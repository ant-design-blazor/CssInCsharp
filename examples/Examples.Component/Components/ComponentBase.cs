using CssInCSharp;
using Microsoft.AspNetCore.Components;

namespace Examples.Component
{
    public class CssToken
    {
        // some css token, eg: theme parameters
        public string ThemeColor { get; set; }
        public string ThemeBackground { get; set; }
        public string ComponentName { get; set; }
        public string HashId { get; set; }
    }

    public abstract class AntdComponentBase: ComponentBase
    {
        [Parameter]
        public string Id { get; set; }

        public RenderFragment WrapSSR(RenderFragment dom, CssToken token)
        {
            return (builder) =>
            {
                var i = 0;
                builder.OpenComponent(i++, typeof(Style));
                builder.AddAttribute(i++, "TokenKey", $"{token.HashId}");
                builder.AddAttribute(i++, "Path", $"css|{token.ComponentName}");
                builder.AddAttribute(i++, "StyleFn", UseStyle);
                builder.CloseComponent();
                builder.AddContent(i++, dom);
            };
        }

        protected abstract CSSInterpolation UseStyle();
    }
}
