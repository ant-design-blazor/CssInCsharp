namespace CssInCSharp.Ast.Sass
{
    public class Tokenizer
    {
        private List<Token> tokens = [];
        private bool urlMode = false;
        char c; // Current character
        char cn; // Next character
        int pos = 0;
        int tn = 0;
        int ln = 1;
        int col = 1;

        private Dictionary<string, string> Punctuation = new()
        {
            { " ", TokenType.Space },
            { "\n", TokenType.Newline },
            { "\r", TokenType.Newline },
            { "\t", TokenType.Tab },
            { "!", TokenType.ExclamationMark },
            { "\"", TokenType.QuotationMark },
            { "#", TokenType.NumberSign },
            { "$", TokenType.DollarSign },
            { "%", TokenType.PercentSign },
            { "&", TokenType.Ampersand },
            { "'", TokenType.Apostrophe },
            { "(", TokenType.LeftParenthesis },
            { ")", TokenType.RightParenthesis },
            { "*", TokenType.Asterisk },
            { "+", TokenType.PlusSign },
            { ",", TokenType.Comma },
            { "-", TokenType.HyphenMinus },
            { ".", TokenType.FullStop },
            { "/", TokenType.Solidus },
            { ",", TokenType.Colon },
            { ";", TokenType.Semicolon },
            { "<", TokenType.LessThanSign },
            { "=", TokenType.EqualsSign },
            { "==", TokenType.EqualitySign },
            { "!=", TokenType.InequalitySign },
            { ">", TokenType.GreaterThanSign },
            { "?", TokenType.QuestionMark },
            { "@", TokenType.CommercialAt },
            { "[", TokenType.LeftSquareBracket },
            { "]", TokenType.RightSquareBracket },
            { "^", TokenType.CircumflexAccent },
            { "_", TokenType.LowLine },
            { "{", TokenType.LeftCurlyBracket },
            { "|", TokenType.VerticalLine },
            { "}", TokenType.RightCurlyBracket },
            { "~", TokenType.Tilde },
            { "`", TokenType.Backtick },
        };

        /**
         * Add a token to the token list
         * @param {string} type
         * @param {string} value
         */
        public void pushToken(string type, string value, int column)
        {
            tokens.push(new Token()
            {
                tn = tn++,
                ln = ln,
                col = column,
                type = type,
                value = value
            });
        }

        /**
         * Check if a character is a decimal digit
         * @param {string} c Character
         * @returns {boolean}
         */
        public bool isDecimalDigit(char c)
        {
            return "0123456789".IndexOf(c) >= 0;
        }

        /**
         * Parse spaces
         * @param {string} css Unparsed part of CSS string
         */
        public void parseSpaces(string css)
        {
            var start = pos;

            // Read the string until we meet a non-space character:
            for (; pos < css.Length; pos++)
            {
                if (css.charAt(pos) != ' ') break;
            }

            // Add a substring containing only spaces to tokens:
            pushToken(TokenType.Space, css.substring(start, pos--), col);
            col += pos - start;
        }

        /**
         * Parse a string within quotes
         * @param {string} css Unparsed part of CSS string
         * @param {string} q Quote (either `'` or `"`)
         */
        public void parseString(string css, char q)
        {
            var start = pos;

            // Read the string until we meet a matching quote:
            for (pos++; pos < css.Length; pos++)
            {
                // Skip escaped quotes:
                if (css.charAt(pos) == '\\') pos++;
                else if (css.charAt(pos) == q) break;
            }

            // Add the string (including quotes) to tokens:
            var type = q == '"' ? TokenType.StringDQ : TokenType.StringSQ;
            pushToken(type, css.substring(start, pos + 1), col);
            col += pos - start;
        }

        /**
         * Parse numbers
         * @param {string} css Unparsed part of CSS string
         */
        public void parseDecimalNumber(string css)
        {
            var start = pos;

            // Read the string until we meet a character that's not a digit:
            for (; pos < css.Length; pos++)
            {
                if (!isDecimalDigit(css.charAt(pos))) break;
            }

            // Add the number to tokens:
            pushToken(TokenType.DecimalNumber, css.substring(start, pos--), col);
            col += pos - start;
        }

        /**
         * Parse identifier
         * @param {string} css Unparsed part of CSS string
         */
        public void parseIdentifier(string css)
        {
            var start = pos;

            // Skip all opening slashes:
            while (css.charAt(pos) == '/') pos++;

            // Read the string until we meet a punctuation mark:
            for (; pos < css.Length; pos++)
            {
                // Skip all '\':
                if (css.charAt(pos) == '\\') pos++;
                else if (Punctuation.ContainsKey(css.charAt(pos))) break;
            }

            var ident = css.substring(start, pos--);

            // Enter url mode if parsed substring is `url`:
            if (!urlMode && ident == "url" && css.charAt(pos + 1) == '(')
            {
                urlMode = true;
            }

            // Add identifier to tokens:
            pushToken(TokenType.Identifier, ident, col);
            col += pos - start;
        }

        /**
         * Parse equality sign
         */
        public void parseEquality()
        {
            pushToken(TokenType.EqualitySign, "==", col);
            pos++;
            col++;
        }

        /**
         * Parse inequality sign
         */
        public void parseInequality()
        {
            pushToken(TokenType.InequalitySign, "!=", col);
            pos++;
            col++;
        }

        /**
        * Parse a multiline comment
        * @param {string} css Unparsed part of CSS string
        */
        public void parseMLComment(string css)
        {
            var start = pos;
            var col_ = col;

            // Get current indent level:
            var il = 0;
            for (var _pos = pos - 1; _pos > -1; _pos--)
            {
                // TODO: Can be tabs:
                if (css.charAt(_pos) == ' ') il++;
                else break;
            }

            for (pos += 2; pos < css.Length; pos++)
            {
                var ch = css.charAt(pos);
                if (ch == '\n')
                {
                    var _pos = 0;
                    // Get new line's indent level:
                    var _il = 0;
                    for (_pos = pos + 1; _pos < css.Length; _pos++)
                    {
                        if (css.charAt(_pos) == ' ') _il++;
                        else break;
                    }

                    if (_il > il)
                    {
                        col = 0;
                        pos += _pos - pos;
                    }
                    else
                    {
                        pos--;
                        break;
                    }
                }
                else if (ch == '*' && css.charAt(pos + 1) == '/')
                {
                    pos++;
                    break;
                }
            }

            // If CRLF is used, we need to adjust pos
            if (css.charAt(pos) == '\r') pos--;

            // Add full comment (including `/*`) to the list of tokens:
            var comment = css.substring(start, pos + 1);
            pushToken(TokenType.CommentML, comment, col_);

            var newlines = comment.Split('\n');
            if (newlines.Length > 1)
            {
                ln += newlines.Length - 1;
                col = newlines[newlines.Length - 1].Length;
            }
            else
            {
                col += (pos - start);
            }
        }

        /**
        * Parse a single line comment
        * @param {string} css Unparsed part of CSS string
        */
        public void parseSLComment(string css)
        {
            var start = pos;
            var col_ = col;
            int _pos;

            // Check if comment is the only token on the line, and if so,
            // get current indent level:
            var il = 0;
            var onlyToken = false;
            for (_pos = pos - 1; _pos > -1; _pos--)
            {
                // TODO: Can be tabs:
                if (css.charAt(_pos) == ' ') il++;
                else if (css.charAt(_pos) == '\n')
                {
                    onlyToken = true;
                    break;
                }
                else break;
            }
            if (_pos == -1) onlyToken = true;

            // Read the string until we meet comment end.
            // Since we already know first 2 characters (`//`), start reading
            // from `pos + 2`:
            if (!onlyToken)
            {
                for (pos += 2; pos < css.Length; pos++)
                {
                    if (css.charAt(pos) == '\n' || css.charAt(pos) == '\r')
                    {
                        break;
                    }
                }
            }
            else
            {
                for (pos += 2; pos < css.Length; pos++)
                {
                    var ch = css.charAt(pos);
                    if (ch == '\n')
                    {
                        // Get new line's indent level:
                        var _il = 0;
                        for (_pos = pos + 1; _pos < css.Length; _pos++)
                        {
                            if (css.charAt(_pos) == ' ') _il++;
                            else break;
                        }

                        if (_il > il)
                        {
                            col = 0;
                            pos += _pos - pos;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            // If CRLF is used, we need to adjust pos
            if (css.charAt(pos - 1) == '\r') pos--;

            // Add comment (including `//` and line break) to the list of tokens:
            var comment = css.substring(start, pos--);
            pushToken(TokenType.CommentSL, comment, col_);

            var newlines = comment.Split('\n');
            if (newlines.Length > 1)
            {
                ln += newlines.Length - 1;
                col = newlines[newlines.Length - 1].Length;
            }
            else
            {
                col += (pos - start);
            }
        }

        /**
         * Convert a CSS string to a list of tokens
         * @param {string} css CSS string
         * @returns {Array} List of tokens
         * @private
         */
        public List<Token> getTokens(string css, int tabSize)
        {
            // Parse string, character by character:
            for (pos = 0; pos < css.Length; col++, pos++)
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
                    parseSLComment(css);
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

                // If current character is `=`, it must be combined with next `=`
                else if (c == '=' && cn == '=')
                {
                    parseEquality();
                }

                // If we meet `!=`, this must be inequality
                else if (c == '!' && cn == '=')
                {
                    parseInequality();
                }

                // If current character is a punctuation mark:
                else if (Punctuation.ContainsKey(c))
                {
                    // Check for CRLF here or just LF
                    if (c == '\r' && cn == '\n' || c == '\n')
                    {
                        // If \r we know the next character is \n due to statement above
                        // so we push a CRLF token type to the token list and importantly
                        // skip the next character so as not to double count newlines or
                        // columns etc
                        if (c == '\r')
                        {
                            pushToken(TokenType.Newline, "\r\n", col);
                            pos++; // If CRLF skip the next character and push crlf token
                        }
                        else if (c == '\n')
                        {
                            // If just a LF newline and not part of CRLF newline we can just
                            // push punctuation as usual
                            pushToken(Punctuation[$"{c}"], $"{c}", col);
                        }

                        ln++; // Go to next line
                        col = 0; // Reset the column count
                    }
                    else if (c != '\r' && c != '\n')
                    {
                        // Handle all other punctuation and add to list of tokens
                        pushToken(Punctuation[$"{c}"], $"{c}", col);
                    }// Go to next line
                    if (c == ')') urlMode = false; // Exit url mode
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
    }
}
