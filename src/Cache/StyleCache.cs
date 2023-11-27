using System;
using System.Collections.Concurrent;

namespace CssInCs
{
    internal class StyleCache
    {
        internal class Item
        {
            public string StyleStr { get; set; }
            public string TokenKey { get; set; }
            public string StyleId { get; set; }
        }

        private readonly ConcurrentDictionary<string, Item> _cache = new();

        private static StyleCache _instance;
        public static StyleCache Instance => _instance ??= new StyleCache();

        public Item GetOrAdd(string key, Func<string, Item> func)
        {
            return _cache.GetOrAdd(key, func);
        }
    }
}
