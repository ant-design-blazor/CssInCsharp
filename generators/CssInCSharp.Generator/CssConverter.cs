using CssInCSharp.Ast.Css;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using CssInCSharp.Generator.Extensions;

namespace CssInCSharp.Generator
{
    public class ConverterBase : IConverter
    {
        protected readonly CSharpOptions _options;

        public ConverterBase(CSharpOptions options)
        {
            _options = options;
            _options.DefaultObjectType = "CSSObject";
        }

        public string Convert(string content, string fileName)
        {
            var csAst = Generate(content, fileName);
            var code = csAst.NormalizeWhitespace().ToFullString();
            return _options.Replace(code);
        }

        protected virtual CompilationUnitSyntax Generate(string content, string fileName)
        {
            // usings
            var usings = SyntaxFactory.List<UsingDirectiveSyntax>(_options.Usings.Select(GenerateUsing));

            // namespace
            var @namespace = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(_options.Namespace));

            // members
            var members = GenerateMembers(content, fileName);
            if (members != null)
            {
                @namespace = @namespace.AddMembers(members);
            }
            
            return SyntaxFactory.CompilationUnit()
                .WithUsings(usings)
                .AddMembers(@namespace);
        }

        protected virtual MemberDeclarationSyntax? GenerateMembers(string content, string fileName)
        {
            return null;
        }

        private UsingDirectiveSyntax GenerateUsing(string usingStr)
        {
            var strs = usingStr.Split("=");
            if (strs.Length > 1)
            {
                return SyntaxFactory.UsingDirective(SyntaxFactory.ParseName(strs[1].Trim())).WithAlias(SyntaxFactory.NameEquals(strs[0].Trim()));
            }

            strs = usingStr.Split("static");
            if (strs.Length > 1)
            {
                return SyntaxFactory.UsingDirective(SyntaxFactory.ParseName(strs[1].Trim())).WithStaticKeyword(SyntaxFactory.Token(SyntaxKind.StaticKeyword));
            }

            return SyntaxFactory.UsingDirective(
                SyntaxFactory.ParseName(usingStr));
        }
    }

    public class CssConverter: ConverterBase
    {
        public CssConverter(CSharpOptions? options = null) : base(options ?? new CSharpOptions())
        {
        }

        protected override MemberDeclarationSyntax? GenerateMembers(string content, string fileName)
        {
            var tokens = new Tokenizer().getTokens(content, 1);
            new Mark().markTokens(tokens);
            var ast = new Parse(tokens.ToArray()).stylesheet();
            var csNode = GenerateMemberDeclaration(ast);
            return (MemberDeclarationSyntax)csNode.AsT0;
        }

        private SyntaxNodeOrList GenerateMemberDeclaration(Node node)
        {
            switch (node.type)
            {
                case NodeType.StylesheetType:
                {
                    SyntaxToken[] tokens = _options.UseStaticMethod
                        ? [SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword)]
                        : [SyntaxFactory.Token(SyntaxKind.PublicKeyword)];
                    var type = _options.DefaultObjectType;
                    var funcName = _options.DefaultExportMethodName;
                    

                    var list = new List<ExpressionSyntax>();
                    foreach (var item in node.content.AsArray)
                    {
                        var n = GenerateMemberDeclaration(item);
                        if (n is { IsT0: true, AsT0: not null })
                        {
                            list.Add(n.AsType<ExpressionSyntax>());
                        }
                        else if (n.IsT1)
                        {
                            list.AddRange(n.AsT1.Cast<ExpressionSyntax>());
                        }
                    }

                    var statement = SyntaxFactory.ReturnStatement(SyntaxFactory
                        .ObjectCreationExpression(SyntaxFactory.IdentifierName(type))
                        .WithInitializer(SyntaxFactory.InitializerExpression(SyntaxKind.ObjectInitializerExpression, SyntaxFactory.SeparatedList<ExpressionSyntax>(list))));

                    var methodDeclaration = SyntaxFactory
                        .MethodDeclaration(SyntaxFactory.ParseTypeName(type), funcName)
                        .AddModifiers(tokens)
                        .WithBody(SyntaxFactory.Block(SyntaxFactory.SingletonList<StatementSyntax>(statement)));

                    return SyntaxFactory.ClassDeclaration(_options.DefaultExportClassName).AddModifiers(tokens).AddMembers(methodDeclaration);
                }
                case NodeType.RulesetType:
                {
                    var selector = node.GetText((n) => n.type != NodeType.BlockType);
                    var left = SyntaxFactory.ElementAccessExpression(SyntaxFactory.IdentifierName(""))
                        .WithArgumentList(
                            SyntaxFactory.BracketedArgumentList(
                                SyntaxFactory.SingletonSeparatedList(
                                    SyntaxFactory.Argument(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(selector))))));
                    var right = GenerateMemberDeclaration(node.content.GetNode(NodeType.BlockType)).AsType<ExpressionSyntax>();
                    return SyntaxFactory.AssignmentExpression(
                        SyntaxKind.SimpleAssignmentExpression,
                        left,
                        right);
                }
                case NodeType.DeclarationType:
                {
                    var propNode = node.content.GetNode(NodeType.PropertyType, NodeType.CustomPropertyType);
                    var valueNode = node.content.GetNode(NodeType.ValueType);
                    var right = SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(valueNode.GetText()));

                    ExpressionSyntax left;
                    if (propNode.type == NodeType.PropertyType)
                    {
                        var property = propNode.content.GetNode(NodeType.IdentType).content.AsString.ToCssProperty();
                        left = SyntaxFactory.IdentifierName(property);
                    }
                    else
                    {
                        var property = propNode.content.GetNode(NodeType.IdentType).content.AsString.ToCssCustomProperty();
                        left = SyntaxFactory.ElementAccessExpression(SyntaxFactory.IdentifierName(""))
                        .WithArgumentList(
                            SyntaxFactory.BracketedArgumentList(
                                SyntaxFactory.SingletonSeparatedList(
                                    SyntaxFactory.Argument(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(property))))));
                    }
                    return SyntaxFactory.AssignmentExpression
                    (
                        SyntaxKind.SimpleAssignmentExpression,
                        left,
                        right
                    );
                }
                case NodeType.BlockType:
                {
                    var list = node.content.AsArray
                        .Where(x => x.type == NodeType.DeclarationType)
                        .Select(x => GenerateMemberDeclaration(x).AsType<ExpressionSyntax>());
                    return SyntaxFactory
                        .ObjectCreationExpression(SyntaxFactory.IdentifierName(_options.DefaultObjectType))
                        .WithInitializer(SyntaxFactory.InitializerExpression(SyntaxKind.ObjectInitializerExpression, SyntaxFactory.SeparatedList<ExpressionSyntax>(list)));
                }
            }

            return default;
        }
    }

    public class LessConverter : ConverterBase
    {
        public LessConverter(CSharpOptions? options = null) : base(options ?? new CSharpOptions())
        {
        }
    }

    public class SassConverter : ConverterBase
    {
        public SassConverter(CSharpOptions? options = null) : base(options ?? new CSharpOptions())
        {
        }
    }

    public class ScssConverter : ConverterBase
    {
        public ScssConverter(CSharpOptions? options = null) : base(options ?? new CSharpOptions())
        {
        }
    }
}
