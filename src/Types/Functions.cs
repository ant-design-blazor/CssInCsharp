namespace CssInCSharp;

internal static class Functions
{
    internal static string FormatValue<T>(string key, T value)
    {
        return value switch
        {
            string v => v,
            int v => FixValue(key, value),
            float v => FixValue(key, value),
            double v => FixValue(key, value),
            Keyframe v => v.ToString(),
            _ => value?.ToString()
        };
    }

    internal static string FixValue<T>(string key, T value)
    {
        if(!string.IsNullOrEmpty(key) && !Unitless.Keys.ContainsKey(key))
        {
            return $"{value}px";
        }
        return value.ToString();
    }
}