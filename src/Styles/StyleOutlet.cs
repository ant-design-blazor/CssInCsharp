using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
#if NET6_0_OR_GREATER
using Microsoft.AspNetCore.Components.Web;
#endif

namespace CssInCSharp
{
    public sealed class StyleOutlet : ComponentBase
    {
        internal const string StyeSectionOutletName = "cssincsharp_style";
        internal const string InternalStyeSectionOutletName = "cssincsharp_style_internal";

        [Parameter] public bool HeadOutletRender { get; set; } = true;

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

            // render internal styles
            builder.OpenComponent<StyleSection>(i++);
            builder.AddAttribute(i++, nameof(StyleSection.SectionName), InternalStyeSectionOutletName);
            builder.CloseComponent();

            // render page styles
            builder.OpenComponent<StyleSection>(i++);
            builder.AddAttribute(i++, nameof(StyleSection.SectionName), StyeSectionOutletName);
            builder.CloseComponent();

            // internal style container
            builder.OpenComponent<StyleContentInternal>(i++);
            builder.CloseComponent();

#if NET6_0_OR_GREATER
            // render default HeadOutlet
            if (HeadOutletRender)
            {
                builder.OpenComponent<HeadOutlet>(i++);
                builder.CloseComponent();
            }
#endif
        }
    }
}
