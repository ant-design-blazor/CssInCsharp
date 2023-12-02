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
        internal const string StyeSectionOutletName = "cssincs_style";

        /*
         * using SectionOutlet to render style tag
         * note:
         * Since only one head::after can exist,
         * Therefore, the HeadOutlet needs to be placed here.
         * The order of HeadOutlet needs to be placed after StyleSection.
         */
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
#if NET8_0_OR_GREATER
            builder.OpenComponent<SectionOutlet>(0);
            builder.AddAttribute(1, nameof(SectionOutlet.SectionName), StyeSectionOutletName);
            builder.CloseComponent();
            builder.OpenComponent<HeadOutlet>(2);
            builder.CloseComponent();
#elif NET6_0_OR_GREATER
            builder.OpenComponent<HeadOutlet>(2);
            builder.CloseComponent();
#else
#warning "The TargetFramework does not support the StyleOutlet component, upgrade the TargetFramework or use Style component only."
#endif
        }
    }
}
