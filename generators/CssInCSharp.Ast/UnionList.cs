namespace CssInCSharp.Ast;

public struct UnionList<T0>
{
    private readonly int _index;
    private readonly T0 _value0;
    private readonly List<T0> _value1;

    private UnionList(
        int index,
        T0 value0 = default,
        List<T0> value1 = default)
    {
        _index = index;
        _value0 = value0;
        _value1 = value1;
    }

    public static implicit operator UnionList<T0>(T0 t) => new(0, value0: t);
    public static implicit operator UnionList<T0>(List<T0> t) => new(1, value1: t);

    public bool IsElement => _index == 0;
    public bool IsArray => _index == 1;
    public bool IsList => _index == 1;

    public T0 AsT0 => _value0;
    public List<T0> AsT1 => _value1;
}
