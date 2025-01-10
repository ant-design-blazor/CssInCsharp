using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CssInCSharp.Colors
{
    public sealed class FastColor
    {
        public double _r = 0;
        public double _g = 0;
        public double _b = 0;
        public double _a = 1;
        public double? _h;
        public double? _s;
        public double? _l;
        public double? _v;

        public FastColor(ColorInput input)
        {
            if (input == null) return;

            if (input.IsString)
            {
                var trimStr = input.AsString.Trim();
                if (Regex.IsMatch(trimStr, @"^#?[A-F\d]{3,8}$"))
                {
                    FromHexString(trimStr);
                } 
                else if (trimStr.StartsWith("rgb"))
                {
                    FromRgbString(trimStr);
                }
                else if (trimStr.StartsWith("hsl"))
                {
                    FromHslString(trimStr);
                }
                else if (trimStr.StartsWith("hsv") || trimStr.StartsWith("hsb"))
                {
                    FromHsvString(trimStr);
                }
            }
            else if (input.IsFastColor)
            {
                var color = input.AsFastColor;
                _r = color._r;
                _g = color._g;
                _b = color._b;
                _a = color._a;
                _h = color._h;
                _s = color._s;
                _l = color._l;
                _v = color._v;
            }
            else if (input.Is("rgb"))
            {
                _r = LimitRange(input.R.AsNumber);
                _g = LimitRange(input.G.AsNumber);
                _b = LimitRange(input.B.AsNumber);
                _a = input.A is { IsNumber: true } ? LimitRange(input.A.Value.AsNumber) : 1;
            }
            else if (input.Is("hsl"))
            {
                FromHsl(input.H.AsNumber, input.S.AsNumber, input.L.AsNumber, input.A);
            }
            else if (input.Is("hsv"))
            {
                FromHsv(input.H.AsNumber, input.S.AsNumber, input.V.AsNumber, input.A);
            }
            else
            {
                throw new Exception("");
            }
        }

        private void FromHexString(string trimStr)
        {
            var withoutPrefix = trimStr.Replace("#", "");
            double connectNum(int index1, int? index2 = null)
            {
                return Convert.ToInt32($"{withoutPrefix[index1]}{withoutPrefix[index2 ?? index1]}", 16);
            }
            
            if (withoutPrefix.Length < 6)
            {
                _r = connectNum(0);
                _g = connectNum(1);
                _b = connectNum(2);
                _a = withoutPrefix.Length > 3 ? connectNum(3) / 255 : 1;
            }
            else
            {
                _r = connectNum(0, 1);
                _g = connectNum(2, 3);
                _b = connectNum(4, 5);
                _a = withoutPrefix.Length > 6 ? connectNum(6, 7) / 255 : 1;
            }
        }

        private void FromHsl(double h, double s, double l, StringNumber? a)
        {
            _h = h % 360;
            _s = s;
            _l = l;
            _a = a is { IsNumber: true } ? a.Value.AsNumber : 1;

            if (s <= 0)
            {
                var rgb = Util.MathRound(l * 255);
                _r = rgb;
                _g = rgb;
                _b = rgb;
            }

            double r = 0, g = 0, b = 0;
            var huePrime = h / 60;
            var chroma = (1 - Math.Abs(2 * l - 1)) * s;
            var secondComponent = chroma * (1 - Math.Abs((huePrime % 2) - 1));

            if (huePrime >= 0 && huePrime < 1)
            {
                r = chroma;
                g = secondComponent;
            }
            else if (huePrime >= 1 && huePrime < 2)
            {
                r = secondComponent;
                g = chroma;
            }
            else if (huePrime >= 2 && huePrime < 3)
            {
                g = chroma;
                b = secondComponent;
            }
            else if (huePrime >= 3 && huePrime < 4)
            {
                g = secondComponent;
                b = chroma;
            }
            else if (huePrime >= 4 && huePrime < 5)
            {
                r = secondComponent;
                b = chroma;
            }
            else if (huePrime >= 5 && huePrime < 6)
            {
                r = chroma;
                b = secondComponent;
            }

            var lightnessModification = l - chroma / 2;
            _r = Util.MathRound((r + lightnessModification) * 255);
            _g = Util.MathRound((g + lightnessModification) * 255);
            _b = Util.MathRound((b + lightnessModification) * 255);
        }

        private void FromHsv(double h, double s, double v, StringNumber? a)
        {
            _h = h % 360;
            _s = s;
            _v = v;
            _a = a is { IsNumber: true } ? a.Value.AsNumber : 1;

            var vv = Util.MathRound(v * 255);
            _r = vv;
            _g = vv;
            _b = vv;

            if (s <= 0)
            {
                return;
            }

            var hh = h / 60;
            var i = Math.Floor(hh);
            var ff = hh - i;
            var p = Util.MathRound(v * (1.0 - s) * 255);
            var q = Util.MathRound(v * (1.0 - s * ff) * 255);
            var t = Util.MathRound(v * (1.0 - s * (1.0 - ff)) * 255);

            switch (i)
            {
                case 0:
                    _g = t;
                    _b = p;
                    break;
                case 1:
                    _r = q;
                    _b = p;
                    break;
                case 2:
                    _r = p;
                    _b = t;
                    break;
                case 3:
                    _r = p;
                    _g = q;
                    break;
                case 4:
                    _r = t;
                    _g = p;
                    break;
                case 5:
                default:
                    _g = p;
                    _b = q;
                    break;
            }
        }

        private void FromHsvString(string trimStr)
        {
            var cells = SplitColorStr(trimStr, ParseHSVorHSL);

            FromHsv(cells[0], cells[1], cells[2], cells[3]);
        }

        private void FromHslString(string trimStr)
        {

        }

        private void FromRgbString(string trimStr)
        {
            
        }

        private static double[] SplitColorStr(string str, Func<double, string, int, double> parseNum)
        {
            var match = str
                .RegexReplace(@"^[^(]*\((.*)", "$1")
                .RegexReplace(@"\).*", "")
                .Match(@"\d*\.?\d+%?");
            var numList = match.Select((item) => Convert.ToDouble(item)).ToArray();

            for (var i = 0; i < 3; i += 1)
            {
                numList[i] = parseNum(numList[i], match[i], i);
            }

            // For alpha. 50% should be 0.5
            if (match.Length > 3) {
                numList[3] = match[3].Contains('%') ? numList[3] / 100 : numList[3];
            } else
            {
                // By default, alpha is 1
                numList[3] = 1;
            }

            return numList;
        }

        private static double ParseHSVorHSL(double num, string text, int index)
        {
            return index == 0 ? num : num / 100;
        }

        private static double LimitRange(double value, double? max = null)
        {
            var mergedMax = max ?? 255;
            if (value > mergedMax)
            {
                return mergedMax;
            }
            if (value < 0)
            {
                return 0;
            }
            return value;
        }
    }
}
