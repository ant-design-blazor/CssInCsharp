using static CssInCs.Compiler.Parser;
using static CssInCs.Compiler.Serializer;
using Shouldly;
using Xunit;

namespace CssInCs.Tests
{
    public class ParserTests
    {
        private Func<string, string> stylis = (input) => Serialize(Compile($".user{{{input}}}"), Stringify);

        [Fact]
        public void Unnested()
        {
            Serialize(Compile("--foo:none;@supports{--bar:none;}"), Stringify).ShouldBe("--foo:none;@supports{--bar:none;}");
        }

        [Fact]
        public void Escape()
        {
            stylis("height:calc(\\))\t!important;").ShouldBe(".user{height:calc(\\))!important;}");
        }

        [Fact]
        public void Calc()
        {
            stylis(@"
    height:calc( 100vh - 1px );
    height:calc(
      100vh -
          1px
        );").ShouldBe(".user{height:calc( 100vh - 1px );height:calc(\r\n      100vh -\r\n          1px\r\n        );}");
        }

        [Fact]
        public void AtRules()
        {
            stylis(@"
        @-ms-viewport {
          width:device-width;
        }
        @viewport {
          width:device-width;
        }
        @page & {
          invalid:true;
        }
        @page {
          size:A4 landscape;
        }
        @document url(://www.w3.org/),url-prefix(//www.w3.org/),domain(mozilla.org),regexp(""https:.*"") {
          body {
            color: red;
          }
        }
        @viewport {
          min-width:640px;
          max-width:800px;
        }
        @counter-style list {
          system:fixed;
          symbols:url();
          suffix:"" "";
        }
        @-moz-document url-prefix() {
          .selector {
            color:lime;
          }
        }
        @page {
          color:red;
          @bottom-right {
            content: counter(pages);
            margin-right: 1cm;
          }
          width: none;
        }").ShouldBe(string.Join("",
                "@-ms-viewport{width:device-width;}",
                "@viewport{width:device-width;}",
                "@page &{invalid:true;}",
                "@page{size:A4 landscape;}",
                "@document url(://www.w3.org/),url-prefix(//www.w3.org/),domain(mozilla.org),regexp(\"https:.*\"){.user body{color:red;}}",
                "@viewport{min-width:640px;max-width:800px;}",
                "@counter-style list{system:fixed;symbols:url();suffix:\" \";}",
                "@-moz-document url-prefix(){.user .selector{color:lime;}}",
                "@page{color:red;@bottom-right{content:counter(pages);margin-right:1cm;}width:none;}"));
        }

        [Fact]
        public void UniversalSelector()
        {
            stylis(@"
        * {
          color:red;
        }
        svg {
          &, & * {
            fill: currentColor;
          }
        }
        * * {color:hotpink;}").ShouldBe(string.Join("", 
                ".user *{color:red;}",
                ".user svg,.user svg *{fill:currentColor;}",
                ".user * *{color:hotpink;}"));
        }

