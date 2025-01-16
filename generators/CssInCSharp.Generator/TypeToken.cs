namespace CssInCSharp.Generator
{
    public class ObjectType
    {
        public string Kind { get; set; } = nameof(ObjectType);
        public CSharpOptions CsOptions { get; set; }
        public string[]? Properties { get; set; }
        public bool HasIndexer { get; set; }
        public ObjectType(CSharpOptions options)
        {
            CsOptions = options;
        }

        public bool HasKey(string key)
        {
            return Properties != null && Properties.Contains(key);
        }

        public bool HasAny(params string[] keys)
        {
            return Properties != null && Properties.Any(keys.Contains);
        }

        public bool HasAll(params string[] keys)
        {
            return Properties != null && keys.All(Properties.Contains);
        }
    }

    public class ReturnType
    {
        public string Kind { get; set; } = nameof(ReturnType);
        public CSharpOptions CsOptions { get; set; }
        public string FunctionName { get; set; }
        public string? ValueType { get; set; }

        public ReturnType(CSharpOptions options, string funcName, string? valueType = null)
        {
            FunctionName = funcName;
            CsOptions = options;
            ValueType = valueType;
        }
    }

    public class ParameterType
    {
        public string Kind { get; set; } = nameof(ParameterType);
        public CSharpOptions CsOptions { get; set; }
        public string Name { get; set; }
        public string FunctionName { get; set; }
        public string? DefaultValue { get; set; }
        public ParameterType(CSharpOptions options, string name, string functionName, string? defaultValue)
        {
            CsOptions = options;
            Name = name;
            FunctionName = functionName;
            DefaultValue = defaultValue;
        }
    }
}
