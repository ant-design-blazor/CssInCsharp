using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Sections;
using Microsoft.AspNetCore.Components.Web;

namespace CssInCs
{
    public sealed class StyleOutlet : ComponentBase
    {
        internal const string StyeSectionOutletName = "cssincs_style";

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            // useing SectionOutlet to render style tag
            builder.OpenComponent<SectionOutlet>(0);
            builder.AddAttribute(1, nameof(SectionOutlet.SectionName), StyeSectionOutletName);
            builder.CloseComponent();

            /*
             * note:
             * Since only one head::after can exist,
             * Therefore, the HeadOutlet needs to be placed here for rendering.
             * The order of HeadOutlet needs to be placed after StyleSection.
             */
            builder.OpenComponent<HeadOutlet>(2);
            builder.CloseComponent();
        }
    }
}
