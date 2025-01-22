namespace CssInCSharp.Generator
{
    internal class TypeInferenceException : Exception
    {
        public string RuleName { get; set; }

        public TypeInferenceException(string ruleName, string message): base($"RuleName {ruleName}, {message}")
        {
            RuleName = ruleName;
        }
    }
}
