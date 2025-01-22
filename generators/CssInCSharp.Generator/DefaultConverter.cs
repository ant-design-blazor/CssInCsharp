namespace CssInCSharp.Generator
{
    public enum ConverterType
    {
        Ts,
        Sass,
        Less,
        Css
    }

    public interface IConverter
    {
        string Convert(string content, string fileName);
    }

    public class DefaultConverter : IConverter
    {
        public string Convert(string content, string fileName)
        {
            return string.Empty;
        }
    }

    public class ConverterFactory
    {
        public static IConverter Create(ConverterType type , CSharpOptions? option)
        {
            return type switch
            {
                ConverterType.Ts => new TypeScriptConverter(option),
                _ => new DefaultConverter(),
            };
        }
    }
}
