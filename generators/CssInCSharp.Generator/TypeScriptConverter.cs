using CssInCSharp.Generator.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Text.RegularExpressions;
using Ts = Zu.TypeScript;

namespace CssInCSharp.Generator
{
    public class TypeScriptConverter : IConverter
    {
        private readonly CSharpOptions _options;

        public TypeScriptConverter(CSharpOptions? options = null)
        {
            _options = options ?? new CSharpOptions();
        }

        public string Convert(string content, string fileName)
        {
            var tsAst = new Ts.TypeScriptAST(content, fileName);
            var csAst = Generate(tsAst.RootNode);
            var code = csAst.NormalizeWhitespace().ToFullString();
            return _options.Replace(code);
        }

        private CompilationUnitSyntax Generate(Ts.TsTypes.INode node)
        {
            // usings
            var usings = SyntaxFactory.List<UsingDirectiveSyntax>(_options.Usings.Select(GenerateUsing));

            // namespace
            var @namespace = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(_options.Namespace));

            // members
            var members = GenerateMemberDeclaration(node);
            @namespace = @namespace.AddMembers(members);

            return SyntaxFactory.CompilationUnit()
                .WithUsings(usings)
                .AddMembers(@namespace);
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
                        var returnType = n.Type?.GetText() ?? InferReturnType(n, funcName);
                        var statements = new List<StatementSyntax>();
                        var bindingCounter = 0;
                        var parameters = n.Parameters.Select(x =>
                        {
                            LiteralExpressionSyntax? initializer = null;
                            string? defaultValue = null;
                            // todo: csharp does not support variable as default value
                            if (x.Initializer != null && x.Initializer.Kind != Ts.TsTypes.SyntaxKind.Identifier)
                            {
                                initializer = GenerateCSharpAst(x.Initializer).AsType<LiteralExpressionSyntax>();
                                defaultValue = initializer.GetText().ToString();
                            }

                            string pName;
                            /*
                             * ObjectBinding
                             * ts:
                             * function Func(p1, { p2, p3 }) {
                             * }
                             * c#
                             * void Func(object p1, object binding)
                             * {
                             *    var p2 = binding.p2;
                             *    var p3 = binding.p3;
                             * }
                             */
                            if (x.Name.Kind == Ts.TsTypes.SyntaxKind.ObjectBindingPattern)
                            {
                                pName = $"binding{bindingCounter}";
                                statements.AddRange(GenerateCSharpAst(x.Name, new NodeContext { Initializer = pName }).AsT1.Cast<StatementSyntax>());
                                bindingCounter++;
                            }
                            else
                            {
                                pName = x.Name.GetText();
                            }

                            TypeSyntax pType;
                            if (x.Type != null)
                            {
                                var type = GetType(x.Type);
                                if (type == _options.DefaultParameterType)
                                {
                                    type = InferParameterType(x, funcName, pName, defaultValue);
                                }

                                pType = SyntaxFactory.ParseTypeName(type);
                            }
                            else
                            {
                                pType = SyntaxFactory.ParseTypeName(InferParameterType(x, funcName, pName, defaultValue));
                            }

                            var parameter = SyntaxFactory.Parameter(SyntaxFactory.Identifier(pName))
                                .WithType(pType);
                            if (initializer != null)
                            {
                                parameter = parameter.WithDefault(SyntaxFactory.EqualsValueClause(initializer));
                            }

                            return parameter;
                        }).ToArray();

