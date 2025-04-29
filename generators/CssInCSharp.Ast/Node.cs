using System.Text;

namespace CssInCSharp.Ast;

public struct Position
{
    public int line;
    public int column;
}

public class NodeOptions
{
    public string type { get; set; }
    public Content content { get; set; }
    public Position? start { get; set; }
    public Position? end { get; set; }
    public string syntax { get; set; }
}

public class Node
{
    public string type { get; set; }
    public Content content { get; set; }
    public Position? start { get; set; }
    public Position? end { get; set; }
    public string syntax { get; set; }

    public Node(NodeOptions options)
    {
        type = options.type;
        content = options.content;
        syntax = options.syntax;
        if (options.start.HasValue) start = options.start;
        if (options.end.HasValue) end = options.end;
    }

    public override string ToString()
    {
        var fmt = content.IsString ? $"'{content.AsString}'" : $"Array({content.AsArray.Count})";
        return $"type: '{type}', content: {fmt}, syntax: '{syntax}'";
    }

    public string GetText(Func<Node, bool>? func = null)
    {
        var sb = new StringBuilder();
        void GetTextCore(Content node)
        {
            if (node.IsString)
            {
                sb.Append(node.AsString);
            }
            else
            {
                foreach (var item in node.AsArray)
                {
                    if (item.type == NodeType.ClassType)
                    {
                        sb.Append(".");
                    }
                    if (item.type == NodeType.UniversalSelectorType)
                    {
                        sb.Append("*");
                    }
                    if (item.type == "pseudoElement")
                    {
                        sb.Append("::");
                    }
                    if (item.type == "color")
                    {
                        sb.Append("#");
                    }
                    if (item.type == "pseudoClass")
                    {
                        sb.Append(":");
                    }
                    if (item.type == NodeType.CustomPropertyType)
                    {
                        sb.Append("--");
                    }

                    if (item.type == NodeType.AttributeSelectorType)
                    {
                        sb.Append("[");
                        GetTextCore(item.content);
                        sb.Append("]");
                        continue;
                    }

                    if (item.type == NodeType.ArgumentsType)
                    {
                        sb.Append("(");
                        GetTextCore(item.content);
                        sb.Append(")");
                        continue;
                    }
                    if (func != null)
                    {
                        var r = func(item);
                        if (r)
                        {
                            GetTextCore(item.content);
                        }
                    }
                    else
                    {
                        GetTextCore(item.content);
                    }
                }
            }
        }

        GetTextCore(content);
        return sb.ToString().Trim();
    }
}
