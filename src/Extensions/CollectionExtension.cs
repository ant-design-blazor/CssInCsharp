using System.Collections.Generic;

namespace CssInCs.Extensions
{
    public static class CollectionExtension
    {
        public static void SetValue<T>(this List<T> list, int index, T value)
        {
            if (index + 1 > list.Count)
            {
                var diff = index + 1 - list.Count;
                list.AddRange(new T[diff]);
            }
            list[index] = value;
        }
    }
}
