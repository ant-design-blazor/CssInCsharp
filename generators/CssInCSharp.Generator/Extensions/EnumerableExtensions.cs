namespace CssInCSharp.Generator.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Separate<T>(this IEnumerable<T> source, T separator, bool separateEnd = false)
        {
            using var enumerator = source.GetEnumerator();
            var hasNext = enumerator.MoveNext();
            while (hasNext)
            {
                var current = enumerator.Current;
                hasNext = enumerator.MoveNext();
                yield return current;
                if (separateEnd)
                {
                    yield return separator;
                }
                else if (hasNext)
                {
                    yield return separator;
                }
            }
        }
    }
}
