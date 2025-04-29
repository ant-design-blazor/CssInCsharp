namespace CssInCSharp.Ast;

public static class Extensions
{
    public static void push<TSource>(this List<TSource> source, UnionList<TSource> item)
    {
        if (item.IsElement)
        {
            source.Add(item.AsT0);
        }
        else
        {
            source.AddRange(item.AsT1);
        }
    }

    public static TSource pop<TSource>(this List<TSource> source)
    {
        if (source.Count == 0)
            throw new InvalidOperationException("List is empty.");

        TSource last = source[^1];
        source.RemoveAt(source.Count - 1);
        return last;
    }

    public static bool Has<TSource>(this TSource[] source, int index)
    {
        return index < source.Length;
    }

    public static bool Has<TSource>(this List<TSource> source, int index)
    {
        return index < source.Count;
    }

    public static List<TSource> concat<TSource>(this List<TSource> source, params UnionList<TSource>[] second)
    {
        var result = new List<TSource>(source);
        foreach (var item in second)
        {
            if (item.IsElement)
            {
                result.Add(item.AsT0);
            }
            else
            {
                result.AddRange(item.AsT1);
            }
        }

        return result;
    }

    public static char charAt(this string str, int index)
    {
        if (string.IsNullOrEmpty(str) || index < 0 || index >= str.Length)
            return default;
        return str[index];
    }

    public static bool AsBool(this int value)
    {
        return value != 0;
    }

    public static string substring(this string str, int start, int? end = null)
    {
        if (string.IsNullOrEmpty(str))
            return string.Empty;

        int len = str.Length;

        // 将负数参数视为0
        int from = Math.Max(0, start);
        int to = end.HasValue ? Math.Max(0, end.Value) : len;

        // 交换顺序
        if (from > to)
        {
            (from, to) = (to, from);
        }

        // 限制范围在 [0, len]
        from = Math.Min(from, len);
        to = Math.Min(to, len);

        return str.Substring(from, to - from);
    }

    public static bool ContainsKey(this Dictionary<string, string> dic, char key)
    {
        return dic.ContainsKey(key.ToString());
    }
}
