using static CssInCs.Compiler.Utility;
using System.Collections.Generic;

namespace CssInCs.Compiler
{
    public class Element
    {
        public string Value { get; set; }
        public Element Root { get; set; }
        public Element Parent { get; set; }
        public string Type { get; set; }
        public List<string> Props { get; set; }
        public List<Element> Children { get; set; }
        public int Line { get; set; }
        public int Column { get; set; }
        public int Length { get; set; }
        public string Return { get; set; }

        public Element()
        {
        }

        public Element(string value, Element root, Element parent, string type, List<string> props, List<Element> children, int line, int column, int length, string @return)
        {
            Value = value;
            Root = root;
            Parent = parent;
            Type = type;
            Props = props;
            Children = children;
            Line = line;
            Column = column;
            Length = length;
            Return = @return;
        }

        public Element(string value, Element root, Element parent, string type, string props, string children, int line, int column, int length, string @return)
        {
            Value = value;
            Root = root;
            Parent = parent;
            Type = type;
            Line = line;
            Column = column;
            Length = length;
            Return = @return;
        }
    }

    public class Tokenizer
    {
        private int line = 1;
        private int column = 1;
        private int length = 0;
        private int position = 0;
        private int character = 0;
        private string characters;
        
        public Tokenizer(string value)
        {
            characters = value;
            line = column = 1;
            length = Strlen(value);
            position = 0;
        }

        public int Next()
        {
            character = position < length ? CharAt(characters, position++) : 0;
            column++;
            if (character == 10)
            {
                column = 1;
                line++;
            }
            return character;
        }

        public string Delimit(int type)
        {
            return Trim(Slice(position - 1, Delimiter(type == 91 ? type + 2 : type == 40 ? type + 1 : type)));
        }

        public string WhiteSpace(int type)
        {
            while ((character = Peek()) !=0)
            {
                if (character < 33)
                    Next();
                else
                    break;
            }

            return Token(type) > 2 || Token(character) > 3 ? "" : " ";
        }

        public string Escaping(int index, int count)
        {
            while (--count != 0 && Next() != 0)
            {
                if (character < 48 || 
                    character > 102 || 
                    (character > 57 && character < 65) ||
                    (character > 70 && character < 97))
                {
                    break;
                }
            }
            // magical code.
            var flag = (count < 6 && Peek() == 32 && Next() == 32);
            return Slice(index, Caret());
        }

        public int Caret()
        {
            return position;
        }

        public int Peek()
        {
            return CharAt(characters, position);
        }

        public string Commenter(int type, int index)
        {
            while (Next() != 0)
            {
                if(type + character == 47 + 10)
                    break;
                else if(type + character == 42 + 42 && Peek() == 47)
                    break;
            }

            return $"/*{Slice(index, position - 1)}*{From(type == 47 ? type : Next())}";
        }

        public Element Node(string value, Element root, Element parent, string type, string props, string children, int len)
        {
            return new Element(value, root, parent, type, props, children, line, column, len, "");
        }

        public Element Node(string value, Element root, Element parent, string type, List<string> props, List<Element> children, int len)
        {
            return new Element(value, root, parent, type, props, children, line, column, len, "");
        }

        public int Prev()
        {
            character = position > 0 ? CharAt(characters, --position) : 0;
            column--;
            if (character == 10)
            {
                column = 1;
                line--;
            }

            return character;
        }

        public string Identifier(int index)
        {
            while (Token(Peek()) == 0)
            {
                Next();
            }
            return Slice(index, position);
        }

        public int Char()
        {
            return character;
        }

        private string Slice(int begin, int end)
        {
            return Substr(characters, begin, end);
        }

        private int Delimiter(int type)
        {
            while (Next() != 0)
            {
                switch (character)
                {
                    case var x when x == type:
                        return position;
                    case 34 or 39:
                        if (type != 34 && type != 39)
                            Delimiter(character);
                        break;
                    case 40:
                        if (type == 41)
                            Delimiter(type);
                        break;
                    case 92:
                        Next();
                        break;
                }
            }

            return position;
        }

        private int Token(int type)
        {
            switch (type)
            {
                case 0 or 9 or 10 or 13 or 32:
                    return 5;
                case 33 or 43 or 44 or 47 or 62 or 64 or 126:
                case 59 or 123 or 125:
                    return 4;
                case 58:
                    return 3;
                case 34 or 39 or 40 or 91:
                    return 2;
                case 41 or 93:
                    return 1;
            }

            return 0;
        }
    }
}
