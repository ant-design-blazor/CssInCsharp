using CssInCSharp.Colors;
using Shouldly;
using Xunit;

namespace CssInCSharp.Tests
{
    public class FastColorTests
    {
        [Fact]
        public void Should_Init()
        {
            var r = new FastColor("#66ccff");
            r.ToHexString().ShouldBe("#66ccff");
        }

        [Fact]
        public void Should_Clone()
        {
            var color1 = new FastColor("#66ccff");
            color1.ToString().ShouldBe("rgb(102,204,255)");
            color1.ToRgb().ShouldBe(new RGBA
            {
                A = 1,
                B = 255,
                G = 204,
                R = 102
            });

            var color2 = color1.Clone();
            color2.ToRgb().ShouldBe(new RGBA{
                A = 1,
                B = 255,
                G = 204,
                R = 102,
            });
            color2 = color2.SetA(0.5);
            color2.ToString().ShouldBe("rgba(102,204,255,0.5)");
        }

        [Fact]
        public void Should_Parse_Hex()
        {
            new FastColor("#000").ToHexString().ShouldBe("#000000");
            new FastColor("#0000").ToHexString().ShouldBe("#00000000");
            new FastColor("#000").A.ShouldBe(1);
            new FastColor("#0000").A.ShouldBe(0);
        }

        [Fact]
        public void Should_Parse_Rgb()
        {
            new FastColor("rgb(255,0,0)").ToHexString().ShouldBe("#ff0000");
            // parenthesized spaced input
            new FastColor("rgb (255,0,0)").ToHexString().ShouldBe("#ff0000");
            // object input
            new FastColor(new RGB{ R = 255, G = 0, B = 0 }).ToHexString().ShouldBe("#ff0000");
            // object input and compare
            new FastColor(new RGB { R = 255, G = 0, B = 0 }).ToRgb().ShouldBe(new RGBA
            {
                R = 255,
                G = 0,
                B = 0,
                A = 1,
            });

            new FastColor(new RGB { R = 200, G = 100, B = 0 }).Equals(new FastColor("rgb(200, 100, 0)")).ShouldBe(true);

            new FastColor(new RGBA { R = 200, G = 100, B = 0, A = 0.4 }).Equals
            (
                new FastColor("rgba(200 100 0 .4)")
            ).ShouldBe(true);

            new FastColor(new RGB { R = 199, G = 100, B = 0 }).Equals
            (
                new FastColor(new RGB { R = 200, G = 100, B = 0 })
            ).ShouldBe(false);
        }

        [Fact]
        public void Should_Parse_Percentage_Rgb_Text()
        {
            // parenthesized input
            new FastColor("rgb(100%, 0%, 0%)").ToHexString().ShouldBe("#ff0000");
            // parenthesized spaced input
            new FastColor("rgb (100%, 0%, 0%)").ToHexString().ShouldBe("#ff0000");
        }

        [Fact]
        public void Should_Parse_HSL()
        {
            new FastColor(new HSL { H = 251, S = 1, L = 0.38 }).ToHexString().ShouldBe("#2400c2");
            // to rgb
            new FastColor(new HSL { H = 251, S = 1, L = 0.38 }).ToRgbString().ShouldBe("rgb(36,0,194)");
            // to hsl
            new FastColor(new HSL { H = 251, S = 1, L = 0.38 }).ToHslString().ShouldBe("hsl(251,100%,38%)");
            
            new FastColor(new HSLA { H = 251, S = 1, L = 0.38, A = 0.38 }).ToHslString().ShouldBe("hsla(251,100%,38%,0.38)");
            // to hex
            new FastColor("hsl(251,100,38)").ToHexString().ShouldBe("#2400c2");
            // to rgb
            new FastColor("hsl(251,100%,38%)").ToRgbString().ShouldBe("rgb(36,0,194)");
            // to hsl
            new FastColor("hsl(251,100%,38%)").ToHslString().ShouldBe("hsl(251,100%,38%)");
        }

