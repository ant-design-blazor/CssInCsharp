using System.Collections.Generic;

namespace CssInCSharp.Colors
{
    internal static class Util
    {
        public static string CharAt(this string str, int index)
        {
            return str[index].ToString();
        }

        public static string Join<T>(this IEnumerable<T> values, string separator)
        {
            return string.Join(separator, values);
        }
    }
}
