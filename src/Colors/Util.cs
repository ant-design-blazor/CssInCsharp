using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CssInCSharp.Colors
{
    public static class Util
    {
        public static string CharAt(this string str, int index)
        {
            return str[index].ToString();
        }

        public static string RegexReplace(this string str, string pattern, string replacement)
        {
            return Regex.Replace(str, pattern, replacement);
        }

        public static string[] Match(this string str, string pattern)
        {
            return Regex.Matches(str, pattern).Select(x => x.Value).ToArray();
        }

        public static string Join<T>(this IEnumerable<T> values, string separator)
        {
            return string.Join(separator, values);
        }

        public static StringNumber Bound01(StringNumber n, double max)
        {
            if (IsOnePointZero(n))
            {
                n = "100%";
            }

            var isPercent = IsPercentage(n);
            n = max == 360 ? ParseNumber(n) : Math.Min(max, Math.Max(0, ParseNumber(n)));

            if (isPercent)
            {
                n = (int)(n * max) / (double)100;
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
            var d = n.IsNumber ? n.AsNumber : ParseNumber(n);
            if (d <= 1)
            {
                return $"{d * 100}%";
            }

            return n.ToString();
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
            return ParseIntFromHex(h) / (double)255;
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

                return double.NaN;
            }

            return n.AsNumber;
        }

        public static bool IsPercentage(StringNumber n)
        {
            return n.IsString && n.AsString.IndexOf("%") != -1;
        }

        public static double MathRound(double value)
        {
            if (value >= 0)
            {
                return Math.Round(value, MidpointRounding.AwayFromZero);
            }
            else
            {
                /*
                 * js math round method:
                 * Math.round(25.5) -> 26
                 * Math.round(-25.5) -> -25
                 */
                if (IsMidpoint(GetDecimalPlaces(value)))
                {
#if NETSTANDARD2_1
                    return Math.Round(value, MidpointRounding.ToEven);
#else
                    return Math.Round(value, MidpointRounding.ToZero);
#endif
                }
                else
                {
                    return Math.Round(value, MidpointRounding.AwayFromZero);
                }
            }
        }

        public static double MathMax(params double[] values)
        {
            return values.Max();
        }

        public static double MathMin(params double[] values)
        {
            return values.Min();
        }

        public static double Clamp01(double val) {
            return Math.Min(1, Math.Max(0, val));
        }

        public static bool IsMidpoint(double val)
        {
            var i = 0;
            while (i < 16)
            {
                i++;
                var mid = -(5 / Math.Pow(10, i));
                if (val == mid)
                {
                    return true;
                }
            }
            return false;
        }

        public static double GetDecimalPlaces(double val)
        {
            return val - Math.Truncate(val);
        }
    }
}