        [Fact]
        public void Should_Get_Alpha()
        {
            var hexSetter = new FastColor("rgba(255,0,0,1)");
            // Alpha should start as 1
            hexSetter.A.ShouldBe(1);
            hexSetter = hexSetter.SetA(0.9);
            // SetAlpha should change alpha value
            hexSetter.A.ShouldBe(0.9);
            hexSetter = hexSetter.SetA(0.5);
            // SetAlpha should change alpha value
            hexSetter.A.ShouldBe(0.5);
        }

        [Fact]
        public void Should_Set_Alpha()
        {
            var hexSetter = new FastColor("rgba(255,0,0,1)");
            // Alpha should start as 1
            hexSetter.A.ShouldBe(1);
            hexSetter = hexSetter.SetA(0.5);
            // SetAlpha should change alpha value
            hexSetter.A.ShouldBe(0.5);
            hexSetter = hexSetter.SetA(0);
            // SetAlpha should change alpha value
            hexSetter.A.ShouldBe(0);
            hexSetter = hexSetter.SetA(-1);
            // SetAlpha with value < 0 is corrected to 0
            hexSetter.A.ShouldBe(0);
            hexSetter = hexSetter.SetA(2);
            // SetAlpha with value > 1 is corrected to 1
            hexSetter.A.ShouldBe(1);
        }

        [Fact]
        public void Should_GetBrightness()
        {
            new FastColor("#000").GetBrightness().ShouldBe(0);
            new FastColor("#fff").GetBrightness().ShouldBe(255);
        }

        [Fact]
        public void Should_GetLuminance()
        {
            new FastColor("#000").GetLuminance().ShouldBe(0);
            new FastColor("#fff").GetLuminance().ShouldBe(1);
        }

        [Fact]
        public void IsDark_Returns_True_Or_False_For_Dark_Or_Light_Colors()
        {
            new FastColor("#000").IsDark().ShouldBe(true);
            new FastColor("#111").IsDark().ShouldBe(true);
            new FastColor("#222").IsDark().ShouldBe(true);
            new FastColor("#333").IsDark().ShouldBe(true);
            new FastColor("#444").IsDark().ShouldBe(true);
            new FastColor("#555").IsDark().ShouldBe(true);
            new FastColor("#666").IsDark().ShouldBe(true);
            new FastColor("#777").IsDark().ShouldBe(true);
            new FastColor("#888").IsDark().ShouldBe(false);
            new FastColor("#999").IsDark().ShouldBe(false);
            new FastColor("#aaa").IsDark().ShouldBe(false);
            new FastColor("#bbb").IsDark().ShouldBe(false);
            new FastColor("#ccc").IsDark().ShouldBe(false);
            new FastColor("#ddd").IsDark().ShouldBe(false);
            new FastColor("#eee").IsDark().ShouldBe(false);
            new FastColor("#fff").IsDark().ShouldBe(false);
        }

        [Fact]
        public void IsLight_Returns_True_Or_False_For_Dark_Or_Light_Colors()
        {
            new FastColor("#000").IsLight().ShouldBe(false);
            new FastColor("#111").IsLight().ShouldBe(false);
            new FastColor("#222").IsLight().ShouldBe(false);
            new FastColor("#333").IsLight().ShouldBe(false);
            new FastColor("#444").IsLight().ShouldBe(false);
            new FastColor("#555").IsLight().ShouldBe(false);
            new FastColor("#666").IsLight().ShouldBe(false);
            new FastColor("#777").IsLight().ShouldBe(false);
            new FastColor("#888").IsLight().ShouldBe(true);
            new FastColor("#999").IsLight().ShouldBe(true);
            new FastColor("#aaa").IsLight().ShouldBe(true);
            new FastColor("#bbb").IsLight().ShouldBe(true);
            new FastColor("#ccc").IsLight().ShouldBe(true);
            new FastColor("#ddd").IsLight().ShouldBe(true);
            new FastColor("#eee").IsLight().ShouldBe(true);
            new FastColor("#fff").IsLight().ShouldBe(true);
        }