        [Fact]
        public void Flat()
        {
            stylis(@"
                color:20px;
                font-size:20px
            ").ShouldBe(".user{color:20px;font-size:20px;}");
        }

        [Fact]
        public void Namespace()
        {
            stylis(@"
        & {
          color:red;
        }").ShouldBe(".user{color:red;}");
        }

        [Fact]
        public void Ampersand_In_Nested_Function()
        {
            var urlOneX = "https://images.ctfassets.net/test.jpg?fm=webp&q=70&w=1000";
            var urlTwoX = "https://images.ctfassets.net/test.jpg?fm=webp&q=70&w=2000";
            stylis(@$"
                background-image: image-set(url({urlOneX}) 1x, url({urlTwoX}) 2x);"
            ).ShouldBe($".user{{background-image:image-set(url({urlOneX}) 1x, url({urlTwoX}) 2x);}}");
        }

        [Fact]
        public void Ampersand_In_String()
        {
            stylis(@"
                & [href=""https://css-tricks.com?a=1&b=2""] {
                  color:red;
                }"
            ).ShouldBe(".user [href=\"https://css-tricks.com?a=1&b=2\"]{color:red;}");
        }

        [Fact]
        public void Escaped_Chars_In_Selector_Identifiers()
        {
            stylis(@"
        &.B\&W{color:red;}
        &.\@example\.com{color:blue;}
        &.owner\/founder{color:green;}
        &.discount\%  {color:purple;}"
            ).ShouldBe(string.Join("",
                ".user.B\\&W{color:red;}",
                ".user.\\@example\\.com{color:blue;}",
                ".user.owner\\/founder{color:green;}",
                ".user.discount\\%{color:purple;}"
            ));
        }

        [Fact]
        public void Escaped_Hex_Codes_In_Selector_Identifiers()
        {
            stylis(@"
        &.B\26W{color:red;}
        &.B\000026W{color:green;}
        &.B\26 W{color:blue;}"
            ).ShouldBe(string.Join("", 
                ".user.B\\26W{color:red;}",
                ".user.B\\000026W{color:green;}",
                ".user.B\\26 W{color:blue;}"
            ));
        }

        [Fact]
        public void Double_Spaces_After_Escaped_Hex_Codes_In_Selector_Identifiers()
        {
            stylis(@"
        &.endsWith\0000A9  a.childNode{color:green;}
        &.endsWith\AE  a.childNode{color:yellow;}
        &.Q\000026A  a.childNode{color:purple;}"
            ).ShouldBe(string.Join("", 
                ".user.endsWith\\0000A9  a.childNode{color:green;}",
                ".user.endsWith\\AE  a.childNode{color:yellow;}",
                ".user.Q\\000026A a.childNode{color:purple;}"
            ));
        }

        [Fact]
        public void Comments()
        {
            stylis(@"
        // line comment
        // color: red;
        /**
         * removes block comments and line comments,
         * there's a fire in the house // there is
         */
        button /*
          // what's
          xxx
          */
        {color: blue;}
        // hello
        button /* 1 */
        {
          color: red; /* 2 */
        }
        /*! 1 */
        color: red;
        /*! 2 */
        h1 {
          /*! 1 */
          color: red;
          /*! 2 */
          color: red;
          /*! 3 */
        }").ShouldBe(string.Join("", 
                ".user{color:red;}", 
                ".user button{color:blue;}.user button{color:red;}", 
                ".user h1{color:red;color:red;}")
          );
        }

        [Fact]
        public void Ampersand()
        {
            stylis(@"
        & {
          color:blue;
        }
        &&& {
          color:red;
        }
        & + & {
          color:red;
        }
        .wrapper button& {
          color:red;
        }
        &:hover & {
          color: green;
        }
        div:hover & {
          color: green;
        }
        div:hover & {
          h1 & {
            color:red;
          }
        }").ShouldBe(string.Join("", 
                ".user{color:blue;}",
                ".user.user.user{color:red;}",
                ".user+.user{color:red;}",
                ".wrapper button.user{color:red;}",
                ".user:hover .user{color:green;}",
                "div:hover .user{color:green;}",
                "h1 div:hover .user{color:red;}"
                ));
        }

