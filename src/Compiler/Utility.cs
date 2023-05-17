using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CssInCs.Compiler
{
    public static class Utility
    {
        public static int CharAt(string value, int index)
        {
            return (int) value[index];
        }

        public static int IndexOf(string value, string search)
        {
            return value.IndexOf(search);
        }

        public static string Replace(string value, string pattern, string replacement, bool all = false)
        {
            if (all)
            {
                return Regex.Replace(value, pattern, replacement);
            }
            else
            {
                // replace first match
                return new Regex(pattern).Replace(value, replacement, 1);
            }
        }

        public static string Trim(string value)
        {
            return value.Trim();
        }

        public static Element Append(Element value, List<Element> array)
        {
            array.Add(value);
            return value;
        }

        public static string From(int code)
        {
            return Convert.ToChar(code).ToString();
        }

        public static int Strlen(string value)
        {
            return value.Length;
        }

        public static string Substr(string value, int begin, int end)
        {
            var len = end - begin;
            if (end < begin)
            {
                if (end >= 0) return string.Empty;
                len = value.Length + end - begin;
            }
            if (value.Length - begin < len)
            {
                len = value.Length - begin;
            }
            if (len <= 0) return string.Empty;
            return value.Substring(begin, len);
        }

        public static int Sizeof<T>(IList<T> value)
        {
            return value.Count;
        }

        public static int Abs(int value)
        {
            return Math.Abs(value);
        }
    }
}
