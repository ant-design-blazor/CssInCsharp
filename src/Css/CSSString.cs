using static CssInCSharp.Compiler.Parser;
using static CssInCSharp.Compiler.Serializer;

namespace CssInCSharp
{
    public struct CSSString
    {
        private string _value;
        private string _className;

        public CSSString(string value, string className = default)
        {
            _value = value;
            _className = className;
        }

        public override string ToString()
        {
            if (_className == default)
            {
                return Serialize(Compile(_value), Stringify);
            }
            return Serialize(Compile($".{_className}{{{_value}}}"), Stringify);
        }
    }
}
