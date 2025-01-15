using System.CommandLine;
using CssInCSharp.Generator;
using RulesEngine.Models;

namespace CssInCSharp.CommandLine
{
    internal class ConvertCommand : Command
    {
        public ConvertCommand() : base("convert", "Convert css file to c#.")
        {
            var configOption = new Option<string>(
                aliases: ["--config", "-c"],
                description: "Specify the configuration file.",
                getDefaultValue: () => "cssincs.json");
            var sourceOption = new Option<string>(
                aliases: ["--source", "-s"],
                description: "Source file path.");
            var destOption = new Option<string>(
                aliases: ["--dest", "-d"],
                description: "Dest file path, Default as same as source file.");
            var typeOption = new Option<ConverterType>(
                aliases: ["--type", "-t"],
                description: "Converter type.");
            var dryRunOption = new Option<bool>(
                aliases: ["--dry-run"],
                description: "Dry run and output code to console.");
            this.Add(configOption);
            this.Add(sourceOption);
            this.Add(destOption);
            this.Add(typeOption);
            this.Add(dryRunOption);
            this.SetHandler(ExecAsync, configOption, typeOption, sourceOption, destOption, dryRunOption);
        }

        private async Task ExecAsync(string configFile, ConverterType type, string src, string dest, bool dryRun)
        {
            var config = new Configuration();
            if (File.Exists(configFile))
            {
                var json = await File.ReadAllTextAsync(configFile);
                config = json.FromJson<Configuration>();
            }
            else if (!string.IsNullOrEmpty(src))
            {
                config.Converter = type;
                config.AddIncludeItem(src, dest);
            }
            else
            {
                Console.WriteLine("`config` or `src` parameter, one must be specified.");
                return;
            }

            var exclude = config.Exclude.SelectMany(x => Util.GetFiles(x));
            var items = config.Include.SelectMany(x => Util.GetFiles(x.Src).Except(exclude), (inc, file) =>
            {
                var global = config.CloneCsOptions();
                if (inc.CsOptions != null)
                {
                    Util.Mapper.Map(inc.CsOptions, global);
                }

                return new IncludeItem
                {
                    Src = file.FullPath,
                    Dest = Util.GetDest(file.Dir, file.FullPath, inc.Dest, ".cs"),
                    CsOptions = global
                }.Update();
            });

            // init rule engine
            InferenceEngine.Initialize(config.TypeInferences);

            foreach (var item in items)
            {
                var converter = ConverterFactory.Create(config.Converter, item.CsOptions);
                var content = await File.ReadAllTextAsync(item.Src);
                var filenName = Path.GetFileName(item.Src);
                Console.WriteLine($"Convert: {item.Src}");
                var code = converter.Convert(content, filenName);
                if (dryRun)
                {
                    Console.WriteLine(code);
                }
                else
                {
                    await Util.WriteAllTextAsync(item.Dest, code);
                }
            }
        }
    }
}
