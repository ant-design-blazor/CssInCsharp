using CssInCSharp.Generator.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Ts = Zu.TypeScript;

namespace CssInCSharp.Generator
{
    public class CSharpOptions
    {
        public List<string> Usings { get; set; } = ["System"];
        public string Namespace { get; set; } = "CssInCSharp";
        public string DefaultReturnType { get; set; } = "object";
        public string DefaultParameterType { get; set; } = "object";
        public string? DefaultClassName { get; set; }
    }

    public class TypeScriptConverter : IConverter
    {
        private readonly CSharpOptions _options;

        public TypeScriptConverter(CSharpOptions options = null)
        {
            _options = options ?? new CSharpOptions();
        }

        public string Convert(string content, string fileName)
        {
            var usings = GenerateUsings();
            var ast = new Ts.TypeScriptAST(content, fileName);
            var member = GenerateMemberDeclaration(ast.RootNode);
            return SyntaxFactory.CompilationUnit()
                .WithUsings(usings)
                .AddMembers(member)
                .NormalizeWhitespace()
                .ToFullString();
        }

        private SyntaxList<UsingDirectiveSyntax> GenerateUsings()
        {
            var usings = _options.Usings.Select(x => SyntaxFactory.UsingDirective(
                SyntaxFactory.ParseName(x)));
            return SyntaxFactory.List<UsingDirectiveSyntax>(usings);
        }

        private MemberDeclarationSyntax? GenerateMemberDeclaration(Ts.TsTypes.INode node)
        {
            MemberDeclarationSyntax? csNode = null;
            if (node.IsMember())
            {
                csNode = GenerateCSharpAst(node).AsT0.AsType<MemberDeclarationSyntax>();
            }
            if (csNode != null)
            {
                foreach (var child in node.Children)
                {
                    var childNode = GenerateMemberDeclaration(child);
                    if (childNode != null)
                    {
                        csNode = csNode.AddMemberNodes(childNode);
                    }
                }
            }
            return csNode;
        }

