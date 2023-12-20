using static CssInCSharp.Colors.Conversion;
using static CssInCSharp.Colors.Format;

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
        private int _r;
        private int _g;
        private int _b;
        private int _a;
        // private int _roundA;
        private string _format;
        private string _gradientType;
        private bool _isValid;

        public bool IsValid => _isValid;

        public TinyColor(ColorInput color, TinyColorOptions opts = null)
        {
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
            // _roundA = _a;
            _format = opts?.Format ?? rgb.Format;
            _gradientType = opts?.GradientType;
            _isValid = rgb.Ok;
        }

        public bool IsDark()
        {
            return GetBrightness() < 128;
        }

        public bool IsLight()
        {
            return !IsDark();
        }

        public int GetBrightness()
        {
            var rgb = ToRgb();
            return (rgb.R * 299 + rgb.G * 587 + rgb.B * 114) / 1000;
        }

        public int GetLuminance()
        {
            return 0;
        }

        public int GetAlpha()
        {
            return _a;
        }

        public void SetAlpha(double alpha)
        {

        }

        public RGBA ToRgb()
        {
            return new RGBA(_r, _g, _b, _a);
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
    }
}
