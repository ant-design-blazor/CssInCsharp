using System.CommandLine;

namespace CssInCSharp.CommandLine
{
    internal class MinifyCommand : Command
    {
        public MinifyCommand() : base("minify", "Minify css file.")
        {
            Add(new Option<string>(
                aliases: ["--source", "-s"],
                description: "Source file path."));
            Add(new Option<string>(
                aliases: ["--dest", "-d"],
                description: "Dest file path, Default as same as source file."));
        }
    }
}
