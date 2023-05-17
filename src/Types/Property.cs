using System;

namespace CssInCs
{
    public readonly struct Property<T0> : IProperty
    {
        private readonly int _index;
        private readonly PropertyRef<T0> _propRef;
        private readonly Func<T0> _func;
        private readonly T0 _value0;
        
        private Property(
            int index, 
            PropertyRef<T0> propRef = default,
            Func<T0> func = default,
            T0 value0 = default)
        {
            _index = index;
            _propRef = propRef;
            _func = func;
            _value0 = value0;
        }

        public static implicit operator Property<T0>(PropertyRef<T0> t) => new(0, propRef: t);
        public static implicit operator Property<T0>(Func<T0> t) => new(1, func: t);
        public static implicit operator Property<T0>(T0 t) => new(2, value0: t);

        private bool Equals(Property<T0> other) =>
            _index == other._index &&
            _index switch
            {
                0 => Equals(_propRef, other._propRef),
                1 => Equals(_func, other._func),
                2 => Equals(_value0, other._value0),
                _ => false
            };

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is Property<T0> o && Equals(o);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = _index switch
                {
                    0 => _propRef?.GetHashCode(),
                    1 => _func?.GetHashCode(),
                    2 => _value0?.GetHashCode(),
                    _ => 0
                } ?? 0;
                return (hashCode * 397) ^ _index;
            }
        }

        public override string ToString()
        {
            return GetValue();
        }

        public string GetValue() =>
            _index switch
            {
                0 => _propRef.ToString(),
                1 => _func().ToString(),
                2 => _value0.ToString(),
                _ => throw new InvalidOperationException("Unexpected index.")
            };
    }

}
