using System.Text.RegularExpressions;
using CssInCSharp.Generator;
using CssInCSharp.Generator.Extensions;

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
    }

    internal class IncludeItem
    {
        public string? Src { get; set; }
        public string? Dest { get; set; }
        public CSharpOptions? CsOptions { get; set; }

        public IncludeItem Update()
        {
            if (CsOptions is not { DefaultClassName: not null }) return this;
            var match = Regex.Match(CsOptions.DefaultClassName, @"(\{(dir|file):?(\S*)\})\w*");
            if (!match.Success) return this;
            if (match.Groups.Count < 3) return this;
            if (Dest == null) return this;

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
                CsOptions.DefaultClassName = CsOptions.DefaultClassName.Replace(replace, name);
            }

            return this;
        }
    }
}
