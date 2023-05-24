﻿using System.Collections.Generic;
using System.Text;

namespace CssInCs
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

        public CSSObject this[string key]
        {
            get => _styles[key];
            set => _styles[key] = value;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"{_name};@keyframes {_name}{{");
            foreach (var subStyle in _styles)
            {
                sb.Append($"{subStyle.Key}{{{subStyle.Value.CreateCss()}}}");
            }
            sb.Append("}}");
            return sb.ToString();
        }
    }
}