        [Fact]
        public void Color_Equality()
        {
            new FastColor("#ff0000").Equals(new FastColor("#ff0000")).ShouldBe(true);
            new FastColor("#ff0000").Equals(new FastColor("rgb(255,0,0)")).ShouldBe(true);
            new FastColor("#ff0000").Equals(new FastColor("rgba(255,0,0,.1)")).ShouldBe(false);
            new FastColor("#ff000066").Equals(new FastColor("rgba(255,0,0,.4)")).ShouldBe(true);
            new FastColor("#f009").Equals(new FastColor("rgba(255,0,0,.6)")).ShouldBe(true);
            new FastColor("#336699CC").Equals(new FastColor("#369C")).ShouldBe(true);
            new FastColor("#f00").Equals(new FastColor("#ff0000")).ShouldBe(true);
            new FastColor("#f00").Equals(new FastColor("#ff0000")).ShouldBe(true);
            new FastColor("#ff0000").Equals(new FastColor("#00ff00")).ShouldBe(false);
            new FastColor("#ff8000").Equals(new FastColor("rgb(100%, 50%, 0%)")).ShouldBe(true);
        }

        [Fact]
        public void OnBackground()
        {
            new FastColor("#ffffff").OnBackground(new FastColor("#000")).ToHexString().ShouldBe("#ffffff");
            new FastColor("#ffffff00").OnBackground(new FastColor("#000")).ToHexString().ShouldBe("#000000");
            new FastColor("#ffffff77").OnBackground(new FastColor("#000")).ToHexString().ShouldBe("#777777");
            new FastColor("#262a6d82").OnBackground(new FastColor("#644242")).ToHexString().ShouldBe("#443658");
            new FastColor("rgba(255,0,0,0.5)").OnBackground(new FastColor("rgba(0,255,0,0.5)")).ToRgbString().ShouldBe("rgba(170,85,0,0.75)");
            new FastColor("rgba(255,0,0,0.5)").OnBackground(new FastColor("rgba(0,0,255,1)")).ToRgbString().ShouldBe("rgb(128,0,128)");
            new FastColor("rgba(0,0,255,1)").OnBackground(new FastColor("rgba(0,0,0,0.5)")).ToRgbString().ShouldBe("rgb(0,0,255)");
        }

        [Fact]
        public void Default_Of_Empty()
        {
            new FastColor("").ToRgb().ShouldBe(new RGBA
            {
                R = 0,
                G = 0,
                B = 0,
                A = 1
            });
        }

        [Fact]
        public void Mix_Should_Round()
        {
            var source = new FastColor("rgba(255, 255, 255, 0.1128)");
            var target = new FastColor("rgba(0, 0, 0, 0.93)");

            var mixed = source.Mix(target, 50);

            mixed.ToRgbString().ShouldBe("rgba(128,128,128,0.52)");
        }

        [Fact]
        public void Hsv_Object_To_Hex()
        {
            new FastColor(new HSV { H = 270, S = 0.6, V = 0.4 }).ToHexString().ShouldBe("#472966");
        }

        [Fact]
        public void Hsv_String_To_Hex()
        {
            new FastColor("hsv(270, 60%, 40%)").ToHexString().ShouldBe("#472966");
        }

        [Fact]
        public void Hsb_String_To_Hex()
        {
            new FastColor("hsb(270 60 40)").ToHexString().ShouldBe("#472966");
        }

        [Fact]
        public void Hex_To_Hsv_Object ()
        {
            new FastColor("#472966").ToHsv().ShouldBe(new HSVA
            {
                H = 270,
                S = 0.5980392156862745,
                V = 0.4,
                A = 1,
            });
        }

        [Fact]
        public void Should_Be_Same_RGB()
        {
            var baseColor = new FastColor(new HSV
            {
                H = 180,
                S = 0,
                V = 0,
            });

            var turn = baseColor.SetHue(0);

            baseColor.ToHexString().ShouldBe(turn.ToHexString());
        }

        [Fact]
        public void Clone_Should_Be_Same_Hsv()
        {
            var baseColor = new FastColor(new HSV{
                H = 180,
                S = 0,
                V = 0,
            });

            var turn = baseColor.Clone();
            baseColor.ToHsv().ShouldBe(turn.ToHsv());
        }

