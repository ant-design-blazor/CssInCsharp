using static CssInCs.Compiler.Utility;
using static CssInCs.Compiler.Enum;
using System.Collections.Generic;
using System.Text;

namespace CssInCs.Compiler
{
    public delegate string SerializeCallback(Element element, SerializeCallback callback);

    public class Serializer
    {
        public static string Serialize(List<Element> children, SerializeCallback callback)
        {
            var output = new StringBuilder();
            var length = Sizeof(children);
            for (var i = 0; i < length; i++)
            {
                var r = callback(children[i], callback);
                output.Append(string.IsNullOrEmpty(r) ? "" : r);
            }
            return output.ToString();
        }

        public static string Stringify(Element element, SerializeCallback callback)
        {
            switch (element.Type)
            {
                case IMPORT: case DECLARATION: return element.Return = !string.IsNullOrEmpty(element.Return) ? element.Return : element.Value;
                case COMMENT: return "";
                case KEYFRAMES: return element.Return = element.Value + "{" + Serialize(element.Children, callback) + "}";
                case RULESET: element.Value = string.Join(",", element.Props); break;
            }
            var children = Serialize(element.Children, callback);
            return Strlen(children) != 0 ? element.Return = element.Value + "{" + children + "}" : "";
        }
    }
}
