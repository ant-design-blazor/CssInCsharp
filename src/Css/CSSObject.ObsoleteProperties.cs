using System;

namespace CssInCSharp
{
    public partial class CSSObject
    {
        /// <summary>
        /// In combination with `elevation`, the **`azimuth`** CSS property enables different audio sources to be positioned spatially for aural presentation. This is important in that it provides a natural way to tell several voices apart, as each can be positioned to originate at a different location on the sound stage. Stereo output produce a lateral sound stage, while binaural headphones and multi-speaker setups allow for a fully three-dimensional stage.
        /// <para> **Syntax**: `&lt;angle&gt; | [ [ left-side | far-left | left | center-left | center | center-right | right | far-right | right-side ] || behind ] | leftwards | rightwards`</para>
        /// <para> **Initial value**: `center`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> Azimuth
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["azimuth"];
            set => _properties["azimuth"] = value;
        }

        /// <summary>
        /// The **`box-align`** CSS property specifies how an element aligns its contents across its layout in a perpendicular direction. The effect of the property is only visible if there is extra space in the box.
        /// <para> **Syntax**: `start | center | end | baseline | stretch`</para>
        /// <para> **Initial value**: `stretch`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> BoxAlign
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["box-align"];
            set => _properties["box-align"] = value;
        }

        /// <summary>
        /// The **`box-direction`** CSS property specifies whether a box lays out its contents normally (from the top or left edge), or in reverse (from the bottom or right edge).
        /// <para> **Syntax**: `normal | reverse | inherit`</para>
        /// <para> **Initial value**: `normal`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> BoxDirection
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["box-direction"];
            set => _properties["box-direction"] = value;
        }

        /// <summary>
        /// The **`-moz-box-flex`** and **`-webkit-box-flex`** CSS properties specify how a `-moz-box` or `-webkit-box` grows to fill the box that contains it, in the direction of the containing box's layout.
        /// <para> **Syntax**: `&lt;number&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> BoxFlex
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["box-flex"];
            set => _properties["box-flex"] = value;
        }

        /// <summary>
        /// The **`box-flex-group`** CSS property assigns the flexbox's child elements to a flex group.
        /// <para> **Syntax**: `&lt;integer&gt;`</para>
        /// <para> **Initial value**: `1`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> BoxFlexGroup
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["box-flex-group"];
            set => _properties["box-flex-group"] = value;
        }

        /// <summary>
        /// The **`box-lines`** CSS property determines whether the box may have a single or multiple lines (rows for horizontally oriented boxes, columns for vertically oriented boxes).
        /// <para> **Syntax**: `single | multiple`</para>
        /// <para> **Initial value**: `single`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> BoxLines
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["box-lines"];
            set => _properties["box-lines"] = value;
        }

        /// <summary>
        /// The **`box-ordinal-group`** CSS property assigns the flexbox's child elements to an ordinal group.
        /// <para> **Syntax**: `&lt;integer&gt;`</para>
        /// <para> **Initial value**: `1`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> BoxOrdinalGroup
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["box-ordinal-group"];
            set => _properties["box-ordinal-group"] = value;
        }

        /// <summary>
        /// The **`box-orient`** CSS property sets whether an element lays out its contents horizontally or vertically.
        /// <para> **Syntax**: `horizontal | vertical | inline-axis | block-axis | inherit`</para>
        /// <para> **Initial value**: `inline-axis` (`horizontal` in XUL)</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> BoxOrient
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["box-orient"];
            set => _properties["box-orient"] = value;
        }

        /// <summary>
        /// The **`-moz-box-pack`** and **`-webkit-box-pack`** CSS properties specify how a `-moz-box` or `-webkit-box` packs its contents in the direction of its layout. The effect of this is only visible if there is extra space in the box.
        /// <para> **Syntax**: `start | center | end | justify`</para>
        /// <para> **Initial value**: `start`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> BoxPack
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["box-pack"];
            set => _properties["box-pack"] = value;
        }

        /// <summary>
        /// The **`clip`** CSS property defines a visible portion of an element. The `clip` property applies only to absolutely positioned elements — that is, elements with `position:absolute` or `position:fixed`.
        /// <para> **Syntax**: `&lt;shape&gt; | auto`</para>
        /// <para> **Initial value**: `auto`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> Clip
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["clip"];
            set => _properties["clip"] = value;
        }

        /// <summary>
        /// The **`column-gap`** CSS property sets the size of the gap (gutter) between an element's columns.
        /// <para> **Syntax**: `&lt;length-percentage&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> GridColumnGap
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["grid-column-gap"];
            set => _properties["grid-column-gap"] = value;
        }

        /// <summary>
        /// The **`gap`** CSS property sets the gaps (gutters) between rows and columns. It is a shorthand for `row-gap` and `column-gap`.
        /// <para> **Syntax**: `&lt;'grid-row-gap'&gt; &lt;'grid-column-gap'&gt;?`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> GridGap
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["grid-gap"];
            set => _properties["grid-gap"] = value;
        }

        /// <summary>
        /// The **`row-gap`** CSS property sets the size of the gap (gutter) between an element's rows.
        /// <para> **Syntax**: `&lt;length-percentage&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> GridRowGap
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["grid-row-gap"];
            set => _properties["grid-row-gap"] = value;
        }

        /// <summary>
        /// The **`ime-mode`** CSS property controls the state of the input method editor (IME) for text fields. This property is obsolete.
        /// <para> **Syntax**: `auto | normal | active | inactive | disabled`</para>
        /// <para> **Initial value**: `auto`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> ImeMode
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["ime-mode"];
            set => _properties["ime-mode"] = value;
        }

        /// <summary>
        /// The **`inset-block`** CSS property defines the logical block start and end offsets of an element, which maps to physical offsets depending on the element's writing mode, directionality, and text orientation. It corresponds to the `top` and `bottom`, or `right` and `left` properties depending on the values defined for `writing-mode`, `direction`, and `text-orientation`.
        /// <para> **Syntax**: `&lt;'top'&gt;{1,2}`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> OffsetBlock
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["offset-block"];
            set => _properties["offset-block"] = value;
        }

        /// <summary>
        /// The **`inset-block-end`** CSS property defines the logical block end offset of an element, which maps to a physical inset depending on the element's writing mode, directionality, and text orientation. It corresponds to the `top`, `right`, `bottom`, or `left` property depending on the values defined for `writing-mode`, `direction`, and `text-orientation`.
        /// <para> **Syntax**: `&lt;'top'&gt;`</para>
        /// <para> **Initial value**: `auto`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> OffsetBlockEnd
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["offset-block-end"];
            set => _properties["offset-block-end"] = value;
        }

        /// <summary>
        /// The **`inset-block-start`** CSS property defines the logical block start offset of an element, which maps to a physical inset depending on the element's writing mode, directionality, and text orientation. It corresponds to the `top`, `right`, `bottom`, or `left` property depending on the values defined for `writing-mode`, `direction`, and `text-orientation`.
        /// <para> **Syntax**: `&lt;'top'&gt;`</para>
        /// <para> **Initial value**: `auto`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> OffsetBlockStart
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["offset-block-start"];
            set => _properties["offset-block-start"] = value;
        }

        /// <summary>
        /// The **`inset-inline`** CSS property defines the logical start and end offsets of an element in the inline direction, which maps to physical offsets depending on the element's writing mode, directionality, and text orientation. It corresponds to the `top` and `bottom`, or `right` and `left` properties depending on the values defined for `writing-mode`, `direction`, and `text-orientation`.
        /// <para> **Syntax**: `&lt;'top'&gt;{1,2}`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> OffsetInline
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["offset-inline"];
            set => _properties["offset-inline"] = value;
        }

        /// <summary>
        /// The **`inset-inline-end`** CSS property defines the logical inline end inset of an element, which maps to a physical offset depending on the element's writing mode, directionality, and text orientation. It corresponds to the `top`, `right`, `bottom`, or `left` property depending on the values defined for `writing-mode`, `direction`, and `text-orientation`.
        /// <para> **Syntax**: `&lt;'top'&gt;`</para>
        /// <para> **Initial value**: `auto`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> OffsetInlineEnd
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["offset-inline-end"];
            set => _properties["offset-inline-end"] = value;
        }

        /// <summary>
        /// The **`inset-inline-start`** CSS property defines the logical inline start inset of an element, which maps to a physical offset depending on the element's writing mode, directionality, and text orientation. It corresponds to the `top`, `right`, `bottom`, or `left` property depending on the values defined for `writing-mode`, `direction`, and `text-orientation`.
        /// <para> **Syntax**: `&lt;'top'&gt;`</para>
        /// <para> **Initial value**: `auto`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> OffsetInlineStart
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["offset-inline-start"];
            set => _properties["offset-inline-start"] = value;
        }

        /// <summary>
        /// The **`scroll-snap-coordinate`** CSS property defines the x and y coordinate positions within an element that will align with its nearest ancestor scroll container's `scroll-snap-destination` for each respective axis.
        /// <para> **Syntax**: `none | &lt;position&gt;#`</para>
        /// <para> **Initial value**: `none`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> ScrollSnapCoordinate
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["scroll-snap-coordinate"];
            set => _properties["scroll-snap-coordinate"] = value;
        }

        /// <summary>
        /// The **`scroll-snap-destination`** CSS property defines the position in x and y coordinates within the scroll container's visual viewport which element snap points align with.
        /// <para> **Syntax**: `&lt;position&gt;`</para>
        /// <para> **Initial value**: `0px 0px`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> ScrollSnapDestination
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["scroll-snap-destination"];
            set => _properties["scroll-snap-destination"] = value;
        }

        /// <summary>
        /// The **`scroll-snap-points-x`** CSS property defines the horizontal positioning of snap points within the content of the scroll container they are applied to.
        /// <para> **Syntax**: `none | repeat( &lt;length-percentage&gt; )`</para>
        /// <para> **Initial value**: `none`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> ScrollSnapPointsX
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["scroll-snap-points-x"];
            set => _properties["scroll-snap-points-x"] = value;
        }

        /// <summary>
        /// The **`scroll-snap-points-y`** CSS property defines the vertical positioning of snap points within the content of the scroll container they are applied to.
        /// <para> **Syntax**: `none | repeat( &lt;length-percentage&gt; )`</para>
        /// <para> **Initial value**: `none`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> ScrollSnapPointsY
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["scroll-snap-points-y"];
            set => _properties["scroll-snap-points-y"] = value;
        }

        /// <summary>
        /// The **`scroll-snap-type-x`** CSS property defines how strictly snap points are enforced on the horizontal axis of the scroll container in case there is one.
        /// <para> **Syntax**: `none | mandatory | proximity`</para>
        /// <para> **Initial value**: `none`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> ScrollSnapTypeX
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["scroll-snap-type-x"];
            set => _properties["scroll-snap-type-x"] = value;
        }

        /// <summary>
        /// The **`scroll-snap-type-y`** CSS property defines how strictly snap points are enforced on the vertical axis of the scroll container in case there is one.
        /// <para> **Syntax**: `none | mandatory | proximity`</para>
        /// <para> **Initial value**: `none`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> ScrollSnapTypeY
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["scroll-snap-type-y"];
            set => _properties["scroll-snap-type-y"] = value;
        }

        /// <summary>
        /// The **`box-align`** CSS property specifies how an element aligns its contents across its layout in a perpendicular direction. The effect of the property is only visible if there is extra space in the box.
        /// <para> **Syntax**: `start | center | end | baseline | stretch`</para>
        /// <para> **Initial value**: `stretch`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> KhtmlBoxAlign
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-khtml-box-align"];
            set => _properties["-khtml-box-align"] = value;
        }

        /// <summary>
        /// The **`box-direction`** CSS property specifies whether a box lays out its contents normally (from the top or left edge), or in reverse (from the bottom or right edge).
        /// <para> **Syntax**: `normal | reverse | inherit`</para>
        /// <para> **Initial value**: `normal`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> KhtmlBoxDirection
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-khtml-box-direction"];
            set => _properties["-khtml-box-direction"] = value;
        }

        /// <summary>
        /// The **`-moz-box-flex`** and **`-webkit-box-flex`** CSS properties specify how a `-moz-box` or `-webkit-box` grows to fill the box that contains it, in the direction of the containing box's layout.
        /// <para> **Syntax**: `&lt;number&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> KhtmlBoxFlex
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-khtml-box-flex"];
            set => _properties["-khtml-box-flex"] = value;
        }

        /// <summary>
        /// The **`box-flex-group`** CSS property assigns the flexbox's child elements to a flex group.
        /// <para> **Syntax**: `&lt;integer&gt;`</para>
        /// <para> **Initial value**: `1`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> KhtmlBoxFlexGroup
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-khtml-box-flex-group"];
            set => _properties["-khtml-box-flex-group"] = value;
        }

        /// <summary>
        /// The **`box-lines`** CSS property determines whether the box may have a single or multiple lines (rows for horizontally oriented boxes, columns for vertically oriented boxes).
        /// <para> **Syntax**: `single | multiple`</para>
        /// <para> **Initial value**: `single`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> KhtmlBoxLines
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-khtml-box-lines"];
            set => _properties["-khtml-box-lines"] = value;
        }

        /// <summary>
        /// The **`box-ordinal-group`** CSS property assigns the flexbox's child elements to an ordinal group.
        /// <para> **Syntax**: `&lt;integer&gt;`</para>
        /// <para> **Initial value**: `1`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> KhtmlBoxOrdinalGroup
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-khtml-box-ordinal-group"];
            set => _properties["-khtml-box-ordinal-group"] = value;
        }

        /// <summary>
        /// The **`box-orient`** CSS property sets whether an element lays out its contents horizontally or vertically.
        /// <para> **Syntax**: `horizontal | vertical | inline-axis | block-axis | inherit`</para>
        /// <para> **Initial value**: `inline-axis` (`horizontal` in XUL)</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> KhtmlBoxOrient
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-khtml-box-orient"];
            set => _properties["-khtml-box-orient"] = value;
        }

        /// <summary>
        /// The **`-moz-box-pack`** and **`-webkit-box-pack`** CSS properties specify how a `-moz-box` or `-webkit-box` packs its contents in the direction of its layout. The effect of this is only visible if there is extra space in the box.
        /// <para> **Syntax**: `start | center | end | justify`</para>
        /// <para> **Initial value**: `start`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> KhtmlBoxPack
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-khtml-box-pack"];
            set => _properties["-khtml-box-pack"] = value;
        }

        /// <summary>
        /// The **`line-break`** CSS property sets how to break lines of Chinese, Japanese, or Korean (CJK) text when working with punctuation and symbols.
        /// <para> **Syntax**: `auto | loose | normal | strict | anywhere`</para>
        /// <para> **Initial value**: `auto`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> KhtmlLineBreak
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-khtml-line-break"];
            set => _properties["-khtml-line-break"] = value;
        }

        /// <summary>
        /// The **`opacity`** CSS property sets the opacity of an element. Opacity is the degree to which content behind an element is hidden, and is the opposite of transparency.
        /// <para> **Syntax**: `&lt;alpha-value&gt;`</para>
        /// <para> **Initial value**: `1`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> KhtmlOpacity
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-khtml-opacity"];
            set => _properties["-khtml-opacity"] = value;
        }

        /// <summary>
        /// The **`user-select`** CSS property controls whether the user can select text. This doesn't have any effect on content loaded as part of a browser's user interface (its chrome), except in textboxes.
        /// <para> **Syntax**: `auto | text | none | contain | all`</para>
        /// <para> **Initial value**: `auto`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> KhtmlUserSelect
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-khtml-user-select"];
            set => _properties["-khtml-user-select"] = value;
        }

        /// <summary>
        /// The **`backface-visibility`** CSS property sets whether the back face of an element is visible when turned towards the user.
        /// <para> **Syntax**: `visible | hidden`</para>
        /// <para> **Initial value**: `visible`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MozBackfaceVisibility
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-backface-visibility"];
            set => _properties["-moz-backface-visibility"] = value;
        }

        /// <summary>
        /// The **`background-clip`** CSS property sets whether an element's background extends underneath its border box, padding box, or content box.
        /// <para> **Syntax**: `&lt;box&gt;#`</para>
        /// <para> **Initial value**: `border-box`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MozBackgroundClip
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-background-clip"];
            set => _properties["-moz-background-clip"] = value;
        }

        /// <summary>
        /// The **`box-decoration-break`** CSS property specifies how an element's fragments should be rendered when broken across multiple lines, columns, or pages.
        /// <para> **Syntax**: `slice | clone`</para>
        /// <para> **Initial value**: `slice`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MozBackgroundInlinePolicy
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-background-inline-policy"];
            set => _properties["-moz-background-inline-policy"] = value;
        }

        /// <summary>
        /// The **`background-origin`** CSS property sets the background's origin: from the border start, inside the border, or inside the padding.
        /// <para> **Syntax**: `&lt;box&gt;#`</para>
        /// <para> **Initial value**: `padding-box`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MozBackgroundOrigin
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-background-origin"];
            set => _properties["-moz-background-origin"] = value;
        }

        /// <summary>
        /// The **`background-size`** CSS property sets the size of the element's background image. The image can be left to its natural size, stretched, or constrained to fit the available space.
        /// <para> **Syntax**: `&lt;bg-size&gt;#`</para>
        /// <para> **Initial value**: `auto auto`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> MozBackgroundSize
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-background-size"];
            set => _properties["-moz-background-size"] = value;
        }

        /// <summary>
        /// The **`border-radius`** CSS property rounds the corners of an element's outer border edge. You can set a single radius to make circular corners, or two radii to make elliptical corners.
        /// <para> **Syntax**: `&lt;length-percentage&gt;{1,4} [ / &lt;length-percentage&gt;{1,4} ]?`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> MozBorderRadius
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-border-radius"];
            set => _properties["-moz-border-radius"] = value;
        }

        /// <summary>
        /// The **`border-bottom-left-radius`** CSS property rounds the bottom-left corner of an element by specifying the radius (or the radius of the semi-major and semi-minor axes) of the ellipse defining the curvature of the corner.
        /// <para> **Syntax**: `&lt;length-percentage&gt;{1,2}`</para>
        /// <para> **Initial value**: `0`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> MozBorderRadiusBottomleft
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-border-radius-bottomleft"];
            set => _properties["-moz-border-radius-bottomleft"] = value;
        }

        /// <summary>
        /// The **`border-bottom-right-radius`** CSS property rounds the bottom-right corner of an element by specifying the radius (or the radius of the semi-major and semi-minor axes) of the ellipse defining the curvature of the corner.
        /// <para> **Syntax**: `&lt;length-percentage&gt;{1,2}`</para>
        /// <para> **Initial value**: `0`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> MozBorderRadiusBottomright
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-border-radius-bottomright"];
            set => _properties["-moz-border-radius-bottomright"] = value;
        }

        /// <summary>
        /// The **`border-top-left-radius`** CSS property rounds the top-left corner of an element by specifying the radius (or the radius of the semi-major and semi-minor axes) of the ellipse defining the curvature of the corner.
        /// <para> **Syntax**: `&lt;length-percentage&gt;{1,2}`</para>
        /// <para> **Initial value**: `0`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> MozBorderRadiusTopleft
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-border-radius-topleft"];
            set => _properties["-moz-border-radius-topleft"] = value;
        }

        /// <summary>
        /// The **`border-top-right-radius`** CSS property rounds the top-right corner of an element by specifying the radius (or the radius of the semi-major and semi-minor axes) of the ellipse defining the curvature of the corner.
        /// <para> **Syntax**: `&lt;length-percentage&gt;{1,2}`</para>
        /// <para> **Initial value**: `0`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> MozBorderRadiusTopright
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-border-radius-topright"];
            set => _properties["-moz-border-radius-topright"] = value;
        }

        /// <summary>
        /// The **`box-align`** CSS property specifies how an element aligns its contents across its layout in a perpendicular direction. The effect of the property is only visible if there is extra space in the box.
        /// <para> **Syntax**: `start | center | end | baseline | stretch`</para>
        /// <para> **Initial value**: `stretch`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MozBoxAlign
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-box-align"];
            set => _properties["-moz-box-align"] = value;
        }

        /// <summary>
        /// The **`box-direction`** CSS property specifies whether a box lays out its contents normally (from the top or left edge), or in reverse (from the bottom or right edge).
        /// <para> **Syntax**: `normal | reverse | inherit`</para>
        /// <para> **Initial value**: `normal`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MozBoxDirection
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-box-direction"];
            set => _properties["-moz-box-direction"] = value;
        }

        /// <summary>
        /// The **`-moz-box-flex`** and **`-webkit-box-flex`** CSS properties specify how a `-moz-box` or `-webkit-box` grows to fill the box that contains it, in the direction of the containing box's layout.
        /// <para> **Syntax**: `&lt;number&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> MozBoxFlex
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-box-flex"];
            set => _properties["-moz-box-flex"] = value;
        }

        /// <summary>
        /// The **`box-ordinal-group`** CSS property assigns the flexbox's child elements to an ordinal group.
        /// <para> **Syntax**: `&lt;integer&gt;`</para>
        /// <para> **Initial value**: `1`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> MozBoxOrdinalGroup
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-box-ordinal-group"];
            set => _properties["-moz-box-ordinal-group"] = value;
        }

        /// <summary>
        /// The **`box-orient`** CSS property sets whether an element lays out its contents horizontally or vertically.
        /// <para> **Syntax**: `horizontal | vertical | inline-axis | block-axis | inherit`</para>
        /// <para> **Initial value**: `inline-axis` (`horizontal` in XUL)</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MozBoxOrient
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-box-orient"];
            set => _properties["-moz-box-orient"] = value;
        }

        /// <summary>
        /// The **`-moz-box-pack`** and **`-webkit-box-pack`** CSS properties specify how a `-moz-box` or `-webkit-box` packs its contents in the direction of its layout. The effect of this is only visible if there is extra space in the box.
        /// <para> **Syntax**: `start | center | end | justify`</para>
        /// <para> **Initial value**: `start`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MozBoxPack
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-box-pack"];
            set => _properties["-moz-box-pack"] = value;
        }

        /// <summary>
        /// The **`box-shadow`** CSS property adds shadow effects around an element's frame. You can set multiple effects separated by commas. A box shadow is described by X and Y offsets relative to the element, blur and spread radius, and color.
        /// <para> **Syntax**: `none | &lt;shadow&gt;#`</para>
        /// <para> **Initial value**: `none`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MozBoxShadow
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-box-shadow"];
            set => _properties["-moz-box-shadow"] = value;
        }

        /// <summary>
        /// The non-standard **`-moz-float-edge`** CSS property specifies whether the height and width properties of the element include the margin, border, or padding thickness.
        /// <para> **Syntax**: `border-box | content-box | margin-box | padding-box`</para>
        /// <para> **Initial value**: `content-box`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MozFloatEdge
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-float-edge"];
            set => _properties["-moz-float-edge"] = value;
        }

        /// <summary>
        /// The **`-moz-force-broken-image-icon`** extended CSS property can be used to force the broken image icon to be shown even when a broken image has an `alt` attribute.
        /// <para> **Syntax**: `0 | 1`</para>
        /// <para> **Initial value**: `0`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MozForceBrokenImageIcon
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-force-broken-image-icon"];
            set => _properties["-moz-force-broken-image-icon"] = value;
        }

        /// <summary>
        /// The **`opacity`** CSS property sets the opacity of an element. Opacity is the degree to which content behind an element is hidden, and is the opposite of transparency.
        /// <para> **Syntax**: `&lt;alpha-value&gt;`</para>
        /// <para> **Initial value**: `1`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> MozOpacity
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-opacity"];
            set => _properties["-moz-opacity"] = value;
        }

        /// <summary>
        /// The **`outline`** CSS shorthand property sets most of the outline properties in a single declaration.
        /// <para> **Syntax**: `[ &lt;'outline-color'&gt; || &lt;'outline-style'&gt; || &lt;'outline-width'&gt; ]`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> MozOutline
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-outline"];
            set => _properties["-moz-outline"] = value;
        }

        /// <summary>
        /// The **`outline-color`** CSS property sets the color of an element's outline.
        /// <para> **Syntax**: `&lt;color&gt; | invert`</para>
        /// <para> **Initial value**: `invert`, for browsers supporting it, `currentColor` for the other</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MozOutlineColor
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-outline-color"];
            set => _properties["-moz-outline-color"] = value;
        }

        /// <summary>
        /// The **`outline-style`** CSS property sets the style of an element's outline. An outline is a line that is drawn around an element, outside the `border`.
        /// <para> **Syntax**: `auto | &lt;'border-style'&gt;`</para>
        /// <para> **Initial value**: `none`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MozOutlineStyle
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-outline-style"];
            set => _properties["-moz-outline-style"] = value;
        }

        /// <summary>
        /// The CSS **`outline-width`** property sets the thickness of an element's outline. An outline is a line that is drawn around an element, outside the `border`.
        /// <para> **Syntax**: `&lt;line-width&gt;`</para>
        /// <para> **Initial value**: `medium`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> MozOutlineWidth
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-outline-width"];
            set => _properties["-moz-outline-width"] = value;
        }

        /// <summary>
        /// The **`perspective`** CSS property determines the distance between the z=0 plane and the user in order to give a 3D-positioned element some perspective.
        /// <para> **Syntax**: `none | &lt;length&gt;`</para>
        /// <para> **Initial value**: `none`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> MozPerspective
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-perspective"];
            set => _properties["-moz-perspective"] = value;
        }

        /// <summary>
        /// The **`perspective-origin`** CSS property determines the position at which the viewer is looking. It is used as the _vanishing point_ by the `perspective` property.
        /// <para> **Syntax**: `&lt;position&gt;`</para>
        /// <para> **Initial value**: `50% 50%`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> MozPerspectiveOrigin
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-perspective-origin"];
            set => _properties["-moz-perspective-origin"] = value;
        }

        /// <summary>
        /// The **`text-align-last`** CSS property sets how the last line of a block or a line, right before a forced line break, is aligned.
        /// <para> **Syntax**: `auto | start | end | left | right | center | justify`</para>
        /// <para> **Initial value**: `auto`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MozTextAlignLast
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-text-align-last"];
            set => _properties["-moz-text-align-last"] = value;
        }

        /// <summary>
        /// The **`text-decoration-color`** CSS property sets the color of decorations added to text by `text-decoration-line`.
        /// <para> **Syntax**: `&lt;color&gt;`</para>
        /// <para> **Initial value**: `currentcolor`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MozTextDecorationColor
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-text-decoration-color"];
            set => _properties["-moz-text-decoration-color"] = value;
        }

        /// <summary>
        /// The **`text-decoration-line`** CSS property sets the kind of decoration that is used on text in an element, such as an underline or overline.
        /// <para> **Syntax**: `none | [ underline || overline || line-through || blink ] | spelling-error | grammar-error`</para>
        /// <para> **Initial value**: `none`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MozTextDecorationLine
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-text-decoration-line"];
            set => _properties["-moz-text-decoration-line"] = value;
        }

        /// <summary>
        /// The **`text-decoration-style`** CSS property sets the style of the lines specified by `text-decoration-line`. The style applies to all lines that are set with `text-decoration-line`.
        /// <para> **Syntax**: `solid | double | dotted | dashed | wavy`</para>
        /// <para> **Initial value**: `solid`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MozTextDecorationStyle
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-text-decoration-style"];
            set => _properties["-moz-text-decoration-style"] = value;
        }

        /// <summary>
        /// The **`transform`** CSS property lets you rotate, scale, skew, or translate an element. It modifies the coordinate space of the CSS visual formatting model.
        /// <para> **Syntax**: `none | &lt;transform-list&gt;`</para>
        /// <para> **Initial value**: `none`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MozTransform
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-transform"];
            set => _properties["-moz-transform"] = value;
        }

        /// <summary>
        /// The **`transform-origin`** CSS property sets the origin for an element's transformations.
        /// <para> **Syntax**: `[ &lt;length-percentage&gt; | left | center | right | top | bottom ] | [ [ &lt;length-percentage&gt; | left | center | right ] && [ &lt;length-percentage&gt; | top | center | bottom ] ] &lt;length&gt;?`</para>
        /// <para> **Initial value**: `50% 50% 0`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> MozTransformOrigin
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-transform-origin"];
            set => _properties["-moz-transform-origin"] = value;
        }

        /// <summary>
        /// The **`transform-style`** CSS property sets whether children of an element are positioned in the 3D space or are flattened in the plane of the element.
        /// <para> **Syntax**: `flat | preserve-3d`</para>
        /// <para> **Initial value**: `flat`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MozTransformStyle
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-transform-style"];
            set => _properties["-moz-transform-style"] = value;
        }

        /// <summary>
        /// The **`transition`** CSS property is a shorthand property for `transition-property`, `transition-duration`, `transition-timing-function`, and `transition-delay`.
        /// <para> **Syntax**: `&lt;single-transition&gt;#`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MozTransition
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-transition"];
            set => _properties["-moz-transition"] = value;
        }

        /// <summary>
        /// The **`transition-delay`** CSS property specifies the duration to wait before starting a property's transition effect when its value changes.
        /// <para> **Syntax**: `&lt;time&gt;#`</para>
        /// <para> **Initial value**: `0s`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MozTransitionDelay
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-transition-delay"];
            set => _properties["-moz-transition-delay"] = value;
        }

        /// <summary>
        /// The **`transition-duration`** CSS property sets the length of time a transition animation should take to complete. By default, the value is `0s`, meaning that no animation will occur.
        /// <para> **Syntax**: `&lt;time&gt;#`</para>
        /// <para> **Initial value**: `0s`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MozTransitionDuration
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-transition-duration"];
            set => _properties["-moz-transition-duration"] = value;
        }

        /// <summary>
        /// The **`transition-property`** CSS property sets the CSS properties to which a transition effect should be applied.
        /// <para> **Syntax**: `none | &lt;single-transition-property&gt;#`</para>
        /// <para> **Initial value**: all</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MozTransitionProperty
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-transition-property"];
            set => _properties["-moz-transition-property"] = value;
        }

        /// <summary>
        /// The **`transition-timing-function`** CSS property sets how intermediate values are calculated for CSS properties being affected by a transition effect.
        /// <para> **Syntax**: `&lt;easing-function&gt;#`</para>
        /// <para> **Initial value**: `ease`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MozTransitionTimingFunction
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-transition-timing-function"];
            set => _properties["-moz-transition-timing-function"] = value;
        }

        /// <summary>
        /// In Mozilla applications, **`-moz-user-input`** determines if an element will accept user input.
        /// <para> **Syntax**: `auto | none | enabled | disabled`</para>
        /// <para> **Initial value**: `auto`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MozUserInput
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-user-input"];
            set => _properties["-moz-user-input"] = value;
        }

        /// <summary>
        /// The **`ime-mode`** CSS property controls the state of the input method editor (IME) for text fields. This property is obsolete.
        /// <para> **Syntax**: `auto | normal | active | inactive | disabled`</para>
        /// <para> **Initial value**: `auto`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> MsImeMode
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-ime-mode"];
            set => _properties["-ms-ime-mode"] = value;
        }

        /// <summary>
        /// The **`animation`** shorthand CSS property applies an animation between styles. It is a shorthand for `animation-name`, `animation-duration`, `animation-timing-function`, `animation-delay`, `animation-iteration-count`, `animation-direction`, `animation-fill-mode`, and `animation-play-state`.
        /// <para> **Syntax**: `&lt;single-animation&gt;#`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> OAnimation
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-o-animation"];
            set => _properties["-o-animation"] = value;
        }

        /// <summary>
        /// The **`animation-delay`** CSS property specifies the amount of time to wait from applying the animation to an element before beginning to perform the animation. The animation can start later, immediately from its beginning, or immediately and partway through the animation.
        /// <para> **Syntax**: `&lt;time&gt;#`</para>
        /// <para> **Initial value**: `0s`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> OAnimationDelay
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-o-animation-delay"];
            set => _properties["-o-animation-delay"] = value;
        }

        /// <summary>
        /// The **`animation-direction`** CSS property sets whether an animation should play forward, backward, or alternate back and forth between playing the sequence forward and backward.
        /// <para> **Syntax**: `&lt;single-animation-direction&gt;#`</para>
        /// <para> **Initial value**: `normal`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> OAnimationDirection
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-o-animation-direction"];
            set => _properties["-o-animation-direction"] = value;
        }

        /// <summary>
        /// The **`animation-duration`** CSS property sets the length of time that an animation takes to complete one cycle.
        /// <para> **Syntax**: `&lt;time&gt;#`</para>
        /// <para> **Initial value**: `0s`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> OAnimationDuration
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-o-animation-duration"];
            set => _properties["-o-animation-duration"] = value;
        }

        /// <summary>
        /// The **`animation-fill-mode`** CSS property sets how a CSS animation applies styles to its target before and after its execution.
        /// <para> **Syntax**: `&lt;single-animation-fill-mode&gt;#`</para>
        /// <para> **Initial value**: `none`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> OAnimationFillMode
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-o-animation-fill-mode"];
            set => _properties["-o-animation-fill-mode"] = value;
        }

        /// <summary>
        /// The **`animation-iteration-count`** CSS property sets the number of times an animation sequence should be played before stopping.
        /// <para> **Syntax**: `&lt;single-animation-iteration-count&gt;#`</para>
        /// <para> **Initial value**: `1`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> OAnimationIterationCount
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-o-animation-iteration-count"];
            set => _properties["-o-animation-iteration-count"] = value;
        }

        /// <summary>
        /// The **`animation-name`** CSS property specifies the names of one or more `@keyframes` at-rules that describe the animation to apply to an element. Multiple `@keyframe` at-rules are specified as a comma-separated list of names. If the specified name does not match any `@keyframe` at-rule, no properties are animated.
        /// <para> **Syntax**: `[ none | &lt;keyframes-name&gt; ]#`</para>
        /// <para> **Initial value**: `none`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, Keyframe> OAnimationName
        {
            get => (Property<CSSProperties, PropertySkip, string, Keyframe>) _properties["-o-animation-name"];
            set => _properties["-o-animation-name"] = value;
        }

        /// <summary>
        /// The **`animation-play-state`** CSS property sets whether an animation is running or paused.
        /// <para> **Syntax**: `&lt;single-animation-play-state&gt;#`</para>
        /// <para> **Initial value**: `running`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> OAnimationPlayState
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-o-animation-play-state"];
            set => _properties["-o-animation-play-state"] = value;
        }

        /// <summary>
        /// The **`animation-timing-function`** CSS property sets how an animation progresses through the duration of each cycle.
        /// <para> **Syntax**: `&lt;easing-function&gt;#`</para>
        /// <para> **Initial value**: `ease`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> OAnimationTimingFunction
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-o-animation-timing-function"];
            set => _properties["-o-animation-timing-function"] = value;
        }

        /// <summary>
        /// The **`background-size`** CSS property sets the size of the element's background image. The image can be left to its natural size, stretched, or constrained to fit the available space.
        /// <para> **Syntax**: `&lt;bg-size&gt;#`</para>
        /// <para> **Initial value**: `auto auto`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> OBackgroundSize
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-o-background-size"];
            set => _properties["-o-background-size"] = value;
        }

        /// <summary>
        /// The **`border-image`** CSS property draws an image around a given element. It replaces the element's regular border.
        /// <para> **Syntax**: `&lt;'border-image-source'&gt; || &lt;'border-image-slice'&gt; [ / &lt;'border-image-width'&gt; | / &lt;'border-image-width'&gt;? / &lt;'border-image-outset'&gt; ]? || &lt;'border-image-repeat'&gt;`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> OBorderImage
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-o-border-image"];
            set => _properties["-o-border-image"] = value;
        }

        /// <summary>
        /// The **`object-fit`** CSS property sets how the content of a replaced element, such as an `&lt;img&gt;` or `&lt;video&gt;`, should be resized to fit its container.
        /// <para> **Syntax**: `fill | contain | cover | none | scale-down`</para>
        /// <para> **Initial value**: `fill`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> OObjectFit
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-o-object-fit"];
            set => _properties["-o-object-fit"] = value;
        }

        /// <summary>
        /// The **`object-position`** CSS property specifies the alignment of the selected replaced element's contents within the element's box. Areas of the box which aren't covered by the replaced element's object will show the element's background.
        /// <para> **Syntax**: `&lt;position&gt;`</para>
        /// <para> **Initial value**: `50% 50%`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> OObjectPosition
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-o-object-position"];
            set => _properties["-o-object-position"] = value;
        }

        /// <summary>
        /// The **`tab-size`** CSS property is used to customize the width of tab characters (U+0009).
        /// <para> **Syntax**: `&lt;integer&gt; | &lt;length&gt;`</para>
        /// <para> **Initial value**: `8`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> OTabSize
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-o-tab-size"];
            set => _properties["-o-tab-size"] = value;
        }

        /// <summary>
        /// The **`text-overflow`** CSS property sets how hidden overflow content is signaled to users. It can be clipped, display an ellipsis ('`…`'), or display a custom string.
        /// <para> **Syntax**: `[ clip | ellipsis | &lt;string&gt; ]{1,2}`</para>
        /// <para> **Initial value**: `clip`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> OTextOverflow
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-o-text-overflow"];
            set => _properties["-o-text-overflow"] = value;
        }

        /// <summary>
        /// The **`transform`** CSS property lets you rotate, scale, skew, or translate an element. It modifies the coordinate space of the CSS visual formatting model.
        /// <para> **Syntax**: `none | &lt;transform-list&gt;`</para>
        /// <para> **Initial value**: `none`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> OTransform
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-o-transform"];
            set => _properties["-o-transform"] = value;
        }

        /// <summary>
        /// The **`transform-origin`** CSS property sets the origin for an element's transformations.
        /// <para> **Syntax**: `[ &lt;length-percentage&gt; | left | center | right | top | bottom ] | [ [ &lt;length-percentage&gt; | left | center | right ] && [ &lt;length-percentage&gt; | top | center | bottom ] ] &lt;length&gt;?`</para>
        /// <para> **Initial value**: `50% 50% 0`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> OTransformOrigin
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-o-transform-origin"];
            set => _properties["-o-transform-origin"] = value;
        }

        /// <summary>
        /// The **`transition`** CSS property is a shorthand property for `transition-property`, `transition-duration`, `transition-timing-function`, and `transition-delay`.
        /// <para> **Syntax**: `&lt;single-transition&gt;#`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> OTransition
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-o-transition"];
            set => _properties["-o-transition"] = value;
        }

        /// <summary>
        /// The **`transition-delay`** CSS property specifies the duration to wait before starting a property's transition effect when its value changes.
        /// <para> **Syntax**: `&lt;time&gt;#`</para>
        /// <para> **Initial value**: `0s`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> OTransitionDelay
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-o-transition-delay"];
            set => _properties["-o-transition-delay"] = value;
        }

        /// <summary>
        /// The **`transition-duration`** CSS property sets the length of time a transition animation should take to complete. By default, the value is `0s`, meaning that no animation will occur.
        /// <para> **Syntax**: `&lt;time&gt;#`</para>
        /// <para> **Initial value**: `0s`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> OTransitionDuration
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-o-transition-duration"];
            set => _properties["-o-transition-duration"] = value;
        }

        /// <summary>
        /// The **`transition-property`** CSS property sets the CSS properties to which a transition effect should be applied.
        /// <para> **Syntax**: `none | &lt;single-transition-property&gt;#`</para>
        /// <para> **Initial value**: all</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> OTransitionProperty
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-o-transition-property"];
            set => _properties["-o-transition-property"] = value;
        }

        /// <summary>
        /// The **`transition-timing-function`** CSS property sets how intermediate values are calculated for CSS properties being affected by a transition effect.
        /// <para> **Syntax**: `&lt;easing-function&gt;#`</para>
        /// <para> **Initial value**: `ease`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> OTransitionTimingFunction
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-o-transition-timing-function"];
            set => _properties["-o-transition-timing-function"] = value;
        }

        /// <summary>
        /// The **`box-align`** CSS property specifies how an element aligns its contents across its layout in a perpendicular direction. The effect of the property is only visible if there is extra space in the box.
        /// <para> **Syntax**: `start | center | end | baseline | stretch`</para>
        /// <para> **Initial value**: `stretch`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> WebkitBoxAlign
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-box-align"];
            set => _properties["-webkit-box-align"] = value;
        }

        /// <summary>
        /// The **`box-direction`** CSS property specifies whether a box lays out its contents normally (from the top or left edge), or in reverse (from the bottom or right edge).
        /// <para> **Syntax**: `normal | reverse | inherit`</para>
        /// <para> **Initial value**: `normal`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> WebkitBoxDirection
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-box-direction"];
            set => _properties["-webkit-box-direction"] = value;
        }

        /// <summary>
        /// The **`-moz-box-flex`** and **`-webkit-box-flex`** CSS properties specify how a `-moz-box` or `-webkit-box` grows to fill the box that contains it, in the direction of the containing box's layout.
        /// <para> **Syntax**: `&lt;number&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> WebkitBoxFlex
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-box-flex"];
            set => _properties["-webkit-box-flex"] = value;
        }

        /// <summary>
        /// The **`box-flex-group`** CSS property assigns the flexbox's child elements to a flex group.
        /// <para> **Syntax**: `&lt;integer&gt;`</para>
        /// <para> **Initial value**: `1`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> WebkitBoxFlexGroup
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-box-flex-group"];
            set => _properties["-webkit-box-flex-group"] = value;
        }

        /// <summary>
        /// The **`box-lines`** CSS property determines whether the box may have a single or multiple lines (rows for horizontally oriented boxes, columns for vertically oriented boxes).
        /// <para> **Syntax**: `single | multiple`</para>
        /// <para> **Initial value**: `single`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> WebkitBoxLines
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-box-lines"];
            set => _properties["-webkit-box-lines"] = value;
        }

        /// <summary>
        /// The **`box-ordinal-group`** CSS property assigns the flexbox's child elements to an ordinal group.
        /// <para> **Syntax**: `&lt;integer&gt;`</para>
        /// <para> **Initial value**: `1`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string, double> WebkitBoxOrdinalGroup
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-box-ordinal-group"];
            set => _properties["-webkit-box-ordinal-group"] = value;
        }

        /// <summary>
        /// The **`box-orient`** CSS property sets whether an element lays out its contents horizontally or vertically.
        /// <para> **Syntax**: `horizontal | vertical | inline-axis | block-axis | inherit`</para>
        /// <para> **Initial value**: `inline-axis` (`horizontal` in XUL)</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> WebkitBoxOrient
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-box-orient"];
            set => _properties["-webkit-box-orient"] = value;
        }

        /// <summary>
        /// The **`-moz-box-pack`** and **`-webkit-box-pack`** CSS properties specify how a `-moz-box` or `-webkit-box` packs its contents in the direction of its layout. The effect of this is only visible if there is extra space in the box.
        /// <para> **Syntax**: `start | center | end | justify`</para>
        /// <para> **Initial value**: `start`</para>
        /// <para> @deprecated</para>
        /// </summary>
        [Obsolete]
        public Property<CSSProperties, PropertySkip, string> WebkitBoxPack
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-box-pack"];
            set => _properties["-webkit-box-pack"] = value;
        }

    }
}
