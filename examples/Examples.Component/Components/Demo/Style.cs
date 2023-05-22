using CssInCs;

namespace Examples.Component
{
    public partial class Demo
    {
        // or component id,name etc.
        private const string Name = "demo";
        private const string ClassName = $".{Name}";

        private CSSObject GenStyle(CssToken token)
        {
            return new CSSObject
            {
                [ClassName] = new ()
                {
                    Width = $"{Width}px",
                    MinHeight = "300px",
                    Display = "flex",
                    FlexDirection = "row",
                    FlexWrap = "wrap",
                    JustifyContent = "space-between",
                    ["& .item"] = new ()
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

        protected override CSSObject[] UseStyle(CssToken token) => new []
        {
            GenStyle(token)
        };
    }
}