                        var funcBody = n.Body;
                        switch (funcBody.Kind)
                        {
                            case Ts.TsTypes.SyntaxKind.Block:
                            {
                                var statement = GenerateCSharpAst(funcBody, new NodeContext() { ReturnType = returnType }).AsT1.Cast<StatementSyntax>();
                                statements.AddRange(statement);
                                break;
                            }
                            case Ts.TsTypes.SyntaxKind.ParenthesizedExpression:
                            {
                                var expression = funcBody.AsType<Ts.TsTypes.ParenthesizedExpression>();
                                var statement = GenerateCSharpAst(expression.Expression, new NodeContext() { ReturnType = returnType }).AsType<ExpressionSyntax>();
                                statements.Add(SyntaxFactory.ReturnStatement(statement));
                                break;
                            }
                            default:
                            {
                                var statement = GenerateCSharpAst(funcBody, new NodeContext() { ReturnType = returnType }).AsType<ExpressionSyntax>();
                                statements.Add(SyntaxFactory.ReturnStatement(statement));
                                break;
                            }
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
                        var elements = n.Elements
                            .Where(x => x.Kind != Ts.TsTypes.SyntaxKind.SpreadElement) // remove SpreadElement
                            .Select(x => (SyntaxNodeOrToken)GenerateCSharpAst(x).AsT0)
                            .Separate(SyntaxFactory.Token(SyntaxKind.CommaToken));

                        var type = context is { ReturnType: not null } ? context.ReturnType : InferArrayType(n);
                        var arrayType = SyntaxFactory.ArrayType(SyntaxFactory.IdentifierName(type))
                            .WithRankSpecifiers(
                                SyntaxFactory.SingletonList<ArrayRankSpecifierSyntax>(
                                    SyntaxFactory.ArrayRankSpecifier(
                                        SyntaxFactory.SingletonSeparatedList<ExpressionSyntax>(
                                            SyntaxFactory.OmittedArraySizeExpression()))));

                        var arrayCreation = SyntaxFactory.ArrayCreationExpression(arrayType)
                            .WithInitializer
                            (
                                SyntaxFactory.InitializerExpression(SyntaxKind.ArrayInitializerExpression, SyntaxFactory.SeparatedList<ExpressionSyntax>(elements))
                            );

                        /*
                         * typescript
                         * var arr = [
                         *    {  },
                         *    ...anotherArray
                         * ];
                         * c#
                         * var arr = new object[] {
                         *    new {}
                         * }.Union(anotherArray).ToArray();
                         */
                        ExpressionSyntax chain = arrayCreation;
                        var toArray = false;
                        foreach (var element in n.Elements.Where(x => x.Kind == Ts.TsTypes.SyntaxKind.SpreadElement))
                        {
                            toArray = true;
                            var el = element.AsType<Ts.TsTypes.SpreadElement>();
                            chain = SyntaxFactory.InvocationExpression(
                                SyntaxFactory.MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    chain,
                                    SyntaxFactory.IdentifierName("Union")
                                )
                            ).WithArgumentList(
                                SyntaxFactory.ArgumentList(
                                    SyntaxFactory.SingletonSeparatedList(
                                        SyntaxFactory.Argument(SyntaxFactory.IdentifierName(el.IdentifierStr))
                                    )
                                )
                            );
                        }

                        if (toArray)
                        {
                            return SyntaxFactory.InvocationExpression(
                                SyntaxFactory.MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    chain,
                                    SyntaxFactory.IdentifierName("ToArray")
                                )
                            );
                        }

