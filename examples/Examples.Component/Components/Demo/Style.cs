using CssInCSharp;

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

    public partial class Demo
    {
        // or component id,name etc.
        private const string Name = "demo";
        private const string ClassName = $".{Name}";

        private CssToken _token = new CssToken()
        {
            HashId = "qsdfq",
        };

        private CSSObject GenStyle(CssToken token)
        {
            return new CSSObject
            {
                [ClassName] = new CSSObject
                {
                    Width = $"{Width}px",
                    MinHeight = "300px",
                    Display = "flex",
                    FlexDirection = "row",
                    FlexWrap = "wrap",
                    JustifyContent = "space-between",
                    ["& .item"] = new CSSObject
                    {
                        Width = "80px",
                        Height = "100px",
                        Border = "1px solid #DDD",
                        TextAlign = "center",
                        Display = "flex",
                        AlignItems = "center",
                        JustifyContent = "center"
                    }
                }
            };
        }

        public CSSInterpolation UseStyle() => GenStyle(_token);
    }
}
