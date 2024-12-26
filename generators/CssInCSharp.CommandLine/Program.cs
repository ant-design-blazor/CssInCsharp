using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Help;
using System.CommandLine.Parsing;
using CssInCSharp.CommandLine;
using Spectre.Console;

var returnCode = 0;
var rootCommand = new RootCommand("CssInCSharp")
{
    new InitCommand(),
    new ConvertCommand(),
};
rootCommand.TreatUnmatchedTokensAsErrors = false;
rootCommand.SetHandler((context) =>
{
    if (context.ParseResult.Tokens.Count == 0)
    {
        context.HelpBuilder.Write(rootCommand, Console.Out);
    }
});
var parser = new CommandLineBuilder(rootCommand)
    .UseDefaults()
    .UseHelp(ctx =>
    {
        ctx.HelpBuilder
            .CustomizeLayout(_ => HelpBuilder.Default.GetLayout().Skip(1).Prepend(_ =>
                AnsiConsole.Write(
                    new FigletText(rootCommand.Description!))));
    })
    .Build();
await parser.InvokeAsync(args);
return returnCode;
