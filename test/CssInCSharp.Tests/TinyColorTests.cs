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

        [Fact]
        public void Should_Parse_HSL()
        {
            new TinyColor(new HSL(251, 100, 0.38)).ToHexString().ShouldBe("#2400c2");
            new TinyColor(new HSL(251, 100, 0.38)).ToRgbString().ShouldBe("rgb(36, 0, 194)");
            new TinyColor(new HSL(251, 100, 0.38)).ToHslString().ShouldBe("hsl(251, 100%, 38%)");
            new TinyColor(new HSLA(251, 100, 0.38, 0.38)).ToHslString().ShouldBe("hsla(251, 100%, 38%, 0.38)");
            new TinyColor("hsl(251, 100, 38)").ToHexString().ShouldBe("#2400c2");
            new TinyColor("hsl(251, 100%, 38%)").ToRgbString().ShouldBe("rgb(36, 0, 194)");
            new TinyColor("hsl(251, 100%, 38%)").ToHslString().ShouldBe("hsl(251, 100%, 38%)");
            new TinyColor("hsl 100 20 10").ToHslString().ShouldBe("hsl(100, 20%, 10%)");
            new TinyColor("hsla 100 20 10 0.38").ToHslString().ShouldBe("hsla(100, 20%, 10%, 0.38)");
            new TinyColor("hsl -700 20 10").ToHslString().ShouldBe("hsl(20, 20%, 10%)");
            new TinyColor("hsl -490 100% 50%").ToHslString().ShouldBe("hsl(230, 100%, 50%)");
        }

        [Fact]
        public void Should_Parse_Rgb_Strings()
        {
            new TinyColor("rgb 255 0 0").ToHexString().ShouldBe("#ff0000");
            new TinyColor("rgb 255 0 0").ToHexString(true).ShouldBe("#f00");

            new TinyColor("rgba 255 0 0 0.5").ToHex8String().ShouldBe("#ff000080");
            new TinyColor("rgba 255 0 0 0").ToHex8String().ShouldBe("#ff000000");
            new TinyColor("rgba 255 0 0 1").ToHex8String().ShouldBe("#ff0000ff");
            new TinyColor("rgba 255 0 0 1").ToHex8String(true).ShouldBe("#f00f");

            new TinyColor("rgba 255 0 0 0").ToHexShortString().ShouldBe("#ff000000");
            new TinyColor("rgba 255 0 0 0").ToHexShortString(true).ShouldBe("#f000");
            new TinyColor("rgba 255 0 0 1").ToHexShortString().ShouldBe("#ff0000");
            new TinyColor("rgba 255 0 0 1").ToHexShortString(true).ShouldBe("#f00");

            new TinyColor("rgb 255 0 0").ToHex().ShouldBe("ff0000");
            new TinyColor("rgb 255 0 0").ToHex(true).ShouldBe("f00");
            new TinyColor("rgba 255 0 0 0.5").ToHex8().ShouldBe("ff000080");
        }

        [Fact]
        public void Should_Parse_Hsv_String()
        {
            new TinyColor("hsv 251.1 0.887 .918").Format.ShouldBe("hsv");
            new TinyColor("hsv 251.1 0.887 .918").ToHsvString().ShouldBe("hsv(251, 89%, 92%)");
            new TinyColor("hsv 251.1 0.887 0.918").ToHsvString().ShouldBe("hsv(251, 89%, 92%)");
            new TinyColor("hsva 251.1 0.887 0.918 0.5").ToHsvString().ShouldBe("hsva(251, 89%, 92%, 0.5)");
        }

        [Fact]
        public void Should_Parse_Invalid_Input()
        {
            var invalidColor = new TinyColor("not a color");
            invalidColor.ToHexString().ShouldBe("#000000");
            invalidColor.IsValid.ShouldBeFalse();

            invalidColor = new TinyColor("#red");
            invalidColor.ToHexString().ShouldBe("#000000");
            invalidColor.IsValid.ShouldBeFalse();
            
            invalidColor = new TinyColor("  #red");
            invalidColor.ToHexString().ShouldBe("#000000");
            invalidColor.IsValid.ShouldBeFalse();
            
            invalidColor = new TinyColor("##123456");
            invalidColor.ToHexString().ShouldBe("#000000");
            invalidColor.IsValid.ShouldBeFalse();
            
            invalidColor = new TinyColor("  ##123456");
            invalidColor.ToHexString().ShouldBe("#000000");
            invalidColor.IsValid.ShouldBeFalse();
            
            invalidColor = new TinyColor(new RGB("invalid", "invalid", "invalid"));
            invalidColor.ToHexString().ShouldBe("#000000");
            invalidColor.IsValid.ShouldBeFalse();
            
            invalidColor = new TinyColor(new HSL("invalid", "invalid", "invalid"));
            invalidColor.ToHexString().ShouldBe("#000000");
            invalidColor.IsValid.ShouldBeFalse();
            
            invalidColor = new TinyColor(new HSV("invalid", "invalid", "invalid"));
            invalidColor.ToHexString().ShouldBe("#000000");
            invalidColor.IsValid.ShouldBeFalse();
            
            invalidColor = new TinyColor();
            invalidColor.ToHexString().ShouldBe("#000000");
            invalidColor.IsValid.ShouldBeFalse();
        }

        [Fact]
        public void Should_Parse_Named_Colors()
        {
            new TinyColor("aliceblue").ToHex().ShouldBe("f0f8ff");
            new TinyColor("antiquewhite").ToHex().ShouldBe("faebd7");
            new TinyColor("aqua").ToHex().ShouldBe("00ffff");
            new TinyColor("aquamarine").ToHex().ShouldBe("7fffd4");
            new TinyColor("azure").ToHex().ShouldBe("f0ffff");
            new TinyColor("beige").ToHex().ShouldBe("f5f5dc");
            new TinyColor("bisque").ToHex().ShouldBe("ffe4c4");
            new TinyColor("black").ToHex().ShouldBe("000000");
            new TinyColor("blanchedalmond").ToHex().ShouldBe("ffebcd");
            new TinyColor("blue").ToHex().ShouldBe("0000ff");
            new TinyColor("blueviolet").ToHex().ShouldBe("8a2be2");
            new TinyColor("brown").ToHex().ShouldBe("a52a2a");
            new TinyColor("burlywood").ToHex().ShouldBe("deb887");
            new TinyColor("cadetblue").ToHex().ShouldBe("5f9ea0");
            new TinyColor("chartreuse").ToHex().ShouldBe("7fff00");
            new TinyColor("chocolate").ToHex().ShouldBe("d2691e");
            new TinyColor("coral").ToHex().ShouldBe("ff7f50");
            new TinyColor("cornflowerblue").ToHex().ShouldBe("6495ed");
            new TinyColor("cornsilk").ToHex().ShouldBe("fff8dc");
            new TinyColor("crimson").ToHex().ShouldBe("dc143c");
            new TinyColor("cyan").ToHex().ShouldBe("00ffff");
            new TinyColor("darkblue").ToHex().ShouldBe("00008b");
            new TinyColor("darkcyan").ToHex().ShouldBe("008b8b");
            new TinyColor("darkgoldenrod").ToHex().ShouldBe("b8860b");
            new TinyColor("darkgray").ToHex().ShouldBe("a9a9a9");
            new TinyColor("darkgreen").ToHex().ShouldBe("006400");
            new TinyColor("darkkhaki").ToHex().ShouldBe("bdb76b");
            new TinyColor("darkmagenta").ToHex().ShouldBe("8b008b");
            new TinyColor("darkolivegreen").ToHex().ShouldBe("556b2f");
            new TinyColor("darkorange").ToHex().ShouldBe("ff8c00");
            new TinyColor("darkorchid").ToHex().ShouldBe("9932cc");
            new TinyColor("darkred").ToHex().ShouldBe("8b0000");
            new TinyColor("darksalmon").ToHex().ShouldBe("e9967a");
            new TinyColor("darkseagreen").ToHex().ShouldBe("8fbc8f");
            new TinyColor("darkslateblue").ToHex().ShouldBe("483d8b");
            new TinyColor("darkslategray").ToHex().ShouldBe("2f4f4f");
            new TinyColor("darkturquoise").ToHex().ShouldBe("00ced1");
            new TinyColor("darkviolet").ToHex().ShouldBe("9400d3");
            new TinyColor("deeppink").ToHex().ShouldBe("ff1493");
            new TinyColor("deepskyblue").ToHex().ShouldBe("00bfff");
            new TinyColor("dimgray").ToHex().ShouldBe("696969");
            new TinyColor("dodgerblue").ToHex().ShouldBe("1e90ff");
            new TinyColor("firebrick").ToHex().ShouldBe("b22222");
            new TinyColor("floralwhite").ToHex().ShouldBe("fffaf0");
            new TinyColor("forestgreen").ToHex().ShouldBe("228b22");
            new TinyColor("fuchsia").ToHex().ShouldBe("ff00ff");
            new TinyColor("gainsboro").ToHex().ShouldBe("dcdcdc");
            new TinyColor("ghostwhite").ToHex().ShouldBe("f8f8ff");
            new TinyColor("gold").ToHex().ShouldBe("ffd700");
            new TinyColor("goldenrod").ToHex().ShouldBe("daa520");
            new TinyColor("gray").ToHex().ShouldBe("808080");
            new TinyColor("grey").ToHex().ShouldBe("808080");
            new TinyColor("green").ToHex().ShouldBe("008000");
            new TinyColor("greenyellow").ToHex().ShouldBe("adff2f");
            new TinyColor("honeydew").ToHex().ShouldBe("f0fff0");
            new TinyColor("hotpink").ToHex().ShouldBe("ff69b4");
            new TinyColor("indianred ").ToHex().ShouldBe("cd5c5c");
            new TinyColor("indigo ").ToHex().ShouldBe("4b0082");
            new TinyColor("ivory").ToHex().ShouldBe("fffff0");
            new TinyColor("khaki").ToHex().ShouldBe("f0e68c");
            new TinyColor("lavender").ToHex().ShouldBe("e6e6fa");
            new TinyColor("lavenderblush").ToHex().ShouldBe("fff0f5");
            new TinyColor("lawngreen").ToHex().ShouldBe("7cfc00");
            new TinyColor("lemonchiffon").ToHex().ShouldBe("fffacd");
            new TinyColor("lightblue").ToHex().ShouldBe("add8e6");
            new TinyColor("lightcoral").ToHex().ShouldBe("f08080");
            new TinyColor("lightcyan").ToHex().ShouldBe("e0ffff");
            new TinyColor("lightgoldenrodyellow").ToHex().ShouldBe("fafad2");
            new TinyColor("lightgrey").ToHex().ShouldBe("d3d3d3");
            new TinyColor("lightgreen").ToHex().ShouldBe("90ee90");
            new TinyColor("lightpink").ToHex().ShouldBe("ffb6c1");
            new TinyColor("lightsalmon").ToHex().ShouldBe("ffa07a");
            new TinyColor("lightseagreen").ToHex().ShouldBe("20b2aa");
            new TinyColor("lightskyblue").ToHex().ShouldBe("87cefa");
            new TinyColor("lightslategray").ToHex().ShouldBe("778899");
            new TinyColor("lightsteelblue").ToHex().ShouldBe("b0c4de");
            new TinyColor("lightyellow").ToHex().ShouldBe("ffffe0");
            new TinyColor("lime").ToHex().ShouldBe("00ff00");
            new TinyColor("limegreen").ToHex().ShouldBe("32cd32");
            new TinyColor("linen").ToHex().ShouldBe("faf0e6");
            new TinyColor("magenta").ToHex().ShouldBe("ff00ff");
            new TinyColor("maroon").ToHex().ShouldBe("800000");
            new TinyColor("mediumaquamarine").ToHex().ShouldBe("66cdaa");
            new TinyColor("mediumblue").ToHex().ShouldBe("0000cd");
            new TinyColor("mediumorchid").ToHex().ShouldBe("ba55d3");
            new TinyColor("mediumpurple").ToHex().ShouldBe("9370db");
            new TinyColor("mediumseagreen").ToHex().ShouldBe("3cb371");
            new TinyColor("mediumslateblue").ToHex().ShouldBe("7b68ee");
            new TinyColor("mediumspringgreen").ToHex().ShouldBe("00fa9a");
            new TinyColor("mediumturquoise").ToHex().ShouldBe("48d1cc");
            new TinyColor("mediumvioletred").ToHex().ShouldBe("c71585");
            new TinyColor("midnightblue").ToHex().ShouldBe("191970");
            new TinyColor("mintcream").ToHex().ShouldBe("f5fffa");
            new TinyColor("mistyrose").ToHex().ShouldBe("ffe4e1");
            new TinyColor("moccasin").ToHex().ShouldBe("ffe4b5");
            new TinyColor("navajowhite").ToHex().ShouldBe("ffdead");
            new TinyColor("navy").ToHex().ShouldBe("000080");
            new TinyColor("oldlace").ToHex().ShouldBe("fdf5e6");
            new TinyColor("olive").ToHex().ShouldBe("808000");
            new TinyColor("olivedrab").ToHex().ShouldBe("6b8e23");
            new TinyColor("orange").ToHex().ShouldBe("ffa500");
            new TinyColor("orangered").ToHex().ShouldBe("ff4500");
            new TinyColor("orchid").ToHex().ShouldBe("da70d6");
            new TinyColor("palegoldenrod").ToHex().ShouldBe("eee8aa");
            new TinyColor("palegreen").ToHex().ShouldBe("98fb98");
            new TinyColor("paleturquoise").ToHex().ShouldBe("afeeee");
            new TinyColor("palevioletred").ToHex().ShouldBe("db7093");
            new TinyColor("papayawhip").ToHex().ShouldBe("ffefd5");
            new TinyColor("peachpuff").ToHex().ShouldBe("ffdab9");
            new TinyColor("peru").ToHex().ShouldBe("cd853f");
            new TinyColor("pink").ToHex().ShouldBe("ffc0cb");
            new TinyColor("plum").ToHex().ShouldBe("dda0dd");
            new TinyColor("powderblue").ToHex().ShouldBe("b0e0e6");
            new TinyColor("purple").ToHex().ShouldBe("800080");
            new TinyColor("rebeccapurple").ToHex().ShouldBe("663399");
            new TinyColor("red").ToHex().ShouldBe("ff0000");
            new TinyColor("rosybrown").ToHex().ShouldBe("bc8f8f");
            new TinyColor("royalblue").ToHex().ShouldBe("4169e1");
            new TinyColor("saddlebrown").ToHex().ShouldBe("8b4513");
            new TinyColor("salmon").ToHex().ShouldBe("fa8072");
            new TinyColor("sandybrown").ToHex().ShouldBe("f4a460");
            new TinyColor("seagreen").ToHex().ShouldBe("2e8b57");
            new TinyColor("seashell").ToHex().ShouldBe("fff5ee");
            new TinyColor("sienna").ToHex().ShouldBe("a0522d");
            new TinyColor("silver").ToHex().ShouldBe("c0c0c0");
            new TinyColor("skyblue").ToHex().ShouldBe("87ceeb");
            new TinyColor("slateblue").ToHex().ShouldBe("6a5acd");
            new TinyColor("slategray").ToHex().ShouldBe("708090");
            new TinyColor("snow").ToHex().ShouldBe("fffafa");
            new TinyColor("springgreen").ToHex().ShouldBe("00ff7f");
            new TinyColor("steelblue").ToHex().ShouldBe("4682b4");
            new TinyColor("tan").ToHex().ShouldBe("d2b48c");
            new TinyColor("teal").ToHex().ShouldBe("008080");
            new TinyColor("thistle").ToHex().ShouldBe("d8bfd8");
            new TinyColor("tomato").ToHex().ShouldBe("ff6347");
            new TinyColor("turquoise").ToHex().ShouldBe("40e0d0");
            new TinyColor("violet").ToHex().ShouldBe("ee82ee");
            new TinyColor("wheat").ToHex().ShouldBe("f5deb3");
            new TinyColor("white").ToHex().ShouldBe("ffffff");
            new TinyColor("whitesmoke").ToHex().ShouldBe("f5f5f5");
            new TinyColor("yellow").ToHex().ShouldBe("ffff00");
            new TinyColor("yellowgreen").ToHex().ShouldBe("9acd32");

            new TinyColor("#f00").ToName().ShouldBe("red");
            new TinyColor("#fa0a0a").ToName().ShouldBeNull();
        }

        [Fact]
        public void Invalid_Alpha_Should_Normalize_To_1()
        {
            new TinyColor(new RGBA(255, 20, 10, -1)).ToRgbString().ShouldBe("rgb(255, 20, 10)");
            new TinyColor(new RGBA(255, 20, 10, -0)).ToRgbString().ShouldBe("rgba(255, 20, 10, 0)");
            new TinyColor(new RGBA(255, 20, 10, 0)).ToRgbString().ShouldBe("rgba(255, 20, 10, 0)");
            new TinyColor(new RGBA(255, 20, 10, 0.5)).ToRgbString().ShouldBe("rgba(255, 20, 10, 0.5)");
            new TinyColor(new RGBA(255, 20, 10, 1)).ToRgbString().ShouldBe("rgb(255, 20, 10)");
            new TinyColor(new RGBA(255, 20, 10, 100)).ToRgbString().ShouldBe("rgb(255, 20, 10)");
            new TinyColor(new RGBA(255, 20, 10, "asdfasd")).ToRgbString().ShouldBe("rgb(255, 20, 10)");
            new TinyColor("#fff").ToRgbString().ShouldBe("rgb(255, 255, 255)");
            new TinyColor("rgba 255 0 0 100").ToRgbString().ShouldBe("rgb(255, 0, 0)");
        }

        [Fact]
        public void Should_Translate_ToString_With_Alpha_Set()
        {
            var redNamed = TinyColor.FromRatio(new RatioInput(255, 0, 0, 0.6), new() { Format = "name" });
            var redHex = TinyColor.FromRatio(new RatioInput(255, 0, 0, 0.4), new() { Format = "hex" });

            redNamed.Format.ShouldBe("name");
            redHex.Format.ShouldBe("hex");

            redNamed.ToString().ShouldBe("rgba(255, 0, 0, 0.6)");
            redHex.ToString().ShouldBe("rgba(255, 0, 0, 0.4)");

            redNamed.ToString("hex").ShouldBe("#ff0000");
            redNamed.ToString("hex6").ShouldBe("#ff0000");
            redNamed.ToString("hex3").ShouldBe("#f00");
            redNamed.ToString("hex8").ShouldBe("#ff000099");
            redNamed.ToString("hex4").ShouldBe("#f009");
            redNamed.ToString("name").ShouldBe("#ff0000");
            redNamed.ToName().ShouldBeNull();

            redHex.ToString().ShouldBe("rgba(255, 0, 0, 0.4)");

            var transparentNamed = TinyColor.FromRatio(new(255, 0, 0, 0), new() { Format = "name" });
            transparentNamed.ToString().ShouldBe("transparent");

            redHex.SetAlpha(0);
            redHex.ToString().ShouldBe("rgba(255, 0, 0, 0)");
            redHex.SetAlpha(0.38);
            redHex.ToString().ShouldBe("rgba(255, 0, 0, 0.38)");
        }

        [Fact]
        public void Should_Get_Alpha()
        {
            var hexSetter = new TinyColor("rgba(255, 0, 0, 1)");
            hexSetter.GetAlpha().ShouldBe(1);

            var returnedFromSetAlpha = hexSetter.SetAlpha(0.9);
            returnedFromSetAlpha.GetAlpha().ShouldBe(0.9);

            hexSetter.SetAlpha(0.5);
            hexSetter.GetAlpha().ShouldBe(0.5);
        }

        [Fact]
        public void Should_Set_Alpha()
        {
            var hexSetter = new TinyColor("rgba(255, 0, 0, 1)");
            hexSetter.A.ShouldBe(1);
            var returnedFromSetAlpha = hexSetter.SetAlpha(0.9);
            returnedFromSetAlpha.ShouldBe(hexSetter);
            hexSetter.A.ShouldBe(0.9);
            hexSetter.SetAlpha(0.5);
            hexSetter.A.ShouldBe(0.5);
            hexSetter.SetAlpha(0);
            hexSetter.A.ShouldBe(0);
            hexSetter.SetAlpha(-1);
            hexSetter.A.ShouldBe(1);
            hexSetter.SetAlpha(2);
            hexSetter.A.ShouldBe(1);
        }

        [Fact]
        public void Alpha_0_Should_Act_Differently_On_ToName()
        {
            new TinyColor(new RGBA(255, 20, 10, 0)).ToName().ShouldBe("transparent");
            new TinyColor("transparent").ToString().ShouldBe("transparent");
            new TinyColor("transparent").ToHex().ShouldBe("000000");
        }

        [Fact]
        public void Should_GetBrightness()
        {
            new TinyColor("#000").GetBrightness().ShouldBe(0);
            new TinyColor("#fff").GetBrightness().ShouldBe(255);
        }

        [Fact]
        public void Should_GetLuminance()
        {
            new TinyColor("#000").GetLuminance().ShouldBe(0);
            new TinyColor("#fff").GetLuminance().ShouldBe(1);
        }

        [Fact]
        public void Is_Dark_Or_Light_Colors()
        {
            new TinyColor("#000").IsDark().ShouldBe(true);
            new TinyColor("#111").IsDark().ShouldBe(true);
            new TinyColor("#222").IsDark().ShouldBe(true);
            new TinyColor("#333").IsDark().ShouldBe(true);
            new TinyColor("#444").IsDark().ShouldBe(true);
            new TinyColor("#555").IsDark().ShouldBe(true);
            new TinyColor("#666").IsDark().ShouldBe(true);
            new TinyColor("#777").IsDark().ShouldBe(true);
            new TinyColor("#888").IsDark().ShouldBe(false);
            new TinyColor("#999").IsDark().ShouldBe(false);
            new TinyColor("#aaa").IsDark().ShouldBe(false);
            new TinyColor("#bbb").IsDark().ShouldBe(false);
            new TinyColor("#ccc").IsDark().ShouldBe(false);
            new TinyColor("#ddd").IsDark().ShouldBe(false);
            new TinyColor("#eee").IsDark().ShouldBe(false);
            new TinyColor("#fff").IsDark().ShouldBe(false);

            new TinyColor("#000").IsLight().ShouldBe(false);
            new TinyColor("#111").IsLight().ShouldBe(false);
            new TinyColor("#222").IsLight().ShouldBe(false);
            new TinyColor("#333").IsLight().ShouldBe(false);
            new TinyColor("#444").IsLight().ShouldBe(false);
            new TinyColor("#555").IsLight().ShouldBe(false);
            new TinyColor("#666").IsLight().ShouldBe(false);
            new TinyColor("#777").IsLight().ShouldBe(false);
            new TinyColor("#888").IsLight().ShouldBe(true);
            new TinyColor("#999").IsLight().ShouldBe(true);
            new TinyColor("#aaa").IsLight().ShouldBe(true);
            new TinyColor("#bbb").IsLight().ShouldBe(true);
            new TinyColor("#ccc").IsLight().ShouldBe(true);
            new TinyColor("#ddd").IsLight().ShouldBe(true);
            new TinyColor("#eee").IsLight().ShouldBe(true);
            new TinyColor("#fff").IsLight().ShouldBe(true);
        }
    }
}
