namespace CssInCSharp.Utils
{
    public static class Util
    {
        public static string Unit(Property<PropertySkip, string, double> num)
        {
            return num.GetValue().ToString();
        }
    }
}
