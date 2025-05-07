using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CssInCSharp
{
    public class StyleContent : ComponentBase
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenComponent<StyleSectionContent>(0);
            builder.AddAttribute(1, nameof(StyleSectionContent.SectionName), StyleOutlet.StyeSectionOutletName);
            builder.AddAttribute(2, nameof(StyleSectionContent.ChildContent), ChildContent);
            builder.CloseComponent();
        }
    }
}
