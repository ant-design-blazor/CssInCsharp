using CssInCSharp;

namespace Examples.Component
{
    public partial class Demo
    {
        // or component id,name etc.
        private const string Name = "demo";
        private const string ClassName = $".{Name}";
        private CssToken _token = new CssToken();

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

        protected override CSSInterpolation UseStyle() => new CSSInterpolation[]
        {
            GenStyle(_token)
        };
    }
}
