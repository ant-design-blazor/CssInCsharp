using Microsoft.AspNetCore.Components;
using System;

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
        public static RenderFragment UseStyleRegister(StyleInfo[] styles)
        {
            StyleOutlet.Register(styles);
            return builder =>
            {
                builder.OpenComponent<StyleContent>(0);
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
