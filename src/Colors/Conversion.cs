using System;

namespace CssInCSharp.Colors
{
    internal static class Conversion
    {
        public static RGB NumberInputToObject(int color)
        {
            return new RGB(color >> 16, (color & 0xFF00) >> 8, color & 0xFF);
        }

        public static string RgbToHex(double r, double g, double b, bool allow3Char)
        {
            var hex = new []
            {
                Math.Round(r).ToString("X2"),
                Math.Round(g).ToString("X2"),
                Math.Round(b).ToString("X2"),
            };

            if (allow3Char &&
                hex[0].StartsWith(hex[0].CharAt(1)) &&
                hex[1].StartsWith(hex[1].CharAt(1)) &&
                hex[2].StartsWith(hex[2].CharAt(1))
               )
            {
                return hex[0].CharAt(0) + hex[1].CharAt(0) + hex[2].CharAt(0);
            }

            return hex.Join("");
        }

        public static RGB RgbToRgb(StringNumber r, StringNumber g, StringNumber b)
        {
            return new RGB();
        }
    }
}
