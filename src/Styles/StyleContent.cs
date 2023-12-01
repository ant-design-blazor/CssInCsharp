using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Sections;

namespace CssInCs
{
    public class StyleContent : ComponentBase
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenComponent<SectionContent>(0);
            builder.AddAttribute(1, nameof(SectionContent.SectionName), StyleOutlet.StyeSectionOutletName);
            builder.AddAttribute(2, nameof(SectionContent.ChildContent), ChildContent);
            builder.CloseComponent();
        }
    }
}
