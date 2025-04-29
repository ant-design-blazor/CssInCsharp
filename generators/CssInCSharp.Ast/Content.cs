namespace CssInCSharp.Ast;

public class Content
{
    private readonly int _index;
    private readonly string _value0;
    private readonly List<Node> _value1;
    private Content(
        int index,
        string value0 = default,
        List<Node> value1 = default)
    {
        _index = index;
        _value0 = value0;
        _value1 = value1;
    }

    public static implicit operator Content(string t) => new(0, value0: t);
    public static implicit operator Content(List<Node> t) => new(1, value1: t);

    public bool IsString => _index == 0;
    public bool IsArray => _index == 1;
    public string AsString => _value0;
    public List<Node> AsArray => _value1;

    public override string ToString()
    {
        if (_index == 0) return _value0;
        return $"Array({_value1.Count})";
    }

    public Node? GetNode(params string[] types)
    {
        if (_index != 1) return null;
        return _value1.FirstOrDefault(x => types.Contains(x.type));
    }
}
