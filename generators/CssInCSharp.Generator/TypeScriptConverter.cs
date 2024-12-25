using CssInCSharp.Generator.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Ts = Zu.TypeScript;

namespace CssInCSharp.Generator
{
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
        public bool UsePascalCase { get; set; } = false;
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
            var tsAst = new Ts.TypeScriptAST(content, fileName);
            var csAst = Generate(tsAst.RootNode);
            return csAst.NormalizeWhitespace().ToFullString();
        }

        private CompilationUnitSyntax Generate(Ts.TsTypes.INode node)
        {
            // usings
            var usings = SyntaxFactory.List<UsingDirectiveSyntax>(_options.Usings.Select(x => SyntaxFactory.UsingDirective(
                SyntaxFactory.ParseName(x))));

            // namespace
            var @namespace = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(_options.Namespace));

            // members
            var members = GenerateMemberDeclaration(node);
            @namespace = @namespace.AddMembers(members);

            return SyntaxFactory.CompilationUnit()
                .WithUsings(usings)
                .AddMembers(@namespace);
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

                        var parameters = n.Parameters.Select(x =>
                        {
                            var pName = x.Name.GetText();
                            var pType = x.Type?.GetText() ?? _options.DefaultParameterType;
                            return SyntaxFactory.Parameter(SyntaxFactory.Identifier(pName))
                                .WithType(SyntaxFactory.ParseTypeName(pType));
                        }).ToArray();
                        
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
                                            if (variableStatement.DeclarationList.Declarations.Count <= 0) break;
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

                        if (context is { UseLambda: true })
                        {
                            return SyntaxFactory.ParenthesizedLambdaExpression(SyntaxFactory.ParameterList(SyntaxFactory.SeparatedList(parameters)), SyntaxFactory.Block(statements));
                        }
                        else
                        {
                            SyntaxToken[] tokens = _options.UseStaticMethod
                                ? [SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword)]
                                : [SyntaxFactory.Token(SyntaxKind.PublicKeyword)];
                            var methodDeclaration = SyntaxFactory
                                .MethodDeclaration(SyntaxFactory.ParseTypeName(returnType), Format(funcName))
                                .AddModifiers(tokens);
                            methodDeclaration = methodDeclaration.AddParameterListParameters(parameters);
                            return methodDeclaration.WithBody(SyntaxFactory.Block(statements));
                        }
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
                            .Select(x => (SyntaxNodeOrToken)SyntaxFactory.Argument(GenerateCSharpAst(x, new NodeContext() { UseLambda = true }).AsType<ExpressionSyntax>()))
                            .Separate(SyntaxFactory.Token(SyntaxKind.CommaToken)).ToList();
                        return SyntaxFactory.InvocationExpression
                        (
                            GenerateCSharpAst(n.Expression).AsType<ExpressionSyntax>(),
                            SyntaxFactory.ArgumentList(SyntaxFactory.SeparatedList<ArgumentSyntax>(args))
                        );
                    }
                    case Ts.TsTypes.SyntaxKind.ComputedPropertyName:
                    {
                        var n = node.AsType<Ts.TsTypes.ComputedPropertyName>();
                        return GenerateCSharpAst(n.Expression);
                    }
                    case Ts.TsTypes.SyntaxKind.ConditionalExpression:
                    {
                        var n = node.AsType<Ts.TsTypes.ConditionalExpression>();
                        if (n.WhenFalse.Kind == Ts.TsTypes.SyntaxKind.MissingDeclaration)
                        {
                            return GenerateCSharpAst(n.WhenTrue, new NodeContext() { ConditionalToken = n.IdentifierStr });
                        } 
                        else if (n.WhenTrue.Kind == Ts.TsTypes.SyntaxKind.MissingDeclaration)
                        {
                            return GenerateCSharpAst(n.WhenFalse, new NodeContext() { ConditionalToken = n.IdentifierStr });
                        }
                        else
                        {
                            var condition = GenerateCSharpAst(n.Condition).AsType<ExpressionSyntax>();
                            var whenTrue = GenerateCSharpAst(n.WhenTrue).AsType<ExpressionSyntax>();
                            var whenFalse = GenerateCSharpAst(n.WhenFalse).AsType<ExpressionSyntax>();
                            return SyntaxFactory.ConditionalExpression(
                                condition,
                                whenTrue,
                                whenFalse);
                        }
                    }
                    case Ts.TsTypes.SyntaxKind.ElementAccessExpression:
                    {
                        var n = node.AsType<Ts.TsTypes.ElementAccessExpression>();
                        var argExp = SyntaxFactory.Argument(GenerateCSharpAst(n.ArgumentExpression).AsType<ExpressionSyntax>());
                        return SyntaxFactory.ElementAccessExpression(SyntaxFactory.IdentifierName(n.IdentifierStr))
                            .WithArgumentList(SyntaxFactory.BracketedArgumentList(SyntaxFactory.SeparatedList<ArgumentSyntax>(new ArgumentSyntax[]{ argExp })));
                    }
                    case Ts.TsTypes.SyntaxKind.ExportAssignment:
                    {
                        var n = node.AsType<Ts.TsTypes.ExportAssignment>();
                        SyntaxToken[] tokens = _options.UseStaticMethod
                            ? [SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword)]
                            : [SyntaxFactory.Token(SyntaxKind.PublicKeyword)];
                        var methodDeclaration = SyntaxFactory
                            .MethodDeclaration(SyntaxFactory.ParseTypeName(_options.DefaultReturnType), _options.DefaultExportMethodName)
                            .AddModifiers(tokens);
                        var exp = GenerateCSharpAst(n.Expression, new NodeContext() { UseLambda = true }).AsType<ExpressionSyntax>();
                        return methodDeclaration.WithBody(SyntaxFactory.Block(SyntaxFactory.ReturnStatement(exp)));
                    }
                    case Ts.TsTypes.SyntaxKind.FalseKeyword:
                    {
                        return SyntaxFactory.LiteralExpression(
                            SyntaxKind.FalseLiteralExpression);
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
                    case Ts.TsTypes.SyntaxKind.IntersectionType:
                    {
                        var n = node.AsType<Ts.TsTypes.IntersectionTypeNode>();
                        var types = n.Types.Where(x => x.Kind != Ts.TsTypes.SyntaxKind.TypeLiteral)
                            .Select(x => (SyntaxNodeOrToken)GenerateCSharpAst(x).AsT0)
                            .Separate(SyntaxFactory.Token(SyntaxKind.CommaToken)).ToList();
                        return types;
                    }
                    case Ts.TsTypes.SyntaxKind.NewExpression:
                    {
                        var n = node.AsType<Ts.TsTypes.NewExpression>();
                        var args = n.Arguments
                            .Select(x => (SyntaxNodeOrToken)SyntaxFactory.Argument(GenerateCSharpAst(x).AsType<ExpressionSyntax>()))
                            .Separate(SyntaxFactory.Token(SyntaxKind.CommaToken));

                        return SyntaxFactory.ObjectCreationExpression(SyntaxFactory.IdentifierName(n.IdentifierStr))
                            .WithArgumentList(SyntaxFactory.ArgumentList(SyntaxFactory.SeparatedList<ArgumentSyntax>(args)));
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
                        if (context is { ConditionalToken: not null })
                        {
                            return SyntaxFactory.ConditionalAccessExpression(
                                SyntaxFactory.IdentifierName(context.ConditionalToken),
                                SyntaxFactory.MemberBindingExpression(
                                    SyntaxFactory.IdentifierName(n.Name.GetText())));
                        }
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
                            .PropertyDeclaration(GetType(n.Type), Format(n.IdentifierStr))
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
                        SyntaxToken[] tokens = _options.UsePartialClass
                            ? [SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.PartialKeyword)]
                            : [SyntaxFactory.Token(SyntaxKind.PublicKeyword)];
                        return SyntaxFactory.ClassDeclaration(Format(_options.DefaultClassName)).AddModifiers(tokens);
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
                    case Ts.TsTypes.SyntaxKind.TypeAliasDeclaration:
                    {
                        var n = node.AsType<Ts.TsTypes.TypeAliasDeclaration>();
                        var classDeclaration = SyntaxFactory.ClassDeclaration(Format(n.IdentifierStr)).AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword));
                        if (n.Type.Kind == Ts.TsTypes.SyntaxKind.UnionType)
                        {
                            // todo: how to handle UnionType
                            return default;
                        }
                        if (n.Type.Kind == Ts.TsTypes.SyntaxKind.TypeLiteral)
                        {
                            // add members
                            var members = GenerateCSharpAst(n.Type).AsT1;
                            foreach (var member in members)
                            {
                                classDeclaration = classDeclaration.AddMembers(member.AsType<MemberDeclarationSyntax>());
                            }
                        }
                        else
                        {
                            // add base class
                            var r = GenerateCSharpAst(n.Type);
                            var baseClasses = new List<SyntaxNodeOrToken>();
                            if (r.IsT2)
                            {
                                baseClasses = r.AsT2;
                            }
                            else
                            {
                                baseClasses.Add(r.AsT0);
                            }

                            if (baseClasses is { Count: > 0 })
                            {
                                classDeclaration = classDeclaration.WithBaseList
                                (
                                    SyntaxFactory.BaseList(SyntaxFactory.SeparatedList<BaseTypeSyntax>(baseClasses))
                                );
                            }
                        }
                        return classDeclaration;
                    }
                    case Ts.TsTypes.SyntaxKind.TypeLiteral:
                    {
                        var n = node.AsType<Ts.TsTypes.TypeLiteralNode>();
                        return n.Members.Select(x => GenerateCSharpAst(x).AsT0).ToList();
                    }
                    case Ts.TsTypes.SyntaxKind.TypeReference:
                    {
                        var n = node.AsType<Ts.TsTypes.TypeReferenceNode>();
                        if (n.TypeArguments is { Count: > 0 })
                        {
                            var args = n.TypeArguments
                                .Select(x => (SyntaxNodeOrToken)SyntaxFactory.IdentifierName(x.GetText().Purify()))
                                .Separate(SyntaxFactory.Token(SyntaxKind.CommaToken));

                            return SyntaxFactory.SimpleBaseType(SyntaxFactory
                                .GenericName(n.IdentifierStr)
                                .WithTypeArgumentList(
                                    SyntaxFactory.TypeArgumentList(SyntaxFactory.SeparatedList<TypeSyntax>(args))));
                        }
                        else
                        {
                            return SyntaxFactory.SimpleBaseType(
                                SyntaxFactory.IdentifierName(n.IdentifierStr));
                        }
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
                        if (declaration.Initializer.Kind == Ts.TsTypes.SyntaxKind.Identifier && declaration.Name.Kind != Ts.TsTypes.SyntaxKind.Identifier)
                        {
                            var initializer = declaration.Initializer?.GetText() ?? string.Empty;
                            return GenerateCSharpAst(declaration.Name, new NodeContext
                            {
                                Initializer = initializer
                            });
                        }
                        else if (declaration.Initializer.Kind == Ts.TsTypes.SyntaxKind.ArrowFunction)
                        {
                            var funcName = declaration.Name.GetText();
                            return GenerateCSharpAst(declaration.Initializer, new NodeContext { FuncName = funcName });
                        }
                        else
                        {
                            var name = declaration.Name.GetText();
                            var variableDeclaration = SyntaxFactory.VariableDeclaration(
                                    SyntaxFactory.IdentifierName(_options.DefaultFieldType))
                                .WithVariables(SyntaxFactory.SingletonSeparatedList(
                                    SyntaxFactory.VariableDeclarator(SyntaxFactory.Identifier(name))));
                            var expression = GenerateCSharpAst(declaration.Initializer).AsType<ExpressionSyntax>();
                            var equalsValueClause = SyntaxFactory.EqualsValueClause(expression);
                            return SyntaxFactory.FieldDeclaration(variableDeclaration.WithVariables(
                                SyntaxFactory.SingletonSeparatedList(
                                    SyntaxFactory.VariableDeclarator(SyntaxFactory.Identifier(name))
                                        .WithInitializer(equalsValueClause)))).WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword)));
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
                case Ts.TsTypes.SyntaxKind.BarBarToken:
                    return SyntaxKind.CoalesceExpression;
                case Ts.TsTypes.SyntaxKind.EqualsEqualsToken:
                case Ts.TsTypes.SyntaxKind.EqualsEqualsEqualsToken:
                    return SyntaxKind.EqualsExpression;
                case Ts.TsTypes.SyntaxKind.MinusToken:
                    return SyntaxKind.SubtractExpression;
                case Ts.TsTypes.SyntaxKind.PlusToken:
                    return SyntaxKind.AddExpression;
                case Ts.TsTypes.SyntaxKind.SlashToken:
                    return SyntaxKind.DivideExpression;
                default:
                    throw new Exception("Typescript SyntaxKind map error.");
            }
        }

        private TypeSyntax GetType(Ts.TsTypes.INode node)
        {
            switch (node.Kind)
            {
                case Ts.TsTypes.SyntaxKind.NumberKeyword:
                    return SyntaxFactory.ParseTypeName("double");
                case Ts.TsTypes.SyntaxKind.StringKeyword:
                    return SyntaxFactory.ParseTypeName("double");
                default:
                    return SyntaxFactory.ParseTypeName("object");
            }
        }

        private string Format(string text)
        {
            if (_options.UsePascalCase)
            {
                return text.ToPascalCase();
            }

            return text;
        }

        private static int GetLineNumber(string text, int index)
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
        public bool UseLambda { get; set; }
        public string? ConditionalToken { get; set; }
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
