namespace CssInCSharp.Generator;

public class AstGenerateException: Exception
{
    public int StartLine { get; }
    public int EndLine { get; }
    public string SourceCode { get; }

    public AstGenerateException(int start, int end, string sourceCode) : base(@$"Generate ast failed, source file line: {start} {end}, source code:\n
========================================
{sourceCode}
========================================")
    {
        StartLine = start;
        EndLine = end;
        SourceCode = sourceCode;
    }
}
