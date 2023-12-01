using Microsoft.AspNetCore.Components;
using System;

namespace CssInCs
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
        public static RenderFragment UseStyleRegister(StyleInfo[] styles)
        {
            return builder =>
            {
                var i = 0;
                foreach (var style in styles)
                {
                    builder.OpenComponent<Style>(0);
                    builder.AddAttribute(1, "HashId", style.HashId);
                    builder.AddAttribute(2, "TokenKey", style.TokenKey);
                    builder.AddAttribute(3, "Path", $"{style.TokenKey}|{string.Join("|", style.Path)}");
                    builder.AddAttribute(4, "StyleFn", style.StyleFn);
                    builder.CloseComponent();
                }
            };
        }
    }
}
