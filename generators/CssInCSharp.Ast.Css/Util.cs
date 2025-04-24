namespace CssInCSharp.Ast.Css;

public static class Util
{
    public static int Of(params int[] values)
    {
        foreach (var val in values)
        {
            if (val != 0) return val;
        }

        return 0;
    }
}