        private SyntaxNodeOrList GenerateCSharpAst(Ts.TsTypes.INode node, NodeContext? context = null)
        {
            try
            {
                switch (node.Kind)
                {
                    case Ts.TsTypes.SyntaxKind.ArrowFunction:
                    {
                        var n = node.AsType<Ts.TsTypes.ArrowFunction>();
                        var funcName = context?.FuncName ?? string.Empty;
                        var returnType = n.Type?.GetText() ?? _options.DefaultReturnType;
                        var methodDeclaration = SyntaxFactory.MethodDeclaration(
                                SyntaxFactory.ParseTypeName(returnType), funcName)
                            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword));

                        var parameters = n.Parameters.Select(x =>
                        {
                            var pName = x.Name.GetText();
                            var pType = x.Type?.GetText() ?? _options.DefaultParameterType;
                            return SyntaxFactory.Parameter(SyntaxFactory.Identifier(pName))
                                .WithType(SyntaxFactory.ParseTypeName(pType));
                        }).ToArray();
                        methodDeclaration = methodDeclaration.AddParameterListParameters(parameters);

                        var funcBody = n.Body;
                        var statements = new List<StatementSyntax>();
                        switch (funcBody.Kind)
                        {
                            case Ts.TsTypes.SyntaxKind.Block:
                                var block = funcBody as Ts.TsTypes.Block;
                                foreach (var statement in block.Statements)
                                {
                                    switch (statement.Kind)
                                    {
                                        case Ts.TsTypes.SyntaxKind.VariableStatement:
                                            var variableStatement = statement as Ts.TsTypes.VariableStatement;
                                            var declaration = variableStatement.DeclarationList.Declarations[0];
                                            if (declaration.Name.Kind == Ts.TsTypes.SyntaxKind.ObjectBindingPattern)
                                            {
                                                if (declaration.Initializer.Kind == Ts.TsTypes.SyntaxKind.CallExpression)
                                                {

                                                }
                                                else
                                                {
                                                    var initializer = declaration.Initializer?.GetText() ?? string.Empty;
                                                    statements.AddRange(GenerateCSharpAst(declaration.Name, new NodeContext()
                                                    {
                                                        Initializer = initializer
                                                    }).AsT1.Cast<StatementSyntax>());
                                                }
                                            }
                                            else
                                            {
                                            }

                                            break;
                                        case Ts.TsTypes.SyntaxKind.ReturnStatement:
                                            var rs = statement as Ts.TsTypes.ReturnStatement;
                                            switch (rs.Expression.Kind)
                                            {
                                                case Ts.TsTypes.SyntaxKind.ObjectLiteralExpression:
                                                    statements.Add(SyntaxFactory.ReturnStatement(GenerateCSharpAst(rs.Expression, new NodeContext
                                                    {
                                                        ReturnType = returnType
                                                    }).AsType<ExpressionSyntax>()));
                                                    break;
                                            }

                                            break;
                                    }
                                }

                                break;
                            case Ts.TsTypes.SyntaxKind.ParenthesizedExpression:
                                var expression = funcBody as Ts.TsTypes.ParenthesizedExpression;
                                switch (expression.Expression.Kind)
                                {
                                    case Ts.TsTypes.SyntaxKind.ObjectLiteralExpression:
                                        statements.Add(
                                            SyntaxFactory.ReturnStatement(GenerateCSharpAst(expression.Expression, new NodeContext() { ReturnType = returnType }).AsType<ExpressionSyntax>()));
                                        break;
                                }
                                break;
                        }

                        return methodDeclaration.WithBody(SyntaxFactory.Block(statements));
                    }
                    case Ts.TsTypes.SyntaxKind.ArrayLiteralExpression:
                    {
                        var n = node.AsType<Ts.TsTypes.ArrayLiteralExpression>();
                        var elements = n.Elements.Select(x => (SyntaxNodeOrToken)GenerateCSharpAst(x).AsT0)
                            .Separate(SyntaxFactory.Token(SyntaxKind.CommaToken));
                        var arrayType = SyntaxFactory.ArrayType(
                                SyntaxFactory.PredefinedType(
                                    SyntaxFactory.Token(SyntaxKind.ObjectKeyword)))
                            .WithRankSpecifiers(
                                SyntaxFactory.SingletonList<ArrayRankSpecifierSyntax>(
                                    SyntaxFactory.ArrayRankSpecifier(
                                        SyntaxFactory.SingletonSeparatedList<ExpressionSyntax>(
                                            SyntaxFactory.OmittedArraySizeExpression()))));
                        return SyntaxFactory.ArrayCreationExpression(arrayType)
                            .WithInitializer(
                                SyntaxFactory.InitializerExpression(
                                    SyntaxKind.ArrayInitializerExpression,
                                    SyntaxFactory.SeparatedList<ExpressionSyntax>(elements)));
                    }
                    case Ts.TsTypes.SyntaxKind.AsExpression:
                    {
                        var n = node.AsType<Ts.TsTypes.AsExpression>();
                        var variable = GenerateCSharpAst(n.Expression).AsType<ExpressionSyntax>();
                        var type = n.Type.GetText();
                        return SyntaxFactory.BinaryExpression
                        (
                            SyntaxKind.AsExpression,
                            variable,
                            SyntaxFactory.IdentifierName(type)
                        );
                    }
                    case Ts.TsTypes.SyntaxKind.BinaryExpression:
                    {
                        var n = node.AsType<Ts.TsTypes.BinaryExpression>();
                        var operatorToken = GenerateOperatorToken(n.OperatorToken);
                        var left = GenerateCSharpAst(n.Left).AsType<ExpressionSyntax>();
                        var right = GenerateCSharpAst(n.Right).AsType<ExpressionSyntax>();
                        return SyntaxFactory.BinaryExpression(operatorToken, left, right);
                    }
                    case Ts.TsTypes.SyntaxKind.CallExpression:
                    {
                        var n = node.AsType<Ts.TsTypes.CallExpression>();
                        var args = n.Arguments
                            .Where(x => x.Kind != Ts.TsTypes.SyntaxKind.ArrowFunction)
                            .Select(x => SyntaxFactory.Argument(GenerateCSharpAst(x).AsType<ExpressionSyntax>()));
                        return SyntaxFactory.InvocationExpression
                        (
                            GenerateCSharpAst(n.Expression).AsType<ExpressionSyntax>(),
                            SyntaxFactory.ArgumentList(SyntaxFactory.SeparatedList(args))
                        );
                    }
                    case Ts.TsTypes.SyntaxKind.ComputedPropertyName:
                    {
                        var n = node.AsType<Ts.TsTypes.ComputedPropertyName>();
                        return GenerateCSharpAst(n.Expression);
                    }
                    case Ts.TsTypes.SyntaxKind.HeritageClause:
                    {
                        var n = node.AsType<Ts.TsTypes.HeritageClause>();
                        return n.Types.Select(x =>
                        {
                            if (x.TypeArguments is { Count: > 0 })
                            {
                                var args = x.TypeArguments
                                    .Select(x => (SyntaxNodeOrToken)SyntaxFactory.IdentifierName(x.GetText().Purify()))
                                    .Separate(SyntaxFactory.Token(SyntaxKind.CommaToken));

                                return (SyntaxNodeOrToken)SyntaxFactory.SimpleBaseType(SyntaxFactory
                                    .GenericName(x.IdentifierStr)
                                    .WithTypeArgumentList(
                                        SyntaxFactory.TypeArgumentList(SyntaxFactory.SeparatedList<TypeSyntax>(args))));
                            }
                            else
                            {
                                return (SyntaxNodeOrToken)SyntaxFactory.SimpleBaseType(
                                    SyntaxFactory.IdentifierName(x.IdentifierStr));
                            }
                        }).Separate(SyntaxFactory.Token(SyntaxKind.CommaToken)).ToList();
                    }
                    case Ts.TsTypes.SyntaxKind.Identifier:
                    {
                        return SyntaxFactory.IdentifierName(node.GetText());
                    }
                    case Ts.TsTypes.SyntaxKind.InterfaceDeclaration:
                    {
                        var n = node.AsType<Ts.TsTypes.InterfaceDeclaration>();
                        var classDeclaration = SyntaxFactory
                            .ClassDeclaration(n.IdentifierStr)
                            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword));
                        if (n.HeritageClauses is { Count: > 0 })
                        {
                            var heritageClauses = n.HeritageClauses.SelectMany(x => GenerateCSharpAst(x).AsT2);
                            classDeclaration = classDeclaration.WithBaseList
                            (
                                SyntaxFactory.BaseList(SyntaxFactory.SeparatedList<BaseTypeSyntax>(heritageClauses))
                            );
                        }

