using System;
using static CssInCSharp.Functions;

namespace CssInCSharp
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
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private AccentColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator AccentColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator AccentColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator AccentColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AlignContent : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private AlignContent(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator AlignContent(CSSProperties t) => new(0, value0: t);
            public static implicit operator AlignContent(PropertySkip t) => new(1, value1: t);
            public static implicit operator AlignContent(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AlignItems : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private AlignItems(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator AlignItems(CSSProperties t) => new(0, value0: t);
            public static implicit operator AlignItems(PropertySkip t) => new(1, value1: t);
            public static implicit operator AlignItems(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AlignSelf : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private AlignSelf(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator AlignSelf(CSSProperties t) => new(0, value0: t);
            public static implicit operator AlignSelf(PropertySkip t) => new(1, value1: t);
            public static implicit operator AlignSelf(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AlignTracks : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private AlignTracks(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator AlignTracks(CSSProperties t) => new(0, value0: t);
            public static implicit operator AlignTracks(PropertySkip t) => new(1, value1: t);
            public static implicit operator AlignTracks(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct All : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private All(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator All(CSSProperties t) => new(0, value0: t);
            public static implicit operator All(PropertySkip t) => new(1, value1: t);
            public static implicit operator All(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Animation : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Animation(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Animation(CSSProperties t) => new(0, value0: t);
            public static implicit operator Animation(PropertySkip t) => new(1, value1: t);
            public static implicit operator Animation(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationComposition : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private AnimationComposition(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator AnimationComposition(CSSProperties t) => new(0, value0: t);
            public static implicit operator AnimationComposition(PropertySkip t) => new(1, value1: t);
            public static implicit operator AnimationComposition(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationDelay : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private AnimationDelay(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator AnimationDelay(CSSProperties t) => new(0, value0: t);
            public static implicit operator AnimationDelay(PropertySkip t) => new(1, value1: t);
            public static implicit operator AnimationDelay(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationDirection : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private AnimationDirection(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator AnimationDirection(CSSProperties t) => new(0, value0: t);
            public static implicit operator AnimationDirection(PropertySkip t) => new(1, value1: t);
            public static implicit operator AnimationDirection(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationDuration : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private AnimationDuration(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator AnimationDuration(CSSProperties t) => new(0, value0: t);
            public static implicit operator AnimationDuration(PropertySkip t) => new(1, value1: t);
            public static implicit operator AnimationDuration(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationFillMode : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private AnimationFillMode(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator AnimationFillMode(CSSProperties t) => new(0, value0: t);
            public static implicit operator AnimationFillMode(PropertySkip t) => new(1, value1: t);
            public static implicit operator AnimationFillMode(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationIterationCount : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private AnimationIterationCount(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator AnimationIterationCount(CSSProperties t) => new(0, value0: t);
            public static implicit operator AnimationIterationCount(PropertySkip t) => new(1, value1: t);
            public static implicit operator AnimationIterationCount(string t) => new(2, value2: t);
            public static implicit operator AnimationIterationCount(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationName : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly Keyframe _value3;

            private AnimationName(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, Keyframe value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator AnimationName(CSSProperties t) => new(0, value0: t);
            public static implicit operator AnimationName(PropertySkip t) => new(1, value1: t);
            public static implicit operator AnimationName(string t) => new(2, value2: t);
            public static implicit operator AnimationName(Keyframe t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationPlayState : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private AnimationPlayState(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator AnimationPlayState(CSSProperties t) => new(0, value0: t);
            public static implicit operator AnimationPlayState(PropertySkip t) => new(1, value1: t);
            public static implicit operator AnimationPlayState(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationRange : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private AnimationRange(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator AnimationRange(CSSProperties t) => new(0, value0: t);
            public static implicit operator AnimationRange(PropertySkip t) => new(1, value1: t);
            public static implicit operator AnimationRange(string t) => new(2, value2: t);
            public static implicit operator AnimationRange(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationRangeEnd : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private AnimationRangeEnd(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator AnimationRangeEnd(CSSProperties t) => new(0, value0: t);
            public static implicit operator AnimationRangeEnd(PropertySkip t) => new(1, value1: t);
            public static implicit operator AnimationRangeEnd(string t) => new(2, value2: t);
            public static implicit operator AnimationRangeEnd(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationRangeStart : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private AnimationRangeStart(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator AnimationRangeStart(CSSProperties t) => new(0, value0: t);
            public static implicit operator AnimationRangeStart(PropertySkip t) => new(1, value1: t);
            public static implicit operator AnimationRangeStart(string t) => new(2, value2: t);
            public static implicit operator AnimationRangeStart(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationTimeline : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private AnimationTimeline(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator AnimationTimeline(CSSProperties t) => new(0, value0: t);
            public static implicit operator AnimationTimeline(PropertySkip t) => new(1, value1: t);
            public static implicit operator AnimationTimeline(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AnimationTimingFunction : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private AnimationTimingFunction(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator AnimationTimingFunction(CSSProperties t) => new(0, value0: t);
            public static implicit operator AnimationTimingFunction(PropertySkip t) => new(1, value1: t);
            public static implicit operator AnimationTimingFunction(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Appearance : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Appearance(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Appearance(CSSProperties t) => new(0, value0: t);
            public static implicit operator Appearance(PropertySkip t) => new(1, value1: t);
            public static implicit operator Appearance(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AspectRatio : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private AspectRatio(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator AspectRatio(CSSProperties t) => new(0, value0: t);
            public static implicit operator AspectRatio(PropertySkip t) => new(1, value1: t);
            public static implicit operator AspectRatio(string t) => new(2, value2: t);
            public static implicit operator AspectRatio(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Azimuth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Azimuth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Azimuth(CSSProperties t) => new(0, value0: t);
            public static implicit operator Azimuth(PropertySkip t) => new(1, value1: t);
            public static implicit operator Azimuth(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackdropFilter : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BackdropFilter(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BackdropFilter(CSSProperties t) => new(0, value0: t);
            public static implicit operator BackdropFilter(PropertySkip t) => new(1, value1: t);
            public static implicit operator BackdropFilter(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackfaceVisibility : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BackfaceVisibility(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BackfaceVisibility(CSSProperties t) => new(0, value0: t);
            public static implicit operator BackfaceVisibility(PropertySkip t) => new(1, value1: t);
            public static implicit operator BackfaceVisibility(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Background : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private Background(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator Background(CSSProperties t) => new(0, value0: t);
            public static implicit operator Background(PropertySkip t) => new(1, value1: t);
            public static implicit operator Background(string t) => new(2, value2: t);
            public static implicit operator Background(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundAttachment : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BackgroundAttachment(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BackgroundAttachment(CSSProperties t) => new(0, value0: t);
            public static implicit operator BackgroundAttachment(PropertySkip t) => new(1, value1: t);
            public static implicit operator BackgroundAttachment(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundBlendMode : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BackgroundBlendMode(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BackgroundBlendMode(CSSProperties t) => new(0, value0: t);
            public static implicit operator BackgroundBlendMode(PropertySkip t) => new(1, value1: t);
            public static implicit operator BackgroundBlendMode(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundClip : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BackgroundClip(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BackgroundClip(CSSProperties t) => new(0, value0: t);
            public static implicit operator BackgroundClip(PropertySkip t) => new(1, value1: t);
            public static implicit operator BackgroundClip(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BackgroundColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BackgroundColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator BackgroundColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator BackgroundColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundImage : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BackgroundImage(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BackgroundImage(CSSProperties t) => new(0, value0: t);
            public static implicit operator BackgroundImage(PropertySkip t) => new(1, value1: t);
            public static implicit operator BackgroundImage(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundOrigin : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BackgroundOrigin(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BackgroundOrigin(CSSProperties t) => new(0, value0: t);
            public static implicit operator BackgroundOrigin(PropertySkip t) => new(1, value1: t);
            public static implicit operator BackgroundOrigin(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundPosition : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BackgroundPosition(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BackgroundPosition(CSSProperties t) => new(0, value0: t);
            public static implicit operator BackgroundPosition(PropertySkip t) => new(1, value1: t);
            public static implicit operator BackgroundPosition(string t) => new(2, value2: t);
            public static implicit operator BackgroundPosition(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundPositionX : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BackgroundPositionX(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BackgroundPositionX(CSSProperties t) => new(0, value0: t);
            public static implicit operator BackgroundPositionX(PropertySkip t) => new(1, value1: t);
            public static implicit operator BackgroundPositionX(string t) => new(2, value2: t);
            public static implicit operator BackgroundPositionX(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundPositionY : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BackgroundPositionY(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BackgroundPositionY(CSSProperties t) => new(0, value0: t);
            public static implicit operator BackgroundPositionY(PropertySkip t) => new(1, value1: t);
            public static implicit operator BackgroundPositionY(string t) => new(2, value2: t);
            public static implicit operator BackgroundPositionY(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundRepeat : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BackgroundRepeat(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BackgroundRepeat(CSSProperties t) => new(0, value0: t);
            public static implicit operator BackgroundRepeat(PropertySkip t) => new(1, value1: t);
            public static implicit operator BackgroundRepeat(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BackgroundSize : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BackgroundSize(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BackgroundSize(CSSProperties t) => new(0, value0: t);
            public static implicit operator BackgroundSize(PropertySkip t) => new(1, value1: t);
            public static implicit operator BackgroundSize(string t) => new(2, value2: t);
            public static implicit operator BackgroundSize(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BlockOverflow : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BlockOverflow(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BlockOverflow(CSSProperties t) => new(0, value0: t);
            public static implicit operator BlockOverflow(PropertySkip t) => new(1, value1: t);
            public static implicit operator BlockOverflow(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BlockSize : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BlockSize(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BlockSize(CSSProperties t) => new(0, value0: t);
            public static implicit operator BlockSize(PropertySkip t) => new(1, value1: t);
            public static implicit operator BlockSize(string t) => new(2, value2: t);
            public static implicit operator BlockSize(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Border : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private Border(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator Border(CSSProperties t) => new(0, value0: t);
            public static implicit operator Border(PropertySkip t) => new(1, value1: t);
            public static implicit operator Border(string t) => new(2, value2: t);
            public static implicit operator Border(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlock : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderBlock(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderBlock(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderBlock(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderBlock(string t) => new(2, value2: t);
            public static implicit operator BorderBlock(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BorderBlockColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderBlockColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderBlockColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderBlockColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockEnd : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderBlockEnd(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderBlockEnd(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderBlockEnd(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderBlockEnd(string t) => new(2, value2: t);
            public static implicit operator BorderBlockEnd(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockEndColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BorderBlockEndColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderBlockEndColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderBlockEndColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderBlockEndColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockEndStyle : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BorderBlockEndStyle(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderBlockEndStyle(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderBlockEndStyle(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderBlockEndStyle(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockEndWidth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderBlockEndWidth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderBlockEndWidth(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderBlockEndWidth(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderBlockEndWidth(string t) => new(2, value2: t);
            public static implicit operator BorderBlockEndWidth(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockStart : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderBlockStart(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderBlockStart(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderBlockStart(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderBlockStart(string t) => new(2, value2: t);
            public static implicit operator BorderBlockStart(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockStartColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BorderBlockStartColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderBlockStartColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderBlockStartColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderBlockStartColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockStartStyle : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BorderBlockStartStyle(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderBlockStartStyle(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderBlockStartStyle(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderBlockStartStyle(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockStartWidth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderBlockStartWidth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderBlockStartWidth(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderBlockStartWidth(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderBlockStartWidth(string t) => new(2, value2: t);
            public static implicit operator BorderBlockStartWidth(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockStyle : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BorderBlockStyle(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderBlockStyle(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderBlockStyle(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderBlockStyle(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBlockWidth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderBlockWidth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderBlockWidth(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderBlockWidth(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderBlockWidth(string t) => new(2, value2: t);
            public static implicit operator BorderBlockWidth(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBottom : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderBottom(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderBottom(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderBottom(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderBottom(string t) => new(2, value2: t);
            public static implicit operator BorderBottom(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBottomColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BorderBottomColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderBottomColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderBottomColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderBottomColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBottomLeftRadius : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderBottomLeftRadius(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderBottomLeftRadius(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderBottomLeftRadius(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderBottomLeftRadius(string t) => new(2, value2: t);
            public static implicit operator BorderBottomLeftRadius(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBottomRightRadius : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderBottomRightRadius(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderBottomRightRadius(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderBottomRightRadius(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderBottomRightRadius(string t) => new(2, value2: t);
            public static implicit operator BorderBottomRightRadius(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBottomStyle : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BorderBottomStyle(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderBottomStyle(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderBottomStyle(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderBottomStyle(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderBottomWidth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderBottomWidth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderBottomWidth(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderBottomWidth(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderBottomWidth(string t) => new(2, value2: t);
            public static implicit operator BorderBottomWidth(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderCollapse : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BorderCollapse(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderCollapse(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderCollapse(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderCollapse(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BorderColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderEndEndRadius : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderEndEndRadius(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderEndEndRadius(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderEndEndRadius(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderEndEndRadius(string t) => new(2, value2: t);
            public static implicit operator BorderEndEndRadius(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderEndStartRadius : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderEndStartRadius(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderEndStartRadius(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderEndStartRadius(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderEndStartRadius(string t) => new(2, value2: t);
            public static implicit operator BorderEndStartRadius(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderImage : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderImage(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderImage(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderImage(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderImage(string t) => new(2, value2: t);
            public static implicit operator BorderImage(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderImageOutset : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderImageOutset(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderImageOutset(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderImageOutset(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderImageOutset(string t) => new(2, value2: t);
            public static implicit operator BorderImageOutset(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderImageRepeat : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BorderImageRepeat(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderImageRepeat(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderImageRepeat(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderImageRepeat(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderImageSlice : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderImageSlice(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderImageSlice(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderImageSlice(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderImageSlice(string t) => new(2, value2: t);
            public static implicit operator BorderImageSlice(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderImageSource : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BorderImageSource(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderImageSource(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderImageSource(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderImageSource(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderImageWidth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderImageWidth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderImageWidth(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderImageWidth(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderImageWidth(string t) => new(2, value2: t);
            public static implicit operator BorderImageWidth(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInline : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderInline(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderInline(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderInline(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderInline(string t) => new(2, value2: t);
            public static implicit operator BorderInline(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BorderInlineColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderInlineColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderInlineColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderInlineColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineEnd : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderInlineEnd(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderInlineEnd(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderInlineEnd(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderInlineEnd(string t) => new(2, value2: t);
            public static implicit operator BorderInlineEnd(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineEndColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BorderInlineEndColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderInlineEndColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderInlineEndColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderInlineEndColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineEndStyle : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BorderInlineEndStyle(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderInlineEndStyle(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderInlineEndStyle(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderInlineEndStyle(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineEndWidth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderInlineEndWidth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderInlineEndWidth(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderInlineEndWidth(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderInlineEndWidth(string t) => new(2, value2: t);
            public static implicit operator BorderInlineEndWidth(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineStart : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderInlineStart(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderInlineStart(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderInlineStart(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderInlineStart(string t) => new(2, value2: t);
            public static implicit operator BorderInlineStart(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineStartColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BorderInlineStartColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderInlineStartColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderInlineStartColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderInlineStartColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineStartStyle : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BorderInlineStartStyle(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderInlineStartStyle(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderInlineStartStyle(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderInlineStartStyle(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineStartWidth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderInlineStartWidth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderInlineStartWidth(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderInlineStartWidth(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderInlineStartWidth(string t) => new(2, value2: t);
            public static implicit operator BorderInlineStartWidth(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineStyle : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BorderInlineStyle(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderInlineStyle(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderInlineStyle(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderInlineStyle(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderInlineWidth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderInlineWidth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderInlineWidth(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderInlineWidth(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderInlineWidth(string t) => new(2, value2: t);
            public static implicit operator BorderInlineWidth(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderLeft : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderLeft(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderLeft(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderLeft(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderLeft(string t) => new(2, value2: t);
            public static implicit operator BorderLeft(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderLeftColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BorderLeftColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderLeftColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderLeftColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderLeftColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderLeftStyle : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BorderLeftStyle(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderLeftStyle(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderLeftStyle(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderLeftStyle(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderLeftWidth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderLeftWidth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderLeftWidth(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderLeftWidth(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderLeftWidth(string t) => new(2, value2: t);
            public static implicit operator BorderLeftWidth(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderRadius : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderRadius(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderRadius(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderRadius(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderRadius(string t) => new(2, value2: t);
            public static implicit operator BorderRadius(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderRight : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderRight(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderRight(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderRight(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderRight(string t) => new(2, value2: t);
            public static implicit operator BorderRight(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderRightColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BorderRightColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderRightColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderRightColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderRightColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderRightStyle : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BorderRightStyle(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderRightStyle(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderRightStyle(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderRightStyle(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderRightWidth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderRightWidth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderRightWidth(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderRightWidth(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderRightWidth(string t) => new(2, value2: t);
            public static implicit operator BorderRightWidth(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderSpacing : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderSpacing(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderSpacing(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderSpacing(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderSpacing(string t) => new(2, value2: t);
            public static implicit operator BorderSpacing(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderStartEndRadius : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderStartEndRadius(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderStartEndRadius(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderStartEndRadius(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderStartEndRadius(string t) => new(2, value2: t);
            public static implicit operator BorderStartEndRadius(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderStartStartRadius : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderStartStartRadius(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderStartStartRadius(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderStartStartRadius(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderStartStartRadius(string t) => new(2, value2: t);
            public static implicit operator BorderStartStartRadius(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderStyle : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BorderStyle(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderStyle(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderStyle(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderStyle(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderTop : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderTop(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderTop(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderTop(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderTop(string t) => new(2, value2: t);
            public static implicit operator BorderTop(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderTopColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BorderTopColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderTopColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderTopColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderTopColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderTopLeftRadius : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderTopLeftRadius(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderTopLeftRadius(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderTopLeftRadius(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderTopLeftRadius(string t) => new(2, value2: t);
            public static implicit operator BorderTopLeftRadius(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderTopRightRadius : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderTopRightRadius(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderTopRightRadius(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderTopRightRadius(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderTopRightRadius(string t) => new(2, value2: t);
            public static implicit operator BorderTopRightRadius(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderTopStyle : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BorderTopStyle(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BorderTopStyle(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderTopStyle(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderTopStyle(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderTopWidth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderTopWidth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderTopWidth(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderTopWidth(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderTopWidth(string t) => new(2, value2: t);
            public static implicit operator BorderTopWidth(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BorderWidth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BorderWidth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BorderWidth(CSSProperties t) => new(0, value0: t);
            public static implicit operator BorderWidth(PropertySkip t) => new(1, value1: t);
            public static implicit operator BorderWidth(string t) => new(2, value2: t);
            public static implicit operator BorderWidth(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Bottom : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private Bottom(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator Bottom(CSSProperties t) => new(0, value0: t);
            public static implicit operator Bottom(PropertySkip t) => new(1, value1: t);
            public static implicit operator Bottom(string t) => new(2, value2: t);
            public static implicit operator Bottom(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxAlign : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BoxAlign(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BoxAlign(CSSProperties t) => new(0, value0: t);
            public static implicit operator BoxAlign(PropertySkip t) => new(1, value1: t);
            public static implicit operator BoxAlign(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxDecorationBreak : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BoxDecorationBreak(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BoxDecorationBreak(CSSProperties t) => new(0, value0: t);
            public static implicit operator BoxDecorationBreak(PropertySkip t) => new(1, value1: t);
            public static implicit operator BoxDecorationBreak(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxDirection : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BoxDirection(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BoxDirection(CSSProperties t) => new(0, value0: t);
            public static implicit operator BoxDirection(PropertySkip t) => new(1, value1: t);
            public static implicit operator BoxDirection(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxFlex : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BoxFlex(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BoxFlex(CSSProperties t) => new(0, value0: t);
            public static implicit operator BoxFlex(PropertySkip t) => new(1, value1: t);
            public static implicit operator BoxFlex(string t) => new(2, value2: t);
            public static implicit operator BoxFlex(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxFlexGroup : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BoxFlexGroup(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BoxFlexGroup(CSSProperties t) => new(0, value0: t);
            public static implicit operator BoxFlexGroup(PropertySkip t) => new(1, value1: t);
            public static implicit operator BoxFlexGroup(string t) => new(2, value2: t);
            public static implicit operator BoxFlexGroup(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxLines : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BoxLines(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BoxLines(CSSProperties t) => new(0, value0: t);
            public static implicit operator BoxLines(PropertySkip t) => new(1, value1: t);
            public static implicit operator BoxLines(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxOrdinalGroup : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BoxOrdinalGroup(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BoxOrdinalGroup(CSSProperties t) => new(0, value0: t);
            public static implicit operator BoxOrdinalGroup(PropertySkip t) => new(1, value1: t);
            public static implicit operator BoxOrdinalGroup(string t) => new(2, value2: t);
            public static implicit operator BoxOrdinalGroup(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxOrient : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BoxOrient(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BoxOrient(CSSProperties t) => new(0, value0: t);
            public static implicit operator BoxOrient(PropertySkip t) => new(1, value1: t);
            public static implicit operator BoxOrient(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxPack : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BoxPack(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BoxPack(CSSProperties t) => new(0, value0: t);
            public static implicit operator BoxPack(PropertySkip t) => new(1, value1: t);
            public static implicit operator BoxPack(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxShadow : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BoxShadow(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BoxShadow(CSSProperties t) => new(0, value0: t);
            public static implicit operator BoxShadow(PropertySkip t) => new(1, value1: t);
            public static implicit operator BoxShadow(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BoxSizing : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BoxSizing(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BoxSizing(CSSProperties t) => new(0, value0: t);
            public static implicit operator BoxSizing(PropertySkip t) => new(1, value1: t);
            public static implicit operator BoxSizing(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BreakAfter : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BreakAfter(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BreakAfter(CSSProperties t) => new(0, value0: t);
            public static implicit operator BreakAfter(PropertySkip t) => new(1, value1: t);
            public static implicit operator BreakAfter(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BreakBefore : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BreakBefore(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BreakBefore(CSSProperties t) => new(0, value0: t);
            public static implicit operator BreakBefore(PropertySkip t) => new(1, value1: t);
            public static implicit operator BreakBefore(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BreakInside : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private BreakInside(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator BreakInside(CSSProperties t) => new(0, value0: t);
            public static implicit operator BreakInside(PropertySkip t) => new(1, value1: t);
            public static implicit operator BreakInside(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct CaptionSide : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private CaptionSide(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator CaptionSide(CSSProperties t) => new(0, value0: t);
            public static implicit operator CaptionSide(PropertySkip t) => new(1, value1: t);
            public static implicit operator CaptionSide(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Caret : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Caret(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Caret(CSSProperties t) => new(0, value0: t);
            public static implicit operator Caret(PropertySkip t) => new(1, value1: t);
            public static implicit operator Caret(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct CaretColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private CaretColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator CaretColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator CaretColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator CaretColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct CaretShape : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private CaretShape(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator CaretShape(CSSProperties t) => new(0, value0: t);
            public static implicit operator CaretShape(PropertySkip t) => new(1, value1: t);
            public static implicit operator CaretShape(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Clear : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Clear(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Clear(CSSProperties t) => new(0, value0: t);
            public static implicit operator Clear(PropertySkip t) => new(1, value1: t);
            public static implicit operator Clear(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Clip : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Clip(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Clip(CSSProperties t) => new(0, value0: t);
            public static implicit operator Clip(PropertySkip t) => new(1, value1: t);
            public static implicit operator Clip(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ClipPath : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ClipPath(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ClipPath(CSSProperties t) => new(0, value0: t);
            public static implicit operator ClipPath(PropertySkip t) => new(1, value1: t);
            public static implicit operator ClipPath(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Color : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Color(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Color(CSSProperties t) => new(0, value0: t);
            public static implicit operator Color(PropertySkip t) => new(1, value1: t);
            public static implicit operator Color(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PrintColorAdjust : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private PrintColorAdjust(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator PrintColorAdjust(CSSProperties t) => new(0, value0: t);
            public static implicit operator PrintColorAdjust(PropertySkip t) => new(1, value1: t);
            public static implicit operator PrintColorAdjust(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColorScheme : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ColorScheme(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ColorScheme(CSSProperties t) => new(0, value0: t);
            public static implicit operator ColorScheme(PropertySkip t) => new(1, value1: t);
            public static implicit operator ColorScheme(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnCount : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ColumnCount(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ColumnCount(CSSProperties t) => new(0, value0: t);
            public static implicit operator ColumnCount(PropertySkip t) => new(1, value1: t);
            public static implicit operator ColumnCount(string t) => new(2, value2: t);
            public static implicit operator ColumnCount(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnFill : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ColumnFill(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ColumnFill(CSSProperties t) => new(0, value0: t);
            public static implicit operator ColumnFill(PropertySkip t) => new(1, value1: t);
            public static implicit operator ColumnFill(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnGap : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ColumnGap(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ColumnGap(CSSProperties t) => new(0, value0: t);
            public static implicit operator ColumnGap(PropertySkip t) => new(1, value1: t);
            public static implicit operator ColumnGap(string t) => new(2, value2: t);
            public static implicit operator ColumnGap(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnRule : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ColumnRule(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ColumnRule(CSSProperties t) => new(0, value0: t);
            public static implicit operator ColumnRule(PropertySkip t) => new(1, value1: t);
            public static implicit operator ColumnRule(string t) => new(2, value2: t);
            public static implicit operator ColumnRule(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnRuleColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ColumnRuleColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ColumnRuleColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator ColumnRuleColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator ColumnRuleColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnRuleStyle : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ColumnRuleStyle(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ColumnRuleStyle(CSSProperties t) => new(0, value0: t);
            public static implicit operator ColumnRuleStyle(PropertySkip t) => new(1, value1: t);
            public static implicit operator ColumnRuleStyle(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnRuleWidth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ColumnRuleWidth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ColumnRuleWidth(CSSProperties t) => new(0, value0: t);
            public static implicit operator ColumnRuleWidth(PropertySkip t) => new(1, value1: t);
            public static implicit operator ColumnRuleWidth(string t) => new(2, value2: t);
            public static implicit operator ColumnRuleWidth(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnSpan : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ColumnSpan(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ColumnSpan(CSSProperties t) => new(0, value0: t);
            public static implicit operator ColumnSpan(PropertySkip t) => new(1, value1: t);
            public static implicit operator ColumnSpan(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColumnWidth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ColumnWidth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ColumnWidth(CSSProperties t) => new(0, value0: t);
            public static implicit operator ColumnWidth(PropertySkip t) => new(1, value1: t);
            public static implicit operator ColumnWidth(string t) => new(2, value2: t);
            public static implicit operator ColumnWidth(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Columns : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private Columns(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator Columns(CSSProperties t) => new(0, value0: t);
            public static implicit operator Columns(PropertySkip t) => new(1, value1: t);
            public static implicit operator Columns(string t) => new(2, value2: t);
            public static implicit operator Columns(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Contain : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Contain(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Contain(CSSProperties t) => new(0, value0: t);
            public static implicit operator Contain(PropertySkip t) => new(1, value1: t);
            public static implicit operator Contain(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ContainIntrinsicBlockSize : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ContainIntrinsicBlockSize(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ContainIntrinsicBlockSize(CSSProperties t) => new(0, value0: t);
            public static implicit operator ContainIntrinsicBlockSize(PropertySkip t) => new(1, value1: t);
            public static implicit operator ContainIntrinsicBlockSize(string t) => new(2, value2: t);
            public static implicit operator ContainIntrinsicBlockSize(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ContainIntrinsicHeight : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ContainIntrinsicHeight(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ContainIntrinsicHeight(CSSProperties t) => new(0, value0: t);
            public static implicit operator ContainIntrinsicHeight(PropertySkip t) => new(1, value1: t);
            public static implicit operator ContainIntrinsicHeight(string t) => new(2, value2: t);
            public static implicit operator ContainIntrinsicHeight(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ContainIntrinsicInlineSize : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ContainIntrinsicInlineSize(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ContainIntrinsicInlineSize(CSSProperties t) => new(0, value0: t);
            public static implicit operator ContainIntrinsicInlineSize(PropertySkip t) => new(1, value1: t);
            public static implicit operator ContainIntrinsicInlineSize(string t) => new(2, value2: t);
            public static implicit operator ContainIntrinsicInlineSize(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ContainIntrinsicSize : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ContainIntrinsicSize(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ContainIntrinsicSize(CSSProperties t) => new(0, value0: t);
            public static implicit operator ContainIntrinsicSize(PropertySkip t) => new(1, value1: t);
            public static implicit operator ContainIntrinsicSize(string t) => new(2, value2: t);
            public static implicit operator ContainIntrinsicSize(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ContainIntrinsicWidth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ContainIntrinsicWidth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ContainIntrinsicWidth(CSSProperties t) => new(0, value0: t);
            public static implicit operator ContainIntrinsicWidth(PropertySkip t) => new(1, value1: t);
            public static implicit operator ContainIntrinsicWidth(string t) => new(2, value2: t);
            public static implicit operator ContainIntrinsicWidth(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Container : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Container(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Container(CSSProperties t) => new(0, value0: t);
            public static implicit operator Container(PropertySkip t) => new(1, value1: t);
            public static implicit operator Container(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ContainerName : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ContainerName(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ContainerName(CSSProperties t) => new(0, value0: t);
            public static implicit operator ContainerName(PropertySkip t) => new(1, value1: t);
            public static implicit operator ContainerName(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ContainerType : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ContainerType(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ContainerType(CSSProperties t) => new(0, value0: t);
            public static implicit operator ContainerType(PropertySkip t) => new(1, value1: t);
            public static implicit operator ContainerType(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Content : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Content(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Content(CSSProperties t) => new(0, value0: t);
            public static implicit operator Content(PropertySkip t) => new(1, value1: t);
            public static implicit operator Content(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ContentVisibility : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ContentVisibility(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ContentVisibility(CSSProperties t) => new(0, value0: t);
            public static implicit operator ContentVisibility(PropertySkip t) => new(1, value1: t);
            public static implicit operator ContentVisibility(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct CounterIncrement : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private CounterIncrement(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator CounterIncrement(CSSProperties t) => new(0, value0: t);
            public static implicit operator CounterIncrement(PropertySkip t) => new(1, value1: t);
            public static implicit operator CounterIncrement(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct CounterReset : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private CounterReset(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator CounterReset(CSSProperties t) => new(0, value0: t);
            public static implicit operator CounterReset(PropertySkip t) => new(1, value1: t);
            public static implicit operator CounterReset(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct CounterSet : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private CounterSet(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator CounterSet(CSSProperties t) => new(0, value0: t);
            public static implicit operator CounterSet(PropertySkip t) => new(1, value1: t);
            public static implicit operator CounterSet(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Cursor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Cursor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Cursor(CSSProperties t) => new(0, value0: t);
            public static implicit operator Cursor(PropertySkip t) => new(1, value1: t);
            public static implicit operator Cursor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Direction : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Direction(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Direction(CSSProperties t) => new(0, value0: t);
            public static implicit operator Direction(PropertySkip t) => new(1, value1: t);
            public static implicit operator Direction(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Display : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Display(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Display(CSSProperties t) => new(0, value0: t);
            public static implicit operator Display(PropertySkip t) => new(1, value1: t);
            public static implicit operator Display(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct EmptyCells : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private EmptyCells(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator EmptyCells(CSSProperties t) => new(0, value0: t);
            public static implicit operator EmptyCells(PropertySkip t) => new(1, value1: t);
            public static implicit operator EmptyCells(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Filter : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Filter(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Filter(CSSProperties t) => new(0, value0: t);
            public static implicit operator Filter(PropertySkip t) => new(1, value1: t);
            public static implicit operator Filter(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Flex : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private Flex(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator Flex(CSSProperties t) => new(0, value0: t);
            public static implicit operator Flex(PropertySkip t) => new(1, value1: t);
            public static implicit operator Flex(string t) => new(2, value2: t);
            public static implicit operator Flex(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FlexBasis : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private FlexBasis(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator FlexBasis(CSSProperties t) => new(0, value0: t);
            public static implicit operator FlexBasis(PropertySkip t) => new(1, value1: t);
            public static implicit operator FlexBasis(string t) => new(2, value2: t);
            public static implicit operator FlexBasis(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FlexDirection : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FlexDirection(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FlexDirection(CSSProperties t) => new(0, value0: t);
            public static implicit operator FlexDirection(PropertySkip t) => new(1, value1: t);
            public static implicit operator FlexDirection(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FlexFlow : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FlexFlow(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FlexFlow(CSSProperties t) => new(0, value0: t);
            public static implicit operator FlexFlow(PropertySkip t) => new(1, value1: t);
            public static implicit operator FlexFlow(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FlexGrow : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private FlexGrow(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator FlexGrow(CSSProperties t) => new(0, value0: t);
            public static implicit operator FlexGrow(PropertySkip t) => new(1, value1: t);
            public static implicit operator FlexGrow(string t) => new(2, value2: t);
            public static implicit operator FlexGrow(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FlexShrink : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private FlexShrink(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator FlexShrink(CSSProperties t) => new(0, value0: t);
            public static implicit operator FlexShrink(PropertySkip t) => new(1, value1: t);
            public static implicit operator FlexShrink(string t) => new(2, value2: t);
            public static implicit operator FlexShrink(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FlexWrap : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FlexWrap(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FlexWrap(CSSProperties t) => new(0, value0: t);
            public static implicit operator FlexWrap(PropertySkip t) => new(1, value1: t);
            public static implicit operator FlexWrap(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Float : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Float(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Float(CSSProperties t) => new(0, value0: t);
            public static implicit operator Float(PropertySkip t) => new(1, value1: t);
            public static implicit operator Float(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Font : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Font(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Font(CSSProperties t) => new(0, value0: t);
            public static implicit operator Font(PropertySkip t) => new(1, value1: t);
            public static implicit operator Font(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontFamily : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FontFamily(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontFamily(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontFamily(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontFamily(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontFeatureSettings : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FontFeatureSettings(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontFeatureSettings(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontFeatureSettings(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontFeatureSettings(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontKerning : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FontKerning(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontKerning(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontKerning(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontKerning(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontLanguageOverride : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FontLanguageOverride(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontLanguageOverride(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontLanguageOverride(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontLanguageOverride(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontOpticalSizing : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FontOpticalSizing(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontOpticalSizing(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontOpticalSizing(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontOpticalSizing(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontPalette : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FontPalette(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontPalette(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontPalette(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontPalette(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontSize : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private FontSize(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator FontSize(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontSize(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontSize(string t) => new(2, value2: t);
            public static implicit operator FontSize(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontSizeAdjust : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private FontSizeAdjust(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator FontSizeAdjust(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontSizeAdjust(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontSizeAdjust(string t) => new(2, value2: t);
            public static implicit operator FontSizeAdjust(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontSmooth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private FontSmooth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator FontSmooth(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontSmooth(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontSmooth(string t) => new(2, value2: t);
            public static implicit operator FontSmooth(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontStretch : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FontStretch(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontStretch(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontStretch(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontStretch(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontStyle : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FontStyle(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontStyle(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontStyle(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontStyle(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontSynthesis : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FontSynthesis(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontSynthesis(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontSynthesis(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontSynthesis(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontSynthesisPosition : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FontSynthesisPosition(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontSynthesisPosition(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontSynthesisPosition(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontSynthesisPosition(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontSynthesisSmallCaps : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FontSynthesisSmallCaps(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontSynthesisSmallCaps(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontSynthesisSmallCaps(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontSynthesisSmallCaps(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontSynthesisStyle : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FontSynthesisStyle(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontSynthesisStyle(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontSynthesisStyle(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontSynthesisStyle(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontSynthesisWeight : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FontSynthesisWeight(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontSynthesisWeight(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontSynthesisWeight(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontSynthesisWeight(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariant : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FontVariant(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontVariant(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontVariant(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontVariant(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariantAlternates : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FontVariantAlternates(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontVariantAlternates(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontVariantAlternates(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontVariantAlternates(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariantCaps : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FontVariantCaps(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontVariantCaps(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontVariantCaps(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontVariantCaps(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariantEastAsian : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FontVariantEastAsian(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontVariantEastAsian(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontVariantEastAsian(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontVariantEastAsian(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariantEmoji : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FontVariantEmoji(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontVariantEmoji(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontVariantEmoji(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontVariantEmoji(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariantLigatures : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FontVariantLigatures(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontVariantLigatures(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontVariantLigatures(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontVariantLigatures(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariantNumeric : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FontVariantNumeric(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontVariantNumeric(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontVariantNumeric(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontVariantNumeric(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariantPosition : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FontVariantPosition(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontVariantPosition(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontVariantPosition(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontVariantPosition(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontVariationSettings : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FontVariationSettings(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FontVariationSettings(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontVariationSettings(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontVariationSettings(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FontWeight : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private FontWeight(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator FontWeight(CSSProperties t) => new(0, value0: t);
            public static implicit operator FontWeight(PropertySkip t) => new(1, value1: t);
            public static implicit operator FontWeight(string t) => new(2, value2: t);
            public static implicit operator FontWeight(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ForcedColorAdjust : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ForcedColorAdjust(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ForcedColorAdjust(CSSProperties t) => new(0, value0: t);
            public static implicit operator ForcedColorAdjust(PropertySkip t) => new(1, value1: t);
            public static implicit operator ForcedColorAdjust(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Gap : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private Gap(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator Gap(CSSProperties t) => new(0, value0: t);
            public static implicit operator Gap(PropertySkip t) => new(1, value1: t);
            public static implicit operator Gap(string t) => new(2, value2: t);
            public static implicit operator Gap(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Grid : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Grid(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Grid(CSSProperties t) => new(0, value0: t);
            public static implicit operator Grid(PropertySkip t) => new(1, value1: t);
            public static implicit operator Grid(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridArea : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private GridArea(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator GridArea(CSSProperties t) => new(0, value0: t);
            public static implicit operator GridArea(PropertySkip t) => new(1, value1: t);
            public static implicit operator GridArea(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridAutoColumns : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private GridAutoColumns(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator GridAutoColumns(CSSProperties t) => new(0, value0: t);
            public static implicit operator GridAutoColumns(PropertySkip t) => new(1, value1: t);
            public static implicit operator GridAutoColumns(string t) => new(2, value2: t);
            public static implicit operator GridAutoColumns(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridAutoFlow : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private GridAutoFlow(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator GridAutoFlow(CSSProperties t) => new(0, value0: t);
            public static implicit operator GridAutoFlow(PropertySkip t) => new(1, value1: t);
            public static implicit operator GridAutoFlow(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridAutoRows : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private GridAutoRows(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator GridAutoRows(CSSProperties t) => new(0, value0: t);
            public static implicit operator GridAutoRows(PropertySkip t) => new(1, value1: t);
            public static implicit operator GridAutoRows(string t) => new(2, value2: t);
            public static implicit operator GridAutoRows(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridColumn : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private GridColumn(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator GridColumn(CSSProperties t) => new(0, value0: t);
            public static implicit operator GridColumn(PropertySkip t) => new(1, value1: t);
            public static implicit operator GridColumn(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridColumnEnd : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private GridColumnEnd(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator GridColumnEnd(CSSProperties t) => new(0, value0: t);
            public static implicit operator GridColumnEnd(PropertySkip t) => new(1, value1: t);
            public static implicit operator GridColumnEnd(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridColumnGap : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private GridColumnGap(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator GridColumnGap(CSSProperties t) => new(0, value0: t);
            public static implicit operator GridColumnGap(PropertySkip t) => new(1, value1: t);
            public static implicit operator GridColumnGap(string t) => new(2, value2: t);
            public static implicit operator GridColumnGap(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridColumnStart : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private GridColumnStart(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator GridColumnStart(CSSProperties t) => new(0, value0: t);
            public static implicit operator GridColumnStart(PropertySkip t) => new(1, value1: t);
            public static implicit operator GridColumnStart(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridGap : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private GridGap(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator GridGap(CSSProperties t) => new(0, value0: t);
            public static implicit operator GridGap(PropertySkip t) => new(1, value1: t);
            public static implicit operator GridGap(string t) => new(2, value2: t);
            public static implicit operator GridGap(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridRow : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private GridRow(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator GridRow(CSSProperties t) => new(0, value0: t);
            public static implicit operator GridRow(PropertySkip t) => new(1, value1: t);
            public static implicit operator GridRow(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridRowEnd : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private GridRowEnd(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator GridRowEnd(CSSProperties t) => new(0, value0: t);
            public static implicit operator GridRowEnd(PropertySkip t) => new(1, value1: t);
            public static implicit operator GridRowEnd(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridRowGap : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private GridRowGap(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator GridRowGap(CSSProperties t) => new(0, value0: t);
            public static implicit operator GridRowGap(PropertySkip t) => new(1, value1: t);
            public static implicit operator GridRowGap(string t) => new(2, value2: t);
            public static implicit operator GridRowGap(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridRowStart : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private GridRowStart(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator GridRowStart(CSSProperties t) => new(0, value0: t);
            public static implicit operator GridRowStart(PropertySkip t) => new(1, value1: t);
            public static implicit operator GridRowStart(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridTemplate : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private GridTemplate(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator GridTemplate(CSSProperties t) => new(0, value0: t);
            public static implicit operator GridTemplate(PropertySkip t) => new(1, value1: t);
            public static implicit operator GridTemplate(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridTemplateAreas : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private GridTemplateAreas(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator GridTemplateAreas(CSSProperties t) => new(0, value0: t);
            public static implicit operator GridTemplateAreas(PropertySkip t) => new(1, value1: t);
            public static implicit operator GridTemplateAreas(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridTemplateColumns : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private GridTemplateColumns(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator GridTemplateColumns(CSSProperties t) => new(0, value0: t);
            public static implicit operator GridTemplateColumns(PropertySkip t) => new(1, value1: t);
            public static implicit operator GridTemplateColumns(string t) => new(2, value2: t);
            public static implicit operator GridTemplateColumns(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GridTemplateRows : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private GridTemplateRows(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator GridTemplateRows(CSSProperties t) => new(0, value0: t);
            public static implicit operator GridTemplateRows(PropertySkip t) => new(1, value1: t);
            public static implicit operator GridTemplateRows(string t) => new(2, value2: t);
            public static implicit operator GridTemplateRows(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct HangingPunctuation : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private HangingPunctuation(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator HangingPunctuation(CSSProperties t) => new(0, value0: t);
            public static implicit operator HangingPunctuation(PropertySkip t) => new(1, value1: t);
            public static implicit operator HangingPunctuation(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Height : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private Height(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator Height(CSSProperties t) => new(0, value0: t);
            public static implicit operator Height(PropertySkip t) => new(1, value1: t);
            public static implicit operator Height(string t) => new(2, value2: t);
            public static implicit operator Height(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct HyphenateCharacter : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private HyphenateCharacter(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator HyphenateCharacter(CSSProperties t) => new(0, value0: t);
            public static implicit operator HyphenateCharacter(PropertySkip t) => new(1, value1: t);
            public static implicit operator HyphenateCharacter(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct HyphenateLimitChars : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private HyphenateLimitChars(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator HyphenateLimitChars(CSSProperties t) => new(0, value0: t);
            public static implicit operator HyphenateLimitChars(PropertySkip t) => new(1, value1: t);
            public static implicit operator HyphenateLimitChars(string t) => new(2, value2: t);
            public static implicit operator HyphenateLimitChars(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Hyphens : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Hyphens(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Hyphens(CSSProperties t) => new(0, value0: t);
            public static implicit operator Hyphens(PropertySkip t) => new(1, value1: t);
            public static implicit operator Hyphens(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ImageOrientation : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ImageOrientation(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ImageOrientation(CSSProperties t) => new(0, value0: t);
            public static implicit operator ImageOrientation(PropertySkip t) => new(1, value1: t);
            public static implicit operator ImageOrientation(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ImageRendering : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ImageRendering(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ImageRendering(CSSProperties t) => new(0, value0: t);
            public static implicit operator ImageRendering(PropertySkip t) => new(1, value1: t);
            public static implicit operator ImageRendering(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ImageResolution : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ImageResolution(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ImageResolution(CSSProperties t) => new(0, value0: t);
            public static implicit operator ImageResolution(PropertySkip t) => new(1, value1: t);
            public static implicit operator ImageResolution(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ImeMode : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ImeMode(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ImeMode(CSSProperties t) => new(0, value0: t);
            public static implicit operator ImeMode(PropertySkip t) => new(1, value1: t);
            public static implicit operator ImeMode(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InitialLetter : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private InitialLetter(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator InitialLetter(CSSProperties t) => new(0, value0: t);
            public static implicit operator InitialLetter(PropertySkip t) => new(1, value1: t);
            public static implicit operator InitialLetter(string t) => new(2, value2: t);
            public static implicit operator InitialLetter(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InlineSize : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private InlineSize(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator InlineSize(CSSProperties t) => new(0, value0: t);
            public static implicit operator InlineSize(PropertySkip t) => new(1, value1: t);
            public static implicit operator InlineSize(string t) => new(2, value2: t);
            public static implicit operator InlineSize(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InputSecurity : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private InputSecurity(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator InputSecurity(CSSProperties t) => new(0, value0: t);
            public static implicit operator InputSecurity(PropertySkip t) => new(1, value1: t);
            public static implicit operator InputSecurity(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Inset : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private Inset(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator Inset(CSSProperties t) => new(0, value0: t);
            public static implicit operator Inset(PropertySkip t) => new(1, value1: t);
            public static implicit operator Inset(string t) => new(2, value2: t);
            public static implicit operator Inset(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InsetBlock : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private InsetBlock(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator InsetBlock(CSSProperties t) => new(0, value0: t);
            public static implicit operator InsetBlock(PropertySkip t) => new(1, value1: t);
            public static implicit operator InsetBlock(string t) => new(2, value2: t);
            public static implicit operator InsetBlock(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InsetBlockEnd : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private InsetBlockEnd(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator InsetBlockEnd(CSSProperties t) => new(0, value0: t);
            public static implicit operator InsetBlockEnd(PropertySkip t) => new(1, value1: t);
            public static implicit operator InsetBlockEnd(string t) => new(2, value2: t);
            public static implicit operator InsetBlockEnd(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InsetBlockStart : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private InsetBlockStart(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator InsetBlockStart(CSSProperties t) => new(0, value0: t);
            public static implicit operator InsetBlockStart(PropertySkip t) => new(1, value1: t);
            public static implicit operator InsetBlockStart(string t) => new(2, value2: t);
            public static implicit operator InsetBlockStart(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InsetInline : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private InsetInline(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator InsetInline(CSSProperties t) => new(0, value0: t);
            public static implicit operator InsetInline(PropertySkip t) => new(1, value1: t);
            public static implicit operator InsetInline(string t) => new(2, value2: t);
            public static implicit operator InsetInline(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InsetInlineEnd : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private InsetInlineEnd(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator InsetInlineEnd(CSSProperties t) => new(0, value0: t);
            public static implicit operator InsetInlineEnd(PropertySkip t) => new(1, value1: t);
            public static implicit operator InsetInlineEnd(string t) => new(2, value2: t);
            public static implicit operator InsetInlineEnd(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct InsetInlineStart : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private InsetInlineStart(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator InsetInlineStart(CSSProperties t) => new(0, value0: t);
            public static implicit operator InsetInlineStart(PropertySkip t) => new(1, value1: t);
            public static implicit operator InsetInlineStart(string t) => new(2, value2: t);
            public static implicit operator InsetInlineStart(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Isolation : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Isolation(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Isolation(CSSProperties t) => new(0, value0: t);
            public static implicit operator Isolation(PropertySkip t) => new(1, value1: t);
            public static implicit operator Isolation(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct JustifyContent : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private JustifyContent(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator JustifyContent(CSSProperties t) => new(0, value0: t);
            public static implicit operator JustifyContent(PropertySkip t) => new(1, value1: t);
            public static implicit operator JustifyContent(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct JustifyItems : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private JustifyItems(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator JustifyItems(CSSProperties t) => new(0, value0: t);
            public static implicit operator JustifyItems(PropertySkip t) => new(1, value1: t);
            public static implicit operator JustifyItems(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct JustifySelf : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private JustifySelf(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator JustifySelf(CSSProperties t) => new(0, value0: t);
            public static implicit operator JustifySelf(PropertySkip t) => new(1, value1: t);
            public static implicit operator JustifySelf(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct JustifyTracks : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private JustifyTracks(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator JustifyTracks(CSSProperties t) => new(0, value0: t);
            public static implicit operator JustifyTracks(PropertySkip t) => new(1, value1: t);
            public static implicit operator JustifyTracks(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Left : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private Left(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator Left(CSSProperties t) => new(0, value0: t);
            public static implicit operator Left(PropertySkip t) => new(1, value1: t);
            public static implicit operator Left(string t) => new(2, value2: t);
            public static implicit operator Left(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct LetterSpacing : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private LetterSpacing(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator LetterSpacing(CSSProperties t) => new(0, value0: t);
            public static implicit operator LetterSpacing(PropertySkip t) => new(1, value1: t);
            public static implicit operator LetterSpacing(string t) => new(2, value2: t);
            public static implicit operator LetterSpacing(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct LineBreak : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private LineBreak(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator LineBreak(CSSProperties t) => new(0, value0: t);
            public static implicit operator LineBreak(PropertySkip t) => new(1, value1: t);
            public static implicit operator LineBreak(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct LineClamp : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private LineClamp(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator LineClamp(CSSProperties t) => new(0, value0: t);
            public static implicit operator LineClamp(PropertySkip t) => new(1, value1: t);
            public static implicit operator LineClamp(string t) => new(2, value2: t);
            public static implicit operator LineClamp(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct LineHeight : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private LineHeight(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator LineHeight(CSSProperties t) => new(0, value0: t);
            public static implicit operator LineHeight(PropertySkip t) => new(1, value1: t);
            public static implicit operator LineHeight(string t) => new(2, value2: t);
            public static implicit operator LineHeight(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct LineHeightStep : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private LineHeightStep(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator LineHeightStep(CSSProperties t) => new(0, value0: t);
            public static implicit operator LineHeightStep(PropertySkip t) => new(1, value1: t);
            public static implicit operator LineHeightStep(string t) => new(2, value2: t);
            public static implicit operator LineHeightStep(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ListStyle : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ListStyle(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ListStyle(CSSProperties t) => new(0, value0: t);
            public static implicit operator ListStyle(PropertySkip t) => new(1, value1: t);
            public static implicit operator ListStyle(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ListStyleImage : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ListStyleImage(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ListStyleImage(CSSProperties t) => new(0, value0: t);
            public static implicit operator ListStyleImage(PropertySkip t) => new(1, value1: t);
            public static implicit operator ListStyleImage(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ListStylePosition : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ListStylePosition(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ListStylePosition(CSSProperties t) => new(0, value0: t);
            public static implicit operator ListStylePosition(PropertySkip t) => new(1, value1: t);
            public static implicit operator ListStylePosition(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ListStyleType : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ListStyleType(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ListStyleType(CSSProperties t) => new(0, value0: t);
            public static implicit operator ListStyleType(PropertySkip t) => new(1, value1: t);
            public static implicit operator ListStyleType(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Margin : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private Margin(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator Margin(CSSProperties t) => new(0, value0: t);
            public static implicit operator Margin(PropertySkip t) => new(1, value1: t);
            public static implicit operator Margin(string t) => new(2, value2: t);
            public static implicit operator Margin(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginBlock : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MarginBlock(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MarginBlock(CSSProperties t) => new(0, value0: t);
            public static implicit operator MarginBlock(PropertySkip t) => new(1, value1: t);
            public static implicit operator MarginBlock(string t) => new(2, value2: t);
            public static implicit operator MarginBlock(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginBlockEnd : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MarginBlockEnd(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MarginBlockEnd(CSSProperties t) => new(0, value0: t);
            public static implicit operator MarginBlockEnd(PropertySkip t) => new(1, value1: t);
            public static implicit operator MarginBlockEnd(string t) => new(2, value2: t);
            public static implicit operator MarginBlockEnd(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginBlockStart : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MarginBlockStart(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MarginBlockStart(CSSProperties t) => new(0, value0: t);
            public static implicit operator MarginBlockStart(PropertySkip t) => new(1, value1: t);
            public static implicit operator MarginBlockStart(string t) => new(2, value2: t);
            public static implicit operator MarginBlockStart(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginBottom : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MarginBottom(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MarginBottom(CSSProperties t) => new(0, value0: t);
            public static implicit operator MarginBottom(PropertySkip t) => new(1, value1: t);
            public static implicit operator MarginBottom(string t) => new(2, value2: t);
            public static implicit operator MarginBottom(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginInline : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MarginInline(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MarginInline(CSSProperties t) => new(0, value0: t);
            public static implicit operator MarginInline(PropertySkip t) => new(1, value1: t);
            public static implicit operator MarginInline(string t) => new(2, value2: t);
            public static implicit operator MarginInline(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginInlineEnd : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MarginInlineEnd(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MarginInlineEnd(CSSProperties t) => new(0, value0: t);
            public static implicit operator MarginInlineEnd(PropertySkip t) => new(1, value1: t);
            public static implicit operator MarginInlineEnd(string t) => new(2, value2: t);
            public static implicit operator MarginInlineEnd(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginInlineStart : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MarginInlineStart(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MarginInlineStart(CSSProperties t) => new(0, value0: t);
            public static implicit operator MarginInlineStart(PropertySkip t) => new(1, value1: t);
            public static implicit operator MarginInlineStart(string t) => new(2, value2: t);
            public static implicit operator MarginInlineStart(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginLeft : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MarginLeft(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MarginLeft(CSSProperties t) => new(0, value0: t);
            public static implicit operator MarginLeft(PropertySkip t) => new(1, value1: t);
            public static implicit operator MarginLeft(string t) => new(2, value2: t);
            public static implicit operator MarginLeft(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginRight : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MarginRight(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MarginRight(CSSProperties t) => new(0, value0: t);
            public static implicit operator MarginRight(PropertySkip t) => new(1, value1: t);
            public static implicit operator MarginRight(string t) => new(2, value2: t);
            public static implicit operator MarginRight(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginTop : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MarginTop(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MarginTop(CSSProperties t) => new(0, value0: t);
            public static implicit operator MarginTop(PropertySkip t) => new(1, value1: t);
            public static implicit operator MarginTop(string t) => new(2, value2: t);
            public static implicit operator MarginTop(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarginTrim : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MarginTrim(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MarginTrim(CSSProperties t) => new(0, value0: t);
            public static implicit operator MarginTrim(PropertySkip t) => new(1, value1: t);
            public static implicit operator MarginTrim(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Mask : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private Mask(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator Mask(CSSProperties t) => new(0, value0: t);
            public static implicit operator Mask(PropertySkip t) => new(1, value1: t);
            public static implicit operator Mask(string t) => new(2, value2: t);
            public static implicit operator Mask(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskBorder : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MaskBorder(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MaskBorder(CSSProperties t) => new(0, value0: t);
            public static implicit operator MaskBorder(PropertySkip t) => new(1, value1: t);
            public static implicit operator MaskBorder(string t) => new(2, value2: t);
            public static implicit operator MaskBorder(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskBorderMode : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MaskBorderMode(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MaskBorderMode(CSSProperties t) => new(0, value0: t);
            public static implicit operator MaskBorderMode(PropertySkip t) => new(1, value1: t);
            public static implicit operator MaskBorderMode(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskBorderOutset : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MaskBorderOutset(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MaskBorderOutset(CSSProperties t) => new(0, value0: t);
            public static implicit operator MaskBorderOutset(PropertySkip t) => new(1, value1: t);
            public static implicit operator MaskBorderOutset(string t) => new(2, value2: t);
            public static implicit operator MaskBorderOutset(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskBorderRepeat : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MaskBorderRepeat(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MaskBorderRepeat(CSSProperties t) => new(0, value0: t);
            public static implicit operator MaskBorderRepeat(PropertySkip t) => new(1, value1: t);
            public static implicit operator MaskBorderRepeat(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskBorderSlice : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MaskBorderSlice(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MaskBorderSlice(CSSProperties t) => new(0, value0: t);
            public static implicit operator MaskBorderSlice(PropertySkip t) => new(1, value1: t);
            public static implicit operator MaskBorderSlice(string t) => new(2, value2: t);
            public static implicit operator MaskBorderSlice(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskBorderSource : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MaskBorderSource(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MaskBorderSource(CSSProperties t) => new(0, value0: t);
            public static implicit operator MaskBorderSource(PropertySkip t) => new(1, value1: t);
            public static implicit operator MaskBorderSource(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskBorderWidth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MaskBorderWidth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MaskBorderWidth(CSSProperties t) => new(0, value0: t);
            public static implicit operator MaskBorderWidth(PropertySkip t) => new(1, value1: t);
            public static implicit operator MaskBorderWidth(string t) => new(2, value2: t);
            public static implicit operator MaskBorderWidth(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskClip : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MaskClip(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MaskClip(CSSProperties t) => new(0, value0: t);
            public static implicit operator MaskClip(PropertySkip t) => new(1, value1: t);
            public static implicit operator MaskClip(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskComposite : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MaskComposite(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MaskComposite(CSSProperties t) => new(0, value0: t);
            public static implicit operator MaskComposite(PropertySkip t) => new(1, value1: t);
            public static implicit operator MaskComposite(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskImage : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MaskImage(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MaskImage(CSSProperties t) => new(0, value0: t);
            public static implicit operator MaskImage(PropertySkip t) => new(1, value1: t);
            public static implicit operator MaskImage(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskMode : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MaskMode(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MaskMode(CSSProperties t) => new(0, value0: t);
            public static implicit operator MaskMode(PropertySkip t) => new(1, value1: t);
            public static implicit operator MaskMode(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskOrigin : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MaskOrigin(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MaskOrigin(CSSProperties t) => new(0, value0: t);
            public static implicit operator MaskOrigin(PropertySkip t) => new(1, value1: t);
            public static implicit operator MaskOrigin(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskPosition : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MaskPosition(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MaskPosition(CSSProperties t) => new(0, value0: t);
            public static implicit operator MaskPosition(PropertySkip t) => new(1, value1: t);
            public static implicit operator MaskPosition(string t) => new(2, value2: t);
            public static implicit operator MaskPosition(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskRepeat : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MaskRepeat(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MaskRepeat(CSSProperties t) => new(0, value0: t);
            public static implicit operator MaskRepeat(PropertySkip t) => new(1, value1: t);
            public static implicit operator MaskRepeat(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskSize : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MaskSize(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MaskSize(CSSProperties t) => new(0, value0: t);
            public static implicit operator MaskSize(PropertySkip t) => new(1, value1: t);
            public static implicit operator MaskSize(string t) => new(2, value2: t);
            public static implicit operator MaskSize(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaskType : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MaskType(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MaskType(CSSProperties t) => new(0, value0: t);
            public static implicit operator MaskType(PropertySkip t) => new(1, value1: t);
            public static implicit operator MaskType(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MasonryAutoFlow : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MasonryAutoFlow(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MasonryAutoFlow(CSSProperties t) => new(0, value0: t);
            public static implicit operator MasonryAutoFlow(PropertySkip t) => new(1, value1: t);
            public static implicit operator MasonryAutoFlow(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MathDepth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MathDepth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MathDepth(CSSProperties t) => new(0, value0: t);
            public static implicit operator MathDepth(PropertySkip t) => new(1, value1: t);
            public static implicit operator MathDepth(string t) => new(2, value2: t);
            public static implicit operator MathDepth(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MathShift : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MathShift(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MathShift(CSSProperties t) => new(0, value0: t);
            public static implicit operator MathShift(PropertySkip t) => new(1, value1: t);
            public static implicit operator MathShift(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MathStyle : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MathStyle(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MathStyle(CSSProperties t) => new(0, value0: t);
            public static implicit operator MathStyle(PropertySkip t) => new(1, value1: t);
            public static implicit operator MathStyle(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaxBlockSize : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MaxBlockSize(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MaxBlockSize(CSSProperties t) => new(0, value0: t);
            public static implicit operator MaxBlockSize(PropertySkip t) => new(1, value1: t);
            public static implicit operator MaxBlockSize(string t) => new(2, value2: t);
            public static implicit operator MaxBlockSize(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaxHeight : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MaxHeight(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MaxHeight(CSSProperties t) => new(0, value0: t);
            public static implicit operator MaxHeight(PropertySkip t) => new(1, value1: t);
            public static implicit operator MaxHeight(string t) => new(2, value2: t);
            public static implicit operator MaxHeight(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaxInlineSize : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MaxInlineSize(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MaxInlineSize(CSSProperties t) => new(0, value0: t);
            public static implicit operator MaxInlineSize(PropertySkip t) => new(1, value1: t);
            public static implicit operator MaxInlineSize(string t) => new(2, value2: t);
            public static implicit operator MaxInlineSize(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaxLines : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MaxLines(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MaxLines(CSSProperties t) => new(0, value0: t);
            public static implicit operator MaxLines(PropertySkip t) => new(1, value1: t);
            public static implicit operator MaxLines(string t) => new(2, value2: t);
            public static implicit operator MaxLines(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MaxWidth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MaxWidth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MaxWidth(CSSProperties t) => new(0, value0: t);
            public static implicit operator MaxWidth(PropertySkip t) => new(1, value1: t);
            public static implicit operator MaxWidth(string t) => new(2, value2: t);
            public static implicit operator MaxWidth(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MinBlockSize : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MinBlockSize(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MinBlockSize(CSSProperties t) => new(0, value0: t);
            public static implicit operator MinBlockSize(PropertySkip t) => new(1, value1: t);
            public static implicit operator MinBlockSize(string t) => new(2, value2: t);
            public static implicit operator MinBlockSize(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MinHeight : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MinHeight(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MinHeight(CSSProperties t) => new(0, value0: t);
            public static implicit operator MinHeight(PropertySkip t) => new(1, value1: t);
            public static implicit operator MinHeight(string t) => new(2, value2: t);
            public static implicit operator MinHeight(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MinInlineSize : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MinInlineSize(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MinInlineSize(CSSProperties t) => new(0, value0: t);
            public static implicit operator MinInlineSize(PropertySkip t) => new(1, value1: t);
            public static implicit operator MinInlineSize(string t) => new(2, value2: t);
            public static implicit operator MinInlineSize(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MinWidth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MinWidth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MinWidth(CSSProperties t) => new(0, value0: t);
            public static implicit operator MinWidth(PropertySkip t) => new(1, value1: t);
            public static implicit operator MinWidth(string t) => new(2, value2: t);
            public static implicit operator MinWidth(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MixBlendMode : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MixBlendMode(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MixBlendMode(CSSProperties t) => new(0, value0: t);
            public static implicit operator MixBlendMode(PropertySkip t) => new(1, value1: t);
            public static implicit operator MixBlendMode(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Offset : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private Offset(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator Offset(CSSProperties t) => new(0, value0: t);
            public static implicit operator Offset(PropertySkip t) => new(1, value1: t);
            public static implicit operator Offset(string t) => new(2, value2: t);
            public static implicit operator Offset(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OffsetDistance : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private OffsetDistance(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator OffsetDistance(CSSProperties t) => new(0, value0: t);
            public static implicit operator OffsetDistance(PropertySkip t) => new(1, value1: t);
            public static implicit operator OffsetDistance(string t) => new(2, value2: t);
            public static implicit operator OffsetDistance(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OffsetPath : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private OffsetPath(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator OffsetPath(CSSProperties t) => new(0, value0: t);
            public static implicit operator OffsetPath(PropertySkip t) => new(1, value1: t);
            public static implicit operator OffsetPath(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OffsetRotate : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private OffsetRotate(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator OffsetRotate(CSSProperties t) => new(0, value0: t);
            public static implicit operator OffsetRotate(PropertySkip t) => new(1, value1: t);
            public static implicit operator OffsetRotate(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ObjectFit : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ObjectFit(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ObjectFit(CSSProperties t) => new(0, value0: t);
            public static implicit operator ObjectFit(PropertySkip t) => new(1, value1: t);
            public static implicit operator ObjectFit(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ObjectPosition : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ObjectPosition(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ObjectPosition(CSSProperties t) => new(0, value0: t);
            public static implicit operator ObjectPosition(PropertySkip t) => new(1, value1: t);
            public static implicit operator ObjectPosition(string t) => new(2, value2: t);
            public static implicit operator ObjectPosition(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OffsetAnchor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private OffsetAnchor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator OffsetAnchor(CSSProperties t) => new(0, value0: t);
            public static implicit operator OffsetAnchor(PropertySkip t) => new(1, value1: t);
            public static implicit operator OffsetAnchor(string t) => new(2, value2: t);
            public static implicit operator OffsetAnchor(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OffsetPosition : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private OffsetPosition(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator OffsetPosition(CSSProperties t) => new(0, value0: t);
            public static implicit operator OffsetPosition(PropertySkip t) => new(1, value1: t);
            public static implicit operator OffsetPosition(string t) => new(2, value2: t);
            public static implicit operator OffsetPosition(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Opacity : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private Opacity(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator Opacity(CSSProperties t) => new(0, value0: t);
            public static implicit operator Opacity(PropertySkip t) => new(1, value1: t);
            public static implicit operator Opacity(string t) => new(2, value2: t);
            public static implicit operator Opacity(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Order : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private Order(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator Order(CSSProperties t) => new(0, value0: t);
            public static implicit operator Order(PropertySkip t) => new(1, value1: t);
            public static implicit operator Order(string t) => new(2, value2: t);
            public static implicit operator Order(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Orphans : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private Orphans(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator Orphans(CSSProperties t) => new(0, value0: t);
            public static implicit operator Orphans(PropertySkip t) => new(1, value1: t);
            public static implicit operator Orphans(string t) => new(2, value2: t);
            public static implicit operator Orphans(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Outline : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private Outline(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator Outline(CSSProperties t) => new(0, value0: t);
            public static implicit operator Outline(PropertySkip t) => new(1, value1: t);
            public static implicit operator Outline(string t) => new(2, value2: t);
            public static implicit operator Outline(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OutlineColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private OutlineColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator OutlineColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator OutlineColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator OutlineColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OutlineOffset : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private OutlineOffset(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator OutlineOffset(CSSProperties t) => new(0, value0: t);
            public static implicit operator OutlineOffset(PropertySkip t) => new(1, value1: t);
            public static implicit operator OutlineOffset(string t) => new(2, value2: t);
            public static implicit operator OutlineOffset(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OutlineStyle : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private OutlineStyle(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator OutlineStyle(CSSProperties t) => new(0, value0: t);
            public static implicit operator OutlineStyle(PropertySkip t) => new(1, value1: t);
            public static implicit operator OutlineStyle(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OutlineWidth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private OutlineWidth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator OutlineWidth(CSSProperties t) => new(0, value0: t);
            public static implicit operator OutlineWidth(PropertySkip t) => new(1, value1: t);
            public static implicit operator OutlineWidth(string t) => new(2, value2: t);
            public static implicit operator OutlineWidth(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Overflow : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Overflow(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Overflow(CSSProperties t) => new(0, value0: t);
            public static implicit operator Overflow(PropertySkip t) => new(1, value1: t);
            public static implicit operator Overflow(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverflowAnchor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private OverflowAnchor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator OverflowAnchor(CSSProperties t) => new(0, value0: t);
            public static implicit operator OverflowAnchor(PropertySkip t) => new(1, value1: t);
            public static implicit operator OverflowAnchor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverflowBlock : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private OverflowBlock(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator OverflowBlock(CSSProperties t) => new(0, value0: t);
            public static implicit operator OverflowBlock(PropertySkip t) => new(1, value1: t);
            public static implicit operator OverflowBlock(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverflowClipBox : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private OverflowClipBox(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator OverflowClipBox(CSSProperties t) => new(0, value0: t);
            public static implicit operator OverflowClipBox(PropertySkip t) => new(1, value1: t);
            public static implicit operator OverflowClipBox(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverflowClipMargin : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private OverflowClipMargin(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator OverflowClipMargin(CSSProperties t) => new(0, value0: t);
            public static implicit operator OverflowClipMargin(PropertySkip t) => new(1, value1: t);
            public static implicit operator OverflowClipMargin(string t) => new(2, value2: t);
            public static implicit operator OverflowClipMargin(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverflowInline : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private OverflowInline(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator OverflowInline(CSSProperties t) => new(0, value0: t);
            public static implicit operator OverflowInline(PropertySkip t) => new(1, value1: t);
            public static implicit operator OverflowInline(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverflowWrap : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private OverflowWrap(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator OverflowWrap(CSSProperties t) => new(0, value0: t);
            public static implicit operator OverflowWrap(PropertySkip t) => new(1, value1: t);
            public static implicit operator OverflowWrap(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverflowX : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private OverflowX(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator OverflowX(CSSProperties t) => new(0, value0: t);
            public static implicit operator OverflowX(PropertySkip t) => new(1, value1: t);
            public static implicit operator OverflowX(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverflowY : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private OverflowY(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator OverflowY(CSSProperties t) => new(0, value0: t);
            public static implicit operator OverflowY(PropertySkip t) => new(1, value1: t);
            public static implicit operator OverflowY(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Overlay : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Overlay(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Overlay(CSSProperties t) => new(0, value0: t);
            public static implicit operator Overlay(PropertySkip t) => new(1, value1: t);
            public static implicit operator Overlay(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverscrollBehavior : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private OverscrollBehavior(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator OverscrollBehavior(CSSProperties t) => new(0, value0: t);
            public static implicit operator OverscrollBehavior(PropertySkip t) => new(1, value1: t);
            public static implicit operator OverscrollBehavior(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverscrollBehaviorBlock : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private OverscrollBehaviorBlock(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator OverscrollBehaviorBlock(CSSProperties t) => new(0, value0: t);
            public static implicit operator OverscrollBehaviorBlock(PropertySkip t) => new(1, value1: t);
            public static implicit operator OverscrollBehaviorBlock(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverscrollBehaviorInline : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private OverscrollBehaviorInline(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator OverscrollBehaviorInline(CSSProperties t) => new(0, value0: t);
            public static implicit operator OverscrollBehaviorInline(PropertySkip t) => new(1, value1: t);
            public static implicit operator OverscrollBehaviorInline(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverscrollBehaviorX : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private OverscrollBehaviorX(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator OverscrollBehaviorX(CSSProperties t) => new(0, value0: t);
            public static implicit operator OverscrollBehaviorX(PropertySkip t) => new(1, value1: t);
            public static implicit operator OverscrollBehaviorX(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct OverscrollBehaviorY : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private OverscrollBehaviorY(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator OverscrollBehaviorY(CSSProperties t) => new(0, value0: t);
            public static implicit operator OverscrollBehaviorY(PropertySkip t) => new(1, value1: t);
            public static implicit operator OverscrollBehaviorY(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Padding : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private Padding(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator Padding(CSSProperties t) => new(0, value0: t);
            public static implicit operator Padding(PropertySkip t) => new(1, value1: t);
            public static implicit operator Padding(string t) => new(2, value2: t);
            public static implicit operator Padding(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingBlock : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private PaddingBlock(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator PaddingBlock(CSSProperties t) => new(0, value0: t);
            public static implicit operator PaddingBlock(PropertySkip t) => new(1, value1: t);
            public static implicit operator PaddingBlock(string t) => new(2, value2: t);
            public static implicit operator PaddingBlock(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingBlockEnd : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private PaddingBlockEnd(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator PaddingBlockEnd(CSSProperties t) => new(0, value0: t);
            public static implicit operator PaddingBlockEnd(PropertySkip t) => new(1, value1: t);
            public static implicit operator PaddingBlockEnd(string t) => new(2, value2: t);
            public static implicit operator PaddingBlockEnd(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingBlockStart : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private PaddingBlockStart(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator PaddingBlockStart(CSSProperties t) => new(0, value0: t);
            public static implicit operator PaddingBlockStart(PropertySkip t) => new(1, value1: t);
            public static implicit operator PaddingBlockStart(string t) => new(2, value2: t);
            public static implicit operator PaddingBlockStart(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingBottom : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private PaddingBottom(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator PaddingBottom(CSSProperties t) => new(0, value0: t);
            public static implicit operator PaddingBottom(PropertySkip t) => new(1, value1: t);
            public static implicit operator PaddingBottom(string t) => new(2, value2: t);
            public static implicit operator PaddingBottom(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingInline : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private PaddingInline(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator PaddingInline(CSSProperties t) => new(0, value0: t);
            public static implicit operator PaddingInline(PropertySkip t) => new(1, value1: t);
            public static implicit operator PaddingInline(string t) => new(2, value2: t);
            public static implicit operator PaddingInline(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingInlineEnd : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private PaddingInlineEnd(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator PaddingInlineEnd(CSSProperties t) => new(0, value0: t);
            public static implicit operator PaddingInlineEnd(PropertySkip t) => new(1, value1: t);
            public static implicit operator PaddingInlineEnd(string t) => new(2, value2: t);
            public static implicit operator PaddingInlineEnd(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingInlineStart : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private PaddingInlineStart(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator PaddingInlineStart(CSSProperties t) => new(0, value0: t);
            public static implicit operator PaddingInlineStart(PropertySkip t) => new(1, value1: t);
            public static implicit operator PaddingInlineStart(string t) => new(2, value2: t);
            public static implicit operator PaddingInlineStart(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingLeft : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private PaddingLeft(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator PaddingLeft(CSSProperties t) => new(0, value0: t);
            public static implicit operator PaddingLeft(PropertySkip t) => new(1, value1: t);
            public static implicit operator PaddingLeft(string t) => new(2, value2: t);
            public static implicit operator PaddingLeft(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingRight : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private PaddingRight(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator PaddingRight(CSSProperties t) => new(0, value0: t);
            public static implicit operator PaddingRight(PropertySkip t) => new(1, value1: t);
            public static implicit operator PaddingRight(string t) => new(2, value2: t);
            public static implicit operator PaddingRight(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaddingTop : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private PaddingTop(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator PaddingTop(CSSProperties t) => new(0, value0: t);
            public static implicit operator PaddingTop(PropertySkip t) => new(1, value1: t);
            public static implicit operator PaddingTop(string t) => new(2, value2: t);
            public static implicit operator PaddingTop(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Page : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Page(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Page(CSSProperties t) => new(0, value0: t);
            public static implicit operator Page(PropertySkip t) => new(1, value1: t);
            public static implicit operator Page(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PageBreakAfter : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private PageBreakAfter(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator PageBreakAfter(CSSProperties t) => new(0, value0: t);
            public static implicit operator PageBreakAfter(PropertySkip t) => new(1, value1: t);
            public static implicit operator PageBreakAfter(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PageBreakBefore : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private PageBreakBefore(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator PageBreakBefore(CSSProperties t) => new(0, value0: t);
            public static implicit operator PageBreakBefore(PropertySkip t) => new(1, value1: t);
            public static implicit operator PageBreakBefore(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PageBreakInside : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private PageBreakInside(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator PageBreakInside(CSSProperties t) => new(0, value0: t);
            public static implicit operator PageBreakInside(PropertySkip t) => new(1, value1: t);
            public static implicit operator PageBreakInside(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PaintOrder : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private PaintOrder(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator PaintOrder(CSSProperties t) => new(0, value0: t);
            public static implicit operator PaintOrder(PropertySkip t) => new(1, value1: t);
            public static implicit operator PaintOrder(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Perspective : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private Perspective(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator Perspective(CSSProperties t) => new(0, value0: t);
            public static implicit operator Perspective(PropertySkip t) => new(1, value1: t);
            public static implicit operator Perspective(string t) => new(2, value2: t);
            public static implicit operator Perspective(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PerspectiveOrigin : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private PerspectiveOrigin(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator PerspectiveOrigin(CSSProperties t) => new(0, value0: t);
            public static implicit operator PerspectiveOrigin(PropertySkip t) => new(1, value1: t);
            public static implicit operator PerspectiveOrigin(string t) => new(2, value2: t);
            public static implicit operator PerspectiveOrigin(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PlaceContent : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private PlaceContent(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator PlaceContent(CSSProperties t) => new(0, value0: t);
            public static implicit operator PlaceContent(PropertySkip t) => new(1, value1: t);
            public static implicit operator PlaceContent(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PlaceItems : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private PlaceItems(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator PlaceItems(CSSProperties t) => new(0, value0: t);
            public static implicit operator PlaceItems(PropertySkip t) => new(1, value1: t);
            public static implicit operator PlaceItems(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PlaceSelf : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private PlaceSelf(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator PlaceSelf(CSSProperties t) => new(0, value0: t);
            public static implicit operator PlaceSelf(PropertySkip t) => new(1, value1: t);
            public static implicit operator PlaceSelf(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct PointerEvents : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private PointerEvents(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator PointerEvents(CSSProperties t) => new(0, value0: t);
            public static implicit operator PointerEvents(PropertySkip t) => new(1, value1: t);
            public static implicit operator PointerEvents(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Position : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Position(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Position(CSSProperties t) => new(0, value0: t);
            public static implicit operator Position(PropertySkip t) => new(1, value1: t);
            public static implicit operator Position(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Quotes : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Quotes(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Quotes(CSSProperties t) => new(0, value0: t);
            public static implicit operator Quotes(PropertySkip t) => new(1, value1: t);
            public static implicit operator Quotes(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Resize : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Resize(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Resize(CSSProperties t) => new(0, value0: t);
            public static implicit operator Resize(PropertySkip t) => new(1, value1: t);
            public static implicit operator Resize(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Right : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private Right(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator Right(CSSProperties t) => new(0, value0: t);
            public static implicit operator Right(PropertySkip t) => new(1, value1: t);
            public static implicit operator Right(string t) => new(2, value2: t);
            public static implicit operator Right(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Rotate : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Rotate(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Rotate(CSSProperties t) => new(0, value0: t);
            public static implicit operator Rotate(PropertySkip t) => new(1, value1: t);
            public static implicit operator Rotate(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct RowGap : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private RowGap(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator RowGap(CSSProperties t) => new(0, value0: t);
            public static implicit operator RowGap(PropertySkip t) => new(1, value1: t);
            public static implicit operator RowGap(string t) => new(2, value2: t);
            public static implicit operator RowGap(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct RubyAlign : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private RubyAlign(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator RubyAlign(CSSProperties t) => new(0, value0: t);
            public static implicit operator RubyAlign(PropertySkip t) => new(1, value1: t);
            public static implicit operator RubyAlign(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct RubyMerge : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private RubyMerge(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator RubyMerge(CSSProperties t) => new(0, value0: t);
            public static implicit operator RubyMerge(PropertySkip t) => new(1, value1: t);
            public static implicit operator RubyMerge(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct RubyPosition : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private RubyPosition(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator RubyPosition(CSSProperties t) => new(0, value0: t);
            public static implicit operator RubyPosition(PropertySkip t) => new(1, value1: t);
            public static implicit operator RubyPosition(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Scale : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private Scale(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator Scale(CSSProperties t) => new(0, value0: t);
            public static implicit operator Scale(PropertySkip t) => new(1, value1: t);
            public static implicit operator Scale(string t) => new(2, value2: t);
            public static implicit operator Scale(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollBehavior : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ScrollBehavior(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollBehavior(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollBehavior(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollBehavior(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMargin : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ScrollMargin(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ScrollMargin(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollMargin(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollMargin(string t) => new(2, value2: t);
            public static implicit operator ScrollMargin(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginBlock : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ScrollMarginBlock(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ScrollMarginBlock(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollMarginBlock(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollMarginBlock(string t) => new(2, value2: t);
            public static implicit operator ScrollMarginBlock(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginBlockEnd : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ScrollMarginBlockEnd(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ScrollMarginBlockEnd(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollMarginBlockEnd(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollMarginBlockEnd(string t) => new(2, value2: t);
            public static implicit operator ScrollMarginBlockEnd(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginBlockStart : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ScrollMarginBlockStart(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ScrollMarginBlockStart(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollMarginBlockStart(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollMarginBlockStart(string t) => new(2, value2: t);
            public static implicit operator ScrollMarginBlockStart(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginBottom : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ScrollMarginBottom(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ScrollMarginBottom(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollMarginBottom(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollMarginBottom(string t) => new(2, value2: t);
            public static implicit operator ScrollMarginBottom(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginInline : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ScrollMarginInline(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ScrollMarginInline(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollMarginInline(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollMarginInline(string t) => new(2, value2: t);
            public static implicit operator ScrollMarginInline(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginInlineEnd : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ScrollMarginInlineEnd(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ScrollMarginInlineEnd(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollMarginInlineEnd(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollMarginInlineEnd(string t) => new(2, value2: t);
            public static implicit operator ScrollMarginInlineEnd(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginInlineStart : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ScrollMarginInlineStart(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ScrollMarginInlineStart(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollMarginInlineStart(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollMarginInlineStart(string t) => new(2, value2: t);
            public static implicit operator ScrollMarginInlineStart(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginLeft : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ScrollMarginLeft(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ScrollMarginLeft(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollMarginLeft(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollMarginLeft(string t) => new(2, value2: t);
            public static implicit operator ScrollMarginLeft(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginRight : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ScrollMarginRight(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ScrollMarginRight(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollMarginRight(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollMarginRight(string t) => new(2, value2: t);
            public static implicit operator ScrollMarginRight(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollMarginTop : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ScrollMarginTop(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ScrollMarginTop(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollMarginTop(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollMarginTop(string t) => new(2, value2: t);
            public static implicit operator ScrollMarginTop(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPadding : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ScrollPadding(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ScrollPadding(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollPadding(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollPadding(string t) => new(2, value2: t);
            public static implicit operator ScrollPadding(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingBlock : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ScrollPaddingBlock(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ScrollPaddingBlock(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollPaddingBlock(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollPaddingBlock(string t) => new(2, value2: t);
            public static implicit operator ScrollPaddingBlock(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingBlockEnd : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ScrollPaddingBlockEnd(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ScrollPaddingBlockEnd(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollPaddingBlockEnd(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollPaddingBlockEnd(string t) => new(2, value2: t);
            public static implicit operator ScrollPaddingBlockEnd(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingBlockStart : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ScrollPaddingBlockStart(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ScrollPaddingBlockStart(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollPaddingBlockStart(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollPaddingBlockStart(string t) => new(2, value2: t);
            public static implicit operator ScrollPaddingBlockStart(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingBottom : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ScrollPaddingBottom(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ScrollPaddingBottom(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollPaddingBottom(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollPaddingBottom(string t) => new(2, value2: t);
            public static implicit operator ScrollPaddingBottom(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingInline : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ScrollPaddingInline(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ScrollPaddingInline(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollPaddingInline(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollPaddingInline(string t) => new(2, value2: t);
            public static implicit operator ScrollPaddingInline(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingInlineEnd : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ScrollPaddingInlineEnd(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ScrollPaddingInlineEnd(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollPaddingInlineEnd(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollPaddingInlineEnd(string t) => new(2, value2: t);
            public static implicit operator ScrollPaddingInlineEnd(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingInlineStart : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ScrollPaddingInlineStart(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ScrollPaddingInlineStart(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollPaddingInlineStart(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollPaddingInlineStart(string t) => new(2, value2: t);
            public static implicit operator ScrollPaddingInlineStart(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingLeft : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ScrollPaddingLeft(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ScrollPaddingLeft(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollPaddingLeft(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollPaddingLeft(string t) => new(2, value2: t);
            public static implicit operator ScrollPaddingLeft(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingRight : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ScrollPaddingRight(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ScrollPaddingRight(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollPaddingRight(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollPaddingRight(string t) => new(2, value2: t);
            public static implicit operator ScrollPaddingRight(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollPaddingTop : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ScrollPaddingTop(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ScrollPaddingTop(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollPaddingTop(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollPaddingTop(string t) => new(2, value2: t);
            public static implicit operator ScrollPaddingTop(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapAlign : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ScrollSnapAlign(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollSnapAlign(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollSnapAlign(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollSnapAlign(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapCoordinate : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ScrollSnapCoordinate(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ScrollSnapCoordinate(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollSnapCoordinate(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollSnapCoordinate(string t) => new(2, value2: t);
            public static implicit operator ScrollSnapCoordinate(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapDestination : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ScrollSnapDestination(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ScrollSnapDestination(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollSnapDestination(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollSnapDestination(string t) => new(2, value2: t);
            public static implicit operator ScrollSnapDestination(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapPointsX : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ScrollSnapPointsX(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollSnapPointsX(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollSnapPointsX(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollSnapPointsX(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapPointsY : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ScrollSnapPointsY(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollSnapPointsY(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollSnapPointsY(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollSnapPointsY(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapStop : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ScrollSnapStop(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollSnapStop(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollSnapStop(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollSnapStop(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapType : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ScrollSnapType(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollSnapType(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollSnapType(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollSnapType(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapTypeX : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ScrollSnapTypeX(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollSnapTypeX(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollSnapTypeX(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollSnapTypeX(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollSnapTypeY : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ScrollSnapTypeY(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollSnapTypeY(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollSnapTypeY(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollSnapTypeY(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollTimeline : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ScrollTimeline(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollTimeline(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollTimeline(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollTimeline(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollTimelineAxis : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ScrollTimelineAxis(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollTimelineAxis(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollTimelineAxis(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollTimelineAxis(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollTimelineName : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ScrollTimelineName(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollTimelineName(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollTimelineName(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollTimelineName(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollbarColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ScrollbarColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollbarColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollbarColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollbarColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollbarGutter : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ScrollbarGutter(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollbarGutter(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollbarGutter(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollbarGutter(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ScrollbarWidth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ScrollbarWidth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ScrollbarWidth(CSSProperties t) => new(0, value0: t);
            public static implicit operator ScrollbarWidth(PropertySkip t) => new(1, value1: t);
            public static implicit operator ScrollbarWidth(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ShapeImageThreshold : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ShapeImageThreshold(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ShapeImageThreshold(CSSProperties t) => new(0, value0: t);
            public static implicit operator ShapeImageThreshold(PropertySkip t) => new(1, value1: t);
            public static implicit operator ShapeImageThreshold(string t) => new(2, value2: t);
            public static implicit operator ShapeImageThreshold(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ShapeMargin : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ShapeMargin(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ShapeMargin(CSSProperties t) => new(0, value0: t);
            public static implicit operator ShapeMargin(PropertySkip t) => new(1, value1: t);
            public static implicit operator ShapeMargin(string t) => new(2, value2: t);
            public static implicit operator ShapeMargin(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ShapeOutside : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ShapeOutside(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ShapeOutside(CSSProperties t) => new(0, value0: t);
            public static implicit operator ShapeOutside(PropertySkip t) => new(1, value1: t);
            public static implicit operator ShapeOutside(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TabSize : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private TabSize(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator TabSize(CSSProperties t) => new(0, value0: t);
            public static implicit operator TabSize(PropertySkip t) => new(1, value1: t);
            public static implicit operator TabSize(string t) => new(2, value2: t);
            public static implicit operator TabSize(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TableLayout : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TableLayout(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TableLayout(CSSProperties t) => new(0, value0: t);
            public static implicit operator TableLayout(PropertySkip t) => new(1, value1: t);
            public static implicit operator TableLayout(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextAlign : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TextAlign(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextAlign(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextAlign(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextAlign(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextAlignLast : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TextAlignLast(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextAlignLast(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextAlignLast(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextAlignLast(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextCombineUpright : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TextCombineUpright(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextCombineUpright(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextCombineUpright(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextCombineUpright(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextDecoration : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private TextDecoration(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator TextDecoration(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextDecoration(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextDecoration(string t) => new(2, value2: t);
            public static implicit operator TextDecoration(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextDecorationColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TextDecorationColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextDecorationColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextDecorationColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextDecorationColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextDecorationLine : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TextDecorationLine(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextDecorationLine(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextDecorationLine(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextDecorationLine(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextDecorationSkip : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TextDecorationSkip(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextDecorationSkip(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextDecorationSkip(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextDecorationSkip(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextDecorationSkipInk : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TextDecorationSkipInk(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextDecorationSkipInk(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextDecorationSkipInk(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextDecorationSkipInk(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextDecorationStyle : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TextDecorationStyle(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextDecorationStyle(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextDecorationStyle(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextDecorationStyle(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextDecorationThickness : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private TextDecorationThickness(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator TextDecorationThickness(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextDecorationThickness(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextDecorationThickness(string t) => new(2, value2: t);
            public static implicit operator TextDecorationThickness(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextEmphasis : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TextEmphasis(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextEmphasis(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextEmphasis(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextEmphasis(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextEmphasisColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TextEmphasisColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextEmphasisColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextEmphasisColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextEmphasisColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextEmphasisPosition : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TextEmphasisPosition(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextEmphasisPosition(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextEmphasisPosition(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextEmphasisPosition(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextEmphasisStyle : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TextEmphasisStyle(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextEmphasisStyle(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextEmphasisStyle(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextEmphasisStyle(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextIndent : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private TextIndent(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator TextIndent(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextIndent(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextIndent(string t) => new(2, value2: t);
            public static implicit operator TextIndent(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextJustify : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TextJustify(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextJustify(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextJustify(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextJustify(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextOrientation : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TextOrientation(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextOrientation(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextOrientation(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextOrientation(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextOverflow : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TextOverflow(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextOverflow(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextOverflow(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextOverflow(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextRendering : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TextRendering(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextRendering(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextRendering(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextRendering(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextShadow : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TextShadow(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextShadow(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextShadow(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextShadow(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextSizeAdjust : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TextSizeAdjust(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextSizeAdjust(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextSizeAdjust(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextSizeAdjust(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextTransform : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TextTransform(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextTransform(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextTransform(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextTransform(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextUnderlineOffset : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private TextUnderlineOffset(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator TextUnderlineOffset(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextUnderlineOffset(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextUnderlineOffset(string t) => new(2, value2: t);
            public static implicit operator TextUnderlineOffset(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextUnderlinePosition : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TextUnderlinePosition(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextUnderlinePosition(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextUnderlinePosition(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextUnderlinePosition(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextWrap : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TextWrap(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextWrap(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextWrap(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextWrap(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TimelineScope : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TimelineScope(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TimelineScope(CSSProperties t) => new(0, value0: t);
            public static implicit operator TimelineScope(PropertySkip t) => new(1, value1: t);
            public static implicit operator TimelineScope(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Top : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private Top(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator Top(CSSProperties t) => new(0, value0: t);
            public static implicit operator Top(PropertySkip t) => new(1, value1: t);
            public static implicit operator Top(string t) => new(2, value2: t);
            public static implicit operator Top(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TouchAction : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TouchAction(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TouchAction(CSSProperties t) => new(0, value0: t);
            public static implicit operator TouchAction(PropertySkip t) => new(1, value1: t);
            public static implicit operator TouchAction(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Transform : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Transform(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Transform(CSSProperties t) => new(0, value0: t);
            public static implicit operator Transform(PropertySkip t) => new(1, value1: t);
            public static implicit operator Transform(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TransformBox : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TransformBox(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TransformBox(CSSProperties t) => new(0, value0: t);
            public static implicit operator TransformBox(PropertySkip t) => new(1, value1: t);
            public static implicit operator TransformBox(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TransformOrigin : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private TransformOrigin(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator TransformOrigin(CSSProperties t) => new(0, value0: t);
            public static implicit operator TransformOrigin(PropertySkip t) => new(1, value1: t);
            public static implicit operator TransformOrigin(string t) => new(2, value2: t);
            public static implicit operator TransformOrigin(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TransformStyle : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TransformStyle(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TransformStyle(CSSProperties t) => new(0, value0: t);
            public static implicit operator TransformStyle(PropertySkip t) => new(1, value1: t);
            public static implicit operator TransformStyle(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Transition : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Transition(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Transition(CSSProperties t) => new(0, value0: t);
            public static implicit operator Transition(PropertySkip t) => new(1, value1: t);
            public static implicit operator Transition(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TransitionBehavior : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TransitionBehavior(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TransitionBehavior(CSSProperties t) => new(0, value0: t);
            public static implicit operator TransitionBehavior(PropertySkip t) => new(1, value1: t);
            public static implicit operator TransitionBehavior(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TransitionDelay : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TransitionDelay(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TransitionDelay(CSSProperties t) => new(0, value0: t);
            public static implicit operator TransitionDelay(PropertySkip t) => new(1, value1: t);
            public static implicit operator TransitionDelay(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TransitionDuration : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TransitionDuration(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TransitionDuration(CSSProperties t) => new(0, value0: t);
            public static implicit operator TransitionDuration(PropertySkip t) => new(1, value1: t);
            public static implicit operator TransitionDuration(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TransitionProperty : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TransitionProperty(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TransitionProperty(CSSProperties t) => new(0, value0: t);
            public static implicit operator TransitionProperty(PropertySkip t) => new(1, value1: t);
            public static implicit operator TransitionProperty(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TransitionTimingFunction : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TransitionTimingFunction(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TransitionTimingFunction(CSSProperties t) => new(0, value0: t);
            public static implicit operator TransitionTimingFunction(PropertySkip t) => new(1, value1: t);
            public static implicit operator TransitionTimingFunction(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Translate : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private Translate(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator Translate(CSSProperties t) => new(0, value0: t);
            public static implicit operator Translate(PropertySkip t) => new(1, value1: t);
            public static implicit operator Translate(string t) => new(2, value2: t);
            public static implicit operator Translate(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct UnicodeBidi : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private UnicodeBidi(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator UnicodeBidi(CSSProperties t) => new(0, value0: t);
            public static implicit operator UnicodeBidi(PropertySkip t) => new(1, value1: t);
            public static implicit operator UnicodeBidi(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct UserSelect : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private UserSelect(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator UserSelect(CSSProperties t) => new(0, value0: t);
            public static implicit operator UserSelect(PropertySkip t) => new(1, value1: t);
            public static implicit operator UserSelect(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct VerticalAlign : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private VerticalAlign(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator VerticalAlign(CSSProperties t) => new(0, value0: t);
            public static implicit operator VerticalAlign(PropertySkip t) => new(1, value1: t);
            public static implicit operator VerticalAlign(string t) => new(2, value2: t);
            public static implicit operator VerticalAlign(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ViewTimeline : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ViewTimeline(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ViewTimeline(CSSProperties t) => new(0, value0: t);
            public static implicit operator ViewTimeline(PropertySkip t) => new(1, value1: t);
            public static implicit operator ViewTimeline(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ViewTimelineAxis : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ViewTimelineAxis(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ViewTimelineAxis(CSSProperties t) => new(0, value0: t);
            public static implicit operator ViewTimelineAxis(PropertySkip t) => new(1, value1: t);
            public static implicit operator ViewTimelineAxis(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ViewTimelineInset : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ViewTimelineInset(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ViewTimelineInset(CSSProperties t) => new(0, value0: t);
            public static implicit operator ViewTimelineInset(PropertySkip t) => new(1, value1: t);
            public static implicit operator ViewTimelineInset(string t) => new(2, value2: t);
            public static implicit operator ViewTimelineInset(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ViewTimelineName : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ViewTimelineName(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ViewTimelineName(CSSProperties t) => new(0, value0: t);
            public static implicit operator ViewTimelineName(PropertySkip t) => new(1, value1: t);
            public static implicit operator ViewTimelineName(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ViewTransitionName : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ViewTransitionName(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ViewTransitionName(CSSProperties t) => new(0, value0: t);
            public static implicit operator ViewTransitionName(PropertySkip t) => new(1, value1: t);
            public static implicit operator ViewTransitionName(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Visibility : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Visibility(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Visibility(CSSProperties t) => new(0, value0: t);
            public static implicit operator Visibility(PropertySkip t) => new(1, value1: t);
            public static implicit operator Visibility(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WhiteSpace : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private WhiteSpace(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WhiteSpace(CSSProperties t) => new(0, value0: t);
            public static implicit operator WhiteSpace(PropertySkip t) => new(1, value1: t);
            public static implicit operator WhiteSpace(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WhiteSpaceCollapse : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private WhiteSpaceCollapse(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WhiteSpaceCollapse(CSSProperties t) => new(0, value0: t);
            public static implicit operator WhiteSpaceCollapse(PropertySkip t) => new(1, value1: t);
            public static implicit operator WhiteSpaceCollapse(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WhiteSpaceTrim : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private WhiteSpaceTrim(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WhiteSpaceTrim(CSSProperties t) => new(0, value0: t);
            public static implicit operator WhiteSpaceTrim(PropertySkip t) => new(1, value1: t);
            public static implicit operator WhiteSpaceTrim(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Widows : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private Widows(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator Widows(CSSProperties t) => new(0, value0: t);
            public static implicit operator Widows(PropertySkip t) => new(1, value1: t);
            public static implicit operator Widows(string t) => new(2, value2: t);
            public static implicit operator Widows(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Width : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private Width(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator Width(CSSProperties t) => new(0, value0: t);
            public static implicit operator Width(PropertySkip t) => new(1, value1: t);
            public static implicit operator Width(string t) => new(2, value2: t);
            public static implicit operator Width(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WillChange : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private WillChange(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WillChange(CSSProperties t) => new(0, value0: t);
            public static implicit operator WillChange(PropertySkip t) => new(1, value1: t);
            public static implicit operator WillChange(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WordBreak : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private WordBreak(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WordBreak(CSSProperties t) => new(0, value0: t);
            public static implicit operator WordBreak(PropertySkip t) => new(1, value1: t);
            public static implicit operator WordBreak(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WordSpacing : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private WordSpacing(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator WordSpacing(CSSProperties t) => new(0, value0: t);
            public static implicit operator WordSpacing(PropertySkip t) => new(1, value1: t);
            public static implicit operator WordSpacing(string t) => new(2, value2: t);
            public static implicit operator WordSpacing(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WordWrap : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private WordWrap(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WordWrap(CSSProperties t) => new(0, value0: t);
            public static implicit operator WordWrap(PropertySkip t) => new(1, value1: t);
            public static implicit operator WordWrap(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WritingMode : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private WritingMode(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WritingMode(CSSProperties t) => new(0, value0: t);
            public static implicit operator WritingMode(PropertySkip t) => new(1, value1: t);
            public static implicit operator WritingMode(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ZIndex : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private ZIndex(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator ZIndex(CSSProperties t) => new(0, value0: t);
            public static implicit operator ZIndex(PropertySkip t) => new(1, value1: t);
            public static implicit operator ZIndex(string t) => new(2, value2: t);
            public static implicit operator ZIndex(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Zoom : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private Zoom(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator Zoom(CSSProperties t) => new(0, value0: t);
            public static implicit operator Zoom(PropertySkip t) => new(1, value1: t);
            public static implicit operator Zoom(string t) => new(2, value2: t);
            public static implicit operator Zoom(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozAppearance : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MozAppearance(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MozAppearance(CSSProperties t) => new(0, value0: t);
            public static implicit operator MozAppearance(PropertySkip t) => new(1, value1: t);
            public static implicit operator MozAppearance(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozBinding : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MozBinding(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MozBinding(CSSProperties t) => new(0, value0: t);
            public static implicit operator MozBinding(PropertySkip t) => new(1, value1: t);
            public static implicit operator MozBinding(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozBorderBottomColors : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MozBorderBottomColors(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MozBorderBottomColors(CSSProperties t) => new(0, value0: t);
            public static implicit operator MozBorderBottomColors(PropertySkip t) => new(1, value1: t);
            public static implicit operator MozBorderBottomColors(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozBorderLeftColors : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MozBorderLeftColors(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MozBorderLeftColors(CSSProperties t) => new(0, value0: t);
            public static implicit operator MozBorderLeftColors(PropertySkip t) => new(1, value1: t);
            public static implicit operator MozBorderLeftColors(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozBorderRightColors : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MozBorderRightColors(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MozBorderRightColors(CSSProperties t) => new(0, value0: t);
            public static implicit operator MozBorderRightColors(PropertySkip t) => new(1, value1: t);
            public static implicit operator MozBorderRightColors(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozBorderTopColors : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MozBorderTopColors(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MozBorderTopColors(CSSProperties t) => new(0, value0: t);
            public static implicit operator MozBorderTopColors(PropertySkip t) => new(1, value1: t);
            public static implicit operator MozBorderTopColors(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozContextProperties : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MozContextProperties(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MozContextProperties(CSSProperties t) => new(0, value0: t);
            public static implicit operator MozContextProperties(PropertySkip t) => new(1, value1: t);
            public static implicit operator MozContextProperties(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozFloatEdge : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MozFloatEdge(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MozFloatEdge(CSSProperties t) => new(0, value0: t);
            public static implicit operator MozFloatEdge(PropertySkip t) => new(1, value1: t);
            public static implicit operator MozFloatEdge(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozForceBrokenImageIcon : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MozForceBrokenImageIcon(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MozForceBrokenImageIcon(CSSProperties t) => new(0, value0: t);
            public static implicit operator MozForceBrokenImageIcon(PropertySkip t) => new(1, value1: t);
            public static implicit operator MozForceBrokenImageIcon(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozImageRegion : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MozImageRegion(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MozImageRegion(CSSProperties t) => new(0, value0: t);
            public static implicit operator MozImageRegion(PropertySkip t) => new(1, value1: t);
            public static implicit operator MozImageRegion(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozOrient : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MozOrient(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MozOrient(CSSProperties t) => new(0, value0: t);
            public static implicit operator MozOrient(PropertySkip t) => new(1, value1: t);
            public static implicit operator MozOrient(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozOutlineRadius : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MozOutlineRadius(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MozOutlineRadius(CSSProperties t) => new(0, value0: t);
            public static implicit operator MozOutlineRadius(PropertySkip t) => new(1, value1: t);
            public static implicit operator MozOutlineRadius(string t) => new(2, value2: t);
            public static implicit operator MozOutlineRadius(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozOutlineRadiusBottomleft : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MozOutlineRadiusBottomleft(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MozOutlineRadiusBottomleft(CSSProperties t) => new(0, value0: t);
            public static implicit operator MozOutlineRadiusBottomleft(PropertySkip t) => new(1, value1: t);
            public static implicit operator MozOutlineRadiusBottomleft(string t) => new(2, value2: t);
            public static implicit operator MozOutlineRadiusBottomleft(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozOutlineRadiusBottomright : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MozOutlineRadiusBottomright(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MozOutlineRadiusBottomright(CSSProperties t) => new(0, value0: t);
            public static implicit operator MozOutlineRadiusBottomright(PropertySkip t) => new(1, value1: t);
            public static implicit operator MozOutlineRadiusBottomright(string t) => new(2, value2: t);
            public static implicit operator MozOutlineRadiusBottomright(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozOutlineRadiusTopleft : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MozOutlineRadiusTopleft(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MozOutlineRadiusTopleft(CSSProperties t) => new(0, value0: t);
            public static implicit operator MozOutlineRadiusTopleft(PropertySkip t) => new(1, value1: t);
            public static implicit operator MozOutlineRadiusTopleft(string t) => new(2, value2: t);
            public static implicit operator MozOutlineRadiusTopleft(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozOutlineRadiusTopright : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MozOutlineRadiusTopright(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MozOutlineRadiusTopright(CSSProperties t) => new(0, value0: t);
            public static implicit operator MozOutlineRadiusTopright(PropertySkip t) => new(1, value1: t);
            public static implicit operator MozOutlineRadiusTopright(string t) => new(2, value2: t);
            public static implicit operator MozOutlineRadiusTopright(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozStackSizing : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MozStackSizing(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MozStackSizing(CSSProperties t) => new(0, value0: t);
            public static implicit operator MozStackSizing(PropertySkip t) => new(1, value1: t);
            public static implicit operator MozStackSizing(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozTextBlink : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MozTextBlink(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MozTextBlink(CSSProperties t) => new(0, value0: t);
            public static implicit operator MozTextBlink(PropertySkip t) => new(1, value1: t);
            public static implicit operator MozTextBlink(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozUserFocus : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MozUserFocus(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MozUserFocus(CSSProperties t) => new(0, value0: t);
            public static implicit operator MozUserFocus(PropertySkip t) => new(1, value1: t);
            public static implicit operator MozUserFocus(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozUserInput : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MozUserInput(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MozUserInput(CSSProperties t) => new(0, value0: t);
            public static implicit operator MozUserInput(PropertySkip t) => new(1, value1: t);
            public static implicit operator MozUserInput(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozUserModify : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MozUserModify(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MozUserModify(CSSProperties t) => new(0, value0: t);
            public static implicit operator MozUserModify(PropertySkip t) => new(1, value1: t);
            public static implicit operator MozUserModify(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozWindowDragging : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MozWindowDragging(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MozWindowDragging(CSSProperties t) => new(0, value0: t);
            public static implicit operator MozWindowDragging(PropertySkip t) => new(1, value1: t);
            public static implicit operator MozWindowDragging(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MozWindowShadow : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MozWindowShadow(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MozWindowShadow(CSSProperties t) => new(0, value0: t);
            public static implicit operator MozWindowShadow(PropertySkip t) => new(1, value1: t);
            public static implicit operator MozWindowShadow(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsAccelerator : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsAccelerator(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsAccelerator(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsAccelerator(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsAccelerator(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsBlockProgression : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsBlockProgression(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsBlockProgression(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsBlockProgression(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsBlockProgression(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsContentZoomChaining : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsContentZoomChaining(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsContentZoomChaining(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsContentZoomChaining(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsContentZoomChaining(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsContentZoomLimit : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsContentZoomLimit(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsContentZoomLimit(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsContentZoomLimit(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsContentZoomLimit(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsContentZoomLimitMax : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsContentZoomLimitMax(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsContentZoomLimitMax(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsContentZoomLimitMax(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsContentZoomLimitMax(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsContentZoomLimitMin : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsContentZoomLimitMin(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsContentZoomLimitMin(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsContentZoomLimitMin(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsContentZoomLimitMin(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsContentZoomSnap : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsContentZoomSnap(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsContentZoomSnap(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsContentZoomSnap(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsContentZoomSnap(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsContentZoomSnapPoints : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsContentZoomSnapPoints(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsContentZoomSnapPoints(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsContentZoomSnapPoints(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsContentZoomSnapPoints(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsContentZoomSnapType : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsContentZoomSnapType(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsContentZoomSnapType(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsContentZoomSnapType(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsContentZoomSnapType(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsContentZooming : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsContentZooming(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsContentZooming(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsContentZooming(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsContentZooming(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsFilter : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsFilter(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsFilter(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsFilter(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsFilter(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsFlowFrom : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsFlowFrom(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsFlowFrom(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsFlowFrom(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsFlowFrom(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsFlowInto : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsFlowInto(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsFlowInto(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsFlowInto(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsFlowInto(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsGridColumns : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MsGridColumns(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MsGridColumns(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsGridColumns(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsGridColumns(string t) => new(2, value2: t);
            public static implicit operator MsGridColumns(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsGridRows : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MsGridRows(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MsGridRows(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsGridRows(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsGridRows(string t) => new(2, value2: t);
            public static implicit operator MsGridRows(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsHighContrastAdjust : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsHighContrastAdjust(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsHighContrastAdjust(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsHighContrastAdjust(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsHighContrastAdjust(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsHyphenateLimitChars : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MsHyphenateLimitChars(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MsHyphenateLimitChars(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsHyphenateLimitChars(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsHyphenateLimitChars(string t) => new(2, value2: t);
            public static implicit operator MsHyphenateLimitChars(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsHyphenateLimitLines : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MsHyphenateLimitLines(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MsHyphenateLimitLines(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsHyphenateLimitLines(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsHyphenateLimitLines(string t) => new(2, value2: t);
            public static implicit operator MsHyphenateLimitLines(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsHyphenateLimitZone : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MsHyphenateLimitZone(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MsHyphenateLimitZone(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsHyphenateLimitZone(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsHyphenateLimitZone(string t) => new(2, value2: t);
            public static implicit operator MsHyphenateLimitZone(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsImeAlign : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsImeAlign(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsImeAlign(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsImeAlign(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsImeAlign(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsOverflowStyle : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsOverflowStyle(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsOverflowStyle(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsOverflowStyle(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsOverflowStyle(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollChaining : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsScrollChaining(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsScrollChaining(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsScrollChaining(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsScrollChaining(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollLimit : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsScrollLimit(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsScrollLimit(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsScrollLimit(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsScrollLimit(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollLimitXMax : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MsScrollLimitXMax(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MsScrollLimitXMax(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsScrollLimitXMax(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsScrollLimitXMax(string t) => new(2, value2: t);
            public static implicit operator MsScrollLimitXMax(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollLimitXMin : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MsScrollLimitXMin(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MsScrollLimitXMin(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsScrollLimitXMin(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsScrollLimitXMin(string t) => new(2, value2: t);
            public static implicit operator MsScrollLimitXMin(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollLimitYMax : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MsScrollLimitYMax(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MsScrollLimitYMax(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsScrollLimitYMax(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsScrollLimitYMax(string t) => new(2, value2: t);
            public static implicit operator MsScrollLimitYMax(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollLimitYMin : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MsScrollLimitYMin(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MsScrollLimitYMin(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsScrollLimitYMin(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsScrollLimitYMin(string t) => new(2, value2: t);
            public static implicit operator MsScrollLimitYMin(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollRails : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsScrollRails(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsScrollRails(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsScrollRails(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsScrollRails(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollSnapPointsX : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsScrollSnapPointsX(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsScrollSnapPointsX(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsScrollSnapPointsX(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsScrollSnapPointsX(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollSnapPointsY : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsScrollSnapPointsY(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsScrollSnapPointsY(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsScrollSnapPointsY(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsScrollSnapPointsY(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollSnapType : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsScrollSnapType(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsScrollSnapType(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsScrollSnapType(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsScrollSnapType(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollSnapX : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsScrollSnapX(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsScrollSnapX(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsScrollSnapX(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsScrollSnapX(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollSnapY : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsScrollSnapY(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsScrollSnapY(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsScrollSnapY(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsScrollSnapY(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollTranslation : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsScrollTranslation(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsScrollTranslation(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsScrollTranslation(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsScrollTranslation(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollbar3dlightColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsScrollbar3dlightColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsScrollbar3dlightColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsScrollbar3dlightColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsScrollbar3dlightColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollbarArrowColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsScrollbarArrowColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsScrollbarArrowColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsScrollbarArrowColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsScrollbarArrowColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollbarBaseColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsScrollbarBaseColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsScrollbarBaseColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsScrollbarBaseColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsScrollbarBaseColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollbarDarkshadowColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsScrollbarDarkshadowColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsScrollbarDarkshadowColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsScrollbarDarkshadowColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsScrollbarDarkshadowColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollbarFaceColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsScrollbarFaceColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsScrollbarFaceColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsScrollbarFaceColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsScrollbarFaceColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollbarHighlightColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsScrollbarHighlightColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsScrollbarHighlightColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsScrollbarHighlightColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsScrollbarHighlightColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollbarShadowColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsScrollbarShadowColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsScrollbarShadowColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsScrollbarShadowColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsScrollbarShadowColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsScrollbarTrackColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsScrollbarTrackColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsScrollbarTrackColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsScrollbarTrackColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsScrollbarTrackColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsTextAutospace : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsTextAutospace(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsTextAutospace(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsTextAutospace(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsTextAutospace(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsTouchSelect : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsTouchSelect(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsTouchSelect(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsTouchSelect(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsTouchSelect(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsUserSelect : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsUserSelect(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsUserSelect(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsUserSelect(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsUserSelect(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsWrapFlow : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsWrapFlow(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsWrapFlow(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsWrapFlow(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsWrapFlow(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsWrapMargin : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private MsWrapMargin(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator MsWrapMargin(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsWrapMargin(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsWrapMargin(string t) => new(2, value2: t);
            public static implicit operator MsWrapMargin(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MsWrapThrough : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MsWrapThrough(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MsWrapThrough(CSSProperties t) => new(0, value0: t);
            public static implicit operator MsWrapThrough(PropertySkip t) => new(1, value1: t);
            public static implicit operator MsWrapThrough(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitAppearance : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private WebkitAppearance(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitAppearance(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitAppearance(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitAppearance(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitBorderBefore : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private WebkitBorderBefore(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator WebkitBorderBefore(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitBorderBefore(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitBorderBefore(string t) => new(2, value2: t);
            public static implicit operator WebkitBorderBefore(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitBorderBeforeColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private WebkitBorderBeforeColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitBorderBeforeColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitBorderBeforeColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitBorderBeforeColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitBorderBeforeStyle : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private WebkitBorderBeforeStyle(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitBorderBeforeStyle(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitBorderBeforeStyle(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitBorderBeforeStyle(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitBorderBeforeWidth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private WebkitBorderBeforeWidth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator WebkitBorderBeforeWidth(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitBorderBeforeWidth(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitBorderBeforeWidth(string t) => new(2, value2: t);
            public static implicit operator WebkitBorderBeforeWidth(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitBoxReflect : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private WebkitBoxReflect(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator WebkitBoxReflect(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitBoxReflect(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitBoxReflect(string t) => new(2, value2: t);
            public static implicit operator WebkitBoxReflect(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitLineClamp : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private WebkitLineClamp(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator WebkitLineClamp(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitLineClamp(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitLineClamp(string t) => new(2, value2: t);
            public static implicit operator WebkitLineClamp(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMask : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private WebkitMask(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator WebkitMask(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitMask(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitMask(string t) => new(2, value2: t);
            public static implicit operator WebkitMask(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskAttachment : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private WebkitMaskAttachment(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitMaskAttachment(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitMaskAttachment(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitMaskAttachment(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskClip : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private WebkitMaskClip(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitMaskClip(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitMaskClip(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitMaskClip(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskComposite : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private WebkitMaskComposite(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitMaskComposite(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitMaskComposite(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitMaskComposite(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskImage : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private WebkitMaskImage(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitMaskImage(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitMaskImage(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitMaskImage(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskOrigin : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private WebkitMaskOrigin(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitMaskOrigin(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitMaskOrigin(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitMaskOrigin(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskPosition : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private WebkitMaskPosition(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator WebkitMaskPosition(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitMaskPosition(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitMaskPosition(string t) => new(2, value2: t);
            public static implicit operator WebkitMaskPosition(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskPositionX : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private WebkitMaskPositionX(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator WebkitMaskPositionX(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitMaskPositionX(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitMaskPositionX(string t) => new(2, value2: t);
            public static implicit operator WebkitMaskPositionX(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskPositionY : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private WebkitMaskPositionY(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator WebkitMaskPositionY(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitMaskPositionY(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitMaskPositionY(string t) => new(2, value2: t);
            public static implicit operator WebkitMaskPositionY(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskRepeat : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private WebkitMaskRepeat(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitMaskRepeat(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitMaskRepeat(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitMaskRepeat(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskRepeatX : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private WebkitMaskRepeatX(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitMaskRepeatX(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitMaskRepeatX(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitMaskRepeatX(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskRepeatY : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private WebkitMaskRepeatY(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitMaskRepeatY(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitMaskRepeatY(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitMaskRepeatY(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitMaskSize : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private WebkitMaskSize(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator WebkitMaskSize(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitMaskSize(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitMaskSize(string t) => new(2, value2: t);
            public static implicit operator WebkitMaskSize(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitOverflowScrolling : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private WebkitOverflowScrolling(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitOverflowScrolling(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitOverflowScrolling(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitOverflowScrolling(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitTapHighlightColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private WebkitTapHighlightColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitTapHighlightColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitTapHighlightColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitTapHighlightColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitTextFillColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private WebkitTextFillColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitTextFillColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitTextFillColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitTextFillColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitTextStroke : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private WebkitTextStroke(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator WebkitTextStroke(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitTextStroke(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitTextStroke(string t) => new(2, value2: t);
            public static implicit operator WebkitTextStroke(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitTextStrokeColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private WebkitTextStrokeColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitTextStrokeColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitTextStrokeColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitTextStrokeColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitTextStrokeWidth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private WebkitTextStrokeWidth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator WebkitTextStrokeWidth(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitTextStrokeWidth(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitTextStrokeWidth(string t) => new(2, value2: t);
            public static implicit operator WebkitTextStrokeWidth(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitTouchCallout : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private WebkitTouchCallout(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitTouchCallout(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitTouchCallout(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitTouchCallout(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct WebkitUserModify : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private WebkitUserModify(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator WebkitUserModify(CSSProperties t) => new(0, value0: t);
            public static implicit operator WebkitUserModify(PropertySkip t) => new(1, value1: t);
            public static implicit operator WebkitUserModify(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct AlignmentBaseline : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private AlignmentBaseline(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator AlignmentBaseline(CSSProperties t) => new(0, value0: t);
            public static implicit operator AlignmentBaseline(PropertySkip t) => new(1, value1: t);
            public static implicit operator AlignmentBaseline(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct BaselineShift : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private BaselineShift(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator BaselineShift(CSSProperties t) => new(0, value0: t);
            public static implicit operator BaselineShift(PropertySkip t) => new(1, value1: t);
            public static implicit operator BaselineShift(string t) => new(2, value2: t);
            public static implicit operator BaselineShift(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ClipRule : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ClipRule(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ClipRule(CSSProperties t) => new(0, value0: t);
            public static implicit operator ClipRule(PropertySkip t) => new(1, value1: t);
            public static implicit operator ClipRule(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColorInterpolation : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ColorInterpolation(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ColorInterpolation(CSSProperties t) => new(0, value0: t);
            public static implicit operator ColorInterpolation(PropertySkip t) => new(1, value1: t);
            public static implicit operator ColorInterpolation(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ColorRendering : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ColorRendering(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ColorRendering(CSSProperties t) => new(0, value0: t);
            public static implicit operator ColorRendering(PropertySkip t) => new(1, value1: t);
            public static implicit operator ColorRendering(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct DominantBaseline : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private DominantBaseline(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator DominantBaseline(CSSProperties t) => new(0, value0: t);
            public static implicit operator DominantBaseline(PropertySkip t) => new(1, value1: t);
            public static implicit operator DominantBaseline(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Fill : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Fill(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Fill(CSSProperties t) => new(0, value0: t);
            public static implicit operator Fill(PropertySkip t) => new(1, value1: t);
            public static implicit operator Fill(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FillOpacity : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private FillOpacity(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator FillOpacity(CSSProperties t) => new(0, value0: t);
            public static implicit operator FillOpacity(PropertySkip t) => new(1, value1: t);
            public static implicit operator FillOpacity(string t) => new(2, value2: t);
            public static implicit operator FillOpacity(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FillRule : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FillRule(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FillRule(CSSProperties t) => new(0, value0: t);
            public static implicit operator FillRule(PropertySkip t) => new(1, value1: t);
            public static implicit operator FillRule(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FloodColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private FloodColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator FloodColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator FloodColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator FloodColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct FloodOpacity : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private FloodOpacity(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator FloodOpacity(CSSProperties t) => new(0, value0: t);
            public static implicit operator FloodOpacity(PropertySkip t) => new(1, value1: t);
            public static implicit operator FloodOpacity(string t) => new(2, value2: t);
            public static implicit operator FloodOpacity(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct GlyphOrientationVertical : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private GlyphOrientationVertical(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator GlyphOrientationVertical(CSSProperties t) => new(0, value0: t);
            public static implicit operator GlyphOrientationVertical(PropertySkip t) => new(1, value1: t);
            public static implicit operator GlyphOrientationVertical(string t) => new(2, value2: t);
            public static implicit operator GlyphOrientationVertical(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct LightingColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private LightingColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator LightingColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator LightingColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator LightingColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Marker : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Marker(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Marker(CSSProperties t) => new(0, value0: t);
            public static implicit operator Marker(PropertySkip t) => new(1, value1: t);
            public static implicit operator Marker(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarkerEnd : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MarkerEnd(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MarkerEnd(CSSProperties t) => new(0, value0: t);
            public static implicit operator MarkerEnd(PropertySkip t) => new(1, value1: t);
            public static implicit operator MarkerEnd(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarkerMid : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MarkerMid(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MarkerMid(CSSProperties t) => new(0, value0: t);
            public static implicit operator MarkerMid(PropertySkip t) => new(1, value1: t);
            public static implicit operator MarkerMid(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct MarkerStart : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private MarkerStart(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator MarkerStart(CSSProperties t) => new(0, value0: t);
            public static implicit operator MarkerStart(PropertySkip t) => new(1, value1: t);
            public static implicit operator MarkerStart(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct ShapeRendering : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private ShapeRendering(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator ShapeRendering(CSSProperties t) => new(0, value0: t);
            public static implicit operator ShapeRendering(PropertySkip t) => new(1, value1: t);
            public static implicit operator ShapeRendering(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StopColor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private StopColor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator StopColor(CSSProperties t) => new(0, value0: t);
            public static implicit operator StopColor(PropertySkip t) => new(1, value1: t);
            public static implicit operator StopColor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StopOpacity : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private StopOpacity(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator StopOpacity(CSSProperties t) => new(0, value0: t);
            public static implicit operator StopOpacity(PropertySkip t) => new(1, value1: t);
            public static implicit operator StopOpacity(string t) => new(2, value2: t);
            public static implicit operator StopOpacity(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct Stroke : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private Stroke(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator Stroke(CSSProperties t) => new(0, value0: t);
            public static implicit operator Stroke(PropertySkip t) => new(1, value1: t);
            public static implicit operator Stroke(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StrokeDasharray : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private StrokeDasharray(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator StrokeDasharray(CSSProperties t) => new(0, value0: t);
            public static implicit operator StrokeDasharray(PropertySkip t) => new(1, value1: t);
            public static implicit operator StrokeDasharray(string t) => new(2, value2: t);
            public static implicit operator StrokeDasharray(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StrokeDashoffset : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private StrokeDashoffset(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator StrokeDashoffset(CSSProperties t) => new(0, value0: t);
            public static implicit operator StrokeDashoffset(PropertySkip t) => new(1, value1: t);
            public static implicit operator StrokeDashoffset(string t) => new(2, value2: t);
            public static implicit operator StrokeDashoffset(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StrokeLinecap : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private StrokeLinecap(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator StrokeLinecap(CSSProperties t) => new(0, value0: t);
            public static implicit operator StrokeLinecap(PropertySkip t) => new(1, value1: t);
            public static implicit operator StrokeLinecap(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StrokeLinejoin : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private StrokeLinejoin(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator StrokeLinejoin(CSSProperties t) => new(0, value0: t);
            public static implicit operator StrokeLinejoin(PropertySkip t) => new(1, value1: t);
            public static implicit operator StrokeLinejoin(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StrokeMiterlimit : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private StrokeMiterlimit(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator StrokeMiterlimit(CSSProperties t) => new(0, value0: t);
            public static implicit operator StrokeMiterlimit(PropertySkip t) => new(1, value1: t);
            public static implicit operator StrokeMiterlimit(string t) => new(2, value2: t);
            public static implicit operator StrokeMiterlimit(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StrokeOpacity : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private StrokeOpacity(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator StrokeOpacity(CSSProperties t) => new(0, value0: t);
            public static implicit operator StrokeOpacity(PropertySkip t) => new(1, value1: t);
            public static implicit operator StrokeOpacity(string t) => new(2, value2: t);
            public static implicit operator StrokeOpacity(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct StrokeWidth : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;
            private readonly double _value3;

            private StrokeWidth(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default, double value3 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
                _value3 = value3;
            }

            public static implicit operator StrokeWidth(CSSProperties t) => new(0, value0: t);
            public static implicit operator StrokeWidth(PropertySkip t) => new(1, value1: t);
            public static implicit operator StrokeWidth(string t) => new(2, value2: t);
            public static implicit operator StrokeWidth(double t) => new(3, value3: t);

            public string GetValue(string key)
            {
                return _index switch
                {
                    0 => FormatValue(key, _value0),
                    1 => FormatValue(key, _value1),
                    2 => FormatValue(key, _value2),
                    3 => FormatValue(key, _value3),
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    3 => _value3,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct TextAnchor : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private TextAnchor(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator TextAnchor(CSSProperties t) => new(0, value0: t);
            public static implicit operator TextAnchor(PropertySkip t) => new(1, value1: t);
            public static implicit operator TextAnchor(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }

        public readonly struct VectorEffect : IProperty
        {
            private readonly int _index;
            private readonly CSSProperties _value0;
            private readonly PropertySkip _value1;
            private readonly string _value2;

            private VectorEffect(int index, CSSProperties value0 = default, PropertySkip value1 = default, string value2 = default)
            {
                _index = index;
                _value0 = value0;
                _value1 = value1;
                _value2 = value2;
            }

            public static implicit operator VectorEffect(CSSProperties t) => new(0, value0: t);
            public static implicit operator VectorEffect(PropertySkip t) => new(1, value1: t);
            public static implicit operator VectorEffect(string t) => new(2, value2: t);

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

            public object GetValue()
            {
                return _index switch
                {
                    0 => _value0,
                    1 => _value1,
                    2 => _value2,
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }
}
}
