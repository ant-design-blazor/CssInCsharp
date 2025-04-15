using System.Text.RegularExpressions;

namespace CssInCSharp.Generator;

public class CSharpOptions
{
    private readonly Dictionary<string, string> _contextVariables = new Dictionary<string, string>();
    public List<string> Usings { get; set; } = ["System", "CssInCSharp"];
    public string Namespace { get; set; } = "CssInCSharp";
    public string NamePrefix { get; set; } = default!;
    public string DefaultObjectType { get; set; } = "object";
    public string DefaultReturnType { get; set; } = "object";
    public string DefaultParameterType { get; set; } = "object";
    public string DefaultVariableType { get; set; } = "object";
    public string DefaultExportClassName { get; set; } = "GeneratedStyle";
    public string DefaultExportMethodName { get; set; } = "Default";
    public string DefaultExportType { get; set; } = "object";
    public bool UsePartialClass { get; set; } = false;
    public bool UseStaticMethod { get; set; } = false;
    public bool UsePascalCase { get; set; } = false;
    public bool UseAnonymousType { get; set; } = false;
    public List<MatchItem> Replacements { get; set; } = [];

    public void SetContextVariables()
    {
        _contextVariables[nameof(Namespace)] = Namespace;
        _contextVariables[nameof(NamePrefix)] = NamePrefix;
        _contextVariables[nameof(DefaultReturnType)] = DefaultReturnType;
        _contextVariables[nameof(DefaultParameterType)] = DefaultParameterType;
        _contextVariables[nameof(DefaultVariableType)] = DefaultVariableType;
        _contextVariables[nameof(DefaultExportClassName)] = DefaultExportClassName;
        _contextVariables[nameof(DefaultExportMethodName)] = DefaultExportMethodName;
        _contextVariables[nameof(DefaultExportType)] = DefaultExportType;
    }

    public string Replace(string input)
    {
        if (Replacements.Count <= 0)
        {
            return input;
        }

        foreach (var item in Replacements)
        {
            input = item.Replace(input, _contextVariables);
        }

        return input;
    }
}

public class MatchItem
{
    public string Pattern { get; set; } = default!;

    public string Value { get; set; } = default!;

    public MatchItem()
    {
    }

    public MatchItem(string pattern, string value)
    {
        Pattern = pattern;
        Value = value;
    }

    public string GetValue(Dictionary<string, string> context)
    {
        var match = Regex.Match(Value, @"\w*(\{(\w+)\})\w*");
        if (match is { Success: true, Groups.Count: >= 3 })
        {
            var replace = match.Groups[1].ToString();
            var key = match.Groups[2].ToString();
            if (context.TryGetValue(key, out var value))
            {
                return Value.Replace(replace, value);
            }
        }

        return Value;
    }

    public string Replace(string input, Dictionary<string, string> context)
    {
        var value = GetValue(context);
        return Regex.Replace(input, Pattern, value);
    }
}