                        return classDeclaration;
                    }
                    case Ts.TsTypes.SyntaxKind.NumericLiteral:
                    {
                        var n = node.AsType<Ts.TsTypes.NumericLiteral>();
                        return SyntaxFactory.LiteralExpression
                        (
                            SyntaxKind.NumericLiteralExpression,
                            SyntaxFactory.Literal(System.Convert.ToDouble(n.Text))
                        );
                    }
                    case Ts.TsTypes.SyntaxKind.ObjectBindingPattern:
                    {
                        var n = node.AsType<Ts.TsTypes.ObjectBindingPattern>();
                        var initializer = context?.Initializer ?? string.Empty;
                        var bindings = new List<SyntaxNode>();
                        foreach (var el in n.Elements)
                        {
                            var item = (el as Ts.TsTypes.BindingElement)!;
                            var name = item.Name.GetText();
                            var property = item.PropertyName?.GetText() ?? name;
                            var variable = SyntaxFactory
                                .VariableDeclaration(SyntaxFactory.ParseTypeName("var"))
                                .AddVariables
                                (
                                    SyntaxFactory.VariableDeclarator(name).WithInitializer
                                    (
                                        SyntaxFactory.EqualsValueClause
                                        (
                                            SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, SyntaxFactory.IdentifierName(initializer),
                                                SyntaxFactory.IdentifierName(property))
                                        )
                                    )
                                );
                            bindings.Add(SyntaxFactory.LocalDeclarationStatement(variable));
                        }

