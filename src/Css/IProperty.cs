namespace CssInCSharp
{
    public interface IProperty
    {
        string GetValue(string key);
        object GetValue();
    }

    public struct PropertySkip
    {
        public bool SkipCheck { get; set; }

        public Property<string, double> Value { get; set; }

        public string GetValue(string key)
        {
	        return Value.GetValue(key);
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
