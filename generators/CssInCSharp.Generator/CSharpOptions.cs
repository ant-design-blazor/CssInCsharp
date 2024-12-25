using System.Text.RegularExpressions;

namespace CssInCSharp.Generator;

public class CSharpOptions
{
    public List<string> Usings { get; set; } = ["System", "CssInCSharp"];
    public string Namespace { get; set; } = "CssInCSharp";
    public string DefaultReturnType { get; set; } = "object";
    public string DefaultParameterType { get; set; } = "object";
    public string DefaultFieldType { get; set; } = "object";
    public string DefaultClassName { get; set; } = "GeneratedStyle";
    public string DefaultExportMethodName { get; set; } = "Default";
    public bool UsePartialClass { get; set; } = false;
    public bool UseStaticMethod { get; set; } = false;
    public bool UsePascalCase { get; set; } = true;
    public List<Replacement> Replacements { get; set; } = [];

    public string Replace(string input)
    {
        if (Replacements.Count <= 0)
        {
            return input;
        }
        var context = new Dictionary<string, string>
        {
            { nameof(Namespace), Namespace },
            { nameof(DefaultReturnType), DefaultReturnType },
            { nameof(DefaultParameterType), DefaultParameterType },
            { nameof(DefaultFieldType), DefaultFieldType },
            { nameof(DefaultClassName), DefaultClassName },
            { nameof(DefaultExportMethodName), DefaultExportMethodName },
        };

        foreach (var item in Replacements)
        {
            input = item.Replace(input, context);
        }

        return input;
    }
}

public class Replacement
{
    public string Pattern { get; set; } = default!;

    public string Value { get; set; } = default!;

    public Replacement()
    {
    }

    public Replacement(string pattern, string value)
    {
        Pattern = pattern;
        Value = value;
    }

    public string Replace(string input, Dictionary<string, string> context)
    {
        var match = Regex.Match(Value, @"\w*(\{(\w+)\})\w*");
        if (match is { Success: true, Groups.Count: >= 3 })
        {
            var replace = match.Groups[1].ToString();
            var key = match.Groups[2].ToString();
            if (context.TryGetValue(key, out var value))
            {
                Value = Value.Replace(replace, value);
            }
        }
        return Regex.Replace(input, Pattern, Value);
    }
}
