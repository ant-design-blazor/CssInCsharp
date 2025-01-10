using CssInCSharp.Colors;

namespace CssInCSharp.Css
{
    public static class CSSUtil
    {
        public static string Unit(StringNumber num)
        {
            return "";
        }

        public static CSSCalculator GenCalc()
        {
            return new CSSCalculator();
        }
    }

    public class CSSCalculator
    {
        public CSSCalculator Add(StringNumber num)
        {
            return this;
        }

        public CSSCalculator Sub(StringNumber num)
        {
            return this;
        }

        public CSSCalculator Mul(StringNumber num)
        {
            return this;
        }

        public CSSCalculator Div(StringNumber num)
        {
            return this;
        }

        public string GetResult(bool force)
        {
            return "";
        }

        public string Equal()
        {
            return "";
        }
    }
}
