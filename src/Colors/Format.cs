using static CssInCSharp.Colors.Conversion;

namespace CssInCSharp.Colors
{
    public record struct RGBFormat(int R, int G, int B, int A, string Format, bool Ok);

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
    }

    internal static class Format
    {
        public static RGBFormat InputToRGB(ColorInput color)
        {
            var rgb = new RGB(0, 0, 0);
            var a = 1;
            if (color.IsString)
            {
                color = StringInputToObject(color.AsString);
            }

            if (color.IsObject)
            {
                if (IsValidCSSUnit(color.R) && IsValidCSSUnit(color.G) && IsValidCSSUnit(color.B))
                {
                    rgb = RgbToRgb(color.R, color.G, color.B);
                }
            }

            return new RGBFormat();
        }

        public static ColorInput StringInputToObject(string color)
        {
            color = color.Trim().ToLower();
            if (CssColor.Names.TryGetValue(color, out var name))
            {
                color = name;
            }
            else if (color == "transparent")
            {
                return new ColorInput
                {
                    R = 0,
                    G = 0, 
                    B = 0,
                    A = 0,
                    Format = "name"
                };
            }

            return null;
        }

        public static bool IsValidCSSUnit(StringNumber color)
        {
            return false;
        }
    }
}
