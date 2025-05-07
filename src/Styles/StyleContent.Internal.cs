using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CssInCSharp
{
    internal class StyleContentInternal : ComponentBase
    {
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenComponent<StyleSectionContent>(0);
            builder.AddAttribute(1, nameof(StyleSectionContent.SectionName), StyleOutlet.InternalStyeSectionOutletName);
            builder.AddAttribute(2, nameof(StyleSectionContent.ChildContent), (RenderFragment)((child) =>
            {
                var i = 0;
                foreach (var item in StyleHelper.Styles)
                {
                    child.OpenComponent<Style>(i++);
                    child.AddAttribute(i++, "HashId", item.Value.HashId);
                    child.AddAttribute(i++, "TokenKey", item.Value.TokenKey);
                    child.AddAttribute(i++, "Path", item.Key);
                    child.AddAttribute(i++, "StyleFn", item.Value.StyleFn);
                    child.CloseComponent();
                }
            }));
            builder.CloseComponent();
        }
    }
}
