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

    public class PropertyType
    {
        public string Kind { get; set; } = nameof(PropertyType);

        public CSharpOptions CsOptions { get; set; }

        public string Name { get; set; }

        public IndexedAccessType? IndexedAccessType { get; set; }

        public UnionType? UnionType { get; set; }

        public PropertyType(CSharpOptions options, string name, IndexedAccessType? indexedAccessType = null, UnionType? unionType = null)
        {
            CsOptions = options;
            Name = name;
            IndexedAccessType = indexedAccessType;
            UnionType = unionType;
        }

        public bool ContainsAny(params string[] keys)
        {
            foreach (var key in keys)
            {
                if (Name.Contains(key))
                {
                    return true;
                }
            }

            return false;
        }
    }

    public class IndexedAccessType
    {
        public string Kind { get; set; } = nameof(IndexedAccessType);

        public CSharpOptions CsOptions { get; set; }

        public string ObjectType { get; set; }

        public string IndexType { get; set; }

        public IndexedAccessType(CSharpOptions options, string objectType, string indexType)
        {
            CsOptions = options;
            ObjectType = objectType;
            IndexType = indexType;
        }
    }

    public class UnionType
    {
        public string Kind { get; set; } = nameof(UnionType);

        public CSharpOptions CsOptions { get; set; }

        public string[] Types { get; set; }

        public UnionType(CSharpOptions options, string[] types)
        {
            CsOptions = options;
            Types = types;
        }

        public bool HasAny(params string[] keys)
        {
            return Types.Any(keys.Contains);
        }

        public bool HasAll(params string[] keys)
        {
            return keys.All(Types.Contains);
        }
    }
}
