using System;
using System.Text.RegularExpressions;
using static CssInCSharp.Colors.Conversion;
using static CssInCSharp.Colors.Util;

namespace CssInCSharp.Colors
{
    public record struct RGBFormat(double R, double G, double B, double A, string Format, bool Ok);

    public struct StringNumber
    {
        private readonly int _index;
        private readonly string _value0;
        private readonly double _value1;

        private StringNumber(int index, string value0 = default, double value1 = default)
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
        }

        public static implicit operator StringNumber(string value) => new(0, value0: value);
        public static implicit operator StringNumber(double value) => new(1, value1: value);
        public static double operator +(StringNumber a, double b) => a._value1 + b;
        public static double operator +(double a, StringNumber b) => a + b._value1;
        public static double operator +(StringNumber a, StringNumber b) => a._value1 + b._value1;
        public static double operator -(StringNumber a, double b) => a._value1 - b;
        public static double operator -(double a, StringNumber b) => a - b._value1;
        public static double operator -(StringNumber a, StringNumber b) => a._value1 - b._value1;
        public static double operator *(StringNumber a, double b) => a._value1 * b;
        public static double operator *(double a, StringNumber b) => a * b._value1;
        public static double operator *(StringNumber a, StringNumber b) => a._value1 * b._value1;
        public static double operator /(StringNumber a, double b) => a._value1 / b;
        public static double operator %(StringNumber a, double b) => a._value1 % b;
        public static bool operator <(StringNumber a, double b) => a._value1 < b;
        public static bool operator >(StringNumber a, double b) => a._value1 > b;
        public static bool operator <=(StringNumber a, double b) => a._value1 <= b;
        public static bool operator >=(StringNumber a, double b) => a._value1 >= b;
        public static bool operator ==(StringNumber a, double b) => a._value1 == b;
        public static bool operator !=(StringNumber a, double b) => a._value1 != b;

        public bool IsString => _index == 0;
        public bool IsNumber => _index == 1;

        public string AsString =>
            _index == 0 ?
                _value0 :
                throw new InvalidOperationException();

        public double AsNumber =>
            _index == 1 ?
                _value1 :
                throw new InvalidOperationException();

        public string SubStr(int startIndex)
        {
            if (_index != 0) return string.Empty;
            var index = startIndex < 0 ? _value0.Length + startIndex : _index;
            return _value0.Substring(index);
        }

