using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
#if NET8_0_OR_GREATER
using Microsoft.AspNetCore.Components.Sections;
#endif
using Microsoft.AspNetCore.Components.Web;
using System.Collections.Concurrent;

namespace CssInCSharp
{
    public sealed class StyleOutlet : ComponentBase
    {
        internal const string StyeSectionOutletName = "cssincs_style";
        internal static ConcurrentDictionary<string, StyleInfo> Styles = new ConcurrentDictionary<string, StyleInfo>();
        internal static void Register(StyleInfo[] styles)
        {
            foreach(var style in styles)
            {
                var path = $"{style.TokenKey}|{string.Join("|", style.Path)}";
                Styles.TryAdd(path, style);
            }
        }

        internal static void Register(StyleInfo style)
        {
            var path = $"{style.TokenKey}|{string.Join("|", style.Path)}";
            Styles.TryAdd(path, style);
        }

        /*
         * using SectionOutlet to render style tag
         * note:
         * Since only one head::after can exist,
         * Therefore, the HeadOutlet needs to be placed here.
         * The order of HeadOutlet needs to be placed after StyleSection.
         */
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            var i = 0;
            foreach (var item in Styles)
            {
                builder.OpenComponent<Style>(i++);
                builder.AddAttribute(i++, "HashId", item.Value.HashId);
                builder.AddAttribute(i++, "TokenKey", item.Value.TokenKey);
                builder.AddAttribute(i++, "Path", item.Key);
                builder.AddAttribute(i++, "StyleFn", item.Value.StyleFn);
                builder.CloseComponent();
            }
#if NET8_0_OR_GREATER
            builder.OpenComponent<SectionOutlet>(i++);
            builder.AddAttribute(i++, nameof(SectionOutlet.SectionName), StyeSectionOutletName);
            builder.CloseComponent();
            builder.OpenComponent<HeadOutlet>(i++);
            builder.CloseComponent();
#elif NET6_0_OR_GREATER
            builder.OpenComponent<HeadOutlet>(i++);
            builder.CloseComponent();
#else
#warning "The TargetFramework does not support the StyleOutlet component, upgrade the TargetFramework or use Style component only."
#endif
        }
    }
}
