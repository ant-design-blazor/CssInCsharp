using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CssInCSharp.Ast.Css
{
    public class Tokenizer
    {
        private List<Token> tokens = [];
        private bool urlMode = false;
        private int blockMode = 0;
        private int pos = 0;
        private int tn = 0;
        private int ln = 1;
        private int col = 1;
        private int cssLength = 0;

        public List<Token> getTokens(string css, int tabSize)
        {
            char c; // Current character
            char cn; // Next character

            cssLength = css.Length;

            // Parse string, character by character:
            for (pos = 0; pos < cssLength; col++, pos++)
            {
                c = css.charAt(pos);
                cn = css.charAt(pos + 1);

                // If we meet `/*`, it's a start of a multiline comment.
                // Parse following characters as a multiline comment:
                if (c == '/' && cn == '*')
                {
                    parseMLComment(css);
                }

                // If we meet `//` and it is not a part of url:
                else if (!urlMode && c == '/' && cn == '/')
                {
                    // If we're currently inside a block, treat `//` as a start
                    // of identifier. Else treat `//` as a start of a single-line
                    // comment:
                    if (blockMode > 0) parseIdentifier(css);
                    else parseSLComment(css);
                }

                // If current character is a double or single quote, it's a start
                // of a string:
                else if (c == '"' || c == '\'')
                {
                    parseString(css, c);
                }

                // If current character is a space:
                else if (c == ' ')
                {
                    parseSpaces(css);
                }

                // If current character is a punctuation mark:
                else if (Punctuation[c])
                {
                    // Add it to the list of tokens:
                    pushToken(Punctuation[c], c, col);
                    if (c == '\n' || c == '\r')
                    {
                        ln++;
                        col = 0;
                    } // Go to next line
                    else if (c == ')') urlMode = false; // Exit url mode
                    else if (c == '{') blockMode++; // Enter a block
                    else if (c == '}') blockMode--; // Exit a block
                    else if (c == '\t' && tabSize > 1) col += (tabSize - 1);
                }

                // If current character is a decimal digit:
                else if (isDecimalDigit(c))
                {
                    parseDecimalNumber(css);
                }

                // If current character is anything else:
                else
                {
                    parseIdentifier(css);
                }
            }

            return tokens;
        }

        private void pushToken(string type, char value, int column)
        {
            tokens.push(new Token{
                tn = tn++,
                ln = ln,
                col = column,
                type = type,
                value = $"{value}"
            });
        }

        private bool isDecimalDigit(char c)
        {
            return "0123456789".IndexOf(c) >= 0;
        }
    }
}