        [Fact]
        public void SetHue_Should_Be_Stable()
        {
            var baseColor = new FastColor("#1677ff");
            baseColor.GetValue().ShouldBe(1);

            var turn = baseColor.SetHue(233);
            turn.GetValue().ShouldBe(1);
        }

        [Fact]
        public void New_Space_Separated_Syntax_Without_Units()
        {
            new FastColor("hsl(270 60 40)").ToRgb().ShouldBe(new RGBA
            {
                R = 102,
                G = 41,
                B = 163,
                A = 1,
            });

            new FastColor("hsl(270 60 40 / 0.2)").ToRgb().ShouldBe(new RGBA
            {
                R = 102,
                G = 41,
                B = 163,
                A = 0.2,
            });

            new FastColor("hsl(270 60 40 / .2)").ToRgb().ShouldBe(new RGBA
            {
                R = 102,
                G = 41,
                B = 163,
                A = 0.2,
            });

            new FastColor("hsl(270 60 40 / 0.233)").ToRgb().ShouldBe(new RGBA
            {
                R = 102,
                G = 41,
                B = 163,
                A = 0.233,
            });

            new FastColor("hsl(270 60 40 / .233)").ToRgb().ShouldBe(new RGBA
            {
                R = 102,
                G = 41,
                B = 163,
                A = 0.233,
            });
        }

        [Fact]
        public void New_Space_Separated_Syntax_With_Units()
        {
            new FastColor("hsl(270 60 40)").ToRgb().ShouldBe(new RGBA
            {
                R = 102,
                G = 41,
                B = 163,
                A = 1,
            });

            new FastColor("hsl(270 60 40 / 20%)").ToRgb().ShouldBe(new RGBA
            {
                R = 102,
                G = 41,
                B = 163,
                A = 0.2,
            });

            new FastColor("hsl(270 60 40 / 23.3%)").ToRgb().ShouldBe(new RGBA
            {
                R = 102,
                G = 41,
                B = 163,
                A = 0.233,
            });
        }

        [Fact]
        public void Old_Comma_Separated_Syntax_Without_Units()
        {
            new FastColor("hsl(270, 60, 40)").ToRgb().ShouldBe(new RGBA
            {
                R = 102,
                G = 41,
                B = 163,
                A = 1,
            });

            new FastColor("hsla(270, 60, 40, 0.2)").ToRgb().ShouldBe(new RGBA{
                R = 102,
                G = 41,
                B = 163,
                A = 0.2,
            });

            new FastColor("hsla(270, 60, 40, .2)").ToRgb().ShouldBe(new RGBA
            {
                R = 102,
                G = 41,
                B = 163,
                A = 0.2,
            });

            new FastColor("hsla(270, 60, 40, 0.233)").ToRgb().ShouldBe(new RGBA
            {
                R = 102,
                G = 41,
                B = 163,
                A = 0.233,
            });

            new FastColor("hsla(270, 60, 40, .233)").ToRgb().ShouldBe(new RGBA
            {
                R = 102,
                G = 41,
                B = 163,
                A = 0.233,
            });
        }

        [Fact]
        public void Old_Comma_Separated_Syntax_With_Units()
        {
            new FastColor("hsl(270deg, 60%, 40%)").ToRgb().ShouldBe(new RGBA
            {
                R = 102,
                G = 41,
                B = 163,
                A = 1,
            });

            new FastColor("hsla(270deg, 60%, 40%, 20%)").ToRgb().ShouldBe(new RGBA
            {
                R = 102,
                G = 41,
                B = 163,
                A = 0.2,
            });

            new FastColor("hsla(270deg, 60%, 40%, 23.3%)").ToRgb().ShouldBe(new RGBA
            {
                R = 102,
                G = 41,
                B = 163,
                A = 0.233,
            });

            // String back
            new FastColor("hsla(270, 60, 40, 0.2)").ToHslString().ShouldBe("hsla(270,60%,40%,0.2)");

            new FastColor("hsla(270deg, 60%, 40%, 23.3%)").ToHslString().ShouldBe("hsla(270,60%,40%,0.233)");
        }