        [Fact]
        public void Ampersand_Before()
        {
            stylis(@"
        &:before{
          color:blue;
        }").ShouldBe(".user:before{color:blue;}");
        }

        [Fact]
        public void Ampersand_Hover()
        {
            stylis(@"
        & :hover{
          color:blue;
        }").ShouldBe(".user :hover{color:blue;}");
        }

        [Fact]
        public void Div_Hover()
        {
            stylis(@"
        div :hover {
          color:blue;
        }").ShouldBe(".user div :hover{color:blue;}");
        }

        [Fact]
        public void Import()
        {
            stylis(@"@import url('http://example.com');").ShouldBe("@import url('http://example.com');");
        }

        [Fact]
        public void Media()
        {
            stylis(@"
        @media (max-width:600px) {
          color:red;
          h1 {
            color:red;
            h2 {
              color:blue;
            }
          }
          display:none;
        }
        @media (min-width:576px) {
          &.card-deck {
            .card {
              &:not(:first-child) {
                margin-left:15px;
              }
              &:not(:last-child) {
                margin-right:15px;
              }
            }
          }
        }
        @supports (display:block) {
          @media (min-width:10px) {
            background-color:seagreen;
          }
        }
        @media (max-width:600px) {
          & { color:red }
        }
        &:hover {
          color:orange
        }").ShouldBe(string.Join("",
                "@media (max-width:600px){.user{color:red;display:none;}.user h1{color:red;}.user h1 h2{color:blue;}}",
                "@media (min-width:576px){.user.card-deck .card:not(:first-child){margin-left:15px;}.user.card-deck .card:not(:last-child){margin-right:15px;}}",
                "@supports (display:block){@media (min-width:10px){.user{background-color:seagreen;}}}",
                "@media (max-width:600px){.user{color:red;}}.user:hover{color:orange;}"
                ));
        }

        [Fact]
        public void Media_Specifity()
        {
            stylis(@"
        > #box-not-working {
          background:red;
          padding-left:8px;
          width:10px;
          @media only screen and (min-width:10px) {
            width: calc(10px + 90px * (100vw - 10px) / 90);
          }
          @media only screen and (min-width:90px) {
            width: 90px;
          }
          height: 10px;
          @media only screen and (min-width:10px) {
            height: calc(10px + 90px * (100vw - 10px) / 90);
          }
          @media only screen and (min-width:90px) {
            height: 90px;
          }
         }").ShouldBe(string.Join("", 
                ".user >#box-not-working{background:red;padding-left:8px;width:10px;height:10px;}",
                "@media only screen and (min-width:10px){.user >#box-not-working{width:calc(10px + 90px * (100vw - 10px) / 90);}}",
                "@media only screen and (min-width:90px){.user >#box-not-working{width:90px;}}",
                "@media only screen and (min-width:10px){.user >#box-not-working{height:calc(10px + 90px * (100vw - 10px) / 90);}}",
                "@media only screen and (min-width:90px){.user >#box-not-working{height:90px;}}"
                ));
        }

        [Fact]
        public void Font_Face()
        {
            stylis(@"
        @font-face {
          font-family:Pangolin;
          src:url('Pangolin-Regular.ttf') format('truetype');
        }").ShouldBe("@font-face{font-family:Pangolin;src:url('Pangolin-Regular.ttf') format('truetype');}");
        }

        [Fact]
        public void Multiple_Selectors()
        {
            stylis(@"
        span, h1 {
          color:red;
        }
        h1, &:after, &:before {
          color:red;
        }").ShouldBe(string.Join("", 
                ".user span,.user h1{color:red;}",
                ".user h1,.user:after,.user:before{color:red;}"
                ));
        }

