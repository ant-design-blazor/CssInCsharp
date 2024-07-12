using System;
using static CssInCSharp.Functions;

namespace CssInCSharp
{
    public struct CSSProperties : IProperty
    {
        private readonly int _index;
        private readonly PropertySkip _value0;
        private readonly string _value1;
        private readonly double _value2;
        private readonly Keyframe _value3;

        private CSSProperties(
            int index,
            PropertySkip value0 = default,
            string value1 = default,
            double value2 = default,
            Keyframe value3 = default)
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
        }

        public static implicit operator CSSProperties(PropertySkip t) => new(0, value0: t);
        public static implicit operator CSSProperties(string t) => new(1, value1: t);
        public static implicit operator CSSProperties(double t) => new(2, value2: t);
        public static implicit operator CSSProperties(Keyframe t) => new(3, value3: t);

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is CSSProperties o && Equals(o);
        }

        public override string ToString() => GetValue(null);

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = _index switch
                {
                    0 => _value0.GetHashCode(),
                    1 => _value1.GetHashCode(),
                    2 => _value2.GetHashCode(),
                    3 => _value3?.GetHashCode(),
                    _ => 0
                } ?? 0;
                return (hashCode * 397) ^ _index;
            }
        }

        public string GetValue(string key)
        {
            return _index switch
            {
                0 => FormatValue(key, _value0),
                1 => FormatValue(key, _value1),
                2 => FormatValue(key, _value2),
                3 => FormatValue(key, _value3),
                _ => throw new InvalidOperationException("Unexpected index.")
            };
        }

        public object GetValue()
        {
            return _index switch
            {
                0 => _value0,
                1 => _value1,
                2 => _value2,
                3 => _value3,
                _ => throw new InvalidOperationException("Unexpected index.")
            };
        }
    }
}
