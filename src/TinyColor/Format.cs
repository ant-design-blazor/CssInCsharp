using System;
using System.Collections.Generic;
using System.Text;

namespace CssInCSharp
{
    public record struct RGBFormat(bool Ok, string Format, int R, int G, int B, int A);

    internal static class Format
    {
        public static RGBFormat InputToRGB(ColorInput color)
        {
            return new RGBFormat();
        }
    }
}
