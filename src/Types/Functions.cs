namespace CssInCSharp;

internal static class Functions
{
    internal static string FormatValue<T>(string key, T value)
    {
        return value switch
        {
            string v => v,
            int v => IsPx(key) ? $"{v}px" : v.ToString(),
            float v => v.ToString(),
            Keyframe v => v.ToString(),
            _ => value?.ToString()
        };
    }

    internal static bool IsPx(string key)
    {
        if (string.IsNullOrEmpty(key)) return false;
        return Unitless.Keys.ContainsKey(key);
    }
}