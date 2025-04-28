﻿namespace CssInCSharp.Generator.Extensions
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

        public static string ToCssProperty(this string cssName)
        {
            if (string.IsNullOrWhiteSpace(cssName))
                return string.Empty;

            return string.Join("",
                cssName
                    .Trim('-', '_')
                    .Split('-', '_')
                    .Where(part => part.Length > 0)
                    .Select(part => char.ToUpperInvariant(part[0]) + part.Substring(1))
            );
        }

        public static string ToCssCustomProperty(this string cssName)
        {
            return $"--{cssName}";
        }
    }
}
