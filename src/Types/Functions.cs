namespace CssInCs;

internal static class Functions
{
    internal static string FormatValue<T>(T value)
    {
        return value switch
        {
            string v => v,
            int v => v != 0 ? $"{v}px" : v.ToString(),
            float v => v.ToString(),
            Keyframe v => v.ToString(),
            _ => value?.ToString()
        };
    }
}