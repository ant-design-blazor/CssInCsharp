using System;

namespace CssInCSharp.Colors
{
    public record struct RGB(int R, int G, int B);
    public record struct RGBA(int R, int G, int B, int A);
    public record struct HSL(int H, int S, int L);
    public record struct HSLA(int H, int S, int L, int A);
    public record struct HSV(int H, int S, int V);
    public record struct HSVA(int H, int S, int V, int A);

    public sealed class ColorInput
    {
        private readonly int _index;
        private readonly string _value0;
        private readonly int _value1;
        private readonly RGB _value2;
        private readonly RGBA _value3;
        private readonly HSL _value4;
        private readonly HSLA _value5;
        private readonly HSV _value6;
        private readonly HSVA _value7;
        private readonly TinyColor _value8;

        public ColorInput()
        {
            _index = -1;
        }

        private ColorInput(
            int index, 
            string value0 = default,
            int value1 = default,
            RGB value2 = default,
            RGBA value3 = default,
            HSL value4 = default,
            HSLA value5 = default,
            HSV value6 = default,
            HSVA value7 = default,
            TinyColor value8 = default)
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
            _value5 = value5;
            _value6 = value6;
            _value7 = value7;
        }

        public static implicit operator ColorInput(string value) => new(0, value0: value);
        public static implicit operator ColorInput(int value) => new(1, value1: value);
        public static implicit operator ColorInput(RGB value) => new(2, value2: value);
        public static implicit operator ColorInput(RGBA value) => new(3, value3: value);
        public static implicit operator ColorInput(HSL value) => new(4, value4: value);
        public static implicit operator ColorInput(HSLA value) => new(5, value5: value);
        public static implicit operator ColorInput(HSV value) => new(6, value6: value);
        public static implicit operator ColorInput(HSVA value) => new(7, value7: value);
        public static implicit operator ColorInput(TinyColor value) => new(8, value8: value);

        public StringNumber R { get; set; }
        public StringNumber G { get; set; }
        public StringNumber B { get; set; }
        public StringNumber A { get; set; }
        public string Format { get; set; }

        public bool IsObject => _index == -1;

        public bool IsString => _index == 0;

        public bool IsNumber => _index == 1;

        public bool IsTinyColor => _index == 8;

        public string AsString =>
            _index == 0 ?
                _value0 :
                throw new InvalidOperationException();

        public int AsNumber =>
            _index == 1 ?
                _value1 :
                throw new InvalidOperationException();

        public TinyColor AsTinyColor => 
            _index == 8 ? 
                _value8 : 
                throw new InvalidOperationException();
    }
}
