using Shouldly;
using Xunit;

namespace CssInCSharp.Tests
{
    public class CSSObjectTests
    {
        [Fact]
        public void Number_Without_Pxwrap()
        {
            new CSSObject
            {
                [".test"] = new CSSObject
                {
                    AnimationIterationCount = 1,
                    AspectRatio = 1,
                    BorderImageOutset = 1,
                    BorderImageSlice = 1,
                    BorderImageWidth = 1,
                    ColumnCount = 1,
                    Columns = 1,
                    Flex = 1,
                    FlexGrow = 1,
                    MsFlexPositive = 1,
                    FlexShrink = 1,
                    FontWeight = 1,
                    LineHeight = 1,
                    Opacity = 1,
                    Order = 1,
                    Orphans = 1,
                    TabSize = 1,
                    Widows = 1,
                    ZIndex = 1,
                    Zoom = 1,
                    WebkitLineClamp = 1,
                }
            }
            .ToString()
            .ShouldBe(".test{animation-iteration-count:1;aspect-ratio:1;border-image-outset:1;border-image-slice:1;border-image-width:1;column-count:1;columns:1;flex:1;flex-grow:1;-ms-flex-positive:1px;flex-shrink:1;font-weight:1;line-height:1;opacity:1;order:1;orphans:1;tab-size:1;widows:1;z-index:1;zoom:1;-webkit-line-clamp:1;}");
        }

        [Fact]
        public void Media()
        {
            var css = new CSSObject
            {
                ["@media (min-width: 500px)"] = new CSSObject
                {
                    [".grid-sm"] = new CSSObject
                    {
                        Display = "none",
                        InsetInlineStart = "auto",
                        InsetInlineEnd = "auto",
                        MarginInlineStart = 0,
                        Order = 0
                    }
                }
            };
            css.ToString().ShouldBe("@media (min-width: 500px){.grid-sm{display:none;inset-inline-start:auto;inset-inline-end:auto;margin-inline-start:0;order:0;}}");
            css.SerializeCss("1iw360o").ShouldBe("@media (min-width: 500px){:where(.1iw360o).grid-sm{display:none;inset-inline-start:auto;inset-inline-end:auto;margin-inline-start:0;order:0;}}");
        }

        [Fact]
        public void Animation()
        {
            var messageMoveIn = new Keyframe("MessageMoveIn", new CSSObject
            {
                ["0%"] = new CSSObject
                {
                    Padding = 0,
                    Transform = "translateY(-100%)",
                    Opacity = 0,
                },
                ["100%"] = new CSSObject
                {
                    Padding = 100,
                    Transform = "translateY(0)",
                    Opacity = 1,
                }
            });
            messageMoveIn.ToString().ShouldBe("MessageMoveIn;@keyframes MessageMoveIn{0%{padding:0;transform:translateY(-100%);opacity:0;}100%{padding:100px;transform:translateY(0);opacity:1;}}");
        }

		[Fact]
		public void Should_Property_Skip_Pxwrap()
		{
			new CSSObject()
			{
				[".test"] = new CSSObject()
				{
                    Left = new PropertySkip()
                    {
                        SkipCheck = true,
                        Value = 12
                    }
				}
			}
			.ToString()
			.ShouldBe(".test{left:12px;}");
		}

		[Fact]
		public void Should_Where_Inject_To_All_Selectors()
		{
			new CSSObject()
			{
                [".ant-zoom-big-fast-enter,.ant-zoom-big-fast-appear"] = new CSSObject()
                {
                    Transform = "scale(0)",
                    Opacity = 0,
                }
			}
			.SerializeCss("css-3nv711")
			.ShouldBe(":where(.css-3nv711).ant-zoom-big-fast-enter,:where(.css-3nv711).ant-zoom-big-fast-appear{transform:scale(0);opacity:0;}");
		}
	}
}
