using System.CommandLine;
using System.Text.Json;
using CssInCSharp.Generator;
using Microsoft.Extensions.FileSystemGlobbing;

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
                config = JsonSerializer.Deserialize<Configuration>(json)!;
            }
            else if (!string.IsNullOrEmpty(src))
            {
                config.AddIncludeItem(src, dest);
            }
            else
            {
                Console.WriteLine("`cssincs.json` file or `src` parameter, one must be specified.");
                return;
            }

            var items = new List<IncludeItem>();
            foreach (var inc in config.Includes)
            {
                var (dir, files) = Util.GetFiles(inc.Src);
                foreach (var file in files)
                {
                    items.Add(new IncludeItem
                    {
                        Src = file,
                        Dest = Util.GetDest(dir, file, inc.Dest, ".cs"),
                        CsOptions = inc.CsOptions ?? config.CsOptions
                    });
                }
            }

            foreach (var item in items)
            {
                var converter = ConverterFactory.Create(type, item.CsOptions);
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

    public static class Util
    {
        public static async Task WriteAllTextAsync(string path, string content)
        {
            var destDir = Path.GetDirectoryName(path);
            if (!Directory.Exists(destDir))
            {
                Directory.CreateDirectory(destDir);
            }
            await File.WriteAllTextAsync(path, content);
        }

        public static (string, string[]) GetFiles(string path)
        {
            path = Path.GetFullPath(path);
            var dir = "";
            var pattern = "";
            var index = path.IndexOf("*");
            if (index > 0)
            {
                dir = path.Substring(0, index);
                pattern = path.Substring(index);
            }
            else
            {
                dir = Path.GetDirectoryName(path);
                pattern = path.Substring(dir.Length + 1);
            }
            var matcher = new Matcher();
            matcher.AddInclude(pattern);
            return (dir, matcher.GetResultsInFullPath(dir).ToArray());
        }

        public static string GetDest(string dir, string file, string dest, string ext)
        {
            if (!string.IsNullOrEmpty(dest) && !IsFolder(dest)) return Path.GetFullPath(dest);
            dest = Path.GetFullPath(dest ?? dir);
            var destFile = Path.Combine(dest, file.Substring(dir.Length));
            var destFolder = Path.GetDirectoryName(destFile);
            var destFileName = Path.GetFileNameWithoutExtension(destFile);
            return Path.Combine(destFolder, destFileName + ext);
        }

        public static bool IsFolder(string path)
        {
            var attr = File.GetAttributes(path);
            return (attr & FileAttributes.Directory) == FileAttributes.Directory;
        }
    }
}
