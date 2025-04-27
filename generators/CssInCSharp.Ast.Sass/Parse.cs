using static CssInCSharp.Ast.Util;

namespace CssInCSharp.Ast.Sass
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
         * Stops parsing and display error.
         *
         * @param {number=} i Token's index number
         */
        public void throwError(int i)
        {
            var ln = tokens[i].ln;

            throw new Exception($"line: {ln}, syntax: sass");
        }

        /**
         * @param {number} start
         * @param {number} finish
         * @return {string}
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
         * @param {number} start
         * @param {number} num
         * @return {string}
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

        /**
         * @param {string|!Array} content
         * @param {number} line
         * @param {number} column
         * @param {number} colOffset
         */
        public int[] getLastPosition(Content content, int line, int column, int? colOffset = null)
        {
            return content.IsString ?
                getLastPositionForString(content.AsString, line, column, colOffset) :
                getLastPositionForArray(content.AsArray, line, column, colOffset);
        }

        /**
         * @param {string} content
         * @param {number} line
         * @param {number} column
         * @param {number} colOffset
         */
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

        /**
         * @param {!Array} content
         * @param {number} line
         * @param {number} column
         * @param {number} colOffset
         */
        public int[] getLastPositionForArray(List<Node> content, int line, int column, int? colOffset)
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

        /**
         * @param {string} type
         * @param {string|!Array} content
         * @param {number} line
         * @param {number} column
         * @param {!Array} end
         */
        public Node newNode(string type, Content content, int line, int column, int[]? end = null)
        {
            if (end != null) end = getLastPosition(content, line, column);
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
                syntax = "sass"
            });
        }



        /**
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkAny(int i)
        {
            int l;

            if ((l = checkBrackets(i)).AsBool()) tokens[i].any_child = 1;
            else if ((l = checkParentheses(i)).AsBool()) tokens[i].any_child = 2;
            else if ((l = checkString(i)).AsBool()) tokens[i].any_child = 3;
            else if ((l = checkVariablesList(i)).AsBool()) tokens[i].any_child = 4;
            else if ((l = checkVariable(i)).AsBool()) tokens[i].any_child = 5;
            else if ((l = checkPlaceholder(i)).AsBool()) tokens[i].any_child = 6;
            else if ((l = checkPercentage(i)).AsBool()) tokens[i].any_child = 7;
            else if ((l = checkDimension(i)).AsBool()) tokens[i].any_child = 8;
            else if ((l = checkUnicodeRange(i)).AsBool()) tokens[i].any_child = 9;
            else if ((l = checkNumber(i)).AsBool()) tokens[i].any_child = 10;
            else if ((l = checkUri(i)).AsBool()) tokens[i].any_child = 11;
            else if ((l = checkExpression(i)).AsBool()) tokens[i].any_child = 12;
            else if ((l = checkFunctionsList(i)).AsBool()) tokens[i].any_child = 13;
            else if ((l = checkFunction(i)).AsBool()) tokens[i].any_child = 14;
            else if ((l = checkInterpolation(i)).AsBool()) tokens[i].any_child = 15;
            else if ((l = checkIdent(i)).AsBool()) tokens[i].any_child = 16;
            else if ((l = checkClass(i)).AsBool()) tokens[i].any_child = 17;
            else if ((l = checkUnary(i)).AsBool()) tokens[i].any_child = 18;
            else if ((l = checkParentSelector(i)).AsBool()) tokens[i].any_child = 19;
            else if ((l = checkImportant(i)).AsBool()) tokens[i].any_child = 20;
            else if ((l = checkGlobal(i)).AsBool()) tokens[i].any_child = 21;
            else if ((l = checkDefault(i)).AsBool()) tokens[i].any_child = 22;
            else if ((l = checkOptional(i)).AsBool()) tokens[i].any_child = 23;

            return l;
        }

        /**
         * @return {!Node}
         */
        public Node getAny()
        {
            var childType = tokens[pos].any_child;

            if (childType == 1) return getBrackets();
            if (childType == 2) return getParentheses();
            if (childType == 3) return getString();
            if (childType == 4) return getVariablesList();
            if (childType == 5) return getVariable();
            if (childType == 6) return getPlaceholder();
            if (childType == 7) return getPercentage();
            if (childType == 8) return getDimension();
            if (childType == 9) return getUnicodeRange();
            if (childType == 10) return getNumber();
            if (childType == 11) return getUri();
            if (childType == 12) return getExpression();
            if (childType == 13) return getFunctionsList();
            if (childType == 14) return getFunction();
            if (childType == 15) return getInterpolation();
            if (childType == 16) return getIdent();
            if (childType == 17) return getClass();
            if (childType == 18) return getUnary();
            if (childType == 19) return getParentSelector();
            if (childType == 20) return getImportant();
            if (childType == 21) return getGlobal();
            if (childType == 22) return getDefault();
            if (childType == 23) return getOptional();

            return default;
        }

        /**
         * Checks if token is part of mixin's arguments.
         *
         * @param {number} i Token's index number
         * @return {number} Length of arguments
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
         * @return {Array}
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
                if (checkSingleValueDeclaration(pos).AsBool())
                {
                    content.push(getSingleValueDeclaration());
                }
                else if (checkArgument(pos).AsBool())
                {
                    body = getArgument();
                    if (body.IsElement) content.push(body);
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
         * Checks if token is valid to be part of arguments list
         * @param {number} i Token's index number
         * @return {number} Length of argument
         */
        public int checkArgument(int i)
        {
            int l;

            if ((l = checkBrackets(i)).AsBool()) tokens[i].argument_child = 1;
            else if ((l = checkParentheses(i)).AsBool()) tokens[i].argument_child = 2;
            else if ((l = checkSingleValueDeclaration(i)).AsBool()) tokens[i].argument_child = 3;
            else if ((l = checkFunctionsList(i)).AsBool()) tokens[i].argument_child = 4;
            else if ((l = checkFunction(i)).AsBool()) tokens[i].argument_child = 5;
            else if ((l = checkVariablesList(i)).AsBool()) tokens[i].argument_child = 6;
            else if ((l = checkVariable(i)).AsBool()) tokens[i].argument_child = 7;
            else if ((l = checkSC(i)).AsBool()) tokens[i].argument_child = 8;
            else if ((l = checkDelim(i)).AsBool()) tokens[i].argument_child = 9;
            else if ((l = checkDeclDelim(i)).AsBool()) tokens[i].argument_child = 10;
            else if ((l = checkString(i)).AsBool()) tokens[i].argument_child = 11;
            else if ((l = checkPercentage(i)).AsBool()) tokens[i].argument_child = 12;
            else if ((l = checkDimension(i)).AsBool()) tokens[i].argument_child = 13;
            else if ((l = checkNumber(i)).AsBool()) tokens[i].argument_child = 14;
            else if ((l = checkUri(i)).AsBool()) tokens[i].argument_child = 15;
            else if ((l = checkInterpolation(i)).AsBool()) tokens[i].argument_child = 16;
            else if ((l = checkIdent(i)).AsBool()) tokens[i].argument_child = 17;
            else if ((l = checkVhash(i)).AsBool()) tokens[i].argument_child = 18;
            else if ((l = checkCustomProperty(i)).AsBool()) tokens[i].argument_child = 19;
            else if ((l = checkOperator(i)).AsBool()) tokens[i].argument_child = 20;
            else if ((l = checkUnary(i)).AsBool()) tokens[i].argument_child = 21;
            else if ((l = checkParentSelector(i)).AsBool()) tokens[i].argument_child = 22;
            else if ((l = checkImportant(i)).AsBool()) tokens[i].argument_child = 23;
            else if ((l = checkGlobal(i)).AsBool()) tokens[i].argument_child = 24;
            else if ((l = checkDefault(i)).AsBool()) tokens[i].argument_child = 25;
            else if ((l = checkOptional(i)).AsBool()) tokens[i].argument_child = 26;

            return l;
        }

        /**
         * @return {!Node}
         */
        public UnionList<Node> getArgument()
        {
            var childType = tokens[pos].argument_child;

            if (childType == 1) return getBrackets();
            if (childType == 2) return getParentheses();
            if (childType == 3) return getSingleValueDeclaration();
            if (childType == 4) return getFunctionsList();
            if (childType == 5) return getFunction();
            if (childType == 6) return getVariablesList();
            if (childType == 7) return getVariable();
            if (childType == 8) return getSC();
            if (childType == 9) return getDelim();
            if (childType == 10) return getDeclDelim();
            if (childType == 11) return getString();
            if (childType == 12) return getPercentage();
            if (childType == 13) return getDimension();
            if (childType == 14) return getNumber();
            if (childType == 15) return getUri();
            if (childType == 16) return getInterpolation();
            if (childType == 17) return getIdent();
            if (childType == 18) return getVhash();
            if (childType == 19) return getCustomProperty();
            if (childType == 20) return getOperator();
            if (childType == 21) return getUnary();
            if (childType == 22) return getParentSelector();
            if (childType == 23) return getImportant();
            if (childType == 24) return getGlobal();
            if (childType == 25) return getDefault();
            if (childType == 26) return getOptional();

            return default;
        }

        /**
         * Checks if token is part of an @-word (e.g. `@import`, `@include`).
         *
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkAtkeyword(int i)
        {
            int l;

            // Check that token is `@`:
            if (i >= tokensLength ||
                tokens[i++].type != TokenType.CommercialAt) return 0;

            return ((l = checkIdentOrInterpolation(i)).AsBool()) ? l + 1 : 0;
        }

        /**
         * Gets node with @-word.
         *
         * @return {!Node}
         */
        public Node getAtkeyword()
        {
            var type = NodeType.AtkeywordType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;

            // Skip `@`.
            pos++;

            var content = getIdentOrInterpolation();

            return newNode(type, content, line, column);
        }

        /**
         * Checks if token is a part of an @-rule.
         *
         * @param {number} i Token's index number
         * @return {number} Length of @-rule
         */
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

        /**
         * Gets node with @-rule.
         *
         * @return {!Node}
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
         * Checks if token is part of a block @-rule.
         *
         * @param {number} i Token's index number
         * @return {number} Length of the @-rule
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
         * Gets node with a block @-rule.
         *
         * @return {!Node}
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
         * Checks if token is part of an @-rule with ruleset.
         *
         * @param {number} i Token's index number
         * @return {number} Length of the @-rule
         */
        public int checkAtruler(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkAtkeyword(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkTsets(i)).AsBool()) i += l;

            if ((l = checkAtrulers(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * Gets node with an @-rule with ruleset.
         *
         * @return {!Node}
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
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkAtrulers(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            var blockEnd = tokens[i].block_end;
            if (!blockEnd.AsBool()) return 0;

            while (i < blockEnd)
            {
                if ((l = checkSC(i)).AsBool()) tokens[i].atrulers_child = 1;
                else if ((l = checkAtrule(i)).AsBool()) tokens[i].atrulers_child = 2;
                else if ((l = checkRuleset(i)).AsBool()) tokens[i].atrulers_child = 3;
                else return 0;
                i += l;
            }

            if (i < tokensLength) tokens[i].atrulers_end = 1;

            return i - start;
        }

        /**
         * @return {!Node}
         */
        public Node getAtrulers()
        {
            var type = NodeType.BlockType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = getSC();

            while (pos < tokensLength && !tokens[pos].atrulers_end.AsBool())
            {
                var childType = tokens[pos].atrulers_child;
                if (childType == 1) content = content.concat(getSC());
                else if (childType == 2) content.push(getAtrule());
                else if (childType == 3) content.push(getRuleset());
                else break;
            }

            var end = getLastPosition(content, line, column);

            return newNode(type, content, line, column, end);
        }

        /**
         * @param {number} i Token's index number
         * @return {number}
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
         * @return {!Node}
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
         * Checks if token is part of a block (e.g. `{...}`).
         *
         * @param {number} i Token's index number
         * @return {number} Length of the block
         */
        public int checkBlock(int i)
        {
            return i < tokensLength && tokens[i].block_end.AsBool() ?
                tokens[i].block_end - i + 1 : 0;
        }

        /**
         * Gets node with a block.
         *
         * @return {!Node}
         */
        public Node getBlock()
        {
            var type = NodeType.BlockType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var end = tokens[pos].block_end;
            var content = new List<Node>();

            while (pos < end)
            {
                if (checkBlockdecl(pos).AsBool()) content = content.concat(getBlockdecl());
                else throwError(pos);
            }

            return newNode(type, content, line, column);
        }

        /**
         * Checks if token is part of a declaration (property-value pair).
         *
         * @param {number} i Token's index number
         * @return {number} Length of the declaration
         */
        public int checkBlockdecl(int i)
        {
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkBlockdecl7(i)).AsBool()) tokens[i].bd_type = 7;
            else if ((l = checkBlockdecl5(i)).AsBool()) tokens[i].bd_type = 5;
            else if ((l = checkBlockdecl6(i)).AsBool()) tokens[i].bd_type = 6;
            else if ((l = checkBlockdecl1(i)).AsBool()) tokens[i].bd_type = 1;
            else if ((l = checkBlockdecl2(i)).AsBool()) tokens[i].bd_type = 2;
            else if ((l = checkBlockdecl3(i)).AsBool()) tokens[i].bd_type = 3;
            else if ((l = checkBlockdecl4(i)).AsBool()) tokens[i].bd_type = 4;
            else return 0;

            return l;
        }

        /**
         * @return {!Array}
         */
        public List<Node> getBlockdecl()
        {
            var childType = tokens[pos].bd_type;

            if (childType == 1) return getBlockdecl1();
            if (childType == 2) return getBlockdecl2();
            if (childType == 3) return getBlockdecl3();
            if (childType == 4) return getBlockdecl4();
            if (childType == 5) return getBlockdecl5();
            if (childType == 6) return getBlockdecl6();
            if (childType == 7) return getBlockdecl7();

            return default;
        }

        /**
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkBlockdecl1(int i)
        {
            var start = i;
            int l;

            if ((l = checkInclude(i)).AsBool()) tokens[i].bd_kind = 2;
            else if ((l = checkDeclaration(i)).AsBool()) tokens[i].bd_kind = 5;
            else if ((l = checkAtrule(i)).AsBool()) tokens[i].bd_kind = 6;
            else return 0;

            i += l;

            if (tokens[start].bd_kind == 2 &&
                Array.IndexOf([2, 4, 6, 8], tokens[start].include_type) == -1) return 0;

            if (tokens[start].bd_kind == 6 &&
                tokens[start].atrule_type == 3) return 0;

            while (i < tokensLength)
            {
                if ((l = checkDeclDelim(i)).AsBool())
                    return i + l - start;

                if ((l = checkS(i)).AsBool()) i += l;
                else if ((l = checkCommentSL(i)).AsBool()) i += l;
                else break;
            }

            return 0;
        }

        /**
         * @return {!Array}
         */
        public List<Node> getBlockdecl1()
        {
            var content = new List<Node>();
            var _content = new List<Node>();

            switch (tokens[pos].bd_kind)
            {
                case 2:
                    content.push(getInclude());
                    break;
                case 5:
                    content.push(getDeclaration());
                    break;
                case 6:
                    content.push(getAtrule());
                    break;
            }

            while (pos < tokensLength)
            {
                var _pos = pos;
                if (checkDeclDelim(pos).AsBool())
                {
                    _content.push(getDeclDelim());
                    content = content.concat(_content);
                    break;
                }

                if (checkS(pos).AsBool()) _content.push(getS());
                else if (checkCommentSL(pos).AsBool()) _content.push(getCommentSL());
                else
                {
                    pos = _pos;
                    break;
                }
            }

            return content;
        }

        /**
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkBlockdecl2(int i)
        {
            var start = i;
            int l;

            if ((l = checkConditionalStatement(i)).AsBool()) tokens[i].bd_kind = 1;
            else if ((l = checkInclude(i)).AsBool()) tokens[i].bd_kind = 2;
            else if ((l = checkExtend(i)).AsBool()) tokens[i].bd_kind = 4;
            else if ((l = checkMixin(i)).AsBool()) tokens[i].bd_kind = 8;
            else if ((l = checkLoop(i)).AsBool()) tokens[i].bd_kind = 3;
            else if ((l = checkRuleset(i)).AsBool()) tokens[i].bd_kind = 7;
            else if ((l = checkDeclaration(i)).AsBool()) tokens[i].bd_kind = 5;
            else if ((l = checkAtrule(i)).AsBool()) tokens[i].bd_kind = 6;
            else return 0;

            i += l;

            while (i < tokensLength)
            {
                if ((l = checkS(i)).AsBool()) i += l;
                else if ((l = checkCommentSL(i)).AsBool()) i += l;
                else break;
            }

            return i - start;
        }

        /**
         * @return {!Array}
         */
        public List<Node> getBlockdecl2()
        {
            var content = new List<Node>();

            switch (tokens[pos].bd_kind)
            {
                case 1:
                    content.push(getConditionalStatement());
                    break;
                case 2:
                    content.push(getInclude());
                    break;
                case 3:
                    content.push(getLoop());
                    break;
                case 4:
                    content.push(getExtend());
                    break;
                case 5:
                    content.push(getDeclaration());
                    break;
                case 6:
                    content.push(getAtrule());
                    break;
                case 7:
                    content.push(getRuleset());
                    break;
                case 8:
                    content.push(getMixin());
                    break;
            }

            while (pos < tokensLength)
            {
                if (checkS(pos).AsBool()) content.push(getS());
                else if (checkCommentSL(pos).AsBool()) content.push(getCommentSL());
                else break;
            }

            return content;
        }



        /**
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkBlockdecl3(int i)
        {
            var start = i;
            int l;

            if ((l = checkConditionalStatement(i)).AsBool()) tokens[i].bd_kind = 1;
            else if ((l = checkInclude(i)).AsBool()) tokens[i].bd_kind = 2;
            else if ((l = checkExtend(i)).AsBool()) tokens[i].bd_kind = 4;
            else if ((l = checkLoop(i)).AsBool()) tokens[i].bd_kind = 3;
            else if ((l = checkRuleset(i)).AsBool()) tokens[i].bd_kind = 7;
            else if ((l = checkDeclaration(i)).AsBool()) tokens[i].bd_kind = 5;
            else if ((l = checkAtrule(i)).AsBool()) tokens[i].bd_kind = 6;
            else return 0;

            i += l;

            return i - start;
        }

        /**
         * @return {!Array}
         */
        public List<Node> getBlockdecl3()
        {
            Node content = null;

            switch (tokens[pos].bd_kind)
            {
                case 1:
                    content = getConditionalStatement();
                    break;
                case 2:
                    content = getInclude();
                    break;
                case 3:
                    content = getLoop();
                    break;
                case 4:
                    content = getExtend();
                    break;
                case 5:
                    content = getDeclaration();
                    break;
                case 6:
                    content = getAtrule();
                    break;
                case 7:
                    content = getRuleset();
                    break;
            }

            return new List<Node>(){ content };
        }

        /**
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkBlockdecl4(int i)
        {
            return checkSC(i);
        }

        /**
         * @return {!Array}
         */
        public List<Node> getBlockdecl4()
        {
            return getSC();
        }

        /**
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkBlockdecl5(int i)
        {
            var start = i;
            int l;

            if ((l = checkInclude(i)).AsBool()) i += l;
            else if ((l = checkRuleset(i)).AsBool()) i += l;
            else return 0;

            while (i < tokensLength)
            {
                if ((l = checkS(i)).AsBool()) i += l;
                else if ((l = checkCommentSL(i)).AsBool()) i += l;
                else break;
            }

            return i - start;
        }

        /**
         * @return {!Array}
         */
        public List<Node> getBlockdecl5()
        {
            var content = new List<Node>();

            if (checkInclude(pos).AsBool()) content.push(getInclude());
            else content.push(getRuleset());

            while (pos < tokensLength)
            {
                if (checkS(pos).AsBool()) content.push(getS());
                else if (checkCommentSL(pos).AsBool()) content.push(getCommentSL());
                else break;
            }

            return content;
        }

        /**
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkBlockdecl6(int i)
        {
            var start = i;
            int l;

            if ((l = checkInclude(i)).AsBool()) i += l;
            else if ((l = checkRuleset(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * @return {!Array}
         */
        public List<Node> getBlockdecl6()
        {
            Node content = null;

            if (checkInclude(pos).AsBool()) content = getInclude();
            else content = getRuleset();

            return new List<Node>(){ content };
        }

        /**
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkBlockdecl7(int i)
        {
            var start = i;
            int l;

            if ((l = checkInclude(i)).AsBool()) i += l;
            else return 0;

            if (Array.IndexOf([2, 4, 6, 8], tokens[start].include_type) == -1) return 0;

            while (i < tokensLength)
            {
                if ((l = checkDeclDelim(i)).AsBool())
                    return i + l - start;

                if ((l = checkS(i)).AsBool()) i += l;
                else if ((l = checkCommentSL(i)).AsBool()) i += l;
                else break;
            }

            return 0;
        }

        /**
         * @return {!Array}
         */
        public List<Node> getBlockdecl7()
        {
            var content = new List<Node>();
            var _content = new List<Node>();

            content.push(getInclude());

            while (pos < tokensLength)
            {
                var _pos = pos;
                if (checkDeclDelim(pos).AsBool())
                {
                    _content.push(getDeclDelim());
                    content = content.concat(_content);
                    break;
                }

                if (checkS(pos).AsBool()) _content.push(getS());
                else if (checkCommentSL(pos).AsBool()) _content.push(getCommentSL());
                else
                {
                    pos = _pos;
                    break;
                }
            }

            return content;
        }


        /**
         * Checks if token is part of text inside square brackets, e.g. `[1]`.
         *
         * @param {number} i Token's index number
         * @return {number}
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
         * Gets node with text inside square brackets, e.g. `[1]`.
         *
         * @return {!Node}
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
         * Checks if token is part of a class selector (e.g. `.abc`).
         *
         * @param {number} i Token's index number
         * @return {number} Length of the class selector
         */
        public int checkClass(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if (tokens[i].class_l.AsBool()) return tokens[i].class_l;

            // Skip `.`.
            if (tokens[i].type == TokenType.FullStop) i++;
            else return 0;

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
            else return 0;

            while (i < tokensLength)
            {
                if ((l = checkIdentOrInterpolation(i)).AsBool())
                {
                    tokens[start].class_l = l + 1;
                    i += l;
                }
                else break;
            }

            tokens[start].classEnd = i;

            return i - start;
        }

        /**
         * Gets node with a class selector.
         *
         * @return {!Node}
         */
        public Node getClass()
        {
            var type = NodeType.ClassType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var end = token.classEnd;
            var content = new List<Node>();

            // Skip `.`
            pos++;

            while (pos < end)
            {
                if (checkIdentOrInterpolation(pos).AsBool())
                {
                    content = content.concat(getIdentOrInterpolation());
                }
                else break;
            }

            return newNode(type, content, line, column);
        }

        /**
         * @param {number} i
         * @return {number}
         */
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

        /**
         * @return {!Node}
         */
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
         * @param {number} i
         * @return {number}
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
         * @return {!Node}
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
         * @param {number} i
         * @return {number}
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
         * @param {number} i Token's index number
         * @return {number} `1` if token is a multiline comment, otherwise `0`
         */
        public int checkCommentML(int i)
        {
            return i < tokensLength && tokens[i].type == TokenType.CommentML ? 1 : 0;
        }

        /**
         * Get node with a multiline comment
         * @return {Array} `['commentML', x]` where `x`
         *      is the comment's text (without `/*` and `* /`).
         */
        public Node getCommentML()
        {
            var type = NodeType.CommentMLType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = tokens[pos].value.substring(2);

            var end = getLastPosition(content, line, column + 2);

            if (content.EndsWith("*/"))
            {
                content = content.substring(0, content.Length - 2);
            }

            pos++;

            return newNode(type, content, line, column, end);
        }

        /**
         * Check if token is part of a single-line comment.
         * @param {number} i Token's index number
         * @return {number} `1` if token is a single-line comment, otherwise `0`
         */
        public int checkCommentSL(int i)
        {
            return i < tokensLength && tokens[i].type == TokenType.CommentSL ? 1 : 0;
        }

        /**
         * Get node with a single-line comment.
         * @return {Array} `['commentSL', x]` where `x` is comment's message
         *      (without `//`)
         */
        public Node getCommentSL()
        {
            var type = NodeType.CommentSLType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = tokens[pos++].value.substring(2);
            var end = content != string.Empty ? [line, column + 1]
              : getLastPosition(content, line, column + 2);

            return newNode(type, content, line, column, end);
        }

        /**
         * Check if token is part of a condition
         * (e.g. `@if ...`, `@else if ...` or `@else ...`).
         * @param {number} i Token's index number
         * @return {number} Length of the condition
         */
        public int checkCondition(int i)
        {
            var start = i;
            int l;
            int _i;
            int s;

            if (i >= tokensLength) return 0;

            if ((l = checkAtkeyword(i)).AsBool()) i += l;
            else return 0;

            if (Array.IndexOf(["if", "else"], tokens[start + 1].value) < 0) return 0;

            while (i < tokensLength)
            {
                if ((l = checkBlock(i)).AsBool()) break;

                s = checkSC(i);
                _i = i + s;

                if ((l = _checkCondition(_i)).AsBool()) i += l + s;
                else break;
            }

            return i - start;
        }

        public int _checkCondition(int i)
        {
            return Of(checkVariable(i),
                      checkNumber(i),
                      checkInterpolation(i),
                      checkIdent(i),
                      checkOperator(i),
                      checkCombinator(i),
                      checkString(i));
        }

        /**
         * Get node with a condition.
         * @return {Array} `['condition', x]`
         */
        public Node getCondition()
        {
            var type = NodeType.ConditionType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();
            int s;
            int _pos;

            content.push(getAtkeyword());

            while (pos < tokensLength)
            {
                if (checkBlock(pos).AsBool()) break;

                s = checkSC(pos);
                _pos = pos + s;

                if (!_checkCondition(_pos).AsBool()) break;

                if (s.AsBool()) content = content.concat(getSC());
                content.push(_getCondition());
            }

            return newNode(type, content, line, column);
        }

        public Node _getCondition()
        {
            if (checkVariable(pos).AsBool()) return getVariable();
            if (checkNumber(pos).AsBool()) return getNumber();
            if (checkInterpolation(pos).AsBool()) return getInterpolation();
            if (checkIdent(pos).AsBool()) return getIdent();
            if (checkOperator(pos).AsBool()) return getOperator();
            if (checkCombinator(pos).AsBool()) return getCombinator();
            if (checkString(pos).AsBool()) return getString();

            return default;
        }

        /**
         * Check if token is part of a conditional statement
         * (e.g. `@if ... {} @else if ... {} @else ... {}`).
         * @param {number} i Token's index number
         * @return {number} Length of the condition
         */
        public int checkConditionalStatement(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkCondition(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkBlock(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * Get node with a condition.
         * @return {Array} `['condition', x]`
         */
        public Node getConditionalStatement()
        {
            var type = NodeType.ConditionalStatementType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
              getCondition(),
              getSC(),
              getBlock()
            );

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is part of a declaration (property-value pair)
         * @param {number} i Token's index number
         * @return {number} Length of the declaration
         */
        public int checkDeclaration(int i)
        {
            return Of(checkDeclaration1(i), checkDeclaration2(i));
        }

        /**
         * Get node with a declaration
         * @return {Array} `['declaration', ['property', x], ['propertyDelim'],
         *       ['value', y]]`
         */
        public Node getDeclaration()
        {
            return checkDeclaration1(pos).AsBool() ? getDeclaration1() : getDeclaration2();
        }

        /**
         * Check if token is part of a declaration (property-value pair)
         * @param {number} i Token's index number
         * @return {number} Length of the declaration
         */
        public int checkDeclaration1(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkProperty(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkPropertyDelim(i)).AsBool()) i++;
            else return 0;

            if ((l = checkValue(i)).AsBool()) return i + l - start;

            if ((l = checkS(i)).AsBool()) i += l;

            if ((l = checkValue(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * Get node with a declaration
         * @return {Array} `['declaration', ['property', x], ['propertyDelim'],
         *       ['value', y]]`
         */
        public Node getDeclaration1()
        {
            var type = NodeType.DeclarationType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            content.push(getProperty());
            if (checkS(pos).AsBool()) content.push(getS());
            content.push(getPropertyDelim());
            if (checkS(pos).AsBool()) content.push(getS());
            content.push(getValue());

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is part of a declaration (property-value pair)
         * @param {number} i Token's index number
         * @return {number} Length of the declaration
         */
        public int checkDeclaration2(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkPropertyDelim(i)).AsBool()) i++;
            else return 0;

            if ((l = checkProperty(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkValue(i)).AsBool()) return i + l - start;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkValue(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * Get node with a declaration
         * @return {Array} `['declaration', ['propertyDelim'], ['property', x],
         *       ['value', y]]`
         */
        public Node getDeclaration2()
        {
            var type = NodeType.DeclarationType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
              getPropertyDelim(),
              getProperty(),
              getSC(),
              getValue()
            );

            return newNode(type, content, line, column);
        }

        /**
         * @param {number} i Token's index number
         * @returns {number} Length of the declaration
         */
        public int checkSingleValueDeclaration(int i)
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

            if ((l = checkSingleValue(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * Get node with a declaration
         * @returns {Array} `['declaration', ['property', x], ['propertyDelim'],
         *       ['value', y]]`
         */
        public Node getSingleValueDeclaration()
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
              getSingleValue()
            );

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is a semicolon
         * @param {number} i Token's index number
         * @return {number} `1` if token is a semicolon, otherwise `0`
         */
        public int checkDeclDelim(int i)
        {
            if (i >= tokensLength) return 0;

            return (tokens[i].type == TokenType.Newline ||
                tokens[i].type == TokenType.Semicolon) ? 1 : 0;
        }

        /**
         * Get node with a semicolon
         * @return {Array} `['declDelim']`
         */
        public Node getDeclDelim()
        {
            var type = NodeType.DeclDelimType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = "\n";

            pos++;

            return newNode(type, content, line, column);
        }

        /**
         * Check if token if part of `!default` word.
         * @param {number} i Token's index number
         * @return {number} Length of the `!default` word
         */
        public int checkDefault(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength ||
                tokens[i++].type != TokenType.ExclamationMark) return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if (tokens[i].value == "default")
            {
                tokens[start].defaultEnd = i;
                return i - start + 1;
            }
            else
            {
                return 0;
            }
        }

        /**
         * Get node with a `!default` word
         * @return {Array} `['default', sc]` where `sc` is optional whitespace
         */
        public Node getDefault()
        {
            var type = NodeType.DefaultType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = joinValues(pos, token.defaultEnd);

            pos = token.defaultEnd + 1;

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is a comma
         * @param {number} i Token's index number
         * @return {number} `1` if token is a comma, otherwise `0`
         */
        public int checkDelim(int i)
        {
            return i < tokensLength && tokens[i].type == TokenType.Comma ? 1 : 0;
        }

        /**
         * Get node with a comma
         * @return {Array} `['delim']`
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
         * @return {Number}
         */
        public int checkDimension(int i)
        {
            var ln = checkNumber(i);
            int li;

            if (i >= tokensLength ||
                !ln.AsBool() ||
                i + ln >= tokensLength) return 0;

            return ((li = checkUnit(i + ln)).AsBool()) ? ln + li : 0;
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
            var content = new List<Node>()
            {
                getNumber(),
                getUnit()
            };

            return newNode(type, content, line, column);
        }

        /**
         * @param {number} i Token's index number
         * @return {number}
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
         * @return {Array}
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

            if ((l = checkExtend1(i)).AsBool()) tokens[i].extend_child = 1;
            else if ((l = checkExtend2(i)).AsBool()) tokens[i].extend_child = 2;

            return l;
        }

        public Node getExtend()
        {
            var childType = tokens[pos].extend_child;

            if (childType == 1) return getExtend1();
            if (childType == 2) return getExtend2();

            return default;
        }

        /**
         * Checks if token is part of an extend with `!optional` flag.
         * @param {number} i
         */
        public int checkExtend1(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkAtkeyword(i)).AsBool()) i += l;
            else return 0;

            if (tokens[start + 1].value != "extend") return 0;

            if ((l = checkSC(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSelectorsGroup(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkOptional(i)).AsBool()) i += l;
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
              getAtkeyword(),
              getSC(),
              getSelectorsGroup(),
              getSC(),
              getOptional()
            );

            return newNode(type, content, line, column);
        }

        /**
         * Checks if token is part of an extend without `!optional` flag.
         * @param {number} i
         */
        public int checkExtend2(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkAtkeyword(i)).AsBool()) i += l;
            else return 0;

            if (tokens[start + 1].value != "extend") return 0;

            if ((l = checkSC(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSelectorsGroup(i)).AsBool()) i += l;
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
              getAtkeyword(),
              getSC(),
              getSelectorsGroup()
            );

            return newNode(type, content, line, column);
        }

        /**
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkFunction(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
            else return 0;

            return i < tokensLength && tokens[i].type == TokenType.LeftParenthesis ?
                tokens[i].right - start + 1 : 0;
        }

        /**
         * @return {Array}
         */
        public Node getFunction()
        {
            var type = NodeType.FunctionType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
              getIdentOrInterpolation(),
              getArguments()
            );

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is part of a functions list (e.g. `function(value)...`).
         * @param {Number} i Token's index number
         * @returns {Number}
         */
        public int checkFunctionsList(int i)
        {
            var d = 0; // Number of dots
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkFunction(i)).AsBool()) i += l;
            else return 0;

            while (i < tokensLength && tokens[i].type == TokenType.FullStop)
            {
                d++;
                i++;
            }

            return d == 3 ? l + d : 0;
        }

        /**
         * Get node with a functions list
         * @returns {Array}
         */
        public Node getFunctionsList()
        {
            var type = NodeType.FunctionsListType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>(){ getFunction() };
            var end = getLastPosition(content, line, column, 3);

            // Skip `...`.
            pos += 3;

            return newNode(type, content, line, column, end);
        }

        /**
         * Check if token is part of `!global` word
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkGlobal(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength ||
                tokens[i++].type != TokenType.ExclamationMark) return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if (tokens[i].value == "global")
            {
                tokens[start].globalEnd = i;
                return i - start + 1;
            }
            else
            {
                return 0;
            }
        }

        /**
         * Get node with `!global` word
         */
        public Node getGlobal()
        {
            var type = NodeType.GlobalType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = joinValues(pos, token.globalEnd);

            pos = token.globalEnd + 1;

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is part of an identifier
         * @param {number} i Token's index number
         * @return {number} Length of the identifier
         */
        public int checkIdent(int i)
        {
            var start = i;

            if (i >= tokensLength) return 0;

            // Check if token is part of a negative number
            if (tokens[i].type == TokenType.HyphenMinus &&
                tokens[i + 1].type == TokenType.DecimalNumber) return 0;

            if (tokens[i].type == TokenType.HyphenMinus) i++;

            if (checkInterpolation(i).AsBool())
            {
                tokens[start].ident_last = i - 1;
                return i - start;
            }

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
         * @return {Array} `['ident', x]` where `x` is identifier's name
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
         * @param {number} i Token's index number
         * @returns {number} Length of the identifier
         */
        public int checkIdentOrInterpolation(int i)
        {
            var start = i;
            int l;
            var prevIsInterpolation = false;

            while (i < tokensLength)
            {
                if ((l = checkInterpolation(i)).AsBool())
                {
                    tokens[i].ii_type = 1;
                    i += l;
                    prevIsInterpolation = true;
                }
                else if ((l = checkIdent(i)).AsBool())
                {
                    tokens[i].ii_type = 2;
                    i += l;
                    prevIsInterpolation = false;
                }
                else if (prevIsInterpolation && ((l = checkPartialIdent(i)).AsBool()))
                {
                    tokens[i].ii_type = 3;
                    i += l;
                    prevIsInterpolation = false;
                }
                else break;
            }

            return i - start;
        }

        public List<Node> getIdentOrInterpolation()
        {
            var content = new List<Node>();

            while (pos < tokensLength)
            {
                var tokenType = tokens[pos].ii_type;

                if (tokenType == 1)
                {
                    content.push(getInterpolation());
                }
                else if (tokenType == 2 || tokenType == 3)
                {
                    content.push(getIdent());
                }
                else break;
            }

            return content;
        }

        /**
         * Check if token is part of `!important` word
         * @param {number} i Token's index number
         * @return {number}
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
         * @return {Array} `['important', sc]` where `sc` is optional whitespace
         */
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

        /**
         * Check if token is part of an included mixin (`@include` or `@extend`
         *      directive).
         * @param {number} i Token's index number
         * @return {number} Length of the included mixin
         */
        public int checkInclude(int i)
        {
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkIncludeWithKeyframes1(i)).AsBool()) tokens[i].include_type = 9;
            else if ((l = checkInclude1(i)).AsBool()) tokens[i].include_type = 1;
            else if ((l = checkInclude2(i)).AsBool()) tokens[i].include_type = 2;
            else if ((l = checkInclude3(i)).AsBool()) tokens[i].include_type = 3;
            else if ((l = checkInclude4(i)).AsBool()) tokens[i].include_type = 4;
            else if ((l = checkIncludeWithKeyframes2(i)).AsBool()) tokens[i].include_type = 10;
            else if ((l = checkInclude5(i)).AsBool()) tokens[i].include_type = 5;
            else if ((l = checkInclude6(i)).AsBool()) tokens[i].include_type = 6;
            else if ((l = checkInclude7(i)).AsBool()) tokens[i].include_type = 7;
            else if ((l = checkInclude8(i)).AsBool()) tokens[i].include_type = 8;

            return l;
        }

        /**
         * Get node with included mixin
         * @return {Array} `['include', x]`
         */
        public Node getInclude()
        {
            var type = tokens[pos].include_type;

            if (type == 1) return getInclude1();
            if (type == 2) return getInclude2();
            if (type == 3) return getInclude3();
            if (type == 4) return getInclude4();
            if (type == 5) return getInclude5();
            if (type == 6) return getInclude6();
            if (type == 7) return getInclude7();
            if (type == 8) return getInclude8();
            if (type == 9) return getIncludeWithKeyframes1();
            if (type == 10) return getIncludeWithKeyframes2();

            return default;
        }

        /**
         * Check if token is part of an included mixin like `@include nani(foo) {...}`
         * @param {number} i Token's index number
         * @return {number} Length of the include
         */
        public int checkInclude1(int i)
        {
            var start = i;
            int l;

            if ((l = checkAtkeyword(i)).AsBool()) i += l;
            else return 0;

            if (tokens[start + 1].value != "include") return 0;

            if ((l = checkSC(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkArguments(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkBlock(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * Get node with included mixin like `@include nani(foo) {...}`
         * @return {Array} `['include', ['atkeyword', x], sc, ['selector', y], sc,
         *      ['arguments', z], sc, ['block', q], sc` where `x` is `include` or
         *      `extend`, `y` is mixin's identifier (selector), `z` are arguments
         *      passed to the mixin, `q` is block passed to the mixin and `sc`
         *      are optional whitespaces
         */
        public Node getInclude1()
        {
            var type = NodeType.IncludeType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
              getAtkeyword(),
              getSC(),
              getIdentOrInterpolation(),
              getSC(),
              getArguments(),
              getSC(),
              getBlock()
            );

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is part of an included mixin like `@include nani(foo)`
         * @param {number} i Token's index number
         * @return {number} Length of the include
         */
        public int checkInclude2(int i)
        {
            var start = i;
            int l;

            if ((l = checkAtkeyword(i)).AsBool()) i += l;
            else return 0;

            if (tokens[start + 1].value != "include") return 0;

            if ((l = checkSC(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkArguments(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * Get node with included mixin like `@include nani(foo)`
         * @return {Array} `['include', ['atkeyword', x], sc, ['selector', y], sc,
         *      ['arguments', z], sc]` where `x` is `include` or `extend`, `y` is
         *      mixin's identifier (selector), `z` are arguments passed to the
         *      mixin and `sc` are optional whitespaces
         */
        public Node getInclude2()
        {
            var type = NodeType.IncludeType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
              getAtkeyword(),
              getSC(),
              getIdentOrInterpolation(),
              getSC(),
              getArguments()
            );

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is part of an included mixin with a content block passed
         *      as an argument (e.g. `@include nani {...}`)
         * @param {number} i Token's index number
         * @return {number} Length of the mixin
         */
        public int checkInclude3(int i)
        {
            var start = i;
            int l;

            if ((l = checkAtkeyword(i)).AsBool()) i += l;
            else return 0;

            if (tokens[start + 1].value != "include") return 0;

            if ((l = checkSC(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkBlock(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * Get node with an included mixin with a content block passed
         *      as an argument (e.g. `@include nani {...}`)
         * @return {Array} `['include', x]`
         */
        public Node getInclude3()
        {
            var type = NodeType.IncludeType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
              getAtkeyword(),
              getSC(),
              getIdentOrInterpolation(),
              getSC(),
              getBlock()
            );

            return newNode(type, content, line, column);
        }

        /**
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkInclude4(int i)
        {
            var start = i;
            int l;

            if ((l = checkAtkeyword(i)).AsBool()) i += l;
            else return 0;

            if (tokens[start + 1].value != "include") return 0;

            if ((l = checkSC(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * @return {Array} `['include', x]`
         */
        public Node getInclude4()
        {
            var type = NodeType.IncludeType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
              getAtkeyword(),
              getSC(),
              getIdentOrInterpolation()
            );

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is part of an included mixin like `+nani(foo) {...}`
         * @param {number} i Token's index number
         * @return {number} Length of the include
         */
        public int checkInclude5(int i)
        {
            var start = i;
            int l;

            if (tokens[i].type == TokenType.PlusSign) i++;
            else return 0;

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkArguments(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkBlock(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * Get node with included mixin like `+nani(foo) {...}`
         * @return {Array} `['include', ['operator', '+'], ['selector', x], sc,
         *      ['arguments', y], sc, ['block', z], sc` where `x` is
         *      mixin's identifier (selector), `y` are arguments passed to the
         *      mixin, `z` is block passed to mixin and `sc` are optional whitespaces
         */
        public Node getInclude5()
        {
            var type = NodeType.IncludeType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
                getOperator(),
                getIdentOrInterpolation(),
                getSC(),
                getArguments(),
                getSC(),
                getBlock()
            );

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is part of an included mixin like `+nani(foo)`
         * @param {number} i Token's index number
         * @return {number} Length of the include
         */
        public int checkInclude6(int i)
        {
            var start = i;
            int l;

            if (tokens[i].type == TokenType.PlusSign) i++;
            else return 0;

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkArguments(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * Get node with included mixin like `+nani(foo)`
         * @return {Array} `['include', ['operator', '+'], ['selector', y], sc,
         *      ['arguments', z], sc]` where `y` is
         *      mixin's identifier (selector), `z` are arguments passed to the
         *      mixin and `sc` are optional whitespaces
         */
        public Node getInclude6()
        {
            var type = NodeType.IncludeType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
              getOperator(),
              getIdentOrInterpolation(),
              getSC(),
              getArguments()
            );

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is part of an included mixin with a content block passed
         *      as an argument (e.g. `+nani {...}`)
         * @param {number} i Token's index number
         * @return {number} Length of the mixin
         */
        public int checkInclude7(int i)
        {
            var start = i;
            int l;

            if (tokens[i].type == TokenType.PlusSign) i++;
            else return 0;

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkBlock(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * Get node with an included mixin with a content block passed
         *      as an argument (e.g. `+nani {...}`)
         * @return {Array} `['include', x]`
         */
        public Node getInclude7()
        {
            var type = NodeType.IncludeType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
              getOperator(),
              getIdentOrInterpolation(),
              getSC(),
              getBlock()
            );

            return newNode(type, content, line, column);
        }

        /**
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkInclude8(int i)
        {
            var start = i;
            int l;

            if (tokens[i].type == TokenType.PlusSign) i++;
            else return 0;

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * @return {Array} `['include', x]`
         */
        public Node getInclude8()
        {
            var type = NodeType.IncludeType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
              getOperator(),
              getIdentOrInterpolation()
            );

            return newNode(type, content, line, column);
        }

        /**
         * Get node with included mixin with keyfames selector like
         * `@include nani(foo) { 0% {}}`
         * @param {number} i Token's index number
         * @returns {number} Length of the include
         */
        public int checkIncludeWithKeyframes1(int i)
        {
            var start = i;
            int l;

            if ((l = checkAtkeyword(i)).AsBool()) i += l;
            else return 0;

            if (tokens[start + 1].value != "include") return 0;

            if ((l = checkSC(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkArguments(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkKeyframesBlocks(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * Get node with included mixin with keyfames selector like
         * `@include nani(foo) { 0% {}}`
         * @return {!Node}
         */
        public Node getIncludeWithKeyframes1()
        {
            var type = NodeType.IncludeType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
              getAtkeyword(),
              getSC(),
              getIdentOrInterpolation(),
              getSC(),
              getArguments(),
              getSC(),
              getKeyframesBlocks()
            );

            return newNode(type, content, line, column);
        }

        /**
         * Get node with included mixin with keyfames selector like
         * `+nani(foo) { 0% {}}`
         * @param {number} i Token's index number
         * @returns {number} Length of the include
         */
        public int checkIncludeWithKeyframes2(int i)
        {
            var start = i;
            int l;

            if (tokens[i].type == TokenType.PlusSign) i++;
            else return 0;

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkArguments(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkKeyframesBlocks(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * Get node with included mixin with keyfames selector like
         * `+nani(foo) { 0% {}}`
         * @return {!Node}
         */
        public Node getIncludeWithKeyframes2()
        {
            var type = NodeType.IncludeType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
              getOperator(),
              getIdentOrInterpolation(),
              getSC(),
              getArguments(),
              getSC(),
              getKeyframesBlocks()
            );

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is part of an interpolated variable (e.g. `#{$nani}`).
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkInterpolation(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if (tokens[i].type != TokenType.NumberSign ||
                !tokens.Has(i + 1) ||
                tokens[i + 1].type != TokenType.LeftCurlyBracket) return 0;

            i += 2;

            while (tokens[i].type != TokenType.RightCurlyBracket)
            {
                if ((l = checkArgument(i)).AsBool()) i += l;
                else return 0;
            }

            return tokens[i].type == TokenType.RightCurlyBracket ? i - start + 1 : 0;
        }

        /**
         * Get node with an interpolated variable
         * @return {Array} `['interpolation', x]`
         */
        public Node getInterpolation()
        {
            var type = NodeType.InterpolationType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            // Skip `#{`:
            pos += 2;

            while (pos < tokensLength &&
                tokens[pos].type != TokenType.RightCurlyBracket)
            {
                var body = getArgument();
                if (body.IsElement) content.push(body);
                else content = content.concat(body);
            }

            var end = getLastPosition(content, line, column, 1);

            // Skip `}`:
            pos++;

            return newNode(type, content, line, column, end);
        }

        /**
         * Check a single keyframe block - `5% {}`
         * @param {number} i
         * @return {number}
         */
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

        /**
         * Get a single keyframe block - `5% {}`
         * @return {Node}
         */
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

        /**
         * Check all keyframe blocks - `5% {} 100% {}`
         * @param {number} i
         * @return {number}
         */
        public int checkKeyframesBlocks(int i)
        {
            if (i >= tokensLength) return 0;

            var blockEnd = tokens[i].block_end;
            var start = i;
            int l;

            if (!blockEnd.AsBool()) return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkKeyframesBlock(i)).AsBool()) i += l;

            while (i < blockEnd)
            {
                if ((l = checkSC(i)).AsBool()) i += l;
                else if ((l = checkKeyframesBlock(i)).AsBool()) i += l;
                else if ((l = checkAtrule(i)).AsBool()) i += l;
                else break;
            }

            if (i != blockEnd + 1) return 0;

            return blockEnd + 1 - start;
        }

        /**
         * Get all keyframe blocks - `5% {} 100% {}`
         * @return {Node}
         */
        public Node getKeyframesBlocks()
        {
            var type = NodeType.BlockType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var keyframesBlocksEnd = token.block_end;
            var content = new List<Node>();

            while (pos < keyframesBlocksEnd)
            {
                if (checkSC(pos).AsBool()) content = content.concat(getSC());
                else if (checkKeyframesBlock(pos).AsBool()) content.push(getKeyframesBlock());
                else if (checkAtrule(pos).AsBool()) content.push(getAtrule()); // @content
                else break;
            }

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is part of a @keyframes rule.
         * @param {number} i Token's index number
         * @return {number} Length of the @keyframes rule
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

            if ((l = Of(checkIdentOrInterpolation(i), checkPseudoc(i))).AsBool()) i += l;
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
              getSC()
            );

            if (checkIdentOrInterpolation(pos).AsBool())
                content = content.concat(getIdentOrInterpolation());
            else if (checkPseudoc(pos).AsBool())
            {
                content = content.concat(getPseudoc());
            }

            content = content.concat(
              getSC(),
              getKeyframesBlocks()
            );

            return newNode(type, content, line, column);
        }

        /**
         * Check a single keyframe selector - `5%`, `from` etc
         * @param {Number} i
         * @return {Number}
         */
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
            else if ((l = checkInterpolation(i)).AsBool())
            {
                i += l;
                tokens[start].keyframesSelectorType = 3;
            }
            else
            {
                return 0;
            }

            return i - start;
        }

        /**
         * Get a single keyframe selector
         * @return {Node}
         */
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
            else if (token.keyframesSelectorType == 2)
            {
                content.push(getPercentage());
            }
            else if (token.keyframesSelectorType == 3)
            {
                content.push(getInterpolation());
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
         * Check the keyframe's selector groups
         * @param {number} i
         * @return {number}
         */
        public int checkKeyframesSelectorsGroup(int i)
        {
            var start = i;
            int l;

            if ((l = checkKeyframesSelector(i)).AsBool()) i += l;
            else return 0;

            // Check for trailing space
            if ((l = checkSC(i)).AsBool() && tokens[i].type != TokenType.Newline) i += l;

            while (i < tokensLength)
            {
                var tempStart = i;
                var tempIndex = i;
                int tempLength;

                if ((tempLength = checkDelim(tempIndex)).AsBool()) tempIndex += tempLength;
                else break;

                // Check for maxmimum space usage - 'space', '\n', 'space'
                if ((tempLength = checkSC(tempIndex)).AsBool()) tempIndex += tempLength;
                if ((tempLength = checkSC(tempIndex)).AsBool()) tempIndex += tempLength;
                if ((tempLength = checkSC(tempIndex)).AsBool()) tempIndex += tempLength;

                if ((tempLength = checkKeyframesSelector(tempIndex)).AsBool()) tempIndex += tempLength;
                else break;

                // Check for trailing space
                if ((tempLength = checkSC(tempIndex)).AsBool() &&
                    tokens[tempIndex].type != TokenType.Newline)
                {
                    tempIndex += tempLength;
                }

                i += tempIndex - tempStart;
            }

            tokens[start].selectorsGroupEnd = i;

            return i - start;
        }

        /**
         * Get the keyframe's selector groups
         * @return {Array} An array of keyframe selectors
         */
        public List<Node> getKeyframesSelectorsGroup()
        {
            var selectorsGroup = new List<Node>();
            var selectorsGroupEnd = tokens[pos].selectorsGroupEnd;

            selectorsGroup.push(getKeyframesSelector());

            if (checkSC(pos).AsBool() && tokens[pos].type != TokenType.Newline)
            {
                selectorsGroup = selectorsGroup.concat(getSC());
            }

            while (pos < selectorsGroupEnd)
            {
                selectorsGroup = selectorsGroup.concat(
                  getDelim(),
                  getSC(),
                  getSC(),
                  getSC(),
                  getKeyframesSelector()
                );

                if (checkSC(pos).AsBool() && tokens[pos].type != TokenType.Newline)
                {
                    selectorsGroup = selectorsGroup.concat(getSC());
                }
            }

            return selectorsGroup;
        }

        /**
         * Check if token is part of a loop.
         * @param {number} i Token's index number
         * @return {number} Length of the loop
         */
        public int checkLoop(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkAtkeyword(i)).AsBool()) i += l;
            else return 0;

            if (Array.IndexOf(["for", "each", "while"], tokens[start + 1].value) < 0) return 0;

            while (i < tokensLength)
            {
                if ((l = checkBlock(i)).AsBool())
                {
                    i += l;
                    break;
                }
                else if ((l = Of(checkVariable(i),
                             checkNumber(i),
                             checkInterpolation(i),
                             checkIdent(i),
                             checkSC(i),
                             checkOperator(i),
                             checkCombinator(i),
                             checkString(i))).AsBool()) i += l;
                else return 0;
            }

            return i - start;
        }

        /**
         * Get node with a loop.
         * @return {Array} `['loop', x]`
         */
        public Node getLoop()
        {
            var type = NodeType.LoopType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            content.push(getAtkeyword());

            while (pos < tokensLength)
            {
                if (checkBlock(pos).AsBool())
                {
                    content.push(getBlock());
                    break;
                }
                else if (checkVariable(pos).AsBool()) content.push(getVariable());
                else if (checkNumber(pos).AsBool()) content.push(getNumber());
                else if (checkInterpolation(pos).AsBool()) content.push(getInterpolation());
                else if (checkIdent(pos).AsBool()) content.push(getIdent());
                else if (checkOperator(pos).AsBool()) content.push(getOperator());
                else if (checkCombinator(pos).AsBool()) content.push(getCombinator());
                else if (checkSC(pos).AsBool()) content = content.concat(getSC());
                else if (checkString(pos).AsBool()) content.push(getString());
            }

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is part of a mixin
         * @param {number} i Token's index number
         * @return {number} Length of the mixin
         */
        public int checkMixin(int i)
        {
            return Of(checkMixin1(i), checkMixin2(i));
        }

        /**
         * Get node with a mixin
         * @return {Array} `['mixin', x]`
         */
        public Node getMixin()
        {
            return checkMixin1(pos).AsBool() ? getMixin1() : getMixin2();
        }

        /**
         * Check if token is part of a mixin
         * @param {number} i Token's index number
         * @return {number} Length of the mixin
         */
        public int checkMixin1(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if (((l = checkAtkeyword(i)).AsBool()) && tokens[i + 1].value == "mixin") i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkBlock(i)).AsBool()) i += l;
            else
            {
                if ((l = checkArguments(i)).AsBool()) i += l;

                if ((l = checkSC(i)).AsBool()) i += l;

                if ((l = checkBlock(i)).AsBool()) i += l;
                else return 0;
            }

            return i - start;
        }

        /**
         * Get node with a mixin
         * @return {Array} `['mixin', x]`
         */
        public Node getMixin1()
        {
            var type = NodeType.MixinType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
              getAtkeyword(),
              getSC()
            );

            if (checkIdentOrInterpolation(pos).AsBool())
                content = content.concat(getIdentOrInterpolation());

            content = content.concat(getSC());

            if (checkBlock(pos).AsBool()) content.push(getBlock());
            else
            {
                if (checkArguments(pos).AsBool()) content.push(getArguments());

                content = content.concat(getSC());

                content.push(getBlock());
            }

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is part of a mixin
         * @param {number} i Token's index number
         * @return {number} Length of the mixin
         */
        public int checkMixin2(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if (tokens[i].type == TokenType.EqualsSign) i++;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkBlock(i)).AsBool()) i += l;
            else
            {
                if ((l = checkArguments(i)).AsBool()) i += l;

                if ((l = checkSC(i)).AsBool()) i += l;

                if ((l = checkBlock(i)).AsBool()) i += l;
                else return 0;
            }

            return i - start;
        }

        /**
        * Get node with a mixin
        * @return {Array} `['mixin', x]`
*/
        public Node getMixin2()
        {
            var type = NodeType.MixinType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>().concat(
              getOperator(),
              getSC()
            );

            if (checkIdentOrInterpolation(pos).AsBool())
                content = content.concat(getIdentOrInterpolation());

            content = content.concat(getSC());

            if (checkBlock(pos).AsBool()) content.push(getBlock());
            else
            {
                if (checkArguments(pos).AsBool()) content.push(getArguments());

                content = content.concat(getSC());

                content.push(getBlock());
            }

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is a namespace sign (`|`)
         * @param {number} i Token's index number
         * @return {number} `1` if token is `|`, `0` if not
         */
        public int checkNamespace(int i)
        {
            return i < tokensLength && tokens[i].type == TokenType.VerticalLine ? 1 : 0;
        }

        /**
         * Get node with a namespace sign
         * @return {Array} `['namespace']`
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
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkNmName2(int i)
        {
            if (tokens[i].type == TokenType.Identifier) return 1;
            else if (tokens[i].type != TokenType.DecimalNumber) return 0;

            i++;

            return i < tokensLength && tokens[i].type == TokenType.Identifier ? 2 : 1;
        }

        /**
         * @return {string}
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
         * @param {number} i Token's index number
         * @return {number} Length of number
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
         * @return {Array} `['number', x]` where `x` is a number converted
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
         * Check if token is an operator (`/`, `%`, `,`, `:` or `=`).
         * @param {number} i Token's index number
         * @return {number} `1` if token is an operator, otherwise `0`
         */
        public int checkOperator(int i)
        {
            if (i >= tokensLength) return 0;

            switch (tokens[i].type)
            {
                case TokenType.Solidus:
                case TokenType.PercentSign:
                case TokenType.Comma:
                case TokenType.Colon:
                case TokenType.EqualsSign:
                case TokenType.EqualitySign:
                case TokenType.InequalitySign:
                case TokenType.LessThanSign:
                case TokenType.GreaterThanSign:
                case TokenType.Asterisk:
                    return 1;
            }

            return 0;
        }

        /**
         * Get node with an operator
         * @return {Array} `['operator', x]` where `x` is an operator converted
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
         * Check if token is part of `!optional` word
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkOptional(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength ||
                tokens[i++].type != TokenType.ExclamationMark) return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if (tokens[i].value == "optional")
            {
                tokens[start].optionalEnd = i;
                return i - start + 1;
            }
            else
            {
                return 0;
            }
        }

        /**
         * Get node with `!optional` word
         */
        public Node getOptional()
        {
            var type = NodeType.OptionalType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = joinValues(pos, token.optionalEnd);

            pos = token.optionalEnd + 1;

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is part of text inside parentheses, e.g. `(1)`
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkParentheses(int i)
        {
            if (i >= tokensLength) return 0;

            var start = i;
            var right = tokens[i].right;
            int l;

            // Skip `(`.
            if (tokens[i].type == TokenType.LeftParenthesis) i++;
            else return 0;

            if (i < right)
            {
                if ((l = checkTsets(i)).AsBool()) i += l;
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
         * Check if token is a parent selector, e.g. `&`
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkParentSelector(int i)
        {
            return i < tokensLength && tokens[i].type == TokenType.Ampersand ? 1 : 0;
        }

        /**
         * Get node with a parent selector
         * @return {Node}
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

        /**
         * Check if token is a parent selector extension, e.g. `&--foo-bar`
         * @param {number} i Token's index number
         * @returns {number} Length of the parent selector extension
         */
        public int checkParentSelectorExtension(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            while (i < tokensLength)
            {
                if ((l = Of(checkIdentOrInterpolation(i), checkPartialIdent(i))).AsBool()) i += l;
                else break;
            }

            return i - start;
        }

        /**
         * Get parent selector extension node
         * @return {Node}
         */
        public Node getParentSelectorExtension()
        {
            var type = NodeType.ParentSelectorExtensionType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            while (pos < tokensLength)
            {
                if (checkIdentOrInterpolation(pos).AsBool())
                {
                    content = content.concat(getIdentOrInterpolation());
                }
                else if (checkPartialIdent(pos).AsBool())
                {
                    content.push(getIdent());
                }
                else break;
            }

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is a parent selector with an extension or not
         * @param {number} i Token's index number
         * @return {number} Length of the parent selector and extension if applicable
         */
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

        /**
         * Get parent selector node and extension node if applicable
         * @return {Array}
         */
        public List<Node> getParentSelectorWithExtension()
        {
            var content = new List<Node>(){ getParentSelector() };

            if (checkParentSelectorExtension(pos).AsBool())
                content.push(getParentSelectorExtension());

            return content;
        }

        /**
         * Check if token is part of a number or an interpolation with a percent sign
         * (e.g. `10%`).
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkPercentage(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkNumberOrInterpolation(i)).AsBool()) i += l;
            else return 0;

            if (i >= tokensLength) return 0;

            // Skip `%`.
            if (tokens[i].type == TokenType.PercentSign) i++;
            else return 0;

            return i - start;
        }

        /**
         * Get a percentage node that contains either a number or an interpolation
         * @return {Object} The percentage node
         */
        public Node getPercentage()
        {
            var type = NodeType.PercentageType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = getNumberOrInterpolation();
            var end = getLastPosition(content, line, column, 1);

            // Skip `%`.
            pos++;

            return newNode(type, content, line, column, end);
        }

        /**
         * Check if token is a number or an interpolation
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkNumberOrInterpolation(int i)
        {
            var start = i;
            int l;

            while (i < tokensLength)
            {
                if ((l = Of(checkInterpolation(i), checkNumber(i))).AsBool()) i += l;
                else break;
            }

            return i - start;
        }

        /**
         * Get a number and/or interpolation node
         * @return {Array} An array containing a single or multiple nodes
         */
        public List<Node> getNumberOrInterpolation()
        {
            var content = new List<Node>();

            while (pos < tokensLength)
            {
                if (checkInterpolation(pos).AsBool()) content.push(getInterpolation());
                else if (checkNumber(pos).AsBool()) content.push(getNumber());
                else break;
            }

            return content;
        }

        /**
         * Check if token is part of a placeholder selector (e.g. `%abc`).
         * @param {number} i Token's index number
         * @return {number} Length of the selector
         */
        public int checkPlaceholder(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if (tokens[start].placeholder_l.AsBool()) return tokens[start].placeholder_l;

            // Skip `%`.
            if (tokens[i].type == TokenType.PercentSign) i++;
            else return 0;

            if ((l = checkIdentOrInterpolation(i)).AsBool())
            {
                i += l;
                tokens[start].placeholder_l = i - start;
            }
            else return 0;

            return i - start;
        }

        /**
         * Get node with a placeholder selector
         * @return {Array} `['placeholder', ['ident', x]]` where x is a placeholder's
         *      identifier (without `%`, e.g. `abc`).
         */
        public Node getPlaceholder()
        {
            var type = NodeType.PlaceholderType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            // Skip `%`.
            pos++;

            content = content.concat(getIdentOrInterpolation());

            return newNode(type, content, line, column);
        }

        /**
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkProgid(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if (joinValues2(i, 6) == "progid:DXImageTransform.Microsoft.") i += 6;
            else return 0;

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
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
         * @return {Array}
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
         * @return {Number} Length of the property
         */
        public int checkProperty(int i)
        {
            var start = i;
            int l;

            if ((l = checkProperty1(i)).AsBool()) tokens[start].propertyType = 1;
            else if ((l = checkProperty2(i)).AsBool()) tokens[start].propertyType = 2;
            else if ((l = checkProperty3(i)).AsBool()) tokens[start].propertyType = 3;

            return l;
        }

        /**
         * Get node with a property
         * @return {!Node}
         */
        public Node getProperty()
        {
            var type = tokens[pos].propertyType;

            if (type == 1) return getProperty1();
            if (type == 2) return getProperty2();
            if (type == 3) return getProperty3();

            return default;
        }

        /**
         * Check if token is part of a property
         * (1) `foo`
         * (2) `#{$foo}`
         * @param {Number} i Token's index number
         * @returns {Number} Length of the property
         */
        public int checkProperty1(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * Get node with a property
         * @returns {Array}
         */
        public Node getProperty1()
        {
            var type = NodeType.PropertyType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = getIdentOrInterpolation();

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is part of a custom property
         * (1) `--foo-bar`
         * @param {Number} i Token's index number
         * @return {Number} Length of the property
         */
        public int checkProperty2(int i)
        {
            return checkCustomProperty(i);
        }

        /**
         * Get node with a custom property
         * @return {Node}
         */
        public Node getProperty2()
        {
            return getCustomProperty();
        }

        /**
         * Check if token is part of a property
         * (1) `$foo`
         * @param {Number} i Token's index number
         * @returns {Number} Length of the property
         */
        public int checkProperty3(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkVariable(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * Get node with a property
         * @returns {Array} `['property', x]`
         */
        public Node getProperty3()
        {
            var type = NodeType.PropertyType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>(){ getVariable() };

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is part of a custom property
         * @param {Number} i Token's index number
         * @return {Number} Length of the property
         */
        public int checkCustomProperty(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if (tokens[i].type != TokenType.HyphenMinus ||
                tokens.Has(i + 1) && tokens[i + 1].type != TokenType.HyphenMinus) return 0;

            // Skip `--`
            i += 2;

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * Get node with a custom property
         * @return {Node}
         */
        public Node getCustomProperty()
        {
            var type = NodeType.CustomPropertyType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;

            // Skip `--`
            pos += 2;

            var content = getIdentOrInterpolation();

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is a colon
         * @param {number} i Token's index number
         * @return {number} `1` if token is a colon, otherwise `0`
         */
        public int checkPropertyDelim(int i)
        {
            return i < tokensLength && tokens[i].type == TokenType.Colon ? 1 : 0;
        }

        /**
         * Get node with a colon
         * @return {Array} `['propertyDelim']`
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
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkPseudo(int i)
        {
            return Of(checkPseudoe(i),
                      checkPseudoc(i));
        }

        /**
         * @return {Array}
         */
        public Node getPseudo()
        {
            if (checkPseudoe(pos).AsBool()) return getPseudoe();
            if (checkPseudoc(pos).AsBool()) return getPseudoc();

            return default;
        }

        /**
         * @param {Number} i Token's index number
         * @return {Number}
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
         * @return {Node}
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

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * @return {Node}
         */
        public Node getPseudoElement2()
        {
            var type = NodeType.PseudoeType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;

            // Skip `::`.
            pos += 2;

            var content = getIdentOrInterpolation();

            return newNode(type, content, line, column);
        }

        /**
         * @param {number} i Token's index number
         * @return {number}
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

        /**
         * @return {Array}
         */
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
         * (-) `:not(panda)`
         */
        public int checkPseudoClass1(int i)
        {
            var start = i;
            int l;

            // Skip `:`.
            i++;

            if (i >= tokensLength) return 0;

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
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

            content = content.concat(getIdentOrInterpolation());

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
            int l;

            // Skip `:`.
            i++;

            if (i >= tokensLength) return 0;

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
            else return 0;

            if (i >= tokensLength ||
                tokens[i].type != TokenType.LeftParenthesis) return 0;

            var right = tokens[i].right;

            // Skip `(`.
            i++;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
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

            content = content.concat(getIdentOrInterpolation());

            var l = tokens[pos].ln;
            var c = tokens[pos].col;

            // Skip `(`.
            pos++;

            var value = new List<Node>().concat(
              getSC(),
              getIdentOrInterpolation(),
              getSC()
            );

            var end = getLastPosition(value, l, c, 1);
            var args = newNode(NodeType.ArgumentsType, value, l, c, end);
            content.push(args);

            // Skip `)`.
            pos++;

            return newNode(type, content, line, column);
        }

        /**
         * (-) `:nth-child(-3n + 2)`
         */
        public int checkPseudoClass3(int i)
        {
            var start = i;
            int l;

            // Skip `:`.
            i++;

            if (i >= tokensLength) return 0;

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
            else return 0;

            if (i >= tokensLength ||
                tokens[i].type != TokenType.LeftParenthesis) return 0;

            var right = tokens[i].right;

            // Skip `(`.
            i++;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkUnary(i)).AsBool()) i += l;

            if ((l = checkNumberOrInterpolation(i)).AsBool()) i += l;

            if (i >= tokensLength) return 0;

            if (tokens[i].value == "n") i++;

            if ((l = checkSC(i)).AsBool()) i += l;

            if (i >= tokensLength) return 0;

            if (tokens[i].type == TokenType.PlusSign ||
                tokens[i].type == TokenType.HyphenMinus) i++;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkNumberOrInterpolation(i)).AsBool()) i += l;
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

            content = content.concat(getIdentOrInterpolation());

            var l = tokens[pos].ln;
            var c = tokens[pos].col;
            var value = new List<Node>();

            // Skip `(`.
            pos++;

            value = value.concat(getSC());

            if (checkUnary(pos).AsBool()) value.push(getUnary());
            if (checkNumberOrInterpolation(pos).AsBool())
                value = value.concat(getNumberOrInterpolation());

            {
                var _token = tokens[pos];

                if (_token.value == "n")
                {
                    var _l = _token.ln;
                    var _c = _token.col;
                    var _content = _token.value;
                    var ident = newNode(NodeType.IdentType, _content, _l, _c);
                    value.push(ident);
                    pos++;
                }
            }

            value = value.concat(getSC());

            if (checkUnary(pos).AsBool()) value.push(getUnary());

            value = value.concat(getSC());

            if (checkNumberOrInterpolation(pos).AsBool())
                value = value.concat(getNumberOrInterpolation());

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
            int l;

            // Skip `:`.
            i++;

            if (i >= tokensLength) return 0;

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
            else return 0;

            if (i >= tokensLength) return 0;
            if (tokens[i].type != TokenType.LeftParenthesis) return 0;

            var right = tokens[i].right;

            // Skip `(`.
            i++;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkUnary(i)).AsBool()) i += l;

            if ((l = checkInterpolation(i)).AsBool()) i += l;

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

            content = content.concat(getIdentOrInterpolation());

            var l = tokens[pos].ln;
            var c = tokens[pos].col;
            var value = new List<Node>();

            // Skip `(`.
            pos++;

            value = value.concat(getSC());

            if (checkUnary(pos).AsBool()) value.push(getUnary());
            if (checkInterpolation(pos).AsBool()) value.push(getInterpolation());
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
            int l;

            // Skip `:`.
            i++;

            if (i >= tokensLength) return 0;

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
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

            content = content.concat(getIdentOrInterpolation());

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
            int l;

            // Skip `:`.
            i++;

            if (i >= tokensLength) return 0;

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        public Node getPseudoClass6()
        {
            var type = NodeType.PseudocType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;

            // Skip `:`.
            pos++;

            var content = getIdentOrInterpolation();

            return newNode(type, content, line, column);
        }

        /**
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkRuleset(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkSelectorsGroup(i)).AsBool()) i += l;
            else return 0;

            if ((l = checkSC(i)).AsBool()) i += l;

            if ((l = checkBlock(i)).AsBool())
            {
                i += l;
            }
            else if ((l = checkSC(i)).AsBool())
            {
                i += l;
                if ((l = checkBlock(i)).AsBool()) i += l;
                else return 0;
            }
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
              getSC()
            );

            if (checkBlock(pos).AsBool())
            {
                content.push(getBlock());
            }
            else
            {
                content = content.concat(getSC(), getBlock());
            }

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is marked as a space (if it's a space or a tab
         *      or a line break).
         * @param {number} i
         * @return {number} Number of spaces in a row starting with the given token.
         */
        public int checkS(int i)
        {
            return i < tokensLength && tokens[i].ws ? tokens[i].ws_last - i + 1 : 0;
        }

        /**
         * Get node with spaces
         * @return {Array} `['s', x]` where `x` is a string containing spaces
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
         * Check if token is a space, newline, or a comment.
         * @param {number} i Token's index number
         * @return {number} Number of similar (space, newline, or comment) tokens
         *      in a row starting with the given token.
         */
        public int checkMultilineSC(int i)
        {
            if (!tokens.Has(i)) return 0;

            int l;
            var lsc = 0;

            while (i < tokensLength)
            {
                if (!((l = checkS(i)).AsBool()) &&
                  !((l = checkCommentML(i)).AsBool()) &&
                  !((l = checkCommentSL(i)).AsBool())) break;

                i += l;
                lsc += l;
            }

            return Of(lsc, 0);
        }

        /**
         * Get node with spaces newlines and comments
         * @return {!Node}
         */
        public List<Node> getMultilineSC()
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
         * Check if token is a space or a comment.
         * @param {number} i Token's index number
         * @return {number} Number of similar (space or comment) tokens
         *      in a row starting with the given token.
         */
        public int checkSC(int i)
        {
            if (i >= tokensLength) return 0;

            int l;
            var lsc = 0;
            var ln = tokens[i].ln;

            while (i < tokensLength)
            {
                if (tokens[i].ln != ln) break;

                if ((l = checkS(i)).AsBool()) tokens[i].sc_child = 1;
                else if ((l = checkCommentML(i)).AsBool()) tokens[i].sc_child = 2;
                else if ((l = checkCommentSL(i)).AsBool()) tokens[i].sc_child = 3;
                else break;

                i += l;
                lsc += l;

                if (tokens.Has(i) && tokens[i].type == TokenType.Newline) break;
            }

            return Of(lsc, 0);
        }

        /**
         * Get node with spaces and comments
         * @return {Array} Array containing nodes with spaces (if there are any)
         *      and nodes with comments (if there are any):
         *      `[['s', x]*, ['comment', y]*]` where `x` is a string of spaces
         *      and `y` is a comment's text (without `/*` and `* /`).
         */
        public List<Node> getSC()
        {
            var sc = new List<Node>();

            if (pos >= tokensLength) return sc;

            var ln = tokens[pos].ln;

            while (pos < tokensLength)
            {
                if (tokens[pos].ln != ln) break;
                else if (checkS(pos).AsBool()) sc.push(getS());
                else if (checkCommentML(pos).AsBool()) sc.push(getCommentML());
                else if (checkCommentSL(pos).AsBool()) sc.push(getCommentSL());
                else break;

                if (tokens.Has(pos) && tokens[pos].type == TokenType.Newline) break;
            }

            return sc;
        }

        /**
         * Check if token is part of a hexadecimal number (e.g. `#fff`) inside a simple
         * selector
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkShash(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            if (tokens[i].type == TokenType.NumberSign) i++;
            else return 0;

            if ((l = Of(checkIdentOrInterpolation(i), checkPartialIdent(i))).AsBool()) i += l;
            else return 0;

            while (i < tokensLength)
            {
                if ((l = Of(checkIdentOrInterpolation(i), checkPartialIdent(i))).AsBool()) i += l;
                else break;
            }

            tokens[start].shashEnd = i;

            return i - start;
        }

        /**
         * Get node with a hexadecimal number (e.g. `#fff`) inside a simple selector
         * @return {Node}
         */
        public Node getShash()
        {
            var type = NodeType.ShashType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var end = token.shashEnd;
            var content = new List<Node>();

            // Skip `#`.
            pos++;

            while (pos < end)
            {
                if (checkIdentOrInterpolation(pos).AsBool())
                {
                    content = content.concat(getIdentOrInterpolation());
                }
                else if (checkPartialIdent(pos).AsBool())
                {
                    content.push(getIdent());
                }
                else break;
            }

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is part of a string (text wrapped in quotes)
         * @param {number} i Token's index number
         * @return {number} `1` if token is part of a string, `0` if not
         */
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

        /**
         * Get string's node
         * @return {Array} `['string', x]` where `x` is a string (including
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
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkStylesheet(int i)
        {
            var start = i;
            int l;

            while (i < tokensLength)
            {
                if ((l = Of(checkSC(i),
                            checkDeclaration(i),
                            checkDeclDelim(i),
                            checkInclude(i),
                            checkExtend(i),
                            checkMixin(i),
                            checkLoop(i),
                            checkConditionalStatement(i),
                            checkAtrule(i),
                            checkRuleset(i))).AsBool()) i += l;
                else throwError(i);
            }

            return i - start;
        }

        /**
         * @return {Array} `['stylesheet', x]` where `x` is all stylesheet's
         *      nodes.
         */
        public Node getStylesheet()
        {
            var type = NodeType.StylesheetType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();
            UnionList<Node> node = default;
            var wasDeclaration = false;

            while (pos < tokensLength)
            {
                if (wasDeclaration && checkDeclDelim(pos).AsBool()) node = getDeclDelim();
                else if (checkSC(pos).AsBool()) node = getSC();
                else if (checkRuleset(pos).AsBool()) node = getRuleset();
                else if (checkInclude(pos).AsBool()) node = getInclude();
                else if (checkExtend(pos).AsBool()) node = getExtend();
                else if (checkMixin(pos).AsBool()) node = getMixin();
                else if (checkLoop(pos).AsBool()) node = getLoop();
                else if (checkConditionalStatement(pos).AsBool()) node = getConditionalStatement();
                else if (checkAtrule(pos).AsBool()) node = getAtrule();
                else if (checkDeclaration(pos).AsBool()) node = getDeclaration();
                else throwError(pos);

                wasDeclaration = node.IsElement && node.AsT0.type == NodeType.DeclarationType;
                if (node.IsArray) content = content.concat(node);
                else content.push(node);
            }

            return newNode(type, content, line, column);
        }

        /**
         * @param {Number} i Token's index number
         * @return {Number}
         */
        public int checkTset(int i)
        {
            return Of(checkVhash(i),
                      checkOperator(i),
                      checkAny(i),
                      checkSC(i));
        }

        /**
         * @return {Array}
         */
        public UnionList<Node> getTset()
        {
            if (checkVhash(pos).AsBool()) return getVhash();
            else if (checkOperator(pos).AsBool()) return getOperator();
            else if (checkAny(pos).AsBool()) return getAny();
            else if (checkSC(pos).AsBool()) return getSC();

            return default;
        }

        /**
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkTsets(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            while (tokens[i - 1].type != TokenType.Newline &&
                  ((l = checkTset(i)).AsBool()))
            {
                i += l;
            }

            return i - start;
        }

        /**
         * @return {Array}
         */
        public List<Node> getTsets()
        {
            var content = new List<Node>();
            Node t;

            while (tokens[pos - 1].type != TokenType.Newline &&
                  (t = getTset().AsT0) != default)
            {
                if (t.content.IsString) content.push(t);
                else content = content.concat(t);
            }

            return content;
        }

        /**
         * Check if token is an unary (arithmetical) sign (`+` or `-`)
         * @param {number} i Token's index number
         * @return {number} `1` if token is an unary sign, `0` if not
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
         * @return {Array} `['unary', x]` where `x` is an unary sign
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
            string[] units = [
                "em", "ex", "ch", "rem",
                "vh", "vw", "vmin", "vmax",
                "px", "mm", "q", "cm", "in", "pt", "pc",
                "deg", "grad", "rad", "turn",
                "s", "ms",
                "Hz", "kHz",
                "dpi", "dpcm", "dppx"
            ];

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
         * Check if token is part of URI, e.g. `url('/css/styles.css')`
         * @param {number} i Token's index number
         * @returns {number} Length of URI
         */
        public int checkUri(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength || tokens[i].value != "url") return 0;

            // Skip `url`.
            i++;

            if (i >= tokensLength || tokens[i].type != TokenType.LeftParenthesis)
                return 0;

            // Store the opening parenthesis token as we will reference it's `right`
            // property to determine when the parentheses close
            var leftParenthesis = tokens[i];

            // Skip `(`.
            i++;

            // Determine the type of URI
            while (i < leftParenthesis.right)
            {
                if ((l = checkUri1(i)).AsBool())
                {
                    i += l;
                    tokens[start].uriType = 1; // Raw based URI (without quotes)
                }
                else if ((l = checkUri2(i)).AsBool())
                {
                    i += l;
                    tokens[start].uriType = 2; // Non-raw based URI (with quotes)
                }
                else return 0;
            }

            // Skip `)`.
            i++;

            return i - start;
        }

        /**
         * Get specific type of URI node
         * @return {Node} Specific type of URI node
         */
        public Node getUri()
        {
            var startPos = pos;
            var type = NodeType.UriType;
            var token = tokens[startPos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();
            int[]? end = null;

            var uriType = tokens[startPos].uriType;

            // Skip `url` and `(`.
            pos += 2;

            if (uriType == 1) content = content.concat(getUri1());
            else if (uriType == 2) content = content.concat(getUri2());
            else end = getLastPosition(content, line, column, 4);

            if (end != null) end = getLastPosition(content, line, column, 1);

            // Skip `)`.
            pos++;

            return newNode(type, content, line, column, end);
        }

        /**
         * Check if token type is valid URI character
         * @param {number} i Token's index number
         * @return {number} Length of raw node
         */
        public int checkUriRawCharacters(int i)
        {
            var start = i;
            int l;

            if ((l = checkIdent(i)).AsBool()) i += l;
            else if ((l = checkNumber(i)).AsBool()) i += l;
            else
            {
                switch (tokens[i].type)
                {
                    case TokenType.ExclamationMark:
                    case TokenType.NumberSign:
                    case TokenType.DollarSign:
                    case TokenType.PercentSign:
                    case TokenType.Ampersand:
                    case TokenType.Asterisk:
                    case TokenType.PlusSign:
                    case TokenType.Comma:
                    case TokenType.HyphenMinus:
                    case TokenType.FullStop:
                    case TokenType.Solidus:
                    case TokenType.Colon:
                    case TokenType.Semicolon:
                    case TokenType.LessThanSign:
                    case TokenType.EqualsSign:
                    case TokenType.GreaterThanSign:
                    case TokenType.QuotationMark:
                    case TokenType.CommercialAt:
                    case TokenType.LeftSquareBracket:
                    case TokenType.RightSquareBracket:
                    case TokenType.CircumflexAccent:
                    case TokenType.LowLine:
                    case TokenType.LeftCurlyBracket:
                    case TokenType.VerticalLine:
                    case TokenType.RightCurlyBracket:
                    case TokenType.Tilde:
                        i += 1;
                        break;

                    default:
                        return 0;
                }
            }

            return i - start;
        }

        /**
         * Check if content of URI can be contained within a raw node
         * @param {number} i Token's index number
         * @return {number} Length of raw node
         */
        public int checkUriRaw(int i)
        {
            var start = i;
            int l;

            while (i < tokensLength)
            {
                if (checkInterpolation(i).AsBool() || checkVariable(i).AsBool()) break;
                else if ((l = checkUriRawCharacters(i)).AsBool()) i += l;
                else break;
            }

            tokens[start].uri_raw_end = i;

            return i - start;
        }

        /**
         * Get a raw node
         * @return {Node}
         */
        public Node getUriRaw()
        {
            var startPos = pos;
            var type = NodeType.RawType;
            var token = tokens[startPos];
            var line = token.ln;
            var column = token.col;
            var content = "";
            int l;

            while (pos < tokens[startPos].uri_raw_end)
            {
                if (checkInterpolation(pos).AsBool() || checkVariable(pos).AsBool()) break;
                else if ((l = checkUriRawCharacters(pos)).AsBool()) pos += l;
                else break;
            }

            content = joinValues(startPos, pos - 1);

            return newNode(type, content, line, column);
        }

        /**
         * Check for a raw (without quotes) URI
         * (1) http://foo.com/bar.png
         * (2) http://foo.com/#{$bar}.png
         * (3) #{$foo}/bar.png
         * (4) #{$foo}
         * @param {number} i Token's index number
         * @return {number} Length of URI node
         */
        public int checkUri1(int i)
        {
            var start = i;
            int l;

            if ((l = checkSC(i)).AsBool()) i += l;

            while (i < tokensLength)
            {
                if ((l = Of(checkInterpolation(i), checkUriRaw(i))).AsBool()) i += l;
                else break;
            }

            if ((l = checkSC(i)).AsBool()) i += l;

            // Check that we are at the end of the uri
            if (i < tokens[start - 1].right) return 0;

            tokens[start].uri_end = i;

            return i - start;
        }

        /**
         * Get a raw (without quotes) URI
          node
         * @return {Array}
         */
        public List<Node> getUri1()
        {
            var startPos = pos;
            var content = new List<Node>();

            if (checkSC(pos).AsBool()) content = content.concat(getSC());

            while (pos < tokens[startPos].uri_end)
            {
                if (checkInterpolation(pos).AsBool()) content.push(getInterpolation());
                else if (checkUriRaw(pos).AsBool()) content.push(getUriRaw());
                else break;
            }

            if (checkSC(pos).AsBool()) content = content.concat(getSC());

            return content;
        }

        /**
         * Check for a non-raw (with quotes) URI
         * (1) 'http://foo.com/bar.png'
         * (2) 'http://foo.com/'#{$bar}.png
         * (3) #{$foo}'/bar.png'
         * @param {number} i Token's index number
         * @return {number} Length of URI node
         */
        public int checkUri2(int i)
        {
            var start = i;
            int l;

            while (i < tokensLength)
            {
                if ((l = checkSC(i)).AsBool()) i += l;
                else if ((l = checkString(i)).AsBool()) i += l;
                else if ((l = checkFunction(i)).AsBool()) i += l;
                else if ((l = checkUnary(i)).AsBool()) i += l;
                else if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
                else if ((l = checkVariable(i)).AsBool()) i += l;
                else break;
            }

            // Check that we are at the end of the uri
            if (i < tokens[start - 1].right) return 0;

            tokens[start].uri_end = i;

            return i - start;
        }

        /**
         * Get a non-raw (with quotes) URI node
         * @return {Array}
         */
        public List<Node> getUri2()
        {
            var startPos = pos;
            var content = new List<Node>();

            while (pos < tokens[startPos].uri_end)
            {
                if (checkSC(pos).AsBool()) content = content.concat(getSC());
                else if (checkUnary(pos).AsBool()) content.push(getUnary());
                else if (_checkValue(pos).AsBool()) content.push(_getValue());
                else break;
            }

            return content;
        }

        /**
         * Check if token is part of a value
         * @param {number} i Token's index number
         * @return {number} Length of the value
         */
        public int checkValue(int i)
        {
            var start = i;
            int l;
            int s;
            int _i;

            while (i < tokensLength)
            {
                if (checkDeclDelim(i).AsBool()) break;

                if ((l = checkBlock(i)).AsBool())
                {
                    i += l;
                    break;
                }

                s = checkS(i);
                _i = i + s;

                if ((l = _checkValue(_i)).AsBool()) i += l + s;
                if (!l.AsBool() || checkBlock(i - l).AsBool()) break;
            }

            return i - start;
        }

        /**
         * @return {Array}
         */
        public Node getValue()
        {
            var type = NodeType.ValueType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();
            int _pos;
            int s;

            while (pos < tokensLength)
            {
                if (checkDeclDelim(pos).AsBool()) break;

                s = checkS(pos);
                _pos = pos + s;

                if (checkDeclDelim(_pos).AsBool()) break;

                if (checkBlock(pos).AsBool())
                {
                    content.push(getBlock());
                    break;
                }

                if (!_checkValue(_pos).AsBool()) break;

                if (s.AsBool()) content.push(getS());
                content.push(_getValue());

                if (checkBlock(_pos).AsBool()) break;
            }

            return newNode(type, content, line, column);
        }

        /**
         * @param {number} i Token's index number
         * @return {number}
         */
        public int _checkValue(int i)
        {
            int l;

            if ((l = checkInterpolation(i)).AsBool()) tokens[i].value_child = 1;
            else if ((l = checkVariable(i)).AsBool()) tokens[i].value_child = 2;
            else if ((l = checkVhash(i)).AsBool()) tokens[i].value_child = 3;
            else if ((l = checkBlock(i)).AsBool()) tokens[i].value_child = 4;
            else if ((l = checkAtkeyword(i)).AsBool()) tokens[i].value_child = 5;
            else if ((l = checkOperator(i)).AsBool()) tokens[i].value_child = 6;
            else if ((l = checkImportant(i)).AsBool()) tokens[i].value_child = 7;
            else if ((l = checkGlobal(i)).AsBool()) tokens[i].value_child = 8;
            else if ((l = checkDefault(i)).AsBool()) tokens[i].value_child = 9;
            else if ((l = checkProgid(i)).AsBool()) tokens[i].value_child = 10;
            else if ((l = checkAny(i)).AsBool()) tokens[i].value_child = 11;
            else if ((l = checkParentSelector(i)).AsBool()) tokens[i].value_child = 12;

            return l;
        }

        /**
         * @return {Array}
         */
        public Node _getValue()
        {
            var childType = tokens[pos].value_child;
            if (childType == 1) return getInterpolation();
            if (childType == 2) return getVariable();
            if (childType == 3) return getVhash();
            if (childType == 4) return getBlock();
            if (childType == 5) return getAtkeyword();
            if (childType == 6) return getOperator();
            if (childType == 7) return getImportant();
            if (childType == 8) return getGlobal();
            if (childType == 9) return getDefault();
            if (childType == 10) return getProgid();
            if (childType == 11) return getAny();
            if (childType == 12) return getParentSelector();

            return default;
        }

        /**
         * @param {number} i Token's index number
         * @returns {number} Length of the value
         */
        public int checkSingleValue(int i)
        {
            var start = i;
            int l;
            int s;
            int _i;

            while (i < tokensLength)
            {
                if (checkDeclDelim(i).AsBool() || checkDelim(i).AsBool()) break;

                if ((l = checkBlock(i)).AsBool())
                {
                    i += l;
                    break;
                }

                s = checkSC(i);
                _i = i + s;

                if ((l = _checkValue(_i)).AsBool()) i += l + s;
                if (!l.AsBool() || checkBlock(i - l).AsBool()) break;
            }

            return i - start;
        }

        /**
         * @returns {Array}
         */
        public Node getSingleValue()
        {
            var type = NodeType.ValueType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();
            int _pos;
            int s;

            while (pos < tokensLength)
            {
                if (checkDeclDelim(pos).AsBool() || checkDelim(pos).AsBool()) break;

                s = checkSC(pos);
                _pos = pos + s;

                if (checkDeclDelim(_pos).AsBool() || checkDelim(_pos).AsBool()) break;

                if (checkBlock(pos).AsBool())
                {
                    content.push(getBlock());
                    break;
                }

                if (!_checkValue(_pos).AsBool()) break;

                if (s.AsBool()) content.push(getS());
                content.push(_getValue());

                if (checkBlock(_pos).AsBool()) break;
            }

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is part of a variable
         * @param {number} i Token's index number
         * @return {number} Length of the variable
         */
        public int checkVariable(int i)
        {
            var start = i;
            int l;

            if (i >= tokensLength) return 0;

            // Skip `$`.
            if (tokens[i].type == TokenType.DollarSign) i++;
            else return 0;

            if ((l = checkIdent(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * Get node with a variable
         * @return {Array} `['variable', ['ident', x]]` where `x` is
         *      a variable name.
         */
        public Node getVariable()
        {
            var type = NodeType.VariableType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;

            // Skip `$`.
            pos++;

            var content = new List<Node>(){ getIdent() };

            return newNode(type, content, line, column);
        }

        /**
         * Check if token is part of a variables list (e.g. `$values...`).
         * @param {number} i Token's index number
         * @return {number}
         */
        public int checkVariablesList(int i)
        {
            var d = 0; // Number of dots
            int l;

            if (i >= tokensLength) return 0;

            if ((l = checkVariable(i)).AsBool()) i += l;
            else return 0;

            while (i < tokensLength && tokens[i].type == TokenType.FullStop)
            {
                d++;
                i++;
            }

            return d == 3 ? l + d : 0;
        }

        /**
         * Get node with a variables list
         * @return {Array} `['variableslist', ['variable', ['ident', x]]]` where
         *      `x` is a variable name.
         */
        public Node getVariablesList()
        {
            var type = NodeType.VariablesListType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            List<Node> content = [getVariable()];
            var end = getLastPosition(content, line, column, 3);

            // Skip `...`.
            pos += 3;

            return newNode(type, content, line, column, end);
        }

        /**
         * Check if token is part of a hexadecimal number (e.g. `#fff`) inside
         *      some value
         * @param {number} i Token's index number
         * @return {number}
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
         * @return {Array} `['vhash', x]` where `x` is a hexadecimal number
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

                var spaceAfter = checkMultilineSC(i + spaceBefore + comma);
                var spaceEnd = spaceAfter.AsBool() ?
                  checkMultilineSC(i + spaceBefore + comma + spaceAfter) : 0;

                if ((l = checkSelector(i + spaceBefore + comma + spaceAfter + spaceEnd)).AsBool())
                    i += spaceBefore + comma + spaceAfter + spaceEnd + l;
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
                  getMultilineSC(),
                  getDelim(),
                  getMultilineSC(),
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
            List<Node> content = [getCombinator()];

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

        /**
         * Check for compound selectors that start with either a type selector,
         * placeholder or parent selector with extension
         * (1) `foo.bar`
         * (2) `foo[attr=val]`
         * (3) `foo:first-of-type`
         * (4) `foo%bar`
         * @param {number} i Token's index
         * @return {number} Compound selector's length
         */
        public int checkCompoundSelector1(int i)
        {
            if (i >= tokensLength) return 0;

            var start = i;
            int l;

            if ((l = Of(checkUniversalSelector(i),
                        checkTypeSelector(i),
                        checkPlaceholder(i),
                        checkParentSelectorWithExtension(i))).AsBool()) i += l;
            else return 0;

            while (i < tokensLength)
            {
                l = Of(checkShash(i),
                           checkClass(i),
                           checkAttributeSelector(i),
                           checkPseudo(i),
                           checkPlaceholder(i),
                           checkInterpolation(i));

                if (l.AsBool()) i += l;
                else break;
            }

            tokens[start].compoundSelectorEnd = i;

            return i - start;
        }

        /**
         * @return {Array} An array of nodes that make up the compound selector
         */
        public List<Node> getCompoundSelector1()
        {
            var sequence = new List<Node>();
            var compoundSelectorEnd = tokens[pos].compoundSelectorEnd;

            if (checkUniversalSelector(pos).AsBool()) sequence.push(getUniversalSelector());
            else if (checkTypeSelector(pos).AsBool()) sequence.push(getTypeSelector());
            else if (checkPlaceholder(pos).AsBool()) sequence.push(getPlaceholder());
            else if (checkParentSelectorWithExtension(pos).AsBool())
                sequence = sequence.concat(getParentSelectorWithExtension());

            while (pos < compoundSelectorEnd)
            {
                if (checkShash(pos).AsBool()) sequence.push(getShash());
                else if (checkClass(pos).AsBool()) sequence.push(getClass());
                else if (checkAttributeSelector(pos).AsBool()) sequence.push(getAttributeSelector());
                else if (checkPseudo(pos).AsBool()) sequence.push(getPseudo());
                else if (checkPlaceholder(pos).AsBool()) sequence.push(getPlaceholder());
                else if (checkInterpolation(pos).AsBool()) sequence.push(getInterpolation());
                else break;
            }

            return sequence;
        }

        /**
         * Check for all other compound selectors
         * (1) `.foo.bar`
         * (2) `.foo[attr=val]`
         * (3) `.foo:first-of-type`
         * (4) `.foo%bar`
         * (5) `.foo#{$bar}`
         * @param {number} i Token's index
         * @return {number} Compound selector's length
         */
        public int checkCompoundSelector2(int i)
        {
            if (i >= tokensLength) return 0;

            var start = i;

            while (i < tokensLength)
            {
                var l = Of(checkShash(i),
                           checkClass(i),
                           checkAttributeSelector(i),
                           checkPseudo(i),
                           checkPlaceholder(i),
                           checkInterpolation(i));

                if (l.AsBool()) i += l;
                else break;
            }

            tokens[start].compoundSelectorEnd = i;

            return i - start;
        }

        /**
         * @return {Array} An array of nodes that make up the compound selector
         */
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
                else if (checkPlaceholder(pos).AsBool()) sequence.push(getPlaceholder());
                else if (checkInterpolation(pos).AsBool()) sequence.push(getInterpolation());
                else break;
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

        /**
         * Check if token is part of a type selector
         * @param {number} i Token's index
         * @return {number} Type selector's length
         */
        public int checkTypeSelector(int i)
        {
            if (i >= tokensLength) return 0;

            var start = i;
            int l;

            if ((l = checkNamePrefix(i)).AsBool()) i += l;

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
            else return 0;

            return i - start;
        }

        /**
         * Get type selector node
         * @return {Node}
         */
        public Node getTypeSelector()
        {
            var type = NodeType.TypeSelectorType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            if (checkNamePrefix(pos).AsBool()) content.push(getNamePrefix());

            content = content.concat(getIdentOrInterpolation());

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

            if ((l = checkIdentOrInterpolation(i)).AsBool()) i += l;
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
            content = content.concat(getIdentOrInterpolation());

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
            return Of(checkString(i), checkIdentOrInterpolation(i));
        }

        public Node getAttributeValue()
        {
            var type = NodeType.AttributeValueType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = new List<Node>();

            if (checkString(pos).AsBool()) content.push(getString());
            else content = content.concat(getIdentOrInterpolation());

            return newNode(type, content, line, column);
        }

        public int checkAttributeFlags(int i)
        {
            return checkIdentOrInterpolation(i);
        }

        public Node getAttributeFlags()
        {
            var type = NodeType.AttributeFlagsType;
            var token = tokens[pos];
            var line = token.ln;
            var column = token.col;
            var content = getIdentOrInterpolation();

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
            List<Node> content = [getNamespaceSeparator()];

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
            else if ((l = checkIdentOrInterpolation(i)).AsBool()) return l;
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
            else if (checkIdentOrInterpolation(pos).AsBool())
                content = content.concat(getIdentOrInterpolation());

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
