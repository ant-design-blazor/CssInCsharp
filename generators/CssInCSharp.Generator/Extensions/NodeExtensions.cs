using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Ts = Zu.TypeScript;

namespace CssInCSharp.Generator.Extensions;

internal static class NodeExtensions
{
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
        /*
         * depth 0 is source file
         * depth 1 is member declaration
         */
        if (node.Depth <= 1) return true;
        return false;

        // switch (node.Kind)
        // {
        //     case Ts.TsTypes.SyntaxKind.SourceFile:
        //     case Ts.TsTypes.SyntaxKind.InterfaceDeclaration:
        //     case Ts.TsTypes.SyntaxKind.VariableDeclaration:
        //     case Ts.TsTypes.SyntaxKind.VariableStatement:
        //     case Ts.TsTypes.SyntaxKind.FunctionDeclaration:
        //     case Ts.TsTypes.SyntaxKind.PropertySignature:
        //         return true;
        //     default: return false;
        // }
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

    public static T AsType<T>(this SyntaxNode node) where T: SyntaxNode
    {
        return (T)node;
    }

    public static T AsType<T>(this Ts.TsTypes.INode node) where T: Ts.TsTypes.INode
    {
        return (T)node;
    }
}
