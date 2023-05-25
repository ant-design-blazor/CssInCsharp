using System;
using static CssInCs.Functions;

namespace CssInCs
{
    /**
     * If you want to use this property type to replace generic property types.
     * You can set "useGeneric = false" in "generator.ts".
     */
    public readonly struct Property
    {
        public readonly struct AccentColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private AccentColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator AccentColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AlignContent : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private AlignContent(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator AlignContent(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AlignItems : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private AlignItems(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator AlignItems(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AlignSelf : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private AlignSelf(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator AlignSelf(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AlignTracks : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private AlignTracks(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator AlignTracks(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct All : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private All(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator All(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Animation : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Animation(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Animation(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationComposition : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private AnimationComposition(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator AnimationComposition(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationDelay : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private AnimationDelay(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator AnimationDelay(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationDirection : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private AnimationDirection(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator AnimationDirection(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationDuration : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private AnimationDuration(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator AnimationDuration(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationFillMode : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private AnimationFillMode(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator AnimationFillMode(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationIterationCount : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private AnimationIterationCount(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator AnimationIterationCount(string t) => new(0, value0: t);
            public static implicit operator AnimationIterationCount(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationName : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly Keyframe _value1;

            private AnimationName(int index, string value0 = default, Keyframe value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator AnimationName(string t) => new(0, value0: t);
            public static implicit operator AnimationName(Keyframe t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationPlayState : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private AnimationPlayState(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator AnimationPlayState(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationTimeline : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private AnimationTimeline(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator AnimationTimeline(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationTimingFunction : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private AnimationTimingFunction(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator AnimationTimingFunction(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Appearance : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Appearance(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Appearance(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AspectRatio : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private AspectRatio(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator AspectRatio(string t) => new(0, value0: t);
            public static implicit operator AspectRatio(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Azimuth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Azimuth(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Azimuth(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackdropFilter : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BackdropFilter(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BackdropFilter(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackfaceVisibility : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BackfaceVisibility(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BackfaceVisibility(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Background : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private Background(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Background(string t) => new(0, value0: t);
            public static implicit operator Background(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundAttachment : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BackgroundAttachment(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BackgroundAttachment(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundBlendMode : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BackgroundBlendMode(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BackgroundBlendMode(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundClip : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BackgroundClip(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BackgroundClip(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BackgroundColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BackgroundColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundImage : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BackgroundImage(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BackgroundImage(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundOrigin : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BackgroundOrigin(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BackgroundOrigin(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundPosition : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BackgroundPosition(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BackgroundPosition(string t) => new(0, value0: t);
            public static implicit operator BackgroundPosition(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundPositionX : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BackgroundPositionX(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BackgroundPositionX(string t) => new(0, value0: t);
            public static implicit operator BackgroundPositionX(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundPositionY : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BackgroundPositionY(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BackgroundPositionY(string t) => new(0, value0: t);
            public static implicit operator BackgroundPositionY(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundRepeat : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BackgroundRepeat(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BackgroundRepeat(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundSize : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BackgroundSize(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BackgroundSize(string t) => new(0, value0: t);
            public static implicit operator BackgroundSize(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BlockOverflow : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BlockOverflow(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BlockOverflow(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BlockSize : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BlockSize(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BlockSize(string t) => new(0, value0: t);
            public static implicit operator BlockSize(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Border : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private Border(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Border(string t) => new(0, value0: t);
            public static implicit operator Border(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlock : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderBlock(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderBlock(string t) => new(0, value0: t);
            public static implicit operator BorderBlock(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BorderBlockColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BorderBlockColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockEnd : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderBlockEnd(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderBlockEnd(string t) => new(0, value0: t);
            public static implicit operator BorderBlockEnd(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockEndColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BorderBlockEndColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BorderBlockEndColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockEndStyle : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BorderBlockEndStyle(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BorderBlockEndStyle(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockEndWidth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderBlockEndWidth(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderBlockEndWidth(string t) => new(0, value0: t);
            public static implicit operator BorderBlockEndWidth(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockStart : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderBlockStart(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderBlockStart(string t) => new(0, value0: t);
            public static implicit operator BorderBlockStart(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockStartColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BorderBlockStartColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BorderBlockStartColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockStartStyle : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BorderBlockStartStyle(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BorderBlockStartStyle(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockStartWidth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderBlockStartWidth(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderBlockStartWidth(string t) => new(0, value0: t);
            public static implicit operator BorderBlockStartWidth(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockStyle : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BorderBlockStyle(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BorderBlockStyle(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockWidth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderBlockWidth(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderBlockWidth(string t) => new(0, value0: t);
            public static implicit operator BorderBlockWidth(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBottom : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderBottom(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderBottom(string t) => new(0, value0: t);
            public static implicit operator BorderBottom(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBottomColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BorderBottomColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BorderBottomColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBottomLeftRadius : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderBottomLeftRadius(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderBottomLeftRadius(string t) => new(0, value0: t);
            public static implicit operator BorderBottomLeftRadius(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBottomRightRadius : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderBottomRightRadius(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderBottomRightRadius(string t) => new(0, value0: t);
            public static implicit operator BorderBottomRightRadius(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBottomStyle : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BorderBottomStyle(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BorderBottomStyle(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBottomWidth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderBottomWidth(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderBottomWidth(string t) => new(0, value0: t);
            public static implicit operator BorderBottomWidth(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderCollapse : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BorderCollapse(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BorderCollapse(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BorderColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BorderColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderEndEndRadius : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderEndEndRadius(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderEndEndRadius(string t) => new(0, value0: t);
            public static implicit operator BorderEndEndRadius(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderEndStartRadius : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderEndStartRadius(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderEndStartRadius(string t) => new(0, value0: t);
            public static implicit operator BorderEndStartRadius(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderImage : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderImage(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderImage(string t) => new(0, value0: t);
            public static implicit operator BorderImage(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderImageOutset : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderImageOutset(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderImageOutset(string t) => new(0, value0: t);
            public static implicit operator BorderImageOutset(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderImageRepeat : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BorderImageRepeat(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BorderImageRepeat(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderImageSlice : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderImageSlice(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderImageSlice(string t) => new(0, value0: t);
            public static implicit operator BorderImageSlice(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderImageSource : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BorderImageSource(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BorderImageSource(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderImageWidth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderImageWidth(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderImageWidth(string t) => new(0, value0: t);
            public static implicit operator BorderImageWidth(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInline : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderInline(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderInline(string t) => new(0, value0: t);
            public static implicit operator BorderInline(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BorderInlineColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BorderInlineColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineEnd : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderInlineEnd(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderInlineEnd(string t) => new(0, value0: t);
            public static implicit operator BorderInlineEnd(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineEndColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BorderInlineEndColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BorderInlineEndColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineEndStyle : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BorderInlineEndStyle(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BorderInlineEndStyle(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineEndWidth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderInlineEndWidth(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderInlineEndWidth(string t) => new(0, value0: t);
            public static implicit operator BorderInlineEndWidth(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineStart : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderInlineStart(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderInlineStart(string t) => new(0, value0: t);
            public static implicit operator BorderInlineStart(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineStartColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BorderInlineStartColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BorderInlineStartColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineStartStyle : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BorderInlineStartStyle(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BorderInlineStartStyle(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineStartWidth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderInlineStartWidth(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderInlineStartWidth(string t) => new(0, value0: t);
            public static implicit operator BorderInlineStartWidth(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineStyle : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BorderInlineStyle(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BorderInlineStyle(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineWidth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderInlineWidth(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderInlineWidth(string t) => new(0, value0: t);
            public static implicit operator BorderInlineWidth(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderLeft : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderLeft(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderLeft(string t) => new(0, value0: t);
            public static implicit operator BorderLeft(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderLeftColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BorderLeftColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BorderLeftColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderLeftStyle : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BorderLeftStyle(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BorderLeftStyle(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderLeftWidth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderLeftWidth(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderLeftWidth(string t) => new(0, value0: t);
            public static implicit operator BorderLeftWidth(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderRadius : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderRadius(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderRadius(string t) => new(0, value0: t);
            public static implicit operator BorderRadius(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderRight : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderRight(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderRight(string t) => new(0, value0: t);
            public static implicit operator BorderRight(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderRightColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BorderRightColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BorderRightColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderRightStyle : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BorderRightStyle(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BorderRightStyle(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderRightWidth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderRightWidth(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderRightWidth(string t) => new(0, value0: t);
            public static implicit operator BorderRightWidth(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderSpacing : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderSpacing(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderSpacing(string t) => new(0, value0: t);
            public static implicit operator BorderSpacing(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderStartEndRadius : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderStartEndRadius(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderStartEndRadius(string t) => new(0, value0: t);
            public static implicit operator BorderStartEndRadius(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderStartStartRadius : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderStartStartRadius(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderStartStartRadius(string t) => new(0, value0: t);
            public static implicit operator BorderStartStartRadius(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderStyle : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BorderStyle(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BorderStyle(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderTop : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderTop(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderTop(string t) => new(0, value0: t);
            public static implicit operator BorderTop(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderTopColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BorderTopColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BorderTopColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderTopLeftRadius : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderTopLeftRadius(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderTopLeftRadius(string t) => new(0, value0: t);
            public static implicit operator BorderTopLeftRadius(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderTopRightRadius : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderTopRightRadius(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderTopRightRadius(string t) => new(0, value0: t);
            public static implicit operator BorderTopRightRadius(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderTopStyle : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BorderTopStyle(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BorderTopStyle(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderTopWidth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderTopWidth(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderTopWidth(string t) => new(0, value0: t);
            public static implicit operator BorderTopWidth(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderWidth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BorderWidth(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderWidth(string t) => new(0, value0: t);
            public static implicit operator BorderWidth(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Bottom : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private Bottom(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Bottom(string t) => new(0, value0: t);
            public static implicit operator Bottom(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxAlign : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BoxAlign(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BoxAlign(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxDecorationBreak : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BoxDecorationBreak(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BoxDecorationBreak(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxDirection : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BoxDirection(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BoxDirection(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxFlex : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BoxFlex(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BoxFlex(string t) => new(0, value0: t);
            public static implicit operator BoxFlex(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxFlexGroup : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BoxFlexGroup(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BoxFlexGroup(string t) => new(0, value0: t);
            public static implicit operator BoxFlexGroup(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxLines : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BoxLines(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BoxLines(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxOrdinalGroup : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BoxOrdinalGroup(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BoxOrdinalGroup(string t) => new(0, value0: t);
            public static implicit operator BoxOrdinalGroup(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxOrient : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BoxOrient(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BoxOrient(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxPack : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BoxPack(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BoxPack(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxShadow : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BoxShadow(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BoxShadow(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxSizing : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BoxSizing(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BoxSizing(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BreakAfter : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BreakAfter(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BreakAfter(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BreakBefore : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BreakBefore(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BreakBefore(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BreakInside : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private BreakInside(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator BreakInside(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct CaptionSide : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private CaptionSide(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator CaptionSide(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Caret : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Caret(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Caret(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct CaretColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private CaretColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator CaretColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct CaretShape : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private CaretShape(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator CaretShape(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Clear : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Clear(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Clear(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Clip : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Clip(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Clip(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ClipPath : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ClipPath(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ClipPath(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Color : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Color(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Color(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PrintColorAdjust : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private PrintColorAdjust(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator PrintColorAdjust(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColorScheme : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ColorScheme(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ColorScheme(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnCount : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ColumnCount(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ColumnCount(string t) => new(0, value0: t);
            public static implicit operator ColumnCount(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnFill : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ColumnFill(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ColumnFill(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnGap : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ColumnGap(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ColumnGap(string t) => new(0, value0: t);
            public static implicit operator ColumnGap(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnRule : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ColumnRule(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ColumnRule(string t) => new(0, value0: t);
            public static implicit operator ColumnRule(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnRuleColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ColumnRuleColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ColumnRuleColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnRuleStyle : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ColumnRuleStyle(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ColumnRuleStyle(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnRuleWidth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ColumnRuleWidth(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ColumnRuleWidth(string t) => new(0, value0: t);
            public static implicit operator ColumnRuleWidth(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnSpan : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ColumnSpan(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ColumnSpan(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnWidth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ColumnWidth(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ColumnWidth(string t) => new(0, value0: t);
            public static implicit operator ColumnWidth(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Columns : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private Columns(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Columns(string t) => new(0, value0: t);
            public static implicit operator Columns(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Contain : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Contain(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Contain(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ContainIntrinsicBlockSize : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ContainIntrinsicBlockSize(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ContainIntrinsicBlockSize(string t) => new(0, value0: t);
            public static implicit operator ContainIntrinsicBlockSize(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ContainIntrinsicHeight : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ContainIntrinsicHeight(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ContainIntrinsicHeight(string t) => new(0, value0: t);
            public static implicit operator ContainIntrinsicHeight(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ContainIntrinsicInlineSize : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ContainIntrinsicInlineSize(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ContainIntrinsicInlineSize(string t) => new(0, value0: t);
            public static implicit operator ContainIntrinsicInlineSize(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ContainIntrinsicSize : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ContainIntrinsicSize(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ContainIntrinsicSize(string t) => new(0, value0: t);
            public static implicit operator ContainIntrinsicSize(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ContainIntrinsicWidth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ContainIntrinsicWidth(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ContainIntrinsicWidth(string t) => new(0, value0: t);
            public static implicit operator ContainIntrinsicWidth(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Container : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Container(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Container(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ContainerName : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ContainerName(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ContainerName(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ContainerType : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ContainerType(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ContainerType(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Content : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Content(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Content(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ContentVisibility : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ContentVisibility(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ContentVisibility(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct CounterIncrement : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private CounterIncrement(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator CounterIncrement(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct CounterReset : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private CounterReset(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator CounterReset(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct CounterSet : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private CounterSet(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator CounterSet(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Cursor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Cursor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Cursor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Direction : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Direction(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Direction(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Display : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Display(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Display(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct EmptyCells : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private EmptyCells(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator EmptyCells(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Filter : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Filter(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Filter(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Flex : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private Flex(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Flex(string t) => new(0, value0: t);
            public static implicit operator Flex(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FlexBasis : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private FlexBasis(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FlexBasis(string t) => new(0, value0: t);
            public static implicit operator FlexBasis(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FlexDirection : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private FlexDirection(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator FlexDirection(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FlexFlow : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private FlexFlow(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator FlexFlow(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FlexGrow : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private FlexGrow(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FlexGrow(string t) => new(0, value0: t);
            public static implicit operator FlexGrow(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FlexShrink : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private FlexShrink(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FlexShrink(string t) => new(0, value0: t);
            public static implicit operator FlexShrink(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FlexWrap : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private FlexWrap(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator FlexWrap(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Float : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Float(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Float(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Font : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Font(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Font(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontFamily : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private FontFamily(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator FontFamily(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontFeatureSettings : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private FontFeatureSettings(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator FontFeatureSettings(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontKerning : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private FontKerning(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator FontKerning(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontLanguageOverride : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private FontLanguageOverride(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator FontLanguageOverride(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontOpticalSizing : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private FontOpticalSizing(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator FontOpticalSizing(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontPalette : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private FontPalette(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator FontPalette(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontSize : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private FontSize(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FontSize(string t) => new(0, value0: t);
            public static implicit operator FontSize(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontSizeAdjust : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private FontSizeAdjust(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FontSizeAdjust(string t) => new(0, value0: t);
            public static implicit operator FontSizeAdjust(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontSmooth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private FontSmooth(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FontSmooth(string t) => new(0, value0: t);
            public static implicit operator FontSmooth(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontStretch : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private FontStretch(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator FontStretch(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontStyle : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private FontStyle(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator FontStyle(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontSynthesis : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private FontSynthesis(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator FontSynthesis(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariant : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private FontVariant(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator FontVariant(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariantAlternates : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private FontVariantAlternates(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator FontVariantAlternates(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariantCaps : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private FontVariantCaps(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator FontVariantCaps(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariantEastAsian : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private FontVariantEastAsian(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator FontVariantEastAsian(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariantEmoji : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private FontVariantEmoji(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator FontVariantEmoji(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariantLigatures : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private FontVariantLigatures(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator FontVariantLigatures(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariantNumeric : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private FontVariantNumeric(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator FontVariantNumeric(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariantPosition : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private FontVariantPosition(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator FontVariantPosition(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariationSettings : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private FontVariationSettings(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator FontVariationSettings(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontWeight : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private FontWeight(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator FontWeight(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ForcedColorAdjust : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ForcedColorAdjust(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ForcedColorAdjust(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Gap : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private Gap(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Gap(string t) => new(0, value0: t);
            public static implicit operator Gap(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Grid : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Grid(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Grid(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridArea : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private GridArea(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator GridArea(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridAutoColumns : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private GridAutoColumns(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator GridAutoColumns(string t) => new(0, value0: t);
            public static implicit operator GridAutoColumns(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridAutoFlow : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private GridAutoFlow(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator GridAutoFlow(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridAutoRows : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private GridAutoRows(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator GridAutoRows(string t) => new(0, value0: t);
            public static implicit operator GridAutoRows(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridColumn : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private GridColumn(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator GridColumn(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridColumnEnd : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private GridColumnEnd(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator GridColumnEnd(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridColumnGap : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private GridColumnGap(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator GridColumnGap(string t) => new(0, value0: t);
            public static implicit operator GridColumnGap(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridColumnStart : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private GridColumnStart(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator GridColumnStart(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridGap : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private GridGap(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator GridGap(string t) => new(0, value0: t);
            public static implicit operator GridGap(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridRow : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private GridRow(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator GridRow(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridRowEnd : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private GridRowEnd(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator GridRowEnd(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridRowGap : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private GridRowGap(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator GridRowGap(string t) => new(0, value0: t);
            public static implicit operator GridRowGap(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridRowStart : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private GridRowStart(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator GridRowStart(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridTemplate : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private GridTemplate(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator GridTemplate(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridTemplateAreas : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private GridTemplateAreas(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator GridTemplateAreas(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridTemplateColumns : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private GridTemplateColumns(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator GridTemplateColumns(string t) => new(0, value0: t);
            public static implicit operator GridTemplateColumns(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridTemplateRows : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private GridTemplateRows(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator GridTemplateRows(string t) => new(0, value0: t);
            public static implicit operator GridTemplateRows(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct HangingPunctuation : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private HangingPunctuation(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator HangingPunctuation(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Height : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private Height(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Height(string t) => new(0, value0: t);
            public static implicit operator Height(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct HyphenateCharacter : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private HyphenateCharacter(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator HyphenateCharacter(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct HyphenateLimitChars : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private HyphenateLimitChars(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator HyphenateLimitChars(string t) => new(0, value0: t);
            public static implicit operator HyphenateLimitChars(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Hyphens : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Hyphens(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Hyphens(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ImageOrientation : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ImageOrientation(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ImageOrientation(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ImageRendering : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ImageRendering(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ImageRendering(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ImageResolution : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ImageResolution(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ImageResolution(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ImeMode : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ImeMode(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ImeMode(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InitialLetter : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private InitialLetter(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator InitialLetter(string t) => new(0, value0: t);
            public static implicit operator InitialLetter(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InlineSize : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private InlineSize(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator InlineSize(string t) => new(0, value0: t);
            public static implicit operator InlineSize(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InputSecurity : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private InputSecurity(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator InputSecurity(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Inset : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private Inset(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Inset(string t) => new(0, value0: t);
            public static implicit operator Inset(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InsetBlock : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private InsetBlock(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator InsetBlock(string t) => new(0, value0: t);
            public static implicit operator InsetBlock(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InsetBlockEnd : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private InsetBlockEnd(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator InsetBlockEnd(string t) => new(0, value0: t);
            public static implicit operator InsetBlockEnd(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InsetBlockStart : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private InsetBlockStart(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator InsetBlockStart(string t) => new(0, value0: t);
            public static implicit operator InsetBlockStart(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InsetInline : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private InsetInline(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator InsetInline(string t) => new(0, value0: t);
            public static implicit operator InsetInline(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InsetInlineEnd : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private InsetInlineEnd(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator InsetInlineEnd(string t) => new(0, value0: t);
            public static implicit operator InsetInlineEnd(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InsetInlineStart : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private InsetInlineStart(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator InsetInlineStart(string t) => new(0, value0: t);
            public static implicit operator InsetInlineStart(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Isolation : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Isolation(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Isolation(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct JustifyContent : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private JustifyContent(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator JustifyContent(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct JustifyItems : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private JustifyItems(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator JustifyItems(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct JustifySelf : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private JustifySelf(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator JustifySelf(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct JustifyTracks : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private JustifyTracks(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator JustifyTracks(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Left : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private Left(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Left(string t) => new(0, value0: t);
            public static implicit operator Left(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct LetterSpacing : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private LetterSpacing(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator LetterSpacing(string t) => new(0, value0: t);
            public static implicit operator LetterSpacing(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct LineBreak : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private LineBreak(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator LineBreak(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct LineClamp : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private LineClamp(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator LineClamp(string t) => new(0, value0: t);
            public static implicit operator LineClamp(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct LineHeight : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private LineHeight(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator LineHeight(string t) => new(0, value0: t);
            public static implicit operator LineHeight(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct LineHeightStep : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private LineHeightStep(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator LineHeightStep(string t) => new(0, value0: t);
            public static implicit operator LineHeightStep(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ListStyle : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ListStyle(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ListStyle(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ListStyleImage : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ListStyleImage(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ListStyleImage(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ListStylePosition : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ListStylePosition(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ListStylePosition(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ListStyleType : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ListStyleType(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ListStyleType(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Margin : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private Margin(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Margin(string t) => new(0, value0: t);
            public static implicit operator Margin(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginBlock : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MarginBlock(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MarginBlock(string t) => new(0, value0: t);
            public static implicit operator MarginBlock(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginBlockEnd : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MarginBlockEnd(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MarginBlockEnd(string t) => new(0, value0: t);
            public static implicit operator MarginBlockEnd(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginBlockStart : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MarginBlockStart(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MarginBlockStart(string t) => new(0, value0: t);
            public static implicit operator MarginBlockStart(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginBottom : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MarginBottom(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MarginBottom(string t) => new(0, value0: t);
            public static implicit operator MarginBottom(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginInline : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MarginInline(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MarginInline(string t) => new(0, value0: t);
            public static implicit operator MarginInline(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginInlineEnd : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MarginInlineEnd(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MarginInlineEnd(string t) => new(0, value0: t);
            public static implicit operator MarginInlineEnd(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginInlineStart : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MarginInlineStart(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MarginInlineStart(string t) => new(0, value0: t);
            public static implicit operator MarginInlineStart(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginLeft : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MarginLeft(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MarginLeft(string t) => new(0, value0: t);
            public static implicit operator MarginLeft(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginRight : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MarginRight(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MarginRight(string t) => new(0, value0: t);
            public static implicit operator MarginRight(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginTop : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MarginTop(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MarginTop(string t) => new(0, value0: t);
            public static implicit operator MarginTop(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginTrim : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MarginTrim(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MarginTrim(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Mask : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private Mask(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Mask(string t) => new(0, value0: t);
            public static implicit operator Mask(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskBorder : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MaskBorder(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MaskBorder(string t) => new(0, value0: t);
            public static implicit operator MaskBorder(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskBorderMode : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MaskBorderMode(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MaskBorderMode(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskBorderOutset : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MaskBorderOutset(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MaskBorderOutset(string t) => new(0, value0: t);
            public static implicit operator MaskBorderOutset(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskBorderRepeat : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MaskBorderRepeat(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MaskBorderRepeat(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskBorderSlice : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MaskBorderSlice(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MaskBorderSlice(string t) => new(0, value0: t);
            public static implicit operator MaskBorderSlice(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskBorderSource : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MaskBorderSource(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MaskBorderSource(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskBorderWidth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MaskBorderWidth(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MaskBorderWidth(string t) => new(0, value0: t);
            public static implicit operator MaskBorderWidth(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskClip : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MaskClip(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MaskClip(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskComposite : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MaskComposite(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MaskComposite(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskImage : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MaskImage(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MaskImage(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskMode : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MaskMode(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MaskMode(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskOrigin : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MaskOrigin(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MaskOrigin(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskPosition : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MaskPosition(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MaskPosition(string t) => new(0, value0: t);
            public static implicit operator MaskPosition(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskRepeat : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MaskRepeat(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MaskRepeat(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskSize : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MaskSize(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MaskSize(string t) => new(0, value0: t);
            public static implicit operator MaskSize(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskType : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MaskType(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MaskType(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MathDepth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MathDepth(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MathDepth(string t) => new(0, value0: t);
            public static implicit operator MathDepth(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MathShift : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MathShift(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MathShift(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MathStyle : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MathStyle(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MathStyle(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaxBlockSize : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MaxBlockSize(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MaxBlockSize(string t) => new(0, value0: t);
            public static implicit operator MaxBlockSize(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaxHeight : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MaxHeight(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MaxHeight(string t) => new(0, value0: t);
            public static implicit operator MaxHeight(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaxInlineSize : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MaxInlineSize(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MaxInlineSize(string t) => new(0, value0: t);
            public static implicit operator MaxInlineSize(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaxLines : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MaxLines(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MaxLines(string t) => new(0, value0: t);
            public static implicit operator MaxLines(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaxWidth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MaxWidth(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MaxWidth(string t) => new(0, value0: t);
            public static implicit operator MaxWidth(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MinBlockSize : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MinBlockSize(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MinBlockSize(string t) => new(0, value0: t);
            public static implicit operator MinBlockSize(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MinHeight : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MinHeight(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MinHeight(string t) => new(0, value0: t);
            public static implicit operator MinHeight(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MinInlineSize : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MinInlineSize(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MinInlineSize(string t) => new(0, value0: t);
            public static implicit operator MinInlineSize(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MinWidth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MinWidth(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MinWidth(string t) => new(0, value0: t);
            public static implicit operator MinWidth(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MixBlendMode : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MixBlendMode(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MixBlendMode(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Offset : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private Offset(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Offset(string t) => new(0, value0: t);
            public static implicit operator Offset(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OffsetDistance : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private OffsetDistance(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator OffsetDistance(string t) => new(0, value0: t);
            public static implicit operator OffsetDistance(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OffsetPath : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private OffsetPath(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator OffsetPath(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OffsetRotate : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private OffsetRotate(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator OffsetRotate(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ObjectFit : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ObjectFit(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ObjectFit(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ObjectPosition : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ObjectPosition(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ObjectPosition(string t) => new(0, value0: t);
            public static implicit operator ObjectPosition(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OffsetAnchor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private OffsetAnchor(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator OffsetAnchor(string t) => new(0, value0: t);
            public static implicit operator OffsetAnchor(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OffsetPosition : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private OffsetPosition(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator OffsetPosition(string t) => new(0, value0: t);
            public static implicit operator OffsetPosition(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Opacity : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly float _value1;

            private Opacity(int index, string value0 = default, float value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Opacity(string t) => new(0, value0: t);
            public static implicit operator Opacity(float t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Order : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private Order(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Order(string t) => new(0, value0: t);
            public static implicit operator Order(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Orphans : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private Orphans(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Orphans(string t) => new(0, value0: t);
            public static implicit operator Orphans(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Outline : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private Outline(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Outline(string t) => new(0, value0: t);
            public static implicit operator Outline(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OutlineColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private OutlineColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator OutlineColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OutlineOffset : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private OutlineOffset(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator OutlineOffset(string t) => new(0, value0: t);
            public static implicit operator OutlineOffset(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OutlineStyle : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private OutlineStyle(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator OutlineStyle(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OutlineWidth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private OutlineWidth(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator OutlineWidth(string t) => new(0, value0: t);
            public static implicit operator OutlineWidth(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Overflow : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Overflow(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Overflow(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverflowAnchor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private OverflowAnchor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator OverflowAnchor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverflowBlock : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private OverflowBlock(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator OverflowBlock(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverflowClipBox : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private OverflowClipBox(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator OverflowClipBox(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverflowClipMargin : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private OverflowClipMargin(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator OverflowClipMargin(string t) => new(0, value0: t);
            public static implicit operator OverflowClipMargin(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverflowInline : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private OverflowInline(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator OverflowInline(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverflowWrap : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private OverflowWrap(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator OverflowWrap(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverflowX : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private OverflowX(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator OverflowX(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverflowY : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private OverflowY(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator OverflowY(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverscrollBehavior : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private OverscrollBehavior(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator OverscrollBehavior(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverscrollBehaviorBlock : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private OverscrollBehaviorBlock(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator OverscrollBehaviorBlock(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverscrollBehaviorInline : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private OverscrollBehaviorInline(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator OverscrollBehaviorInline(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverscrollBehaviorX : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private OverscrollBehaviorX(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator OverscrollBehaviorX(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverscrollBehaviorY : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private OverscrollBehaviorY(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator OverscrollBehaviorY(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Padding : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private Padding(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Padding(string t) => new(0, value0: t);
            public static implicit operator Padding(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingBlock : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private PaddingBlock(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator PaddingBlock(string t) => new(0, value0: t);
            public static implicit operator PaddingBlock(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingBlockEnd : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private PaddingBlockEnd(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator PaddingBlockEnd(string t) => new(0, value0: t);
            public static implicit operator PaddingBlockEnd(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingBlockStart : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private PaddingBlockStart(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator PaddingBlockStart(string t) => new(0, value0: t);
            public static implicit operator PaddingBlockStart(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingBottom : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private PaddingBottom(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator PaddingBottom(string t) => new(0, value0: t);
            public static implicit operator PaddingBottom(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingInline : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private PaddingInline(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator PaddingInline(string t) => new(0, value0: t);
            public static implicit operator PaddingInline(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingInlineEnd : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private PaddingInlineEnd(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator PaddingInlineEnd(string t) => new(0, value0: t);
            public static implicit operator PaddingInlineEnd(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingInlineStart : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private PaddingInlineStart(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator PaddingInlineStart(string t) => new(0, value0: t);
            public static implicit operator PaddingInlineStart(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingLeft : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private PaddingLeft(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator PaddingLeft(string t) => new(0, value0: t);
            public static implicit operator PaddingLeft(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingRight : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private PaddingRight(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator PaddingRight(string t) => new(0, value0: t);
            public static implicit operator PaddingRight(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingTop : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private PaddingTop(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator PaddingTop(string t) => new(0, value0: t);
            public static implicit operator PaddingTop(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Page : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Page(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Page(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PageBreakAfter : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private PageBreakAfter(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator PageBreakAfter(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PageBreakBefore : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private PageBreakBefore(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator PageBreakBefore(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PageBreakInside : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private PageBreakInside(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator PageBreakInside(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaintOrder : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private PaintOrder(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator PaintOrder(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Perspective : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private Perspective(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Perspective(string t) => new(0, value0: t);
            public static implicit operator Perspective(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PerspectiveOrigin : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private PerspectiveOrigin(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator PerspectiveOrigin(string t) => new(0, value0: t);
            public static implicit operator PerspectiveOrigin(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PlaceContent : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private PlaceContent(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator PlaceContent(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PlaceItems : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private PlaceItems(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator PlaceItems(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PlaceSelf : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private PlaceSelf(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator PlaceSelf(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PointerEvents : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private PointerEvents(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator PointerEvents(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Position : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Position(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Position(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Quotes : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Quotes(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Quotes(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Resize : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Resize(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Resize(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Right : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private Right(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Right(string t) => new(0, value0: t);
            public static implicit operator Right(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Rotate : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Rotate(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Rotate(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct RowGap : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private RowGap(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator RowGap(string t) => new(0, value0: t);
            public static implicit operator RowGap(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct RubyAlign : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private RubyAlign(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator RubyAlign(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct RubyMerge : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private RubyMerge(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator RubyMerge(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct RubyPosition : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private RubyPosition(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator RubyPosition(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Scale : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private Scale(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Scale(string t) => new(0, value0: t);
            public static implicit operator Scale(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollBehavior : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ScrollBehavior(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ScrollBehavior(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMargin : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ScrollMargin(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollMargin(string t) => new(0, value0: t);
            public static implicit operator ScrollMargin(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginBlock : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ScrollMarginBlock(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollMarginBlock(string t) => new(0, value0: t);
            public static implicit operator ScrollMarginBlock(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginBlockEnd : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ScrollMarginBlockEnd(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollMarginBlockEnd(string t) => new(0, value0: t);
            public static implicit operator ScrollMarginBlockEnd(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginBlockStart : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ScrollMarginBlockStart(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollMarginBlockStart(string t) => new(0, value0: t);
            public static implicit operator ScrollMarginBlockStart(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginBottom : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ScrollMarginBottom(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollMarginBottom(string t) => new(0, value0: t);
            public static implicit operator ScrollMarginBottom(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginInline : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ScrollMarginInline(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollMarginInline(string t) => new(0, value0: t);
            public static implicit operator ScrollMarginInline(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginInlineEnd : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ScrollMarginInlineEnd(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollMarginInlineEnd(string t) => new(0, value0: t);
            public static implicit operator ScrollMarginInlineEnd(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginInlineStart : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ScrollMarginInlineStart(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollMarginInlineStart(string t) => new(0, value0: t);
            public static implicit operator ScrollMarginInlineStart(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginLeft : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ScrollMarginLeft(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollMarginLeft(string t) => new(0, value0: t);
            public static implicit operator ScrollMarginLeft(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginRight : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ScrollMarginRight(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollMarginRight(string t) => new(0, value0: t);
            public static implicit operator ScrollMarginRight(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginTop : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ScrollMarginTop(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollMarginTop(string t) => new(0, value0: t);
            public static implicit operator ScrollMarginTop(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPadding : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ScrollPadding(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollPadding(string t) => new(0, value0: t);
            public static implicit operator ScrollPadding(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingBlock : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ScrollPaddingBlock(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollPaddingBlock(string t) => new(0, value0: t);
            public static implicit operator ScrollPaddingBlock(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingBlockEnd : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ScrollPaddingBlockEnd(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollPaddingBlockEnd(string t) => new(0, value0: t);
            public static implicit operator ScrollPaddingBlockEnd(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingBlockStart : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ScrollPaddingBlockStart(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollPaddingBlockStart(string t) => new(0, value0: t);
            public static implicit operator ScrollPaddingBlockStart(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingBottom : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ScrollPaddingBottom(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollPaddingBottom(string t) => new(0, value0: t);
            public static implicit operator ScrollPaddingBottom(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingInline : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ScrollPaddingInline(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollPaddingInline(string t) => new(0, value0: t);
            public static implicit operator ScrollPaddingInline(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingInlineEnd : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ScrollPaddingInlineEnd(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollPaddingInlineEnd(string t) => new(0, value0: t);
            public static implicit operator ScrollPaddingInlineEnd(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingInlineStart : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ScrollPaddingInlineStart(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollPaddingInlineStart(string t) => new(0, value0: t);
            public static implicit operator ScrollPaddingInlineStart(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingLeft : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ScrollPaddingLeft(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollPaddingLeft(string t) => new(0, value0: t);
            public static implicit operator ScrollPaddingLeft(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingRight : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ScrollPaddingRight(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollPaddingRight(string t) => new(0, value0: t);
            public static implicit operator ScrollPaddingRight(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingTop : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ScrollPaddingTop(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollPaddingTop(string t) => new(0, value0: t);
            public static implicit operator ScrollPaddingTop(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapAlign : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ScrollSnapAlign(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ScrollSnapAlign(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapCoordinate : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ScrollSnapCoordinate(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollSnapCoordinate(string t) => new(0, value0: t);
            public static implicit operator ScrollSnapCoordinate(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapDestination : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ScrollSnapDestination(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollSnapDestination(string t) => new(0, value0: t);
            public static implicit operator ScrollSnapDestination(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapPointsX : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ScrollSnapPointsX(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ScrollSnapPointsX(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapPointsY : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ScrollSnapPointsY(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ScrollSnapPointsY(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapStop : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ScrollSnapStop(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ScrollSnapStop(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapType : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ScrollSnapType(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ScrollSnapType(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapTypeX : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ScrollSnapTypeX(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ScrollSnapTypeX(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapTypeY : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ScrollSnapTypeY(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ScrollSnapTypeY(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollTimeline : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ScrollTimeline(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ScrollTimeline(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollTimelineAxis : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ScrollTimelineAxis(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ScrollTimelineAxis(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollTimelineName : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ScrollTimelineName(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ScrollTimelineName(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollbarColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ScrollbarColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ScrollbarColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollbarGutter : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ScrollbarGutter(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ScrollbarGutter(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollbarWidth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ScrollbarWidth(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ScrollbarWidth(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ShapeImageThreshold : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ShapeImageThreshold(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ShapeImageThreshold(string t) => new(0, value0: t);
            public static implicit operator ShapeImageThreshold(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ShapeMargin : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ShapeMargin(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ShapeMargin(string t) => new(0, value0: t);
            public static implicit operator ShapeMargin(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ShapeOutside : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ShapeOutside(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ShapeOutside(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TabSize : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private TabSize(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TabSize(string t) => new(0, value0: t);
            public static implicit operator TabSize(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TableLayout : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TableLayout(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TableLayout(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextAlign : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TextAlign(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TextAlign(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextAlignLast : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TextAlignLast(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TextAlignLast(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextCombineUpright : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TextCombineUpright(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TextCombineUpright(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextDecoration : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private TextDecoration(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TextDecoration(string t) => new(0, value0: t);
            public static implicit operator TextDecoration(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextDecorationColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TextDecorationColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TextDecorationColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextDecorationLine : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TextDecorationLine(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TextDecorationLine(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextDecorationSkip : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TextDecorationSkip(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TextDecorationSkip(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextDecorationSkipInk : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TextDecorationSkipInk(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TextDecorationSkipInk(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextDecorationStyle : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TextDecorationStyle(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TextDecorationStyle(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextDecorationThickness : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private TextDecorationThickness(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TextDecorationThickness(string t) => new(0, value0: t);
            public static implicit operator TextDecorationThickness(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextEmphasis : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TextEmphasis(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TextEmphasis(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextEmphasisColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TextEmphasisColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TextEmphasisColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextEmphasisPosition : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TextEmphasisPosition(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TextEmphasisPosition(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextEmphasisStyle : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TextEmphasisStyle(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TextEmphasisStyle(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextIndent : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private TextIndent(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TextIndent(string t) => new(0, value0: t);
            public static implicit operator TextIndent(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextJustify : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TextJustify(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TextJustify(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextOrientation : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TextOrientation(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TextOrientation(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextOverflow : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TextOverflow(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TextOverflow(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextRendering : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TextRendering(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TextRendering(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextShadow : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TextShadow(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TextShadow(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextSizeAdjust : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TextSizeAdjust(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TextSizeAdjust(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextTransform : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TextTransform(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TextTransform(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextUnderlineOffset : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private TextUnderlineOffset(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TextUnderlineOffset(string t) => new(0, value0: t);
            public static implicit operator TextUnderlineOffset(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextUnderlinePosition : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TextUnderlinePosition(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TextUnderlinePosition(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Top : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private Top(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Top(string t) => new(0, value0: t);
            public static implicit operator Top(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TouchAction : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TouchAction(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TouchAction(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Transform : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Transform(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Transform(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TransformBox : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TransformBox(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TransformBox(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TransformOrigin : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private TransformOrigin(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TransformOrigin(string t) => new(0, value0: t);
            public static implicit operator TransformOrigin(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TransformStyle : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TransformStyle(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TransformStyle(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Transition : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Transition(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Transition(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TransitionDelay : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TransitionDelay(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TransitionDelay(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TransitionDuration : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TransitionDuration(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TransitionDuration(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TransitionProperty : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TransitionProperty(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TransitionProperty(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TransitionTimingFunction : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TransitionTimingFunction(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TransitionTimingFunction(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Translate : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private Translate(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Translate(string t) => new(0, value0: t);
            public static implicit operator Translate(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct UnicodeBidi : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private UnicodeBidi(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator UnicodeBidi(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct UserSelect : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private UserSelect(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator UserSelect(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct VerticalAlign : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private VerticalAlign(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator VerticalAlign(string t) => new(0, value0: t);
            public static implicit operator VerticalAlign(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ViewTransitionName : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ViewTransitionName(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ViewTransitionName(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Visibility : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Visibility(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Visibility(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WhiteSpace : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private WhiteSpace(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator WhiteSpace(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Widows : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private Widows(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Widows(string t) => new(0, value0: t);
            public static implicit operator Widows(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Width : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private Width(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Width(string t) => new(0, value0: t);
            public static implicit operator Width(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WillChange : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private WillChange(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator WillChange(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WordBreak : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private WordBreak(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator WordBreak(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WordSpacing : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private WordSpacing(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WordSpacing(string t) => new(0, value0: t);
            public static implicit operator WordSpacing(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WordWrap : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private WordWrap(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator WordWrap(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WritingMode : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private WritingMode(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator WritingMode(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ZIndex : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private ZIndex(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ZIndex(string t) => new(0, value0: t);
            public static implicit operator ZIndex(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Zoom : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private Zoom(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Zoom(string t) => new(0, value0: t);
            public static implicit operator Zoom(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozAppearance : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MozAppearance(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MozAppearance(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozBinding : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MozBinding(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MozBinding(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozBorderBottomColors : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MozBorderBottomColors(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MozBorderBottomColors(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozBorderLeftColors : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MozBorderLeftColors(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MozBorderLeftColors(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozBorderRightColors : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MozBorderRightColors(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MozBorderRightColors(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozBorderTopColors : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MozBorderTopColors(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MozBorderTopColors(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozContextProperties : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MozContextProperties(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MozContextProperties(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozFloatEdge : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MozFloatEdge(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MozFloatEdge(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozForceBrokenImageIcon : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MozForceBrokenImageIcon(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MozForceBrokenImageIcon(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozImageRegion : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MozImageRegion(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MozImageRegion(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozOrient : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MozOrient(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MozOrient(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozOutlineRadius : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MozOutlineRadius(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MozOutlineRadius(string t) => new(0, value0: t);
            public static implicit operator MozOutlineRadius(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozOutlineRadiusBottomleft : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MozOutlineRadiusBottomleft(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MozOutlineRadiusBottomleft(string t) => new(0, value0: t);
            public static implicit operator MozOutlineRadiusBottomleft(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozOutlineRadiusBottomright : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MozOutlineRadiusBottomright(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MozOutlineRadiusBottomright(string t) => new(0, value0: t);
            public static implicit operator MozOutlineRadiusBottomright(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozOutlineRadiusTopleft : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MozOutlineRadiusTopleft(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MozOutlineRadiusTopleft(string t) => new(0, value0: t);
            public static implicit operator MozOutlineRadiusTopleft(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozOutlineRadiusTopright : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MozOutlineRadiusTopright(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MozOutlineRadiusTopright(string t) => new(0, value0: t);
            public static implicit operator MozOutlineRadiusTopright(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozStackSizing : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MozStackSizing(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MozStackSizing(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozTextBlink : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MozTextBlink(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MozTextBlink(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozUserFocus : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MozUserFocus(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MozUserFocus(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozUserInput : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MozUserInput(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MozUserInput(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozUserModify : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MozUserModify(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MozUserModify(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozWindowDragging : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MozWindowDragging(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MozWindowDragging(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozWindowShadow : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MozWindowShadow(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MozWindowShadow(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsAccelerator : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsAccelerator(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsAccelerator(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsBlockProgression : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsBlockProgression(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsBlockProgression(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsContentZoomChaining : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsContentZoomChaining(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsContentZoomChaining(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsContentZoomLimit : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsContentZoomLimit(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsContentZoomLimit(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsContentZoomLimitMax : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsContentZoomLimitMax(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsContentZoomLimitMax(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsContentZoomLimitMin : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsContentZoomLimitMin(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsContentZoomLimitMin(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsContentZoomSnap : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsContentZoomSnap(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsContentZoomSnap(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsContentZoomSnapPoints : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsContentZoomSnapPoints(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsContentZoomSnapPoints(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsContentZoomSnapType : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsContentZoomSnapType(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsContentZoomSnapType(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsContentZooming : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsContentZooming(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsContentZooming(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsFilter : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsFilter(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsFilter(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsFlowFrom : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsFlowFrom(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsFlowFrom(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsFlowInto : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsFlowInto(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsFlowInto(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsGridColumns : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MsGridColumns(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsGridColumns(string t) => new(0, value0: t);
            public static implicit operator MsGridColumns(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsGridRows : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MsGridRows(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsGridRows(string t) => new(0, value0: t);
            public static implicit operator MsGridRows(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsHighContrastAdjust : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsHighContrastAdjust(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsHighContrastAdjust(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsHyphenateLimitChars : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MsHyphenateLimitChars(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsHyphenateLimitChars(string t) => new(0, value0: t);
            public static implicit operator MsHyphenateLimitChars(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsHyphenateLimitLines : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MsHyphenateLimitLines(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsHyphenateLimitLines(string t) => new(0, value0: t);
            public static implicit operator MsHyphenateLimitLines(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsHyphenateLimitZone : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MsHyphenateLimitZone(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsHyphenateLimitZone(string t) => new(0, value0: t);
            public static implicit operator MsHyphenateLimitZone(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsImeAlign : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsImeAlign(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsImeAlign(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsOverflowStyle : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsOverflowStyle(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsOverflowStyle(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollChaining : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsScrollChaining(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsScrollChaining(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollLimit : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsScrollLimit(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsScrollLimit(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollLimitXMax : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MsScrollLimitXMax(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsScrollLimitXMax(string t) => new(0, value0: t);
            public static implicit operator MsScrollLimitXMax(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollLimitXMin : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MsScrollLimitXMin(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsScrollLimitXMin(string t) => new(0, value0: t);
            public static implicit operator MsScrollLimitXMin(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollLimitYMax : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MsScrollLimitYMax(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsScrollLimitYMax(string t) => new(0, value0: t);
            public static implicit operator MsScrollLimitYMax(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollLimitYMin : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MsScrollLimitYMin(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsScrollLimitYMin(string t) => new(0, value0: t);
            public static implicit operator MsScrollLimitYMin(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollRails : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsScrollRails(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsScrollRails(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollSnapPointsX : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsScrollSnapPointsX(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsScrollSnapPointsX(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollSnapPointsY : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsScrollSnapPointsY(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsScrollSnapPointsY(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollSnapType : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsScrollSnapType(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsScrollSnapType(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollSnapX : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsScrollSnapX(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsScrollSnapX(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollSnapY : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsScrollSnapY(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsScrollSnapY(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollTranslation : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsScrollTranslation(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsScrollTranslation(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollbar3dlightColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsScrollbar3dlightColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsScrollbar3dlightColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollbarArrowColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsScrollbarArrowColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsScrollbarArrowColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollbarBaseColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsScrollbarBaseColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsScrollbarBaseColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollbarDarkshadowColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsScrollbarDarkshadowColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsScrollbarDarkshadowColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollbarFaceColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsScrollbarFaceColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsScrollbarFaceColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollbarHighlightColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsScrollbarHighlightColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsScrollbarHighlightColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollbarShadowColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsScrollbarShadowColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsScrollbarShadowColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollbarTrackColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsScrollbarTrackColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsScrollbarTrackColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsTextAutospace : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsTextAutospace(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsTextAutospace(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsTouchSelect : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsTouchSelect(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsTouchSelect(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsUserSelect : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsUserSelect(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsUserSelect(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsWrapFlow : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsWrapFlow(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsWrapFlow(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsWrapMargin : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private MsWrapMargin(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsWrapMargin(string t) => new(0, value0: t);
            public static implicit operator MsWrapMargin(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsWrapThrough : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MsWrapThrough(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MsWrapThrough(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitAppearance : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private WebkitAppearance(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator WebkitAppearance(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitBorderBefore : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private WebkitBorderBefore(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitBorderBefore(string t) => new(0, value0: t);
            public static implicit operator WebkitBorderBefore(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitBorderBeforeColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private WebkitBorderBeforeColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator WebkitBorderBeforeColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitBorderBeforeStyle : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private WebkitBorderBeforeStyle(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator WebkitBorderBeforeStyle(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitBorderBeforeWidth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private WebkitBorderBeforeWidth(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitBorderBeforeWidth(string t) => new(0, value0: t);
            public static implicit operator WebkitBorderBeforeWidth(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitBoxReflect : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private WebkitBoxReflect(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitBoxReflect(string t) => new(0, value0: t);
            public static implicit operator WebkitBoxReflect(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitLineClamp : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private WebkitLineClamp(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitLineClamp(string t) => new(0, value0: t);
            public static implicit operator WebkitLineClamp(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMask : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private WebkitMask(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitMask(string t) => new(0, value0: t);
            public static implicit operator WebkitMask(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskAttachment : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private WebkitMaskAttachment(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator WebkitMaskAttachment(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskClip : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private WebkitMaskClip(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator WebkitMaskClip(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskComposite : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private WebkitMaskComposite(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator WebkitMaskComposite(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskImage : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private WebkitMaskImage(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator WebkitMaskImage(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskOrigin : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private WebkitMaskOrigin(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator WebkitMaskOrigin(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskPosition : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private WebkitMaskPosition(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitMaskPosition(string t) => new(0, value0: t);
            public static implicit operator WebkitMaskPosition(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskPositionX : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private WebkitMaskPositionX(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitMaskPositionX(string t) => new(0, value0: t);
            public static implicit operator WebkitMaskPositionX(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskPositionY : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private WebkitMaskPositionY(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitMaskPositionY(string t) => new(0, value0: t);
            public static implicit operator WebkitMaskPositionY(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskRepeat : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private WebkitMaskRepeat(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator WebkitMaskRepeat(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskRepeatX : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private WebkitMaskRepeatX(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator WebkitMaskRepeatX(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskRepeatY : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private WebkitMaskRepeatY(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator WebkitMaskRepeatY(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskSize : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private WebkitMaskSize(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitMaskSize(string t) => new(0, value0: t);
            public static implicit operator WebkitMaskSize(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitOverflowScrolling : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private WebkitOverflowScrolling(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator WebkitOverflowScrolling(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitTapHighlightColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private WebkitTapHighlightColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator WebkitTapHighlightColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitTextFillColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private WebkitTextFillColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator WebkitTextFillColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitTextStroke : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private WebkitTextStroke(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitTextStroke(string t) => new(0, value0: t);
            public static implicit operator WebkitTextStroke(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitTextStrokeColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private WebkitTextStrokeColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator WebkitTextStrokeColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitTextStrokeWidth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private WebkitTextStrokeWidth(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitTextStrokeWidth(string t) => new(0, value0: t);
            public static implicit operator WebkitTextStrokeWidth(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitTouchCallout : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private WebkitTouchCallout(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator WebkitTouchCallout(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitUserModify : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private WebkitUserModify(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator WebkitUserModify(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AlignmentBaseline : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private AlignmentBaseline(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator AlignmentBaseline(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BaselineShift : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private BaselineShift(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BaselineShift(string t) => new(0, value0: t);
            public static implicit operator BaselineShift(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ClipRule : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ClipRule(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ClipRule(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColorInterpolation : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ColorInterpolation(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ColorInterpolation(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColorRendering : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ColorRendering(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ColorRendering(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct DominantBaseline : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private DominantBaseline(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator DominantBaseline(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Fill : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Fill(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Fill(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FillOpacity : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private FillOpacity(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FillOpacity(string t) => new(0, value0: t);
            public static implicit operator FillOpacity(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FillRule : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private FillRule(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator FillRule(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FloodColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private FloodColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator FloodColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FloodOpacity : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private FloodOpacity(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FloodOpacity(string t) => new(0, value0: t);
            public static implicit operator FloodOpacity(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GlyphOrientationVertical : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private GlyphOrientationVertical(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator GlyphOrientationVertical(string t) => new(0, value0: t);
            public static implicit operator GlyphOrientationVertical(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct LightingColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private LightingColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator LightingColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Marker : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Marker(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Marker(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarkerEnd : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MarkerEnd(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MarkerEnd(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarkerMid : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MarkerMid(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MarkerMid(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarkerStart : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private MarkerStart(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator MarkerStart(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ShapeRendering : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private ShapeRendering(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator ShapeRendering(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StopColor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private StopColor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator StopColor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StopOpacity : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private StopOpacity(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator StopOpacity(string t) => new(0, value0: t);
            public static implicit operator StopOpacity(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Stroke : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private Stroke(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator Stroke(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StrokeDasharray : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private StrokeDasharray(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator StrokeDasharray(string t) => new(0, value0: t);
            public static implicit operator StrokeDasharray(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StrokeDashoffset : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private StrokeDashoffset(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator StrokeDashoffset(string t) => new(0, value0: t);
            public static implicit operator StrokeDashoffset(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StrokeLinecap : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private StrokeLinecap(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator StrokeLinecap(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StrokeLinejoin : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private StrokeLinejoin(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator StrokeLinejoin(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StrokeMiterlimit : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private StrokeMiterlimit(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator StrokeMiterlimit(string t) => new(0, value0: t);
            public static implicit operator StrokeMiterlimit(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StrokeOpacity : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private StrokeOpacity(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator StrokeOpacity(string t) => new(0, value0: t);
            public static implicit operator StrokeOpacity(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StrokeWidth : IProperty
        {
            private readonly int _index;
            private readonly string _value0;
            private readonly int _value1;

            private StrokeWidth(int index, string value0 = default, int value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator StrokeWidth(string t) => new(0, value0: t);
            public static implicit operator StrokeWidth(int t) => new(1, value1: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    1 => FormatValue(_value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextAnchor : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private TextAnchor(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator TextAnchor(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct VectorEffect : IProperty
        {
            private readonly int _index;
            private readonly string _value0;

            private VectorEffect(int index, string value0 = default)
            {
                _index = index;
                _value0 = value0;
            }

            public static implicit operator VectorEffect(string t) => new(0, value0: t);

            public string GetValue()
            {
                return _index switch
                {
                    0 => FormatValue(_value0),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }
}
}
