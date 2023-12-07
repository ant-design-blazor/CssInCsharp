using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
#if NET8_0_OR_GREATER
using Microsoft.AspNetCore.Components.Sections;
#endif
using Microsoft.AspNetCore.Components.Web;

namespace CssInCSharp
{
    public sealed class StyleOutlet : ComponentBase
    {
        internal const string StyeSectionOutletName = "cssincsharp_style";
        internal const string InternalStyeSectionOutletName = "cssincsharp_style_internal";

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
#if NET8_0_OR_GREATER
            // internal style content for components
            builder.OpenComponent<SectionOutlet>(i++);
            builder.AddAttribute(i++, nameof(SectionOutlet.SectionName), InternalStyeSectionOutletName);
            builder.CloseComponent();
            // style content for pages
            builder.OpenComponent<SectionOutlet>(i++);
            builder.AddAttribute(i++, nameof(SectionOutlet.SectionName), StyeSectionOutletName);
            builder.CloseComponent();
            // original head
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