        public override string ToString()
        {
            return _index switch
            {
                0 => _value0 ?? string.Empty,
                1 => _value1.ToString(),
                _ => string.Empty
            };
        }
    }

    internal static class Format
    {
        public static class Matchers
        {
            public const string CSS_INTEGER = @"[-\+]?\d+%?";
            public const string CSS_NUMBER = @"[-\+]?\d*\.\d+%?";
            public const string CSS_UNIT = $"(?:{CSS_NUMBER})|(?:{CSS_INTEGER})";
            public const string PERMISSIVE_MATCH3 = @$"[\s|\(]+({CSS_UNIT})[,|\s]+({CSS_UNIT})[,|\s]+({CSS_UNIT})\s*\)?";
            public const string PERMISSIVE_MATCH4 = @$"[\s|\(]+({CSS_UNIT})[,|\s]+({CSS_UNIT})[,|\s]+({CSS_UNIT})[,|\s]+({CSS_UNIT})\s*\)?";
            public static readonly Regex Unit = new(CSS_UNIT);
            public static readonly Regex Rgb = new("rgb" + PERMISSIVE_MATCH3);
            public static readonly Regex Rgba = new("rgba" + PERMISSIVE_MATCH4);
            public static readonly Regex Hsl = new("hsl" + PERMISSIVE_MATCH3);
            public static readonly Regex Hsla = new("hsla" + PERMISSIVE_MATCH4);
            public static readonly Regex Hsv = new("hsv" + PERMISSIVE_MATCH3);
            public static readonly Regex Hsva = new("hsva" + PERMISSIVE_MATCH4);
            public static readonly Regex Hex3 = new("^#?([0-9a-fA-F]{1})([0-9a-fA-F]{1})([0-9a-fA-F]{1})$");
            public static readonly Regex Hex6 = new("^#?([0-9a-fA-F]{2})([0-9a-fA-F]{2})([0-9a-fA-F]{2})$");
            public static readonly Regex Hex4 = new("^#?([0-9a-fA-F]{1})([0-9a-fA-F]{1})([0-9a-fA-F]{1})([0-9a-fA-F]{1})$");
            public static readonly Regex Hex8 = new("^#?([0-9a-fA-F]{2})([0-9a-fA-F]{2})([0-9a-fA-F]{2})([0-9a-fA-F]{2})$");
        }

        public static RGBFormat InputToRGB(ColorInput color)
        {
            var rgb = new RGB(0, 0, 0);
            double a = 1;
            var ok = false;
            var format = string.Empty;
            StringNumber s;
            StringNumber v;
            StringNumber l;
            if (color.IsString)
            {
                color = StringInputToObject(color.AsString);
                if (color == null) return new RGBFormat();
            }

            if (color.IsObject)
            {
                if (IsValidCSSUnit(color.R) && IsValidCSSUnit(color.G) && IsValidCSSUnit(color.B))
                {
                    rgb = RgbToRgb(color.R, color.G, color.B);
                    ok = true;
                    format = color.R.SubStr(-1) == "%" ? "prgb" : "rgb";
                } 
                else if (IsValidCSSUnit(color.H) && IsValidCSSUnit(color.S) && IsValidCSSUnit(color.V))
                {
                    s = ConvertToPercentage(color.S);
                    v = ConvertToPercentage(color.V);
                    rgb = HsvToRgb(color.H, s, v);
                    ok = true;
                    format = "hsv";
                }
                else if (IsValidCSSUnit(color.H) && IsValidCSSUnit(color.S) && IsValidCSSUnit(color.L))
                {
                    s = ConvertToPercentage(color.S);
                    l = ConvertToPercentage(color.L);
                    rgb = HslToRgb(color.H, s, l);
                    ok = true;
                    format = "hsl";
                }

                if (color.A.HasValue)
                {
                    if (color.A.Value.IsNumber)
                    {
                        a = color.A.Value.AsNumber;
                    }
                    else
                    {
                        var n = ParseNumber(color.A.Value);
                        if (!double.IsNaN(n))
                        {
                            a = n;
                        }
                    }
                }
            }

            a = BoundAlpha(a);

            return new RGBFormat
            {
                Ok = ok,
                Format = color.Format ?? format,
                R = Math.Min(255, Math.Max(rgb.R.AsNumber, 0)),
                G = Math.Min(255, Math.Max(rgb.G.AsNumber, 0)),
                B = Math.Min(255, Math.Max(rgb.B.AsNumber, 0)),
                A = a,
            };
        }

        public static ColorInput StringInputToObject(string color)
        {
            color = color.Trim().ToLower();
            var named = false;
            if (CssColor.Names.TryGetValue(color, out var name))
            {
                color = name;
                named = true;
            }
            else if (color == "transparent")
            {
                return new ColorInput { R = 0, G = 0, B = 0, A = 0, Format = "name" };
            }

            var match = Matchers.Rgb.Match(color);
            if (match.Success)
            {
                return new ColorInput
                {
                    R = match.Groups[1].Value, 
                    G = match.Groups[2].Value, 
                    B = match.Groups[3].Value
                };
            }

            match = Matchers.Rgba.Match(color);
            if (match.Success)
            {
                return new ColorInput
                {
                    R = match.Groups[1].Value, 
                    G = match.Groups[2].Value, 
                    B = match.Groups[3].Value,
                    A = match.Groups[4].Value
                };
            }

            match = Matchers.Hsl.Match(color);
            if (match.Success)
            {
                return new ColorInput
                {
                    H = match.Groups[1].Value,
                    S = match.Groups[2].Value,
                    L = match.Groups[3].Value
                };
            }

            match = Matchers.Hsla.Match(color);
            if (match.Success)
            {
                return new ColorInput
                {
                    H = match.Groups[1].Value,
                    S = match.Groups[2].Value,
                    L = match.Groups[3].Value,
                    A = match.Groups[4].Value
                };
            }

            match = Matchers.Hsv.Match(color);
            if (match.Success)
            {
                return new ColorInput
                {
                    H = match.Groups[1].Value,
                    S = match.Groups[2].Value,
                    V = match.Groups[3].Value
                };
            }

            match = Matchers.Hsva.Match(color);
            if (match.Success)
            {
                return new ColorInput
                {
                    H = match.Groups[1].Value,
                    S = match.Groups[2].Value,
                    V = match.Groups[3].Value,
                    A = match.Groups[4].Value
                };
            }

            match = Matchers.Hex8.Match(color);
            if (match.Success)
            {
                return new ColorInput
                {
                    R = ParseIntFromHex(match.Groups[1].Value),
                    G = ParseIntFromHex(match.Groups[2].Value),
                    B = ParseIntFromHex(match.Groups[3].Value),
                    A = ConvertHexToDecimal(match.Groups[4].Value),
                    Format = named ? "name" : "hex8",
                };
            }

            match = Matchers.Hex6.Match(color);
            if (match.Success)
            {
                return new ColorInput
                {
                    R = ParseIntFromHex(match.Groups[1].Value),
                    G = ParseIntFromHex(match.Groups[2].Value),
                    B = ParseIntFromHex(match.Groups[3].Value),
                    Format = named ? "name" : "hex",
                };
            }

            match = Matchers.Hex4.Match(color);
            if (match.Success)
            {
                return new ColorInput
                {
                    R = ParseIntFromHex(match.Groups[1].Value + match.Groups[1].Value),
                    G = ParseIntFromHex(match.Groups[2].Value + match.Groups[2].Value),
                    B = ParseIntFromHex(match.Groups[3].Value + match.Groups[3].Value),
                    A = ConvertHexToDecimal(match.Groups[4].Value + match.Groups[4].Value),
                    Format = named ? "name" : "hex8",
                };
            }

            match = Matchers.Hex3.Match(color);
            if (match.Success)
            {
                return new ColorInput
                {
                    R = ParseIntFromHex(match.Groups[1].Value + match.Groups[1].Value),
                    G = ParseIntFromHex(match.Groups[2].Value + match.Groups[2].Value),
                    B = ParseIntFromHex(match.Groups[3].Value + match.Groups[3].Value),
                    Format = named ? "name" : "hex",
                };
            }

            return null;
        }

        public static bool IsValidCSSUnit(StringNumber color)
        {
            return Matchers.Unit.IsMatch(color.ToString());
        }
    }
}
