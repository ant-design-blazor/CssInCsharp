using System;

namespace CssInCSharp.Colors
{
    public record struct RGB(StringNumber R, StringNumber G, StringNumber B);
    public record struct RGBA(StringNumber R, StringNumber G, StringNumber B, StringNumber? A);
    public record struct HSL(StringNumber H, StringNumber S, StringNumber L);
    public record struct HSLA(StringNumber H, StringNumber S, StringNumber L, StringNumber? A);
    public record struct HSV(StringNumber H, StringNumber S, StringNumber V);
    public record struct HSVA(StringNumber H, StringNumber S, StringNumber V, StringNumber? A);
    public record struct RatioInput(StringNumber R, StringNumber G, StringNumber B, StringNumber? A = default);

    public sealed class ColorInput
    {
        private readonly int _index;
        private readonly string _value0;
        private readonly int _value1;
        private readonly TinyColor _value2;
        private readonly FastColor _value3;

        public ColorInput()
        {
            _index = -1;
        }

        private ColorInput(
            int index, 
            string value0 = default,
            int value1 = default,
            TinyColor value2 = default,
            FastColor value3 = default,
            RGB rgb = default,
            RGBA rgba = default,
            HSL hsl = default,
            HSLA hsla = default,
            HSV hsv = default,
            HSVA hsva = default)
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;

            if (rgb != default)
            {
                R = rgb.R; 
                G = rgb.G;
                B = rgb.B;
            }
            if (rgba != default)
            {
                R = rgba.R;
                G = rgba.G;
                B = rgba.B;
                A = rgba.A;
            }
            if (hsl != default)
            {
                H = hsl.H;
                S = hsl.S;
                L = hsl.L;
            }
            if (hsla != default)
            {
                H = hsla.H;
                S = hsla.S;
                L = hsla.L;
                A = hsla.A;
            }
            if (hsv != default)
            {
                H = hsv.H;
                S = hsv.S;
                V = hsv.V;
            }
            if (hsva != default)
            {
                H = hsva.H;
                S = hsva.S;
                V = hsva.V;
                A = hsva.A;
            }
        }

        public static implicit operator ColorInput(string value) => new(0, value0: value);
        public static implicit operator ColorInput(int value) => new(1, value1: value);
        public static implicit operator ColorInput(TinyColor value) => new(2, value2: value);
        public static implicit operator ColorInput(FastColor value) => new(3, value3: value);
        public static implicit operator ColorInput(RGB value) => new(-1, rgb: value);
        public static implicit operator ColorInput(RGBA value) => new(-1, rgba: value);
        public static implicit operator ColorInput(HSL value) => new(-1, hsl: value);
        public static implicit operator ColorInput(HSLA value) => new(-1, hsla: value);
        public static implicit operator ColorInput(HSV value) => new(-1, hsv: value);
        public static implicit operator ColorInput(HSVA value) => new(-1, hsva: value);

        public StringNumber R { get; set; }
        public StringNumber G { get; set; }
        public StringNumber B { get; set; }
        public StringNumber? A { get; set; }
        public StringNumber H { get; set; }
        public StringNumber S { get; set; }
        public StringNumber V { get; set; }
        public StringNumber L { get; set; }

        public string Format { get; set; }

        public bool IsObject => _index == -1;

        public bool IsString => _index == 0;

        public bool IsNumber => _index == 1;

        public bool IsColor => _index == 2;

        public bool IsFastColor => _index == 3;

        public string AsString =>
            _index == 0 ?
                _value0 :
                throw new InvalidOperationException();

        public int AsNumber =>
            _index == 1 ?
                _value1 :
                throw new InvalidOperationException();

        public TinyColor AsColor =>
            _index == 2 ? 
                _value2 : 
                throw new InvalidOperationException();

        public FastColor AsFastColor =>
            _index == 3 ?
                _value3 :
                throw new InvalidOperationException();

        public bool Is(string type)
        {
            return true;
        }

        public override string ToString()
        {
            return _index switch
            {
                0 => _value0,
                1 => _value1.ToString(),
                _ => throw new InvalidOperationException()
            };
        }
    }
}
