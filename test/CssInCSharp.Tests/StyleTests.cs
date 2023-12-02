using Bunit;
using Xunit;

namespace CssInCSharp.Tests
{
    public class StyleTests : TestContext
    {
        [Fact]
        public void RenderStyle()
        {
            var render = new Func<CSSInterpolation>(() => new CSSObject()
            {
                ["&"] = new CSSObject
                {
                    ["a"] = new CSSObject
                    {
                        Color = "#1677ff",
                        TextDecoration = "none",
                        BackgroundColor = "transparent",
                        Outline = "none",
                        Cursor = "pointer",
                        Transition = $"color 0.3s",
                        WebkitTextDecorationSkip = "objects",

                        ["&:hover"] = new CSSObject
                        {
                            Color = "#69b1ff",
                        },

                        ["&:active"] = new CSSObject
                        {
                            Color = "#0958d9",
                        },

                        ["&:active,&:hover"] = new CSSObject
                        {
                            TextDecoration = "none",
                            Outline = 0,
                        },

                        ["&:focus"] = new CSSObject
                        {
                            TextDecoration = "none",
                            Outline = 0,
                        },

                        ["&[disabled]"] = new CSSObject
                        {
                            Color = "rgba(0, 0, 0, 0.25)",
                            Cursor = "not-allowed",
                        },
                    }
                }
            });
            var cut = RenderComponent<Style>(parameters => parameters
                .Add(p => p.HashId, "css-dev-only-do-not-override-zcfrx9")
                .Add(p => p.TokenKey, "1iw360o")
                .Add(p => p.Path, "1iw360o|Shared|ant")
                .Add(p => p.StyleFn, render));
            cut.MarkupMatches(@"<style data-css-hash:ignore data-token-hash:ignore data-cache-path:ignore>:where(.css-dev-only-do-not-override-zcfrx9) a{color:#1677ff;text-decoration:none;background-color:transparent;outline:none;cursor:pointer;transition:color 0.3s;-webkit-text-decoration-skip:objects;}:where(.css-dev-only-do-not-override-zcfrx9) a:hover{color:#69b1ff;}:where(.css-dev-only-do-not-override-zcfrx9) a:active{color:#0958d9;}:where(.css-dev-only-do-not-override-zcfrx9) a:active,:where(.css-dev-only-do-not-override-zcfrx9) a:hover{text-decoration:none;outline:0;}:where(.css-dev-only-do-not-override-zcfrx9) a:focus{text-decoration:none;outline:0;}:where(.css-dev-only-do-not-override-zcfrx9) a[disabled]{color:rgba(0, 0, 0, 0.25);cursor:not-allowed;}</style>");
        }
    }
}
