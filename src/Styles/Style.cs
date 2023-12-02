using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Text;

namespace CssInCSharp
{
    public class Style : ComponentBase
    {
        [Parameter]
        public string TokenKey { get; set; }

        [Parameter]
        public string Path { get; set; } = $"css|{Guid.NewGuid()}";

        [Parameter]
        public string HashId { get; set; }

        [Parameter]
        public int Order { get; set; }

        [Parameter]
        public Func<CSSInterpolation> StyleFn { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            // If the cache is hit, skip render
            if (StyleCache.Instance.Exists(Path)) return;
            var cache = StyleCache.Instance.GetOrAdd(Path, (key) =>
            {
                var csses = StyleFn().ToCssArray();
                var sb = new StringBuilder();
                foreach (var css in csses)
                {
                    sb.Append(css.SerializeCss(HashId));
                }
                return new StyleCache.Item
                {
                    StyleStr = sb.ToString(),
                    TokenKey = TokenKey,
                    StyleId = ""
                };
            });
            builder.OpenElement(0, "style");
            builder.AddAttribute(1, "data-css-hash", cache.StyleId);
            builder.AddAttribute(2, "data-token-hash", cache.TokenKey);
            builder.AddAttribute(3, "data-cache-path", Path);
            builder.AddContent(4, cache.StyleStr);
            builder.CloseElement();
        }
    }
}
