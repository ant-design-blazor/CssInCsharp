using System.CommandLine;
using System.CommandLine.Binding;
using CssInCSharp.Generator;

namespace CssInCSharp.CommandLine
{
    internal class ConvertCommand : Command
    {
        public ConvertCommand() : base("convert", "Convert css file to c#.")
        {
            var sourceOption = new Option<string>(
                aliases: ["--source", "-s"],
                description: "Source file path.");
            var destOption = new Option<string>(
                aliases: ["--dest", "-d"],
                description: "Dest file path, Default as same as source file.");
            var typeOption = new Option<ConvertType>(
                aliases: ["--type", "-t"],
                description: "Converter type.");
            var dryRunOption = new Option<bool>(
                aliases: ["--dry-run"],
                description: "Dry run and output code to console.");
            Add(sourceOption);
            Add(destOption);
            Add(typeOption);
            Add(dryRunOption);
            this.SetHandler(ExecAsync, new ConverterBinder(typeOption), sourceOption, destOption, dryRunOption);
        }

        public async Task ExecAsync(IConverter converter, string source, string dest, bool dryRun)
        {
            if (!File.Exists(source))
            {
                return;
            }
            var fileName = Path.GetFileName(source);
            var fileContent = await File.ReadAllTextAsync(source);
            var code = converter.Convert(fileContent, fileName);

            if (dryRun)
            {
                Console.WriteLine(code);
            }
            else
            {
                if (string.IsNullOrEmpty(dest))
                {
                    var destFile = Path.GetFileNameWithoutExtension(source) + ".cs";
                    dest = Path.Combine(Path.GetDirectoryName(source)!, destFile);
                }

                await File.WriteAllTextAsync(dest, code);
            }
        }
    }

    internal class ConverterBinder : BinderBase<IConverter>
    {
        private readonly Option<ConvertType> _typeOption;

        public ConverterBinder(Option<ConvertType> typeOption)
        {
            _typeOption = typeOption;
        }

        protected override IConverter GetBoundValue(BindingContext bindingContext)
        {
            var value = bindingContext.ParseResult.GetValueForOption(_typeOption);
            return value switch
            {
                ConvertType.Ts => new TypeScriptConverter(),
                ConvertType.Sass => new DefaultConverter(),
                ConvertType.Less => new DefaultConverter(),
                ConvertType.Css => new DefaultConverter(),
                _ => new DefaultConverter()
            };
        }
    }

}
