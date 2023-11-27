using Bunit;
using Xunit;

namespace CssInCs.Tests
{
    public class StyleTests : TestContext
    {
        [Fact]
        public void RenderStyle()
        {
            var render = new Func<CSSInterpolation>(() => new CSSObject()
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
            });
            var cut = RenderComponent<Style>(parameters => parameters
                .Add(p => p.HashId, "")
                .Add(p => p.Token, "1iw360o")
                .Add(p => p.Path, new []{ "Shared", "ant" })
                .Add(p => p.StyleFn, render));
            cut.MarkupMatches(@"<style data-css-hash="""" data-token-hash=""1iw360o"" data-cache-path=""1iw360o|Shared|ant"">a{color:#1677ff;text-decoration:none;background-color:transparent;outline:none;cursor:pointer;transition:color 0.3s;-webkit-text-decoration-skip:objects;}a:hover{color:#69b1ff;}a:active{color:#0958d9;}a:active,a:hover{text-decoration:none;outline:0;}a:focus{text-decoration:none;outline:0;}a[disabled]{color:rgba(0, 0, 0, 0.25);cursor:not-allowed;}</style>");
        }
    }
}
