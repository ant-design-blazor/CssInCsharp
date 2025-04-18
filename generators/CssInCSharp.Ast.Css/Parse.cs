using System.Text;
using static CssInCSharp.Ast.Css.Util;

namespace CssInCSharp.Ast.Css
{
    public struct UnionList<T0>
    {
        private readonly int _index;
        private readonly T0 _value0;
        private readonly List<T0> _value1;

        private UnionList(
            int index,
            T0 value0 = default,
            List<T0> value1 = default)
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
        }

        public static implicit operator UnionList<T0>(T0 t) => new(0, value0: t);
        public static implicit operator UnionList<T0>(List<T0> t) => new(1, value1: t);

        public bool IsElement => _index == 0;
        public bool IsList => _index == 1;

        public T0 AsT0 => _value0;
        public List<T0> AsT1 => _value1;
    }

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
        public string AsString => _value0;
        public List<Node> AsArray => _value1;
    }

    public class NodeType
    {
        public const string ArgumentsType = "arguments";
        public const string AtkeywordType = "atkeyword";
        public const string AtruleType = "atrule";
        public const string AttributeSelectorType = "attributeSelector";
        public const string AttributeNameType = "attributeName";
        public const string AttributeFlagsType = "attributeFlags";
        public const string AttributeMatchType = "attributeMatch";
        public const string AttributeValueType = "attributeValue";
        public const string BlockType = "block";
        public const string BracketsType = "brackets";
        public const string ClassType = "class";
        public const string CombinatorType = "combinator";
        public const string CommentMLType = "multilineComment";
        public const string CommentSLType = "singlelineComment";
        public const string ConditionType = "condition";
        public const string ConditionalStatementType = "conditionalStatement";
        public const string CustomPropertyType = "customProperty";
        public const string DeclarationType = "declaration";
        public const string DeclDelimType = "declarationDelimiter";
        public const string DefaultType = "default";
        public const string DelimType = "delimiter";
        public const string DimensionType = "dimension";
        public const string EscapedStringType = "escapedString";
        public const string ExtendType = "extend";
        public const string ExpressionType = "expression";
        public const string FunctionType = "function";
        public const string FunctionsListType = "functionsList";
        public const string GlobalType = "global";
        public const string IdentType = "ident";
        public const string ImportantType = "important";
        public const string IncludeType = "include";
        public const string InterpolationType = "interpolation";
        public const string InterpolatedVariableType = "interpolatedVariable";
        public const string KeyframesSelectorType = "keyframesSelector";
        public const string LoopType = "loop";
        public const string MixinType = "mixin";
        public const string NamePrefixType = "namePrefix";
        public const string NamespacePrefixType = "namespacePrefix";
        public const string NamespaceSeparatorType = "namespaceSeparator";
        public const string NumberType = "number";
        public const string OperatorType = "operator";
        public const string OptionalType = "optional";
        public const string ParenthesesType = "parentheses";
        public const string ParentSelectorType = "parentSelector";
        public const string ParentSelectorExtensionType = "parentSelectorExtension";
        public const string PercentageType = "percentage";
        public const string PlaceholderType = "placeholder";
        public const string ProgidType = "progid";
        public const string PropertyType = "property";
        public const string PropertyDelimType = "propertyDelimiter";
        public const string PseudocType = "pseudoClass";
        public const string PseudoeType = "pseudoElement";
        public const string RawType = "raw";
        public const string RulesetType = "ruleset";
        public const string SType = "space";
        public const string SelectorType = "selector";
        public const string ShashType = "id";
        public const string StringType = "string";
        public const string StylesheetType = "stylesheet";
        public const string TypeSelectorType = "typeSelector";
        public const string UnicodeRangeType = "unicodeRange";
        public const string UniversalSelectorType = "universalSelector";
        public const string UriType = "uri";
        public const string UrangeType = "urange";
        public const string ValueType = "value";
        public const string VariableType = "variable";
        public const string VariablesListType = "variablesList";
        public const string VhashType = "color";
    }

    public class TokenType
    {
        public const string StringSQ = "StringSQ";
        public const string StringDQ = "StringDQ";
        public const string CommentML = "CommentML";
        public const string CommentSL = "CommentSL";

        public const string Newline = "Newline";
        public const string Space = "Space";
        public const string Tab = "Tab";

        public const string ExclamationMark = "ExclamationMark";         // !
        public const string QuotationMark = "QuotationMark";             // "
        public const string NumberSign = "NumberSign";                   // #
        public const string DollarSign = "DollarSign";                   // $
        public const string PercentSign = "PercentSign";                 // %
        public const string Ampersand = "Ampersand";                     // &
        public const string Apostrophe = "Apostrophe";                   // '
        public const string LeftParenthesis = "LeftParenthesis";         // (
        public const string RightParenthesis = "RightParenthesis";       // )
        public const string Asterisk = "Asterisk";                       // *
        public const string PlusSign = "PlusSign";                       // +
        public const string Comma = "Comma";                             // ,
        public const string HyphenMinus = "HyphenMinus";                 // -
        public const string FullStop = "FullStop";                       // .
        public const string Solidus = "Solidus";                         // /
        public const string Colon = "Colon";                             // :
        public const string Semicolon = "Semicolon";                     // ;
        public const string LessThanSign = "LessThanSign";               // <
        public const string EqualsSign = "EqualsSign";                   // =
        public const string EqualitySign = "EqualitySign";               // ==
        public const string InequalitySign = "InequalitySign";           // !=
        public const string GreaterThanSign = "GreaterThanSign";         // >
        public const string QuestionMark = "QuestionMark";               // ?
        public const string CommercialAt = "CommercialAt";               // @
        public const string LeftSquareBracket = "LeftSquareBracket";     // [
        public const string ReverseSolidus = "ReverseSolidus";           // \
        public const string RightSquareBracket = "RightSquareBracket";   // ]
        public const string CircumflexAccent = "CircumflexAccent";       // ^
        public const string LowLine = "LowLine";                         // _
        public const string LeftCurlyBracket = "LeftCurlyBracket";       // {
        public const string VerticalLine = "VerticalLine";               // |
        public const string RightCurlyBracket = "RightCurlyBracket";     // }
        public const string Tilde = "Tilde";                             // ~

        public const string Identifier = "Identifier";
        public const string DecimalNumber = "DecimalNumber";
    }

    public struct Position
    {
        public int line;
        public int column;
    }

    public class NodeOptions
    {
        public string type { get; set; }
        public Content content { get; set; }
        public Position start { get; set; }
        public Position end { get; set; }
        public string syntax { get; set; }
    }

    public class Node
    {
        public Content content { get; set; }
        public Position? end { get; set; }

        public Node(NodeOptions options)
        {

        }
    }

    public class Token
    {
        public int tn;
        public int ln;
        public int col;
        public string type;
        public string value;
        public int stylesheet_child;
        public int sc_child;
        public int ws_last;
        public int atrule_type;
        public int selectorsGroupEnd;
        public int selectorsGroupSelectorCount;
        public int selectorsGroupDelimCount;
        public int right;
        public int bd_type;
        public int ws;
        public int? atrule_l;
        public int ident_last;
        public int selectorEnd;
        public int tsets_end;
        public int atrulers_child;
        public int atrulers_end;
        public int compoundSelectorType;
        public int combinatorType;
        public int tset_child;
        public int compoundSelectorEnd;
        public int any_child;
        public int class_l;
        public int classEnd;
        public int attributeSelectorType;
        public int keyframesSelectorType;
        public int number_l;
        public int namePrefixType;
        public int pseudoElementType;
        public int pseudoClassType;
        public int urangeEnd;
        public int attributeMatchType;
        public int bd_kind;
        public int propertyType;
        public int value_end;
        public int value_child;
        public int progid_end;
        public int importantEnd;
        public int argument_child;
    }

    public class Parse
    {
        private int tokensLength;
        private int pos;
        private Token[] tokens;

        public Parse(Token[] tokens, object context)
        {
            this.tokens = tokens;
            tokensLength = tokens.Length;
            pos = 0;
        }

        public void throwError(int i)
        {
            var ln = tokens[i].ln;

            throw new Exception($"line: {ln}, syntax: css");
        }

        public string joinValues(int start, int finish)
        {
            var sb = new StringBuilder();

            for (var i = start; i < finish + 1; i++)
            {
                sb.Append(tokens[i].value);
            }

            return sb.ToString();
        }

        public string joinValues2(int start, int num)
        {
            if (start + num - 1 >= tokensLength) return null;

            var s = new StringBuilder();

            for (var i = 0; i < num; i++)
            {
                s.Append(tokens[start + i].value);
            }

            return s.ToString();
        }

        public int checkSC(int i)
        {
            if (i >= tokensLength) return 0;

            int l;
            int lsc = 0;

            while (i < tokensLength)
            {
                if ((l = checkS(i)).AsBool()) tokens[i].sc_child = 1;
                else if ((l = checkCommentML(i)).AsBool()) tokens[i].sc_child = 2;
                else break;

                i += l;
                lsc += l;
            }

            return lsc;
        }

        public int checkS(int i)
        {
            return i < tokensLength && tokens[i].ws.AsBool() ? tokens[i].ws_last - i + 1 : 0;
        }

        public int checkRuleset(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkSelectorsGroup(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkBlock(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        public int checkAtrule(int i)
        {
            int l;

            if (i >= tokensLength) return 0;

            // If token already has a record of being part of an @-rule,
            // return the @-rule's length:
            if (tokens[i].atrule_l != null) return tokens[i].atrule_l.Value;

            // If token is part of an @-rule, save the rule's type to token.
            // @keyframes:
            if ((l = checkKeyframesRule(i)).AsBool()) tokens[i].atrule_type = 4;
            // @-rule with ruleset:
            else if ((l = checkAtruler(i)).AsBool()) tokens[i].atrule_type = 1;
            // Block @-rule:
            else if ((l = checkAtruleb(i)).AsBool()) tokens[i].atrule_type = 2;
            // Single-line @-rule:
            else if ((l = checkAtrules(i)).AsBool()) tokens[i].atrule_type = 3;
            else return 0;

            // If token is part of an @-rule, save the rule's length to token:
            tokens[i].atrule_l = l;

            return l;
        }

        public int checkDeclDelim(int i)
        {
            return i < tokensLength && tokens[i].type == TokenType.Semicolon ? 1 : 0;
        }

        public int checkCommentML(int i)
        {
            return i < tokensLength && tokens[i].type == TokenType.CommentML ? 1 : 0;
        }

        public int checkSelectorsGroup(int i)
        {
            if (i >= tokensLength) return 0;

            var start = i;
            int l;
            var selectorCounter = 0;
            var delimCounter = 0;

            if ((l = checkSelector(i)).AsBool())
            {
                i += l;
                selectorCounter++;
            }
            else return 0;

            while (i < tokensLength)
            {
                var tempStart = i;
                var tempIndex = i;
                int tempLength;

                var spaceBefore = checkSC(tempIndex);

                if ((tempLength = checkDelim(tempIndex + spaceBefore)).AsBool())
                {
                    tempIndex += spaceBefore + tempLength;
                    delimCounter++;

                    if ((tempLength = checkSC(tempIndex)).AsBool()) tempIndex += tempLength;
                    if ((tempLength = checkSelector(tempIndex)).AsBool())
                    {
                        tempIndex += tempLength;
                        selectorCounter++;
                    }
                }
                else break;

                i += tempIndex - tempStart;
            }

            tokens[start].selectorsGroupEnd = i;
            tokens[start].selectorsGroupSelectorCount = selectorCounter;
            tokens[start].selectorsGroupDelimCount = delimCounter;

            return i - start;
        }

        public int checkBlock(int i)
        {
            return i < tokensLength && tokens[i].type == TokenType.LeftCurlyBracket ?
                tokens[i].right - i + 1 : 0;
        }

        public int checkKeyframesRule(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkAtkeyword(i)).AsBool()) i += l;
            else return 0;

            var atruleName = joinValues2(i - l, l);
            if (atruleName.ToLower().IndexOf("keyframes") == -1) return 0;

            if ((l = checkSC(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkIdent(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkKeyframesBlocks(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        public int checkAtkeyword(int i)
        {
            int l;

            // Check that token is `@`:
            if (i >= tokensLength ||
                tokens[i++].type != TokenType.CommercialAt) return 0;

            return ((l = checkIdent(i)).AsBool()) ? l + 1 : 0;
        }

        public int checkIdent(int i)
        {
            var start = i;

            if (i >= tokensLength) return 0;

            if (tokens[i].type == TokenType.HyphenMinus) i++;

            if (tokens[i].type == TokenType.LowLine ||
                    tokens[i].type == TokenType.Identifier) i++;
            else return 0;

            for (; i < tokensLength; i++)
            {
                if (tokens[i].type != TokenType.HyphenMinus &&
                        tokens[i].type != TokenType.LowLine &&
                        tokens[i].type != TokenType.Identifier &&
                        tokens[i].type != TokenType.DecimalNumber) break;
            }

            tokens[start].ident_last = i - 1;

            return i - start;
        }

        public int checkAtruler(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkAtkeyword(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkTsets(i)).AsBool()) i += l;

            if (i < tokensLength && tokens[i].type == TokenType.LeftCurlyBracket) i++;
            else return 0;

            if ((l = checkAtrulers(i)).AsBool()) i += l;

            if (i < tokensLength && tokens[i].type == TokenType.RightCurlyBracket) i++;
            else return 0;

            return i - start;
        }

        public int checkAtruleb(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkAtkeyword(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkTsets(i)).AsBool()) i += l;

            if ((l = checkBlock(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        public int checkAtrules(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkAtkeyword(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkTsets(i)).AsBool()) i += l;

            return i - start;
        }

        public int checkSelector(int i)
        {
            if (i >= tokensLength) return 0;

            var start = i;
            int l;

            if ((l = checkCompoundSelector(i)).AsBool()) i += l;
            else return 0;

            while (i < tokensLength)
            {
                var spaceBefore = checkSC(i);
                var comma = checkCombinator(i + spaceBefore);
                if (!spaceBefore.AsBool() && !comma.AsBool()) break;

                var spaceAfter = checkSC(i + spaceBefore + comma);
                if ((l = checkCompoundSelector(i + spaceBefore + comma + spaceAfter)).AsBool())
                {
                    i += spaceBefore + comma + spaceAfter + l;
                }
                else break;
            }

            tokens[start].selectorEnd = i;
            return i - start;
        }

        public int checkDelim(int i)
        {
            return i < tokensLength && tokens[i].type == TokenType.Comma ? 1 : 0;
        }

        public int checkKeyframesBlocks(int i)
        {
            var start = i;
            int l;

            if (i < tokensLength && tokens[i].type == TokenType.LeftCurlyBracket) i++;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkKeyframesBlock(i)).AsBool()) i += l;
            else return 0;

            while (tokens[i].type != TokenType.RightCurlyBracket)
            {
                if ((l = checkSC(i)).AsBool()) i += l;
                else if ((l = checkKeyframesBlock(i)).AsBool()) i += l;
                else break;
            }

            if (i < tokensLength && tokens[i].type == TokenType.RightCurlyBracket) i++;
            else return 0;

            return i - start;
        }

        public int checkTsets(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            while ((l = checkTset(i)).AsBool())
            {
                i += l;
            }

            tokens[start].tsets_end = i;
            return i - start;
        }

        public int checkAtrulers(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            while (i < tokensLength)
            {
                if ((l = checkSC(i)).AsBool()) tokens[i].atrulers_child = 1;
                else if ((l = checkAtrule(i)).AsBool()) tokens[i].atrulers_child = 2;
                else if ((l = checkRuleset(i)).AsBool()) tokens[i].atrulers_child = 3;
                else break;
                i += l;
            }

            if (i < tokensLength) tokens[i].atrulers_end = 1;

            if ((l = checkSC(i)).AsBool()) i += l;

            return i - start;
        }

        public int checkCompoundSelector(int i)
        {
            int l;

            if ((l = checkCompoundSelector1(i)).AsBool())
            {
                tokens[i].compoundSelectorType = 1;
            }
            else if ((l = checkCompoundSelector2(i)).AsBool())
            {
                tokens[i].compoundSelectorType = 2;
            }

            return l;
        }

        public int checkCombinator(int i)
        {
            if (i >= tokensLength) return 0;

            int l;
            if ((l = checkCombinator1(i)).AsBool()) tokens[i].combinatorType = 1;
            else if ((l = checkCombinator2(i)).AsBool()) tokens[i].combinatorType = 2;
            else if ((l = checkCombinator3(i)).AsBool()) tokens[i].combinatorType = 3;
            else if ((l = checkCombinator4(i)).AsBool()) tokens[i].combinatorType = 4;

            return l;
        }

        public int checkKeyframesBlock(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkKeyframesSelectorsGroup(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkBlock(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        public int checkTset(int i)
        {
            int l;

            if ((l = checkVhash(i)).AsBool()) tokens[i].tset_child = 1;
            else if ((l = checkAny(i)).AsBool()) tokens[i].tset_child = 2;
            else if ((l = checkSC(i)).AsBool()) tokens[i].tset_child = 3;
            else if ((l = checkOperator(i)).AsBool()) tokens[i].tset_child = 4;

            return l;
        }

        public int checkCompoundSelector1(int i)
        {
            if (i >= tokensLength) return 0;

            var start = i;
            int l;

            if ((l = checkUniversalSelector(i)).AsBool() || (checkTypeSelector(i)).AsBool()) i += l;
            else return 0;

            while (i < tokensLength)
            {
                l = Of(checkShash(i),
                       checkClass(i),
                       checkAttributeSelector(i),
                       checkPseudo(i));
                if (l.AsBool()) i += l;
                else break;
            }

            tokens[start].compoundSelectorEnd = i;

            return i - start;
        }

        public int checkCompoundSelector2(int i)
        {
            if (i >= tokensLength) return 0;

            var start = i;
            int l;

            while (i < tokensLength)
            {
                l = Of(checkShash(i),
                    checkClass(i),
                    checkAttributeSelector(i),
                    checkPseudo(i));

                if (l.AsBool()) i += l;
                else break;
            }

            tokens[start].compoundSelectorEnd = i;

            return i - start;
        }

        public int checkCombinator1(int i)
        {
            if (i < tokensLength && tokens[i++].type == TokenType.GreaterThanSign &&
                    i < tokensLength && tokens[i++].type == TokenType.GreaterThanSign &&
                    i < tokensLength && tokens[i++].type == TokenType.GreaterThanSign)
                return 3;

            return 0;
        }

        public int checkCombinator2(int i)
        {
            if (i + 1 >= tokensLength) return 0;

            if (tokens[i].type == TokenType.VerticalLine &&
                    tokens[i + 1].type == TokenType.VerticalLine) return 2;

            if (tokens[i].type == TokenType.GreaterThanSign &&
                    tokens[i + 1].type == TokenType.GreaterThanSign) return 2;

            return 0;
        }

        public int checkCombinator3(int i)
        {
            var type = tokens[i].type;
            if (type == TokenType.PlusSign ||
                    type == TokenType.GreaterThanSign ||
                    type == TokenType.Tilde) return 1;
            else return 0;
        }

        public int checkCombinator4(int i)
        {
            var start = i;

            if (tokens[i].type == TokenType.Solidus) i++;
            else return 0;

            int l;
            if ((l = checkIdent(i)).AsBool()) i += l;
            else return 0;

            if (tokens[i].type == TokenType.Solidus) i++;
            else return 0;

            return i - start;
        }

        public int checkKeyframesSelectorsGroup(int i)
        {
            var start = i;
            int l;

            if ((l = checkKeyframesSelector(i)).AsBool()) i += l;
            else return 0;

            while (i < tokensLength)
            {
                var spaceBefore = checkSC(i);
                var comma = checkDelim(i + spaceBefore);
                if (!comma.AsBool()) break;

                var spaceAfter = checkSC(i + spaceBefore + comma);
                if ((l = checkKeyframesSelector(i + spaceBefore + comma + spaceAfter)).AsBool())
                {
                    i += spaceBefore + comma + spaceAfter + l;
                }
                else break;
            }

            tokens[start].selectorsGroupEnd = i;

            return i - start;
        }

        public int checkVhash(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            // Skip `#`.
            if (tokens[i].type == TokenType.NumberSign) i++;
            else return 0;

            if ((l = checkNmName2(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        public int checkAny(int i)
        {
            int l;

            if ((l = checkBrackets(i)).AsBool()) tokens[i].any_child = 1;
            else if ((l = checkParentheses(i)).AsBool()) tokens[i].any_child = 2;
            else if ((l = checkString(i)).AsBool()) tokens[i].any_child = 3;
            else if ((l = checkPercentage(i)).AsBool()) tokens[i].any_child = 4;
            else if ((l = checkDimension(i)).AsBool()) tokens[i].any_child = 5;
            else if ((l = checkUnicodeRange(i)).AsBool()) tokens[i].any_child = 13;
            else if ((l = checkNumber(i)).AsBool()) tokens[i].any_child = 6;
            else if ((l = checkUri(i)).AsBool()) tokens[i].any_child = 7;
            else if ((l = checkExpression(i)).AsBool()) tokens[i].any_child = 8;
            else if ((l = checkFunction(i)).AsBool()) tokens[i].any_child = 9;
            else if ((l = checkIdent(i)).AsBool()) tokens[i].any_child = 10;
            else if ((l = checkClass(i)).AsBool()) tokens[i].any_child = 11;
            else if ((l = checkUnary(i)).AsBool()) tokens[i].any_child = 12;

            return l;
        }

        public int checkOperator(int i)
        {
            if (i >= tokensLength) return 0;

            switch (tokens[i].type)
            {
                case TokenType.Solidus:
                case TokenType.Comma:
                case TokenType.Colon:
                case TokenType.EqualsSign:
                case TokenType.Asterisk:
                    return 1;
            }

            return 0;
        }

        public int checkUniversalSelector(int i)
        {
            if (i >= tokensLength) return 0;

            var start = i;
            int l;

            if ((l = checkNamePrefix(i)).AsBool()) i += l;

            if (tokens[i].type == TokenType.Asterisk) i++;
            else return 0;

            return i - start;
        }

        public int checkTypeSelector(int i)
        {
            if (i >= tokensLength) return 0;

            var start = i;
            int l;

            if ((l = checkNamePrefix(i)).AsBool()) i += l;

            if ((l = checkIdent(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        public int checkShash(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if (tokens[i].type == TokenType.NumberSign) i++;
            else return 0;

            if ((l = checkIdent(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        public int checkClass(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if (tokens[i].class_l.AsBool()) return tokens[i].class_l;

            // Skip `.`.
            if (tokens[i].type == TokenType.FullStop) i++;
            else return 0;

            if ((l = checkIdent(i)).AsBool())
            {
                tokens[start].class_l = l + 1;
                i += l;
            }
            else return 0;

            tokens[start].classEnd = i;

            return i - start;
        }

        public int checkAttributeSelector(int i)
        {
            int l;
            if ((l = checkAttributeSelector1(i)).AsBool()) tokens[i].attributeSelectorType = 1;
            else if ((l = checkAttributeSelector2(i)).AsBool()) tokens[i].attributeSelectorType = 2;

            return l;
        }

        public int checkPseudo(int i)
        {
            return Of(checkPseudoe(i),
                checkPseudoc(i));
        }

        public int checkKeyframesSelector(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkIdent(i)).AsBool())
            {
                // Valid selectors are only `from` and `to`.
                var selector = joinValues2(i, l);
                if (selector != "from" && selector != "to") return 0;

                i += l;
                tokens[start].keyframesSelectorType = 1;
            }
            else if ((l = checkPercentage(i)).AsBool())
            {
                i += l;
                tokens[start].keyframesSelectorType = 2;
            }
            else
            {
                return 0;
            }

            return i - start;
        }

        public int checkNmName2(int i)
        {
            if (tokens[i].type == TokenType.Identifier) return 1;
            else if (tokens[i].type != TokenType.DecimalNumber) return 0;

            i++;

            return i < tokensLength && tokens[i].type == TokenType.Identifier ? 2 : 1;
        }

        public int checkBrackets(int i)
        {
            if (i >= tokensLength) return 0;

            var start = i;

            // Skip `[`.
            if (tokens[i].type == TokenType.LeftSquareBracket) i++;
            else return 0;

            if (i < tokens[start].right)
            {
                var l = checkTsets(i);
                if (l.AsBool()) i += l;
                else return 0;
            }

            // Skip `]`.
            i++;

            return i - start;
        }

        public int checkParentheses(int i)
        {
            if (i >= tokensLength) return 0;

            var start = i;
            var right = tokens[i].right;

            // Skip `(`.
            if (tokens[i].type == TokenType.LeftParenthesis) i++;
            else return 0;

            if (i < right)
            {
                var l = checkTsets(i);
                if (l.AsBool()) i += l;
                else return 0;
            }

            // Skip `)`.
            i++;

            return i - start;
        }

        public int checkString(int i)
        {
            if (i >= tokensLength) return 0;

            if (tokens[i].type == TokenType.StringSQ ||
                    tokens[i].type == TokenType.StringDQ)
            {
                return 1;
            }

            return 0;
        }

        public int checkPercentage(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkNumber(i)).AsBool()) i += l;
            else return 0;

            if (i >= tokensLength) return 0;

            // Skip `%`.
            if (tokens[i].type == TokenType.PercentSign) i++;
            else return 0;

            return i - start;
        }

        public int checkDimension(int i)
        {
            var ln = checkNumber(i);
            int li;

            if (i >= tokensLength ||
                !ln.AsBool() ||
                i + ln >= tokensLength) return 0;

            return (li = checkUnit(i + ln)).AsBool() ? ln + li : 0;
        }

        public int checkUnicodeRange(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkUrange(i)).AsBool()) i += l;
            else return 0;

            while (i < tokensLength)
            {
                var spaceBefore = checkSC(i);
                var comma = checkDelim(i + spaceBefore);
                if (!comma.AsBool()) break;

                var spaceAfter = checkSC(i + spaceBefore + comma);
                if ((l = checkUrange(i + spaceBefore + comma + spaceAfter)).AsBool())
                {
                    i += spaceBefore + comma + spaceAfter + l;
                }
                else break;
            }

            return i - start;
        }

        public int checkNumber(int i)
        {
            if (i >= tokensLength) return 0;

            if (tokens[i].number_l.AsBool()) return tokens[i].number_l;

            // `10`:
            if (i < tokensLength && tokens[i].type == TokenType.DecimalNumber &&
                                                       (!tokens.Has(i + 1) ||
                                                        (tokens.Has(i + 1) && tokens[i + 1].type != TokenType.FullStop)))
            {
                tokens[i].number_l = 1;
                return 1;
            }

            // `10.`:
            if (i < tokensLength &&
                tokens[i].type == TokenType.DecimalNumber &&
                    tokens.Has(i + 1) && tokens[i + 1].type == TokenType.FullStop &&
                                                            (!tokens.Has(i + 2) || (tokens[i + 2].type != TokenType.DecimalNumber)))
            {
                tokens[i].number_l = 2;
                return 2;
            }

            // `.10`:
            if (i < tokensLength &&
                tokens[i].type == TokenType.FullStop &&
                    tokens[i + 1].type == TokenType.DecimalNumber)
            {
                tokens[i].number_l = 2;
                return 2;
            }

            // `10.10`:
            if (i < tokensLength &&
                tokens[i].type == TokenType.DecimalNumber &&
                    tokens.Has(i + 1) && tokens[i + 1].type == TokenType.FullStop &&
                    tokens.Has(i + 2) && tokens[i + 2].type == TokenType.DecimalNumber)
            {
                tokens[i].number_l = 3;
                return 3;
            }

            return 0;
        }

        public int checkUri(int i)
        {
            var start = i;

            if (i >= tokensLength || tokens[i].value != "url") return 0;

            // Skip `url`.
            i++;

            if (i >= tokensLength || tokens[i].type != TokenType.LeftParenthesis)
                return 0;

            return tokens[i].right - start + 1;
        }

        public int checkExpression(int i)
        {
            var start = i;

            if (i >= tokensLength || tokens[i++].value != "expression" ||
                    i >= tokensLength || tokens[i].type != TokenType.LeftParenthesis)
            {
                return 0;
            }

            return tokens[i].right - start + 1;
        }

        public int checkFunction(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkIdent(i)).AsBool()) i += l;
            else return 0;

            return i < tokensLength && tokens[i].type == TokenType.LeftParenthesis ?
                tokens[i].right - start + 1 : 0;
        }

        public int checkUnary(int i)
        {
            if (i >= tokensLength) return 0;

            if (tokens[i].type == TokenType.HyphenMinus ||
                    tokens[i].type == TokenType.PlusSign)
            {
                return 1;
            }

            return 0;
        }

        public int checkNamePrefix(int i)
        {
            if (i >= tokensLength) return 0;

            int l;
            if ((l = checkNamePrefix1(i)).AsBool()) tokens[i].namePrefixType = 1;
            else if ((l = checkNamePrefix2(i)).AsBool()) tokens[i].namePrefixType = 2;

            return l;
        }

        public int checkAttributeSelector1(int i)
        {
            var start = i;

            if (tokens[i].type == TokenType.LeftSquareBracket) i++;
            else return 0;

            int l;
            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkAttributeName(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkAttributeMatch(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkAttributeValue(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkAttributeFlags(i)).AsBool())
            {
                i += l;
                if ((l = checkSC(i)).AsBool()) i += l;
            }

            if (tokens[i].type == TokenType.RightSquareBracket) i++;
            else return 0;

            return i - start;
        }

        public int checkAttributeSelector2(int i)
        {
            var start = i;

            if (tokens[i].type == TokenType.LeftSquareBracket) i++;
            else return 0;

            int l;
            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkAttributeName(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if (tokens[i].type == TokenType.RightSquareBracket) i++;
            else return 0;

            return i - start;
        }

        public int checkPseudoe(int i)
        {
            int l;

            // Check `::`
            if (i >= tokensLength || tokens[i].type != TokenType.Colon ||
                    i >= tokensLength || tokens[i + 1].type != TokenType.Colon) return 0;

            if ((l = checkPseudoElement1(i)).AsBool()) tokens[i].pseudoElementType = 1;
            else if ((l = checkPseudoElement2(i)).AsBool()) tokens[i].pseudoElementType = 2;
            else return 0;

            return l;
        }

        public int checkPseudoc(int i)
        {
            int l;

            if (i >= tokensLength || tokens[i].type != TokenType.Colon) return 0;

            if ((l = checkPseudoClass1(i)).AsBool()) tokens[i].pseudoClassType = 1;
            else if ((l = checkPseudoClass2(i)).AsBool()) tokens[i].pseudoClassType = 2;
            else if ((l = checkPseudoClass3(i)).AsBool()) tokens[i].pseudoClassType = 3;
            else if ((l = checkPseudoClass4(i)).AsBool()) tokens[i].pseudoClassType = 4;
            else if ((l = checkPseudoClass5(i)).AsBool()) tokens[i].pseudoClassType = 5;
            else if ((l = checkPseudoClass6(i)).AsBool()) tokens[i].pseudoClassType = 6;
            else return 0;

            return l;
        }

        public int checkUnit(int i)
        {
            var units = new string[]
            {
                "em", "ex", "ch", "rem",
                "vh", "vw", "vmin", "vmax",
                "px", "mm", "q", "cm", "in", "pt", "pc",
                "deg", "grad", "rad", "turn",
                "s", "ms",
                "Hz", "kHz",
                "dpi", "dpcm", "dppx"
            };

            return Array.IndexOf(units, tokens[i].value) != -1 ? 1 : 0;
        }

        public int checkUrange(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            // Check for unicode prefix (u+ or U+)
            if (tokens[i].value == "U" || tokens[i].value == "u") i += 1;
            else return 0;

            if (i >= tokensLength) return 0;

            if (tokens[i].value == "+") i += 1;
            else return 0;

            while (i < tokensLength)
            {
                if ((l = checkIdent(i)).AsBool()) i += l;
                else if ((l = checkNumber(i)).AsBool()) i += l;
                else if ((l = checkUnary(i)).AsBool()) i += l;
                else if ((l = _checkUnicodeWildcard(i)).AsBool()) i += l;
                else break;
            }

            tokens[start].urangeEnd = i - 1;

            return i - start;
        }

        public int checkNamePrefix1(int i)
        {
            var start = i;
            int l;

            if ((l = checkNamespacePrefix(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkCommentML(i)).AsBool()) i += l;

            if ((l = checkNamespaceSeparator(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        public int checkNamePrefix2(int i)
        {
            return checkNamespaceSeparator(i);
        }

        private int _checkUnicodeWildcard(int i)
        {
            var start = i;

            if (i >= tokensLength) return 0;

            while (i < tokensLength)
            {
                if (tokens[i].type == TokenType.QuestionMark) i += 1;
                else break;
            }

            return i - start;
        }

        public int checkAttributeName(int i)
        {
            var start = i;
            int l;

            if ((l = checkNamePrefix(i)).AsBool()) i += l;

            if ((l = checkIdent(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        public int checkAttributeMatch(int i)
        {
            int l;
            if ((l = checkAttributeMatch1(i)).AsBool()) tokens[i].attributeMatchType = 1;
            else if ((l = checkAttributeMatch2(i)).AsBool()) tokens[i].attributeMatchType = 2;

            return l;
        }

        public int checkAttributeValue(int i)
        {
            return Of(checkString(i), checkIdent(i));
        }

        public int checkAttributeFlags(int i)
        {
            return checkIdent(i);
        }

        public int checkPseudoElement1(int i)
        {
            var start = i;
            int l;

            // Skip `::`.
            i += 2;

            if (i >= tokensLength) return 0;

            if ((l = checkIdent(i)).AsBool()) i += l;
            else return 0;

            if (i >= tokensLength ||
                tokens[i].type != TokenType.LeftParenthesis) return 0;

            var right = tokens[i].right;

            // Skip `(`.
            i++;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkSelectorsGroup(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if (i != right) return 0;

            // Skip `)`.
            i++;

            return i - start;
        }

        public int checkPseudoElement2(int i)
        {
            var start = i;
            int l;

            // Skip `::`.
            i += 2;

            if ((l = checkIdent(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        public int checkPseudoClass1(int i)
        {
            var start = i;
            int l;

            // Skip `:`.
            i++;

            if (i >= tokensLength) return 0;

            if ((l = checkIdent(i)).AsBool()) i += l;
            else return 0;

            if (i >= tokensLength ||
                tokens[i].type != TokenType.LeftParenthesis) return 0;

            var right = tokens[i].right;

            // Skip `(`.
            i++;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkSelectorsGroup(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if (i != right) return 0;

            // Skip `)`.
            i++;

            return i - start;
        }

        public int checkPseudoClass2(int i)
        {
            var start = i;
            int l;

            // Skip `:`.
            i++;

            if (i >= tokensLength) return 0;

            if ((l = checkIdent(i)).AsBool()) i += l;
            else return 0;

            if (i >= tokensLength ||
                tokens[i].type != TokenType.LeftParenthesis) return 0;

            var right = tokens[i].right;

            // Skip `(`.
            i++;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkIdent(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if (i != right) return 0;

            // Skip `)`.
            i++;

            return i - start;
        }

        public int checkPseudoClass3(int i)
        {
            var start = i;
            int l;

            // Skip `:`.
            i++;

            if (i >= tokensLength) return 0;

            if ((l = checkIdent(i)).AsBool()) i += l;
            else return 0;

            if (i >= tokensLength ||
                tokens[i].type != TokenType.LeftParenthesis) return 0;

            var right = tokens[i].right;

            // Skip `(`.
            i++;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkUnary(i)).AsBool()) i += l;

            if (i >= tokensLength) return 0;
            if (tokens[i].type == TokenType.DecimalNumber) i++;

            if (i >= tokensLength) return 0;
            if (tokens[i].value == "n") i++;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if (i >= tokensLength) return 0;

            if (tokens[i].type == TokenType.PlusSign ||
                    tokens[i].type == TokenType.HyphenMinus) i++;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if (tokens[i].type == TokenType.DecimalNumber) i++;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if (i != right) return 0;

            // Skip `)`.
            i++;

            return i - start;
        }

        public int checkPseudoClass4(int i)
        {
            var start = i;
            int l;

            // Skip `:`.
            i++;

            if (i >= tokensLength) return 0;

            if ((l = checkIdent(i)).AsBool()) i += l;
            else return 0;

            if (i >= tokensLength) return 0;
            if (tokens[i].type != TokenType.LeftParenthesis) return 0;

            var right = tokens[i].right;

            // Skip `(`.
            i++;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkUnary(i)).AsBool()) i += l;
            if (tokens[i].type == TokenType.DecimalNumber) i++;

            if (tokens[i].value == "n") i++;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if (i != right) return 0;

            // Skip `)`.
            i++;

            return i - start;
        }

        public int checkPseudoClass5(int i)
        {
            var start = i;
            int l;

            // Skip `:`.
            i++;

            if (i >= tokensLength) return 0;

            if ((l = checkIdent(i)).AsBool()) i += l;
            else return 0;

            if (i >= tokensLength) return 0;
            if (tokens[i].type != TokenType.LeftParenthesis) return 0;

            var right = tokens[i].right;

            // Skip `(`.
            i++;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkUnary(i)).AsBool()) i += l;
            if (tokens[i].type == TokenType.DecimalNumber) i++;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if (i != right) return 0;

            // Skip `)`.
            i++;

            return i - start;
        }

        public int checkPseudoClass6(int i)
        {
            var start = i;
            int l;

            // Skip `:`.
            i++;

            if (i >= tokensLength) return 0;

            if ((l = checkIdent(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        public int checkNamespacePrefix(int i)
        {
            if (i >= tokensLength) return 0;

            int l;

            if (tokens[i].type == TokenType.Asterisk) return 1;
            else if ((l = checkIdent(i)).AsBool()) return l;
            else return 0;
        }

        public int checkNamespaceSeparator(int i)
        {
            if (i >= tokensLength) return 0;

            if (tokens[i].type != TokenType.VerticalLine) return 0;

            // Return false if `|=` - [attr|=value]
            if (tokens.Has(i + 1) && tokens[i + 1].type == TokenType.EqualsSign) return 0;

            return 1;
        }

        public int checkAttributeMatch1(int i)
        {
            var start = i;

            var type = tokens[i].type;
            if (type == TokenType.Tilde ||
                    type == TokenType.VerticalLine ||
                    type == TokenType.CircumflexAccent ||
                    type == TokenType.DollarSign ||
                    type == TokenType.Asterisk) i++;
            else return 0;

            if (tokens[i].type == TokenType.EqualsSign) i++;
            else return 0;

            return i - start;
        }

        public int checkAttributeMatch2(int i)
        {
            if (tokens[i].type == TokenType.EqualsSign) return 1;
            else return 0;
        }

        public int checkBlockdecl(int i)
        {
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkBlockdecl1(i)).AsBool()) tokens[i].bd_type = 1;
            else if ((l = checkBlockdecl2(i)).AsBool()) tokens[i].bd_type = 2;
            else if ((l = checkBlockdecl3(i)).AsBool()) tokens[i].bd_type = 3;
            else if ((l = checkBlockdecl4(i)).AsBool()) tokens[i].bd_type = 4;
            else return 0;

            return l;
        }

        public int checkBlockdecl1(int i)
        {
            var start = i;
            int l;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkDeclaration(i)).AsBool()) tokens[i].bd_kind = 1;
            else if ((l = checkAtrule(i)).AsBool()) tokens[i].bd_kind = 2;
            else return 0;

            i += l;

            if ((l = checkSC(i)).AsBool()) i += l;

            if (i < tokensLength && (l = checkDeclDelim(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        public int checkBlockdecl2(int i)
        {
            var start = i;
            int l;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkDeclaration(i)).AsBool()) tokens[i].bd_kind = 1;
            else if ((l = checkAtrule(i)).AsBool()) tokens[i].bd_kind = 2;
            else return 0;

            i += l;

            if ((l = checkSC(i)).AsBool()) i += l;

            return i - start;
        }

        public int checkBlockdecl3(int i)
        {
            var start = i;
            int l;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkDeclDelim(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            return i - start;
        }

        public int checkBlockdecl4(int i)
        {
            return checkSC(i);
        }

        public int checkDeclaration(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkProperty(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkPropertyDelim(i)).AsBool()) i++;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkValue(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        public int checkProperty(int i)
        {
            var start = i;
            int l;

            if ((l = checkProperty1(i)).AsBool()) tokens[start].propertyType = 1;
            else if ((l = checkProperty2(i)).AsBool()) tokens[start].propertyType = 2;

            return l;
        }

        public int checkValue(int i)
        {
            var start = i;
            int l;
            int s;
            int _i;

            while (i < tokensLength)
            {
                s = checkSC(i);
                _i = i + s;

                if ((l = _checkValue(_i)).AsBool()) i += l + s;
                else break;
            }

            tokens[start].value_end = i;

            return i - start;
        }

        private int _checkValue(int i)
        {
            int l;

            if ((l = checkProgid(i)).AsBool()) tokens[i].value_child = 1;
            else if ((l = checkVhash(i)).AsBool()) tokens[i].value_child = 2;
            else if ((l = checkAny(i)).AsBool()) tokens[i].value_child = 3;
            else if ((l = checkOperator(i)).AsBool()) tokens[i].value_child = 4;
            else if ((l = checkImportant(i)).AsBool()) tokens[i].value_child = 5;

            return l;
        }

        public int checkPropertyDelim(int i)
        {
            return i < tokensLength && tokens[i].type == TokenType.Colon ? 1 : 0;
        }

        public int checkProperty1(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkIdent(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        public int checkProperty2(int i)
        {
            return checkCustomProperty(i);
        }

        public int checkCustomProperty(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if (tokens[i].type != TokenType.HyphenMinus ||
                    tokens.Has(i + 1) && tokens[i + 1].type != TokenType.HyphenMinus) return 0;

            // Skip `--`
            i += 2;

            if ((l = checkIdent(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        public int checkProgid(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if (joinValues2(i, 6) == "progid:DXImageTransform.Microsoft.") i += 6;
            else return 0;

            if ((l = checkIdent(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if (tokens[i].type == TokenType.LeftParenthesis)
            {
                tokens[start].progid_end = tokens[i].right;
                i = tokens[i].right + 1;
            }
            else return 0;

            return i - start;
        }

        public int checkImportant(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength ||
                tokens[i++].type != TokenType.ExclamationMark) return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if (tokens[i].value == "important")
            {
                tokens[start].importantEnd = i;
                return i - start + 1;
            }
            else
            {
                return 0;
            }
        }

        public int checkStylesheet(int i)
        {
            var start = i;
            int l;
            while (i < tokensLength)
            {
                if ((l = checkSC(i)).AsBool()) tokens[i].stylesheet_child = 1;
                else if ((l = checkRuleset(i)).AsBool()) tokens[i].stylesheet_child = 2;
                else if ((l = checkAtrule(i)).AsBool()) tokens[i].stylesheet_child = 3;
                else if ((l = checkDeclDelim(i)).AsBool()) tokens[i].stylesheet_child = 4;
                else throwError(i);

                i += l;
            }

            return i - start;
        }

        public Node getStylesheet()
        {
            var type = NodeType.StylesheetType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            while (pos < tokensLength)
            {
                var childType = tokens[pos].stylesheet_child;

                if (childType == 1) content = content.concat(getSC());
                if (childType == 2) content.push(getRuleset());
                if (childType == 3) content.push(getAtrule());
                if (childType == 4) content.push(getDeclDelim());
            }

            return newNode(type, content, line, column);
        }

        public Node getCommentML()
        {
            var type = NodeType.CommentMLType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = tokens[pos].value.Substring(2);
            var l = content.Length;

            if (content.charAt(l - 2) == '*' && content.charAt(l - 1) == '/')
                content = content.Substring(0, l - 2);

            var end = getLastPosition(content, line, column, 2);
            if (end[0] == line) end[1] += 2;
            pos++;

            return newNode(type, content, line, column, end);
        }

        public Node getS()
        {
            var type = NodeType.SType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = joinValues(pos, tokens[pos].ws_last);

            pos = tokens[pos].ws_last + 1;

            return newNode(type, content, line, column);
        }

        public List<Node> getSC()
        {
            var sc = new List<Node>();
            if (pos >= tokensLength) return sc;

            while (pos < tokensLength)
            {
                var childType = tokens[pos].sc_child;

                if (childType == 1) sc.push(getS());
                else if (childType == 2) sc.push(getCommentML());
                else break;
            }

            return sc;
        }

        public Node getRuleset()
        {
            var type = NodeType.RulesetType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
                getSelectorsGroup(),
                getSC(),
                getBlock()
            );

            return newNode(type, content, line, column);
        }

        public Node getAtrule()
        {
            var childType = tokens[pos].atrule_type;

            if (childType == 1) return getAtruler(); // @-rule with ruleset
            if (childType == 2) return getAtruleb(); // Block @-rule
            if (childType == 3) return getAtrules(); // Single-line @-rule
            if (childType == 4) return getKeyframesRule();

            return null;
        }

        public Node getDeclDelim()
        {
            var type = NodeType.DeclDelimType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = ";";

            pos++;

            return newNode(type, content, line, column);
        }

        public int[] getLastPosition(Content content, int line, int column, int? colOffset = null)
        {
            return content.IsString ?
                getLastPositionForString(content.AsString, line, column, colOffset) :
                getLastPositionForArray(content.AsArray, line, column, colOffset);
        }

        public int[] getLastPositionForString(string? content, int line, int column, int? colOffset = null)
        {
            var position = new int[2];

            if (content == null)
            {
                position = [line, column];
                if (colOffset.HasValue) position[1] += colOffset.Value - 1;
                return position;
            }

            var lastLinebreak = content.LastIndexOf('\n');
            var endsWithLinebreak = lastLinebreak == content.Length - 1;
            var splitContent = content.Split('\n');
            var linebreaksCount = splitContent.Length - 1;
            var prevLinebreak = linebreaksCount == 0 || linebreaksCount == 1 ?
                -1 : content.Length - splitContent[linebreaksCount - 1].Length - 2;

            // Line:
            var offset = endsWithLinebreak ? linebreaksCount - 1 : linebreaksCount;
            position[0] = line + offset;

            // Column:
            if (endsWithLinebreak)
            {
                offset = prevLinebreak != -1 ?
                    content.Length - prevLinebreak :
                    content.Length - 1;
            }
            else
            {
                offset = linebreaksCount != 0 ?
                content.Length - lastLinebreak - column - 1 :
                    content.Length - 1;
            }
            position[1] = column + offset;

            if (!colOffset.HasValue) return position;

            if (endsWithLinebreak)
            {
                position[0]++;
                position[1] = colOffset.Value;
            }
            else
            {
                position[1] += colOffset.Value;
            }

            return position;
        }

        public int[] getLastPositionForArray(List<Node> content, int line, int column, int? colOffset = null)
        {
            var position = new int[2];

            if (content.Count == 0)
            {
                position = [line, column];
            }
            else
            {
                var c = content[content.Count - 1];
                if (c.end != null)
                {
                    position = [c.end.Value.line, c.end.Value.column];
                }
                else
                {
                    position = getLastPosition(c.content, line, column);
                }
            }

            if (!colOffset.HasValue) return position;

            if (tokens.Has(pos - 1) && tokens[pos - 1].type != "Newline")
            {
                position[1] += colOffset.Value;
            }
            else
            {
                position[0]++;
                position[1] = 1;
            }

            return position;
        }

        public Node newNode(string type, Content content, int line, int column, int[]? end = null)
        {
            end ??= getLastPosition(content, line, column);
            return new Node(new NodeOptions {
                type = type,
                content = content,
                start = new Position
                {
                    line = line,
                    column = column
                },
                end = new Position
                {
                    line = end[0],
                    column = end[1]
                },
                syntax = "css"
            });
        }

        public List<Node> getSelectorsGroup()
        {
            var selectorsGroup = new List<Node>();
            var selectorCounter = 0;
            var delimCounter = 0;

            var selectorsGroupEnd = tokens[pos].selectorsGroupEnd;
            var selectorCount = tokens[pos].selectorsGroupSelectorCount;
            var delimCount = tokens[pos].selectorsGroupDelimCount;

            selectorsGroup.push(getSelector());
            selectorCounter++;

            while (pos < selectorsGroupEnd)
            {
                if (delimCounter < delimCount)
                {
                    selectorsGroup = selectorsGroup.concat(getSC());
                    selectorsGroup = selectorsGroup.concat(getDelim());
                    delimCounter++;

                    selectorsGroup = selectorsGroup.concat(getSC());

                    if (selectorCounter < selectorCount)
                    {
                        selectorsGroup = selectorsGroup.concat(getSelector());
                        selectorCounter++;
                    }
                }
            }

            return selectorsGroup;
        }

        public Node getBlock()
        {
            var type = NodeType.BlockType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var end = tokens[pos].right;
            var content = new List<Node>();

            // Skip `{`.
            pos++;

            while (pos < end)
            {
                if (checkBlockdecl(pos).AsBool()) content = content.concat(getBlockdecl());
                else throwError(pos);
            }

            var end_ = getLastPosition(content, line, column, 1);
            pos = end + 1;

            return newNode(type, content, line, column, end_);
        }

        public Node getAtruler()
        {
            var type = NodeType.AtruleType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
                getAtkeyword(),
                getTsets(),
                getAtrulers()
            );

            return newNode(type, content, line, column);
        }

        public Node getAtruleb()
        {
            var type = NodeType.AtruleType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
                getAtkeyword(),
                getTsets(),
                getBlock()
            );

            return newNode(type, content, line, column);
        }

        public Node getAtrules()
        {
            var type = NodeType.AtruleType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
                getAtkeyword(),
                getTsets()
            );

            return newNode(type, content, line, column);
        }

        public Node getKeyframesRule()
        {
            var type = NodeType.AtruleType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
                getAtkeyword(),
                getSC(),
                getIdent(),
                getSC(),
                getKeyframesBlocks()
            );

            return newNode(type, content, line, column);
        }

        public Node getSelector()
        {
            var type = NodeType.SelectorType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var selectorEnd = token.selectorEnd;
            var content = getCompoundSelector();

            while (pos < selectorEnd)
            {
                content = content.concat(getSC());
                if (checkCombinator(pos).AsBool()) content.push(getCombinator());
                content = content.concat(
                    getSC(),
                    getCompoundSelector()
                );
            }

            return newNode(type, content, line, column);
        }

        public Node getDelim()
        {
            var type = NodeType.DelimType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = ",";

            pos++;

            return newNode(type, content, line, column);
        }

        public List<Node> getBlockdecl()
        {
            var childType = tokens[pos].bd_type;

            if (childType == 1) return getBlockdecl1();
            if (childType == 2) return getBlockdecl2();
            if (childType == 3) return getBlockdecl3();
            if (childType == 4) return getBlockdecl4();

            return default;
        }

        public Node getAtkeyword()
        {
            var type = NodeType.AtkeywordType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;

            // Skip `@`.
            pos++;

            var content = new List<Node>(){ getIdent() };

            return newNode(type, content, line, column);
        }

        public List<Node> getTsets()
        {
            var content = new List<Node>();
            Node t;

            if (pos >= tokensLength) return content;

            var end = tokens[pos].tsets_end;
            while (pos < end)
            {
                t = getTset().AsT0;
                if (t.content.IsString) content.push(t);
                else content = content.concat(t);
            }

            return content;
        }

        public Node getAtrulers()
        {
            var type = NodeType.BlockType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            // Skip `{`.
            pos++;

            content = content.concat(getSC());

            while (pos < tokensLength && !tokens[pos].atrulers_end.AsBool())
            {
                var childType = tokens[pos].atrulers_child;
                if (childType == 1) content = content.concat(getSC());
                else if (childType == 2) content.push(getAtrule());
                else if (childType == 3) content.push(getRuleset());
                else break;
            }

            content = content.concat(getSC());

            var end = getLastPosition(content, line, column, 1);

            // Skip `}`.
            pos++;

            return newNode(type, content, line, column, end);
        }

        public Node getIdent()
        {
            var type = NodeType.IdentType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = joinValues(pos, tokens[pos].ident_last);

            pos = tokens[pos].ident_last + 1;

            return newNode(type, content, line, column);
        }

        public Node getKeyframesBlocks()
        {
            var type = NodeType.BlockType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var keyframesBlocksEnd = token.right;
            var content = new List<Node>();

            // Skip `{`.
            pos++;

            while (pos < keyframesBlocksEnd)
            {
                if (checkSC(pos).AsBool()) content = content.concat(getSC());
                else if (checkKeyframesBlock(pos).AsBool()) content.push(getKeyframesBlock());
            }

            var end = getLastPosition(content, line, column, 1);

            // Skip `}`.
            pos++;

            return newNode(type, content, line, column, end);
        }

        public List<Node> getCompoundSelector()
        {
            var type = tokens[pos].compoundSelectorType;
            if (type == 1) return getCompoundSelector1();
            if (type == 2) return getCompoundSelector2();

            return default;
        }

        public Node getCombinator()
        {
            var type = tokens[pos].combinatorType;
            if (type == 1) return getCombinator1();
            if (type == 2) return getCombinator2();
            if (type == 3) return getCombinator3();
            if (type == 4) return getCombinator4();

            return default;
        }

        public List<Node> getBlockdecl1()
        {
            var sc = getSC();
            Node content = default;

            switch (tokens[pos].bd_kind)
            {
                case 1:
                    content = getDeclaration();
                    break;
                case 2:
                    content = getAtrule();
                    break;
            }

            return sc.concat(
                content,
                getSC(),
                getDeclDelim(),
                getSC()
            );
        }

        public List<Node> getBlockdecl2()
        {
            var sc = getSC();
            Node content = default;

            switch (tokens[pos].bd_kind)
            {
                case 1:
                    content = getDeclaration();
                    break;
                case 2:
                    content = getAtrule();
                    break;
            }

            return sc.concat(
                content,
                getSC()
            );
        }

        public List<Node> getBlockdecl3()
        {
            return new List<Node>().concat(
                getSC(),
                getDeclDelim(),
                getSC()
            );
        }

        public List<Node> getBlockdecl4()
        {
            return getSC();
        }

        public UnionList<Node> getTset()
        {
            var childType = tokens[pos].tset_child;

            if (childType == 1) return getVhash();
            if (childType == 2) return getAny();
            if (childType == 3) return getSC();
            if (childType == 4) return getOperator();

            return default;
        }

        public Node getKeyframesBlock()
        {
            var type = NodeType.RulesetType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
                getKeyframesSelectorsGroup(),
                getSC(),
                getBlock()
            );

            return newNode(type, content, line, column);
        }

        public List<Node> getCompoundSelector1()
        {
            var sequence = new List<Node>();
            var compoundSelectorEnd = tokens[pos].compoundSelectorEnd;

            if (checkUniversalSelector(pos).AsBool()) sequence.push(getUniversalSelector());
            else sequence.push(getTypeSelector());

            while (pos < compoundSelectorEnd)
            {
                if (checkShash(pos).AsBool()) sequence.push(getShash());
                else if (checkClass(pos).AsBool()) sequence.push(getClass());
                else if (checkAttributeSelector(pos).AsBool()) sequence.push(getAttributeSelector());
                else if (checkPseudo(pos).AsBool()) sequence.push(getPseudo());
            }

            return sequence;
        }

        public List<Node> getCompoundSelector2()
        {
            var sequence = new List<Node>();
            var compoundSelectorEnd = tokens[pos].compoundSelectorEnd;

            while (pos < compoundSelectorEnd)
            {
                if (checkShash(pos).AsBool()) sequence.push(getShash());
                else if (checkClass(pos).AsBool()) sequence.push(getClass());
                else if (checkAttributeSelector(pos).AsBool()) sequence.push(getAttributeSelector());
                else if (checkPseudo(pos).AsBool()) sequence.push(getPseudo());
                else break;
            }

            return sequence;
        }

        public Node getDeclaration()
        {
            var type = NodeType.DeclarationType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
                getProperty(),
                getSC(),
                getPropertyDelim(),
                getSC(),
                getValue()
            );

            return newNode(type, content, line, column);
        }

        public Node getCombinator1()
        {
            var type = NodeType.CombinatorType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = ">>>";

            // Skip combinator
            pos += 3;

            return newNode(type, content, line, column);
        }

        public Node getCombinator2()
        {
            var type = NodeType.CombinatorType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = $"{token.value}{tokens[pos + 1].value}";

            // Skip combinator
            pos += 2;

            return newNode(type, content, line, column);
        }

        public Node getCombinator3()
        {
            var type = NodeType.CombinatorType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = token.value;

            // Skip combinator
            pos++;

            return newNode(type, content, line, column);
        }

        public Node getCombinator4()
        {
            var type = NodeType.CombinatorType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;

            // Skip `/`.
            pos++;

            var ident = getIdent();

            // Skip `/`.
            pos++;

            var content = $"/{ident.content}/";

            return newNode(type, content, line, column);
        }

        public Node getVhash()
        {
            var type = NodeType.VhashType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;

            // Skip `#`.
            pos++;

            var content = getNmName2();
            var end = getLastPosition(content, line, column + 1);
            return newNode(type, content, line, column, end);
        }

        public Node getAny()
        {
            var childType = tokens[pos].any_child;

            if (childType == 1) return getBrackets();
            if (childType == 2) return getParentheses();
            if (childType == 3) return getString();
            if (childType == 4) return getPercentage();
            if (childType == 5) return getDimension();
            if (childType == 13) return getUnicodeRange();
            if (childType == 6) return getNumber();
            if (childType == 7) return getUri();
            if (childType == 8) return getExpression();
            if (childType == 9) return getFunction();
            if (childType == 10) return getIdent();
            if (childType == 11) return getClass();
            if (childType == 12) return getUnary();

            return default;
        }

        public Node getExpression()
        {
            var type = NodeType.ExpressionType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;

            pos++;

            var content = joinValues(pos + 1, tokens[pos].right - 1);
            var end = getLastPosition(content, line, column, 1);

            if (end[0] == line) end[1] += 11;
            pos = tokens[pos].right + 1;

            return newNode(type, content, line, column, end);
        }

        public Node getFunction()
        {
            var type = NodeType.FunctionType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
                getIdent(),
                getArguments()
            );

            return newNode(type, content, line, column);
        }

        public Node getArguments()
        {
            var type = NodeType.ArgumentsType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();
            Node body;

            // Skip `(`.
            pos++;

            while (pos < tokensLength &&
                   tokens[pos].type != TokenType.RightParenthesis)
            {
                if (checkDeclaration(pos).AsBool()) content.push(getDeclaration());
                else if (checkArgument(pos).AsBool())
                {
                    body = getArgument().AsT0;
                    if (body.content.IsString) content.push(body);
                    else content = content.concat(body);
                }
                else if (checkClass(pos).AsBool()) content.push(getClass());
                else throwError(pos);
            }

            var end = getLastPosition(content, line, column, 1);

            // Skip `)`.
            pos++;

            return newNode(type, content, line, column, end);
        }

        public UnionList<Node> getArgument()
        {
            var childType = tokens[pos].argument_child;

            if (childType == 1) return getVhash();
            if (childType == 2) return getCustomProperty();
            if (childType == 3) return getAny();
            if (childType == 4) return getSC();
            if (childType == 5) return getOperator();

            return default;
        }

        public int checkArgument(int i)
        {
            int l;

            if ((l = checkVhash(i)).AsBool()) tokens[i].argument_child = 1;
            else if ((l = checkCustomProperty(i)).AsBool()) tokens[i].argument_child = 2;
            else if ((l = checkAny(i)).AsBool()) tokens[i].argument_child = 3;
            else if ((l = checkSC(i)).AsBool()) tokens[i].argument_child = 4;
            else if ((l = checkOperator(i)).AsBool()) tokens[i].argument_child = 5;

            return l;
        }

        public Node getUri()
        {
            var startPos = pos;
            var uriExcluding = new Dictionary<string, int>();
            List<Node> uri;
            int l;
            Node raw;

            string rawContent;
            Token t;

            pos += 2;

            uriExcluding[TokenType.Space] = 1;
            uriExcluding[TokenType.Tab] = 1;
            uriExcluding[TokenType.Newline] = 1;
            uriExcluding[TokenType.LeftParenthesis] = 1;
            uriExcluding[TokenType.RightParenthesis] = 1;

            if (checkUri1(pos).AsBool())
            {
                uri = new List<Node>().concat(
                    getSC(),
                    getString(),
                    getSC()
                );
            }
            else
            {
                uri = checkSC(pos).AsBool() ? getSC() : [];
                l = checkExcluding(uriExcluding, pos);
                rawContent = joinValues(pos, pos + l);
                t = tokens[pos];
                raw = newNode(NodeType.RawType, rawContent, t.ln, t.col);

                uri.push(raw);

                pos += l + 1;

                if (checkSC(pos).AsBool()) uri = uri.concat(getSC());
            }

            t = tokens[startPos];
            var line = t.ln;
            var column = t.col;
            var end = getLastPosition(uri, line, column, 1);
            pos++;

            return newNode(NodeType.UriType, uri, line, column, end);
        }

        public int checkExcluding(Dictionary<string, int> exclude, int i)
        {
            var start = i;

            while (i < tokensLength)
            {
                if (exclude[tokens[i++].type].AsBool()) break;
            }

            return i - start - 2;
        }

        public int checkUri1(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if (tokens[i].type != TokenType.StringDQ &&
                    tokens[i].type != TokenType.StringSQ) return 0;

            i++;

            if ((l = checkSC(i)).AsBool()) i += l;

            return i - start;
        }

        public Node getUnicodeRange()
        {
            var type = NodeType.UnicodeRangeType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            while (pos < tokensLength)
            {
                if (checkSC(pos).AsBool()) content = content.concat(getSC());
                else if (checkDelim(pos).AsBool()) content.push(getDelim());
                else if (checkUrange(pos).AsBool()) content.push(getUrange());
                else break;
            }

            return newNode(type, content, line, column);
        }

        public Node getUrange()
        {
            var startPos = pos;
            var type = NodeType.UrangeType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = "";

            content = joinValues(startPos, tokens[startPos].urangeEnd);
            pos = tokens[startPos].urangeEnd + 1;

            return newNode(type, content, line, column);
        }

        public Node getDimension()
        {
            var type = NodeType.DimensionType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>()
            {
                getNumber(),
                getUnit()
            };

            return newNode(type, content, line, column);
        }

        public Node getUnit()
        {
            var type = NodeType.IdentType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = token.value;

            pos++;

            return newNode(type, content, line, column);
        }

        public Node getParentheses()
        {
            var type = NodeType.ParenthesesType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var right = token.right;
            var content = new List<Node>();

            // Skip `(`.
            pos++;

            if (pos < right)
            {
                content = getTsets();
            }

            var end = getLastPosition(content, line, column, 1);

            // Skip `)`.
            pos++;

            return newNode(type, content, line, column, end);
        }

        public Node getBrackets()
        {
            var type = NodeType.BracketsType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var right = token.right;
            var content = new List<Node>();

            // Skip `[`.
            pos++;

            if (pos < right)
            {
                content = getTsets();
            }

            var end = getLastPosition(content, line, column, 1);

            // Skip `]`.
            pos++;

            return newNode(type, content, line, column, end);
        }

        public Node getOperator()
        {
            var type = NodeType.OperatorType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = token.value;

            pos++;

            return newNode(type, content, line, column);
        }

        public List<Node> getKeyframesSelectorsGroup()
        {
            var selectorsGroup = new List<Node>();
            var selectorsGroupEnd = tokens[pos].selectorsGroupEnd;

            selectorsGroup.push(getKeyframesSelector());

            while (pos < selectorsGroupEnd)
            {
                selectorsGroup = selectorsGroup.concat(
                    getSC(),
                    getDelim(),
                    getSC(),
                    getKeyframesSelector()
                );
            }

            return selectorsGroup;
        }

        public Node getUniversalSelector()
        {
            var type = NodeType.UniversalSelectorType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();
            int[] end = default;

            if (checkNamePrefix(pos).AsBool())
            {
                content.push(getNamePrefix());
                end = getLastPosition(content, line, column, 1);
            }

            pos++;

            return newNode(type, content, line, column, end);
        }

        public Node getTypeSelector()
        {
            var type = NodeType.TypeSelectorType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            if (checkNamePrefix(pos).AsBool()) content.push(getNamePrefix());

            content.push(getIdent());

            return newNode(type, content, line, column);
        }

        public Node getShash()
        {
            var type = NodeType.ShashType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;

            // Skip `#`.
            pos++;

            var content = new List<Node>{ getIdent() };

            return newNode(type, content, line, column);
        }

        public Node getClass()
        {
            var type = NodeType.ClassType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;

            // Skip `.`
            pos++;

            var content = new List<Node>() { getIdent() };

            return newNode(type, content, line, column);
        }

        public Node getAttributeSelector()
        {
            var type = tokens[pos].attributeSelectorType;
            if (type == 1) return getAttributeSelector1();
            else return getAttributeSelector2();
        }

        public Node getPseudo()
        {
            if (checkPseudoe(pos).AsBool()) return getPseudoe();
            if (checkPseudoc(pos).AsBool()) return getPseudoc();

            return default;
        }

        public Node getProperty()
        {
            var type = tokens[pos].propertyType;

            if (type == 1) return getProperty1();
            if (type == 2) return getProperty2();

            return default;
        }

        public Node getPropertyDelim()
        {
            var type = NodeType.PropertyDelimType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = ":";

            // Skip `:`.
            pos++;

            return newNode(type, content, line, column);
        }

        public Node getValue()
        {
            var type = NodeType.ValueType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var end = tokens[pos].value_end;
            var content = new List<Node>();

            while (pos < end)
            {
                if (tokens[pos].value_child.AsBool()) content.push(_getValue());
                else content = content.concat(getSC());
            }

            return newNode(type, content, line, column);
        }

        public string getNmName2()
        {
            var s = tokens[pos].value;

            if (tokens[pos++].type == TokenType.DecimalNumber &&
                    pos < tokensLength &&
                    tokens[pos].type == TokenType.Identifier) s += tokens[pos++].value;

            return s;
        }

        public Node getKeyframesSelector()
        {
            var keyframesSelectorType = NodeType.KeyframesSelectorType;
            var selectorType = NodeType.SelectorType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            if (token.keyframesSelectorType == 1)
            {
                content.push(getIdent());
            }
            else
            {
                content.push(getPercentage());
            }

            var keyframesSelector = newNode(
                keyframesSelectorType,
                content,
                line,
                column
            );

            return newNode(selectorType, new List<Node>(){ keyframesSelector }, line, column);
        }

        public Node getNamePrefix()
        {
            var type = tokens[pos].namePrefixType;
            if (type == 1) return getNamePrefix1();
            else return getNamePrefix2();
        }

        public Node getAttributeSelector1()
        {
            var type = NodeType.AttributeSelectorType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            // Skip `[`.
            pos++;

            content = content.concat(
                getSC(),
                getAttributeName(),
                getSC(),
                getAttributeMatch(),
                getSC(),
                getAttributeValue(),
                getSC()
            );

            if (checkAttributeFlags(pos).AsBool())
            {
                content.push(getAttributeFlags());
                content = content.concat(getSC());
            }

            // Skip `]`.
            pos++;

            var end = getLastPosition(content, line, column, 1);
            return newNode(type, content, line, column, end);
        }

        public Node getAttributeSelector2()
        {
            var type = NodeType.AttributeSelectorType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            // Skip `[`.
            pos++;

            content = content.concat(
                getSC(),
                getAttributeName(),
                getSC()
            );

            // Skip `]`.
            pos++;

            var end = getLastPosition(content, line, column, 1);
            return newNode(type, content, line, column, end);
        }

        public Node getPseudoe()
        {
            var childType = tokens[pos].pseudoElementType;
            if (childType == 1) return getPseudoElement1();
            if (childType == 2) return getPseudoElement2();

            return default;
        }

        public Node getPseudoc()
        {
            var childType = tokens[pos].pseudoClassType;
            if (childType == 1) return getPseudoClass1();
            if (childType == 2) return getPseudoClass2();
            if (childType == 3) return getPseudoClass3();
            if (childType == 4) return getPseudoClass4();
            if (childType == 5) return getPseudoClass5();
            if (childType == 6) return getPseudoClass6();

            return default;
        }

        public Node getProperty1()
        {
            var type = NodeType.PropertyType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>(){ getIdent() };

            return newNode(type, content, line, column);
        }

        public Node getProperty2()
        {
            return getCustomProperty();
        }

        public Node getCustomProperty()
        {
            var type = NodeType.CustomPropertyType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;

            // Skip `--`
            pos += 2;

            var content = new List<Node>(){ getIdent() };

            return newNode(type, content, line, column);
        }

        public Node _getValue()
        {
            var childType = tokens[pos].value_child;
            if (childType == 1) return getProgid();
            if (childType == 2) return getVhash();
            if (childType == 3) return getAny();
            if (childType == 4) return getOperator();
            if (childType == 5) return getImportant();

            return default;
        }

        public Node getProgid()
        {
            var type = NodeType.ProgidType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var progid_end = token.progid_end;
            var content = joinValues(pos, progid_end);

            pos = progid_end + 1;

            return newNode(type, content, line, column);
        }

        public Node getImportant()
        {
            var type = NodeType.ImportantType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = joinValues(pos, token.importantEnd);

            pos = token.importantEnd + 1;

            return newNode(type, content, line, column);
        }

        public Node getPercentage()
        {
            var type = NodeType.PercentageType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>(){ getNumber() };
            var end = getLastPosition(content, line, column, 1);

            // Skip `%`.
            pos++;

            return newNode(type, content, line, column, end);
        }

        public Node getNumber()
        {
            var type = NodeType.NumberType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var l = tokens[pos].number_l;
            var content = "";

            for (var j = 0; j < l; j++)
            {
                content += tokens[pos + j].value;
            }

            pos += l;

            return newNode(type, content, line, column);
        }

        public Node getNamePrefix1()
        {
            var type = NodeType.NamePrefixType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            content.push(getNamespacePrefix());

            if (checkCommentML(pos).AsBool()) content.push(getCommentML());

            content.push(getNamespaceSeparator());

            return newNode(type, content, line, column);
        }

        public Node getNamespacePrefix()
        {
            var type = NodeType.NamespacePrefixType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            if (token.type == TokenType.Asterisk)
            {
                var asteriskNode = newNode(NodeType.IdentType, "*", line, column);
                content.push(asteriskNode);
                pos++;
            }
            else if (checkIdent(pos).AsBool()) content.push(getIdent());

            return newNode(type, content, line, column);
        }

        public Node getNamespaceSeparator()
        {
            var type = NodeType.NamespaceSeparatorType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = "|";

            pos++;
            return newNode(type, content, line, column);
        }

        public Node getNamePrefix2()
        {
            var type = NodeType.NamePrefixType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>(){ getNamespaceSeparator() };

            return newNode(type, content, line, column);
        }

        public Node getAttributeName()
        {
            var type = NodeType.AttributeNameType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            if (checkNamePrefix(pos).AsBool()) content.push(getNamePrefix());
            content.push(getIdent());

            return newNode(type, content, line, column);
        }

        public Node getAttributeMatch()
        {
            var type = tokens[pos].attributeMatchType;
            if (type == 1) return getAttributeMatch1();
            else return getAttributeMatch2();
        }

        public Node getAttributeMatch1()
        {
            var type = NodeType.AttributeMatchType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = tokens[pos].value + tokens[pos + 1].value;
            pos += 2;

            return newNode(type, content, line, column);
        }

        public Node getAttributeMatch2()
        {
            var type = NodeType.AttributeMatchType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = "=";

            pos++;
            return newNode(type, content, line, column);
        }

        public Node getAttributeValue()
        {
            var type = NodeType.AttributeValueType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            if (checkString(pos).AsBool()) content.push(getString());
            else content.push(getIdent());

            return newNode(type, content, line, column);
        }

        public Node getString()
        {
            var type = NodeType.StringType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = token.value;

            pos++;

            return newNode(type, content, line, column);
        }

        public Node getAttributeFlags()
        {
            var type = NodeType.AttributeFlagsType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>() { getIdent() };

            return newNode(type, content, line, column);
        }

        public Node getPseudoElement1()
        {
            var type = NodeType.PseudoeType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            // Skip `::`.
            pos += 2;

            content.push(getIdent());

            {
                var _type = NodeType.ArgumentsType;
                var _token = tokens[pos];
                var _line = _token.ln;
                var _column = _token.col;

                // Skip `(`.
                pos++;

                var selectorContent = new List<Node>().concat(
                    getSC(),
                    getSelectorsGroup(),
                    getSC()
                );

                var end = getLastPosition(selectorContent, _line, _column, 1);
                var args = newNode(_type, selectorContent, _line, _column, end);
                content.push(args);

                // Skip `)`.
                pos++;
            }

            return newNode(type, content, line, column);
        }

        public Node getPseudoElement2()
        {
            var type = NodeType.PseudoeType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;

            // Skip `::`.
            pos += 2;

            var content = new List<Node>(){ getIdent() };

            return newNode(type, content, line, column);
        }

        public Node getPseudoClass1()
        {
            var type = NodeType.PseudocType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            // Skip `:`.
            pos++;

            content.push(getIdent());

            {
                var _type = NodeType.ArgumentsType;
                var _token = tokens[pos];
                var _line = _token.ln;
                var _column = _token.col;

                // Skip `(`.
                pos++;

                var selectorContent = new List<Node>().concat(
                    getSC(),
                    getSelectorsGroup(),
                    getSC()
                );

                var end = getLastPosition(selectorContent, _line, _column, 1);
                var args = newNode(_type, selectorContent, _line, _column, end);
                content.push(args);

                // Skip `)`.
                pos++;
            }

            return newNode(type, content, line, column);
        }

        public Node getPseudoClass2()
        {
            var type = NodeType.PseudocType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            // Skip `:`.
            pos++;

            content.push(getIdent());

            // Skip `(`.
            pos++;

            var l = tokens[pos].ln;
            var c = tokens[pos].col;
            var value = new List<Node>().concat(
                getSC(),
                getIdent(),
                getSC()
            );

            var end = getLastPosition(value, l, c, 1);
            var args = newNode(NodeType.ArgumentsType, value, l, c, end);
            content.push(args);

            // Skip `)`.
            pos++;

            return newNode(type, content, line, column);
        }

        public Node getPseudoClass3()
        {
            var type = NodeType.PseudocType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            // Skip `:`.
            pos++;

            content.push(getIdent());

            var l = tokens[pos].ln;
            var c = tokens[pos].col;
            var value = new List<Node>();

            // Skip `(`.
            pos++;

            value = value.concat(getSC());

            if (checkUnary(pos).AsBool()) value.push(getUnary());
            if (checkNumber(pos).AsBool()) value.push(getNumber());

            {
                var _l = tokens[pos].ln;
                var _c = tokens[pos].col;
                var _content = tokens[pos].value;
                var ident = newNode(NodeType.IdentType, _content, _l, _c);
                value.push(ident);
                pos++;
            }

            value = value.concat(getSC());

            if (checkUnary(pos).AsBool()) value.push(getUnary());

            value = value.concat(getSC());

            if (checkNumber(pos).AsBool()) value.push(getNumber());

            value = value.concat(getSC());

            var end = getLastPosition(value, l, c, 1);
            var args = newNode(NodeType.ArgumentsType, value, l, c, end);
            content.push(args);

            // Skip `)`.
            pos++;

            return newNode(type, content, line, column);
        }

        public Node getUnary()
        {
            var type = NodeType.OperatorType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = token.value;

            pos++;

            return newNode(type, content, line, column);
        }

        public Node getPseudoClass4()
        {
            var type = NodeType.PseudocType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            // Skip `:`.
            pos++;

            content.push(getIdent());

            var l = tokens[pos].ln;
            var c = tokens[pos].col;
            var value = new List<Node>();

            // Skip `(`.
            pos++;

            value = value.concat(getSC());

            if (checkUnary(pos).AsBool()) value.push(getUnary());
            if (checkNumber(pos).AsBool()) value.push(getNumber());
            if (checkIdent(pos).AsBool()) value.push(getIdent());

            value = value.concat(getSC());

            var end = getLastPosition(value, l, c, 1);
            var args = newNode(NodeType.ArgumentsType, value, l, c, end);
            content.push(args);

            // Skip `)`.
            pos++;

            return newNode(type, content, line, column);
        }

        public Node getPseudoClass5()
        {
            var type = NodeType.PseudocType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            // Skip `:`.
            pos++;

            content.push(getIdent());

            var l = tokens[pos].ln;
            var c = tokens[pos].col;
            var value = new List<Node>();

            // Skip `(`.
            pos++;

            value = value.concat(getSC());

            if (checkUnary(pos).AsBool()) value.push(getUnary());
            if (checkNumber(pos).AsBool()) value.push(getNumber());

            value = value.concat(getSC());

            var end = getLastPosition(value, l, c, 1);
            var args = newNode(NodeType.ArgumentsType, value, l, c, end);
            content.push(args);

            // Skip `)`.
            pos++;

            return newNode(type, content, line, column);
        }

        public Node getPseudoClass6()
        {
            var type = NodeType.PseudocType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;

            // Skip `:`.
            pos++;

            var content = new List<Node>(){ getIdent() };

            return newNode(type, content, line, column);
        }
    }

    public static class Extensions
    {
        public static void push<TSource>(this List<TSource> source, UnionList<TSource> item)
        {
            if (item.IsElement)
            {
                source.Add(item.AsT0);
            }
            else
            {
                source.AddRange(item.AsT1);
            }
        }

        public static bool Has<TSource>(this TSource[] source, int index)
        {
            return index < source.Length;
        }

        public static List<TSource> concat<TSource>(this List<TSource> source, params UnionList<TSource>[] second)
        {
            IEnumerable<TSource> list = source;
            foreach (var item in second)
            {
                if (item.IsElement)
                {
                    source.Add(item.AsT0);
                }
                else
                {
                    list = list.Concat(item.AsT1);
                }
                
            }

            return source;
        }

        public static char charAt(this string str, int index)
        {
            return str[index];
        }

        public static bool AsBool(this int value)
        {
            return value != 0;
        }
    }

    public static class Util
    {
        public static int Of(params int[] values)
        {
            foreach (var val in values)
            {
                if (val != 0) return val;
            }

            return 0;
        }
    }
}
