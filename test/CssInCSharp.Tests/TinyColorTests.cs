using CssInCSharp.Colors;
using Shouldly;
using Xunit;

namespace CssInCSharp.Tests
{
    public class TinyColorTests
    {
        [Fact]
        public void Should_Init()
        {
            var r = new TinyColor("red");
            r.ToName().ShouldBe("red");
        }

        [Fact]
        public void Should_Clone()
        {
            var color1 = new TinyColor("red");
            var color2 = new TinyColor("red");
            color2.SetAlpha(0.5);
            color2.IsValid.ShouldBeTrue();
            color2.ToString().ShouldBe("rgba(255, 0, 0, 0.5)");
            color1.ToString().ShouldBe("red");
        }

        [Fact]
        public void Should_Parse_Options()
        {
            new TinyColor("red", new() { Format = "hex" }).ToString().ShouldBe("#ff0000");
            TinyColor.FromRatio(new RatioInput(1, 0, 0), new() { Format = "hex" }).ToString().ShouldBe("#ff0000");
        }

        [Fact]
        public void Should_Parse_Ratio()
        {
            TinyColor.FromRatio(new RatioInput(1, 1, 1)).ToHexString().ShouldBe("#ffffff");
            TinyColor.FromRatio(new RatioInput(1, 0, 0, 0.5)).ToRgbString().ShouldBe("rgba(255, 0, 0, 0.5)");
            TinyColor.FromRatio(new RatioInput(1, 0, 0, 1)).ToRgbString().ShouldBe("rgb(255, 0, 0)");
            TinyColor.FromRatio(new RatioInput(1, 0, 0, 10)).ToRgbString().ShouldBe("rgb(255, 0, 0)");
            TinyColor.FromRatio(new RatioInput(1, 0, 0, -1)).ToRgbString().ShouldBe("rgb(255, 0, 0)");
            new TinyColor(new RGB(1, 1, 1)).ToHexString().ShouldBe("#010101");
            new TinyColor(new RGB(0.1, 0.1, 0.1)).ToHexString().ShouldBe("#000000");
            new TinyColor("rgb .1 .1 .1").ToHexString().ShouldBe("#000000");
        }

        [Fact]
        public void Should_Parse_Hex()
        {
            new TinyColor("#000").ToHexString(true).ShouldBe("#000");
            new TinyColor("#0000").ToHexString(true).ShouldBe("#000");
            new TinyColor("#000").GetAlpha().ShouldBe(1);
            new TinyColor("#0000").GetAlpha().ShouldBe(0);
        }

        [Fact]
        public void Should_Parse_Rgb()
        {
            new TinyColor("rgb 255 0 0").ToHexString().ShouldBe("#ff0000");
            new TinyColor("rgb(255, 0, 0)").ToHexString().ShouldBe("#ff0000");
            new TinyColor("rgb (255, 0, 0)").ToHexString().ShouldBe("#ff0000");
            new TinyColor(new RGB(255, 0, 0)).ToHexString().ShouldBe("#ff0000");
            new TinyColor(new RGB(255, 0, 0)).ToRgb().ShouldBe(new RGBA(255, 0, 0, 1));
            new TinyColor(new RGB(200, 100, 0)).Equals("rgb(200, 100, 0)").ShouldBeTrue();
            new TinyColor(new RGB(200, 100, 0)).Equals("rgb 200 100 0").ShouldBeTrue();
            new TinyColor(new RGBA(200, 100, 0, 0.4)).Equals("rgba 200 100 0 .4").ShouldBeTrue();
            new TinyColor(new RGB(199, 100, 0)).Equals(null).ShouldBeFalse();
            new TinyColor(null).Equals(new TinyColor(new RGB(200, 100, 0))).ShouldBeFalse();
        }

        [Fact]
        public void Should_Parse_Percentage_Rgb_Text()
        {
            new TinyColor("rgb 100% 0% 0%").ToHexString().ShouldBe("#ff0000");
            new TinyColor("rgb(100%, 0%, 0%)").ToHexString().ShouldBe("#ff0000");
            new TinyColor("rgb (100%, 0%, 0%)").ToHexString().ShouldBe("#ff0000");
            new TinyColor(new RGB("100%", "0%", "0%")).ToHexString().ShouldBe("#ff0000");
            new TinyColor(new RGB("100%", "0%", "0%")).ToRgb().ShouldBe(new RGBA(255, 0, 0, 1));

            new TinyColor(new RGB("90%", "45%", "0%")).Equals("rgb(90%, 45%, 0%)").ShouldBeTrue();
            new TinyColor(new RGB("90%", "45%", "0%")).Equals("rgb 90% 45% 0%").ShouldBeTrue();
            new TinyColor(new RGB("90%", "45%", "0%")).Equals("rgb 90% 45% 0%").ShouldBeTrue();
            new TinyColor(new RGBA("90%", "45%", "0%", 0.4)).Equals("rgba 90% 45% 0% .4").ShouldBeTrue();

            new TinyColor(new RGB("89%", "45%", "0%")).Equals("rgba 90% 45% 0% 1").ShouldBeFalse();
            new TinyColor(new RGB("89%", "45%", "0%")).Equals("rgb(90%, 45%, 0%)").ShouldBeFalse();
            new TinyColor(new RGB("89%", "45%", "0%")).Equals("rgb 90% 45% 0%").ShouldBeFalse();
            new TinyColor(new RGB("89%", "45%", "0%")).Equals("rgb 90% 45% 0%").ShouldBeFalse();

            new TinyColor(new RGB("90%", "45%", "0%")).Equals(new TinyColor("rgb 90% 45% 0%")).ShouldBeTrue();
            new TinyColor(new RGB("90%", "45%", "0%")).Equals(new TinyColor("rgb(90%, 45%, 0%)")).ShouldBeTrue();
        }
    }
}
