using System;
using System.Collections.Generic;
using System.Linq;
using static CssInCSharp.Colors.Conversion;
using static CssInCSharp.Colors.Format;

namespace CssInCSharp.Colors;

public record struct HsvObject(double H, double S, double V);
public record struct RgbObject(double R, double G, double B)
{
    public static implicit operator RgbObject(RGBFormat format) => new RgbObject(format.R, format.G, format.B);
}

public record struct Opts(string Theme, string BackgroundColor);

public static class ColorPatternGenerator
{
    private const int HueStep = 2;
    private const double SaturationStep = 0.16;
    private const double SaturationStep2 = 0.05;
    private const double BrightnessStep1 = 0.05;
    private const double BrightnessStep2 = 0.15;
    private const int LightColorCount = 5;
    private const int DarkColorCount = 4;
    private const double DarkColorOpacity = 0.85;

    private static readonly KeyValuePair<int, double>[] DarkColorMap =
    {
        new(7, 0.15),
        new(6, 0.25),
        new(5, 0.3),
        new(5, 0.45),
        new(5, 0.65),
        new(5, 0.85),
        new(4, 0.9),
        new(3, 0.95),
        new(2, 0.97),
        new(1, 0.98),
    };


    private static HsvObject ToHsv(RgbObject rgb)
    {
        var (R, G, B) = rgb;
        var hsv = RgbToHsv(R, G, B);
        return new(H: hsv.H * 360, S: hsv.S.AsNumber, V: hsv.V.AsNumber);
    }

    private static string ToHex(RgbObject rgb)
    {
        return $"#{RgbToHex(rgb.R, rgb.G, rgb.B, false)}";
    }

    // Wrapper function ported from TinyColor.prototype.mix, not treeshakable.
    // Amount in range [0, 1]
    // Assume color1 & color2 has no alpha, since the following src code did so.
    public static RgbObject Mix(RgbObject rgb1, RgbObject rgb2, double amount)
    {
        var p = amount / 100;
        var rgb = new RgbObject(
            R: (rgb2.R - rgb1.R) * p + rgb1.R,
            G: (rgb2.G - rgb1.G) * p + rgb1.G,
            B: (rgb2.B - rgb1.B) * p + rgb1.B
            );
        return rgb;
    }

    public static double GetHue(HsvObject hsv, int i, bool light = false)
    {
        double hue;
        if (Math.Round(hsv.H) >= 60 && Math.Round(hsv.H) <= 240)
        {
            hue = light ? Math.Round(hsv.H) - HueStep * i : Math.Round(hsv.H) + HueStep * i;
        }
        else
        {
            hue = light ? Math.Round(hsv.H) + HueStep * i : Math.Round(hsv.H) - HueStep * i;
        }
        if (hue < 0)
        {
            hue += 360;
        }
        else if (hue >= 360)
        {
            hue -= 360;
        }
        return hue;
    }

    public static double GetSaturation(HsvObject hsv, int i, bool light = false)
    {
        // 灰度颜色不改变饱和度
        if (hsv.H == 0 && hsv.S == 0)
        {
            return hsv.S;
        }
        double saturation;
        if (light)
        {
            saturation = hsv.S - SaturationStep * i;
        }
        else if (i == DarkColorCount)
        {
            saturation = hsv.S + SaturationStep;
        }
        else
        {
            saturation = hsv.S + SaturationStep2 * i;
        }
        // 边界值修正
        if (saturation > 1)
        {
            saturation = 1;
        }
        // 第一格的 s 限制在 0.06-0.1 之间
        if (light && i == LightColorCount && saturation > 0.1)
        {
            saturation = 0.1;
        }
        if (saturation < 0.06)
        {
            saturation = 0.06;
        }
        return Math.Round(saturation, 2);
    }

    public static double GetValue(HsvObject hsv, int i, bool light = false)
    {
        double value;
        if (light)
        {
            value = hsv.V + BrightnessStep1 * i;
        }
        else
        {
            value = hsv.V - BrightnessStep2 * i;
        }
        if (value > 1)
        {
            value = 1;
        }
        return Math.Round(value, 2);
    }


    public static string[] Generate(string color, Opts? opts = null)
    {
        List<string> patterns = new List<string>();
        var pColor = InputToRGB(color);
        for (int i = LightColorCount; i > 0; i--)
        {
            var hsv = ToHsv(pColor);
            string colorString = ToHex(
                InputToRGB(
                    new HSV(
                        H: GetHue(hsv, i, true),
                        S: GetSaturation(hsv, i, true),
                        V: GetValue(hsv, i, true)
                    )
                )
            );
            patterns.Add(colorString);
        }
        patterns.Add(ToHex(pColor));
        for (int i = 1; i <= DarkColorCount; i++)
        {
            var hsv = ToHsv(pColor);
            string colorString = ToHex(
                InputToRGB(
                    new HSV(
                        H: GetHue(hsv, i),
                        S: GetSaturation(hsv, i),
                        V: GetValue(hsv, i)
                    )
                )
            );
            patterns.Add(colorString);
        }

        // dark theme patterns
        if (opts?.Theme == "dark")
        {
            return DarkColorMap.Select((opacity, index) =>
            {
                string darkColorString = ToHex(
                    Mix(
                        InputToRGB(opts?.BackgroundColor ?? "#141414"),
                        InputToRGB(patterns[index]),
                        opacity.Value * 100
                    )
                );

                return darkColorString;
            }).ToArray();
        }
        return [.. patterns];
    }
}
