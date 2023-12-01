﻿namespace CssInCs
{
    public interface IProperty
    {
        string GetValue(string key);
    }

    public struct PropertySkip
    {
        public bool SkipCheck { get; set; }
        public Property<string, int> Value { get; set; }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
