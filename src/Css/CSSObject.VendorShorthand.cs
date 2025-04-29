namespace CssInCSharp
{
    public partial class CSSObject
    {
        /// <summary>
        /// The **`animation`** shorthand CSS property applies an animation between styles. It is a shorthand for `animation-name`, `animation-duration`, `animation-timing-function`, `animation-delay`, `animation-iteration-count`, `animation-direction`, `animation-fill-mode`, and `animation-play-state`.
        /// <para> **Syntax**: `&lt;single-animation&gt;#`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozAnimation
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-animation"];
            set => _properties["-moz-animation"] = value;
        }

        /// <summary>
        /// The **`border-image`** CSS property draws an image around a given element. It replaces the element's regular border.
        /// <para> **Syntax**: `&lt;'border-image-source'&gt; || &lt;'border-image-slice'&gt; [ / &lt;'border-image-width'&gt; | / &lt;'border-image-width'&gt;? / &lt;'border-image-outset'&gt; ]? || &lt;'border-image-repeat'&gt;`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MozBorderImage
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-border-image"];
            set => _properties["-moz-border-image"] = value;
        }

        /// <summary>
        /// The **`column-rule`** shorthand CSS property sets the width, style, and color of the line drawn between columns in a multi-column layout.
        /// <para> **Syntax**: `&lt;'column-rule-width'&gt; || &lt;'column-rule-style'&gt; || &lt;'column-rule-color'&gt;`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MozColumnRule
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-column-rule"];
            set => _properties["-moz-column-rule"] = value;
        }

        /// <summary>
        /// The **`columns`** CSS shorthand property sets the number of columns to use when drawing an element's contents, as well as those columns' widths.
        /// <para> **Syntax**: `&lt;'column-width'&gt; || &lt;'column-count'&gt;`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MozColumns
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-columns"];
            set => _properties["-moz-columns"] = value;
        }

        /// <summary>
        /// In Mozilla applications like Firefox, the **`-moz-outline-radius`** CSS shorthand property can be used to give an element's `outline` rounded corners.
        /// <para> **Syntax**: `&lt;outline-radius&gt;{1,4} [ / &lt;outline-radius&gt;{1,4} ]?`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MozOutlineRadius
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-outline-radius"];
            set => _properties["-moz-outline-radius"] = value;
        }

        /// <summary>
        /// The **`-ms-content-zoom-limit`** CSS shorthand property is a Microsoft extension that specifies values for the `-ms-content-zoom-limit-min` and `-ms-content-zoom-limit-max` properties.
        /// <para> **Syntax**: `&lt;'-ms-content-zoom-limit-min'&gt; &lt;'-ms-content-zoom-limit-max'&gt;`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsContentZoomLimit
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-content-zoom-limit"];
            set => _properties["-ms-content-zoom-limit"] = value;
        }

        /// <summary>
        /// The **`-ms-content-zoom-snap`** CSS shorthand property is a Microsoft extension that specifies values for the `-ms-content-zoom-snap-type` and `-ms-content-zoom-snap-points` properties.
        /// <para> **Syntax**: `&lt;'-ms-content-zoom-snap-type'&gt; || &lt;'-ms-content-zoom-snap-points'&gt;`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsContentZoomSnap
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-content-zoom-snap"];
            set => _properties["-ms-content-zoom-snap"] = value;
        }

        /// <summary>
        /// The **`flex`** CSS shorthand property sets how a flex _item_ will grow or shrink to fit the space available in its flex container.
        /// <para> **Syntax**: `none | [ &lt;'flex-grow'&gt; &lt;'flex-shrink'&gt;? || &lt;'flex-basis'&gt; ]`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MsFlex
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-ms-flex"];
            set => _properties["-ms-flex"] = value;
        }

        /// <summary>
        /// The **\-ms-scroll-limit** CSS property is a Microsoft extension that specifies values for the `-ms-scroll-limit-x-min`, `-ms-scroll-limit-y-min`, `-ms-scroll-limit-x-max`, and `-ms-scroll-limit-y-max` properties.
        /// <para> **Syntax**: `&lt;'-ms-scroll-limit-x-min'&gt; &lt;'-ms-scroll-limit-y-min'&gt; &lt;'-ms-scroll-limit-x-max'&gt; &lt;'-ms-scroll-limit-y-max'&gt;`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsScrollLimit
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-scroll-limit"];
            set => _properties["-ms-scroll-limit"] = value;
        }

        /// <summary>
        /// The **`-ms-scroll-snap-x`** CSS shorthand property is a Microsoft extension that specifies values for the `-ms-scroll-snap-type` and `-ms-scroll-snap-points-x` properties.
        /// <para> **Syntax**: `&lt;'-ms-scroll-snap-type'&gt; &lt;'-ms-scroll-snap-points-x'&gt;`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsScrollSnapX
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-scroll-snap-x"];
            set => _properties["-ms-scroll-snap-x"] = value;
        }

        /// <summary>
        /// The **`-ms-scroll-snap-x`** CSS shorthand property is a Microsoft extension that specifies values for the `-ms-scroll-snap-type` and `-ms-scroll-snap-points-y` properties.
        /// <para> **Syntax**: `&lt;'-ms-scroll-snap-type'&gt; &lt;'-ms-scroll-snap-points-y'&gt;`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsScrollSnapY
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-scroll-snap-y"];
            set => _properties["-ms-scroll-snap-y"] = value;
        }

        /// <summary>
        /// The **`transition`** CSS property is a shorthand property for `transition-property`, `transition-duration`, `transition-timing-function`, and `transition-delay`.
        /// <para> **Syntax**: `&lt;single-transition&gt;#`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsTransition
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-transition"];
            set => _properties["-ms-transition"] = value;
        }

        /// <summary>
        /// The **`animation`** shorthand CSS property applies an animation between styles. It is a shorthand for `animation-name`, `animation-duration`, `animation-timing-function`, `animation-delay`, `animation-iteration-count`, `animation-direction`, `animation-fill-mode`, and `animation-play-state`.
        /// <para> **Syntax**: `&lt;single-animation&gt;#`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitAnimation
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-animation"];
            set => _properties["-webkit-animation"] = value;
        }

        /// <summary>
        /// The **`-webkit-border-before`** CSS property is a shorthand property for setting the individual logical block start border property values in a single place in the style sheet.
        /// <para> **Syntax**: `&lt;'border-width'&gt; || &lt;'border-style'&gt; || &lt;color&gt;`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitBorderBefore
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-border-before"];
            set => _properties["-webkit-border-before"] = value;
        }

        /// <summary>
        /// The **`border-image`** CSS property draws an image around a given element. It replaces the element's regular border.
        /// <para> **Syntax**: `&lt;'border-image-source'&gt; || &lt;'border-image-slice'&gt; [ / &lt;'border-image-width'&gt; | / &lt;'border-image-width'&gt;? / &lt;'border-image-outset'&gt; ]? || &lt;'border-image-repeat'&gt;`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitBorderImage
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-border-image"];
            set => _properties["-webkit-border-image"] = value;
        }

        /// <summary>
        /// The **`border-radius`** CSS property rounds the corners of an element's outer border edge. You can set a single radius to make circular corners, or two radii to make elliptical corners.
        /// <para> **Syntax**: `&lt;length-percentage&gt;{1,4} [ / &lt;length-percentage&gt;{1,4} ]?`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitBorderRadius
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-border-radius"];
            set => _properties["-webkit-border-radius"] = value;
        }

        /// <summary>
        /// The **`column-rule`** shorthand CSS property sets the width, style, and color of the line drawn between columns in a multi-column layout.
        /// <para> **Syntax**: `&lt;'column-rule-width'&gt; || &lt;'column-rule-style'&gt; || &lt;'column-rule-color'&gt;`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitColumnRule
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-column-rule"];
            set => _properties["-webkit-column-rule"] = value;
        }

        /// <summary>
        /// The **`columns`** CSS shorthand property sets the number of columns to use when drawing an element's contents, as well as those columns' widths.
        /// <para> **Syntax**: `&lt;'column-width'&gt; || &lt;'column-count'&gt;`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitColumns
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-columns"];
            set => _properties["-webkit-columns"] = value;
        }

        /// <summary>
        /// The **`flex`** CSS shorthand property sets how a flex _item_ will grow or shrink to fit the space available in its flex container.
        /// <para> **Syntax**: `none | [ &lt;'flex-grow'&gt; &lt;'flex-shrink'&gt;? || &lt;'flex-basis'&gt; ]`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitFlex
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-flex"];
            set => _properties["-webkit-flex"] = value;
        }

        /// <summary>
        /// The **`flex-flow`** CSS shorthand property specifies the direction of a flex container, as well as its wrapping behavior.
        /// <para> **Syntax**: `&lt;'flex-direction'&gt; || &lt;'flex-wrap'&gt;`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitFlexFlow
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-flex-flow"];
            set => _properties["-webkit-flex-flow"] = value;
        }

        /// <summary>
        /// The **`mask`** CSS shorthand property hides an element (partially or fully) by masking or clipping the image at specific points.
        /// <para> **Syntax**: `[ &lt;mask-reference&gt; || &lt;position&gt; [ / &lt;bg-size&gt; ]? || &lt;repeat-style&gt; || [ &lt;box&gt; | border | padding | content | text ] || [ &lt;box&gt; | border | padding | content ] ]#`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitMask
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-mask"];
            set => _properties["-webkit-mask"] = value;
        }

        /// <summary>
        /// The **`mask-border`** CSS shorthand property lets you create a mask along the edge of an element's border.
        /// <para> **Syntax**: `&lt;'mask-border-source'&gt; || &lt;'mask-border-slice'&gt; [ / &lt;'mask-border-width'&gt;? [ / &lt;'mask-border-outset'&gt; ]? ]? || &lt;'mask-border-repeat'&gt; || &lt;'mask-border-mode'&gt;`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitMaskBoxImage
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-mask-box-image"];
            set => _properties["-webkit-mask-box-image"] = value;
        }

        /// <summary>
        /// The **`text-emphasis`** CSS property applies emphasis marks to text (except spaces and control characters). It is a shorthand for `text-emphasis-style` and `text-emphasis-color`.
        /// <para> **Syntax**: `&lt;'text-emphasis-style'&gt; || &lt;'text-emphasis-color'&gt;`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitTextEmphasis
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-text-emphasis"];
            set => _properties["-webkit-text-emphasis"] = value;
        }

        /// <summary>
        /// The **`-webkit-text-stroke`** CSS property specifies the width and color of strokes for text characters. This is a shorthand property for the longhand properties `-webkit-text-stroke-width` and `-webkit-text-stroke-color`.
        /// <para> **Syntax**: `&lt;length&gt; || &lt;color&gt;`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitTextStroke
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-text-stroke"];
            set => _properties["-webkit-text-stroke"] = value;
        }

        /// <summary>
        /// The **`transition`** CSS property is a shorthand property for `transition-property`, `transition-duration`, `transition-timing-function`, and `transition-delay`.
        /// <para> **Syntax**: `&lt;single-transition&gt;#`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitTransition
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-transition"];
            set => _properties["-webkit-transition"] = value;
        }

    }
}
