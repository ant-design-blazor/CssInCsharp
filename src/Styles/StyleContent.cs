using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
#if NET8_0_OR_GREATER
using Microsoft.AspNetCore.Components.Sections;
#endif

namespace CssInCSharp
{
    public class StyleContent : ComponentBase
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
#if NET8_0_OR_GREATER
            builder.OpenComponent<SectionContent>(0);
            builder.AddAttribute(1, nameof(SectionContent.SectionName), StyleOutlet.StyeSectionOutletName);
            builder.AddAttribute(2, nameof(SectionContent.ChildContent), ChildContent);
            builder.CloseComponent();
#endif
        }
    }
}
