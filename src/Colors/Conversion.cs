using static CssInCSharp.Colors.Util;

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
                ((int)r).ToString("x2"),
                ((int)g).ToString("x2"),
                ((int)b).ToString("x2"),
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

        public static string RgbaToHex(double r, double g, double b, double a, bool allow4Char)
        {
            return "";
        }

        public static RGB RgbToRgb(StringNumber r, StringNumber g, StringNumber b)
        {
            return new RGB
            {
                R = Bound01(r, 255) * 255,
                G = Bound01(g, 255) * 255,
                B = Bound01(b, 255) * 255,
            };
        }

        public static HSV RgbToHsv(double r, double g, double b)
        {
            return new HSV();
        }

        public static HSL RgbToHsl(double r, double g, double b)
        {
            return new HSL();
        }

        public static RGB HsvToRgb(StringNumber h, StringNumber s, StringNumber v)
        {
            h = Bound01(h, 360) * 6;
            s = Bound01(s, 100);
            v = Bound01(v, 100);
            return new RGB { };
        }

        public static RGB HslToRgb(StringNumber h, StringNumber s, StringNumber l)
        {
            return new RGB();
        }
    }
}
