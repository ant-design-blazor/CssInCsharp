using CssInCSharp.Generator;

namespace CssInCSharp.CommandLine
{
    internal class Configuration
    {
        public CSharpOptions CsOptions { get; set; } = new();

        public List<IncludeItem> Includes { get; set; } = [];

        public void AddIncludeItem(string src, string dest)
        {
            Includes.Add(new IncludeItem
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
