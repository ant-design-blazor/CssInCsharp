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
    }

    internal class IncludeItem
    {
        public string? Src { get; set; }
        public string? Dest { get; set; }
        public CSharpOptions? CsOptions { get; set; }
    }
}
