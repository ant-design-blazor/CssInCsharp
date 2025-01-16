using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Ts = Zu.TypeScript;

namespace CssInCSharp.Generator.Extensions;

internal static class NodeExtensions
{
    private static string[] _htmlTags = [
        "a",
        "bdi",
        "blockquote",
        "button",
        "code",
        "fill",
        "i",
        "img",
        "input",
        "kbd",
        "li",
        "mark",
        "ol",
        "pre",
        "span",
        "stroke",
        "strong",
        "svg",
        "table",
        "td",
        "textarea",
        "th",
        "to",
        "ul",
    ];

    public static MemberDeclarationSyntax AddMemberNodes(this MemberDeclarationSyntax node, params MemberDeclarationSyntax[] members)
    {
        switch (node)
        {
            case NamespaceDeclarationSyntax namespaceDeclaration:
                return namespaceDeclaration.AddMembers(members);
            case ClassDeclarationSyntax classDeclaration:
                return classDeclaration.AddMembers(members);
            default: throw new Exception("");
        }
    }

    public static bool IsNodeType<T>(this SyntaxNode node)
    {
        return node.GetType().IsAssignableFrom(typeof(T));
    }

    public static bool IsMember(this Ts.TsTypes.INode node)
    {
        switch (node.Kind)
        {
            case Ts.TsTypes.SyntaxKind.SourceFile:
            case Ts.TsTypes.SyntaxKind.InterfaceDeclaration:
            case Ts.TsTypes.SyntaxKind.VariableDeclaration:
            case Ts.TsTypes.SyntaxKind.VariableStatement:
            case Ts.TsTypes.SyntaxKind.FunctionDeclaration:
            case Ts.TsTypes.SyntaxKind.PropertySignature:
            case Ts.TsTypes.SyntaxKind.ExportAssignment:
            case Ts.TsTypes.SyntaxKind.TypeAliasDeclaration:
                return true;
            default: return false;
        }
    }

    public static bool IsHtmlTag(this Ts.TsTypes.INode node)
    {
        if (node.Kind == Ts.TsTypes.SyntaxKind.Identifier)
        {
            var tag = node.GetText();
            return _htmlTags.Contains(tag);
        }
        return false;
    }

    public static bool IsIndexerProperty(this Ts.TsTypes.INode node)
    {
        switch (node.Kind)
        {
            case Ts.TsTypes.SyntaxKind.StringLiteral:
            case Ts.TsTypes.SyntaxKind.ComputedPropertyName:
            case Ts.TsTypes.SyntaxKind.TemplateExpression:
                return true;
            default: return false;
        }
    }

    public static bool IsPropertyAssignment(this Ts.TsTypes.INode node)
    {
        switch (node.Kind)
        {
            case Ts.TsTypes.SyntaxKind.ObjectLiteralExpression:
                return true;
            default: return false;
        }
    }

    public static bool IsProperty(this Ts.TsTypes.INode node)
    {
        switch (node.Kind)
        {
            case Ts.TsTypes.SyntaxKind.PropertyAssignment:
            case Ts.TsTypes.SyntaxKind.SpreadAssignment:
            case Ts.TsTypes.SyntaxKind.ShorthandPropertyAssignment:
                return true;
            default: return false;
        }
    }

    public static bool IsUnsupportedStatement(this Ts.TsTypes.INode node)
    {
        switch (node.Kind)
        {
            case Ts.TsTypes.SyntaxKind.TypeAliasDeclaration:
                return true;
            default: return false;
        }
    }

    public static T AsType<T>(this SyntaxNode node) where T: SyntaxNode
    {
        return (T)node;
    }

    public static T AsType<T>(this Ts.TsTypes.INode node) where T: Ts.TsTypes.INode
    {
        return (T)node;
    }
}
