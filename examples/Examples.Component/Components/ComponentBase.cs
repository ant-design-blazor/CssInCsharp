using CssInCs;
using Microsoft.AspNetCore.Components;

namespace Examples.Component
{
    public class CssToken
    {
        // some css token, eg: theme parameters
        public string ThemeColor { get; set; }
        public string ThemeBackground { get; set; }
    }

    public abstract class AntdComponentBase: ComponentBase
    {
        [Parameter]
        public string Id { get; set; }

        public RenderFragment WrapSSR(RenderFragment dom)
        {
            var token = new CssToken();
            var styleList = UseStyle(token);
            return (builder) =>
            {
                var i = 0;
                builder.OpenComponent(i++, typeof(Style));
                builder.AddAttribute(i++, "Id", Id);
                builder.AddAttribute(i++, "Styles", styleList);
                builder.CloseComponent();
                builder.AddContent(i++, dom);
            };
        }

        protected abstract CSSObject[] UseStyle(CssToken token);
    }
}
