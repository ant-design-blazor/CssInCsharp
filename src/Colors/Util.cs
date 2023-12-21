﻿using System;
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

        public static StringNumber Bound01(StringNumber n, int max)
        {
            if (IsOnePointZero(n))
            {
                n = "100%";
            }

            var isPercent = IsPercentage(n);
            n = max == 360 ? n : Math.Min(max, Math.Max(0, ParseNumber(n)));

            if (isPercent)
            {
                n = n * max / 100;
            }

            if (Math.Abs(n - max) < 0.000001)
            {
                return 1;
            }

            if (max == 360)
            {
                n = (n < 0 ? (n % max) + max : n % max) / max;
            }
            else
            {
                n = (n % max) / max;
            }

            return n;
        }

        public static bool IsOnePointZero(StringNumber n)
        {
            return n.IsString && n.AsString.IndexOf(".") != -1 && ParseNumber(n) == 1;
        }

        public static string ConvertToPercentage(StringNumber n)
        {
            if (n.IsNumber && n <= 1)
            {
                return $"{n * 100}%";
            }

            return n.AsString;
        }

        public static double BoundAlpha(StringNumber a)
        {
            var n = a.IsNumber ? a.AsNumber : Convert.ToDouble(a.AsString);

            if (n is < 0 or > 1)
            {
                return 1;
            }

            return n;
        }

        public static double ConvertHexToDecimal(string h)
        {
            return ParseIntFromHex(h) / 255;
        }

        public static int ParseIntFromHex(string h)
        {
            return Convert.ToInt32(h, 16);
        }

        public static double ParseNumber(StringNumber n)
        {
            if (n.IsString)
            {
                var str = n.AsString;
                if (IsPercentage(n))
                {
                    str = str.Substring(0, str.Length - 1);
                }

                if (double.TryParse(str, out var r))
                {
                    return r;
                }
            }

            return n.AsNumber;
        }

        public static bool IsPercentage(StringNumber n)
        {
            return n.IsString && n.AsString.IndexOf("%") != -1;
        }

        public static double MathRound(double value)
        {
            return Math.Round(value, MidpointRounding.AwayFromZero);
        }
    }
}
