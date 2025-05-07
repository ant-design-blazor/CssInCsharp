using System;
using System.Collections.Generic;
using System.Text;

namespace CssInCSharp
{
    public class StyleInfo
    {
        public string TokenKey { get; set; }
        public string HashId { get; set; }
        public string[] Path { get; set; }
        public Func<CSSInterpolation> StyleFn { get; set; }
    }

    public static class StyleHelper
    {
        private const string CACHE_KEY = "css";
        internal static StyleRegistry StyleRegistry { get; } = new StyleRegistry();
        internal static Dictionary<string, StyleInfo> Styles { get; } = new Dictionary<string, StyleInfo>();

        public static void Register(StyleInfo style)
        {
            var path = GetPath(style.TokenKey, style.Path);
            Styles.TryAdd(path, style);
            var provider = StyleRegistry.GetCurrentProviderContentOrDefault(StyleOutlet.InternalStyeSectionOutletName);
            if (provider != null)
            {
                StyleRegistry.NotifyContentProviderChanged(StyleOutlet.InternalStyeSectionOutletName, provider);
            }
        }

        public static string Register(string className, CSSObject style)
        {
            string[] path;
            if (className == null)
            {
                var (hashId, item) = SerializeStyle(style);
                className = $"{CACHE_KEY}-{hashId}";
                item.StyleStr = $".{className}{{{item.StyleStr}}}";
                path = new string[] { CACHE_KEY, className };
                StyleCache.Instance.TryAdd(GetPath("", path), item);
            }
            else
            {
                path = new[] { CACHE_KEY, className };
               
            }
            var css = new CSSObject()
            {
                [$".{className}"] = style,
            };
            Register(new StyleInfo
            {
                HashId = "",
                Path = path,
                StyleFn = () => css
            });
            return className;
        }

        public static string Register(CSSObject style)
        {
            return Register(null, style);
        }

        public static string Register(string style)
        {
            var css = new CSSString(style);
            var (hashId, item) = SerializeStyle(css);
            var className = $"{CACHE_KEY}-{hashId}";
            item.StyleStr = $".{className}{{{item.StyleStr}}}";
            var path = new string[] { CACHE_KEY, className };
            StyleCache.Instance.TryAdd(GetPath("", path), item);
            Register(new StyleInfo
            {
                HashId = "",
                Path = path,
                StyleFn = () => css
            });
            return className;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="css"></param>
        public static void UseStyleRegister(StyleInfo css)
        {
            Register(css);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="css"></param>
        /// <returns>className</returns>
        public static string CSS(string css)
        {
            return Register(css);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="className"></param>
        /// <param name="css"></param>
        /// <returns></returns>
        public static string CX(string className, CSSObject css)
        {
            return Register(className, css);
        }

        public static string Hash(string str)
        {
            long h = 0;
            int k = 0;
            var i = 0;
            var len = str.Length;
            for (; len >= 4; ++i, len -= 4)
            {
                k = (str.CharCodeAt(i) & 0xff) |
                    ((str.CharCodeAt(++i) & 0xff) << 8) |
                    ((str.CharCodeAt(++i) & 0xff) << 16) |
                    ((str.CharCodeAt(++i) & 0xff) << 24);

                k = (k & 0xffff) * 0x5bd1e995 + (((k >>> 16) * 0xe995) << 16);
                k ^= k >>> 24;
                h = ((k & 0xffff) * 0x5bd1e995 + (((k >>> 16) * 0xe995) << 16)) ^
                    ((h & 0xffff) * 0x5bd1e995 + (((h >>> 16) * 0xe995) << 16));
            }
            switch (len)
            {
                case 3:
                    h ^= (str.CharCodeAt(i + 2) & 0xff) << 16;
                    goto case 2;
                case 2:
                    h ^= (str.CharCodeAt(i + 1) & 0xff) << 8;
                    goto case 1;
                case 1:
                    h ^= str.CharCodeAt(i) & 0xff;
                    h = ((h & 0xffff) * 0x5bd1e995) + (((int)(h >>> 16) * 0xe995) << 16);
                    break;
            }
            h ^= (int)h >>> 13;
            h = ((h & 0xffff) * 0x5bd1e995) + (((int)(h >>> 16) * 0xe995) << 16);
            var val = ((int)(h ^ ((int)h >>> 15)));
            return Convert.ToInt64(Convert.ToString((val >>> 0), toBase: 2), 2).ToString(36);
        }

        private static string GetPath(string tokenKey, string[] path)
        {
            return $"{tokenKey}|{string.Join("|", path)}";
        }

        internal static (string, StyleCache.Item) SerializeStyle(CSSInterpolation style, string? tokenKey = null, string? hashId = null)
        {
            string styleStr;
            List<(string, string)> effects = null;
            if (style.IsT3)
            {
                styleStr = style.AsT3.ToString();
            }
            else
            {
                var csses = style.ToCssArray();
                var sb = new StringBuilder();
                effects = new List<(string, string)>();
                foreach (var css in csses)
                {
                    sb.Append(css?.SerializeCss(hashId, effects));
                }
                styleStr = sb.ToString();
            }

            var item = new StyleCache.Item
            {
                StyleStr = styleStr,
                TokenKey = tokenKey,
                StyleId = "",
                Effects = new Dictionary<string, string>(),
            };
            if (effects != null && effects.Count > 0)
            {
                foreach (var (effectName, effect) in effects)
                {
                    if (!StyleCache.Instance.HasEffect(effectName))
                    {
                        item.Effects.TryAdd(effectName, effect);
                    }
                }
            }

            if (string.IsNullOrEmpty(hashId))
            {
                hashId = Hash(styleStr);
            }
            return (hashId, item);
        }
    }

    public static class TypeEntensions
    {
        private const string CharList = "0123456789abcdefghijklmnopqrstuvwxyz";

        public static int CharCodeAt(this string str, int index)
        {
            return str[index];
        }

        public static string ToString(this long value, int radix = 36)
        {
            var clistarr = CharList.ToCharArray();
            var result = new Stack<char>();
            while (value != 0)
            {
                result.Push(clistarr[value % radix]);
                value /= radix;
            }
            return new string(result.ToArray());
        }
    }
}
