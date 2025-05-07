namespace CssInCSharp
{
    public class StyleService
    {
        public void Register(StyleInfo style)
        {
            StyleHelper.Register(style);
        }

        public string Register(CSSObject style)
        {
            return StyleHelper.Register(style);
        }

        public string Register(string className, CSSObject style)
        {
            return StyleHelper.Register(className, style);
        }

        public string Register(string style)
        {
            return StyleHelper.Register(style);
        }
    }
}
