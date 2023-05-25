using static CssInCs.Compiler.Serializer;
using static CssInCs.Compiler.Parser;
using System.Collections.Generic;
using System.Text;

namespace CssInCs
{
    public sealed partial class CSSObject
    {
        private readonly Dictionary<string, CSSObject> _styles = new ();
        private readonly Dictionary<string, IProperty> _properties = new();
        public Dictionary<string, IProperty> GetProperties() => _properties;
        public Dictionary<string, CSSObject> GetStyles() => _styles;

        public CSSObject this[string key]
        {
            get => _styles[key];
            set => _styles[key] = value;
        }

        public override string ToString()
        {
            return Serialize(Compile(CreateCss()), Stringify);
        }

        public string CreateCss()
        {
            var sb = new StringBuilder();
            foreach (var property in _properties)
            {
                sb.Append($"{property.Key}:{property.Value.GetValue()};");
            }
            foreach (var subStyle in _styles)
            {
                sb.Append($"{subStyle.Key}{{{subStyle.Value.CreateCss()}}}");
            }
            return sb.ToString();
        }

        public CSSObject Merge(CSSObject css)
        {
            var props = css.GetProperties();
            foreach (var prop in props)
            {
                // merge props
                _properties[prop.Key] = prop.Value;
            }

            var styles = css.GetStyles();
            foreach (var style in styles)
            {
                if (_styles.ContainsKey(style.Key))
                {
                    // if exists, merge to sub style sheet.
                    _styles[style.Key].Merge(style.Value);
                }
                else
                {
                    // add to current style sheet.
                    _styles[style.Key] = style.Value;
                }
            }

            return this;
        }
    }
}
