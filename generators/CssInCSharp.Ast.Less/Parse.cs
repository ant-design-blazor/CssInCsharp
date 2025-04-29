using static CssInCSharp.Ast.Util;

namespace CssInCSharp.Ast.Less
{
    public class Parse
    {
        private Token[] tokens;
        private int tokensLength;
        private int pos;

        public Parse(Token[] tokens)
        {
            this.tokens = tokens;
            tokensLength = tokens.Length;
            pos = 0;
        }

        public Node stylesheet()
        {
            if (checkStylesheet(pos).AsBool())
            {
                return getStylesheet();
            }

            return null;
        }

        /**
         * Stop parsing and display error
         * @param {Number=} i Token's index number
         */
        public void throwError(int i)
        {
            var ln = tokens[i].ln;

            throw new Exception($"line: {ln}, syntax: less");
        }

        /**
         * @param {Object} exclude
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int checkExcluding(Dictionary<string, int> exclude, int i)
        {
            var start = i;

            while (i < tokensLength)
            {
                if (exclude[tokens[i++].type].AsBool()) break;
            }

            return i - start - 2;
        }

        /**
         * @param {Number} start
         * @param {Number} finish
         * @returns {String}
         */
        public string joinValues(int start, int finish)
        {
            var s = "";

            for (var i = start; i < finish + 1; i++)
            {
                s += tokens[i].value;
            }

            return s;
        }

        /**
         * @param {Number} start
         * @param {Number} num
         * @returns {String}
         */
        public string joinValues2(int start, int num)
        {
            if (start + num - 1 >= tokensLength) return null;

            var s = "";

            for (var i = 0; i < num; i++)
            {
                s += tokens[start + i].value;
            }

            return s;
        }

        public int[] getLastPosition(Content content, int line, int column, int? colOffset = null)
        {
            return content.IsString ?
                getLastPositionForString(content.AsString, line, column, colOffset) :
                getLastPositionForArray(content.AsArray, line, column, colOffset);
        }

