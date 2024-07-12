using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace CssInCSharp
{
    internal class StyleCache
    {
        internal class Item
        {
            public string StyleStr { get; set; }
            public string TokenKey { get; set; }
            public string StyleId { get; set; }
            public Dictionary<string, string> Effects { get; set; }
        }

        private readonly ConcurrentDictionary<string, Item> _cache = new();

        private static StyleCache _instance;
        public static StyleCache Instance => _instance ??= new StyleCache();

        public Item GetOrAdd(string key, Func<string, Item> func)
        {
            return _cache.GetOrAdd(key, func);
        }

        public bool HasEffect(string effectKey)
        {
            return _cache
                .Values
                .SelectMany(x => x.Effects.Keys)
                .Contains(effectKey);
        }
    }
}
