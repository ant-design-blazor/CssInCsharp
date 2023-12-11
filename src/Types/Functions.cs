namespace CssInCSharp;

internal static class Functions
{
    internal static string FormatValue<T>(string key, T value)
    {
        return value switch
        {
            string v => v,
            int v => Wrap(key, v),
            float v => Wrap(key, v),
            double v => Wrap(key, v),
            Keyframe v => v.ToString(),
            _ => value?.ToString()
        };
    }

    internal static string Wrap<T>(string key, T value)
    {
        // All number types need to be px-wrapped and unwanted parts of Unitless should be ignored.
        if (!string.IsNullOrEmpty(key) && !Unitless.Keys.ContainsKey(key))
        {
            return $"{value}px";
        }
        return value.ToString();
    }
}