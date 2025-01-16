using System.Text.RegularExpressions;
using CssInCSharp.Generator;
using RulesEngine.Models;

namespace CssInCSharp.CommandLine
{
    internal class Configuration
    {
        public ConverterType Converter { get; set; } = ConverterType.Ts;

        public CSharpOptions CsOptions { get; set; } = new();

        public List<IncludeItem> Include { get; set; } = [];

        public List<string> Exclude { get; set; } = [];

        public List<Rule> TypeInferences { get; set; } = [];

        public void AddIncludeItem(string src, string dest)
        {
            Include.Add(new IncludeItem
            {
                Src = src,
                Dest = dest
            });
        }

        public CSharpOptions CloneCsOptions()
        {
            return Util.Mapper.Map(CsOptions, new CSharpOptions());
        }
    }

    internal class IncludeItem
    {
        public string? Src { get; set; }
        public string? Dest { get; set; }
        public CSharpOptions? CsOptions { get; set; }

        public IncludeItem Update()
        {
            UpdateNamePrefix();
            UpdateDefaultClassName();
            UpdateDefaultExportMethodName();
            CsOptions?.SetContextVariables();
            return this;
        }

        private void UpdateNamePrefix()
        {
            if (CsOptions is not { NamePrefix: not null }) return;
            var name = ParseName(CsOptions.NamePrefix);
            if (!string.IsNullOrEmpty(name))
            {
                CsOptions.NamePrefix = Util.PurifyFileName(name);
            }
        }

        private void UpdateDefaultClassName()
        {
            if (CsOptions is not { DefaultExportClassName: not null }) return;
            var name = ParseName(CsOptions.DefaultExportClassName);
            if (!string.IsNullOrEmpty(name))
            {
                CsOptions.DefaultExportClassName = Util.PurifyFileName(name);
            }
        }

        private void UpdateDefaultExportMethodName()
        {
            if (CsOptions is not { DefaultExportMethodName: not null }) return;
            var name = ParseName(CsOptions.DefaultExportMethodName);
            if (!string.IsNullOrEmpty(name))
            {
                CsOptions.DefaultExportMethodName = Util.PurifyFileName(name);
            }
        }

        private string? ParseName(string option)
        {
            var match = Regex.Match(option, @"(\{(dir|file):?(\S*)\})\w*");
            if (!match.Success) return null;
            if (match.Groups.Count < 3) return null;
            if (Dest == null) return null;

            var replace = match.Groups[1].Value;
            var type = match.Groups[2].Value;
            var param = match.Groups[3].Value;

            string name;
            if (type == "dir")
            {
                var dir = Path.GetDirectoryName(Dest)!;
                if (!string.IsNullOrEmpty(param))
                {
                    dir = Path.GetDirectoryName(Path.GetFullPath(Path.Join(Dest, param)));
                }

                name = Path.GetFileName(dir);
            }
            else
            {
                name = Path.GetFileNameWithoutExtension(Dest);
            }

            if (!string.IsNullOrEmpty(name))
            {
                name = option.Replace(replace, name);
            }
            return name;
        }
    }
}
