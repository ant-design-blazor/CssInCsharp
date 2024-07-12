using System.Collections.Generic;
using System.Text;

namespace CssInCSharp
{
    public sealed class Keyframe
    {
        private readonly string _name;
        private readonly Dictionary<string, CSSObject> _styles = new();

        private Keyframe()
        {
        }

        public Keyframe(string name)
        {
            _name = name;
        }

        public Keyframe(string name, CSSObject css)
        {
            _name = name;
            _styles = css.GetStyles();
        }

        public CSSObject this[string key]
        {
            get => _styles[key];
            set => _styles[key] = value;
        }

        public (string, string) GetEffect(string hashId = null)
        {
            var effectName = hashId == null ? _name : $"{hashId}-{_name}";
            var sb = new StringBuilder();
            sb.Append($"@keyframes {effectName}{{");
            foreach (var subStyle in _styles)
            {
                sb.Append($"{subStyle.Key}{{{subStyle.Value.ParseStyle(true, string.Empty)}}}");
            }
            sb.Append("}");
            return (effectName, sb.ToString());
        }

        public override string ToString()
        {
            var (effectName, effectStyle) = GetEffect();
            return $"{effectName};{effectStyle}";
        }
    }
}
