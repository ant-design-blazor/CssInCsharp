using static CssInCSharp.Compiler.Serializer;
using static CssInCSharp.Compiler.Parser;
using static CssInCSharp.Constant;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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

        public string SerializeCss(string hashId, List<(string, string)> effects = null)
        {
            return Serialize(Compile(ParseStyle(true, false, hashId, effects)), Stringify);
        }

        internal string ParseStyle(bool root, bool injectHash, string hashId, List<(string, string)> effects = null)
        {
            var sb = new StringBuilder();

            // normal css properties
            foreach (var property in _properties)
            {
                if (effects != null && property.Key == "animation-name")
                {
                    var keyframe = (Keyframe)property.Value.GetValue();
                    var effect = keyframe.GetEffect(hashId);
                    sb.Append($"{property.Key}:{effect.Item1};");
                    effects.Add(effect);
                }
                else
                {
                    sb.Append($"{property.Key}:{property.Value.GetValue(property.Key)};");
                }
            }

            // sub style sheet
            foreach (var subStyle in _styles)
            {
                var subInjectHash = false;
                var nextRoot = false;
                var mergedKey = subStyle.Key.Trim();

                if ((root || injectHash) && !string.IsNullOrEmpty(hashId))
                {
                    if (mergedKey.StartsWith("@"))
                    {
                        subInjectHash = true;
                    }
                    else
                    {
                        mergedKey = InjectSelectorHash(mergedKey, hashId);
                    }
                } 
                else if (root && string.IsNullOrEmpty(hashId) && (mergedKey == "&" || mergedKey == ""))
                {
                    mergedKey = "";
                    nextRoot = true;
                }

                sb.Append($"{mergedKey}{{{subStyle.Value.ParseStyle(nextRoot, subInjectHash, hashId, effects)}}}");
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

        private string InjectSelectorHash(string key, string hashId)
        {
            var hashClassName = $".{hashId}"; 
            var hashSelector = $":where({hashClassName})"; 
            var keys = key.Split(",").Select(k => 
            { 
                var fullPath = Regex.Split(k.Trim(), @"\s+"); 
                var firstPath = fullPath[0]; 
                var match = Regex.Match(firstPath, @"^\w+"); 
                var htmlElement = match.Success ? match.Value : ""; 
                fullPath[0] = $"{htmlElement}{hashSelector}{firstPath.Substring(htmlElement.Length)}"; 
                return string.Join(" ", fullPath);
            });

            return string.Join(",", keys);
        }
    }
}
