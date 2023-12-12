using System;

namespace CssInCSharp
{
    public struct CSSInterpolation
    {
        private readonly int _index;
        private readonly CSSObject _value0;
        private readonly CSSInterpolation[] _value1;
        private readonly string _value2;

        public CSSObject this[string key] => _value0;

        private CSSInterpolation(int index, CSSObject value0 = default, CSSInterpolation[] value1 = default, string value2 = default)
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
        }

        public static implicit operator CSSInterpolation(CSSObject t) => new(0, value0: t);
        public static implicit operator CSSInterpolation(CSSInterpolation[] t) => new(1, value1: t);
        public static implicit operator CSSInterpolation(string t) => new(2, value2: t);

        public bool IsT0 => _index == 0;
        public bool IsT1 => _index == 1;
        public bool IsT2 => _index == 2;

        public CSSObject AsT0 =>
            _index == 0 ?
                _value0 :
                throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
        public CSSInterpolation[] AsT1 =>
            _index == 1 ?
                _value1 :
                throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");

        public string AsT2 =>
            _index == 2 ?
                _value2 :
                throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
    }
}
