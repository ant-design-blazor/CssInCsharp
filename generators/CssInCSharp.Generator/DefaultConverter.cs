namespace CssInCSharp.Generator
{
    public enum ConverterType
    {
        Ts,
        Css,
        Less,
        Sass,
        Scss
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
                ConverterType.Css => new CssConverter(option),
                ConverterType.Less => new LessConverter(option),
                ConverterType.Sass => new SassConverter(option),
                ConverterType.Scss => new ScssConverter(option),
                _ => new DefaultConverter(),
            };
        }
    }
}
