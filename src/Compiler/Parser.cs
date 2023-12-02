using static CssInCSharp.Compiler.Utility;
using static CssInCSharp.Compiler.Enum;
using System.Collections.Generic;
using CssInCSharp;

namespace CssInCSharp.Compiler
{
    public static class Parser
    {
        public static List<Element> Compile(string value)
        {
            var tokenizer = new Tokenizer(value);
            var rules = new List<string> {""};
            var rulesets = new List<Element>();
            var points = new List<int> {0};
            var result = Parse(tokenizer, "", null, null, null, rules, rulesets, 0, points, rulesets);
            return result;
        }

        public static List<Element> Parse(Tokenizer tokenizer, string value, Element root, Element parent, Element rule, List<string> rules, List<Element> rulesets, int pseudo, List<int> points, List<Element> declarations)
        {
            var index = 0;
            var offset = 0;
            var length = pseudo;
            var atrule = 0;
            var property = 0;
            var previous = 0;
            var variable = 1;
            var scanning = true;
            var ampersand = 1;
            var character = 0;
            var type = string.Empty;
            var props = rules;
            var children = rulesets;
            var reference = rule;
            var characters = string.Empty;
            while (scanning)
            {
                previous = character;
                character = tokenizer.Next();
                switch (character)
                {
                    case 40:
                        if (previous != 108 && CharAt(characters, length - 1) == 58)
                        {
                            if (IndexOf(characters += Replace(tokenizer.Delimit(character), "&", "&\f"), "&\f") != -1)
                                ampersand = -1;
                            break;
                        }
                        goto case -3;
                    case -3:
                    case 34 or 39 or 91:
                        characters += tokenizer.Delimit(character);
                        break;
                    case 9 or 10 or 13 or 32:
                        characters += tokenizer.WhiteSpace(previous);
                        break;
                    case 92:
                        var ss = tokenizer.Escaping(tokenizer.Caret() - 1, 7);
                        characters += ss;
                        continue;
                    case 47:
                        switch (tokenizer.Peek())
                        {
                            case 42 or 47:
                                Append(Comment(tokenizer, tokenizer.Commenter(tokenizer.Next(), tokenizer.Caret()), root, parent), declarations);
                                break;
                            default:
                                characters += "/";
                                break;
                        }
                        break;
                    case var x when x == 123 * variable:
                        points.SetValue(index++, Strlen(characters) * ampersand);
                        goto case -2;
                    case -2:
                    case var x when x == 125 * variable || x is 59 or 0:
                        switch (character)
                        {
                            case 0 or 125: scanning = false; goto case -1;
                            case -1:
                            case var y when y == 59 + offset:
                                if (ampersand == -1) characters = Replace(characters, "\f", "");
                                if (property > 0 && (Strlen(characters) - length) != 0)
                                    Append(property > 32 ? Declaration(tokenizer, characters + ';', rule, parent, length - 1) : Declaration(tokenizer, Replace(characters, " ", "") + ';', rule, parent, length - 2), declarations);
                                break;
                            case 59: characters += ";"; goto default;
                            default:
                                props = new List<string>();
                                children = new List<Element>();
                                Append(reference = Ruleset(tokenizer, characters, root, parent, index, offset, rules, points, type, props, children, length), rulesets);

                                if (character == 123)
                                    if (offset == 0)
                                        Parse(tokenizer, characters, root, reference, reference, props, rulesets, length, points, children);
                                    else
                                        switch (atrule == 99 && CharAt(characters, 3) == 110 ? 100 : atrule)
                                        {
                                            // d m s
                                            case 100 or 109 or 115:
                                                var p = new List<Element>();
                                                if (rule != null)
                                                {
                                                    rule = Append(Ruleset(tokenizer, value, reference, reference, 0, 0, rules, points, type, rules, p, length), children);
                                                }
                                                Parse(tokenizer, value, reference, reference, rule, rules, children, length, points, rule != null ? p : children);
                                                break;
        
                                            default:
                                                Parse(tokenizer, characters, reference, reference, reference, new List<string> {""}, children, 0, points, children);
                                                break;
        
                                        }
                                break;

                        }
                        index = offset = property = 0;
                        variable = ampersand = 1;
                        type = characters = "";
                        length = pseudo;
                        break;
                    case 58:
                        length = 1 + Strlen(characters);
                        property = previous;
                        goto default;
                    default:
                        if (variable < 1)
                            if (character == 123)
                                --variable;
                            else if (character == 125 && variable++ == 0 && tokenizer.Prev() == 125)
                                continue;
                        characters += From(character);
                        switch (character * variable)
                        {
                            // &
                            case 38:
                                ampersand = offset > 0 ? 1 : -1;
                                if (ampersand == -1) characters += "\f";
                                break;
                            // ,
                            case 44:
                                points.SetValue(index++, (Strlen(characters) - 1) * ampersand);
                                ampersand = 1;
                                break;
                            // @
                            case 64:
                                // -
                                if (tokenizer.Peek() == 45)
                                    characters += tokenizer.Delimit(tokenizer.Next());
                                atrule = tokenizer.Peek();
                                offset = length = Strlen(type = characters += tokenizer.Identifier(tokenizer.Caret()));
                                character++;
                                break;
                            // -
                            case 45:
                                if (previous == 45 && Strlen(characters) == 2)
                                    variable = 0;
                                break;
                        }
                        break;
                }
            }

            return rulesets;
        }

        public static Element Ruleset(Tokenizer tokenizer, string value, Element root, Element parent, int index, int offset, List<string> rules, List<int> points, string type, List<string> props, List<Element> children, int length)
        {
            var post = offset - 1;
            var rule = offset == 0 ? rules : new List<string>();
            var size = Sizeof(rule);
            for (int i = 0, j = 0, k = 0; i < index; ++i)
            {
                var y = Substr(value, post + 1, post = Abs(j = points[i]));
                for (var x = 0; x < size; ++x)
                {
                    var z = Trim(j > 0 ? rule[x] + " " + y : Replace(y, "&\f", rule[x], true));
                    if (!string.IsNullOrEmpty(z))
                    {
                        props.SetValue(k++, z);
                    }
                }
            }
            return tokenizer.Node(value, root, parent, offset == 0 ? RULESET : type, props, children, length);
        }

        public static Element Comment(Tokenizer tokenizer, string value, Element root, Element parent)
        {
            return tokenizer.Node(value, root, parent, COMMENT, From(tokenizer.Char()), Substr(value, 2, -2), 0);
        }

        public static Element Declaration(Tokenizer tokenizer, string value, Element root, Element parent, int length)
        {
            return tokenizer.Node(value, root, parent, DECLARATION, Substr(value, 0, length), Substr(value, length + 1, -1), length);
        }
    }
}