        [Fact]
        public void New_Space_Separated_Syntax()
        {
            new FastColor("rgb(255 255 255)").ToRgb().ShouldBe(new RGBA
            {
                R = 255,
                G = 255,
                B = 255,
                A = 1,
            });

            new FastColor("rgb(255 255 255 / 0.2)").ToRgb().ShouldBe(new RGBA
            {
                R = 255,
                G = 255,
                B = 255,
                A = 0.2,
            });

            new FastColor("rgb(255 255 255 / .2)").ToRgb().ShouldBe(new RGBA
            {
                R = 255,
                G = 255,
                B = 255,
                A = 0.2,
            });

            new FastColor("rgb(255 255 255 / 0.233)").ToRgb().ShouldBe(new RGBA
            {
                R = 255,
                G = 255,
                B = 255,
                A = 0.233,
            });

            new FastColor("rgb(255 255 255 / .233)").ToRgb().ShouldBe(new RGBA
            {
                R = 255,
                G = 255,
                B = 255,
                A = 0.233,
            });

            new FastColor("rgb(100% 100% 100%)").ToRgb().ShouldBe(new RGBA
            {
                R = 255,
                G = 255,
                B = 255,
                A = 1,
            });

            new FastColor("rgb(100% 100% 100%)").ToRgb().ShouldBe(new RGBA
            {
                R = 255,
                G = 255,
                B = 255,
                A = 1,
            });

            new FastColor("rgb(100% 100% 100% / 20%)").ToRgb().ShouldBe(new RGBA
            {
                R = 255,
                G = 255,
                B = 255,
                A = 0.2,
            });

            new FastColor("rgb(100% 100% 100% / 23.3%)").ToRgb().ShouldBe(new RGBA
            {
                R = 255,
                G = 255,
                B = 255,
                A = 0.233,
            });
        }

        [Fact]
        public void Old_Comma_Separated_Syntax()
        {
            new FastColor("rgb(255, 255, 255)").ToRgb().ShouldBe(new RGBA
            {
                R = 255,
                G = 255,
                B = 255,
                A = 1,
            });

            new FastColor("rgba(255, 255, 255, 0.2)").ToRgb().ShouldBe(new RGBA
            {
                R = 255,
                G = 255,
                B = 255,
                A = 0.2,
            });

            new FastColor("rgba(255, 255, 255, .2)").ToRgb().ShouldBe(new RGBA
            {
                R = 255,
                G = 255,
                B = 255,
                A = 0.2,
            });

            new FastColor("rgba(255, 255, 255, 0.233)").ToRgb().ShouldBe(new RGBA
            {
                R = 255,
                G = 255,
                B = 255,
                A = 0.233,
            });

            new FastColor("rgba(255, 255, 255, .233)").ToRgb().ShouldBe(new RGBA
            {
                R = 255,
                G = 255,
                B = 255,
                A = 0.233,
            });

            new FastColor("rgb(100%, 100%, 100%)").ToRgb().ShouldBe(new RGBA
            {
                R = 255,
                G = 255,
                B = 255,
                A = 1,
            });

            new FastColor("rgba(100%, 100%, 100%, 20%)").ToRgb().ShouldBe(new RGBA
            {
                R = 255,
                G = 255,
                B = 255,
                A = 0.2,
            });

            new FastColor("rgba(100%, 100%, 100%, 23.3%)").ToRgb().ShouldBe(new RGBA
            {
                R = 255,
                G = 255,
                B = 255,
                A = 0.233,
            });
        }

        [Fact]
        public void Invalid_Rgb()
        {
            new FastColor("rgb").ToRgb().ShouldBe(new RGBA
            {
                R = 0,
                G = 0,
                B = 0,
                A = 1,
            });
        }

        [Fact]
        public void Rgb_With_Extra_Stop()
        {
            new FastColor("rgb(255, 90, 30) 0%").ToRgb().ShouldBe(new RGBA
            {
                R = 255,
                G = 90,
                B = 30,
                A = 1,
            });
        }

        [Fact]
        public void Pure_Rbg()
        {
            new FastColor("FF00FF").ToRgb().ShouldBe(new RGBA
            {
                R = 255,
                G = 0,
                B = 255,
                A = 1,
            });
        }
    }
}
