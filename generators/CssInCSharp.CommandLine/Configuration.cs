using System.Text.Json;
using System.Text.RegularExpressions;
using CssInCSharp.Generator;

namespace CssInCSharp.CommandLine
{
    internal class Configuration
    {
        public CSharpOptions CsOptions { get; set; } = new();

        public List<IncludeItem> Include { get; set; } = [];

        public List<string> Exclude { get; set; } = [];

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
            return JsonSerializer.Deserialize<CSharpOptions>(JsonSerializer.Serialize(CsOptions));
        }
    }

    internal class IncludeItem
    {
        public string? Src { get; set; }
        public string? Dest { get; set; }
        public CSharpOptions? CsOptions { get; set; }

        public IncludeItem Update()
        {
            UpdateDefaultClassName();
            UpdateDefaultExportMethodName();
            return this;
        }

        private void UpdateDefaultClassName()
        {
            if (CsOptions is not { DefaultClassName: not null }) return;
            var name = ParseName(CsOptions.DefaultClassName);
            if (!string.IsNullOrEmpty(name))
            {
                CsOptions.DefaultClassName = Util.PurifyFileName(name);
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
