using System;

namespace CssInCs;

public class PropertyRef<T0>
{
    private T0 _value0;
    private readonly int _index;

    private PropertyRef(int index, T0 value0 = default)
    {
        _index = index;
        _value0 = value0;
    }

    public static implicit operator PropertyRef<T0>(T0 t) => new(0, value0: t);

    private bool Equals(PropertyRef<T0> other) =>
        _index == other._index &&
        _index switch
        {
            0 => Equals(_value0, other._value0),
            _ => false
        };

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }

        return obj is PropertyRef<T0> o && Equals(o);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hashCode = _index switch
            {
                0 => _value0?.GetHashCode(),
                _ => 0
            } ?? 0;
            return (hashCode * 397) ^ _index;
        }
    }

    public override string ToString() =>
        _index switch
        {
            0 => _value0.ToString(),
            _ => throw new InvalidOperationException("Unexpected index.")
        };

    public void SetValue(T0 value)
    {
        _value0 = value;
    }
}