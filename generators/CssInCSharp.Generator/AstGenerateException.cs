namespace CssInCSharp.Generator;

public class AstGenerateException: Exception
{
    public int StartLine { get; }
    public int EndLine { get; }

    public AstGenerateException(int start, int end) : base($"Generate ast failed, source file line: {start} {end}")
    {
        StartLine = start;
        EndLine = end;
    }
}
