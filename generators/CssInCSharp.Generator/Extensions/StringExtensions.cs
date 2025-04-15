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

        public static string ToType(this string type)
        {
            switch (type)
            {
                case "double":
                case "bool":
                case "string":
                case "object":
                    return type;
                default: return type.ToPascalCase();
            }
        }

        public static string ToPascalCase(this string input) =>
            input switch
            {
                null => throw new ArgumentNullException(nameof(input)),
                "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
                _ => string.Concat(input[0].ToString().ToUpper(), input.AsSpan(1))
            };
    }
}