                        return bindings;
                    }
                    case Ts.TsTypes.SyntaxKind.ObjectLiteralExpression:
                    {
                        var n = node.AsType<Ts.TsTypes.ObjectLiteralExpression>();
                        var returnType = context?.ReturnType ?? _options.DefaultReturnType;
                        var assignments = n.Properties
                            .Where(x => x.Kind == Ts.TsTypes.SyntaxKind.PropertyAssignment || x.Kind == Ts.TsTypes.SyntaxKind.SpreadAssignment)
                            .Select(x => (SyntaxNodeOrToken)GenerateCSharpAst(x, new NodeContext()
                            {
                                ReturnType = returnType,
                            }).AsType<ExpressionSyntax>());
                        return SyntaxFactory
                            .ObjectCreationExpression(SyntaxFactory.IdentifierName(returnType))
                            .WithInitializer
                            (
                                SyntaxFactory.InitializerExpression
                                (
                                    SyntaxKind.ObjectInitializerExpression,
                                    SyntaxFactory.SeparatedList<ExpressionSyntax>(assignments.Separate(SyntaxFactory.Token(SyntaxKind.CommaToken), true))
                                )
                            );
                    }
                    case Ts.TsTypes.SyntaxKind.ParenthesizedExpression:
                    {
                        var n = node.AsType<Ts.TsTypes.ParenthesizedExpression>();
                        return SyntaxFactory.ParenthesizedExpression(GenerateCSharpAst(n.Expression)
                            .AsType<ExpressionSyntax>());
                    }
                    case Ts.TsTypes.SyntaxKind.PrefixUnaryExpression:
                    {
                        var n = node.AsType<Ts.TsTypes.PrefixUnaryExpression>();
                        return SyntaxFactory.PrefixUnaryExpression
                        (
                            SyntaxKind.UnaryMinusExpression,
                            GenerateCSharpAst(n.Operand).AsType<ExpressionSyntax>()
                        );
                    }
                    case Ts.TsTypes.SyntaxKind.PropertyAccessExpression:
                    {
                        var n = node.AsType<Ts.TsTypes.PropertyAccessExpression>();
                        return SyntaxFactory.MemberAccessExpression
                        (
                            SyntaxKind.SimpleMemberAccessExpression,
                            SyntaxFactory.IdentifierName(n.Expression.GetText()),
                            SyntaxFactory.IdentifierName(n.Name.GetText())
                        );
                    }
                    case Ts.TsTypes.SyntaxKind.PropertyAssignment:
                    {
                        var n = node.AsType<Ts.TsTypes.PropertyAssignment>();
                        var initializer = n.Initializer;
                        var left = GenerateCSharpAst(n.Name, context).AsType<ExpressionSyntax>();
                        if (n.Name.IsIndexerProperty())
                        {
                            left = SyntaxFactory.ElementAccessExpression(SyntaxFactory.IdentifierName(""))
                                .WithArgumentList(
                                    SyntaxFactory.BracketedArgumentList(
                                        SyntaxFactory.SingletonSeparatedList(
                                            SyntaxFactory.Argument(left))));
                        }
                        var right = GenerateCSharpAst(initializer, context).AsType<ExpressionSyntax>();
                        return SyntaxFactory.AssignmentExpression
                        (
                            SyntaxKind.SimpleAssignmentExpression,
                            left,
                            right
                        );
                    }
                    case Ts.TsTypes.SyntaxKind.PropertySignature:
                    {
                        var n = node.AsType<Ts.TsTypes.PropertySignature>();
                        return SyntaxFactory
                            .PropertyDeclaration(SyntaxFactory.ParseTypeName("string"), n.IdentifierStr)
                            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                            .AddAccessorListAccessors
                            (
                                SyntaxFactory
                                    .AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
                                SyntaxFactory
                                    .AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                                    .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
                            );
                    }
                    case Ts.TsTypes.SyntaxKind.SpreadAssignment:
                    {
                        var n = node.AsType<Ts.TsTypes.SpreadAssignment>();
                        var expression = GenerateCSharpAst(n.Expression).AsType<ExpressionSyntax>();
                        if (n.Parent.IsPropertyAssignment())
                        {
                            var field = SyntaxFactory.ElementAccessExpression(SyntaxFactory.IdentifierName(""))
                                .WithArgumentList(
                                    SyntaxFactory.BracketedArgumentList(
                                        SyntaxFactory.SingletonSeparatedList(
                                            SyntaxFactory.Argument(SyntaxFactory.LiteralExpression(
                                                SyntaxKind.StringLiteralExpression,
                                                SyntaxFactory.Literal("..."))))));
                            return SyntaxFactory.AssignmentExpression
                            (
                                SyntaxKind.SimpleAssignmentExpression,
                                field,
                                expression
                            );
                        }

                        return expression;
                    }
                    case Ts.TsTypes.SyntaxKind.ReturnStatement:
                    {
                        var n = node.AsType<Ts.TsTypes.ReturnStatement>();
                        return SyntaxFactory.ReturnStatement(GenerateCSharpAst(n.Expression, context).AsType<ExpressionSyntax>());
                    }
                    case Ts.TsTypes.SyntaxKind.SourceFile:
                    {
                        return SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(_options.Namespace));
                    }
                    case Ts.TsTypes.SyntaxKind.StringLiteral:
                    {
                        var n = node.AsType<Ts.TsTypes.StringLiteral>();
                        return SyntaxFactory.LiteralExpression
                        (
                            SyntaxKind.StringLiteralExpression,
                            SyntaxFactory.Literal(n.Text)
                        );
                    }
                    case Ts.TsTypes.SyntaxKind.TemplateExpression:
                    {
                        var n = node.AsType<Ts.TsTypes.TemplateExpression>();
                        var spans = new List<InterpolatedStringContentSyntax>();
                        foreach (var span in n.TemplateSpans)
                        {
                            var expression = GenerateCSharpAst(span.Expression).AsType<ExpressionSyntax>();
                            spans.Add(SyntaxFactory.Interpolation(expression));
                            spans.Add(SyntaxFactory.InterpolatedStringText(
                                SyntaxFactory.Token(
                                    SyntaxFactory.TriviaList(),
                                    SyntaxKind.InterpolatedStringTextToken,
                                    span.Literal.Text,
                                    "",
                                    SyntaxFactory.TriviaList())));
                        }

                        return SyntaxFactory.InterpolatedStringExpression
                        (
                            SyntaxFactory.Token(SyntaxKind.InterpolatedStringStartToken),
                            SyntaxFactory.List<InterpolatedStringContentSyntax>(spans)
                        );
                    }
                    case Ts.TsTypes.SyntaxKind.TrueKeyword:
                    {
                        return SyntaxFactory.LiteralExpression(
                            SyntaxKind.TrueLiteralExpression);
                    }
                    case Ts.TsTypes.SyntaxKind.FirstTemplateToken:
                    {
                        var n = node.AsType<Ts.TsTypes.NoSubstitutionTemplateLiteral>();
                        return SyntaxFactory.LiteralExpression
                        (
                            SyntaxKind.StringLiteralExpression,
                            SyntaxFactory.Literal(n.Text)
                        );
                    }
                    case Ts.TsTypes.SyntaxKind.VariableStatement:
                    {
                        var n = node.AsType<Ts.TsTypes.VariableStatement>();
                        var declaration = n.DeclarationList.Declarations[0];
                        if (declaration.Initializer.Kind == Ts.TsTypes.SyntaxKind.Identifier)
                        {
                            var initializer = declaration.Initializer?.GetText() ?? string.Empty;
                            return GenerateCSharpAst(declaration.Name, new NodeContext
                            {
                                Initializer = initializer
                            });
                        }
                        else
                        {
                            var funcName = declaration.Name.GetText();
                            return GenerateCSharpAst(declaration.Initializer, new NodeContext { FuncName = funcName });
                        }
                    }
                    default: return default;
                }
            }
            catch (AstGenerateException)
            {
                throw;
            }
            catch (Exception ex)
            {
                var n = node.AsType<Ts.TsTypes.Node>();
                var start = GetLineNumber(n.SourceStr, n.NodeStart);
                var end = GetLineNumber(n.SourceStr, n.End.Value);
                throw new AstGenerateException($"Generate ast failed, source file pos: {start} {end}");
            }
        }

        private SyntaxKind GenerateOperatorToken(Ts.TsTypes.INode node)
        {
            switch (node.Kind)
            {
                case Ts.TsTypes.SyntaxKind.AsteriskToken:
                    return SyntaxKind.MultiplyExpression;
                case Ts.TsTypes.SyntaxKind.PlusToken:
                    return SyntaxKind.AddExpression;
                case Ts.TsTypes.SyntaxKind.MinusToken:
                    return SyntaxKind.SubtractExpression;
                case Ts.TsTypes.SyntaxKind.SlashToken:
                    return SyntaxKind.DivideExpression;
                case Ts.TsTypes.SyntaxKind.BarBarToken:
                    return SyntaxKind.CoalesceExpression;
                default:
                    throw new Exception("Typescript SyntaxKind map error.");
            }
        }

        static int GetLineNumber(string text, int index)
        {
            if (index < 0 || index > text.Length)
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of the range of the text.");

            int line = 1;
            for (int i = 0; i < index; i++)
            {
                if (text[i] == '\n')
                    line++;
            }

            return line;
        }
    }

    public class AstGenerateException: Exception
    {
        public AstGenerateException(string message) : base(message)
        {

        }
    }

    public class NodeContext
    {
        public string? ReturnType { get; set; }
        public string? Initializer { get; set; }
        public string? FuncName { get; set; }
    }

    public struct SyntaxNodeOrList
    {
        private readonly int _index;
        private readonly SyntaxNode _value0;
        private readonly List<SyntaxNode> _value1;
        private readonly List<SyntaxNodeOrToken> _value2;
        
        private SyntaxNodeOrList(
            int index,
            SyntaxNode value0 = default,
            List<SyntaxNode> value1 = default,
            List<SyntaxNodeOrToken> value2 = default)
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
        }

        public static implicit operator SyntaxNodeOrList(SyntaxNode t) => new(0, value0: t);
        public static implicit operator SyntaxNodeOrList(List<SyntaxNode> t) => new(1, value1: t);
        public static implicit operator SyntaxNodeOrList(List<SyntaxNodeOrToken> t) => new(2, value2: t);

        public T AsType<T>() where T : SyntaxNode
        {
            return _index == 0 ?
                (T)_value0 :
                throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
        }

        public bool IsType<T>()
        {
            if (_index == 0)
            {
                return _value0.GetType().IsAssignableFrom(typeof(T));
            }

            return false;
        }

        public bool IsT0 => _index == 0;
        public bool IsT1 => _index == 1;
        public bool IsT2 => _index == 2;

        public SyntaxNode AsT0 =>
            _index == 0 ?
                _value0 :
                throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");

        public List<SyntaxNode> AsT1 =>
            _index == 1 ?
                _value1 :
                throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");

        public List<SyntaxNodeOrToken> AsT2 =>
            _index == 2 ?
                _value2 :
                throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
    }
}
