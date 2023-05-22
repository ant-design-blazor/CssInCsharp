// See https://aka.ms/new-console-template for more information

// while (Console.ReadLine() != "quit")
// {
//     var css = Styles.BenchmarkCss.ToString();
//     Console.WriteLine(css);
//     Console.WriteLine();
// }

using CssInCs;

var css = Styles.Selectors_I;
Console.WriteLine(css.ToString());

Console.ReadLine();