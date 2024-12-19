namespace CssInCSharp.Generator.Extensions
{
    internal static class StringExtensions
    {
        public static string FormatValue(this string str)
        {
            // todo:
            return str.Trim('\'');
        }

        public static string Purify(this string str)
        {
            return str.Trim('\'');
        }
    }
}
