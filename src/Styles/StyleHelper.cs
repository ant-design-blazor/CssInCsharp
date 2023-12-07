using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Concurrent;

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
        // todo: how to UnRegister style, if compoent disposed.
        internal static ConcurrentDictionary<string, StyleInfo> Styles = new ConcurrentDictionary<string, StyleInfo>();

        public static RenderFragment UseStyleRegister(StyleInfo style)
        {
            var path = $"{style.TokenKey}|{string.Join("|", style.Path)}";
            Styles.TryAdd(path, style);
            return builder =>
            {
                builder.OpenComponent<StyleContentInternal>(0);
                builder.AddAttribute(1, "ChildContent", (RenderFragment)((child) =>
                {
                    var i = 0;
                    foreach (var item in Styles)
                    {
                        child.OpenComponent<Style>(i++);
                        child.AddAttribute(i++, "HashId", item.Value.HashId);
                        child.AddAttribute(i++, "TokenKey", item.Value.TokenKey);
                        child.AddAttribute(i++, "Path", item.Key);
                        child.AddAttribute(i++, "StyleFn", item.Value.StyleFn);
                        child.CloseComponent();
                    }
                }));
                builder.CloseComponent();
            };
        }

        public static RenderFragment UseStyleRegister(StyleInfo style)
        {
            StyleOutlet.Register(style);
            return builder =>
            {
                builder.OpenComponent<StyleContent>(0);
                builder.CloseComponent();
            };
        }
    }
}
