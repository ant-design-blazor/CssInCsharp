namespace CssInCSharp.Ast.Sass
{
    public class Mark
    {
        /**
        * Mark whitespaces and comments
        */
        public void markSC(List<Token> tokens)
        {
            var tokensLength = tokens.Count;
            var ws = -1; // Flag for whitespaces
            var sc = -1; // Flag for whitespaces and comments
            Token t; // Current token

            // For every token in the token list, mark spaces and line breaks
            // as spaces (set both `ws` and `sc` flags). Mark multiline comments
            // with `sc` flag.
            // If there are several spaces or tabs or line breaks or multiline
            // comments in a row, group them: take the last one's index number
            // and save it to the first token in the group as a reference:
            // e.g., `ws_last = 7` for a group of whitespaces or `sc_last = 9`
            // for a group of whitespaces and comments.
            var i = 0;
            for (; i < tokensLength; i++)
            {
                t = tokens[i];
                switch (t.type)
                {
                    case TokenType.Space:
                    case TokenType.Tab:
                        t.ws = true;
                        t.sc = true;

                        if (ws == -1) ws = i;
                        if (sc == -1) sc = i;

                        break;
                    case TokenType.Newline:
                        t.ws = true;
                        t.sc = true;

                        ws = ws == -1 ? i : ws;
                        sc = sc == -1 ? i : ws;

                        tokens[ws].ws_last = i - 1;
                        tokens[sc].sc_last = i - 1;
                        tokens[i].ws_last = i;
                        tokens[i].sc_last = i;

                        ws = -1;
                        sc = -1;

                        break;
                    case TokenType.CommentML:
                    case TokenType.CommentSL:
                        if (ws != -1)
                        {
                            tokens[ws].ws_last = i - 1;
                            ws = -1;
                        }

                        t.sc = true;

                        break;
                    default:
                        if (ws != -1)
                        {
                            tokens[ws].ws_last = i - 1;
                            ws = -1;
                        }

                        if (sc != -1)
                        {
                            tokens[sc].sc_last = i - 1;
                            sc = -1;
                        }
                        break;
                }
            }

            if (ws != -1) tokens[ws].ws_last = i - 1;
            if (sc != -1) tokens[sc].sc_last = i - 1;
        }

        /**
        * Pair brackets
        */
        public void markBrackets(List<Token> tokens)
        {
            var tokensLength = tokens.Count;
            List<int> ps = []; // Parentheses
            List<int> sbs = []; // Square brackets
            List<int> cbs = []; // Curly brackets
            Token t; // Current token

            // For every token in the token list, if we meet an opening (left)
            // bracket, push its index number to a corresponding array.
            // If we then meet a closing (right) bracket, look at the corresponding
            // array. If there are any elements (records about previously met
            // left brackets), take a token of the last left bracket (take
            // the last index number from the array and find a token with
            // this index number) and save right bracket's index as a reference:
            for (var i = 0; i < tokensLength; i++)
            {
                t = tokens[i];
                switch (t.type)
                {
                    case TokenType.LeftParenthesis:
                        ps.push(i);
                        break;
                    case TokenType.RightParenthesis:
                        if (ps.Count.AsBool())
                        {
                            t.left = ps.pop();
                            tokens[t.left].right = i;
                        }
                        break;
                    case TokenType.LeftSquareBracket:
                        sbs.push(i);
                        break;
                    case TokenType.RightSquareBracket:
                        if (sbs.Count.AsBool())
                        {
                            t.left = sbs.pop();
                            tokens[t.left].right = i;
                        }
                        break;
                    case TokenType.LeftCurlyBracket:
                        cbs.push(i);
                        break;
                    case TokenType.RightCurlyBracket:
                        if (cbs.Count.AsBool())
                        {
                            t.left = cbs.pop();
                            tokens[t.left].right = i;
                        }
                        break;
                }
            }
        }

        public void markBlocks(List<Token> tokens)
        {
            int i = 0;
            int l = tokens.Count;
            List<int[]> lines = [];
            List<int> whitespaceOnlyLines = [];

            for (i = 0; i < l; i++)
            {
                var lineStart = i;
                var currentLineIndent = 0;

                // Get all spaces.
                while (i < l && (tokens[i].type == TokenType.Space ||
                    tokens[i].type == TokenType.Tab))
                {
                    currentLineIndent += tokens[i].value.Length;
                    i++;
                }

                lines.Add([lineStart, currentLineIndent]);

                var x = i;
                while (i < l && tokens[i].type != TokenType.Newline)
                {
                    i++;
                }

                if (x == i)
                {
                    whitespaceOnlyLines.push(lines.Count - 1);
                }
            }

            List<int> levels = [0];
            List<int> blockStarts = [];

            for (i = 0; i < lines.Count; i++)
            {
                var line = lines[i];
                var token = line[0];
                var indent = line[1];
                var lastLevel = levels[levels.Count - 1];

                if (indent > lastLevel)
                {
                    blockStarts.push(token);
                    levels.push(indent);
                }
                else
                {
                    // Check if line is whitespace-only.
                    var p = i;

                    while (true)
                    {
                        if (whitespaceOnlyLines.IndexOf(p) == -1) break;
                        p++;
                    }

                    if (i == p && indent == lastLevel) continue;

                    if (!lines.Has(p))
                    {
                        continue;
                    }

                    indent = lines[p][1];

                    if (indent == lastLevel)
                    {
                        i = p;
                        continue;
                    }

                    if (indent > lastLevel)
                    {
                        blockStarts.push(token);
                        levels.push(lines[p][1]);
                        i = p;
                        continue;
                    }

                    while (true)
                    {
                        lastLevel = levels.pop();
                        if (indent < lastLevel)
                        {
                            var start = blockStarts.pop();
                            tokens[start].block_end = token - 1;
                        }
                        else
                        {
                            levels.push(indent);
                            break;
                        }
                    }
                }
            }

            blockStarts.ForEach(start => {
                tokens[start].block_end = tokens.Count - 1;
            });
        }

        public void markTokens(List<Token> tokens)
        {
            markBrackets(tokens);
            markSC(tokens);
            markBlocks(tokens);
        }
    }
}