        public int[] getLastPositionForString(string? content, int line, int column, int? colOffset)
        {
            var position = new int[2];

            if (content != null)
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

        public int[] getLastPositionForArray(List<Node> content, int line, int column, int? colOffset)
        {
            int[] position;

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
            return new Node(new NodeOptions
            {
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
                syntax = "less"
            });
        }

        /**
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int checkAny(int i)
        {
            int l;

            if ((l = checkBrackets(i)).AsBool()) tokens[i].any_child = 1;
            else if ((l = checkParentheses(i)).AsBool()) tokens[i].any_child = 2;
            else if ((l = checkString(i)).AsBool()) tokens[i].any_child = 3;
            else if ((l = checkVariablesList(i)).AsBool()) tokens[i].any_child = 4;
            else if ((l = checkVariable(i)).AsBool()) tokens[i].any_child = 5;
            else if ((l = checkPercentage(i)).AsBool()) tokens[i].any_child = 6;
            else if ((l = checkDimension(i)).AsBool()) tokens[i].any_child = 7;
            else if ((l = checkUnicodeRange(i)).AsBool()) tokens[i].any_child = 15;
            else if ((l = checkNumber(i)).AsBool()) tokens[i].any_child = 8;
            else if ((l = checkUri(i)).AsBool()) tokens[i].any_child = 9;
            else if ((l = checkExpression(i)).AsBool()) tokens[i].any_child = 10;
            else if ((l = checkFunction(i)).AsBool()) tokens[i].any_child = 11;
            else if ((l = checkIdent(i)).AsBool()) tokens[i].any_child = 12;
            else if ((l = checkClass(i)).AsBool()) tokens[i].any_child = 13;
            else if ((l = checkUnary(i)).AsBool()) tokens[i].any_child = 14;

            return l;
        }

        /**
         * @returns {Array}
         */
        public Node getAny()
        {
            var childType = tokens[pos].any_child;

            if (childType == 1) return getBrackets();
            if (childType == 2) return getParentheses();
            if (childType == 3) return getString();
            if (childType == 4) return getVariablesList();
            if (childType == 5) return getVariable();
            if (childType == 6) return getPercentage();
            if (childType == 7) return getDimension();
            if (childType == 15) return getUnicodeRange();
            if (childType == 8) return getNumber();
            if (childType == 9) return getUri();
            if (childType == 10) return getExpression();
            if (childType == 11) return getFunction();
            if (childType == 12) return getIdent();
            if (childType == 13) return getClass();
            if (childType == 14) return getUnary();

            return default;
        }

        /**
         * Check if token is part of mixin's arguments.
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int checkArguments(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength ||
                tokens[i].type != TokenType.LeftParenthesis) return 0;

            // Skip `(`.
            i++;

            while (i < tokens[start].right)
            {
                if ((l = checkArgument(i)).AsBool()) i += l;
                else return 0;
            }

            return tokens[start].right - start + 1;
        }

        /**
         * @returns {Array}
         */
        public Node getArguments()
        {
            var type = NodeType.ArgumentsType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();
            UnionList<Node> body;

            // Skip `(`.
            pos++;

            while (pos < tokensLength &&
                tokens[pos].type != TokenType.RightParenthesis)
            {
                if (checkDeclaration(pos).AsBool()) content.push(getDeclaration());
                else if (checkArgument(pos).AsBool())
                {
                    body = getArgument();
                    if (body.IsElement && body.AsT0.content.IsString) content.push(body);
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

        /**
         * Check if token is valid to be part of arguments list.
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int checkArgument(int i)
        {
            int l;

            if ((l = checkEscapedString(i)).AsBool()) tokens[i].argument_child = 1;
            else if ((l = checkDeclaration(i)).AsBool()) tokens[i].argument_child = 2;
            else if ((l = checkVariablesList(i)).AsBool()) tokens[i].argument_child = 3;
            else if ((l = checkVariable(i)).AsBool()) tokens[i].argument_child = 4;
            else if ((l = checkSC(i)).AsBool()) tokens[i].argument_child = 5;
            else if ((l = checkUnary(i)).AsBool()) tokens[i].argument_child = 6;
            else if ((l = checkOperator(i)).AsBool()) tokens[i].argument_child = 7;
            else if ((l = checkDelim(i)).AsBool()) tokens[i].argument_child = 8;
            else if ((l = checkDeclDelim(i)).AsBool()) tokens[i].argument_child = 9;
            else if ((l = checkString(i)).AsBool()) tokens[i].argument_child = 10;
            else if ((l = checkPercentage(i)).AsBool()) tokens[i].argument_child = 11;
            else if ((l = checkDimension(i)).AsBool()) tokens[i].argument_child = 12;
            else if ((l = checkNumber(i)).AsBool()) tokens[i].argument_child = 13;
            else if ((l = checkUri(i)).AsBool()) tokens[i].argument_child = 14;
            else if ((l = checkFunction(i)).AsBool()) tokens[i].argument_child = 15;
            else if ((l = checkIdent(i)).AsBool()) tokens[i].argument_child = 16;
            else if ((l = checkVhash(i)).AsBool()) tokens[i].argument_child = 17;
            else if ((l = checkBlock(i)).AsBool()) tokens[i].argument_child = 18;
            else if ((l = checkParentheses(i)).AsBool()) tokens[i].argument_child = 19;

            return l;
        }

        /**
         * @returns {Array} Node that is part of arguments list.
         */
        public UnionList<Node> getArgument()
        {
            var childType = tokens[pos].argument_child;

            if (childType == 1) return getEscapedString();
            if (childType == 2) return getDeclaration();
            if (childType == 3) return getVariablesList();
            if (childType == 4) return getVariable();
            if (childType == 5) return getSC();
            if (childType == 6) return getUnary();
            if (childType == 7) return getOperator();
            if (childType == 8) return getDelim();
            if (childType == 9) return getDeclDelim();
            if (childType == 10) return getString();
            if (childType == 11) return getPercentage();
            if (childType == 12) return getDimension();
            if (childType == 13) return getNumber();
            if (childType == 14) return getUri();
            if (childType == 15) return getFunction();
            if (childType == 16) return getIdent();
            if (childType == 17) return getVhash();
            if (childType == 18) return getBlock();
            if (childType == 19) return getParentheses();

            return default;
        }

        /**
         * Check if token is part of an @-word (e.g. `@import`, `@include`)
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int checkAtkeyword(int i)
        {
            int l;

            // Check that token is `@`:
            if (i >= tokensLength ||
                tokens[i++].type != TokenType.CommercialAt) return 0;

            return ((l = checkIdent(i)).AsBool()) ? l + 1 : 0;
        }

        /**
         * Get node with @-word
         * @returns {Array} `['atkeyword', ['ident', x]]` where `x` is
         *      an identifier without
         *      `@` (e.g. `import`, `include`)
         */
        public Node getAtkeyword()
        {
            var type = NodeType.AtkeywordType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;

            // Skip `@`.
            pos++;

            var content = new List<Node>() { getIdent() };

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is a part of an @-rule
         * @param {Number} i Token's index number
         * @returns {Number} Length of @-rule
         */
        public int checkAtrule(int i)
        {
            int l;

            if (i >= tokensLength) return 0;

            // If token already has a record of being part of an @-rule,
            // return the @-rule's length:
            if (tokens[i].atrule_l != null) return tokens[i].atrule_l.Value;

            // If token is part of an @-rule, save the rule's type to token.
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

        /**
         * Get node with @-rule
         * @returns {Array}
         */
        public Node getAtrule()
        {
            var childType = tokens[pos].atrule_type;

            if (childType == 1) return getAtruler(); // @-rule with ruleset
            if (childType == 2) return getAtruleb(); // Block @-rule
            if (childType == 3) return getAtrules(); // Single-line @-rule
            if (childType == 4) return getKeyframesRule();

            return default;
        }

        /**
         * Check if token is part of a block @-rule
         * @param {Number} i Token's index number
         * @returns {Number} Length of the @-rule
         */
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

        /**
         * Get node with a block @-rule
         * @returns {Array} `['atruleb', ['atkeyword', x], y, ['block', z]]`
         */
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

        /**
         * Check if token is part of an @-rule with ruleset
         * @param {Number} i Token's index number
         * @returns {Number} Length of the @-rule
         */
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

        /**
         * Get node with an @-rule with ruleset
         * @returns {Array} ['atruler', ['atkeyword', x], y, z]
         */
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

        /**
         * @param {Number} i Token's index number
         * @returns {Number}
         */
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

        /**
         * @returns {Array} `['atrulers', x]`
         */
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

        /**
         * @param {Number} i Token's index number
         * @returns {Number}
         */
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

        /**
         * @returns {Array} `['atrules', ['atkeyword', x], y]`
         */
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

        /**
         * Check if token is part of a block (e.g. `{...}`).
         * @param {Number} i Token's index number
         * @returns {Number} Length of the block
         */
        public int checkBlock(int i)
        {
            return i < tokensLength && tokens[i].type == TokenType.LeftCurlyBracket ?
                tokens[i].right - i + 1 : 0;
        }

        /**
         * Get node with a block
         * @returns {Array} `['block', x]`
         */
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

        /**
         * Check if token is part of a declaration (property-value pair)
         * @param {Number} i Token's index number
         * @returns {Number} Length of the declaration
         */
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

        /**
         * @returns {Array}
         */
        public List<Node> getBlockdecl()
        {
            var childType = tokens[pos].bd_type;

            if (childType == 1) return getBlockdecl1();
            if (childType == 2) return getBlockdecl2();
            if (childType == 3) return getBlockdecl3();
            if (childType == 4) return getBlockdecl4();

            return default;
        }

        /**
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int checkBlockdecl1(int i)
        {
            var start = i;
            int l;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkCondition(i)).AsBool()) tokens[i].bd_kind = 1;
            else if ((l = checkExtend(i)).AsBool()) tokens[i].bd_kind = 6;
            else if ((l = checkRuleset(i)).AsBool()) tokens[i].bd_kind = 2;
            else if ((l = checkDeclaration(i)).AsBool()) tokens[i].bd_kind = 3;
            else if ((l = checkAtrule(i)).AsBool()) tokens[i].bd_kind = 4;
            else if ((l = checkInclude(i)).AsBool()) tokens[i].bd_kind = 5;
            else return 0;

            i += l;

            if (i < tokensLength && (l = checkDeclDelim(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * @returns {Array}
         */
        public List<Node> getBlockdecl1()
        {
            var sc = getSC();
            Node content = null;

            switch (tokens[pos].bd_kind)
            {
                case 1:
                    content = getCondition();
                    break;
                case 2:
                    content = getRuleset();
                    break;
                case 3:
                    content = getDeclaration();
                    break;
                case 4:
                    content = getAtrule();
                    break;
                case 5:
                    content = getInclude();
                    break;
                case 6:
                    content = getExtend();
                    break;
            }

            return sc.concat(
              content,
              getDeclDelim(),
              getSC()
            );
        }

        /**
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int checkBlockdecl2(int i)
        {
            var start = i;
            int l;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkCondition(i)).AsBool()) tokens[i].bd_kind = 1;
            else if ((l = checkExtend(i)).AsBool()) tokens[i].bd_kind = 3;
            else if ((l = checkRuleset(i)).AsBool()) tokens[i].bd_kind = 6;
            else if ((l = checkDeclaration(i)).AsBool()) tokens[i].bd_kind = 4;
            else if ((l = checkAtrule(i)).AsBool()) tokens[i].bd_kind = 5;
            else if ((l = checkInclude(i)).AsBool()) tokens[i].bd_kind = 2;
            else return 0;

            i += l;

            if ((l = checkSC(i)).AsBool()) i += l;

            return i - start;
        }

        /**
         * @returns {Array}
         */
        public List<Node> getBlockdecl2()
        {
            var sc = getSC();
            Node content = null;

            switch (tokens[pos].bd_kind)
            {
                case 1:
                    content = getCondition();
                    break;
                case 2:
                    content = getInclude();
                    break;
                case 3:
                    content = getExtend();
                    break;
                case 4:
                    content = getDeclaration();
                    break;
                case 5:
                    content = getAtrule();
                    break;
                case 6:
                    content = getRuleset();
                    break;
            }

            return sc.concat(
              content,
              getSC()
            );
        }

        /**
         * @param {Number} i Token's index number
         * @returns {Number}
         */
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

        /**
         * @returns {Array} `[s0, ['declDelim'], s1]` where `s0` and `s1` are
         *      are optional whitespaces.
         */
        public List<Node> getBlockdecl3()
        {
            return new List<Node>().concat(
              getSC(),
              getDeclDelim(),
              getSC()
            );
        }

        /**
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int checkBlockdecl4(int i)
        {
            return checkSC(i);
        }

        /**
         * @returns {Array}
         */
        public List<Node> getBlockdecl4()
        {
            return getSC();
        }

        /**
         * Check if token is part of text inside square brackets, e.g. `[1]`
         * @param {Number} i Token's index number
         * @returns {Number}
         */
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

        /**
         * Get node with text inside square brackets, e.g. `[1]`
         * @returns {Node}
         */
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

        /**
         * Check if token is part of a class selector (e.g. `.abc`)
         * @param {Number} i Token's index number
         * @returns {Number} Length of the class selector
         */
        public int checkClass(int i)
        {
            int l;

            if (i >= tokensLength) return 0;

            if (tokens[i].class_l.AsBool()) return tokens[i].class_l;

            if (tokens[i++].type == TokenType.FullStop)
            {
                if ((l = checkInterpolatedVariable(i)).AsBool()) tokens[i].class_child = 1;
                else if ((l = checkIdent(i)).AsBool()) tokens[i].class_child = 2;
                else return 0;

                tokens[i].class_l = l + 1;
                return l + 1;
            }

            return 0;
        }

        /**
         * Get node with a class selector
         * @returns {Array} `['class', ['ident', x]]` where x is a class's
         *      identifier (without `.`, e.g. `abc`).
         */
        public Node getClass()
        {
            var type = NodeType.ClassType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            // Skip `.`
            pos++;

            var childType = tokens[pos].class_child;
            if (childType == 1) content.push(getInterpolatedVariable());
            else content.push(getIdent());

            return newNode(type, content, line, column);
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

        public Node getCombinator()
        {
            var type = tokens[pos].combinatorType;
            if (type == 1) return getCombinator1();
            if (type == 2) return getCombinator2();
            if (type == 3) return getCombinator3();
            if (type == 4) return getCombinator4();

            return default;
        }


        /**
         * (1) `>>>`
         *
         * @param {Number} i
         * @return {Number}
         */
        public int checkCombinator1(int i)
        {
            if (i < tokensLength && tokens[i++].type == TokenType.GreaterThanSign &&
                i < tokensLength && tokens[i++].type == TokenType.GreaterThanSign &&
                i < tokensLength && tokens[i++].type == TokenType.GreaterThanSign)
                return 3;

            return 0;
        }

        /**
         * @return {Node}
         */
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

        /**
         * (1) `||`
         * (2) `>>`
         *
         * @param {Number} i
         * @return {Number}
         */
        public int checkCombinator2(int i)
        {
            if (i + 1 >= tokensLength) return 0;

            if (tokens[i].type == TokenType.VerticalLine &&
                tokens[i + 1].type == TokenType.VerticalLine) return 2;

            if (tokens[i].type == TokenType.GreaterThanSign &&
                tokens[i + 1].type == TokenType.GreaterThanSign) return 2;

            return 0;
        }

        /**
         * @return {Node}
         */
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

        /**
         * (1) `>`
         * (2) `+`
         * (3) `~`
         *
         * @param {Number} i
         * @return {Number}
         */
        public int checkCombinator3(int i)
        {
            var type = tokens[i].type;
            if (type == TokenType.PlusSign ||
                type == TokenType.GreaterThanSign ||
                type == TokenType.Tilde) return 1;
            else return 0;
        }

        /**
         * @return {Node}
         */
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

        /**
         * (1) `/panda/`
         */
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

        /**
         * @return {Node}
         */
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

            var content = $"/${ident.content}/";

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is a multiline comment.
         * @param {Number} i Token's index number
         * @returns {Number} `1` if token is a multiline comment, otherwise `0`
         */
        public int checkCommentML(int i)
        {
            return i < tokensLength && tokens[i].type == TokenType.CommentML ? 1 : 0;
        }

        /**
         * Get node with a multiline comment
         * @returns {Array} `['commentML', x]` where `x`
         *      is the comment's text (without `/*` and `* /`).
         */
        public Node getCommentML()
        {
            var type = NodeType.CommentMLType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = tokens[pos].value.substring(2);
            var l = content.Length;

            if (content.charAt(l - 2) == '*' && content.charAt(l - 1) == '/')
                content = content.substring(0, l - 2);

            var end = getLastPosition(content, line, column, 2);
            if (end[0] == line) end[1] += 2;
            pos++;

            return newNode(type, content, line, column, end);
        }

        /**
         * Check if token is part of a single-line comment.
         * @param {Number} i Token's index number
         * @returns {Number} `1` if token is a single-line comment, otherwise `0`
         */
        public int checkCommentSL(int i)
        {
            return i < tokensLength && tokens[i].type == TokenType.CommentSL ? 1 : 0;
        }

        /**
         * Get node with a single-line comment.
         * @returns {Array}
         */
        public Node getCommentSL()
        {
            var type = NodeType.CommentSLType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = tokens[pos++].value.substring(2);
            var end = getLastPosition(content, line, column + 2);

            return newNode(type, content, line, column, end);
        }

        /**
         * Check if token is part of a condition.
         * @param {Number} i Token's index number
         * @return {Number} Length of the condition
         */
        public int checkCondition(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkIdent(i)).AsBool() && tokens[i].value == "when") i += l;
            else return 0;

            while (i < tokensLength)
            {
                if ((l = checkBlock(i)).AsBool())
                {
                    tokens[i].condition_child = 0;
                    break;
                }
                else if ((l = checkFunction(i)).AsBool()) tokens[i].condition_child = 1;
                else if ((l = checkBrackets(i)).AsBool()) tokens[i].condition_child = 2;
                else if ((l = checkParentheses(i)).AsBool()) tokens[i].condition_child = 3;
                else if ((l = checkVariable(i)).AsBool()) tokens[i].condition_child = 4;
                else if ((l = checkIdent(i)).AsBool()) tokens[i].condition_child = 5;
                else if ((l = checkNumber(i)).AsBool()) tokens[i].condition_child = 6;
                else if ((l = checkDelim(i)).AsBool()) tokens[i].condition_child = 7;
                else if ((l = checkOperator(i)).AsBool()) tokens[i].condition_child = 8;
                else if ((l = checkCombinator(i)).AsBool()) tokens[i].condition_child = 9;
                else if ((l = checkSC(i)).AsBool()) tokens[i].condition_child = 10;
                else if ((l = checkString(i)).AsBool()) tokens[i].condition_child = 11;
                else return 0;

                i += l;
            }

            return i - start;
        }

        /**
         * Get node with a condition.
         * @returns {Array} `['condition', x]`
         */
        public Node getCondition()
        {
            var type = NodeType.ConditionType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            content.push(getIdent());

            while (pos < tokensLength)
            {
                var childType = tokens[pos].condition_child;

                if (childType == 0) break;
                else if (childType == 1) content.push(getFunction());
                else if (childType == 2) content.push(getBrackets());
                else if (childType == 3) content.push(getParentheses());
                else if (childType == 4) content.push(getVariable());
                else if (childType == 5) content.push(getIdent());
                else if (childType == 6) content.push(getNumber());
                else if (childType == 7) content.push(getDelim());
                else if (childType == 8) content.push(getOperator());
                else if (childType == 9) content.push(getCombinator());
                else if (childType == 10) content = content.concat(getSC());
                else if (childType == 11) content.push(getString());
            }

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is part of a declaration (property-value pair)
         * @param {Number} i Token's index number
         * @returns {Number} Length of the declaration
         */
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

        /**
         * Get node with a declaration
         * @returns {Array} `['declaration', ['property', x], ['propertyDelim'],
         *       ['value', y]]`
         */
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

        /**
         * Check if token is a semicolon
         * @param {Number} i Token's index number
         * @returns {Number} `1` if token is a semicolon, otherwise `0`
         */
        public int checkDeclDelim(int i)
        {
            return i < tokensLength && tokens[i].type == TokenType.Semicolon ? 1 : 0;
        }

        /**
         * Get node with a semicolon
         * @returns {Array} `['declDelim']`
         */
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

        /**
         * Check if token is a comma
         * @param {Number} i Token's index number
         * @returns {Number} `1` if token is a comma, otherwise `0`
         */
        public int checkDelim(int i)
        {
            return i < tokensLength && tokens[i].type == TokenType.Comma ? 1 : 0;
        }

        /**
         * Get node with a comma
         * @returns {Array} `['delim']`
         */
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

        /**
         * Check if token is part of a number with dimension unit (e.g. `10px`)
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int checkDimension(int i)
        {
            var ln = checkNumber(i);
            int li;

            if (i >= tokensLength ||
                !ln.AsBool() ||
                i + ln >= tokensLength) return 0;

            return (li = checkUnit(i + ln)).AsBool() ? ln + li : 0;
        }

        /**
         * Get node of a number with dimension unit
         * @return {Node}
         */
        public Node getDimension()
        {
            var type = NodeType.DimensionType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>
            {
                getNumber(),
                getUnit()
            };

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is part of an escaped string (e.g. `~"ms:something"`).
         * @param {Number} i Token's index number
         * @returns {Number} Length of the string (including `~` and quotes)
         */
        public int checkEscapedString(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if (tokens[i].type == TokenType.Tilde && (l = checkString(i + 1)).AsBool())
                return i + l - start;
            else return 0;
        }

        /**
         * Get node with an escaped string
         * @returns {Array} `['escapedString', ['string', x]]` where `x` is a string
         *      without `~` but with quotes
         */
        public Node getEscapedString()
        {
            var type = NodeType.EscapedStringType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;

            pos++;

            var content = tokens[pos].value;
            var end = getLastPosition(content, line, column + 1);

            pos++;

            return newNode(type, content, line, column, end);
        }

        /**
         * @param {Number} i Token's index number
         * @returns {Number}
         */
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

        /**
         * @returns {Array}
         */
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

        public int checkExtend(int i)
        {
            if (i >= tokensLength) return 0;

            int l;

            if ((l = checkExtend1(i)).AsBool()) tokens[i].extendType = 1;
            else if ((l = checkExtend2(i)).AsBool()) tokens[i].extendType = 2;
            else return 0;

            return l;
        }

        public Node getExtend()
        {
            var childType = tokens[pos].extendType;

            if (childType == 1) return getExtend1();
            if (childType == 2) return getExtend2();

            return default;
        }

        /**
         * (1) `selector:extend(selector) {...}`
         */
        public int checkExtend1(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkExtendSelector(i)).AsBool()) i += l;
            else return 0;

            if (tokens.Has(i + 1) &&
                tokens[i + 1].value == "extend" &&
                (l = checkPseudoc(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkBlock(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        public Node getExtend1()
        {
            var type = NodeType.ExtendType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
              getExtendSelector(),
              getPseudoc(),
              getSC(),
              getBlock()
            );

            return newNode(type, content, line, column);
        }

        /**
         * (1) `selector:extend(selector)`
         */
        public int checkExtend2(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkExtendSelector(i)).AsBool()) i += l;
            else return 0;

            if (tokens.Has(i + 1) &&
                tokens[i + 1].value == "extend" &&
                (l = checkPseudoc(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        public Node getExtend2()
        {
            var type = NodeType.ExtendType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
              getExtendSelector(),
              getPseudoc()
            );

            return newNode(type, content, line, column);
        }

        public int checkExtendSelector(int i)
        {
            int l;

            if ((l = checkParentSelectorWithExtension(i)).AsBool()) tokens[i].extend_type = 1;
            else if ((l = checkIdent(i)).AsBool()) tokens[i].extend_type = 2;
            else if ((l = checkClass(i)).AsBool()) tokens[i].extend_type = 3;
            else if ((l = checkShash(i)).AsBool()) tokens[i].extend_type = 4;

            return l;
        }

        public List<Node> getExtendSelector()
        {
            var childType = tokens[pos].extend_type;

            if (childType == 1) return getParentSelectorWithExtension();
            if (childType == 2) return [getIdent()];
            if (childType == 3) return [getClass()];
            if (childType == 4) return [getShash()];

            return default;
        }

        /**
         * @param {Number} i Token's index number
         * @returns {Number}
         */
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

        /**
         * @returns {Array}
         */
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

        /**
         * Check if token is part of an identifier
         * @param {Number} i Token's index number
         * @returns {Number} Length of the identifier
         */
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

        /**
         * Get node with an identifier
         * @returns {Array} `['ident', x]` where `x` is identifier's name
         */
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

        /**
         * @param {number} i Token's index number
         * @returns {number} Length of the identifier
         */
        public int checkPartialIdent(int i)
        {
            var start = i;

            if (i >= tokensLength) return 0;

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

        /**
         * Check if token is part of `!important` word
         * @param {Number} i Token's index number
         * @returns {Number}
         */
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

        /**
         * Get node with `!important` word
         * @returns {Array} `['important', sc]` where `sc` is optional whitespace
         */
        public Node getImportant()
        {
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = joinValues(pos, token.importantEnd);

            pos = token.importantEnd + 1;

            return newNode(NodeType.ImportantType, content, line, column);
        }

        /**
         * Check if token is part of an include (`@include` or `@extend` directive).
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int checkInclude(int i)
        {
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkInclude1(i)).AsBool()) tokens[i].include_type = 1;
            else if ((l = checkInclude2(i)).AsBool()) tokens[i].include_type = 2;

            return l;
        }

        /**
         * Get node with included mixin
         * @returns {Array} `['include', x]`
         */
        public Node getInclude()
        {
            var type = tokens[pos].include_type;

            if (type == 1) return getInclude1();
            if (type == 2) return getInclude2();

            return default;
        }

        /**
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int checkInclude1(int i)
        {
            var start = i;
            int l;

            if ((l = Of(checkClass(i), checkShash(i))).AsBool()) i += l;
            else return 0;

            while (i < tokensLength)
            {
                if ((l = Of(checkClass(i), checkShash(i), checkSC(i))).AsBool()) i += l;
                else if (tokens[i].type == TokenType.GreaterThanSign) i++;
                else break;
            }

            if ((l = checkArguments(i)).AsBool()) i += l;
            else return 0;

            if (i < tokensLength && (l = checkSC(i)).AsBool()) i += l;

            if (i < tokensLength && (l = checkImportant(i)).AsBool()) i += l;

            return i - start;
        }

        /**
         * @returns {Array} `['include', x]`
         */
        public Node getInclude1()
        {
            var type = NodeType.IncludeType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            content.push(checkClass(pos).AsBool() ? getClass() : getShash());

            while (pos < tokensLength)
            {
                if (checkClass(pos).AsBool()) content.push(getClass());
                else if (checkShash(pos).AsBool()) content.push(getShash());
                else if (checkSC(pos).AsBool()) content = content.concat(getSC());
                else if (checkOperator(pos).AsBool()) content.push(getOperator());
                else break;
            }

            content.push(getArguments());

            content = content.concat(getSC());

            if (checkImportant(pos).AsBool()) content.push(getImportant());

            return newNode(type, content, line, column);
        }

        /**
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int checkInclude2(int i)
        {
            var start = i;
            int l;

            if ((l = Of(checkClass(i), checkShash(i))).AsBool()) i += l;
            else return 0;

            while (i < tokensLength)
            {
                if ((l = Of(checkClass(i), checkShash(i), checkSC(i))).AsBool()) i += l;
                else if (tokens[i].type == TokenType.GreaterThanSign) i++;
                else break;
            }

            return i - start;
        }

        /**
         * @returns {Array} `['include', x]`
         */
        public Node getInclude2()
        {
            var type = NodeType.IncludeType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            content.push(checkClass(pos).AsBool() ? getClass() : getShash());

            while (pos < tokensLength)
            {
                if (checkClass(pos).AsBool()) content.push(getClass());
                else if (checkShash(pos).AsBool()) content.push(getShash());
                else if (checkSC(pos).AsBool()) content = content.concat(getSC());
                else if (checkOperator(pos).AsBool()) content.push(getOperator());
                else break;
            }

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is part of LESS interpolated variable
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int checkInterpolatedVariable(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if (tokens[i].type != TokenType.CommercialAt ||
                !tokens.Has(i + 1) || tokens[i + 1].type != TokenType.LeftCurlyBracket)
            {
                return 0;
            }

            i += 2;

            if ((l = checkIdent(i)).AsBool()) i += l;
            else return 0;

            return tokens[i].type == TokenType.RightCurlyBracket ? i - start + 1 : 0;
        }

        /**
         * Get node with LESS interpolated variable
         * @returns {Array} `['interpolatedVariable', x]`
         */
        public Node getInterpolatedVariable()
        {
            var type = NodeType.InterpolatedVariableType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            // Skip `@{`:
            pos += 2;

            content.push(getIdent());

            var end = getLastPosition(content, line, column, 1);

            // Skip `}`:
            pos++;

            return newNode(type, content, line, column, end);
        }

        public int checkKeyframesBlock(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkKeyframesSelector(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkBlock(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        public Node getKeyframesBlock()
        {
            var type = NodeType.RulesetType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
              getKeyframesSelector(),
              getSC(),
              getBlock()
            );

            return newNode(type, content, line, column);
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

        /**
         * Check if token is part of a @keyframes rule.
         * @param {Number} i Token's index number
         * @return {Number} Length of the @keyframes rule
         */
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

        /**
         * @return {Node}
         */
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

        /**
         * Check if token is part of a LESS mixin
         * @param {Number} i Token's index number
         * @returns {Number} Length of the mixin
         */
        public int checkMixin(int i)
        {
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkMixin1(i)).AsBool()) tokens[i].mixin_type = 1;
            else if ((l = checkMixin2(i)).AsBool()) tokens[i].mixin_type = 2;
            else return 0;

            return l;
        }

        /**
         * @returns {Array}
         */
        public Node getMixin()
        {
            var type = tokens[pos].mixin_type;

            if (type == 1) return getMixin1();
            if (type == 2) return getMixin2();

            return default;
        }

        public int checkMixin1(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = Of(checkClass(i), checkShash(i))).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkArguments(i)).AsBool()) i += l;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkBlock(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * Get node with a mixin
         * @returns {Array} `['mixin', x]`
         */
        public Node getMixin1()
        {
            var type = NodeType.MixinType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            content.push(checkClass(pos).AsBool() ? getClass() : getShash());

            content = content.concat(getSC());

            if (checkArguments(pos).AsBool()) content.push(getArguments());

            content = content.concat(getSC());

            if (checkBlock(pos).AsBool()) content.push(getBlock());

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is part of a LESS mixin
         * @param {Number} i Token's index number
         * @returns {Number} Length of the mixin
         */
        public int checkMixin2(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = Of(checkClass(i), checkShash(i))).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkArguments(i)).AsBool()) i += l;

            return i - start;
        }

        /**
         * Get node with a mixin
         * @returns {Array} `['mixin', x]`
         */
        public Node getMixin2()
        {
            var type = NodeType.MixinType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            content.push(checkClass(pos).AsBool() ? getClass() : getShash());

            content = content.concat(getSC());

            if (checkArguments(pos).AsBool()) content.push(getArguments());

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is a namespace sign (`|`)
         * @param {Number} i Token's index number
         * @returns {Number} `1` if token is `|`, `0` if not
         */
        public int checkNamespace(int i)
        {
            return i < tokensLength && tokens[i].type == TokenType.VerticalLine ? 1 : 0;
        }

        /**
         * Get node with a namespace sign
         * @returns {Array} `['namespace']`
         */
        public Node getNamespace()
        {
            var type = NodeType.NamespaceType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = "|";

            pos++;

            return newNode(type, content, line, column);
        }

        /**
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int checkNmName2(int i)
        {
            if (tokens[i].type == TokenType.Identifier) return 1;
            else if (tokens[i].type != TokenType.DecimalNumber) return 0;

            i++;

            return i < tokensLength && tokens[i].type == TokenType.Identifier ? 2 : 1;
        }

        /**
         * @returns {String}
         */
        public string getNmName2()
        {
            var s = tokens[pos].value;

            if (tokens[pos++].type == TokenType.DecimalNumber &&
                pos < tokensLength &&
                tokens[pos].type == TokenType.Identifier) s += tokens[pos++].value;

            return s;
        }

        /**
         * Check if token is part of a number
         * @param {Number} i Token's index number
         * @returns {Number} Length of number
         */
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

        /**
         * Get node with number
         * @returns {Array} `['number', x]` where `x` is a number converted
         *      to string.
         */
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

        /**
         * Check if token is an operator (`/`, `,`, `:`, `=`, `>`, `<` or `*`)
         * @param {Number} i Token's index number
         * @returns {Number} `1` if token is an operator, otherwise `0`
         */
        public int checkOperator(int i)
        {
            if (i >= tokensLength) return 0;

            switch (tokens[i].type)
            {
                case TokenType.Solidus:
                case TokenType.Comma:
                case TokenType.Colon:
                case TokenType.EqualsSign:
                case TokenType.LessThanSign:
                case TokenType.GreaterThanSign:
                case TokenType.Asterisk:
                    return 1;
            }

            return 0;
        }

        /**
         * Get node with an operator
         * @returns {Array} `['operator', x]` where `x` is an operator converted
         *      to string.
         */
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

        /**
         * Check if token is part of text inside parentheses, e.g. `(1)`
         * @param {Number} i Token's index number
         * @return {Number}
         */
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

        /**
         * Get node with text inside parentheses, e.g. `(1)`
         * @return {Node}
         */
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

        /**
         * Check if token is a parent selector (`&`).
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int checkParentSelector(int i)
        {
            return i < tokensLength && tokens[i].type == TokenType.Ampersand ? 1 : 0;
        }

        /**
         * Get node with a parent selector
         * @returns {Array} `['parentSelector']`
         */
        public Node getParentSelector()
        {
            var type = NodeType.ParentSelectorType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = "&";

            pos++;

            return newNode(type, content, line, column);
        }

        public int checkParentSelectorExtension(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            while (i < tokensLength)
            {
                if ((l = Of(checkNumber(i), checkPartialIdent(i))).AsBool()) i += l;
                else break;
            }

            return i - start;
        }

        public Node getParentSelectorExtension()
        {
            var type = NodeType.ParentSelectorExtensionType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            while (pos < tokensLength)
            {
                if (checkNumber(pos).AsBool())
                {
                    content.push(getNumber());
                }
                else if (checkPartialIdent(pos).AsBool())
                {
                    content.push(getIdent());
                }
                else break;
            }

            return newNode(type, content, line, column);
        }

        public int checkParentSelectorWithExtension(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkParentSelector(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkParentSelectorExtension(i)).AsBool()) i += l;

            return i - start;
        }

        public List<Node> getParentSelectorWithExtension()
        {
            var content = new List<Node>(){ getParentSelector() };

            if (checkParentSelectorExtension(pos).AsBool())
                content.push(getParentSelectorExtension());

            return content;
        }

        /**
         * Check if token is part of a number with percent sign (e.g. `10%`)
         * @param {Number} i Token's index number
         * @returns {Number}
         */
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

        /**
         * Get node of number with percent sign
         * @returns {Array} `['percentage', ['number', x]]` where `x` is a number
         *      (without percent sign) converted to string.
         */
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

        /**
         * @param {Number} i Token's index number
         * @returns {Number}
         */
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

        /**
         * @returns {Array}
         */
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

        /**
         * Check if token is part of a property
         * @param {Number} i Token's index number
         * @returns {Number} Length of the property
         */
        public int checkProperty(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = Of(checkVariable(i), checkIdent(i))).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * Get node with a property
         * @returns {Array} `['property', x]`
         */
        public Node getProperty()
        {
            var type = NodeType.PropertyType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            if (checkVariable(pos).AsBool())
            {
                content.push(getVariable());
            }
            else
            {
                content.push(getIdent());
            }

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is a colon
         * @param {Number} i Token's index number
         * @returns {Number} `1` if token is a colon, otherwise `0`
         */
        public int checkPropertyDelim(int i)
        {
            return i < tokensLength && tokens[i].type == TokenType.Colon ? 1 : 0;
        }

        /**
         * Get node with a colon
         * @returns {Array} `['propertyDelim']`
         */
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

        /**
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int checkPseudo(int i)
        {
            return Of(checkPseudoe(i),
                      checkPseudoc(i));
        }

        /**
         * @returns {Array}
         */
        public Node getPseudo()
        {
            if (checkPseudoe(pos).AsBool()) return getPseudoe();
            if (checkPseudoc(pos).AsBool()) return getPseudoc();

            return default;
        }

        /**
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int checkPseudoe(int i)
        {
            int l;

            // Check `::`
            if (i >= tokensLength || tokens[i].type != TokenType.Colon ||
                i + 1 >= tokensLength || tokens[i + 1].type != TokenType.Colon) return 0;

            if ((l = checkPseudoElement1(i)).AsBool()) tokens[i].pseudoElementType = 1;
            else if ((l = checkPseudoElement2(i)).AsBool()) tokens[i].pseudoElementType = 2;
            else return 0;

            return l;
        }

        /**
         * @returns {Node}
         */
        public Node getPseudoe()
        {
            var childType = tokens[pos].pseudoElementType;
            if (childType == 1) return getPseudoElement1();
            if (childType == 2) return getPseudoElement2();

            return default;
        }

        /**
         * (1) `::slotted(selector)`
         * (2) `::slotted(selector, selector)`
         */
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

        /**
         * (1) `::slotted(selector)`
         * (2) `::slotted(selector, selector)`
         */
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

        public int checkPseudoElement2(int i)
        {
            var start = i;
            int l;

            // Skip `::`.
            i += 2;

            if ((l = Of(checkInterpolatedVariable(i), checkIdent(i))).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * @returns {Array}
         */
        public Node getPseudoElement2()
        {
            var type = NodeType.PseudoeType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;

            // Skip `::`.
            pos += 2;

            var content = new List<Node>();

            if (checkInterpolatedVariable(pos).AsBool())
            {
                content.push(getInterpolatedVariable());
            }
            else
            {
                content.push(getIdent());
            }

            return newNode(type, content, line, column);
        }

        /**
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int checkPseudoc(int i)
        {
            int l;

            if (i >= tokensLength || tokens[i].type != TokenType.Colon) return 0;

            if ((l = checkPseudoClass3(i)).AsBool()) tokens[i].pseudoClassType = 3;
            else if ((l = checkPseudoClass4(i)).AsBool()) tokens[i].pseudoClassType = 4;
            else if ((l = checkPseudoClass5(i)).AsBool()) tokens[i].pseudoClassType = 5;
            else if ((l = checkPseudoClass1(i)).AsBool()) tokens[i].pseudoClassType = 1;
            else if ((l = checkPseudoClass2(i)).AsBool()) tokens[i].pseudoClassType = 2;
            else if ((l = checkPseudoClass6(i)).AsBool()) tokens[i].pseudoClassType = 6;
            else return 0;

            return l;
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

        /**
         * (1) `:not(selector)`
         * (2) `:extend(selector, selector)`
         */
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

        /**
         * (-) `:not(panda)`
         */
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

        /**
         * (1) `:nth-child(odd)`
         * (2) `:nth-child(even)`
         * (3) `:lang(de-DE)`
         */
        public int checkPseudoClass2(int i)
        {
            var start = i;
            int l = 0;

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

            {
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
            }

            return newNode(type, content, line, column);
        }

        /**
         * (-) `:nth-child(-3n + 2)`
         */
        public int checkPseudoClass3(int i)
        {
            var start = i;
            int l = 0;

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
            if (tokens[i].value == "" ||
                tokens[i].value == "-") i++;
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

        /**
         * (-) `:nth-child(-3n)`
         */
        public int checkPseudoClass4(int i)
        {
            var start = i;
            int l = 0;

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

        /**
         * (-) `:nth-child(+8)`
         */
        public int checkPseudoClass5(int i)
        {
            var start = i;
            int l = 0;

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

        /**
         * (-) `:checked`
         */
        public int checkPseudoClass6(int i)
        {
            var start = i;
            int l = 0;

            // Skip `:`.
            i++;

            if (i >= tokensLength) return 0;

            if ((l = checkInterpolatedVariable(i)).AsBool()) i += l;
            else if ((l = checkIdent(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        public Node getPseudoClass6()
        {
            var type = NodeType.PseudocType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            // Skip `:`.
            pos++;

            var ident = checkInterpolatedVariable(pos).AsBool() ?
                getInterpolatedVariable() : getIdent();
            content.push(ident);

            return newNode(type, content, line, column);
        }

        /**
         * @param {Number} i Token's index number
         * @returns {Number}
         */
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

        /**
         * Check if token is marked as a space (if it's a space or a tab
         *      or a line break).
         * @param {Number} i
         * @returns {Number} Number of spaces in a row starting with the given token.
         */
        public int checkS(int i)
        {
            return i < tokensLength && tokens[i].ws ? tokens[i].ws_last - i + 1 : 0;
        }

        /**
         * Get node with spaces
         * @returns {Array} `['s', x]` where `x` is a string containing spaces
         */
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

        /**
         * Check if token is a space or a comment.
         * @param {Number} i Token's index number
         * @returns {Number} Number of similar (space or comment) tokens
         *      in a row starting with the given token.
         */
        public int checkSC(int i)
        {
            if (i >= tokensLength) return 0;

            int l;
            var lsc = 0;

            while (i < tokensLength)
            {
                if (!(l = checkS(i)).AsBool() &&
                    !(l = checkCommentML(i)).AsBool() &&
                    !(l = checkCommentSL(i)).AsBool()) break;
                i += l;
                lsc += l;
            }

            return Of(lsc, 0);
        }

        /**
         * Get node with spaces and comments
         * @returns {Array} Array containing nodes with spaces (if there are any)
         *      and nodes with comments (if there are any):
         *      `[['s', x]*, ['comment', y]*]` where `x` is a string of spaces
         *      and `y` is a comment's text (without `/*` and `* /`).
         */
        public List<Node> getSC()
        {
            var sc = new List<Node>();

            if (pos >= tokensLength) return sc;

            while (pos < tokensLength)
            {
                if (checkS(pos).AsBool()) sc.push(getS());
                else if (checkCommentML(pos).AsBool()) sc.push(getCommentML());
                else if (checkCommentSL(pos).AsBool()) sc.push(getCommentSL());
                else break;
            }

            return sc;
        }

        /**
         * Check if token is part of a hexadecimal number (e.g. `#fff`) inside
         *      a simple selector
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int checkShash(int i)
        {
            int l;

            if (i >= tokensLength || tokens[i].type != TokenType.NumberSign) return 0;

            if ((l = Of(checkInterpolatedVariable(i + 1), checkIdent(i + 1))).AsBool()) return l + 1;
            else return 0;
        }

        /**
         * Get node with a hexadecimal number (e.g. `#fff`) inside a simple
         *      selector
         * @returns {Array} `['shash', x]` where `x` is a hexadecimal number
         *      converted to string (without `#`, e.g. `fff`)
         */
        public Node getShash()
        {
            var type = NodeType.ShashType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            // Skip `#`.
            pos++;

            if (checkInterpolatedVariable(pos).AsBool()) content.push(getInterpolatedVariable());
            else content.push(getIdent());

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is part of a string (text wrapped in quotes)
         * @param {Number} i Token's index number
         * @returns {Number} `1` if token is part of a string, `0` if not
         */
        public int checkString(int i)
        {
            if (i >= tokensLength)
            {
                return 0;
            }

            if (tokens[i].type == TokenType.StringSQ ||
                tokens[i].type == TokenType.StringDQ)
            {
                return 1;
            }

            return 0;
        }

        /**
         * Get string's node
         * @returns {Array} `['string', x]` where `x` is a string (including
         *      quotes).
         */
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

        /**
         * Validate stylesheet: it should consist of any number (0 or more) of
         * rulesets (sets of rules with selectors), @-rules, whitespaces or
         * comments.
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int checkStylesheet(int i)
        {
            var start = i;
            int l;

            // Check every token:
            while (i < tokensLength)
            {
                if ((l = Of(checkSC(i),
                            checkRuleset(i),
                            checkDeclaration(i),
                            checkDeclDelim(i),
                            checkAtrule(i),
                            checkMixin(i))).AsBool()) i += l;
                else throwError(i);
            }

            return i - start;
        }

        /**
         * @returns {Array} `['stylesheet', x]` where `x` is all stylesheet's
         *      nodes.
         */
        public Node getStylesheet()
        {
            var type = NodeType.StylesheetType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            while (pos < tokensLength)
            {
                if (checkSC(pos).AsBool()) content = content.concat(getSC());
                else if (checkRuleset(pos).AsBool()) content.push(getRuleset());
                else if (checkDeclaration(pos).AsBool()) content.push(getDeclaration());
                else if (checkDeclDelim(pos).AsBool()) content.push(getDeclDelim());
                else if (checkAtrule(pos).AsBool()) content.push(getAtrule());
                else if (checkMixin(pos).AsBool()) content.push(getMixin());
                else throwError(pos);
            }

            return newNode(type, content, line, column);
        }

        /**
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int checkTset(int i)
        {
            int l;

            if ((l = checkVhash(i)).AsBool()) tokens[i].tset_child = 1;
            else if ((l = checkAny(i)).AsBool()) tokens[i].tset_child = 2;
            else if ((l = checkSC(i)).AsBool()) tokens[i].tset_child = 3;
            else if ((l = checkOperator(i)).AsBool()) tokens[i].tset_child = 4;

            return l;
        }

        /**
         * @returns {Array}
         */
        public UnionList<Node> getTset()
        {
            var childType = tokens[pos].tset_child;

            if (childType == 1) return getVhash();
            if (childType == 2) return getAny();
            if (childType == 3) return getSC();
            if (childType == 4) return getOperator();

            return default;
        }

        /**
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int checkTsets(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            while ((l = checkTset(i)).AsBool())
            {
                i += l;
            }

            return i - start;
        }

        /**
         * @returns {Array}
         */
        public List<Node> getTsets()
        {
            var content = new List<Node>();
            Node t;

            while (checkTset(pos).AsBool())
            {
                t = getTset().AsT0;
                if (t.content.IsString) content.push(t);
                else content = content.concat(t);
            }

            return content;
        }

        /**
         * Check if token is an unary (arithmetical) sign (`+` or `-`)
         * @param {Number} i Token's index number
         * @returns {Number} `1` if token is an unary sign, `0` if not
         */
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

        /**
         * Get node with an unary (arithmetical) sign (`+` or `-`)
         * @returns {Array} `['unary', x]` where `x` is an unary sign
         *      converted to string.
         */
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

        /**
         * Check if token is a unicode range (single or multiple <urange> nodes)
         * @param {number} i Token's index
         * @return {number} Unicode range node's length
         */
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

        /**
         * Get a unicode range node
         * @return {Node}
         */
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

        /**
         * Check if token is unit
         * @param {Number} i Token's index number
         * @return {Number}
         */
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

        /**
         * Get unit node of type ident
         * @return {Node} An ident node containing the unit value
         */
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

        /**
         * Check if token is a u-range (part of a unicode-range)
         * (1) `U+416`
         * (2) `U+400-4ff`
         * (3) `U+4??`
         * @param {number} i Token's index
         * @return {number} Urange node's length
         */
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

        /**
         * Get a u-range node (part of a unicode-range)
         * @return {Node}
         */
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

        /**
         * Check for unicode wildcard characters `?`
         * @param {number} i Token's index
         * @return {number} Wildcard length
         */
        public int _checkUnicodeWildcard(int i)
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

        /**
         * Check if token is part of URI (e.g. `url('/css/styles.css')`)
         * @param {Number} i Token's index number
         * @returns {Number} Length of URI
         */
        public int checkUri(int i)
        {
            var start = i;

            if (i >= tokensLength || tokens[i++].value != "url" ||
                i >= tokensLength || tokens[i].type != TokenType.LeftParenthesis)
                return 0;

            return tokens[i].right - start + 1;
        }

        /**
         * Get node with URI
         * @returns {Array} `['uri', x]` where `x` is URI's nodes (without `url`
         *      and braces, e.g. `['string', ''/css/styles.css'']`).
         */
        public Node getUri()
        {
            var startPos = pos;
            var uriExcluding = new Dictionary<string, int>();
            List<Node> uri;
            Token token;
            int l;
            Node raw;

            pos += 2;

            uriExcluding[TokenType.Space] = 1;
            uriExcluding[TokenType.Tab] = 1;
            uriExcluding[TokenType.Newline] = 1;
            uriExcluding[TokenType.LeftParenthesis] = 1;
            uriExcluding[TokenType.RightParenthesis] = 1;

            if (checkUri1(pos).AsBool())
            {
                uri = new List<Node>()
                    .concat(getSC())
                    .concat([getString()])
                    .concat(getSC());
            }
            else
            {
                uri = getSC();
                l = checkExcluding(uriExcluding, pos);
                token = tokens[pos];
                raw = newNode(NodeType.RawType, joinValues(pos, pos + l), token.ln,
                    token.col);

                uri.push(raw);

                pos += l + 1;

                uri = uri.concat(getSC());
            }

            token = tokens[startPos];
            var line = token.ln;
            var column = token.col;
            var end = getLastPosition(uri, line, column, 1);
            pos++;

            return newNode(NodeType.UriType, uri, line, column, end);
        }

        /**
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int checkUri1(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if (tokens[i].type != TokenType.StringDQ &&
                tokens[i].type != TokenType.StringSQ)
            {
                return 0;
            }

            i++;

            if ((l = checkSC(i)).AsBool()) i += l;

            return i - start;
        }

        /**
         * Check if token is part of a value
         * @param {Number} i Token's index number
         * @returns {Number} Length of the value
         */
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
                if (!l.AsBool() || checkBlock(_i).AsBool()) break;
            }

            tokens[start].value_end = i;

            return i - start;
        }

        /**
         * @returns {Array}
         */
        public Node getValue()
        {
            var type = NodeType.ValueType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var end = tokens[pos].value_end;
            var content = new List<Node>();
            int _pos;
            int s;

            while (pos < end)
            {
                s = checkSC(pos);
                _pos = pos + s;

                if (!_checkValue(_pos).AsBool()) break;

                if (s.AsBool()) content = content.concat(getSC());
                content.push(_getValue());
            }

            return newNode(type, content, line, column);
        }

        /**
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int _checkValue(int i)
        {
            int l;

            if ((l = checkEscapedString(i)).AsBool()) tokens[i].value_child = 1;
            else if ((l = checkInterpolatedVariable(i)).AsBool()) tokens[i].value_child = 2;
            else if ((l = checkVariable(i)).AsBool()) tokens[i].value_child = 3;
            else if ((l = checkVhash(i)).AsBool()) tokens[i].value_child = 4;
            else if ((l = checkBlock(i)).AsBool()) tokens[i].value_child = 5;
            else if ((l = checkProgid(i)).AsBool()) tokens[i].value_child = 6;
            else if ((l = checkAny(i)).AsBool()) tokens[i].value_child = 7;
            else if ((l = checkAtkeyword(i)).AsBool()) tokens[i].value_child = 8;
            else if ((l = checkOperator(i)).AsBool()) tokens[i].value_child = 9;
            else if ((l = checkImportant(i)).AsBool()) tokens[i].value_child = 10;

            return l;
        }

        /**
         * @returns {Array}
         */
        public Node _getValue()
        {
            var childType = tokens[pos].value_child;
            if (childType == 1) return getEscapedString();
            if (childType == 2) return getInterpolatedVariable();
            if (childType == 3) return getVariable();
            if (childType == 4) return getVhash();
            if (childType == 5) return getBlock();
            if (childType == 6) return getProgid();
            if (childType == 7) return getAny();
            if (childType == 8) return getAtkeyword();
            if (childType == 9) return getOperator();
            if (childType == 10) return getImportant();

            return default;
        }

        /**
         * Check if token is part of LESS variable
         * @param {Number} i Token's index number
         * @returns {Number} Length of the variable
         */
        public int checkVariable(int i)
        {
            int l;

            if (i >= tokensLength || tokens[i].type != TokenType.CommercialAt) return 0;

            if (tokens.Has(i - 1) &&
                tokens[i - 1].type == TokenType.CommercialAt &&
                tokens.Has(i - 2) &&
                tokens[i - 2].type == TokenType.CommercialAt) return 0;

            return (l = Of(checkVariable(i + 1), checkIdent(i + 1))).AsBool() ? l + 1 : 0;
        }

        /**
         * Get node with a variable
         * @returns {Array} `['variable', ['ident', x]]` where `x` is
         *      a variable name.
         */
        public Node getVariable()
        {
            var type = NodeType.VariableType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            // Skip `$`.
            pos++;

            if (checkVariable(pos).AsBool()) content.push(getVariable());
            else content.push(getIdent());

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is part of a variables list (e.g. `@rest...`).
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int checkVariablesList(int i)
        {
            var d = 0; // Number of dots
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkVariable(i)).AsBool()) i += l;
            else return 0;

            while (tokens.Has(i) && tokens[i].type == TokenType.FullStop)
            {
                d++;
                i++;
            }

            return d == 3 ? l + d : 0;
        }

        /**
         * Get node with a variables list
         * @returns {Array} `['variableslist', ['variable', ['ident', x]]]` where
         *      `x` is a variable name.
         */
        public Node getVariablesList()
        {
            var type = NodeType.VariablesListType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>{ getVariable() };
            var end = getLastPosition(content, line, column, 3);

            // Skip `...`.
            pos += 3;

            return newNode(type, content, line, column, end);
        }

        /**
         * Check if token is part of a hexadecimal number (e.g. `#fff`) inside
         *      some value
         * @param {Number} i Token's index number
         * @returns {Number}
         */
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

        /**
         * Get node with a hexadecimal number (e.g. `#fff`) inside some value
         * @returns {Array} `['vhash', x]` where `x` is a hexadecimal number
         *      converted to string (without `#`, e.g. `'fff'`).
         */
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

        public int checkSelectorsGroup(int i)
        {
            if (i >= tokensLength) return 0;

            var start = i;
            int l;

            if ((l = checkSelector(i)).AsBool()) i += l;
            else return 0;

            while (i < tokensLength)
            {
                var spaceBefore = checkSC(i);
                var comma = checkDelim(i + spaceBefore);
                if (!comma.AsBool()) break;

                var spaceAfter = checkSC(i + spaceBefore + comma);
                if ((l = checkSelector(i + spaceBefore + comma + spaceAfter)).AsBool())
                {
                    i += spaceBefore + comma + spaceAfter + l;
                }
                else break;
            }

            tokens[start].selectorsGroupEnd = i;
            return i - start;
        }

        public List<Node> getSelectorsGroup()
        {
            var selectorsGroup = new List<Node>();
            var selectorsGroupEnd = tokens[pos].selectorsGroupEnd;

            selectorsGroup.push(getSelector());

            while (pos < selectorsGroupEnd)
            {
                selectorsGroup = selectorsGroup.concat(
                  getSC(),
                  getDelim(),
                  getSC(),
                  getSelector()
                );
            }

            return selectorsGroup;
        }

        public int checkSelector(int i)
        {
            int l;

            if ((l = checkSelector1(i)).AsBool()) tokens[i].selectorType = 1;
            else if ((l = checkSelector2(i)).AsBool()) tokens[i].selectorType = 2;

            return l;
        }

        public Node getSelector()
        {
            var selectorType = tokens[pos].selectorType;
            if (selectorType == 1) return getSelector1();
            else return getSelector2();
        }

        /**
         * Checks for selector which starts with a compound selector.
         */
        public int checkSelector1(int i)
        {
            if (i >= tokensLength) return 0;

            var start = i;
            int l;

            if ((l = checkCompoundSelector(i)).AsBool()) i += l;
            else return 0;

            while (i < tokensLength)
            {
                var space = checkSC(i);
                var comma = checkCombinator(i + space);
                if (!space.AsBool() && !comma.AsBool()) break;

                if (comma.AsBool())
                {
                    i += space + comma;
                    space = checkSC(i);
                }

                if ((l = checkCompoundSelector(i + space)).AsBool()) i += space + l;
                else break;
            }

            tokens[start].selectorEnd = i;
            return i - start;
        }

        public Node getSelector1()
        {
            var type = NodeType.SelectorType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var selectorEnd = token.selectorEnd;
            var content = getCompoundSelector();

            while (pos < selectorEnd)
            {
                if (checkSC(pos).AsBool())
                    content = content.concat(getSC());
                else if (checkCombinator(pos).AsBool())
                    content.push(getCombinator());
                else if (checkCompoundSelector(pos).AsBool())
                    content = content.concat(getCompoundSelector());
            }

            return newNode(type, content, line, column);
        }

        /**
         * Checks for a selector that starts with a combinator.
         */
        public int checkSelector2(int i)
        {
            if (i >= tokensLength) return 0;

            var start = i;
            int l;

            if ((l = checkCombinator(i)).AsBool()) i += l;
            else return 0;

            while (i < tokensLength)
            {
                var spaceBefore = checkSC(i);
                if ((l = checkCompoundSelector(i + spaceBefore)).AsBool()) i += spaceBefore + l;
                else break;

                var spaceAfter = checkSC(i);
                var comma = checkCombinator(i + spaceAfter);
                if (!spaceAfter.AsBool() && !comma.AsBool()) break;
                if (comma.AsBool())
                {
                    i += spaceAfter + comma;
                }
            }

            tokens[start].selectorEnd = i;
            return i - start;
        }

        public Node getSelector2()
        {
            var type = NodeType.SelectorType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var selectorEnd = token.selectorEnd;
            var content = new List<Node>(){ getCombinator() };

            while (pos < selectorEnd)
            {
                if (checkSC(pos).AsBool())
                    content = content.concat(getSC());
                else if (checkCombinator(pos).AsBool())
                    content.push(getCombinator());
                else if (checkCompoundSelector(pos).AsBool())
                    content = content.concat(getCompoundSelector());
            }

            return newNode(type, content, line, column);
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

        public List<Node> getCompoundSelector()
        {
            var type = tokens[pos].compoundSelectorType;
            if (type == 1) return getCompoundSelector1();
            if (type == 2) return getCompoundSelector2();

            return default;
        }

        public int checkCompoundSelector1(int i)
        {
            if (i >= tokensLength) return 0;

            var start = i;
            int l;

            if ((l = Of(checkUniversalSelector(i),
                        checkTypeSelector(i),
                        checkParentSelectorWithExtension(i))).AsBool()) i += l;
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

        public List<Node> getCompoundSelector1()
        {
            var sequence = new List<Node>();
            var compoundSelectorEnd = tokens[pos].compoundSelectorEnd;

            if (checkUniversalSelector(pos).AsBool()) sequence.push(getUniversalSelector());
            else if (checkTypeSelector(pos).AsBool()) sequence.push(getTypeSelector());
            else if (checkParentSelectorWithExtension(pos).AsBool())
                sequence = sequence.concat(getParentSelectorWithExtension());

            while (pos < compoundSelectorEnd)
            {
                if (checkShash(pos).AsBool()) sequence.push(getShash());
                else if (checkClass(pos).AsBool()) sequence.push(getClass());
                else if (checkAttributeSelector(pos).AsBool()) sequence.push(getAttributeSelector());
                else if (checkPseudo(pos).AsBool()) sequence.push(getPseudo());
            }

            return sequence;
        }

        public int checkCompoundSelector2(int i)
        {
            if (i >= tokensLength) return 0;

            var start = i;

            while (i < tokensLength)
            {
                var l = Of(checkShash(i),
                           checkClass(i),
                           checkAttributeSelector(i),
                           checkPseudo(i));
                if (l.AsBool()) i += l;
                else break;
            }

            tokens[start].compoundSelectorEnd = i;

            return i - start;
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
            }

            return sequence;
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

        public int checkAttributeSelector(int i)
        {
            int l;
            if ((l = checkAttributeSelector1(i)).AsBool()) tokens[i].attributeSelectorType = 1;
            else if ((l = checkAttributeSelector2(i)).AsBool()) tokens[i].attributeSelectorType = 2;

            return l;
        }

        public Node getAttributeSelector()
        {
            var type = tokens[pos].attributeSelectorType;
            if (type == 1) return getAttributeSelector1();
            else return getAttributeSelector2();
        }

        /**
         * (1) `[panda=nani]`
         * (2) `[panda='nani']`
         * (3) `[panda='nani' i]`
         *
         */
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

        /**
         * (1) `[panda]`
         */
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

        public int checkAttributeName(int i)
        {
            var start = i;
            int l;

            if ((l = checkNamePrefix(i)).AsBool()) i += l;

            if ((l = checkIdent(i)).AsBool()) i += l;
            else return 0;

            return i - start;
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

        public int checkAttributeMatch(int i)
        {
            int l;
            if ((l = checkAttributeMatch1(i)).AsBool()) tokens[i].attributeMatchType = 1;
            else if ((l = checkAttributeMatch2(i)).AsBool()) tokens[i].attributeMatchType = 2;

            return l;
        }

        public Node getAttributeMatch()
        {
            var type = tokens[pos].attributeMatchType;
            if (type == 1) return getAttributeMatch1();
            else return getAttributeMatch2();
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

        public int checkAttributeMatch2(int i)
        {
            if (tokens[i].type == TokenType.EqualsSign) return 1;
            else return 0;
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

        public int checkAttributeValue(int i)
        {
            return Of(checkString(i), checkIdent(i));
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

        public int checkAttributeFlags(int i)
        {
            return checkIdent(i);
        }

        public Node getAttributeFlags()
        {
            var type = NodeType.AttributeFlagsType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>(){ getIdent() };

            return newNode(type, content, line, column);
        }

        public int checkNamePrefix(int i)
        {
            if (i >= tokensLength) return 0;

            int l;
            if ((l = checkNamePrefix1(i)).AsBool()) tokens[i].namePrefixType = 1;
            else if ((l = checkNamePrefix2(i)).AsBool()) tokens[i].namePrefixType = 2;

            return l;
        }

        public Node getNamePrefix()
        {
            var type = tokens[pos].namePrefixType;
            if (type == 1) return getNamePrefix1();
            else return getNamePrefix2();
        }

        /**
         * (1) `panda|`
         * (2) `panda<comment>|`
         */
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

        /**
         * (1) `|`
         */
        public int checkNamePrefix2(int i)
        {
            return checkNamespaceSeparator(i);
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

        /**
         * (1) `*`
         * (2) `panda`
         */
        public int checkNamespacePrefix(int i)
        {
            if (i >= tokensLength) return 0;

            int l;

            if (tokens[i].type == TokenType.Asterisk) return 1;
            else if ((l = checkIdent(i)).AsBool()) return l;
            else return 0;
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

        /**
         * (1) `|`
         */
        public int checkNamespaceSeparator(int i)
        {
            if (i >= tokensLength) return 0;

            if (tokens[i].type != TokenType.VerticalLine) return 0;

            // Return false if `|=` - [attr|=value]
            if (tokens.Has(i + 1) && tokens[i + 1].type == TokenType.EqualsSign) return 0;

            return 1;
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

    }
}
