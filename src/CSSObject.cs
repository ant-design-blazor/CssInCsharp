using System;
using static CssInCSharp.Compiler.Serializer;
using static CssInCSharp.Compiler.Parser;
using static CssInCSharp.Constant;
using System.Collections.Generic;
using System.Text;

namespace CssInCSharp
{
    public sealed partial class CSSObject
    {
        private readonly Dictionary<string, CSSObject> _styles = new();
        private readonly Dictionary<string, IProperty> _properties = new();
        public Dictionary<string, IProperty> GetProperties() => _properties;
        public Dictionary<string, CSSObject> GetStyles() => _styles;
        
        public CSSInterpolation this[string key]
        {
            get => _styles[key];
            set => SetStyle(key, value);
        }

        public override string ToString()
        {
            return SerializeCss(string.Empty);
        }

        public string SerializeCss(string hashId)
        {
            return Serialize(Compile(ParseStyle(true, hashId)), Stringify);
        }

        internal string ParseStyle(bool root, string hashId)
        {
            var sb = new StringBuilder();
            
            foreach (var property in _properties)
            {
                sb.Append($"{property.Key}:{property.Value.GetValue(property.Key)};");
            }
            foreach (var subStyle in _styles)
            {
                var nextRoot = false;
                if (subStyle.Key.StartsWith("@"))
                {
                    // if is media type, skip and insert hashId from subStyle.
                    root = false;
                    nextRoot = true;
                }
                sb.Append($"{subStyle.Key}{{{subStyle.Value.ParseStyle(nextRoot, hashId)}}}");
            }

            if (root && !string.IsNullOrEmpty(hashId))
            {
                return $":where(.{hashId}){sb}";
            }
            else
            {
                return sb.ToString();
            }
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
                if (_styles.TryGetValue(style.Key, out var value))
                {
                    // if exists, merge to sub style sheet.
                    value.Merge(style.Value);
                }
                else
                {
                    // add to current style sheet.
                    _styles[style.Key] = style.Value;
                }
            }

            return this;
        }

        public CSSObject Merge(CSSObject[] objects)
        {
            foreach (var css in objects)
            {
                Merge(css);
            }
            return this;
        }

        private void SetStyle(string key, CSSInterpolation value)
        {
            if (key == null) return;
            /*
             * if is CSSProperties
             * new CSSObject
             * {
             *    ["--font-size"] = "12px",     // string value.
             *    ["width"] = 100,              // number value.
             *    ["width"] = new Keyframe(""), // Keyframe
             * }
             */
            if (value.IsT2)
            {
                _properties[key] = value.AsT2;
                return;
            }

            /*
             * if is CSSObject or CSSObject[]
             */
            var cssObject = value.IsT0 ? value.AsT0 : new CSSObject().Merge(value.ToCssArray());
            if (cssObject == null) return;
            if (key == MERGE_OPERATOR)
            {
                Merge(cssObject);
                return;
            }
            _styles[key] = cssObject;
        }
    }
}
