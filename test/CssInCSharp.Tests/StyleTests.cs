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

        [Fact]
        public void Should_AnimationName_Render_As_A_Separate_Style_Tag()
        {
            var render = (Func<CSSInterpolation>)(() => new CSSObject()
            {
                [".transform"] = new CSSObject()
                {
                    Width = 120,
                    Height = 120,
                    ["& .animation"] = new CSSObject
                    {
                        Width = 100,
                        Height = 100,
                        BackgroundColor = "rgba(0, 0, 255, 0.5)",
                        AnimationDuration = "3s",
                        AnimationName = new Keyframe("transformAnimation")
                        {
                            ["from"] = new CSSObject()
                            {
                                Transform = "translateX(0px)",
                                Opacity = 1
                            },
                            ["to"] = new CSSObject()
                            {
                                Transform = "translateX(100px)",
                                Opacity = 0.2f
                            }
                        }
                    }
                }
            });
            var cut = RenderComponent<Style>(parameters => parameters
                .Add(p => p.HashId, "css-dev-only-do-not-override-zcfrx9")
                .Add(p => p.TokenKey, "1iw360o")
                .Add(p => p.Path, "1iw360o|AnimationName|test")
                .Add(p => p.StyleFn, render));
            cut.MarkupMatches(string.Join("", new []
            {
                "<style data-css-hash:ignore data-token-hash:ignore data-cache-path:ignore>:where(.css-dev-only-do-not-override-zcfrx9).transform{width:120px;height:120px;}:where(.css-dev-only-do-not-override-zcfrx9).transform .animation{width:100px;height:100px;background-color:rgba(0, 0, 255, 0.5);animation-duration:3s;animation-name:css-dev-only-do-not-override-zcfrx9-transformAnimation;}</style>",
                "<style data-css-hash:ignore>@keyframes css-dev-only-do-not-override-zcfrx9-transformAnimation{from{transform:translateX(0px);opacity:1;}to{transform:translateX(100px);opacity:0.20000000298023224;}}</style>"
            }));
        }
    }
}
