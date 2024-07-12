﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
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
            var cache = StyleCache.Instance.GetOrAdd(Path, (key) =>
            {
                var csses = StyleFn().ToCssArray();
                var sb = new StringBuilder();
                var effects = new List<(string, string)>();
                foreach (var css in csses)
                {
                    sb.Append(css?.SerializeCss(HashId, effects));
                }
                var item = new StyleCache.Item
                {
                    StyleStr = sb.ToString(),
                    TokenKey = TokenKey,
                    StyleId = "",
                    Effects = new Dictionary<string, string>(),
                };
                if (effects.Count > 0)
                {
                    foreach (var (effectName, effect) in effects)
                    {
                        if (!StyleCache.Instance.HasEffect(effectName))
                        {
                            item.Effects.TryAdd(effectName, effect);
                        }
                    }
                }
                return item;
            });
            var i = 0;
            builder.OpenElement(i++, "style");
            builder.AddAttribute(i++, "data-css-hash", cache.StyleId);
            builder.AddAttribute(i++, "data-token-hash", cache.TokenKey);
            builder.AddAttribute(i++, "data-cache-path", Path);
            builder.AddContent(i++, cache.StyleStr);
            builder.CloseElement();
            // gen animation effect
            foreach (var effect in cache.Effects)
            {
                builder.OpenElement(i++, "style");
                builder.AddAttribute(i++, "data-css-hash", $"_effect-{effect.Key}");
                builder.AddContent(i++, effect.Value);
                builder.CloseElement();
            }
        }
    }
}
