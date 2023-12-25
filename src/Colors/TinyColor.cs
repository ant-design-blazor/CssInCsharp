using System;
using System.Collections.Generic;
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
        public string Format => _format;
        public double A => _a;

        public TinyColor(ColorInput color = null, TinyColorOptions opts = null)
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

        public static TinyColor LegacyRandom()
        {
            var random = new Random();
            return new TinyColor(new RGB
            {
                R = random.Next(),
                G = random.Next(),
                B = random.Next(),
            });
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
            var rgb = ToRgb();
            double r, g, b;
            var rsRGB = rgb.R / 255;
            var gsRGB = rgb.G / 255;
            var bsRGB = rgb.B / 255;

            if (rsRGB <= 0.03928)
            {
                r = rsRGB / 12.92;
            }
            else
            {
                r = Math.Pow((rsRGB + 0.055) / 1.055, 2.4);
            }

            if (gsRGB <= 0.03928)
            {
                g = gsRGB / 12.92;
            }
            else
            {
                g = Math.Pow((gsRGB + 0.055) / 1.055, 2.4);
            }

            if (bsRGB <= 0.03928)
            {
                b = bsRGB / 12.92;
            }
            else
            {
                b = Math.Pow((bsRGB + 0.055) / 1.055, 2.4);
            }

            return 0.2126 * r + 0.7152 * g + 0.0722 * b;
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
            return new HSLA(hsl.H * 360, hsl.S, hsl.L, _a);
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

            if (_a < 1)
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

            var formattedString = format switch
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
            return string.IsNullOrEmpty(formattedString) ? ToHexString() : formattedString;
        }

        public double ToNumber()
        {
            return ((int)MathRound(_r) << 16) + ((int)MathRound(_g) << 8) + MathRound(_b);
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

        // todo: move below into extensions
        public TinyColor Clone()
        {
            return new TinyColor(ToString());
        }

        public TinyColor Lighten(double amount = 10)
        {
            var hsl = ToHsl();
            hsl.L += amount / 100;
            hsl.L = Clamp01(hsl.L.AsNumber);
            return new TinyColor(hsl);
        }

        public TinyColor Brighten(double amount = 10)
        {
            var rgb = ToRgb();
            rgb.R = Math.Max(0, Math.Min(255, rgb.R - MathRound(255 * -(amount / 100))));
            rgb.G = Math.Max(0, Math.Min(255, rgb.G - MathRound(255 * -(amount / 100))));
            rgb.B = Math.Max(0, Math.Min(255, rgb.B - MathRound(255 * -(amount / 100))));
            return new TinyColor(rgb);
        }

        public TinyColor Darken(double amount = 10)
        {
            var hsl = ToHsl();
            hsl.L -= amount / 100;
            hsl.L = Clamp01(hsl.L.AsNumber);
            return new TinyColor(hsl);
        }

        public TinyColor Tint(double amount = 10)
        {
            return Mix("white", amount);
        }

        public TinyColor Shade(double amount = 10)
        {
            return Mix("black", amount);
        }

        public TinyColor Desaturate(double amount = 10)
        {
            var hsl = this.ToHsl();
            hsl.S -= amount / 100;
            hsl.S = Clamp01(hsl.S.AsNumber);
            return new TinyColor(hsl);
        }

        public TinyColor Saturate(double amount = 10)
        {
            var hsl = ToHsl();
            hsl.S += amount / 100;
            hsl.S = Clamp01(hsl.S.AsNumber);
            return new TinyColor(hsl);
        }

        public TinyColor Greyscale()
        {
            return Desaturate(100);
        }

        public TinyColor Spin(double amount = 10)
        {
            var hsl = ToHsl();
            var hue = (hsl.H + amount) % 360;
            hsl.H = hue < 0 ? 360 + hue : hue;
            return new TinyColor(hsl);
        }

        public TinyColor Mix(ColorInput color, double amount = 50)
        {
            var rgb1 = ToRgb();
            var rgb2 = new TinyColor(color).ToRgb();

            var p = amount / 100;
            var rgba = new RGBA
            {
                R = (rgb2.R - rgb1.R) * p + rgb1.R,
                G = (rgb2.G - rgb1.G) * p + rgb1.G,
                B = (rgb2.B - rgb1.B) * p + rgb1.B,
                A = (rgb2.A - rgb1.A) * p + rgb1.A,
            };

            return new TinyColor(rgba);
        }

        public TinyColor[] Analogous(double results = 6, double slices = 30)
        {
            var hsl = ToHsl();
            var part = 360 / slices;
            var ret = new List<TinyColor>() { this };
            for (hsl.H = (hsl.H - ((int)(part * results) >> 1) + 720) % 360; results > 1; --results)
            {
                hsl.H = (hsl.H + part) % 360;
                ret.Add(new TinyColor(hsl));
            }

            return ret.ToArray();
        }

        public TinyColor Complement()
        {
            var hsl = ToHsl();
            hsl.H = (hsl.H + 180) % 360;
            return new TinyColor(hsl);
        }

        public TinyColor[] Monochromatic(double results = 6)
        {
            var hsv = ToHsv();
            var h  = hsv.H;
            var s  = hsv.S;
            var v = hsv.V;
            var res = new List<TinyColor>();
            var modification = 1 / results;

            while (results-- > 0)
            {
                res.Add(new TinyColor(new HSV(h, s, v)));
                v = (v + modification) % 1;
            }

            return res.ToArray();
        }

        public TinyColor[] Splitcomplement()
        {
            var hsl = ToHsl();
            var h = hsl.H;
            return new []
            {
                this,
                new TinyColor(new HSL((h + 72) % 360, hsl.S, hsl.L)),
                new TinyColor(new HSL((h + 216) % 360, hsl.S, hsl.L)),
            };
        }

        public TinyColor OnBackground(ColorInput background)
        {
            var fg = ToRgb();
            var bg = new TinyColor(background).ToRgb();
            var alpha = fg.A + bg.A * (1 - fg.A);

            var r = (fg.R * fg.A + bg.R * bg.A * (1 - fg.A)) / alpha;
            var g = (fg.G * fg.A + bg.G * bg.A * (1 - fg.A)) / alpha;
            var b = (fg.B * fg.A + bg.B * bg.A * (1 - fg.A)) / alpha;

            return new TinyColor(new RGBA{
                R = r.Value,
                G = g.Value,
                B = b.Value,
                A = alpha,
            });
        }

        public TinyColor[] Triad()
        {
            return Polyad(3);
        }

        public TinyColor[] Tetrad()
        {
            return Polyad(4);
        }

        public TinyColor[] Polyad(double n)
        {
            var hsl = ToHsl();
            var h = hsl.H;

            var result = new List<TinyColor>() { this };
            var increment = 360 / n;
            for (var i = 1; i < n; i++)
            {
                result.Add(new TinyColor(new HSL { H = (h + i * increment) % 360, S = hsl.S, L = hsl.L }));
            }

            return result.ToArray();
        }
    }
}
