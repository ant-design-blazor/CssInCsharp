using System;
using static CssInCs.Functions;

namespace CssInCs
{
    public readonly struct Property<T0> : IProperty
    {
        private readonly int _index;
        private readonly T0 _value0;

        private Property(int index, T0 value0 = default)
        {
            _index = index;
            _value0 = value0;
        }

        public static implicit operator Property<T0>(T0 t) => new(0, value0: t);

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is Property<T0> o && Equals(o);
        }

        public override string ToString() => GetValue(null);

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = _index switch
                {
                    0 => _value0?.GetHashCode(),
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
                _ => throw new InvalidOperationException("Unexpected index.")
            };
        }
    }

    public readonly struct Property<T0, T1> : IProperty
    {
        private readonly int _index;
        private readonly T0 _value0;
        private readonly T1 _value1;

        private Property(int index, T0 value0 = default, T1 value1 = default)
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
        }

        public static implicit operator Property<T0, T1>(T0 t) => new(0, value0: t);
        public static implicit operator Property<T0, T1>(T1 t) => new(1, value1: t);

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is Property<T0, T1> o && Equals(o);
        }

        public override string ToString() => GetValue(null);

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = _index switch
                {
                    0 => _value0?.GetHashCode(),
                    1 => _value1?.GetHashCode(),
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
                _ => throw new InvalidOperationException("Unexpected index.")
            };
        }
    }

    public readonly struct Property<T0, T1, T2> : IProperty
    {
        private readonly int _index;
        private readonly T0 _value0;
        private readonly T1 _value1;
        private readonly T2 _value2;

        private Property(int index, T0 value0 = default, T1 value1 = default, T2 value2 = default)
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
        }

        public static implicit operator Property<T0, T1, T2>(T0 t) => new(0, value0: t);
        public static implicit operator Property<T0, T1, T2>(T1 t) => new(1, value1: t);
        public static implicit operator Property<T0, T1, T2>(T2 t) => new(2, value2: t);

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is Property<T0, T1, T2> o && Equals(o);
        }

        public override string ToString() => GetValue(null);

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = _index switch
                {
                    0 => _value0?.GetHashCode(),
                    1 => _value1?.GetHashCode(),
                    2 => _value2?.GetHashCode(),
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
                _ => throw new InvalidOperationException("Unexpected index.")
            };
        }
    }

    public readonly struct Property<T0, T1, T2, T3> : IProperty
    {
        private readonly int _index;
        private readonly T0 _value0;
        private readonly T1 _value1;
        private readonly T2 _value2;
        private readonly T3 _value3;

        private Property(int index, T0 value0 = default, T1 value1 = default, T2 value2 = default, T3 value3 = default)
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
        }

        public static implicit operator Property<T0, T1, T2, T3>(T0 t) => new(0, value0: t);
        public static implicit operator Property<T0, T1, T2, T3>(T1 t) => new(1, value1: t);
        public static implicit operator Property<T0, T1, T2, T3>(T2 t) => new(2, value2: t);
        public static implicit operator Property<T0, T1, T2, T3>(T3 t) => new(3, value3: t);

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is Property<T0, T1, T2, T3> o && Equals(o);
        }

        public override string ToString() => GetValue(null);

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = _index switch
                {
                    0 => _value0?.GetHashCode(),
                    1 => _value1?.GetHashCode(),
                    2 => _value2?.GetHashCode(),
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
    }
}
