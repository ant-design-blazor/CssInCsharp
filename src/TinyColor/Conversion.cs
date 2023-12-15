namespace CssInCSharp
{
    internal static class Conversion
    {
        public static RGB NumberInputToObject(int color)
        {
            return new RGB(color >> 16, (color & 0xFF00) >> 8, color & 0xFF);
        }
    }
}
