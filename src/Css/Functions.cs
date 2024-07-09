namespace CssInCSharp;

internal static class Functions
{
    internal static string FormatValue<T>(string key, T value)
    {
        return value switch
        {
            string v => v,
            int v => Wrap(key, v, v != 0),
            float v => Wrap(key, v, v != 0),
            double v => Wrap(key, v, v != 0),
            Keyframe v => v.ToString(),
            PropertySkip v => v.GetValue(key),
            _ => value?.ToString()
        };
    }

    internal static string Wrap<T>(string key, T value, bool hasValue)
    {
        // All number types need to be px-wrapped and unwanted parts of Unitless should be ignored.
        if (!string.IsNullOrEmpty(key) && !Unitless.Keys.ContainsKey(key) && hasValue)
        {
            return $"{value}px";
        }
        return value.ToString();
    }
}