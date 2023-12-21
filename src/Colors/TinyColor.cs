using System;
using static CssInCSharp.Colors.Conversion;
using static CssInCSharp.Colors.Format;
using static CssInCSharp.Colors.Util;

namespace CssInCSharp.Colors
{
    public class TinyColorOptions
    {
        public string Format { get; set; }
        public string GradientType { get; set; }
    }

    public sealed class TinyColor
    {
        private readonly ColorInput _originalInput;
        private double _r;
        private double _g;
        private double _b;
        private double _a;
        private double _roundA;
        private string _format;
        private string _gradientType;
        private bool _isValid;
        public bool IsValid => _isValid;

        public TinyColor(ColorInput color, TinyColorOptions opts = null)
        {
            if (color == null) return;
            if (color.IsNumber)
            {
                color = NumberInputToObject(color.AsNumber);
            }
            _originalInput = color;
            var rgb = InputToRGB(color);
            _r = rgb.R;
            _g = rgb.G;
            _b = rgb.B;
            _a = rgb.A;
            _roundA = MathRound(100 * _a) / 100;
            _format = opts?.Format ?? rgb.Format;
            _gradientType = opts?.GradientType;
            if (_r < 1) _r = MathRound(_r);
            if (_g < 1) _g = MathRound(_g);
            if (_b < 1) _b = MathRound(_b);
            _isValid = rgb.Ok;
        }

        public static TinyColor FromRatio(RatioInput ratio, TinyColorOptions opts = null)
        {
            var newColor = new RGBA()
            {
                R = ConvertToPercentage(ratio.R),
                G = ConvertToPercentage(ratio.G),
                B = ConvertToPercentage(ratio.B),
                A = ratio.A
            };
            return new TinyColor(newColor, opts);
        }

        public bool IsDark()
        {
            return GetBrightness() < 128;
        }

        public bool IsLight()
        {
            return !IsDark();
        }

        public double GetBrightness()
        {
            var rgb = ToRgb();
            return (rgb.R * 299 + rgb.G * 587 + rgb.B * 114) / 1000;
        }

        public double GetLuminance()
        {
            return 0;
        }

        public double GetAlpha()
        {
            return _a;
        }

        public TinyColor SetAlpha(double alpha)
        {
            _a = BoundAlpha(alpha);
            _roundA = MathRound(100 * _a) / 100;
            return this;
        }

        public HSVA ToHsv()
        {
            var hsv = RgbToHsv(_r, _g, _b);
            return new HSVA(hsv.H, hsv.S, hsv.V, _a);
        }

        public string ToHsvString()
        {
            var hsv = RgbToHsv(_r, _g, _b);
            var h = MathRound(hsv.H * 360);
            var s = MathRound(hsv.S * 100);
            var v = MathRound(hsv.V * 100);
            return _a == 1 ? $"hsv({h}, {s}%, {v}%)" : $"hsva({h}, {s}%, {v}%, {_roundA})";
        }

        public HSLA ToHsl()
        {
            var hsl = RgbToHsl(_r, _g, _b);
            return new HSLA(hsl.H, hsl.S, hsl.L, _a);
        }

        public string ToHslString()
        {
            var hsl = RgbToHsl(_r, _g, _b);
            var h = MathRound(hsl.H * 360);
            var s = MathRound(hsl.S * 100);
            var l = MathRound(hsl.L * 100);
            return _a == 1 ? $"hsl({h}, {s}%, {l}%)" : $"hsla({h}, {s}%, {l}%, {_roundA})";
        }

        public string ToHex(bool allow3Char = false)
        {
            return RgbToHex(_r, _g, _b, allow3Char);
        }

        public string ToHexString(bool allow3Char = false)
        {
            return "#" + ToHex(allow3Char);
        }

        public string ToHex8(bool allow4Char = false)
        {
            return RgbaToHex(_r, _g, _b, _a, allow4Char);
        }

        public string ToHex8String(bool allow4Char = false)
        {
            return "#" + ToHex8(allow4Char);
        }

        public string ToHexShortString(bool allowShortChar = false)
        {
            return _a == 1 ? ToHexString(allowShortChar) : ToHex8String(allowShortChar);
        }

        public RGBA ToRgb()
        {
            return new RGBA()
            {
                R = MathRound(_r),
                G = MathRound(_g),
                B = MathRound(_b),
                A = _a,
            };
        }

        public string ToRgbString()
        {
            var r = MathRound(_r);
            var g = MathRound(_g);
            var b = MathRound(_b);
            return _a == 1 ? $"rgb({r}, {g}, {b})" : $"rgba({r}, {g}, {b}, {_roundA})";
        }

        public RGBA ToPercentageRgb()
        {
            var fmt = (double x) => $"{MathRound(Bound01(x, 255) * 100)}%";
            return new RGBA()
            {
                R = fmt(_r),
                G = fmt(_g),
                B = fmt(_b),
                A = _a
            };
        }

        public string ToPercentageRgbString()
        {
            var rnd = (double x) => MathRound(Bound01(x, 255) * 100);
            return _a == 1
                ? $"rgb({rnd(_r)}%, {rnd(_g)}%, {rnd(_b)}%)"
                : $"rgba(${rnd(_r)}%, ${rnd(_g)}%, ${rnd(_b)}%, ${_roundA})";
        }

        public string ToName()
        {
            if (_a ==  0)
            {
                return "transparent";
            }

            if (_a < 0)
            {
                return null;
            }

            var hex = "#" + RgbToHex(_r, _g, _b, false);

            foreach (var item in CssColor.Names)
            {
                if(hex == item.Value)
                    return item.Key;
            }

            return null;
        }

        public override string ToString()
        {
            return ToString(null);
        }

        public string ToString(string format)
        {
            var formatSet = !string.IsNullOrEmpty(format);
            format = formatSet ? format : _format;
            var hasAlpha = _a < 1 && _a >= 0;
            var needsAlphaFormat = !formatSet && hasAlpha && (format.StartsWith("hex") || format == "name");
            if (needsAlphaFormat)
            {
                if (format == "name" && _a == 0)
                {
                    return ToName();
                }

                return ToRgbString();
            }

            return format switch
            {
                "rgb" => ToRgbString(),
                "prgb" => ToPercentageRgbString(),
                "hex" or "hex6" => ToHexString(),
                "hex3" => ToHexString(true),
                "hex4" => ToHex8String(true),
                "hex8" => ToHex8String(),
                "name" => ToName(),
                "hsl" => ToHslString(),
                "hsv" => ToHsvString(),
                _ => ToHexString()
            };
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is string str)
            {
                return ToRgbString() == new TinyColor(str).ToRgbString();
            }

            if (obj is TinyColor color)
            {
                return ToRgbString() == color.ToRgbString();
            }

            return false;
        }
    }
}
