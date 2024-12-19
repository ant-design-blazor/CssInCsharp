namespace CssInCSharp.Generator
{
    public enum ConvertType
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
}
