using System;
using System.Linq;
using System.Text;
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
        private double? _max;
        private double? _min;
        private double? _brightness;

        public double R => _r;
        public double G => _g;
        public double B => _b;
        public double A => _a;

        public double this[string key]
        {
            get
            {
                switch (key)
                {
                    case "r": return _r;
                    case "g": return _g;
                    case "b": return _b;
                    case "a": return _a;
                }

                throw new Exception($"Invalid key: {key}");
            }
            set
            {
                switch (key)
                {
                    case "r": _r = value; break;
                    case "g": _g = value; break;
                    case "b": _b = value; break;
                    case "a": _a = value; break;
                }
            }
        }

        public FastColor(ColorInput input)
        {
            if (input == null) return;

            if (input.IsString)
            {
                var trimStr = input.AsString.Trim();
                if (Regex.IsMatch(trimStr, @"^#?[A-F\d]{3,8}$", RegexOptions.IgnoreCase))
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

        public FastColor SetR(double value)
        {
            return _sc("r", value);
        }

        public FastColor SetG(double value)
        {
            return _sc("g", value);
        }

        public FastColor SetB(double value)
        {
            return _sc("b", value);
        }

        public FastColor SetA(double value)
        {
            return _sc("a", value, 1);
        }

        public FastColor SetHue(double value)
        {
            var hsv = ToHsv();
            hsv.H = value;
            return _c(hsv);
        }

        public double GetLuminance()
        {
            double adjustGamma(double raw)
            {
                var val = raw / 255;

                return val <= 0.03928
                    ? val / 12.92
                    : Math.Pow((val + 0.055) / 1.055, 2.4);
            }

            var r = adjustGamma(_r);
            var g = adjustGamma(_g);
            var b = adjustGamma(_b);

            return 0.2126 * r + 0.7152 * g + 0.0722 * b;
        }

        public double GetHue()
        {
            if (!_h.HasValue) {
                var delta = GetMax() - GetMin();
                if (delta == 0)
                {
                    this._h = 0;
                }
                else
                {
                    this._h = Util.MathRound((
                            60 *
                            (_r == GetMax()
                                ? (_g - _b) / delta + (_g < _b ? 6 : 0)
                                : _g == GetMax()
                                    ? (_b - _r) / delta + 2
                                    : (_r - _g) / delta + 4)
                        )
                    );
                }
            }
            return _h.Value;
        }

        public double GetSaturation()
        {
            if (!_s.HasValue) {
                var delta = GetMax() - GetMin();
                if (delta == 0)
                {
                    _s = 0;
                }
                else
                {
                    _s = delta / GetMax();
                }
            }
            return _s.Value;
        }

        public double GetLightness()
        {
            if (!_l.HasValue) {
                _l = (GetMax() + GetMin()) / 510;
            }
            return _l.Value;
        }

        public double GetValue()
        {
            if (!_v.HasValue) {
                _v = GetMax() / 255;
            }
            return _v.Value;
        }

        public double GetBrightness()
        {
            if (!_brightness.HasValue) {
                _brightness = (_r * 299 + _g * 587 + _b * 114) / 1000;
            }
            return _brightness.Value;
        }

        public FastColor Darken(double amount = 10)
        {
            var h = GetHue();
            var s = GetSaturation();
            var l = GetLightness() - amount / 100;
            if (l < 0)
            {
                l = 0;
            }

            return _c(new HSLA { H = h, S = s, L = l, A = _a });
        }

        public FastColor Lighten(double amount = 10)
        {
            var h = GetHue();
            var s = GetSaturation();
            var l = GetLightness() + amount / 100;
            if (l > 1)
            {
                l = 1;
            }

            return _c(new HSLA { H = h, S = s, L = l, A = _a });
        }

        public FastColor Mix(ColorInput input, double amount = 50)
        {
            var color = _c(input);

            var p = amount / 100;
            var calc = (string key) => (color[key] - this[key]) * p + this[key];

            var rgba = new RGBA {
                R = Util.MathRound(calc("r")),
                G = Util.MathRound(calc("g")),
                B = Util.MathRound(calc("b")),
                A = Util.MathRound(calc("a") * 100) / 100,
            };

            return _c(rgba);
        }

        public FastColor Tint(double amount = 10)
        {
            return Mix(new RGBA { R = 255, G = 255, B = 255, A = 1 }, amount);
        }

        public FastColor Shade(double amount = 10)
        {
            return Mix(new RGBA { R = 0, G = 0, B = 0, A = 1 }, amount);
        }

        public FastColor OnBackground(ColorInput background)
        {
            var bg = _c(background);
            var alpha = _a + bg._a * (1 - _a);

            var calc = (string key) => Util.MathRound(
                (this[key] * _a + bg[key] * bg._a * (1 - _a)) / alpha
            );

            return _c(new RGBA{
                R = calc("r"),
                G = calc("g"),
                B = calc("b"),
                A = alpha,
            });
        }

        public bool IsDark() {
            return GetBrightness() < 128;
        }

        public bool IsLight()
        {
            return GetBrightness() >= 128;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is FastColor other)
            {
                return (
                    _r == other._r &&
                    _g == other._g &&
                    _b == other._b &&
                    _a == other._a
                );
            }

            return false;
        }

        public FastColor Clone()
        {
            return _c(this);
        }

        public string ToHexString()
        {
            var hex = new StringBuilder("#");
            var rHex = ((long)_r).ToString("x").PadLeft(2, '0');
            hex.Append(rHex);
            var gHex = ((long)_g).ToString("x").PadLeft(2, '0');
            hex.Append(gHex);
            var bHex = ((long)_b).ToString("x").PadLeft(2, '0');
            hex.Append(bHex);
            if (_a >= 0 && _a< 1)
            {
                var aHex = ((long)Util.MathRound(_a * 255)).ToString("X").PadLeft(2, '0');
                hex.Append(aHex);
            }
            return hex.ToString();
        }

        public HSLA ToHsl()
        {
            return new HSLA
            {
                H = GetHue(),
                S = GetSaturation(),
                L = GetLightness(),
                A = _a,
            };
        }

        public string ToHslString() {
            var h = GetHue();
            var s = Util.MathRound(GetSaturation() * 100);
            var l = Util.MathRound(GetLightness() * 100);
            return _a != 1
                ? $"hsla({h},{s}%,{l}%,{_a})"
                : $"hsl({h},{s}%,{l}%)";
        }

        public HSVA ToHsv()
        {
            return new HSVA
            {
                H = GetHue(),
                S = GetSaturation(),
                V = GetValue(),
                A = _a,
            };
        }

        public RGBA ToRgb()
        {
            return new RGBA
            {
                R = _r,
                G = _g,
                B = _b,
                A = _a,
            };
        }

        public string ToRgbString()
        {
            return _a != 1
                ? $"rgba({_r},{_g},{_b},{_a})"
                : $"rgb({_r},{_g},{_b})";
        }

        public override string ToString()
        {
            return ToRgbString();
        }

        private FastColor _sc(string rgb, double value, double? max = null)
        {
            var clone = Clone();
            clone[rgb] = LimitRange(value, max);
            return clone;
        }

        private FastColor _c(ColorInput input)
        {
            return new FastColor(input);
        }

        private double GetMax()
        {
            if (!_max.HasValue) {
                _max = Util.MathMax(_r, _g, _b);
            }
            return _max.Value;
        }

        private double GetMin()
        {
            if (!_min.HasValue) {
                _min = Util.MathMin(_r, _g, _b);
            }
            return _min.Value;
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
            var cells = SplitColorStr(trimStr, ParseHSVorHSL);
            FromHsl(cells[0], cells[1], cells[2], cells[3]);
        }

        private void FromRgbString(string trimStr)
        {
            var cells = SplitColorStr(trimStr, (num, txt, _) =>
                // Convert percentage to number. e.g. 50% -> 128
                txt.Contains("%") ? Util.MathRound((num / 100) * 255) : num
            );

            _r = cells[0];
            _g = cells[1];
            _b = cells[2];
            _a = cells[3];
        }

        private static double[] SplitColorStr(string str, Func<double, string, int, double> parseNum)
        {
            var match = str
                .RegexReplace(@"^[^(]*\((.*)", "$1")
                .RegexReplace(@"\).*", "")
                .Match(@"\d*\.?\d+%?");
            var numList = match.Select((item) => Util.ParseFloat(item)).ToList();

            for (var i = 0; i < 3; i += 1)
            {
                if (i < numList.Count)
                {
                    numList[i] = parseNum(numList[i], match[i], i);
                }
                else
                {
                    numList.Add(parseNum(0, "", i));
                }
            }

            // For alpha. 50% should be 0.5
            if (match.Length > 3) {
                numList[3] = match[3].Contains('%') ? numList[3] / 100 : numList[3];
            } else
            {
                // By default, alpha is 1
                numList.Add(1);
            }

            return numList.ToArray();
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
