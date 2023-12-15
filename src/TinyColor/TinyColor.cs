using static CssInCSharp.Conversion;
using static CssInCSharp.Format;

namespace CssInCSharp
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
    }
}
