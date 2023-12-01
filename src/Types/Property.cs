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
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private AccentColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator AccentColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator AccentColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AlignContent : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private AlignContent(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator AlignContent(PropertySkip t) => new(0, value0: t);
            public static implicit operator AlignContent(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AlignItems : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private AlignItems(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator AlignItems(PropertySkip t) => new(0, value0: t);
            public static implicit operator AlignItems(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AlignSelf : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private AlignSelf(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator AlignSelf(PropertySkip t) => new(0, value0: t);
            public static implicit operator AlignSelf(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AlignTracks : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private AlignTracks(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator AlignTracks(PropertySkip t) => new(0, value0: t);
            public static implicit operator AlignTracks(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct All : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private All(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator All(PropertySkip t) => new(0, value0: t);
            public static implicit operator All(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Animation : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Animation(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Animation(PropertySkip t) => new(0, value0: t);
            public static implicit operator Animation(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationComposition : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private AnimationComposition(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator AnimationComposition(PropertySkip t) => new(0, value0: t);
            public static implicit operator AnimationComposition(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationDelay : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private AnimationDelay(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator AnimationDelay(PropertySkip t) => new(0, value0: t);
            public static implicit operator AnimationDelay(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationDirection : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private AnimationDirection(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator AnimationDirection(PropertySkip t) => new(0, value0: t);
            public static implicit operator AnimationDirection(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationDuration : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private AnimationDuration(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator AnimationDuration(PropertySkip t) => new(0, value0: t);
            public static implicit operator AnimationDuration(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationFillMode : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private AnimationFillMode(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator AnimationFillMode(PropertySkip t) => new(0, value0: t);
            public static implicit operator AnimationFillMode(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationIterationCount : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private AnimationIterationCount(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator AnimationIterationCount(PropertySkip t) => new(0, value0: t);
            public static implicit operator AnimationIterationCount(string t) => new(1, value1: t);
            public static implicit operator AnimationIterationCount(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationName : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly Keyframe _value2;

            private AnimationName(int index, PropertySkip value0 = default, string value1 = default, Keyframe value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator AnimationName(PropertySkip t) => new(0, value0: t);
            public static implicit operator AnimationName(string t) => new(1, value1: t);
            public static implicit operator AnimationName(Keyframe t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationPlayState : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private AnimationPlayState(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator AnimationPlayState(PropertySkip t) => new(0, value0: t);
            public static implicit operator AnimationPlayState(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationTimeline : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private AnimationTimeline(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator AnimationTimeline(PropertySkip t) => new(0, value0: t);
            public static implicit operator AnimationTimeline(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationTimingFunction : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private AnimationTimingFunction(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator AnimationTimingFunction(PropertySkip t) => new(0, value0: t);
            public static implicit operator AnimationTimingFunction(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Appearance : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Appearance(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Appearance(PropertySkip t) => new(0, value0: t);
            public static implicit operator Appearance(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AspectRatio : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private AspectRatio(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator AspectRatio(PropertySkip t) => new(0, value0: t);
            public static implicit operator AspectRatio(string t) => new(1, value1: t);
            public static implicit operator AspectRatio(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Azimuth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Azimuth(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Azimuth(PropertySkip t) => new(0, value0: t);
            public static implicit operator Azimuth(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackdropFilter : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BackdropFilter(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BackdropFilter(PropertySkip t) => new(0, value0: t);
            public static implicit operator BackdropFilter(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackfaceVisibility : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BackfaceVisibility(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BackfaceVisibility(PropertySkip t) => new(0, value0: t);
            public static implicit operator BackfaceVisibility(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Background : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private Background(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Background(PropertySkip t) => new(0, value0: t);
            public static implicit operator Background(string t) => new(1, value1: t);
            public static implicit operator Background(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundAttachment : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BackgroundAttachment(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BackgroundAttachment(PropertySkip t) => new(0, value0: t);
            public static implicit operator BackgroundAttachment(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundBlendMode : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BackgroundBlendMode(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BackgroundBlendMode(PropertySkip t) => new(0, value0: t);
            public static implicit operator BackgroundBlendMode(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundClip : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BackgroundClip(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BackgroundClip(PropertySkip t) => new(0, value0: t);
            public static implicit operator BackgroundClip(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BackgroundColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BackgroundColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator BackgroundColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundImage : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BackgroundImage(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BackgroundImage(PropertySkip t) => new(0, value0: t);
            public static implicit operator BackgroundImage(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundOrigin : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BackgroundOrigin(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BackgroundOrigin(PropertySkip t) => new(0, value0: t);
            public static implicit operator BackgroundOrigin(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundPosition : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BackgroundPosition(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BackgroundPosition(PropertySkip t) => new(0, value0: t);
            public static implicit operator BackgroundPosition(string t) => new(1, value1: t);
            public static implicit operator BackgroundPosition(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundPositionX : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BackgroundPositionX(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BackgroundPositionX(PropertySkip t) => new(0, value0: t);
            public static implicit operator BackgroundPositionX(string t) => new(1, value1: t);
            public static implicit operator BackgroundPositionX(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundPositionY : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BackgroundPositionY(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BackgroundPositionY(PropertySkip t) => new(0, value0: t);
            public static implicit operator BackgroundPositionY(string t) => new(1, value1: t);
            public static implicit operator BackgroundPositionY(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundRepeat : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BackgroundRepeat(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BackgroundRepeat(PropertySkip t) => new(0, value0: t);
            public static implicit operator BackgroundRepeat(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundSize : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BackgroundSize(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BackgroundSize(PropertySkip t) => new(0, value0: t);
            public static implicit operator BackgroundSize(string t) => new(1, value1: t);
            public static implicit operator BackgroundSize(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BlockOverflow : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BlockOverflow(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BlockOverflow(PropertySkip t) => new(0, value0: t);
            public static implicit operator BlockOverflow(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BlockSize : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BlockSize(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BlockSize(PropertySkip t) => new(0, value0: t);
            public static implicit operator BlockSize(string t) => new(1, value1: t);
            public static implicit operator BlockSize(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Border : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private Border(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Border(PropertySkip t) => new(0, value0: t);
            public static implicit operator Border(string t) => new(1, value1: t);
            public static implicit operator Border(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlock : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderBlock(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderBlock(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderBlock(string t) => new(1, value1: t);
            public static implicit operator BorderBlock(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BorderBlockColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderBlockColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderBlockColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockEnd : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderBlockEnd(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderBlockEnd(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderBlockEnd(string t) => new(1, value1: t);
            public static implicit operator BorderBlockEnd(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockEndColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BorderBlockEndColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderBlockEndColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderBlockEndColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockEndStyle : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BorderBlockEndStyle(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderBlockEndStyle(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderBlockEndStyle(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockEndWidth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderBlockEndWidth(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderBlockEndWidth(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderBlockEndWidth(string t) => new(1, value1: t);
            public static implicit operator BorderBlockEndWidth(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockStart : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderBlockStart(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderBlockStart(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderBlockStart(string t) => new(1, value1: t);
            public static implicit operator BorderBlockStart(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockStartColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BorderBlockStartColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderBlockStartColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderBlockStartColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockStartStyle : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BorderBlockStartStyle(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderBlockStartStyle(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderBlockStartStyle(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockStartWidth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderBlockStartWidth(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderBlockStartWidth(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderBlockStartWidth(string t) => new(1, value1: t);
            public static implicit operator BorderBlockStartWidth(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockStyle : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BorderBlockStyle(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderBlockStyle(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderBlockStyle(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockWidth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderBlockWidth(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderBlockWidth(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderBlockWidth(string t) => new(1, value1: t);
            public static implicit operator BorderBlockWidth(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBottom : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderBottom(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderBottom(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderBottom(string t) => new(1, value1: t);
            public static implicit operator BorderBottom(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBottomColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BorderBottomColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderBottomColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderBottomColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBottomLeftRadius : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderBottomLeftRadius(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderBottomLeftRadius(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderBottomLeftRadius(string t) => new(1, value1: t);
            public static implicit operator BorderBottomLeftRadius(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBottomRightRadius : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderBottomRightRadius(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderBottomRightRadius(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderBottomRightRadius(string t) => new(1, value1: t);
            public static implicit operator BorderBottomRightRadius(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBottomStyle : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BorderBottomStyle(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderBottomStyle(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderBottomStyle(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBottomWidth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderBottomWidth(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderBottomWidth(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderBottomWidth(string t) => new(1, value1: t);
            public static implicit operator BorderBottomWidth(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderCollapse : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BorderCollapse(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderCollapse(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderCollapse(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BorderColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderEndEndRadius : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderEndEndRadius(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderEndEndRadius(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderEndEndRadius(string t) => new(1, value1: t);
            public static implicit operator BorderEndEndRadius(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderEndStartRadius : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderEndStartRadius(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderEndStartRadius(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderEndStartRadius(string t) => new(1, value1: t);
            public static implicit operator BorderEndStartRadius(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderImage : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderImage(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderImage(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderImage(string t) => new(1, value1: t);
            public static implicit operator BorderImage(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderImageOutset : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderImageOutset(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderImageOutset(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderImageOutset(string t) => new(1, value1: t);
            public static implicit operator BorderImageOutset(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderImageRepeat : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BorderImageRepeat(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderImageRepeat(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderImageRepeat(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderImageSlice : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderImageSlice(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderImageSlice(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderImageSlice(string t) => new(1, value1: t);
            public static implicit operator BorderImageSlice(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderImageSource : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BorderImageSource(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderImageSource(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderImageSource(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderImageWidth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderImageWidth(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderImageWidth(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderImageWidth(string t) => new(1, value1: t);
            public static implicit operator BorderImageWidth(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInline : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderInline(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderInline(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderInline(string t) => new(1, value1: t);
            public static implicit operator BorderInline(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BorderInlineColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderInlineColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderInlineColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineEnd : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderInlineEnd(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderInlineEnd(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderInlineEnd(string t) => new(1, value1: t);
            public static implicit operator BorderInlineEnd(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineEndColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BorderInlineEndColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderInlineEndColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderInlineEndColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineEndStyle : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BorderInlineEndStyle(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderInlineEndStyle(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderInlineEndStyle(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineEndWidth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderInlineEndWidth(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderInlineEndWidth(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderInlineEndWidth(string t) => new(1, value1: t);
            public static implicit operator BorderInlineEndWidth(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineStart : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderInlineStart(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderInlineStart(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderInlineStart(string t) => new(1, value1: t);
            public static implicit operator BorderInlineStart(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineStartColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BorderInlineStartColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderInlineStartColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderInlineStartColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineStartStyle : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BorderInlineStartStyle(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderInlineStartStyle(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderInlineStartStyle(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineStartWidth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderInlineStartWidth(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderInlineStartWidth(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderInlineStartWidth(string t) => new(1, value1: t);
            public static implicit operator BorderInlineStartWidth(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineStyle : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BorderInlineStyle(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderInlineStyle(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderInlineStyle(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineWidth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderInlineWidth(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderInlineWidth(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderInlineWidth(string t) => new(1, value1: t);
            public static implicit operator BorderInlineWidth(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderLeft : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderLeft(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderLeft(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderLeft(string t) => new(1, value1: t);
            public static implicit operator BorderLeft(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderLeftColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BorderLeftColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderLeftColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderLeftColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderLeftStyle : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BorderLeftStyle(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderLeftStyle(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderLeftStyle(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderLeftWidth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderLeftWidth(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderLeftWidth(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderLeftWidth(string t) => new(1, value1: t);
            public static implicit operator BorderLeftWidth(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderRadius : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderRadius(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderRadius(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderRadius(string t) => new(1, value1: t);
            public static implicit operator BorderRadius(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderRight : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderRight(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderRight(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderRight(string t) => new(1, value1: t);
            public static implicit operator BorderRight(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderRightColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BorderRightColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderRightColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderRightColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderRightStyle : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BorderRightStyle(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderRightStyle(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderRightStyle(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderRightWidth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderRightWidth(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderRightWidth(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderRightWidth(string t) => new(1, value1: t);
            public static implicit operator BorderRightWidth(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderSpacing : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderSpacing(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderSpacing(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderSpacing(string t) => new(1, value1: t);
            public static implicit operator BorderSpacing(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderStartEndRadius : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderStartEndRadius(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderStartEndRadius(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderStartEndRadius(string t) => new(1, value1: t);
            public static implicit operator BorderStartEndRadius(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderStartStartRadius : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderStartStartRadius(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderStartStartRadius(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderStartStartRadius(string t) => new(1, value1: t);
            public static implicit operator BorderStartStartRadius(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderStyle : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BorderStyle(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderStyle(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderStyle(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderTop : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderTop(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderTop(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderTop(string t) => new(1, value1: t);
            public static implicit operator BorderTop(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderTopColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BorderTopColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderTopColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderTopColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderTopLeftRadius : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderTopLeftRadius(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderTopLeftRadius(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderTopLeftRadius(string t) => new(1, value1: t);
            public static implicit operator BorderTopLeftRadius(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderTopRightRadius : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderTopRightRadius(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderTopRightRadius(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderTopRightRadius(string t) => new(1, value1: t);
            public static implicit operator BorderTopRightRadius(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderTopStyle : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BorderTopStyle(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BorderTopStyle(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderTopStyle(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderTopWidth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderTopWidth(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderTopWidth(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderTopWidth(string t) => new(1, value1: t);
            public static implicit operator BorderTopWidth(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderWidth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BorderWidth(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderWidth(PropertySkip t) => new(0, value0: t);
            public static implicit operator BorderWidth(string t) => new(1, value1: t);
            public static implicit operator BorderWidth(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Bottom : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private Bottom(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Bottom(PropertySkip t) => new(0, value0: t);
            public static implicit operator Bottom(string t) => new(1, value1: t);
            public static implicit operator Bottom(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxAlign : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BoxAlign(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BoxAlign(PropertySkip t) => new(0, value0: t);
            public static implicit operator BoxAlign(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxDecorationBreak : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BoxDecorationBreak(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BoxDecorationBreak(PropertySkip t) => new(0, value0: t);
            public static implicit operator BoxDecorationBreak(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxDirection : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BoxDirection(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BoxDirection(PropertySkip t) => new(0, value0: t);
            public static implicit operator BoxDirection(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxFlex : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BoxFlex(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BoxFlex(PropertySkip t) => new(0, value0: t);
            public static implicit operator BoxFlex(string t) => new(1, value1: t);
            public static implicit operator BoxFlex(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxFlexGroup : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BoxFlexGroup(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BoxFlexGroup(PropertySkip t) => new(0, value0: t);
            public static implicit operator BoxFlexGroup(string t) => new(1, value1: t);
            public static implicit operator BoxFlexGroup(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxLines : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BoxLines(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BoxLines(PropertySkip t) => new(0, value0: t);
            public static implicit operator BoxLines(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxOrdinalGroup : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BoxOrdinalGroup(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BoxOrdinalGroup(PropertySkip t) => new(0, value0: t);
            public static implicit operator BoxOrdinalGroup(string t) => new(1, value1: t);
            public static implicit operator BoxOrdinalGroup(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxOrient : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BoxOrient(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BoxOrient(PropertySkip t) => new(0, value0: t);
            public static implicit operator BoxOrient(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxPack : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BoxPack(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BoxPack(PropertySkip t) => new(0, value0: t);
            public static implicit operator BoxPack(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxShadow : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BoxShadow(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BoxShadow(PropertySkip t) => new(0, value0: t);
            public static implicit operator BoxShadow(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxSizing : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BoxSizing(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BoxSizing(PropertySkip t) => new(0, value0: t);
            public static implicit operator BoxSizing(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BreakAfter : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BreakAfter(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BreakAfter(PropertySkip t) => new(0, value0: t);
            public static implicit operator BreakAfter(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BreakBefore : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BreakBefore(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BreakBefore(PropertySkip t) => new(0, value0: t);
            public static implicit operator BreakBefore(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BreakInside : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private BreakInside(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator BreakInside(PropertySkip t) => new(0, value0: t);
            public static implicit operator BreakInside(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct CaptionSide : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private CaptionSide(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator CaptionSide(PropertySkip t) => new(0, value0: t);
            public static implicit operator CaptionSide(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Caret : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Caret(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Caret(PropertySkip t) => new(0, value0: t);
            public static implicit operator Caret(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct CaretColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private CaretColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator CaretColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator CaretColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct CaretShape : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private CaretShape(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator CaretShape(PropertySkip t) => new(0, value0: t);
            public static implicit operator CaretShape(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Clear : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Clear(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Clear(PropertySkip t) => new(0, value0: t);
            public static implicit operator Clear(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Clip : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Clip(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Clip(PropertySkip t) => new(0, value0: t);
            public static implicit operator Clip(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ClipPath : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ClipPath(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ClipPath(PropertySkip t) => new(0, value0: t);
            public static implicit operator ClipPath(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Color : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Color(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Color(PropertySkip t) => new(0, value0: t);
            public static implicit operator Color(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PrintColorAdjust : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private PrintColorAdjust(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator PrintColorAdjust(PropertySkip t) => new(0, value0: t);
            public static implicit operator PrintColorAdjust(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColorScheme : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ColorScheme(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ColorScheme(PropertySkip t) => new(0, value0: t);
            public static implicit operator ColorScheme(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnCount : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ColumnCount(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ColumnCount(PropertySkip t) => new(0, value0: t);
            public static implicit operator ColumnCount(string t) => new(1, value1: t);
            public static implicit operator ColumnCount(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnFill : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ColumnFill(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ColumnFill(PropertySkip t) => new(0, value0: t);
            public static implicit operator ColumnFill(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnGap : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ColumnGap(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ColumnGap(PropertySkip t) => new(0, value0: t);
            public static implicit operator ColumnGap(string t) => new(1, value1: t);
            public static implicit operator ColumnGap(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnRule : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ColumnRule(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ColumnRule(PropertySkip t) => new(0, value0: t);
            public static implicit operator ColumnRule(string t) => new(1, value1: t);
            public static implicit operator ColumnRule(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnRuleColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ColumnRuleColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ColumnRuleColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator ColumnRuleColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnRuleStyle : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ColumnRuleStyle(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ColumnRuleStyle(PropertySkip t) => new(0, value0: t);
            public static implicit operator ColumnRuleStyle(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnRuleWidth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ColumnRuleWidth(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ColumnRuleWidth(PropertySkip t) => new(0, value0: t);
            public static implicit operator ColumnRuleWidth(string t) => new(1, value1: t);
            public static implicit operator ColumnRuleWidth(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnSpan : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ColumnSpan(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ColumnSpan(PropertySkip t) => new(0, value0: t);
            public static implicit operator ColumnSpan(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnWidth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ColumnWidth(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ColumnWidth(PropertySkip t) => new(0, value0: t);
            public static implicit operator ColumnWidth(string t) => new(1, value1: t);
            public static implicit operator ColumnWidth(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Columns : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private Columns(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Columns(PropertySkip t) => new(0, value0: t);
            public static implicit operator Columns(string t) => new(1, value1: t);
            public static implicit operator Columns(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Contain : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Contain(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Contain(PropertySkip t) => new(0, value0: t);
            public static implicit operator Contain(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ContainIntrinsicBlockSize : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ContainIntrinsicBlockSize(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ContainIntrinsicBlockSize(PropertySkip t) => new(0, value0: t);
            public static implicit operator ContainIntrinsicBlockSize(string t) => new(1, value1: t);
            public static implicit operator ContainIntrinsicBlockSize(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ContainIntrinsicHeight : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ContainIntrinsicHeight(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ContainIntrinsicHeight(PropertySkip t) => new(0, value0: t);
            public static implicit operator ContainIntrinsicHeight(string t) => new(1, value1: t);
            public static implicit operator ContainIntrinsicHeight(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ContainIntrinsicInlineSize : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ContainIntrinsicInlineSize(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ContainIntrinsicInlineSize(PropertySkip t) => new(0, value0: t);
            public static implicit operator ContainIntrinsicInlineSize(string t) => new(1, value1: t);
            public static implicit operator ContainIntrinsicInlineSize(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ContainIntrinsicSize : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ContainIntrinsicSize(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ContainIntrinsicSize(PropertySkip t) => new(0, value0: t);
            public static implicit operator ContainIntrinsicSize(string t) => new(1, value1: t);
            public static implicit operator ContainIntrinsicSize(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ContainIntrinsicWidth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ContainIntrinsicWidth(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ContainIntrinsicWidth(PropertySkip t) => new(0, value0: t);
            public static implicit operator ContainIntrinsicWidth(string t) => new(1, value1: t);
            public static implicit operator ContainIntrinsicWidth(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Container : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Container(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Container(PropertySkip t) => new(0, value0: t);
            public static implicit operator Container(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ContainerName : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ContainerName(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ContainerName(PropertySkip t) => new(0, value0: t);
            public static implicit operator ContainerName(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ContainerType : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ContainerType(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ContainerType(PropertySkip t) => new(0, value0: t);
            public static implicit operator ContainerType(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Content : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Content(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Content(PropertySkip t) => new(0, value0: t);
            public static implicit operator Content(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ContentVisibility : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ContentVisibility(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ContentVisibility(PropertySkip t) => new(0, value0: t);
            public static implicit operator ContentVisibility(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct CounterIncrement : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private CounterIncrement(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator CounterIncrement(PropertySkip t) => new(0, value0: t);
            public static implicit operator CounterIncrement(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct CounterReset : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private CounterReset(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator CounterReset(PropertySkip t) => new(0, value0: t);
            public static implicit operator CounterReset(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct CounterSet : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private CounterSet(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator CounterSet(PropertySkip t) => new(0, value0: t);
            public static implicit operator CounterSet(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Cursor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Cursor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Cursor(PropertySkip t) => new(0, value0: t);
            public static implicit operator Cursor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Direction : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Direction(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Direction(PropertySkip t) => new(0, value0: t);
            public static implicit operator Direction(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Display : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Display(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Display(PropertySkip t) => new(0, value0: t);
            public static implicit operator Display(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct EmptyCells : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private EmptyCells(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator EmptyCells(PropertySkip t) => new(0, value0: t);
            public static implicit operator EmptyCells(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Filter : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Filter(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Filter(PropertySkip t) => new(0, value0: t);
            public static implicit operator Filter(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Flex : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private Flex(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Flex(PropertySkip t) => new(0, value0: t);
            public static implicit operator Flex(string t) => new(1, value1: t);
            public static implicit operator Flex(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FlexBasis : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private FlexBasis(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FlexBasis(PropertySkip t) => new(0, value0: t);
            public static implicit operator FlexBasis(string t) => new(1, value1: t);
            public static implicit operator FlexBasis(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FlexDirection : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private FlexDirection(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FlexDirection(PropertySkip t) => new(0, value0: t);
            public static implicit operator FlexDirection(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FlexFlow : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private FlexFlow(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FlexFlow(PropertySkip t) => new(0, value0: t);
            public static implicit operator FlexFlow(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FlexGrow : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private FlexGrow(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FlexGrow(PropertySkip t) => new(0, value0: t);
            public static implicit operator FlexGrow(string t) => new(1, value1: t);
            public static implicit operator FlexGrow(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FlexShrink : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private FlexShrink(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FlexShrink(PropertySkip t) => new(0, value0: t);
            public static implicit operator FlexShrink(string t) => new(1, value1: t);
            public static implicit operator FlexShrink(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FlexWrap : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private FlexWrap(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FlexWrap(PropertySkip t) => new(0, value0: t);
            public static implicit operator FlexWrap(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Float : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Float(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Float(PropertySkip t) => new(0, value0: t);
            public static implicit operator Float(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Font : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Font(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Font(PropertySkip t) => new(0, value0: t);
            public static implicit operator Font(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontFamily : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private FontFamily(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FontFamily(PropertySkip t) => new(0, value0: t);
            public static implicit operator FontFamily(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontFeatureSettings : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private FontFeatureSettings(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FontFeatureSettings(PropertySkip t) => new(0, value0: t);
            public static implicit operator FontFeatureSettings(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontKerning : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private FontKerning(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FontKerning(PropertySkip t) => new(0, value0: t);
            public static implicit operator FontKerning(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontLanguageOverride : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private FontLanguageOverride(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FontLanguageOverride(PropertySkip t) => new(0, value0: t);
            public static implicit operator FontLanguageOverride(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontOpticalSizing : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private FontOpticalSizing(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FontOpticalSizing(PropertySkip t) => new(0, value0: t);
            public static implicit operator FontOpticalSizing(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontPalette : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private FontPalette(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FontPalette(PropertySkip t) => new(0, value0: t);
            public static implicit operator FontPalette(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontSize : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private FontSize(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontSize(PropertySkip t) => new(0, value0: t);
            public static implicit operator FontSize(string t) => new(1, value1: t);
            public static implicit operator FontSize(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontSizeAdjust : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private FontSizeAdjust(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontSizeAdjust(PropertySkip t) => new(0, value0: t);
            public static implicit operator FontSizeAdjust(string t) => new(1, value1: t);
            public static implicit operator FontSizeAdjust(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontSmooth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private FontSmooth(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontSmooth(PropertySkip t) => new(0, value0: t);
            public static implicit operator FontSmooth(string t) => new(1, value1: t);
            public static implicit operator FontSmooth(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontStretch : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private FontStretch(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FontStretch(PropertySkip t) => new(0, value0: t);
            public static implicit operator FontStretch(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontStyle : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private FontStyle(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FontStyle(PropertySkip t) => new(0, value0: t);
            public static implicit operator FontStyle(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontSynthesis : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private FontSynthesis(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FontSynthesis(PropertySkip t) => new(0, value0: t);
            public static implicit operator FontSynthesis(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariant : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private FontVariant(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FontVariant(PropertySkip t) => new(0, value0: t);
            public static implicit operator FontVariant(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariantAlternates : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private FontVariantAlternates(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FontVariantAlternates(PropertySkip t) => new(0, value0: t);
            public static implicit operator FontVariantAlternates(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariantCaps : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private FontVariantCaps(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FontVariantCaps(PropertySkip t) => new(0, value0: t);
            public static implicit operator FontVariantCaps(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariantEastAsian : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private FontVariantEastAsian(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FontVariantEastAsian(PropertySkip t) => new(0, value0: t);
            public static implicit operator FontVariantEastAsian(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariantEmoji : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private FontVariantEmoji(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FontVariantEmoji(PropertySkip t) => new(0, value0: t);
            public static implicit operator FontVariantEmoji(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariantLigatures : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private FontVariantLigatures(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FontVariantLigatures(PropertySkip t) => new(0, value0: t);
            public static implicit operator FontVariantLigatures(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariantNumeric : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private FontVariantNumeric(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FontVariantNumeric(PropertySkip t) => new(0, value0: t);
            public static implicit operator FontVariantNumeric(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariantPosition : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private FontVariantPosition(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FontVariantPosition(PropertySkip t) => new(0, value0: t);
            public static implicit operator FontVariantPosition(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariationSettings : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private FontVariationSettings(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FontVariationSettings(PropertySkip t) => new(0, value0: t);
            public static implicit operator FontVariationSettings(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontWeight : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private FontWeight(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontWeight(PropertySkip t) => new(0, value0: t);
            public static implicit operator FontWeight(string t) => new(1, value1: t);
            public static implicit operator FontWeight(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ForcedColorAdjust : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ForcedColorAdjust(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ForcedColorAdjust(PropertySkip t) => new(0, value0: t);
            public static implicit operator ForcedColorAdjust(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Gap : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private Gap(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Gap(PropertySkip t) => new(0, value0: t);
            public static implicit operator Gap(string t) => new(1, value1: t);
            public static implicit operator Gap(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Grid : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Grid(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Grid(PropertySkip t) => new(0, value0: t);
            public static implicit operator Grid(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridArea : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private GridArea(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator GridArea(PropertySkip t) => new(0, value0: t);
            public static implicit operator GridArea(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridAutoColumns : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private GridAutoColumns(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator GridAutoColumns(PropertySkip t) => new(0, value0: t);
            public static implicit operator GridAutoColumns(string t) => new(1, value1: t);
            public static implicit operator GridAutoColumns(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridAutoFlow : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private GridAutoFlow(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator GridAutoFlow(PropertySkip t) => new(0, value0: t);
            public static implicit operator GridAutoFlow(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridAutoRows : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private GridAutoRows(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator GridAutoRows(PropertySkip t) => new(0, value0: t);
            public static implicit operator GridAutoRows(string t) => new(1, value1: t);
            public static implicit operator GridAutoRows(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridColumn : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private GridColumn(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator GridColumn(PropertySkip t) => new(0, value0: t);
            public static implicit operator GridColumn(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridColumnEnd : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private GridColumnEnd(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator GridColumnEnd(PropertySkip t) => new(0, value0: t);
            public static implicit operator GridColumnEnd(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridColumnGap : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private GridColumnGap(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator GridColumnGap(PropertySkip t) => new(0, value0: t);
            public static implicit operator GridColumnGap(string t) => new(1, value1: t);
            public static implicit operator GridColumnGap(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridColumnStart : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private GridColumnStart(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator GridColumnStart(PropertySkip t) => new(0, value0: t);
            public static implicit operator GridColumnStart(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridGap : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private GridGap(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator GridGap(PropertySkip t) => new(0, value0: t);
            public static implicit operator GridGap(string t) => new(1, value1: t);
            public static implicit operator GridGap(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridRow : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private GridRow(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator GridRow(PropertySkip t) => new(0, value0: t);
            public static implicit operator GridRow(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridRowEnd : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private GridRowEnd(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator GridRowEnd(PropertySkip t) => new(0, value0: t);
            public static implicit operator GridRowEnd(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridRowGap : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private GridRowGap(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator GridRowGap(PropertySkip t) => new(0, value0: t);
            public static implicit operator GridRowGap(string t) => new(1, value1: t);
            public static implicit operator GridRowGap(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridRowStart : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private GridRowStart(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator GridRowStart(PropertySkip t) => new(0, value0: t);
            public static implicit operator GridRowStart(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridTemplate : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private GridTemplate(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator GridTemplate(PropertySkip t) => new(0, value0: t);
            public static implicit operator GridTemplate(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridTemplateAreas : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private GridTemplateAreas(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator GridTemplateAreas(PropertySkip t) => new(0, value0: t);
            public static implicit operator GridTemplateAreas(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridTemplateColumns : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private GridTemplateColumns(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator GridTemplateColumns(PropertySkip t) => new(0, value0: t);
            public static implicit operator GridTemplateColumns(string t) => new(1, value1: t);
            public static implicit operator GridTemplateColumns(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridTemplateRows : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private GridTemplateRows(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator GridTemplateRows(PropertySkip t) => new(0, value0: t);
            public static implicit operator GridTemplateRows(string t) => new(1, value1: t);
            public static implicit operator GridTemplateRows(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct HangingPunctuation : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private HangingPunctuation(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator HangingPunctuation(PropertySkip t) => new(0, value0: t);
            public static implicit operator HangingPunctuation(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Height : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private Height(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Height(PropertySkip t) => new(0, value0: t);
            public static implicit operator Height(string t) => new(1, value1: t);
            public static implicit operator Height(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct HyphenateCharacter : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private HyphenateCharacter(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator HyphenateCharacter(PropertySkip t) => new(0, value0: t);
            public static implicit operator HyphenateCharacter(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct HyphenateLimitChars : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private HyphenateLimitChars(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator HyphenateLimitChars(PropertySkip t) => new(0, value0: t);
            public static implicit operator HyphenateLimitChars(string t) => new(1, value1: t);
            public static implicit operator HyphenateLimitChars(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Hyphens : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Hyphens(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Hyphens(PropertySkip t) => new(0, value0: t);
            public static implicit operator Hyphens(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ImageOrientation : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ImageOrientation(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ImageOrientation(PropertySkip t) => new(0, value0: t);
            public static implicit operator ImageOrientation(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ImageRendering : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ImageRendering(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ImageRendering(PropertySkip t) => new(0, value0: t);
            public static implicit operator ImageRendering(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ImageResolution : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ImageResolution(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ImageResolution(PropertySkip t) => new(0, value0: t);
            public static implicit operator ImageResolution(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ImeMode : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ImeMode(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ImeMode(PropertySkip t) => new(0, value0: t);
            public static implicit operator ImeMode(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InitialLetter : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private InitialLetter(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator InitialLetter(PropertySkip t) => new(0, value0: t);
            public static implicit operator InitialLetter(string t) => new(1, value1: t);
            public static implicit operator InitialLetter(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InlineSize : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private InlineSize(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator InlineSize(PropertySkip t) => new(0, value0: t);
            public static implicit operator InlineSize(string t) => new(1, value1: t);
            public static implicit operator InlineSize(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InputSecurity : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private InputSecurity(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator InputSecurity(PropertySkip t) => new(0, value0: t);
            public static implicit operator InputSecurity(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Inset : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private Inset(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Inset(PropertySkip t) => new(0, value0: t);
            public static implicit operator Inset(string t) => new(1, value1: t);
            public static implicit operator Inset(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InsetBlock : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private InsetBlock(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator InsetBlock(PropertySkip t) => new(0, value0: t);
            public static implicit operator InsetBlock(string t) => new(1, value1: t);
            public static implicit operator InsetBlock(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InsetBlockEnd : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private InsetBlockEnd(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator InsetBlockEnd(PropertySkip t) => new(0, value0: t);
            public static implicit operator InsetBlockEnd(string t) => new(1, value1: t);
            public static implicit operator InsetBlockEnd(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InsetBlockStart : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private InsetBlockStart(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator InsetBlockStart(PropertySkip t) => new(0, value0: t);
            public static implicit operator InsetBlockStart(string t) => new(1, value1: t);
            public static implicit operator InsetBlockStart(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InsetInline : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private InsetInline(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator InsetInline(PropertySkip t) => new(0, value0: t);
            public static implicit operator InsetInline(string t) => new(1, value1: t);
            public static implicit operator InsetInline(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InsetInlineEnd : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private InsetInlineEnd(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator InsetInlineEnd(PropertySkip t) => new(0, value0: t);
            public static implicit operator InsetInlineEnd(string t) => new(1, value1: t);
            public static implicit operator InsetInlineEnd(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InsetInlineStart : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private InsetInlineStart(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator InsetInlineStart(PropertySkip t) => new(0, value0: t);
            public static implicit operator InsetInlineStart(string t) => new(1, value1: t);
            public static implicit operator InsetInlineStart(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Isolation : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Isolation(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Isolation(PropertySkip t) => new(0, value0: t);
            public static implicit operator Isolation(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct JustifyContent : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private JustifyContent(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator JustifyContent(PropertySkip t) => new(0, value0: t);
            public static implicit operator JustifyContent(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct JustifyItems : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private JustifyItems(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator JustifyItems(PropertySkip t) => new(0, value0: t);
            public static implicit operator JustifyItems(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct JustifySelf : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private JustifySelf(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator JustifySelf(PropertySkip t) => new(0, value0: t);
            public static implicit operator JustifySelf(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct JustifyTracks : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private JustifyTracks(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator JustifyTracks(PropertySkip t) => new(0, value0: t);
            public static implicit operator JustifyTracks(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Left : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private Left(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Left(PropertySkip t) => new(0, value0: t);
            public static implicit operator Left(string t) => new(1, value1: t);
            public static implicit operator Left(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct LetterSpacing : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private LetterSpacing(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator LetterSpacing(PropertySkip t) => new(0, value0: t);
            public static implicit operator LetterSpacing(string t) => new(1, value1: t);
            public static implicit operator LetterSpacing(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct LineBreak : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private LineBreak(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator LineBreak(PropertySkip t) => new(0, value0: t);
            public static implicit operator LineBreak(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct LineClamp : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private LineClamp(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator LineClamp(PropertySkip t) => new(0, value0: t);
            public static implicit operator LineClamp(string t) => new(1, value1: t);
            public static implicit operator LineClamp(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct LineHeight : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly double _value2;

            private LineHeight(int index, PropertySkip value0 = default, string value1 = default, double value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator LineHeight(PropertySkip t) => new(0, value0: t);
            public static implicit operator LineHeight(string t) => new(1, value1: t);
            public static implicit operator LineHeight(double t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct LineHeightStep : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private LineHeightStep(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator LineHeightStep(PropertySkip t) => new(0, value0: t);
            public static implicit operator LineHeightStep(string t) => new(1, value1: t);
            public static implicit operator LineHeightStep(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ListStyle : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ListStyle(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ListStyle(PropertySkip t) => new(0, value0: t);
            public static implicit operator ListStyle(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ListStyleImage : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ListStyleImage(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ListStyleImage(PropertySkip t) => new(0, value0: t);
            public static implicit operator ListStyleImage(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ListStylePosition : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ListStylePosition(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ListStylePosition(PropertySkip t) => new(0, value0: t);
            public static implicit operator ListStylePosition(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ListStyleType : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ListStyleType(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ListStyleType(PropertySkip t) => new(0, value0: t);
            public static implicit operator ListStyleType(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Margin : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private Margin(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Margin(PropertySkip t) => new(0, value0: t);
            public static implicit operator Margin(string t) => new(1, value1: t);
            public static implicit operator Margin(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginBlock : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MarginBlock(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MarginBlock(PropertySkip t) => new(0, value0: t);
            public static implicit operator MarginBlock(string t) => new(1, value1: t);
            public static implicit operator MarginBlock(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginBlockEnd : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MarginBlockEnd(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MarginBlockEnd(PropertySkip t) => new(0, value0: t);
            public static implicit operator MarginBlockEnd(string t) => new(1, value1: t);
            public static implicit operator MarginBlockEnd(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginBlockStart : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MarginBlockStart(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MarginBlockStart(PropertySkip t) => new(0, value0: t);
            public static implicit operator MarginBlockStart(string t) => new(1, value1: t);
            public static implicit operator MarginBlockStart(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginBottom : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MarginBottom(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MarginBottom(PropertySkip t) => new(0, value0: t);
            public static implicit operator MarginBottom(string t) => new(1, value1: t);
            public static implicit operator MarginBottom(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginInline : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MarginInline(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MarginInline(PropertySkip t) => new(0, value0: t);
            public static implicit operator MarginInline(string t) => new(1, value1: t);
            public static implicit operator MarginInline(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginInlineEnd : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MarginInlineEnd(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MarginInlineEnd(PropertySkip t) => new(0, value0: t);
            public static implicit operator MarginInlineEnd(string t) => new(1, value1: t);
            public static implicit operator MarginInlineEnd(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginInlineStart : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MarginInlineStart(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MarginInlineStart(PropertySkip t) => new(0, value0: t);
            public static implicit operator MarginInlineStart(string t) => new(1, value1: t);
            public static implicit operator MarginInlineStart(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginLeft : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MarginLeft(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MarginLeft(PropertySkip t) => new(0, value0: t);
            public static implicit operator MarginLeft(string t) => new(1, value1: t);
            public static implicit operator MarginLeft(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginRight : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MarginRight(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MarginRight(PropertySkip t) => new(0, value0: t);
            public static implicit operator MarginRight(string t) => new(1, value1: t);
            public static implicit operator MarginRight(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginTop : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MarginTop(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MarginTop(PropertySkip t) => new(0, value0: t);
            public static implicit operator MarginTop(string t) => new(1, value1: t);
            public static implicit operator MarginTop(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginTrim : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MarginTrim(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MarginTrim(PropertySkip t) => new(0, value0: t);
            public static implicit operator MarginTrim(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Mask : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private Mask(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Mask(PropertySkip t) => new(0, value0: t);
            public static implicit operator Mask(string t) => new(1, value1: t);
            public static implicit operator Mask(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskBorder : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MaskBorder(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MaskBorder(PropertySkip t) => new(0, value0: t);
            public static implicit operator MaskBorder(string t) => new(1, value1: t);
            public static implicit operator MaskBorder(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskBorderMode : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MaskBorderMode(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MaskBorderMode(PropertySkip t) => new(0, value0: t);
            public static implicit operator MaskBorderMode(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskBorderOutset : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MaskBorderOutset(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MaskBorderOutset(PropertySkip t) => new(0, value0: t);
            public static implicit operator MaskBorderOutset(string t) => new(1, value1: t);
            public static implicit operator MaskBorderOutset(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskBorderRepeat : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MaskBorderRepeat(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MaskBorderRepeat(PropertySkip t) => new(0, value0: t);
            public static implicit operator MaskBorderRepeat(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskBorderSlice : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MaskBorderSlice(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MaskBorderSlice(PropertySkip t) => new(0, value0: t);
            public static implicit operator MaskBorderSlice(string t) => new(1, value1: t);
            public static implicit operator MaskBorderSlice(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskBorderSource : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MaskBorderSource(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MaskBorderSource(PropertySkip t) => new(0, value0: t);
            public static implicit operator MaskBorderSource(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskBorderWidth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MaskBorderWidth(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MaskBorderWidth(PropertySkip t) => new(0, value0: t);
            public static implicit operator MaskBorderWidth(string t) => new(1, value1: t);
            public static implicit operator MaskBorderWidth(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskClip : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MaskClip(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MaskClip(PropertySkip t) => new(0, value0: t);
            public static implicit operator MaskClip(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskComposite : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MaskComposite(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MaskComposite(PropertySkip t) => new(0, value0: t);
            public static implicit operator MaskComposite(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskImage : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MaskImage(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MaskImage(PropertySkip t) => new(0, value0: t);
            public static implicit operator MaskImage(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskMode : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MaskMode(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MaskMode(PropertySkip t) => new(0, value0: t);
            public static implicit operator MaskMode(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskOrigin : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MaskOrigin(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MaskOrigin(PropertySkip t) => new(0, value0: t);
            public static implicit operator MaskOrigin(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskPosition : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MaskPosition(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MaskPosition(PropertySkip t) => new(0, value0: t);
            public static implicit operator MaskPosition(string t) => new(1, value1: t);
            public static implicit operator MaskPosition(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskRepeat : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MaskRepeat(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MaskRepeat(PropertySkip t) => new(0, value0: t);
            public static implicit operator MaskRepeat(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskSize : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MaskSize(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MaskSize(PropertySkip t) => new(0, value0: t);
            public static implicit operator MaskSize(string t) => new(1, value1: t);
            public static implicit operator MaskSize(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskType : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MaskType(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MaskType(PropertySkip t) => new(0, value0: t);
            public static implicit operator MaskType(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MathDepth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MathDepth(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MathDepth(PropertySkip t) => new(0, value0: t);
            public static implicit operator MathDepth(string t) => new(1, value1: t);
            public static implicit operator MathDepth(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MathShift : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MathShift(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MathShift(PropertySkip t) => new(0, value0: t);
            public static implicit operator MathShift(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MathStyle : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MathStyle(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MathStyle(PropertySkip t) => new(0, value0: t);
            public static implicit operator MathStyle(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaxBlockSize : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MaxBlockSize(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MaxBlockSize(PropertySkip t) => new(0, value0: t);
            public static implicit operator MaxBlockSize(string t) => new(1, value1: t);
            public static implicit operator MaxBlockSize(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaxHeight : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MaxHeight(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MaxHeight(PropertySkip t) => new(0, value0: t);
            public static implicit operator MaxHeight(string t) => new(1, value1: t);
            public static implicit operator MaxHeight(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaxInlineSize : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MaxInlineSize(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MaxInlineSize(PropertySkip t) => new(0, value0: t);
            public static implicit operator MaxInlineSize(string t) => new(1, value1: t);
            public static implicit operator MaxInlineSize(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaxLines : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MaxLines(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MaxLines(PropertySkip t) => new(0, value0: t);
            public static implicit operator MaxLines(string t) => new(1, value1: t);
            public static implicit operator MaxLines(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaxWidth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MaxWidth(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MaxWidth(PropertySkip t) => new(0, value0: t);
            public static implicit operator MaxWidth(string t) => new(1, value1: t);
            public static implicit operator MaxWidth(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MinBlockSize : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MinBlockSize(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MinBlockSize(PropertySkip t) => new(0, value0: t);
            public static implicit operator MinBlockSize(string t) => new(1, value1: t);
            public static implicit operator MinBlockSize(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MinHeight : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MinHeight(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MinHeight(PropertySkip t) => new(0, value0: t);
            public static implicit operator MinHeight(string t) => new(1, value1: t);
            public static implicit operator MinHeight(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MinInlineSize : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MinInlineSize(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MinInlineSize(PropertySkip t) => new(0, value0: t);
            public static implicit operator MinInlineSize(string t) => new(1, value1: t);
            public static implicit operator MinInlineSize(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MinWidth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MinWidth(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MinWidth(PropertySkip t) => new(0, value0: t);
            public static implicit operator MinWidth(string t) => new(1, value1: t);
            public static implicit operator MinWidth(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MixBlendMode : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MixBlendMode(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MixBlendMode(PropertySkip t) => new(0, value0: t);
            public static implicit operator MixBlendMode(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Offset : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private Offset(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Offset(PropertySkip t) => new(0, value0: t);
            public static implicit operator Offset(string t) => new(1, value1: t);
            public static implicit operator Offset(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OffsetDistance : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private OffsetDistance(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator OffsetDistance(PropertySkip t) => new(0, value0: t);
            public static implicit operator OffsetDistance(string t) => new(1, value1: t);
            public static implicit operator OffsetDistance(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OffsetPath : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private OffsetPath(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator OffsetPath(PropertySkip t) => new(0, value0: t);
            public static implicit operator OffsetPath(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OffsetRotate : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private OffsetRotate(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator OffsetRotate(PropertySkip t) => new(0, value0: t);
            public static implicit operator OffsetRotate(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ObjectFit : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ObjectFit(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ObjectFit(PropertySkip t) => new(0, value0: t);
            public static implicit operator ObjectFit(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ObjectPosition : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ObjectPosition(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ObjectPosition(PropertySkip t) => new(0, value0: t);
            public static implicit operator ObjectPosition(string t) => new(1, value1: t);
            public static implicit operator ObjectPosition(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OffsetAnchor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private OffsetAnchor(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator OffsetAnchor(PropertySkip t) => new(0, value0: t);
            public static implicit operator OffsetAnchor(string t) => new(1, value1: t);
            public static implicit operator OffsetAnchor(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OffsetPosition : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private OffsetPosition(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator OffsetPosition(PropertySkip t) => new(0, value0: t);
            public static implicit operator OffsetPosition(string t) => new(1, value1: t);
            public static implicit operator OffsetPosition(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Opacity : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly double _value2;

            private Opacity(int index, PropertySkip value0 = default, string value1 = default, double value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Opacity(PropertySkip t) => new(0, value0: t);
            public static implicit operator Opacity(string t) => new(1, value1: t);
            public static implicit operator Opacity(double t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Order : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private Order(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Order(PropertySkip t) => new(0, value0: t);
            public static implicit operator Order(string t) => new(1, value1: t);
            public static implicit operator Order(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Orphans : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private Orphans(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Orphans(PropertySkip t) => new(0, value0: t);
            public static implicit operator Orphans(string t) => new(1, value1: t);
            public static implicit operator Orphans(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Outline : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private Outline(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Outline(PropertySkip t) => new(0, value0: t);
            public static implicit operator Outline(string t) => new(1, value1: t);
            public static implicit operator Outline(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OutlineColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private OutlineColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator OutlineColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator OutlineColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OutlineOffset : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private OutlineOffset(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator OutlineOffset(PropertySkip t) => new(0, value0: t);
            public static implicit operator OutlineOffset(string t) => new(1, value1: t);
            public static implicit operator OutlineOffset(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OutlineStyle : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private OutlineStyle(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator OutlineStyle(PropertySkip t) => new(0, value0: t);
            public static implicit operator OutlineStyle(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OutlineWidth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private OutlineWidth(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator OutlineWidth(PropertySkip t) => new(0, value0: t);
            public static implicit operator OutlineWidth(string t) => new(1, value1: t);
            public static implicit operator OutlineWidth(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Overflow : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Overflow(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Overflow(PropertySkip t) => new(0, value0: t);
            public static implicit operator Overflow(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverflowAnchor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private OverflowAnchor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator OverflowAnchor(PropertySkip t) => new(0, value0: t);
            public static implicit operator OverflowAnchor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverflowBlock : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private OverflowBlock(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator OverflowBlock(PropertySkip t) => new(0, value0: t);
            public static implicit operator OverflowBlock(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverflowClipBox : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private OverflowClipBox(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator OverflowClipBox(PropertySkip t) => new(0, value0: t);
            public static implicit operator OverflowClipBox(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverflowClipMargin : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private OverflowClipMargin(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator OverflowClipMargin(PropertySkip t) => new(0, value0: t);
            public static implicit operator OverflowClipMargin(string t) => new(1, value1: t);
            public static implicit operator OverflowClipMargin(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverflowInline : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private OverflowInline(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator OverflowInline(PropertySkip t) => new(0, value0: t);
            public static implicit operator OverflowInline(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverflowWrap : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private OverflowWrap(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator OverflowWrap(PropertySkip t) => new(0, value0: t);
            public static implicit operator OverflowWrap(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverflowX : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private OverflowX(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator OverflowX(PropertySkip t) => new(0, value0: t);
            public static implicit operator OverflowX(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverflowY : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private OverflowY(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator OverflowY(PropertySkip t) => new(0, value0: t);
            public static implicit operator OverflowY(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverscrollBehavior : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private OverscrollBehavior(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator OverscrollBehavior(PropertySkip t) => new(0, value0: t);
            public static implicit operator OverscrollBehavior(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverscrollBehaviorBlock : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private OverscrollBehaviorBlock(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator OverscrollBehaviorBlock(PropertySkip t) => new(0, value0: t);
            public static implicit operator OverscrollBehaviorBlock(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverscrollBehaviorInline : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private OverscrollBehaviorInline(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator OverscrollBehaviorInline(PropertySkip t) => new(0, value0: t);
            public static implicit operator OverscrollBehaviorInline(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverscrollBehaviorX : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private OverscrollBehaviorX(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator OverscrollBehaviorX(PropertySkip t) => new(0, value0: t);
            public static implicit operator OverscrollBehaviorX(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverscrollBehaviorY : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private OverscrollBehaviorY(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator OverscrollBehaviorY(PropertySkip t) => new(0, value0: t);
            public static implicit operator OverscrollBehaviorY(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Padding : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private Padding(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Padding(PropertySkip t) => new(0, value0: t);
            public static implicit operator Padding(string t) => new(1, value1: t);
            public static implicit operator Padding(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingBlock : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private PaddingBlock(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator PaddingBlock(PropertySkip t) => new(0, value0: t);
            public static implicit operator PaddingBlock(string t) => new(1, value1: t);
            public static implicit operator PaddingBlock(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingBlockEnd : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private PaddingBlockEnd(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator PaddingBlockEnd(PropertySkip t) => new(0, value0: t);
            public static implicit operator PaddingBlockEnd(string t) => new(1, value1: t);
            public static implicit operator PaddingBlockEnd(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingBlockStart : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private PaddingBlockStart(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator PaddingBlockStart(PropertySkip t) => new(0, value0: t);
            public static implicit operator PaddingBlockStart(string t) => new(1, value1: t);
            public static implicit operator PaddingBlockStart(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingBottom : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private PaddingBottom(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator PaddingBottom(PropertySkip t) => new(0, value0: t);
            public static implicit operator PaddingBottom(string t) => new(1, value1: t);
            public static implicit operator PaddingBottom(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingInline : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private PaddingInline(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator PaddingInline(PropertySkip t) => new(0, value0: t);
            public static implicit operator PaddingInline(string t) => new(1, value1: t);
            public static implicit operator PaddingInline(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingInlineEnd : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private PaddingInlineEnd(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator PaddingInlineEnd(PropertySkip t) => new(0, value0: t);
            public static implicit operator PaddingInlineEnd(string t) => new(1, value1: t);
            public static implicit operator PaddingInlineEnd(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingInlineStart : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private PaddingInlineStart(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator PaddingInlineStart(PropertySkip t) => new(0, value0: t);
            public static implicit operator PaddingInlineStart(string t) => new(1, value1: t);
            public static implicit operator PaddingInlineStart(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingLeft : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private PaddingLeft(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator PaddingLeft(PropertySkip t) => new(0, value0: t);
            public static implicit operator PaddingLeft(string t) => new(1, value1: t);
            public static implicit operator PaddingLeft(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingRight : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private PaddingRight(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator PaddingRight(PropertySkip t) => new(0, value0: t);
            public static implicit operator PaddingRight(string t) => new(1, value1: t);
            public static implicit operator PaddingRight(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingTop : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private PaddingTop(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator PaddingTop(PropertySkip t) => new(0, value0: t);
            public static implicit operator PaddingTop(string t) => new(1, value1: t);
            public static implicit operator PaddingTop(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Page : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Page(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Page(PropertySkip t) => new(0, value0: t);
            public static implicit operator Page(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PageBreakAfter : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private PageBreakAfter(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator PageBreakAfter(PropertySkip t) => new(0, value0: t);
            public static implicit operator PageBreakAfter(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PageBreakBefore : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private PageBreakBefore(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator PageBreakBefore(PropertySkip t) => new(0, value0: t);
            public static implicit operator PageBreakBefore(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PageBreakInside : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private PageBreakInside(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator PageBreakInside(PropertySkip t) => new(0, value0: t);
            public static implicit operator PageBreakInside(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaintOrder : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private PaintOrder(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator PaintOrder(PropertySkip t) => new(0, value0: t);
            public static implicit operator PaintOrder(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Perspective : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private Perspective(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Perspective(PropertySkip t) => new(0, value0: t);
            public static implicit operator Perspective(string t) => new(1, value1: t);
            public static implicit operator Perspective(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PerspectiveOrigin : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private PerspectiveOrigin(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator PerspectiveOrigin(PropertySkip t) => new(0, value0: t);
            public static implicit operator PerspectiveOrigin(string t) => new(1, value1: t);
            public static implicit operator PerspectiveOrigin(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PlaceContent : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private PlaceContent(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator PlaceContent(PropertySkip t) => new(0, value0: t);
            public static implicit operator PlaceContent(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PlaceItems : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private PlaceItems(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator PlaceItems(PropertySkip t) => new(0, value0: t);
            public static implicit operator PlaceItems(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PlaceSelf : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private PlaceSelf(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator PlaceSelf(PropertySkip t) => new(0, value0: t);
            public static implicit operator PlaceSelf(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PointerEvents : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private PointerEvents(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator PointerEvents(PropertySkip t) => new(0, value0: t);
            public static implicit operator PointerEvents(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Position : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Position(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Position(PropertySkip t) => new(0, value0: t);
            public static implicit operator Position(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Quotes : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Quotes(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Quotes(PropertySkip t) => new(0, value0: t);
            public static implicit operator Quotes(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Resize : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Resize(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Resize(PropertySkip t) => new(0, value0: t);
            public static implicit operator Resize(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Right : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private Right(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Right(PropertySkip t) => new(0, value0: t);
            public static implicit operator Right(string t) => new(1, value1: t);
            public static implicit operator Right(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Rotate : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Rotate(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Rotate(PropertySkip t) => new(0, value0: t);
            public static implicit operator Rotate(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct RowGap : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private RowGap(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator RowGap(PropertySkip t) => new(0, value0: t);
            public static implicit operator RowGap(string t) => new(1, value1: t);
            public static implicit operator RowGap(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct RubyAlign : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private RubyAlign(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator RubyAlign(PropertySkip t) => new(0, value0: t);
            public static implicit operator RubyAlign(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct RubyMerge : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private RubyMerge(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator RubyMerge(PropertySkip t) => new(0, value0: t);
            public static implicit operator RubyMerge(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct RubyPosition : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private RubyPosition(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator RubyPosition(PropertySkip t) => new(0, value0: t);
            public static implicit operator RubyPosition(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Scale : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private Scale(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Scale(PropertySkip t) => new(0, value0: t);
            public static implicit operator Scale(string t) => new(1, value1: t);
            public static implicit operator Scale(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollBehavior : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ScrollBehavior(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollBehavior(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollBehavior(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMargin : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ScrollMargin(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollMargin(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollMargin(string t) => new(1, value1: t);
            public static implicit operator ScrollMargin(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginBlock : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ScrollMarginBlock(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollMarginBlock(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollMarginBlock(string t) => new(1, value1: t);
            public static implicit operator ScrollMarginBlock(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginBlockEnd : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ScrollMarginBlockEnd(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollMarginBlockEnd(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollMarginBlockEnd(string t) => new(1, value1: t);
            public static implicit operator ScrollMarginBlockEnd(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginBlockStart : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ScrollMarginBlockStart(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollMarginBlockStart(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollMarginBlockStart(string t) => new(1, value1: t);
            public static implicit operator ScrollMarginBlockStart(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginBottom : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ScrollMarginBottom(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollMarginBottom(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollMarginBottom(string t) => new(1, value1: t);
            public static implicit operator ScrollMarginBottom(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginInline : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ScrollMarginInline(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollMarginInline(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollMarginInline(string t) => new(1, value1: t);
            public static implicit operator ScrollMarginInline(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginInlineEnd : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ScrollMarginInlineEnd(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollMarginInlineEnd(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollMarginInlineEnd(string t) => new(1, value1: t);
            public static implicit operator ScrollMarginInlineEnd(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginInlineStart : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ScrollMarginInlineStart(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollMarginInlineStart(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollMarginInlineStart(string t) => new(1, value1: t);
            public static implicit operator ScrollMarginInlineStart(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginLeft : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ScrollMarginLeft(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollMarginLeft(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollMarginLeft(string t) => new(1, value1: t);
            public static implicit operator ScrollMarginLeft(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginRight : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ScrollMarginRight(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollMarginRight(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollMarginRight(string t) => new(1, value1: t);
            public static implicit operator ScrollMarginRight(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginTop : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ScrollMarginTop(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollMarginTop(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollMarginTop(string t) => new(1, value1: t);
            public static implicit operator ScrollMarginTop(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPadding : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ScrollPadding(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollPadding(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollPadding(string t) => new(1, value1: t);
            public static implicit operator ScrollPadding(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingBlock : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ScrollPaddingBlock(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollPaddingBlock(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollPaddingBlock(string t) => new(1, value1: t);
            public static implicit operator ScrollPaddingBlock(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingBlockEnd : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ScrollPaddingBlockEnd(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollPaddingBlockEnd(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollPaddingBlockEnd(string t) => new(1, value1: t);
            public static implicit operator ScrollPaddingBlockEnd(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingBlockStart : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ScrollPaddingBlockStart(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollPaddingBlockStart(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollPaddingBlockStart(string t) => new(1, value1: t);
            public static implicit operator ScrollPaddingBlockStart(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingBottom : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ScrollPaddingBottom(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollPaddingBottom(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollPaddingBottom(string t) => new(1, value1: t);
            public static implicit operator ScrollPaddingBottom(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingInline : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ScrollPaddingInline(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollPaddingInline(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollPaddingInline(string t) => new(1, value1: t);
            public static implicit operator ScrollPaddingInline(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingInlineEnd : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ScrollPaddingInlineEnd(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollPaddingInlineEnd(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollPaddingInlineEnd(string t) => new(1, value1: t);
            public static implicit operator ScrollPaddingInlineEnd(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingInlineStart : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ScrollPaddingInlineStart(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollPaddingInlineStart(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollPaddingInlineStart(string t) => new(1, value1: t);
            public static implicit operator ScrollPaddingInlineStart(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingLeft : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ScrollPaddingLeft(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollPaddingLeft(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollPaddingLeft(string t) => new(1, value1: t);
            public static implicit operator ScrollPaddingLeft(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingRight : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ScrollPaddingRight(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollPaddingRight(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollPaddingRight(string t) => new(1, value1: t);
            public static implicit operator ScrollPaddingRight(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingTop : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ScrollPaddingTop(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollPaddingTop(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollPaddingTop(string t) => new(1, value1: t);
            public static implicit operator ScrollPaddingTop(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapAlign : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ScrollSnapAlign(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollSnapAlign(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollSnapAlign(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapCoordinate : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ScrollSnapCoordinate(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollSnapCoordinate(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollSnapCoordinate(string t) => new(1, value1: t);
            public static implicit operator ScrollSnapCoordinate(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapDestination : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ScrollSnapDestination(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollSnapDestination(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollSnapDestination(string t) => new(1, value1: t);
            public static implicit operator ScrollSnapDestination(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapPointsX : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ScrollSnapPointsX(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollSnapPointsX(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollSnapPointsX(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapPointsY : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ScrollSnapPointsY(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollSnapPointsY(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollSnapPointsY(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapStop : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ScrollSnapStop(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollSnapStop(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollSnapStop(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapType : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ScrollSnapType(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollSnapType(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollSnapType(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapTypeX : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ScrollSnapTypeX(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollSnapTypeX(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollSnapTypeX(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapTypeY : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ScrollSnapTypeY(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollSnapTypeY(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollSnapTypeY(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollTimeline : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ScrollTimeline(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollTimeline(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollTimeline(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollTimelineAxis : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ScrollTimelineAxis(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollTimelineAxis(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollTimelineAxis(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollTimelineName : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ScrollTimelineName(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollTimelineName(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollTimelineName(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollbarColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ScrollbarColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollbarColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollbarColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollbarGutter : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ScrollbarGutter(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollbarGutter(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollbarGutter(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollbarWidth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ScrollbarWidth(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ScrollbarWidth(PropertySkip t) => new(0, value0: t);
            public static implicit operator ScrollbarWidth(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ShapeImageThreshold : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ShapeImageThreshold(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ShapeImageThreshold(PropertySkip t) => new(0, value0: t);
            public static implicit operator ShapeImageThreshold(string t) => new(1, value1: t);
            public static implicit operator ShapeImageThreshold(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ShapeMargin : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ShapeMargin(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ShapeMargin(PropertySkip t) => new(0, value0: t);
            public static implicit operator ShapeMargin(string t) => new(1, value1: t);
            public static implicit operator ShapeMargin(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ShapeOutside : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ShapeOutside(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ShapeOutside(PropertySkip t) => new(0, value0: t);
            public static implicit operator ShapeOutside(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TabSize : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private TabSize(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TabSize(PropertySkip t) => new(0, value0: t);
            public static implicit operator TabSize(string t) => new(1, value1: t);
            public static implicit operator TabSize(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TableLayout : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TableLayout(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TableLayout(PropertySkip t) => new(0, value0: t);
            public static implicit operator TableLayout(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextAlign : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TextAlign(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TextAlign(PropertySkip t) => new(0, value0: t);
            public static implicit operator TextAlign(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextAlignLast : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TextAlignLast(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TextAlignLast(PropertySkip t) => new(0, value0: t);
            public static implicit operator TextAlignLast(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextCombineUpright : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TextCombineUpright(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TextCombineUpright(PropertySkip t) => new(0, value0: t);
            public static implicit operator TextCombineUpright(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextDecoration : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private TextDecoration(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextDecoration(PropertySkip t) => new(0, value0: t);
            public static implicit operator TextDecoration(string t) => new(1, value1: t);
            public static implicit operator TextDecoration(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextDecorationColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TextDecorationColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TextDecorationColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator TextDecorationColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextDecorationLine : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TextDecorationLine(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TextDecorationLine(PropertySkip t) => new(0, value0: t);
            public static implicit operator TextDecorationLine(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextDecorationSkip : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TextDecorationSkip(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TextDecorationSkip(PropertySkip t) => new(0, value0: t);
            public static implicit operator TextDecorationSkip(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextDecorationSkipInk : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TextDecorationSkipInk(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TextDecorationSkipInk(PropertySkip t) => new(0, value0: t);
            public static implicit operator TextDecorationSkipInk(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextDecorationStyle : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TextDecorationStyle(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TextDecorationStyle(PropertySkip t) => new(0, value0: t);
            public static implicit operator TextDecorationStyle(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextDecorationThickness : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private TextDecorationThickness(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextDecorationThickness(PropertySkip t) => new(0, value0: t);
            public static implicit operator TextDecorationThickness(string t) => new(1, value1: t);
            public static implicit operator TextDecorationThickness(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextEmphasis : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TextEmphasis(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TextEmphasis(PropertySkip t) => new(0, value0: t);
            public static implicit operator TextEmphasis(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextEmphasisColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TextEmphasisColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TextEmphasisColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator TextEmphasisColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextEmphasisPosition : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TextEmphasisPosition(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TextEmphasisPosition(PropertySkip t) => new(0, value0: t);
            public static implicit operator TextEmphasisPosition(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextEmphasisStyle : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TextEmphasisStyle(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TextEmphasisStyle(PropertySkip t) => new(0, value0: t);
            public static implicit operator TextEmphasisStyle(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextIndent : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private TextIndent(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextIndent(PropertySkip t) => new(0, value0: t);
            public static implicit operator TextIndent(string t) => new(1, value1: t);
            public static implicit operator TextIndent(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextJustify : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TextJustify(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TextJustify(PropertySkip t) => new(0, value0: t);
            public static implicit operator TextJustify(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextOrientation : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TextOrientation(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TextOrientation(PropertySkip t) => new(0, value0: t);
            public static implicit operator TextOrientation(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextOverflow : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TextOverflow(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TextOverflow(PropertySkip t) => new(0, value0: t);
            public static implicit operator TextOverflow(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextRendering : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TextRendering(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TextRendering(PropertySkip t) => new(0, value0: t);
            public static implicit operator TextRendering(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextShadow : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TextShadow(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TextShadow(PropertySkip t) => new(0, value0: t);
            public static implicit operator TextShadow(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextSizeAdjust : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TextSizeAdjust(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TextSizeAdjust(PropertySkip t) => new(0, value0: t);
            public static implicit operator TextSizeAdjust(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextTransform : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TextTransform(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TextTransform(PropertySkip t) => new(0, value0: t);
            public static implicit operator TextTransform(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextUnderlineOffset : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private TextUnderlineOffset(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextUnderlineOffset(PropertySkip t) => new(0, value0: t);
            public static implicit operator TextUnderlineOffset(string t) => new(1, value1: t);
            public static implicit operator TextUnderlineOffset(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextUnderlinePosition : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TextUnderlinePosition(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TextUnderlinePosition(PropertySkip t) => new(0, value0: t);
            public static implicit operator TextUnderlinePosition(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Top : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private Top(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Top(PropertySkip t) => new(0, value0: t);
            public static implicit operator Top(string t) => new(1, value1: t);
            public static implicit operator Top(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TouchAction : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TouchAction(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TouchAction(PropertySkip t) => new(0, value0: t);
            public static implicit operator TouchAction(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Transform : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Transform(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Transform(PropertySkip t) => new(0, value0: t);
            public static implicit operator Transform(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TransformBox : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TransformBox(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TransformBox(PropertySkip t) => new(0, value0: t);
            public static implicit operator TransformBox(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TransformOrigin : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private TransformOrigin(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TransformOrigin(PropertySkip t) => new(0, value0: t);
            public static implicit operator TransformOrigin(string t) => new(1, value1: t);
            public static implicit operator TransformOrigin(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TransformStyle : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TransformStyle(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TransformStyle(PropertySkip t) => new(0, value0: t);
            public static implicit operator TransformStyle(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Transition : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Transition(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Transition(PropertySkip t) => new(0, value0: t);
            public static implicit operator Transition(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TransitionDelay : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TransitionDelay(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TransitionDelay(PropertySkip t) => new(0, value0: t);
            public static implicit operator TransitionDelay(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TransitionDuration : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TransitionDuration(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TransitionDuration(PropertySkip t) => new(0, value0: t);
            public static implicit operator TransitionDuration(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TransitionProperty : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TransitionProperty(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TransitionProperty(PropertySkip t) => new(0, value0: t);
            public static implicit operator TransitionProperty(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TransitionTimingFunction : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TransitionTimingFunction(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TransitionTimingFunction(PropertySkip t) => new(0, value0: t);
            public static implicit operator TransitionTimingFunction(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Translate : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private Translate(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Translate(PropertySkip t) => new(0, value0: t);
            public static implicit operator Translate(string t) => new(1, value1: t);
            public static implicit operator Translate(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct UnicodeBidi : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private UnicodeBidi(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator UnicodeBidi(PropertySkip t) => new(0, value0: t);
            public static implicit operator UnicodeBidi(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct UserSelect : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private UserSelect(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator UserSelect(PropertySkip t) => new(0, value0: t);
            public static implicit operator UserSelect(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct VerticalAlign : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private VerticalAlign(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator VerticalAlign(PropertySkip t) => new(0, value0: t);
            public static implicit operator VerticalAlign(string t) => new(1, value1: t);
            public static implicit operator VerticalAlign(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ViewTransitionName : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ViewTransitionName(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ViewTransitionName(PropertySkip t) => new(0, value0: t);
            public static implicit operator ViewTransitionName(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Visibility : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Visibility(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Visibility(PropertySkip t) => new(0, value0: t);
            public static implicit operator Visibility(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WhiteSpace : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private WhiteSpace(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WhiteSpace(PropertySkip t) => new(0, value0: t);
            public static implicit operator WhiteSpace(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Widows : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private Widows(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Widows(PropertySkip t) => new(0, value0: t);
            public static implicit operator Widows(string t) => new(1, value1: t);
            public static implicit operator Widows(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Width : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private Width(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Width(PropertySkip t) => new(0, value0: t);
            public static implicit operator Width(string t) => new(1, value1: t);
            public static implicit operator Width(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WillChange : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private WillChange(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WillChange(PropertySkip t) => new(0, value0: t);
            public static implicit operator WillChange(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WordBreak : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private WordBreak(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WordBreak(PropertySkip t) => new(0, value0: t);
            public static implicit operator WordBreak(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WordSpacing : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private WordSpacing(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WordSpacing(PropertySkip t) => new(0, value0: t);
            public static implicit operator WordSpacing(string t) => new(1, value1: t);
            public static implicit operator WordSpacing(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WordWrap : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private WordWrap(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WordWrap(PropertySkip t) => new(0, value0: t);
            public static implicit operator WordWrap(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WritingMode : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private WritingMode(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WritingMode(PropertySkip t) => new(0, value0: t);
            public static implicit operator WritingMode(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ZIndex : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private ZIndex(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ZIndex(PropertySkip t) => new(0, value0: t);
            public static implicit operator ZIndex(string t) => new(1, value1: t);
            public static implicit operator ZIndex(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Zoom : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private Zoom(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Zoom(PropertySkip t) => new(0, value0: t);
            public static implicit operator Zoom(string t) => new(1, value1: t);
            public static implicit operator Zoom(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozAppearance : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MozAppearance(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MozAppearance(PropertySkip t) => new(0, value0: t);
            public static implicit operator MozAppearance(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozBinding : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MozBinding(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MozBinding(PropertySkip t) => new(0, value0: t);
            public static implicit operator MozBinding(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozBorderBottomColors : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MozBorderBottomColors(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MozBorderBottomColors(PropertySkip t) => new(0, value0: t);
            public static implicit operator MozBorderBottomColors(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozBorderLeftColors : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MozBorderLeftColors(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MozBorderLeftColors(PropertySkip t) => new(0, value0: t);
            public static implicit operator MozBorderLeftColors(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozBorderRightColors : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MozBorderRightColors(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MozBorderRightColors(PropertySkip t) => new(0, value0: t);
            public static implicit operator MozBorderRightColors(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozBorderTopColors : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MozBorderTopColors(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MozBorderTopColors(PropertySkip t) => new(0, value0: t);
            public static implicit operator MozBorderTopColors(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozContextProperties : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MozContextProperties(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MozContextProperties(PropertySkip t) => new(0, value0: t);
            public static implicit operator MozContextProperties(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozFloatEdge : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MozFloatEdge(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MozFloatEdge(PropertySkip t) => new(0, value0: t);
            public static implicit operator MozFloatEdge(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozForceBrokenImageIcon : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MozForceBrokenImageIcon(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MozForceBrokenImageIcon(PropertySkip t) => new(0, value0: t);
            public static implicit operator MozForceBrokenImageIcon(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozImageRegion : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MozImageRegion(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MozImageRegion(PropertySkip t) => new(0, value0: t);
            public static implicit operator MozImageRegion(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozOrient : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MozOrient(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MozOrient(PropertySkip t) => new(0, value0: t);
            public static implicit operator MozOrient(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozOutlineRadius : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MozOutlineRadius(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MozOutlineRadius(PropertySkip t) => new(0, value0: t);
            public static implicit operator MozOutlineRadius(string t) => new(1, value1: t);
            public static implicit operator MozOutlineRadius(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozOutlineRadiusBottomleft : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MozOutlineRadiusBottomleft(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MozOutlineRadiusBottomleft(PropertySkip t) => new(0, value0: t);
            public static implicit operator MozOutlineRadiusBottomleft(string t) => new(1, value1: t);
            public static implicit operator MozOutlineRadiusBottomleft(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozOutlineRadiusBottomright : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MozOutlineRadiusBottomright(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MozOutlineRadiusBottomright(PropertySkip t) => new(0, value0: t);
            public static implicit operator MozOutlineRadiusBottomright(string t) => new(1, value1: t);
            public static implicit operator MozOutlineRadiusBottomright(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozOutlineRadiusTopleft : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MozOutlineRadiusTopleft(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MozOutlineRadiusTopleft(PropertySkip t) => new(0, value0: t);
            public static implicit operator MozOutlineRadiusTopleft(string t) => new(1, value1: t);
            public static implicit operator MozOutlineRadiusTopleft(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozOutlineRadiusTopright : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MozOutlineRadiusTopright(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MozOutlineRadiusTopright(PropertySkip t) => new(0, value0: t);
            public static implicit operator MozOutlineRadiusTopright(string t) => new(1, value1: t);
            public static implicit operator MozOutlineRadiusTopright(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozStackSizing : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MozStackSizing(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MozStackSizing(PropertySkip t) => new(0, value0: t);
            public static implicit operator MozStackSizing(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozTextBlink : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MozTextBlink(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MozTextBlink(PropertySkip t) => new(0, value0: t);
            public static implicit operator MozTextBlink(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozUserFocus : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MozUserFocus(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MozUserFocus(PropertySkip t) => new(0, value0: t);
            public static implicit operator MozUserFocus(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozUserInput : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MozUserInput(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MozUserInput(PropertySkip t) => new(0, value0: t);
            public static implicit operator MozUserInput(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozUserModify : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MozUserModify(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MozUserModify(PropertySkip t) => new(0, value0: t);
            public static implicit operator MozUserModify(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozWindowDragging : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MozWindowDragging(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MozWindowDragging(PropertySkip t) => new(0, value0: t);
            public static implicit operator MozWindowDragging(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozWindowShadow : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MozWindowShadow(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MozWindowShadow(PropertySkip t) => new(0, value0: t);
            public static implicit operator MozWindowShadow(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsAccelerator : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsAccelerator(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsAccelerator(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsAccelerator(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsBlockProgression : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsBlockProgression(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsBlockProgression(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsBlockProgression(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsContentZoomChaining : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsContentZoomChaining(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsContentZoomChaining(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsContentZoomChaining(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsContentZoomLimit : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsContentZoomLimit(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsContentZoomLimit(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsContentZoomLimit(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsContentZoomLimitMax : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsContentZoomLimitMax(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsContentZoomLimitMax(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsContentZoomLimitMax(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsContentZoomLimitMin : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsContentZoomLimitMin(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsContentZoomLimitMin(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsContentZoomLimitMin(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsContentZoomSnap : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsContentZoomSnap(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsContentZoomSnap(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsContentZoomSnap(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsContentZoomSnapPoints : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsContentZoomSnapPoints(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsContentZoomSnapPoints(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsContentZoomSnapPoints(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsContentZoomSnapType : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsContentZoomSnapType(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsContentZoomSnapType(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsContentZoomSnapType(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsContentZooming : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsContentZooming(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsContentZooming(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsContentZooming(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsFilter : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsFilter(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsFilter(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsFilter(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsFlowFrom : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsFlowFrom(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsFlowFrom(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsFlowFrom(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsFlowInto : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsFlowInto(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsFlowInto(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsFlowInto(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsGridColumns : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MsGridColumns(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsGridColumns(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsGridColumns(string t) => new(1, value1: t);
            public static implicit operator MsGridColumns(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsGridRows : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MsGridRows(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsGridRows(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsGridRows(string t) => new(1, value1: t);
            public static implicit operator MsGridRows(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsHighContrastAdjust : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsHighContrastAdjust(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsHighContrastAdjust(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsHighContrastAdjust(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsHyphenateLimitChars : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MsHyphenateLimitChars(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsHyphenateLimitChars(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsHyphenateLimitChars(string t) => new(1, value1: t);
            public static implicit operator MsHyphenateLimitChars(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsHyphenateLimitLines : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MsHyphenateLimitLines(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsHyphenateLimitLines(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsHyphenateLimitLines(string t) => new(1, value1: t);
            public static implicit operator MsHyphenateLimitLines(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsHyphenateLimitZone : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MsHyphenateLimitZone(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsHyphenateLimitZone(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsHyphenateLimitZone(string t) => new(1, value1: t);
            public static implicit operator MsHyphenateLimitZone(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsImeAlign : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsImeAlign(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsImeAlign(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsImeAlign(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsOverflowStyle : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsOverflowStyle(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsOverflowStyle(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsOverflowStyle(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollChaining : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsScrollChaining(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsScrollChaining(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsScrollChaining(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollLimit : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsScrollLimit(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsScrollLimit(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsScrollLimit(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollLimitXMax : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MsScrollLimitXMax(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsScrollLimitXMax(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsScrollLimitXMax(string t) => new(1, value1: t);
            public static implicit operator MsScrollLimitXMax(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollLimitXMin : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MsScrollLimitXMin(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsScrollLimitXMin(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsScrollLimitXMin(string t) => new(1, value1: t);
            public static implicit operator MsScrollLimitXMin(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollLimitYMax : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MsScrollLimitYMax(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsScrollLimitYMax(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsScrollLimitYMax(string t) => new(1, value1: t);
            public static implicit operator MsScrollLimitYMax(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollLimitYMin : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MsScrollLimitYMin(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsScrollLimitYMin(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsScrollLimitYMin(string t) => new(1, value1: t);
            public static implicit operator MsScrollLimitYMin(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollRails : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsScrollRails(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsScrollRails(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsScrollRails(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollSnapPointsX : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsScrollSnapPointsX(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsScrollSnapPointsX(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsScrollSnapPointsX(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollSnapPointsY : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsScrollSnapPointsY(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsScrollSnapPointsY(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsScrollSnapPointsY(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollSnapType : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsScrollSnapType(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsScrollSnapType(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsScrollSnapType(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollSnapX : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsScrollSnapX(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsScrollSnapX(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsScrollSnapX(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollSnapY : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsScrollSnapY(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsScrollSnapY(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsScrollSnapY(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollTranslation : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsScrollTranslation(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsScrollTranslation(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsScrollTranslation(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollbar3dlightColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsScrollbar3dlightColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsScrollbar3dlightColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsScrollbar3dlightColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollbarArrowColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsScrollbarArrowColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsScrollbarArrowColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsScrollbarArrowColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollbarBaseColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsScrollbarBaseColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsScrollbarBaseColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsScrollbarBaseColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollbarDarkshadowColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsScrollbarDarkshadowColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsScrollbarDarkshadowColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsScrollbarDarkshadowColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollbarFaceColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsScrollbarFaceColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsScrollbarFaceColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsScrollbarFaceColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollbarHighlightColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsScrollbarHighlightColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsScrollbarHighlightColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsScrollbarHighlightColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollbarShadowColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsScrollbarShadowColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsScrollbarShadowColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsScrollbarShadowColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollbarTrackColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsScrollbarTrackColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsScrollbarTrackColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsScrollbarTrackColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsTextAutospace : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsTextAutospace(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsTextAutospace(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsTextAutospace(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsTouchSelect : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsTouchSelect(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsTouchSelect(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsTouchSelect(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsUserSelect : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsUserSelect(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsUserSelect(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsUserSelect(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsWrapFlow : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsWrapFlow(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsWrapFlow(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsWrapFlow(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsWrapMargin : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private MsWrapMargin(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsWrapMargin(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsWrapMargin(string t) => new(1, value1: t);
            public static implicit operator MsWrapMargin(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsWrapThrough : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MsWrapThrough(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MsWrapThrough(PropertySkip t) => new(0, value0: t);
            public static implicit operator MsWrapThrough(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitAppearance : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private WebkitAppearance(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitAppearance(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitAppearance(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitBorderBefore : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private WebkitBorderBefore(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitBorderBefore(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitBorderBefore(string t) => new(1, value1: t);
            public static implicit operator WebkitBorderBefore(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitBorderBeforeColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private WebkitBorderBeforeColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitBorderBeforeColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitBorderBeforeColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitBorderBeforeStyle : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private WebkitBorderBeforeStyle(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitBorderBeforeStyle(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitBorderBeforeStyle(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitBorderBeforeWidth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private WebkitBorderBeforeWidth(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitBorderBeforeWidth(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitBorderBeforeWidth(string t) => new(1, value1: t);
            public static implicit operator WebkitBorderBeforeWidth(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitBoxReflect : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private WebkitBoxReflect(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitBoxReflect(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitBoxReflect(string t) => new(1, value1: t);
            public static implicit operator WebkitBoxReflect(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitLineClamp : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private WebkitLineClamp(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitLineClamp(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitLineClamp(string t) => new(1, value1: t);
            public static implicit operator WebkitLineClamp(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMask : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private WebkitMask(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitMask(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitMask(string t) => new(1, value1: t);
            public static implicit operator WebkitMask(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskAttachment : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private WebkitMaskAttachment(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitMaskAttachment(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitMaskAttachment(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskClip : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private WebkitMaskClip(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitMaskClip(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitMaskClip(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskComposite : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private WebkitMaskComposite(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitMaskComposite(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitMaskComposite(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskImage : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private WebkitMaskImage(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitMaskImage(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitMaskImage(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskOrigin : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private WebkitMaskOrigin(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitMaskOrigin(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitMaskOrigin(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskPosition : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private WebkitMaskPosition(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitMaskPosition(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitMaskPosition(string t) => new(1, value1: t);
            public static implicit operator WebkitMaskPosition(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskPositionX : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private WebkitMaskPositionX(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitMaskPositionX(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitMaskPositionX(string t) => new(1, value1: t);
            public static implicit operator WebkitMaskPositionX(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskPositionY : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private WebkitMaskPositionY(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitMaskPositionY(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitMaskPositionY(string t) => new(1, value1: t);
            public static implicit operator WebkitMaskPositionY(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskRepeat : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private WebkitMaskRepeat(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitMaskRepeat(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitMaskRepeat(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskRepeatX : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private WebkitMaskRepeatX(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitMaskRepeatX(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitMaskRepeatX(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskRepeatY : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private WebkitMaskRepeatY(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitMaskRepeatY(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitMaskRepeatY(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskSize : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private WebkitMaskSize(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitMaskSize(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitMaskSize(string t) => new(1, value1: t);
            public static implicit operator WebkitMaskSize(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitOverflowScrolling : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private WebkitOverflowScrolling(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitOverflowScrolling(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitOverflowScrolling(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitTapHighlightColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private WebkitTapHighlightColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitTapHighlightColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitTapHighlightColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitTextFillColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private WebkitTextFillColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitTextFillColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitTextFillColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitTextStroke : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private WebkitTextStroke(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitTextStroke(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitTextStroke(string t) => new(1, value1: t);
            public static implicit operator WebkitTextStroke(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitTextStrokeColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private WebkitTextStrokeColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitTextStrokeColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitTextStrokeColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitTextStrokeWidth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private WebkitTextStrokeWidth(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitTextStrokeWidth(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitTextStrokeWidth(string t) => new(1, value1: t);
            public static implicit operator WebkitTextStrokeWidth(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitTouchCallout : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private WebkitTouchCallout(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitTouchCallout(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitTouchCallout(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitUserModify : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private WebkitUserModify(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator WebkitUserModify(PropertySkip t) => new(0, value0: t);
            public static implicit operator WebkitUserModify(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AlignmentBaseline : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private AlignmentBaseline(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator AlignmentBaseline(PropertySkip t) => new(0, value0: t);
            public static implicit operator AlignmentBaseline(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BaselineShift : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private BaselineShift(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BaselineShift(PropertySkip t) => new(0, value0: t);
            public static implicit operator BaselineShift(string t) => new(1, value1: t);
            public static implicit operator BaselineShift(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ClipRule : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ClipRule(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ClipRule(PropertySkip t) => new(0, value0: t);
            public static implicit operator ClipRule(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColorInterpolation : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ColorInterpolation(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ColorInterpolation(PropertySkip t) => new(0, value0: t);
            public static implicit operator ColorInterpolation(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColorRendering : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ColorRendering(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ColorRendering(PropertySkip t) => new(0, value0: t);
            public static implicit operator ColorRendering(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct DominantBaseline : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private DominantBaseline(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator DominantBaseline(PropertySkip t) => new(0, value0: t);
            public static implicit operator DominantBaseline(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Fill : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Fill(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Fill(PropertySkip t) => new(0, value0: t);
            public static implicit operator Fill(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FillOpacity : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private FillOpacity(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FillOpacity(PropertySkip t) => new(0, value0: t);
            public static implicit operator FillOpacity(string t) => new(1, value1: t);
            public static implicit operator FillOpacity(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FillRule : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private FillRule(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FillRule(PropertySkip t) => new(0, value0: t);
            public static implicit operator FillRule(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FloodColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private FloodColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator FloodColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator FloodColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FloodOpacity : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private FloodOpacity(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FloodOpacity(PropertySkip t) => new(0, value0: t);
            public static implicit operator FloodOpacity(string t) => new(1, value1: t);
            public static implicit operator FloodOpacity(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GlyphOrientationVertical : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private GlyphOrientationVertical(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator GlyphOrientationVertical(PropertySkip t) => new(0, value0: t);
            public static implicit operator GlyphOrientationVertical(string t) => new(1, value1: t);
            public static implicit operator GlyphOrientationVertical(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct LightingColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private LightingColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator LightingColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator LightingColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Marker : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Marker(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Marker(PropertySkip t) => new(0, value0: t);
            public static implicit operator Marker(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarkerEnd : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MarkerEnd(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MarkerEnd(PropertySkip t) => new(0, value0: t);
            public static implicit operator MarkerEnd(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarkerMid : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MarkerMid(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MarkerMid(PropertySkip t) => new(0, value0: t);
            public static implicit operator MarkerMid(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarkerStart : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private MarkerStart(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator MarkerStart(PropertySkip t) => new(0, value0: t);
            public static implicit operator MarkerStart(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ShapeRendering : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private ShapeRendering(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator ShapeRendering(PropertySkip t) => new(0, value0: t);
            public static implicit operator ShapeRendering(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StopColor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private StopColor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator StopColor(PropertySkip t) => new(0, value0: t);
            public static implicit operator StopColor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StopOpacity : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private StopOpacity(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator StopOpacity(PropertySkip t) => new(0, value0: t);
            public static implicit operator StopOpacity(string t) => new(1, value1: t);
            public static implicit operator StopOpacity(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Stroke : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private Stroke(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator Stroke(PropertySkip t) => new(0, value0: t);
            public static implicit operator Stroke(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StrokeDasharray : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private StrokeDasharray(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator StrokeDasharray(PropertySkip t) => new(0, value0: t);
            public static implicit operator StrokeDasharray(string t) => new(1, value1: t);
            public static implicit operator StrokeDasharray(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StrokeDashoffset : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private StrokeDashoffset(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator StrokeDashoffset(PropertySkip t) => new(0, value0: t);
            public static implicit operator StrokeDashoffset(string t) => new(1, value1: t);
            public static implicit operator StrokeDashoffset(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StrokeLinecap : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private StrokeLinecap(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator StrokeLinecap(PropertySkip t) => new(0, value0: t);
            public static implicit operator StrokeLinecap(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StrokeLinejoin : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private StrokeLinejoin(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator StrokeLinejoin(PropertySkip t) => new(0, value0: t);
            public static implicit operator StrokeLinejoin(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StrokeMiterlimit : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private StrokeMiterlimit(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator StrokeMiterlimit(PropertySkip t) => new(0, value0: t);
            public static implicit operator StrokeMiterlimit(string t) => new(1, value1: t);
            public static implicit operator StrokeMiterlimit(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StrokeOpacity : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private StrokeOpacity(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator StrokeOpacity(PropertySkip t) => new(0, value0: t);
            public static implicit operator StrokeOpacity(string t) => new(1, value1: t);
            public static implicit operator StrokeOpacity(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StrokeWidth : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;
            private readonly int _value2;

            private StrokeWidth(int index, PropertySkip value0 = default, string value1 = default, int value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator StrokeWidth(PropertySkip t) => new(0, value0: t);
            public static implicit operator StrokeWidth(string t) => new(1, value1: t);
            public static implicit operator StrokeWidth(int t) => new(2, value2: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextAnchor : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private TextAnchor(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator TextAnchor(PropertySkip t) => new(0, value0: t);
            public static implicit operator TextAnchor(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct VectorEffect : IProperty
        {
            private readonly int _index;
            private readonly PropertySkip _value0;
            private readonly string _value1;

            private VectorEffect(int index, PropertySkip value0 = default, string value1 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
            }

            public static implicit operator VectorEffect(PropertySkip t) => new(0, value0: t);
            public static implicit operator VectorEffect(string t) => new(1, value1: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }
}
}