        [Fact]
        public void Attribute_Selector_And_Match()
        {
            stylis(@"
        .test:matches(a,b,c), .test {
          color:blue;
        }
        .test[title="",""] {
          color:red;
        }
        [title=""a,b,c, something""], h1, [title=""a,b,c""] {
          color:red
        }
        [title=""a""],
        [title=""b""] {
          color:red;
        }").ShouldBe(string.Join("", 
                ".user .test:matches(a,b,c),.user .test{color:blue;}",
                ".user .test[title=\",\"]{color:red;}",
                ".user [title=\"a,b,c, something\"],.user h1,.user [title=\"a,b,c\"]{color:red;}",
                ".user [title=\"a\"],.user [title=\"b\"]{color:red;}"
            ));
        }

        [Fact]
        public void Quotes()
        {
            stylis(@"
        .foo:before {
          content:"".hello {world}"";
          content:"".hello {world} ' "";
          content:'.hello {world} "" ';
        }").ShouldBe(".user .foo:before{content:\".hello {world}\";content:\".hello {world} ' \";content:'.hello {world} \" ';}");
        }

        [Fact]
        public void Quotes_Escaping()
        {
            stylis(@"
        .foo:before {
          content:""\"""";
          content:""\\\"""";

          content:'\'';
          content:'\\\'';
        }
").ShouldBe(@".user .foo:before{content:""\"""";content:""\\\"""";content:'\'';content:'\\\'';}");
        }

        [Fact]
        public void Remove_Empty_Css()
        {
            stylis(@"& {   }").ShouldBe("");
        }

        [Fact]
        public void Remove_Empty_Declarations()
        {
            stylis("width:").ShouldBe("");
            stylis("height:;").ShouldBe("");
            stylis("max-width:     ").ShouldBe("");
            stylis("max-height:     ;").ShouldBe("");
        }

        [Fact]
        public void Urls()
        {
            stylis(@"
        background:url(http://url.com/});
        background:url(http://url.com//1234) '('; // sdsd
        background:url(""data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAEYAAAABCAIAAADsEU8HAAAACXBIW" + 
        @"XMAAAsTAAALEwEAmpwYAAAAIklEQVQI12P8//8/Aw4wbdq0rKysAZG1trbGJXv06FH8sgDIJBbBfp+hFAAAAABJRU5ErkJggg=="");"
                   ).ShouldBe(string.Join("", 
                ".user{background:url(http://url.com/});",
                "background:url(http://url.com//1234) '(';",
                "background:url(\"data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAEYAAAABCAIAAADsEU8HAAAACXBIW",
                "XMAAAsTAAALEwEAmpwYAAAAIklEQVQI12P8//8/Aw4wbdq0rKysAZG1trbGJXv06FH8sgDIJBbBfp+hFAAAAABJRU5ErkJggg==\");}"
            ));
        }

        [Fact]
        public void Last_Semicolon_Omission()
        {
            stylis(@"
        .content {
          color:red
        }
        .content {
          color:blue
        }").ShouldBe(string.Join("", 
                ".user .content{color:red;}",
                ".user .content{color:blue;}"
            ));
        }

        [Fact]
        public void Matches_Not()
        {
            stylis(@"
        h1:matches(.a,.b,:not(.c)) {
          display: none
        }").ShouldBe(".user h1:matches(.a,.b,:not(.c)){display:none;}");
        }

        [Fact]
        public void Pseudo_Selectors()
        {
            stylis(@"
        :not(&) {
          color: red;
        }
        :matches(&) {
          color: red;
        }
        :is(&) {
          color: red;
        }
        :any(&) {
          color: red;
        }
        :where(&) {
          color: red;
        }
        :has(&) {
          color: red;
        }").ShouldBe(string.Join("", 
                ":not(.user){color:red;}",
                ":matches(.user){color:red;}",
                ":is(.user){color:red;}",
                ":any(.user){color:red;}",
                ":where(.user){color:red;}",
                ":has(.user){color:red;}"
            ));
        }

        [Fact]
        public void Nested_Pseudo_Selectors()
        {
            stylis(@"
        :not(&) {
          :matches(&) {
            :is(&) {
              :any(&) {
                :where(&) {
                  :has(&) {
                    color: red;
                  }
                }
              }
            }
          }
        }").ShouldBe(":has(:where(:any(:is(:matches(:not(.user)))))){color:red;}");
        }

        [Fact]
        public void Pseudo_Selector_Inside_Pseudo_Selector()
        {
            stylis(@"
        h1:matches(.a,.b,:not(&)) {
          display: none
        }").ShouldBe("h1:matches(.a,.b,:not(.user)){display:none;}");
        }

        [Fact]
        public void Pseudo_Selector_With_Ampersand_In_A_String()
        {
            stylis(@"
        h1:matches(&,[href=""https://css-tricks.com?a=1&b=2""]) {
          display: none
        }").ShouldBe("h1:matches(.user,[href=\"https://css-tricks.com?a=1&b=2\"]){display:none;}");
        }

        [Fact]
        public void Keyframes()
        {
            stylis(@"
      @-webkit-keyframes slidein {
				to { transform:translate(20px); }
			}
      @keyframes slidein {
				to { transform:translate(20px); }
      }
      @keyframes hahaha {
			  0%,
			  1%{t:0}
      }
      @keyframes infinite-spinning {
        from {
          transform: rotate(0deg);
        }
        to {
          transform: rotate(360deg);
        }
      }").ShouldBe(string.Join("",
                "@-webkit-keyframes slidein{to{transform:translate(20px);}}",
                "@keyframes slidein{to{transform:translate(20px);}}",
                "@keyframes hahaha{0%,1%{t:0;}}",
                "@keyframes infinite-spinning{from{transform:rotate(0deg);}to{transform:rotate(360deg);}}"
            ));
        }

        [Fact]
        public void Edge_Case()
        {
            stylis(@"
        @media (min-width:537px) {
          border-bottom:4px solid red;
        }
        &::placeholder {
          color:pink;
        }
        .a {color:'red'}
        .b {color:""red""}
        .a {color:red;}[role=button]{color:red;}
        .b {padding:30 3}
        .c {v-text-anchor: middle;}").ShouldBe(string.Join("", 
                "@media (min-width:537px){.user{border-bottom:4px solid red;}}",
                ".user::placeholder{color:pink;}",
                ".user .a{color:'red';}",
                ".user .b{color:\"red\";}",
                ".user .a{color:red;}",
                ".user [role=button]{color:red;}",
                ".user .b{padding:30 3;}",
                ".user .c{v-text-anchor:middle;}"
                ));
        }

        [Fact]
        public void WhitEspace()
        {
            stylis(@"
        @import
        ""./a.css"";

        div {
          width:0;    
        }
        .foo {
          color   :   hotpink;
        }").ShouldBe(string.Join("", 
                "@import \"./a.css\";",
                ".user div{width:0;}",
                ".user .foo{color:hotpink;}"
                ));
        }

        [Fact]
        public void No_Trailing_Semi_Colons()
        {
            stylis(@"
      h2 {
        display:none
      }
      div:hover
        {
        color:red
      }").ShouldBe(string.Join("", 
                ".user h2{display:none;}", 
                ".user div:hover{color:red;}"));
        }

        [Fact]
        public void Multiline_Declaration()
        {
            stylis(@"
      html {
        background:
          linear-gradient(0deg, rgba(255, 255, 255, 0.8), rgba(255, 255, 255, 0.8)),
          url(/static/background.svg);
      }").ShouldBe(".user html{background:linear-gradient(0deg, rgba(255, 255, 255, 0.8), rgba(255, 255, 255, 0.8)),url(/static/background.svg);}");
        }

        [Fact]
        public void Nesting_Selector_Multiple_Levels()
        {
            stylis(@"
        a {
          a {
            a {
              a {
                a {
                  a {
                    a {
                      a {
                        a {
                          a {
                            a {
                              a {
                                color:red;
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }").ShouldBe(".user a a a a a a a a a a a a{color:red;}");
        }

        [Fact]
        public void Nesting_Container_Multiple_Levels()
        {
            stylis(@"
        div {
          @container {
            a {
              color:red;

        @container {
                h1 {
                  color:hotpink;
                }
              }
            }
          }
        }").ShouldBe(string.Join("", 
                "@container{.user div a{color:red;}", 
                "@container{.user div a h1{color:hotpink;}}}"));
        }

        [Fact]
        public void Nesting_Media_Multiple_Levels()
        {
            stylis(@"
        div {
          @media {
            a {
              color:red;

        @media {
                h1 {
                  color:hotpink;
                }
              }
            }
          }
        }").ShouldBe(string.Join("", 
                "@media{.user div a{color:red;}", 
                "@media{.user div a h1{color:hotpink;}}}"
            ));
        }

        [Fact]
        public void Noop_Tail()
        {
            stylis(@"color:red/**/").ShouldBe(".user{color:red;}");
            stylis(@"color:red//").ShouldBe(".user{color:red;}");
            stylis(@"color:red[]").ShouldBe(".user{color:red[];}");
            stylis(@"color:red()").ShouldBe(".user{color:red();}");
            stylis(@"color:red''").ShouldBe(".user{color:red'';}");
            stylis(@"color:red""""").ShouldBe(".user{color:red\"\";}");
            stylis(@"h1{color:red/**}").ShouldBe(".user h1{color:red;}");
        }

        [Fact]
        public void Context_Character()
        {
            stylis(".a{color:red;/* } */}").ShouldBe(".user .a{color:red;}");
            stylis(".a{color:red;/*}*/}").ShouldBe(".user .a{color:red;}");
            stylis(".a{color:red;/*{*/}").ShouldBe(".user .a{color:red;}");
            stylis(".a{/**/color:red}").ShouldBe(".user .a{color:red;}");
            stylis(".a{color:red;/*//color:blue;*/}").ShouldBe(".user .a{color:red;}");
            stylis("background: url(\"img}.png\");.a {background: url(\"img}.png\");}")
                .ShouldBe(string.Join("", 
                    ".user{background:url(\"img}.png\");}", 
                    ".user .a{background:url(\"img}.png\");}"));
            stylis("background: url(img}.png);.a {background: url(img}.png);}")
                .ShouldBe(string.Join("",
                    ".user{background:url(img}.png);}",
                    ".user .a{background:url(img}.png);}"));
            stylis("background: url[img}.png];.a {background: url[img}.png];}")
                .ShouldBe(string.Join("",
                    ".user{background:url[img}.png];}",
                    ".user .a{background:url[img}.png];}"));
        }

        [Fact]
        public void Dash_In_An_Identifier()
        {
            stylis(@"
        .block--modifier {
          color: hotpink;
        }
        .card {
          color: black;
        }").ShouldBe(string.Join("", 
                ".user .block--modifier{color:hotpink;}", 
                ".user .card{color:black;}"));
        }

        [Fact]
        public void Comments_In_Rules_Not_Increasing_Depth_Of_Consecutive_Rules()
        {
            stylis(@"
        font-size:2rem;
        .one{color:black;/* foo */}
        .two{color:black;/* bar */}
        .three{color:black;/* baz */}").ShouldBe(string.Join("",
                ".user{font-size:2rem;}",
                ".user .one{color:black;}",
                ".user .two{color:black;}",
                ".user .three{color:black;}"));
        }

        [Fact]
        public void Comment_In_A_Group_Of_Selectors_Inside_A_Media_Query()
        {
            stylis(@"
        @media (min-width: 400px) {
          div /* comment */ {
            border-left:1px solid hotpink;
          }
          span {
            border-top:none;
          }
        }").ShouldBe("@media (min-width: 400px){.user div{border-left:1px solid hotpink;}.user span{border-top:none;}}");
        }

        [Fact]
        public void Comment_In_A_Group_Of_Selectors_Inside_A_Container_Query()
        {
            stylis(@"
        @container (min-width: 400px) {
          div /* comment */ {
            border-left:1px solid hotpink;
          }
          span {
            border-top:none;
          }
        }").ShouldBe("@container (min-width: 400px){.user div{border-left:1px solid hotpink;}.user span{border-top:none;}}");
        }

        [Fact]
        public void Comment_Bang_At_The_Start()
        {
            Serialize(Compile("/*! test */body{color:red;}"), Stringify).ShouldBe("body{color:red;}");
        }

        [Fact]
        public void Parenthesis_In_String_Literal()
        {
            stylis(@"
      @media only screen and (max-width: 320px){
        background: url(""image_(1).jpg"");
      }

      @media only screen and (min-width:321px) {
        background: url(""image_(1).jpg"");
      }").ShouldBe(string.Join("",
                "@media only screen and (max-width: 320px){.user{background:url(\"image_(1).jpg\");}}",
                "@media only screen and (min-width:321px){.user{background:url(\"image_(1).jpg\");}}"));

            stylis(@"
        .a {
          background: url(""image_(1).jpg)"");
        }

        .b {
          background: url(""abc"");
        }").ShouldBe(string.Join("", 
                ".user .a{background:url(\"image_(1).jpg)\");}",
                ".user .b{background:url(\"abc\");}"));

            stylis(@"
        .icon {
          background:url(""data:image/svg+xml;charset=utf-8,%3Csvg width='12' height='12' viewBox='0 0 16 16' xmlns='http://www.w3.org/2000/svg'%3E%3Cpath d='M14.117.323L8.044 6.398 2.595.323a1.105 1.105 0 0 0-1.562 1.562L6.482 7.96.323 14.119a1.105 1.105 0 0 0 1.562 1.562L7.96 9.608l5.449 6.073a1.103 1.103 0 1 0 1.56-1.562L9.517 8.046l6.159-6.161a1.103 1.103 0 1 0-1.56-1.562z' fill='rgba(85, 85, 85, 0.5)'/%3E%3C/svg%3E"");
        }

        div {
          background: cyan;
      }").ShouldBe(string.Join("",
                ".user .icon{background:url(\"data:image/svg+xml;charset=utf-8,%3Csvg width='12' height='12' viewBox='0 0 16 16' xmlns='http://www.w3.org/2000/svg'%3E%3Cpath d='M14.117.323L8.044 6.398 2.595.323a1.105 1.105 0 0 0-1.562 1.562L6.482 7.96.323 14.119a1.105 1.105 0 0 0 1.562 1.562L7.96 9.608l5.449 6.073a1.103 1.103 0 1 0 1.56-1.562L9.517 8.046l6.159-6.161a1.103 1.103 0 1 0-1.56-1.562z' fill='rgba(85, 85, 85, 0.5)'/%3E%3C/svg%3E\");}",
                ".user div{background:cyan;}"));

            stylis(@"
        .a .b .c {
          width: calc(100% / ""func()"");
        }

        .d {
          background: yellow;
      }").ShouldBe(string.Join("", 
                ".user .a .b .c{width:calc(100% / \"func()\");}", 
                ".user .d{background:yellow;}"));
        }

        [Fact]
        public void Nested_Parenthesis()
        {
            stylis("width: calc(calc(1) + 10);").ShouldBe(".user{width:calc(calc(1) + 10);}");
        }

        [Fact]
        public void Css_Variables_Edge_Cases()
        {
            stylis(@"
        --braces: { };
        --at-keyword-unknown-block: @foobar {};
        --at-keyword-known-block: @media {};
        --cdo-at-top-level: <!--;
        --cdc-at-top-level: -->;
        --semicolon-not-top-level: (;);
        --cdo-not-top-level: (<!--);
        --cdc-not-top-level: (-->);
        --ampersand-preserved: foo & bar;").ShouldBe(".user{" + string.Join("",
                "--braces:{};",
                "--at-keyword-unknown-block:@foobar{};",
                "--at-keyword-known-block:@media{};",
                "--cdo-at-top-level:<!--;",
                "--cdc-at-top-level:-->;",
                "--semicolon-not-top-level:(;);",
                "--cdo-not-top-level:(<!--);",
                "--cdc-not-top-level:(-->);",
                "--ampersand-preserved:foo & bar;") + "}");

            Serialize(Compile(".foo { --bar: var(--baz) } .bar{--foo: {} } .foo {--min-height: 66px }"), Stringify)
                .ShouldBe(string.Join("", 
                    ".foo{--bar:var(--baz);}", 
                    ".bar{--foo:{};}",
                    ".foo{--min-height:66px;}"));
        }

        [Fact]
        public void Does_Not_Hang_On_Unterminated_Block_Comment()
        {
            stylis("/*").ShouldBe("");
        }

        [Fact]
        public void Handles_Single_Slash_In_A_Value()
        {
            stylis("font: 12px/14px serif;").ShouldBe(".user{font:12px/14px serif;}");
        }

        [Fact]
        public void Nested()
        {
            stylis(@"
      div {
        h2 {
          color:red;
          h3 {
            color:blue;
          }
        }
      }

      .foo & {
          width:1px;
          &:hover {
            color:black;
          }
          li {
            color:white;
          }
      }

      h1, div {
        color:red;
        h2,
        &:before {
          color:red;
        }
        color:blue;
        header {
          font-size:12px;
        }
        @media {
          color:red;
        }
        @media {
          color:blue;
        }
        @container (min-width: 250px) {
          color:green;
        }
      }

      &.foo {
        &.bar {
          color:orange
        }
      }

      &.foo {
        &.bar {
          &.barbar {
            color:orange
          }
        }
      }").ShouldBe(string.Join("",
                ".user div h2{color:red;}",
                ".user div h2 h3{color:blue;}",
                ".foo .user{width:1px;}",
                ".foo .user:hover{color:black;}",
                ".foo .user li{color:white;}",
                ".user h1,.user div{color:red;color:blue;}",
                ".user h1 h2,.user div h2,.user h1:before,.user div:before{color:red;}",
                ".user h1 header,.user div header{font-size:12px;}",
                "@media{.user h1,.user div{color:red;}}",
                "@media{.user h1,.user div{color:blue;}}",
                "@container (min-width: 250px){.user h1,.user div{color:green;}}",
                ".user.foo.bar{color:orange;}",
                ".user.foo.bar.barbar{color:orange;}"));
        }
    }
}