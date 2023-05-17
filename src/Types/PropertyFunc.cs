using System;

namespace CssInCs
{
    public static class PropertyFunc
    {
        public static Property<T> Fn<T>(Func<T> func) => func;
    }
}
