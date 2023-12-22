using System;
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
                ((int)MathRound(r)).ToString("x2"),
                ((int)MathRound(g)).ToString("x2"),
                ((int)MathRound(b)).ToString("x2"),
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
            var hex = new[]
            {
                ((int)MathRound(r)).ToString("x2"),
                ((int)MathRound(g)).ToString("x2"),
                ((int)MathRound(b)).ToString("x2"),
                ((int)MathRound(a * 255)).ToString("x2"),
            };

            if (
                allow4Char &&
                hex[0].StartsWith(hex[0].CharAt(1)) &&
                hex[1].StartsWith(hex[1].CharAt(1)) &&
                hex[2].StartsWith(hex[2].CharAt(1)) &&
                hex[3].StartsWith(hex[3].CharAt(1))
            )
            {
                return hex[0].CharAt(0) + hex[1].CharAt(0) + hex[2].CharAt(0) + hex[3].CharAt(0);
            }

            return hex.Join("");
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
            r = Bound01(r, 255).AsNumber;
            g = Bound01(g, 255).AsNumber;
            b = Bound01(b, 255).AsNumber;

            var max = MathMax(r, g, b);
            var min = MathMin(r, g, b);
            double h = 0;
            var v = max;
            var d = max - min;
            var s = max == 0 ? 0 : d / max;

            if (max == min)
            {
                h = 0; // achromatic
            }
            else
            {
                switch (max)
                {
                    case var _ when max == r:
                        h = (g - b) / d + (g < b ? 6 : 0);
                        break;
                    case var _ when max == g:
                        h = (b - r) / d + 2;
                        break;
                    case var _ when max == b:
                        h = (r - g) / d + 4;
                        break;
                    default:
                        break;
                }

                h /= 6;
            }

            return new HSV(h, s, v);
        }

        public static HSL RgbToHsl(double r, double g, double b)
        {
            r = Bound01(r, 255).AsNumber;
            g = Bound01(g, 255).AsNumber;
            b = Bound01(b, 255).AsNumber;

            var max = MathMax(r, g, b);
            var min = MathMin(r, g, b);
            double h = 0;
            double s = 0;
            var l = (max + min) / 2;

            if (max == min)
            {
                s = 0;
                h = 0; // achromatic
            }
            else
            {
                var d = max - min;
                s = l > 0.5 ? d / (2 - max - min) : d / (max + min);
                switch (max)
                {
                    case var _ when max == r:
                        h = (g - b) / d + (g < b ? 6 : 0);
                        break;
                    case var _ when max == g:
                        h = (b - r) / d + 2;
                        break;
                    case var _ when max == b:
                        h = (r - g) / d + 4;
                        break;
                    default:
                        break;
                }

                h /= 6;
            }

            return new HSL(h, s, l);
        }

        public static RGB HsvToRgb(StringNumber h, StringNumber s, StringNumber v)
        {
            h = Bound01(h, 360) * 6;
            s = Bound01(s, 100);
            v = Bound01(v, 100);
            var i = Math.Floor(h.AsNumber);
            var f = h - i;
            var p = v * (1 - s);
            var q = v * (1 - f * s);
            var t = v * (1 - (1 - f) * s);
            var mod = (int)i % 6;
            var r = new double[] { v.AsNumber, q, p, p, t, v.AsNumber }[mod];
            var g = new double[] { t, v.AsNumber, v.AsNumber, q, p, p }[mod];
            var b = new double[] { p, p, t, v.AsNumber, v.AsNumber, q }[mod];
            return new RGB(r * 255, g * 255, b * 255);
        }

        public static RGB HslToRgb(StringNumber h, StringNumber s, StringNumber l)
        {
            double r;
            double g;
            double b;

            h = Bound01(h, 360);
            s = Bound01(s, 100);
            l = Bound01(l, 100);

            if (s == 0)
            {
                // achromatic
                g = l.AsNumber;
                b = l.AsNumber;
                r = l.AsNumber;
            }
            else
            {
                var q = l < 0.5 ? l * (1 + s) : l + s - l * s;
                var p = 2 * l - q;
                r = Hue2Rgb(p, q, h + 1d / 3);
                g = Hue2Rgb(p, q, h.AsNumber);
                b = Hue2Rgb(p, q, h - 1d / 3);
            }

            return new RGB(r * 255, g * 255, b * 255);
        }

        public static double Hue2Rgb(double p, double q, double t)
        {
            if (t < 0)
            {
                t += 1;
            }
            if (t > 1)
            {
                t -= 1;
            }

            if (t < 1d / 6)
            {
                return p + (q - p) * (6 * t);
            }

            if (t < 1d / 2)
            {
                return q;
            }

            if (t < 2d / 3)
            {
                return p + (q - p) * (2d / 3 - t) * 6;
            }

            return p;
        }
    }
}
