using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;
using static CssInCSharp.Colors.ColorPatternGenerator;

namespace CssInCSharp.Colors
{
    public static class AntDesignColorPalettes
    {
        private static readonly Dictionary<string, string> _presetPrimaryColors = new()
        {
            { "red", "#F5222D" },
            { "volcano", "#FA541C" },
            { "orange", "#FA8C16" },
            { "gold", "#FAAD14" },
            { "yellow", "#FADB14" },
            { "lime", "#A0D911" },
            { "green", "#52C41A" },
            { "cyan", "#13C2C2" },
            { "blue", "#1677FF" },
            { "geekblue", "#2F54EB" },
            { "purple", "#722ED1" },
            { "magenta", "#EB2F96" },
            { "grey", "#666666" },
        };

        public static Dictionary<string, string[]> PresetPalettes;
        public static Dictionary<string, string[]> PresetDarkPalettes;

        public static string Red => PresetPalettes["red"][5];
        public static string Volcano => PresetPalettes["volcano"][5];
        public static string Orange => PresetPalettes["orange"][5];
        public static string Gold => PresetPalettes["gold"][5];
        public static string Yellow => PresetPalettes["yellow"][5];
        public static string Lime => PresetPalettes["lime"][5];
        public static string Green => PresetPalettes["green"][5];
        public static string Cyan => PresetPalettes["cyan"][5];
        public static string Blue => PresetPalettes["blue"][5];
        public static string Geekblue => PresetPalettes["geekblue"][5];
        public static string Purple => PresetPalettes["purple"][5];
        public static string Magenta => PresetPalettes["magenta"][5];
        public static string Grey => PresetPalettes["grey"][5];

        static AntDesignColorPalettes()
        {
            PresetPalettes = _presetPrimaryColors.ToDictionary(kv => kv.Key, kv => Generate(kv.Value));
            PresetDarkPalettes = _presetPrimaryColors.ToDictionary(kv => kv.Key, kv => Generate(kv.Value, new(Theme: "dark", BackgroundColor: "#141414")));
        }
    }
}