                        return arrayCreation;
                    }
                    case Ts.TsTypes.SyntaxKind.AsExpression:
                    {
                        var n = node.AsType<Ts.TsTypes.AsExpression>();
                        var variable = GenerateCSharpAst(n.Expression).AsType<ExpressionSyntax>();
                        if (n.Type.Kind == Ts.TsTypes.SyntaxKind.TypeReference)
                        {
                            var typeNode = n.Type.AsType<Ts.TsTypes.TypeReferenceNode>();
                            if (typeNode.TypeName.Kind == Ts.TsTypes.SyntaxKind.MissingDeclaration)
                            {
                                return variable;
                            }
                        }

                        var type = GetType(n.Type);
                        if (type == "double")
                        {
                            return SyntaxFactory.InvocationExpression(
                                SyntaxFactory.MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    SyntaxFactory.IdentifierName("Convert"),
                                    SyntaxFactory.IdentifierName("ToDouble")
                                )
                            ).WithArgumentList(SyntaxFactory.ArgumentList(SyntaxFactory.SingletonSeparatedList(SyntaxFactory.Argument(variable))));
                        }

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
                    case Ts.TsTypes.SyntaxKind.Block:
                    {
                        var n = node.AsType<Ts.TsTypes.Block>();
                        var statements = new List<SyntaxNode>();
                        foreach (var statement in n.Statements)
                        {
                            if (statement.IsUnsupportedStatement()) continue;
                            var r = GenerateCSharpAst(statement, new NodeContext { IsLocalDeclaration = true, ReturnType = context?.ReturnType });
                            if (r.IsT1)
                            {
                                statements.AddRange(r.AsT1);
                            }
                            else if (r.AsT0 != null)
                            {
                                statements.Add(r.AsT0);
                            }
                        }

                        return statements;
                    }
                    case Ts.TsTypes.SyntaxKind.CallExpression:
                    {
                        var n = node.AsType<Ts.TsTypes.CallExpression>();
                        var args = new List<SyntaxNodeOrToken>();
                        foreach (var argument in n.Arguments)
                        {
                            var ctx = new NodeContext() { FuncName = n.IdentifierStr, UseLambda = true };
                            if (argument.Kind == Ts.TsTypes.SyntaxKind.ObjectLiteralExpression)
                            {
                                ctx.ReturnType = InferArgumentType(n);
                            }

                            args.Add(SyntaxFactory.Argument(GenerateCSharpAst(argument, ctx).AsType<ExpressionSyntax>()));
                        }

                        return SyntaxFactory.InvocationExpression
                        (
                            FormatNode(n.Expression).AsType<ExpressionSyntax>(),
                            SyntaxFactory.ArgumentList(SyntaxFactory.SeparatedList<ArgumentSyntax>(args.Separate(SyntaxFactory.Token(SyntaxKind.CommaToken))))
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
                            .WithArgumentList(SyntaxFactory.BracketedArgumentList(SyntaxFactory.SeparatedList<ArgumentSyntax>(new ArgumentSyntax[] { argExp })));
                    }
                    case Ts.TsTypes.SyntaxKind.ExportAssignment:
                    {
                        var n = node.AsType<Ts.TsTypes.ExportAssignment>();
                        SyntaxToken[] tokens = _options.UseStaticMethod
                            ? [SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword)]
                            : [SyntaxFactory.Token(SyntaxKind.PublicKeyword)];
                        var funcName = _options.DefaultExportMethodName;
                        var returnType = InferReturnType(null, funcName);
                        var methodDeclaration = SyntaxFactory
                            .MethodDeclaration(SyntaxFactory.ParseTypeName(returnType), Format(funcName))
                            .AddModifiers(tokens);
                        var exp = GenerateCSharpAst(n.Expression, new NodeContext() { UseLambda = true }).AsType<ExpressionSyntax>();
                        return methodDeclaration.WithBody(SyntaxFactory.Block(SyntaxFactory.ReturnStatement(exp)));
                    }
                    case Ts.TsTypes.SyntaxKind.FalseKeyword:
                    {
                        return SyntaxFactory.LiteralExpression(
                            SyntaxKind.FalseLiteralExpression);
                    }
                    case Ts.TsTypes.SyntaxKind.ForStatement:
                    {
                        var n = node.AsType<Ts.TsTypes.ForStatement>();
                        var initializer = GenerateCSharpAst(n.Initializer).AsType<VariableDeclarationSyntax>();
                        var condition = GenerateCSharpAst(n.Condition).AsType<BinaryExpressionSyntax>();
                        var incrementor = GenerateCSharpAst(n.Incrementor).AsType<PostfixUnaryExpressionSyntax>();
                        var body = SyntaxFactory.Block();
                        return SyntaxFactory.ForStatement(body)
                            .WithDeclaration(initializer)
                            .WithCondition(condition)
                            .WithIncrementors(SyntaxFactory.SingletonSeparatedList<ExpressionSyntax>(incrementor));
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
                        var txt = node.GetText();
                        // todo: filter ts keyword
                        if (txt == "undefined")
                        {
                            return SyntaxFactory.IdentifierName("default");
                        }

                        return SyntaxFactory.IdentifierName(txt);
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
                    case Ts.TsTypes.SyntaxKind.NonNullExpression:
                    {
                        var n = node.AsType<Ts.TsTypes.NonNullExpression>();
                        return SyntaxFactory.PostfixUnaryExpression(
                            SyntaxKind.SuppressNullableWarningExpression,
                            SyntaxFactory.IdentifierName(n.IdentifierStr)
                        );
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
                            var property = Format(item.PropertyName?.GetText() ?? name);
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
                        var objectType = InferObjectType(n, context?.ReturnType);
                        /*
                         * todo: should not use return for property, return type only used for Function return eg:
                         * return {
                         *   a: 'value'
                         * };
                         */
                        var assignments = n.Properties
                            .Where(x => x.IsProperty())
                            .Select(x => (SyntaxNodeOrToken)GenerateCSharpAst(x, new NodeContext { ReturnType = objectType }).AsType<ExpressionSyntax>());
                        if (_options.UseAnonymousType)
                        {
                            return SyntaxFactory.AnonymousObjectCreationExpression()
                                .WithInitializers
                                (
                                    SyntaxFactory.SeparatedList(assignments.Select(x => SyntaxFactory.AnonymousObjectMemberDeclarator(x.AsNode().AsType<ExpressionSyntax>())))
                                );
                        }

                        return SyntaxFactory
                            .ObjectCreationExpression(SyntaxFactory.IdentifierName(objectType))
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
                    case Ts.TsTypes.SyntaxKind.PostfixUnaryExpression:
                    {
                        var n = node.AsType<Ts.TsTypes.PostfixUnaryExpression>();
                        return SyntaxFactory.PostfixUnaryExpression(
                            GenerateOperatorToken(n.Operator),
                            SyntaxFactory.IdentifierName(n.IdentifierStr));
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
                                    SyntaxFactory.IdentifierName(Format(n.Name.GetText()))));
                        }

                        var expression = GenerateCSharpAst(n.Expression).AsType<ExpressionSyntax>();
                        return SyntaxFactory.MemberAccessExpression
                        (
                            SyntaxKind.SimpleMemberAccessExpression,
                            expression,
                            SyntaxFactory.IdentifierName(Format(n.Name.GetText()))
                        );
                    }
                    case Ts.TsTypes.SyntaxKind.PropertyAssignment:
                    {
                        var n = node.AsType<Ts.TsTypes.PropertyAssignment>();
                        var initializer = n.Initializer;
                        ExpressionSyntax left;
                        if (n.Name.IsHtmlTag())
                        {
                            left = SyntaxFactory.ElementAccessExpression(SyntaxFactory.IdentifierName(""))
                                .WithArgumentList(
                                    SyntaxFactory.BracketedArgumentList(
                                        SyntaxFactory.SingletonSeparatedList(
                                            SyntaxFactory.Argument(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(n.Name.GetText()))))));
                        }
                        else
                        {
                            left = FormatNode(n.Name).AsType<ExpressionSyntax>();
                            if (n.Name.IsIndexerProperty())
                            {
                                left = SyntaxFactory.ElementAccessExpression(SyntaxFactory.IdentifierName(""))
                                    .WithArgumentList(
                                        SyntaxFactory.BracketedArgumentList(
                                            SyntaxFactory.SingletonSeparatedList(
                                                SyntaxFactory.Argument(left))));
                            }
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
                        var type = InferPropertyType(n);
                        return SyntaxFactory
                            .PropertyDeclaration(SyntaxFactory.ParseTypeName(type), Format(n.IdentifierStr))
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
                    case Ts.TsTypes.SyntaxKind.ReturnStatement:
                    {
                        var n = node.AsType<Ts.TsTypes.ReturnStatement>();
                        return SyntaxFactory.ReturnStatement(GenerateCSharpAst(n.Expression, context).AsType<ExpressionSyntax>());
                    }
                    case Ts.TsTypes.SyntaxKind.ShorthandPropertyAssignment:
                    {
                        var n = node.AsType<Ts.TsTypes.ShorthandPropertyAssignment>();
                        var left = FormatNode(n.Name).AsType<ExpressionSyntax>();
                        var right = SyntaxFactory.IdentifierName(n.Name.GetText());
                        return SyntaxFactory.AssignmentExpression
                        (
                            SyntaxKind.SimpleAssignmentExpression,
                            left,
                            right
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
                    case Ts.TsTypes.SyntaxKind.SourceFile:
                    {
                        SyntaxToken[] tokens = _options.UsePartialClass
                            ? [SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.PartialKeyword)]
                            : [SyntaxFactory.Token(SyntaxKind.PublicKeyword)];
                        return SyntaxFactory.ClassDeclaration(Format(_options.DefaultExportClassName)).AddModifiers(tokens);
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
                            if (span.Expression.Kind == Ts.TsTypes.SyntaxKind.ConditionalExpression)
                            {
                                /*
                                 * typescript:
                                 * const str = `${true ? '123' : 'qwe'}`;
                                 * csharp:
                                 * var str = $"{(true ? "123" : "qwe")}";
                                 */
                                expression = SyntaxFactory.ParenthesizedExpression(expression);
                            }

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
                            SyntaxFactory.Token(SyntaxKind.InterpolatedVerbatimStringStartToken),
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
                        switch (n.Type.Kind)
                        {
                            case Ts.TsTypes.SyntaxKind.UnionType:
                            {
                                return default;
                            }
                            case Ts.TsTypes.SyntaxKind.TypeLiteral:
                            {
                                var members = GenerateCSharpAst(n.Type).AsT1;
                                foreach (var member in members)
                                {
                                    classDeclaration = classDeclaration.AddMembers(member.AsType<MemberDeclarationSyntax>());
                                }

                                return classDeclaration;
                            }
                            case Ts.TsTypes.SyntaxKind.IntersectionType:
                            {
                                var inter = n.Type.AsType<Ts.TsTypes.IntersectionTypeNode>();
                                var type = inter.Types.FirstOrDefault(x => x.Kind == Ts.TsTypes.SyntaxKind.TypeLiteral);
                                if (type != null)
                                {
                                    var members = GenerateCSharpAst(type).AsT1;
                                    foreach (var member in members)
                                    {
                                        classDeclaration = classDeclaration.AddMembers(member.AsType<MemberDeclarationSyntax>());
                                    }
                                }

                                goto default;
                            }
                            default:
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

                                return classDeclaration;
                        }
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
                    case Ts.TsTypes.SyntaxKind.VariableDeclaration:
                    {
                        var n = node.AsType<Ts.TsTypes.VariableDeclaration>();
                        var c = new NodeContext() { UseLambda = true };
                        if (n.Type is { Kind: Ts.TsTypes.SyntaxKind.TypeReference })
                        {
                            c.ReturnType = n.Type.AsType<Ts.TsTypes.TypeReferenceNode>().IdentifierStr;
                        }

                        var identifier = GenerateCSharpAst(n.Initializer, c).AsType<ExpressionSyntax>();
                        return SyntaxFactory
                            .VariableDeclaration(SyntaxFactory.IdentifierName("var"))
                            .AddVariables
                            (
                                SyntaxFactory.VariableDeclarator(SyntaxFactory.Identifier(n.IdentifierStr)).WithInitializer(SyntaxFactory.EqualsValueClause(identifier))
                            );
                    }
                    case Ts.TsTypes.SyntaxKind.VariableDeclarationList:
                    {
                        var n = node.AsType<Ts.TsTypes.VariableDeclarationList>();
                        var variables = n.Declarations.Select(x =>
                        {
                            var identifier = GenerateCSharpAst(x.Initializer).AsType<ExpressionSyntax>();
                            return SyntaxFactory.VariableDeclarator(SyntaxFactory.Identifier(x.IdentifierStr)).WithInitializer(SyntaxFactory.EqualsValueClause(identifier));
                        });
                        return SyntaxFactory
                            .VariableDeclaration(SyntaxFactory.IdentifierName("var"))
                            .WithVariables(SyntaxFactory.SeparatedList(variables));
                    }
                    case Ts.TsTypes.SyntaxKind.VariableStatement:
                    {
                        var n = node.AsType<Ts.TsTypes.VariableStatement>();
                        // todo: ast parser error, it should not be empty.
                        if (n.DeclarationList.Declarations.Count <= 0) return default;
                        var declaration = n.DeclarationList.Declarations[0];
                        if (context is { IsLocalDeclaration: true })
                        {
                            if (declaration.Name.Kind == Ts.TsTypes.SyntaxKind.ObjectBindingPattern)
                            {
                                var initializer = declaration.Initializer?.GetText() ?? string.Empty;
                                return GenerateCSharpAst(declaration.Name, new NodeContext()
                                {
                                    Initializer = initializer
                                });
                            }

                            return SyntaxFactory.LocalDeclarationStatement(GenerateCSharpAst(declaration).AsType<VariableDeclarationSyntax>());
                        }

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
                            return GenerateCSharpAst(declaration.Initializer, new NodeContext
                            {
                                FuncName = funcName
                            });
                        }
                        else
                        {
                            var name = declaration.Name.GetText();
                            var type = InferVariableType(declaration);
                            var variableDeclaration = SyntaxFactory
                                .VariableDeclaration(SyntaxFactory.IdentifierName(type))
                                .WithVariables(SyntaxFactory.SingletonSeparatedList(SyntaxFactory.VariableDeclarator(SyntaxFactory.Identifier(name))));
                            var expression = GenerateCSharpAst(declaration.Initializer).AsType<ExpressionSyntax>();
                            var equalsValueClause = SyntaxFactory.EqualsValueClause(expression);
                            SyntaxToken[] tokens = _options.UseStaticMethod
                                ? [SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword)]
                                : [SyntaxFactory.Token(SyntaxKind.PublicKeyword)];
                            return SyntaxFactory.FieldDeclaration
                                (
                                    variableDeclaration.WithVariables
                                    (
                                        SyntaxFactory.SingletonSeparatedList(SyntaxFactory.VariableDeclarator(SyntaxFactory.Identifier(name))
                                            .WithInitializer(equalsValueClause))
                                    )
                                )
                                .WithModifiers(SyntaxFactory.TokenList(tokens));
                        }
                    }
                    default: return default;
                }
            }
            catch (TypeInferenceException)
            {
                throw;
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
                var len = n.End.Value - n.NodeStart;
                var code = n.SourceStr.Substring(n.NodeStart, len);
                throw new AstGenerateException(start, end, code);
            }
        }

        private SyntaxKind GenerateOperatorToken(Ts.TsTypes.SyntaxKind node)
        {
            switch (node)
            {
                case Ts.TsTypes.SyntaxKind.MinusMinusToken:
                    return SyntaxKind.PostDecrementExpression;
                case Ts.TsTypes.SyntaxKind.PlusPlusToken:
                    return SyntaxKind.PostIncrementExpression;
                default:
                    throw new Exception("Typescript SyntaxKind map error.");
            }
        }

        private SyntaxKind GenerateOperatorToken(Ts.TsTypes.INode node)
        {
            switch (node.Kind)
            {
                case Ts.TsTypes.SyntaxKind.AmpersandAmpersandToken:
                    return SyntaxKind.LogicalAndExpression;
                case Ts.TsTypes.SyntaxKind.AsteriskToken:
                    return SyntaxKind.MultiplyExpression;
                case Ts.TsTypes.SyntaxKind.BarBarToken:
                    return SyntaxKind.CoalesceExpression;
                case Ts.TsTypes.SyntaxKind.EqualsEqualsToken:
                case Ts.TsTypes.SyntaxKind.EqualsEqualsEqualsToken:
                    return SyntaxKind.EqualsExpression;
                case Ts.TsTypes.SyntaxKind.GreaterThanToken:
                    return SyntaxKind.GreaterThanExpression;
                case Ts.TsTypes.SyntaxKind.GreaterThanEqualsToken:
                    return SyntaxKind.GreaterThanOrEqualExpression;
                case Ts.TsTypes.SyntaxKind.LessThanToken:
                    return SyntaxKind.LessThanExpression;
                case Ts.TsTypes.SyntaxKind.LessThanEqualsToken:
                    return SyntaxKind.LessThanOrEqualExpression;
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

        private SyntaxNodeOrList FormatNode(Ts.TsTypes.INode node)
        {
            if (node.Kind == Ts.TsTypes.SyntaxKind.Identifier)
            {
                return SyntaxFactory.IdentifierName(Format(node.GetText()));
            }

            return GenerateCSharpAst(node);
        }

        private string GetType(Ts.TsTypes.INode node)
        {
            switch (node.Kind)
            {
                case Ts.TsTypes.SyntaxKind.BooleanKeyword:
                    return "bool";
                case Ts.TsTypes.SyntaxKind.NumberKeyword:
                    return "double";
                case Ts.TsTypes.SyntaxKind.StringKeyword:
                    return "string";
                case Ts.TsTypes.SyntaxKind.IndexedAccessType:
                {
                    /*
                     * typescript:
                     * interface A {
                     *  defaultPadding: CSSProperties['padding']
                     * }
                     */
                    var type = node.AsType<Ts.TsTypes.IndexedAccessTypeNode>();
                    var objectType = type.ObjectType.GetText();
                    var indexType = type.IndexType.GetText();
                    var token = new IndexedAccessType(_options, objectType, indexType);
                    return InferenceEngine.Infer(token, objectType);
                }
                case Ts.TsTypes.SyntaxKind.UnionType:
                {
                    var unionType = node.AsType<Ts.TsTypes.UnionTypeNode>();
                    // if type is 'a' | 'b' or 1 | 2
                    if (unionType.Types.All(x => x.Kind == Ts.TsTypes.SyntaxKind.LiteralType))
                    {
                        var t = unionType.Types.First().AsType<Ts.TsTypes.LiteralTypeNode>();
                        switch (t.Literal.Kind)
                        {
                            case Ts.TsTypes.SyntaxKind.StringLiteral:
                                return "string";
                            case Ts.TsTypes.SyntaxKind.NumericLiteral:
                                return "double";
                        }
                    }
                    // todo: eg: string | number | bool | object
                    var types = unionType.Types.Select(x => x.GetText()).ToArray();
                    var token = new UnionType(_options, types);
                    return InferenceEngine.Infer(token, _options.DefaultObjectType);
                }
                default:
                {
                    return node.GetText();
                }
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

        private string InferObjectType(Ts.TsTypes.ObjectLiteralExpression node, string? defaultType = null)
        {
            var token = new ObjectType(_options);
            if (node.Properties != null)
            {
                var properties = node.Properties.Where(x => x.Kind == Ts.TsTypes.SyntaxKind.PropertyAssignment).Select(x => x.AsType<Ts.TsTypes.PropertyAssignment>());
                token.Properties = properties
                    .Where(x => !x.Name.IsIndexerProperty())
                    .Select(x => x.Name.GetText()).ToArray();
                if (token.Properties.Length <= 0) token.Properties = null;
                if (properties.Any(x => x.Name.IsIndexerProperty()))
                {
                    token.HasIndexer = true;
                }
                else if(node.Properties.Any(x => x.Kind == Ts.TsTypes.SyntaxKind.SpreadAssignment))
                {
                    token.HasIndexer = true;
                }
            }

            return InferenceEngine.Infer(token, defaultType ?? _options.DefaultObjectType);
        }

        private string InferReturnType(Ts.TsTypes.ArrowFunction? node, string funcName)
        {
            if (node == null)
            {
                var token = new ReturnType(_options, funcName);
                return InferenceEngine.Infer(token, _options.DefaultReturnType);
            }
            else
            {
                string? valueType = null;
                Ts.TsTypes.INode? returnValue = null;
                if (node.Body.Kind == Ts.TsTypes.SyntaxKind.Block)
                {
                    var statement = node.Body.AsType<Ts.TsTypes.Block>().Statements
                        .Where(x => x.Kind == Ts.TsTypes.SyntaxKind.ReturnStatement)
                        .Select(x => x.AsType<Ts.TsTypes.ReturnStatement>())
                        .FirstOrDefault();

                    if (statement is { Expression.Kind: Ts.TsTypes.SyntaxKind.ObjectLiteralExpression })
                    {
                        returnValue = statement.Expression;
                        valueType = "object";
                    }

                    if (statement is { Expression.Kind: Ts.TsTypes.SyntaxKind.ArrayLiteralExpression })
                    {
                        valueType = "array";
                    }
                }
                
                if (node.Body.Kind == Ts.TsTypes.SyntaxKind.ParenthesizedExpression)
                {
                    var exp = node.Body.AsType<Ts.TsTypes.ParenthesizedExpression>().Expression;
                    if (exp.Kind == Ts.TsTypes.SyntaxKind.ObjectLiteralExpression)
                    {
                        returnValue = exp;
                        valueType = "object";
                    }
                }

                if (node.Body.Kind == Ts.TsTypes.SyntaxKind.ArrayLiteralExpression)
                {
                    valueType = "array";
                }

                var token = new ReturnType(_options, funcName, valueType);
                var returnType = InferenceEngine.Infer(token, _options.DefaultReturnType);
                if (returnType != _options.DefaultReturnType)
                {
                    return returnType;
                }

                if (returnValue == null)
                {
                    return _options.DefaultReturnType;
                }
                else
                {
                    switch (valueType)
                    {
                        case "object":
                            return InferObjectType(returnValue.AsType<Ts.TsTypes.ObjectLiteralExpression>());
                    }
                }

                return _options.DefaultReturnType;
            }
        }

        private string InferParameterType(Ts.TsTypes.ParameterDeclaration node, string funcName, string name, string? defaultValue)
        {
            // try parse default value
            if (defaultValue != null)
            {
                if (double.TryParse(defaultValue, out _))
                {
                    return "double";
                }

                if (bool.TryParse(defaultValue, out _))
                {
                    return "bool";
                }

                if (Regex.IsMatch(defaultValue, @"^""\w*""$"))
                {
                    return "string";
                }
            }

            var token = new ParameterType(_options, name, funcName, defaultValue);
            return InferenceEngine.Infer(token, _options.DefaultParameterType);
        }

        private string InferPropertyType(Ts.TsTypes.PropertySignature node)
        {
            var token = new PropertyType(_options, node.IdentifierStr);
            if (node.Type.Kind == Ts.TsTypes.SyntaxKind.IndexedAccessType)
            {
                var type = node.Type.AsType<Ts.TsTypes.IndexedAccessTypeNode>();
                var objectType = type.ObjectType.GetText();
                var indexType = type.IndexType.GetText();
                token.IndexedAccessType = new IndexedAccessType(_options, objectType, indexType);
            } 
            else if (node.Type.Kind == Ts.TsTypes.SyntaxKind.UnionType)
            {
                var unionType = node.Type.AsType<Ts.TsTypes.UnionTypeNode>();
                var types = unionType.Types.Select(x => x.GetText()).ToArray();
                token.UnionType = new UnionType(_options, types);
            }

            return InferenceEngine.Infer(token, GetType(node.Type));
        }

        private string InferVariableType(Ts.TsTypes.VariableDeclaration node)
        {
            if (node.Initializer.Kind == Ts.TsTypes.SyntaxKind.NewExpression)
            {
                var exp = node.Initializer.AsType<Ts.TsTypes.NewExpression>().Expression;
                return exp.GetText();
            }
            return _options.DefaultVariableType;
        }

        private string InferArrayType(Ts.TsTypes.ArrayLiteralExpression node)
        {
            var element = node.Elements.FirstOrDefault();
            if (element == null) return "object";

            if (element.Kind == Ts.TsTypes.SyntaxKind.StringLiteral)
            {
                return "string";
            }
            return "object";
        }

        private string InferArgumentType(Ts.TsTypes.CallExpression node)
        {
            // todo: how to parse Type to 
            if (node.TypeArguments is { Count: > 0 })
            {
                var typeArgument = node.TypeArguments[0];
                if (typeArgument.Kind == Ts.TsTypes.SyntaxKind.IntersectionType)
                {
                    var intersectionType = typeArgument.AsType<Ts.TsTypes.IntersectionTypeNode>();
                    if (intersectionType.Types is { Count: > 0 })
                    {
                        var type = intersectionType.Types[0];
                        if (type.Kind == Ts.TsTypes.SyntaxKind.TypeReference)
                        {
                            return type.AsType<Ts.TsTypes.TypeReferenceNode>().IdentifierStr;
                        }
                    }
                }

                if (typeArgument.Kind == Ts.TsTypes.SyntaxKind.TypeReference)
                {
                    return typeArgument.AsType<Ts.TsTypes.TypeReferenceNode>().IdentifierStr;
                }
            }

            return "object";
        }

        private static int GetLineNumber(string text, int index)
        {
            if (index < 0 || index > text.Length)
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of the range of the text.");

            var line = 1;
            for (var i = 0; i < index; i++)
            {
                if (text[i] == '\n')
                    line++;
            }

            return line;
        }
    }

    public class NodeContext
    {
        public string? ReturnType { get; set; }
        public string? Initializer { get; set; }
        public string? FuncName { get; set; }
        public bool UseLambda { get; set; }
        public string? ConditionalToken { get; set; }
        public bool IsLocalDeclaration { get; set; }
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
