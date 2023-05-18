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
        public RenderFragment WrapSSR(RenderFragment dom)
        {
            var token = new CssToken();
            var styleList = UseStyle(token);
            return (builder) =>
            {
                var i = 0;
                builder.AddContent(i++, dom);
                builder.OpenElement(i++, "style");
                foreach (var style in styleList)
                {
                    builder.AddContent(i++, style.ToString());
                }
                builder.CloseElement();
            };
        }

        protected abstract CSSObject[] UseStyle(CssToken token);
    }
}
