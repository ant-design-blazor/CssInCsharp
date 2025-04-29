namespace CssInCSharp
{
    public partial class CSSObject
    {
        /// <summary>
        /// The **`all`** shorthand CSS property resets all of an element's properties except `unicode-bidi`, `direction`, and CSS Custom Properties. It can set properties to their initial or inherited values, or to the values specified in another cascade layer or stylesheet origin.
        /// <para> **Syntax**: `initial | inherit | unset | revert | revert-layer`</para>
        /// <para> **Initial value**: There is no practical initial value for it.</para>
        /// <para> | Chrome | Firefox | Safari  | Edge | IE  |</para>
        /// <para> | :----: | :-----: | :-----: | :--: | :-: |</para>
        /// <para> | **37** | **27**  | **9.1** | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/all</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> All
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["all"];
            set => _properties["all"] = value;
        }

        /// <summary>
        /// The **`animation`** shorthand CSS property applies an animation between styles. It is a shorthand for `animation-name`, `animation-duration`, `animation-timing-function`, `animation-delay`, `animation-iteration-count`, `animation-direction`, `animation-fill-mode`, and `animation-play-state`.
        /// <para> **Syntax**: `&lt;single-animation&gt;#`</para>
        /// <para> | Chrome  | Firefox | Safari  |  Edge  |   IE   |</para>
        /// <para> | :-----: | :-----: | :-----: | :----: | :----: |</para>
        /// <para> | **43**  | **16**  |  **9**  | **12** | **10** |</para>
        /// <para> | 3 _-x-_ | 5 _-x-_ | 4 _-x-_ |        |        |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/animation</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> Animation
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["animation"];
            set => _properties["animation"] = value;
        }

        /// <summary>
        /// The **`animation-range`** CSS shorthand property is used to set the start and end of an animation's attachment range along its timeline, i.e. where along the timeline an animation will start and end.
        /// <para> **Syntax**: `[ &lt;'animation-range-start'&gt; &lt;'animation-range-end'&gt;? ]#`</para>
        /// <para> | Chrome  | Firefox | Safari | Edge | IE  |</para>
        /// <para> | :-----: | :-----: | :----: | :--: | :-: |</para>
        /// <para> | **115** |   No    |   No   | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/animation-range</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> AnimationRange
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["animation-range"];
            set => _properties["animation-range"] = value;
        }

        /// <summary>
        /// The **`background`** shorthand CSS property sets all background style properties at once, such as color, image, origin and size, or repeat method.
        /// <para> **Syntax**: `[ &lt;bg-layer&gt; , ]* &lt;final-bg-layer&gt;`</para>
        /// <para> | Chrome | Firefox | Safari |  Edge  |  IE   |</para>
        /// <para> | :----: | :-----: | :----: | :----: | :---: |</para>
        /// <para> | **1**  |  **1**  | **1**  | **12** | **4** |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/background</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> Background
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["background"];
            set => _properties["background"] = value;
        }

        /// <summary>
        /// The **`background-position`** CSS property sets the initial position for each background image. The position is relative to the position layer set by `background-origin`.
        /// <para> **Syntax**: `&lt;bg-position&gt;#`</para>
        /// <para> **Initial value**: `0% 0%`</para>
        /// <para> | Chrome | Firefox | Safari |  Edge  |  IE   |</para>
        /// <para> | :----: | :-----: | :----: | :----: | :---: |</para>
        /// <para> | **1**  |  **1**  | **1**  | **12** | **4** |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/background-position</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> BackgroundPosition
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["background-position"];
            set => _properties["background-position"] = value;
        }

        /// <summary>
        /// The **`border`** shorthand CSS property sets an element's border. It sets the values of `border-width`, `border-style`, and `border-color`.
        /// <para> **Syntax**: `&lt;line-width&gt; || &lt;line-style&gt; || &lt;color&gt;`</para>
        /// <para> | Chrome | Firefox | Safari |  Edge  |  IE   |</para>
        /// <para> | :----: | :-----: | :----: | :----: | :---: |</para>
        /// <para> | **1**  |  **1**  | **1**  | **12** | **4** |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/border</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> Border
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["border"];
            set => _properties["border"] = value;
        }

        /// <summary>
        /// The **`border-block`** CSS property is a shorthand property for setting the individual logical block border property values in a single place in the style sheet.
        /// <para> **Syntax**: `&lt;'border-top-width'&gt; || &lt;'border-top-style'&gt; || &lt;color&gt;`</para>
        /// <para> | Chrome | Firefox |  Safari  | Edge | IE  |</para>
        /// <para> | :----: | :-----: | :------: | :--: | :-: |</para>
        /// <para> | **87** | **66**  | **14.1** | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/border-block</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> BorderBlock
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["border-block"];
            set => _properties["border-block"] = value;
        }

        /// <summary>
        /// The **`border-block-end`** CSS property is a shorthand property for setting the individual logical block-end border property values in a single place in the style sheet.
        /// <para> **Syntax**: `&lt;'border-top-width'&gt; || &lt;'border-top-style'&gt; || &lt;color&gt;`</para>
        /// <para> | Chrome | Firefox |  Safari  | Edge | IE  |</para>
        /// <para> | :----: | :-----: | :------: | :--: | :-: |</para>
        /// <para> | **69** | **41**  | **12.1** | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/border-block-end</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> BorderBlockEnd
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["border-block-end"];
            set => _properties["border-block-end"] = value;
        }

        /// <summary>
        /// The **`border-block-start`** CSS property is a shorthand property for setting the individual logical block-start border property values in a single place in the style sheet.
        /// <para> **Syntax**: `&lt;'border-top-width'&gt; || &lt;'border-top-style'&gt; || &lt;color&gt;`</para>
        /// <para> | Chrome | Firefox |  Safari  | Edge | IE  |</para>
        /// <para> | :----: | :-----: | :------: | :--: | :-: |</para>
        /// <para> | **69** | **41**  | **12.1** | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/border-block-start</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> BorderBlockStart
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["border-block-start"];
            set => _properties["border-block-start"] = value;
        }

        /// <summary>
        /// The **`border-bottom`** shorthand CSS property sets an element's bottom border. It sets the values of `border-bottom-width`, `border-bottom-style` and `border-bottom-color`.
        /// <para> **Syntax**: `&lt;line-width&gt; || &lt;line-style&gt; || &lt;color&gt;`</para>
        /// <para> | Chrome | Firefox | Safari |  Edge  |  IE   |</para>
        /// <para> | :----: | :-----: | :----: | :----: | :---: |</para>
        /// <para> | **1**  |  **1**  | **1**  | **12** | **4** |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/border-bottom</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> BorderBottom
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["border-bottom"];
            set => _properties["border-bottom"] = value;
        }

        /// <summary>
        /// The **`border-color`** shorthand CSS property sets the color of an element's border.
        /// <para> **Syntax**: `&lt;color&gt;{1,4}`</para>
        /// <para> | Chrome | Firefox | Safari |  Edge  |  IE   |</para>
        /// <para> | :----: | :-----: | :----: | :----: | :---: |</para>
        /// <para> | **1**  |  **1**  | **1**  | **12** | **4** |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/border-color</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> BorderColor
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["border-color"];
            set => _properties["border-color"] = value;
        }

        /// <summary>
        /// The **`border-image`** CSS property draws an image around a given element. It replaces the element's regular border.
        /// <para> **Syntax**: `&lt;'border-image-source'&gt; || &lt;'border-image-slice'&gt; [ / &lt;'border-image-width'&gt; | / &lt;'border-image-width'&gt;? / &lt;'border-image-outset'&gt; ]? || &lt;'border-image-repeat'&gt;`</para>
        /// <para> | Chrome  |  Firefox  | Safari  |  Edge  |   IE   |</para>
        /// <para> | :-----: | :-------: | :-----: | :----: | :----: |</para>
        /// <para> | **16**  |  **15**   |  **6**  | **12** | **11** |</para>
        /// <para> | 7 _-x-_ | 3.5 _-x-_ | 3 _-x-_ |        |        |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/border-image</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> BorderImage
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["border-image"];
            set => _properties["border-image"] = value;
        }

        /// <summary>
        /// The **`border-inline`** CSS property is a shorthand property for setting the individual logical inline border property values in a single place in the style sheet.
        /// <para> **Syntax**: `&lt;'border-top-width'&gt; || &lt;'border-top-style'&gt; || &lt;color&gt;`</para>
        /// <para> | Chrome | Firefox |  Safari  | Edge | IE  |</para>
        /// <para> | :----: | :-----: | :------: | :--: | :-: |</para>
        /// <para> | **87** | **66**  | **14.1** | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/border-inline</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> BorderInline
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["border-inline"];
            set => _properties["border-inline"] = value;
        }

        /// <summary>
        /// The **`border-inline-end`** CSS property is a shorthand property for setting the individual logical inline-end border property values in a single place in the style sheet.
        /// <para> **Syntax**: `&lt;'border-top-width'&gt; || &lt;'border-top-style'&gt; || &lt;color&gt;`</para>
        /// <para> | Chrome | Firefox |  Safari  | Edge | IE  |</para>
        /// <para> | :----: | :-----: | :------: | :--: | :-: |</para>
        /// <para> | **69** | **41**  | **12.1** | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/border-inline-end</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> BorderInlineEnd
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["border-inline-end"];
            set => _properties["border-inline-end"] = value;
        }

        /// <summary>
        /// The **`border-inline-start`** CSS property is a shorthand property for setting the individual logical inline-start border property values in a single place in the style sheet.
        /// <para> **Syntax**: `&lt;'border-top-width'&gt; || &lt;'border-top-style'&gt; || &lt;color&gt;`</para>
        /// <para> | Chrome | Firefox |  Safari  | Edge | IE  |</para>
        /// <para> | :----: | :-----: | :------: | :--: | :-: |</para>
        /// <para> | **69** | **41**  | **12.1** | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/border-inline-start</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> BorderInlineStart
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["border-inline-start"];
            set => _properties["border-inline-start"] = value;
        }

        /// <summary>
        /// The **`border-left`** shorthand CSS property sets all the properties of an element's left border.
        /// <para> **Syntax**: `&lt;line-width&gt; || &lt;line-style&gt; || &lt;color&gt;`</para>
        /// <para> | Chrome | Firefox | Safari |  Edge  |  IE   |</para>
        /// <para> | :----: | :-----: | :----: | :----: | :---: |</para>
        /// <para> | **1**  |  **1**  | **1**  | **12** | **4** |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/border-left</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> BorderLeft
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["border-left"];
            set => _properties["border-left"] = value;
        }

        /// <summary>
        /// The **`border-radius`** CSS property rounds the corners of an element's outer border edge. You can set a single radius to make circular corners, or two radii to make elliptical corners.
        /// <para> **Syntax**: `&lt;length-percentage&gt;{1,4} [ / &lt;length-percentage&gt;{1,4} ]?`</para>
        /// <para> | Chrome  | Firefox | Safari  |  Edge  |  IE   |</para>
        /// <para> | :-----: | :-----: | :-----: | :----: | :---: |</para>
        /// <para> |  **4**  |  **4**  |  **5**  | **12** | **9** |</para>
        /// <para> | 1 _-x-_ |         | 3 _-x-_ |        |       |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/border-radius</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> BorderRadius
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["border-radius"];
            set => _properties["border-radius"] = value;
        }

        /// <summary>
        /// The **`border-right`** shorthand CSS property sets all the properties of an element's right border.
        /// <para> **Syntax**: `&lt;line-width&gt; || &lt;line-style&gt; || &lt;color&gt;`</para>
        /// <para> | Chrome | Firefox | Safari |  Edge  |   IE    |</para>
        /// <para> | :----: | :-----: | :----: | :----: | :-----: |</para>
        /// <para> | **1**  |  **1**  | **1**  | **12** | **5.5** |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/border-right</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> BorderRight
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["border-right"];
            set => _properties["border-right"] = value;
        }

        /// <summary>
        /// The **`border-style`** shorthand CSS property sets the line style for all four sides of an element's border.
        /// <para> **Syntax**: `&lt;line-style&gt;{1,4}`</para>
        /// <para> | Chrome | Firefox | Safari |  Edge  |  IE   |</para>
        /// <para> | :----: | :-----: | :----: | :----: | :---: |</para>
        /// <para> | **1**  |  **1**  | **1**  | **12** | **4** |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/border-style</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> BorderStyle
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["border-style"];
            set => _properties["border-style"] = value;
        }

        /// <summary>
        /// The **`border-top`** shorthand CSS property sets all the properties of an element's top border.
        /// <para> **Syntax**: `&lt;line-width&gt; || &lt;line-style&gt; || &lt;color&gt;`</para>
        /// <para> | Chrome | Firefox | Safari |  Edge  |  IE   |</para>
        /// <para> | :----: | :-----: | :----: | :----: | :---: |</para>
        /// <para> | **1**  |  **1**  | **1**  | **12** | **4** |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/border-top</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> BorderTop
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["border-top"];
            set => _properties["border-top"] = value;
        }

        /// <summary>
        /// The **`border-width`** shorthand CSS property sets the width of an element's border.
        /// <para> **Syntax**: `&lt;line-width&gt;{1,4}`</para>
        /// <para> | Chrome | Firefox | Safari |  Edge  |  IE   |</para>
        /// <para> | :----: | :-----: | :----: | :----: | :---: |</para>
        /// <para> | **1**  |  **1**  | **1**  | **12** | **4** |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/border-width</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> BorderWidth
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["border-width"];
            set => _properties["border-width"] = value;
        }

        /// <summary>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> Caret
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["caret"];
            set => _properties["caret"] = value;
        }

        /// <summary>
        /// The **`column-rule`** shorthand CSS property sets the width, style, and color of the line drawn between columns in a multi-column layout.
        /// <para> **Syntax**: `&lt;'column-rule-width'&gt; || &lt;'column-rule-style'&gt; || &lt;'column-rule-color'&gt;`</para>
        /// <para> | Chrome  | Firefox | Safari  |  Edge  |   IE   |</para>
        /// <para> | :-----: | :-----: | :-----: | :----: | :----: |</para>
        /// <para> | **50**  | **52**  |  **9**  | **12** | **10** |</para>
        /// <para> | 1 _-x-_ |         | 3 _-x-_ |        |        |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/column-rule</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> ColumnRule
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["column-rule"];
            set => _properties["column-rule"] = value;
        }

        /// <summary>
        /// The **`columns`** CSS shorthand property sets the number of columns to use when drawing an element's contents, as well as those columns' widths.
        /// <para> **Syntax**: `&lt;'column-width'&gt; || &lt;'column-count'&gt;`</para>
        /// <para> | Chrome | Firefox | Safari  |  Edge  |   IE   |</para>
        /// <para> | :----: | :-----: | :-----: | :----: | :----: |</para>
        /// <para> | **50** | **52**  |  **9**  | **12** | **10** |</para>
        /// <para> |        |         | 3 _-x-_ |        |        |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/columns</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> Columns
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["columns"];
            set => _properties["columns"] = value;
        }

        /// <summary>
        /// The **`contain-intrinsic-size`** CSS shorthand property sets the size of an element that a browser will use for layout when the element is subject to size containment.
        /// <para> **Syntax**: `[ auto? [ none | &lt;length&gt; ] ]{1,2}`</para>
        /// <para> | Chrome | Firefox | Safari | Edge | IE  |</para>
        /// <para> | :----: | :-----: | :----: | :--: | :-: |</para>
        /// <para> | **83** | **107** | **17** | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/contain-intrinsic-size</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> ContainIntrinsicSize
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["contain-intrinsic-size"];
            set => _properties["contain-intrinsic-size"] = value;
        }

        /// <summary>
        /// The **container** shorthand CSS property establishes the element as a query container and specifies the name or name for the containment context used in a container query.
        /// <para> **Syntax**: `&lt;'container-name'&gt; [ / &lt;'container-type'&gt; ]?`</para>
        /// <para> | Chrome  | Firefox | Safari | Edge | IE  |</para>
        /// <para> | :-----: | :-----: | :----: | :--: | :-: |</para>
        /// <para> | **105** | **110** | **16** | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/container</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> Container
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["container"];
            set => _properties["container"] = value;
        }

        /// <summary>
        /// The **`flex`** CSS shorthand property sets how a flex _item_ will grow or shrink to fit the space available in its flex container.
        /// <para> **Syntax**: `none | [ &lt;'flex-grow'&gt; &lt;'flex-shrink'&gt;? || &lt;'flex-basis'&gt; ]`</para>
        /// <para> |  Chrome  | Firefox | Safari  |  Edge  |    IE    |</para>
        /// <para> | :------: | :-----: | :-----: | :----: | :------: |</para>
        /// <para> |  **29**  | **20**  |  **9**  | **12** |  **11**  |</para>
        /// <para> | 21 _-x-_ |         | 7 _-x-_ |        | 10 _-x-_ |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/flex</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> Flex
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["flex"];
            set => _properties["flex"] = value;
        }

        /// <summary>
        /// The **`flex-flow`** CSS shorthand property specifies the direction of a flex container, as well as its wrapping behavior.
        /// <para> **Syntax**: `&lt;'flex-direction'&gt; || &lt;'flex-wrap'&gt;`</para>
        /// <para> |  Chrome  | Firefox | Safari  |  Edge  |   IE   |</para>
        /// <para> | :------: | :-----: | :-----: | :----: | :----: |</para>
        /// <para> |  **29**  | **28**  |  **9**  | **12** | **11** |</para>
        /// <para> | 21 _-x-_ |         | 7 _-x-_ |        |        |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/flex-flow</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> FlexFlow
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["flex-flow"];
            set => _properties["flex-flow"] = value;
        }

        /// <summary>
        /// The **`font`** CSS shorthand property sets all the different properties of an element's font. Alternatively, it sets an element's font to a system font.
        /// <para> **Syntax**: `[ [ &lt;'font-style'&gt; || &lt;font-variant-css21&gt; || &lt;'font-weight'&gt; || &lt;'font-stretch'&gt; ]? &lt;'font-size'&gt; [ / &lt;'line-height'&gt; ]? &lt;'font-family'&gt; ] | caption | icon | menu | message-box | small-caption | status-bar`</para>
        /// <para> | Chrome | Firefox | Safari |  Edge  |  IE   |</para>
        /// <para> | :----: | :-----: | :----: | :----: | :---: |</para>
        /// <para> | **1**  |  **1**  | **1**  | **12** | **3** |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/font</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> Font
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["font"];
            set => _properties["font"] = value;
        }

        /// <summary>
        /// The **`gap`** CSS property sets the gaps (gutters) between rows and columns. It is a shorthand for `row-gap` and `column-gap`.
        /// <para> **Syntax**: `&lt;'row-gap'&gt; &lt;'column-gap'&gt;?`</para>
        /// <para> | Chrome | Firefox |  Safari  |  Edge  | IE  |</para>
        /// <para> | :----: | :-----: | :------: | :----: | :-: |</para>
        /// <para> | **57** | **52**  | **10.1** | **16** | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/gap</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> Gap
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["gap"];
            set => _properties["gap"] = value;
        }

        /// <summary>
        /// The **`grid`** CSS property is a shorthand property that sets all of the explicit and implicit grid properties in a single declaration.
        /// <para> **Syntax**: `&lt;'grid-template'&gt; | &lt;'grid-template-rows'&gt; / [ auto-flow && dense? ] &lt;'grid-auto-columns'&gt;? | [ auto-flow && dense? ] &lt;'grid-auto-rows'&gt;? / &lt;'grid-template-columns'&gt;`</para>
        /// <para> | Chrome | Firefox |  Safari  |  Edge  | IE  |</para>
        /// <para> | :----: | :-----: | :------: | :----: | :-: |</para>
        /// <para> | **57** | **52**  | **10.1** | **16** | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/grid</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> Grid
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["grid"];
            set => _properties["grid"] = value;
        }

        /// <summary>
        /// The **`grid-area`** CSS shorthand property specifies a grid item's size and location within a grid by contributing a line, a span, or nothing (automatic) to its grid placement, thereby specifying the edges of its grid area.
        /// <para> **Syntax**: `&lt;grid-line&gt; [ / &lt;grid-line&gt; ]{0,3}`</para>
        /// <para> | Chrome | Firefox |  Safari  |  Edge  | IE  |</para>
        /// <para> | :----: | :-----: | :------: | :----: | :-: |</para>
        /// <para> | **57** | **52**  | **10.1** | **16** | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/grid-area</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> GridArea
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["grid-area"];
            set => _properties["grid-area"] = value;
        }

        /// <summary>
        /// The **`grid-column`** CSS shorthand property specifies a grid item's size and location within a grid column by contributing a line, a span, or nothing (automatic) to its grid placement, thereby specifying the inline-start and inline-end edge of its grid area.
        /// <para> **Syntax**: `&lt;grid-line&gt; [ / &lt;grid-line&gt; ]?`</para>
        /// <para> | Chrome | Firefox |  Safari  |  Edge  | IE  |</para>
        /// <para> | :----: | :-----: | :------: | :----: | :-: |</para>
        /// <para> | **57** | **52**  | **10.1** | **16** | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/grid-column</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> GridColumn
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["grid-column"];
            set => _properties["grid-column"] = value;
        }

        /// <summary>
        /// The **`grid-row`** CSS shorthand property specifies a grid item's size and location within a grid row by contributing a line, a span, or nothing (automatic) to its grid placement, thereby specifying the inline-start and inline-end edge of its grid area.
        /// <para> **Syntax**: `&lt;grid-line&gt; [ / &lt;grid-line&gt; ]?`</para>
        /// <para> | Chrome | Firefox |  Safari  |  Edge  | IE  |</para>
        /// <para> | :----: | :-----: | :------: | :----: | :-: |</para>
        /// <para> | **57** | **52**  | **10.1** | **16** | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/grid-row</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> GridRow
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["grid-row"];
            set => _properties["grid-row"] = value;
        }

        /// <summary>
        /// The **`grid-template`** CSS property is a shorthand property for defining grid columns, grid rows, and grid areas.
        /// <para> **Syntax**: `none | [ &lt;'grid-template-rows'&gt; / &lt;'grid-template-columns'&gt; ] | [ &lt;line-names&gt;? &lt;string&gt; &lt;track-size&gt;? &lt;line-names&gt;? ]+ [ / &lt;explicit-track-list&gt; ]?`</para>
        /// <para> | Chrome | Firefox |  Safari  |  Edge  | IE  |</para>
        /// <para> | :----: | :-----: | :------: | :----: | :-: |</para>
        /// <para> | **57** | **52**  | **10.1** | **16** | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/grid-template</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> GridTemplate
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["grid-template"];
            set => _properties["grid-template"] = value;
        }

        /// <summary>
        /// The **`inset`** CSS property is a shorthand that corresponds to the `top`, `right`, `bottom`, and/or `left` properties. It has the same multi-value syntax of the `margin` shorthand.
        /// <para> **Syntax**: `&lt;'top'&gt;{1,4}`</para>
        /// <para> | Chrome | Firefox |  Safari  | Edge | IE  |</para>
        /// <para> | :----: | :-----: | :------: | :--: | :-: |</para>
        /// <para> | **87** | **66**  | **14.1** | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/inset</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> Inset
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["inset"];
            set => _properties["inset"] = value;
        }

        /// <summary>
        /// The **`inset-block`** CSS property defines the logical block start and end offsets of an element, which maps to physical offsets depending on the element's writing mode, directionality, and text orientation. It corresponds to the `top` and `bottom`, or `right` and `left` properties depending on the values defined for `writing-mode`, `direction`, and `text-orientation`.
        /// <para> **Syntax**: `&lt;'top'&gt;{1,2}`</para>
        /// <para> | Chrome | Firefox |  Safari  | Edge | IE  |</para>
        /// <para> | :----: | :-----: | :------: | :--: | :-: |</para>
        /// <para> | **87** | **63**  | **14.1** | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/inset-block</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> InsetBlock
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["inset-block"];
            set => _properties["inset-block"] = value;
        }

        /// <summary>
        /// The **`inset-inline`** CSS property defines the logical start and end offsets of an element in the inline direction, which maps to physical offsets depending on the element's writing mode, directionality, and text orientation. It corresponds to the `top` and `bottom`, or `right` and `left` properties depending on the values defined for `writing-mode`, `direction`, and `text-orientation`.
        /// <para> **Syntax**: `&lt;'top'&gt;{1,2}`</para>
        /// <para> | Chrome | Firefox |  Safari  | Edge | IE  |</para>
        /// <para> | :----: | :-----: | :------: | :--: | :-: |</para>
        /// <para> | **87** | **63**  | **14.1** | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/inset-inline</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> InsetInline
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["inset-inline"];
            set => _properties["inset-inline"] = value;
        }

        /// <summary>
        /// **Syntax**: `none | &lt;integer&gt;`
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> LineClamp
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["line-clamp"];
            set => _properties["line-clamp"] = value;
        }

        /// <summary>
        /// The **`list-style`** CSS shorthand property allows you to set all the list style properties at once.
        /// <para> **Syntax**: `&lt;'list-style-type'&gt; || &lt;'list-style-position'&gt; || &lt;'list-style-image'&gt;`</para>
        /// <para> | Chrome | Firefox | Safari |  Edge  |  IE   |</para>
        /// <para> | :----: | :-----: | :----: | :----: | :---: |</para>
        /// <para> | **1**  |  **1**  | **1**  | **12** | **4** |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/list-style</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> ListStyle
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["list-style"];
            set => _properties["list-style"] = value;
        }

        /// <summary>
        /// The **`margin`** CSS shorthand property sets the margin area on all four sides of an element.
        /// <para> **Syntax**: `[ &lt;length&gt; | &lt;percentage&gt; | auto ]{1,4}`</para>
        /// <para> | Chrome | Firefox | Safari |  Edge  |  IE   |</para>
        /// <para> | :----: | :-----: | :----: | :----: | :---: |</para>
        /// <para> | **1**  |  **1**  | **1**  | **12** | **3** |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/margin</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> Margin
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["margin"];
            set => _properties["margin"] = value;
        }

        /// <summary>
        /// The **`margin-block`** CSS shorthand property defines the logical block start and end margins of an element, which maps to physical margins depending on the element's writing mode, directionality, and text orientation.
        /// <para> **Syntax**: `&lt;'margin-left'&gt;{1,2}`</para>
        /// <para> | Chrome | Firefox |  Safari  | Edge | IE  |</para>
        /// <para> | :----: | :-----: | :------: | :--: | :-: |</para>
        /// <para> | **87** | **66**  | **14.1** | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/margin-block</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MarginBlock
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["margin-block"];
            set => _properties["margin-block"] = value;
        }

        /// <summary>
        /// The **`margin-inline`** CSS shorthand property is a shorthand property that defines both the logical inline start and end margins of an element, which maps to physical margins depending on the element's writing mode, directionality, and text orientation.
        /// <para> **Syntax**: `&lt;'margin-left'&gt;{1,2}`</para>
        /// <para> | Chrome | Firefox |  Safari  | Edge | IE  |</para>
        /// <para> | :----: | :-----: | :------: | :--: | :-: |</para>
        /// <para> | **87** | **66**  | **14.1** | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/margin-inline</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MarginInline
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["margin-inline"];
            set => _properties["margin-inline"] = value;
        }

        /// <summary>
        /// The **`mask`** CSS shorthand property hides an element (partially or fully) by masking or clipping the image at specific points.
        /// <para> **Syntax**: `&lt;mask-layer&gt;#`</para>
        /// <para> | Chrome | Firefox |  Safari   | Edge  | IE  |</para>
        /// <para> | :----: | :-----: | :-------: | :---: | :-: |</para>
        /// <para> | **1**  | **53**  | **15.4**  | 12-79 | No  |</para>
        /// <para> |        |         | 3.1 _-x-_ |       |     |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/mask</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> Mask
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["mask"];
            set => _properties["mask"] = value;
        }

        /// <summary>
        /// The **`mask-border`** CSS shorthand property lets you create a mask along the edge of an element's border.
        /// <para> **Syntax**: `&lt;'mask-border-source'&gt; || &lt;'mask-border-slice'&gt; [ / &lt;'mask-border-width'&gt;? [ / &lt;'mask-border-outset'&gt; ]? ]? || &lt;'mask-border-repeat'&gt; || &lt;'mask-border-mode'&gt;`</para>
        /// <para> |              Chrome              | Firefox |             Safari             | Edge | IE  |</para>
        /// <para> | :------------------------------: | :-----: | :----------------------------: | :--: | :-: |</para>
        /// <para> | **1** _(-webkit-mask-box-image)_ |   No    |            **17.2**            | n/a  | No  |</para>
        /// <para> |                                  |         | 3.1 _(-webkit-mask-box-image)_ |      |     |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/mask-border</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MaskBorder
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["mask-border"];
            set => _properties["mask-border"] = value;
        }

        /// <summary>
        /// The **`offset`** CSS shorthand property sets all the properties required for animating an element along a defined path.
        /// <para> **Syntax**: `[ &lt;'offset-position'&gt;? [ &lt;'offset-path'&gt; [ &lt;'offset-distance'&gt; || &lt;'offset-rotate'&gt; ]? ]? ]! [ / &lt;'offset-anchor'&gt; ]?`</para>
        /// <para> |    Chrome     | Firefox | Safari | Edge | IE  |</para>
        /// <para> | :-----------: | :-----: | :----: | :--: | :-: |</para>
        /// <para> |    **55**     | **72**  | **16** | n/a  | No  |</para>
        /// <para> | 46 _(motion)_ |         |        |      |     |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/offset</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> Motion
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["motion"];
            set => _properties["motion"] = value;
        }

        /// <summary>
        /// The **`offset`** CSS shorthand property sets all the properties required for animating an element along a defined path.
        /// <para> **Syntax**: `[ &lt;'offset-position'&gt;? [ &lt;'offset-path'&gt; [ &lt;'offset-distance'&gt; || &lt;'offset-rotate'&gt; ]? ]? ]! [ / &lt;'offset-anchor'&gt; ]?`</para>
        /// <para> |    Chrome     | Firefox | Safari | Edge | IE  |</para>
        /// <para> | :-----------: | :-----: | :----: | :--: | :-: |</para>
        /// <para> |    **55**     | **72**  | **16** | n/a  | No  |</para>
        /// <para> | 46 _(motion)_ |         |        |      |     |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/offset</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> Offset
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["offset"];
            set => _properties["offset"] = value;
        }

        /// <summary>
        /// The **`outline`** CSS shorthand property sets most of the outline properties in a single declaration.
        /// <para> **Syntax**: `[ &lt;'outline-color'&gt; || &lt;'outline-style'&gt; || &lt;'outline-width'&gt; ]`</para>
        /// <para> | Chrome | Firefox |  Safari  |  Edge  |  IE   |</para>
        /// <para> | :----: | :-----: | :------: | :----: | :---: |</para>
        /// <para> | **94** | **88**  | **16.4** | **94** | **8** |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/outline</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> Outline
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["outline"];
            set => _properties["outline"] = value;
        }

        /// <summary>
        /// The **`overflow`** CSS shorthand property sets the desired behavior for an element's overflow — i.e. when an element's content is too big to fit in its block formatting context — in both directions.
        /// <para> **Syntax**: `[ visible | hidden | clip | scroll | auto ]{1,2}`</para>
        /// <para> **Initial value**: `visible`</para>
        /// <para> | Chrome | Firefox | Safari |  Edge  |  IE   |</para>
        /// <para> | :----: | :-----: | :----: | :----: | :---: |</para>
        /// <para> | **1**  |  **1**  | **1**  | **12** | **4** |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/overflow</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> Overflow
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["overflow"];
            set => _properties["overflow"] = value;
        }

        /// <summary>
        /// The **`overscroll-behavior`** CSS property sets what a browser does when reaching the boundary of a scrolling area. It's a shorthand for `overscroll-behavior-x` and `overscroll-behavior-y`.
        /// <para> **Syntax**: `[ contain | none | auto ]{1,2}`</para>
        /// <para> **Initial value**: `auto`</para>
        /// <para> | Chrome | Firefox | Safari |  Edge  | IE  |</para>
        /// <para> | :----: | :-----: | :----: | :----: | :-: |</para>
        /// <para> | **63** | **59**  | **16** | **18** | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/overscroll-behavior</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> OverscrollBehavior
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["overscroll-behavior"];
            set => _properties["overscroll-behavior"] = value;
        }

        /// <summary>
        /// The **`padding`** CSS shorthand property sets the padding area on all four sides of an element at once.
        /// <para> **Syntax**: `[ &lt;length&gt; | &lt;percentage&gt; ]{1,4}`</para>
        /// <para> | Chrome | Firefox | Safari |  Edge  |  IE   |</para>
        /// <para> | :----: | :-----: | :----: | :----: | :---: |</para>
        /// <para> | **1**  |  **1**  | **1**  | **12** | **4** |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/padding</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> Padding
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["padding"];
            set => _properties["padding"] = value;
        }

        /// <summary>
        /// The **`padding-block`** CSS shorthand property defines the logical block start and end padding of an element, which maps to physical padding properties depending on the element's writing mode, directionality, and text orientation.
        /// <para> **Syntax**: `&lt;'padding-left'&gt;{1,2}`</para>
        /// <para> | Chrome | Firefox |  Safari  | Edge | IE  |</para>
        /// <para> | :----: | :-----: | :------: | :--: | :-: |</para>
        /// <para> | **87** | **66**  | **14.1** | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/padding-block</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> PaddingBlock
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["padding-block"];
            set => _properties["padding-block"] = value;
        }

        /// <summary>
        /// The **`padding-inline`** CSS shorthand property defines the logical inline start and end padding of an element, which maps to physical padding properties depending on the element's writing mode, directionality, and text orientation.
        /// <para> **Syntax**: `&lt;'padding-left'&gt;{1,2}`</para>
        /// <para> | Chrome | Firefox |  Safari  | Edge | IE  |</para>
        /// <para> | :----: | :-----: | :------: | :--: | :-: |</para>
        /// <para> | **87** | **66**  | **14.1** | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/padding-inline</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> PaddingInline
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["padding-inline"];
            set => _properties["padding-inline"] = value;
        }

        /// <summary>
        /// The **`place-content`** CSS shorthand property allows you to align content along both the block and inline directions at once (i.e. the `align-content` and `justify-content` properties) in a relevant layout system such as Grid or Flexbox.
        /// <para> **Syntax**: `&lt;'align-content'&gt; &lt;'justify-content'&gt;?`</para>
        /// <para> | Chrome | Firefox | Safari | Edge | IE  |</para>
        /// <para> | :----: | :-----: | :----: | :--: | :-: |</para>
        /// <para> | **59** | **45**  | **9**  | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/place-content</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> PlaceContent
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["place-content"];
            set => _properties["place-content"] = value;
        }

        /// <summary>
        /// The CSS **`place-items`** shorthand property allows you to align items along both the block and inline directions at once (i.e. the `align-items` and `justify-items` properties) in a relevant layout system such as Grid or Flexbox. If the second value is not set, the first value is also used for it.
        /// <para> **Syntax**: `&lt;'align-items'&gt; &lt;'justify-items'&gt;?`</para>
        /// <para> | Chrome | Firefox | Safari | Edge | IE  |</para>
        /// <para> | :----: | :-----: | :----: | :--: | :-: |</para>
        /// <para> | **59** | **45**  | **11** | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/place-items</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> PlaceItems
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["place-items"];
            set => _properties["place-items"] = value;
        }

        /// <summary>
        /// The **`place-self`** CSS shorthand property allows you to align an individual item in both the block and inline directions at once (i.e. the `align-self` and `justify-self` properties) in a relevant layout system such as Grid or Flexbox. If the second value is not present, the first value is also used for it.
        /// <para> **Syntax**: `&lt;'align-self'&gt; &lt;'justify-self'&gt;?`</para>
        /// <para> | Chrome | Firefox | Safari | Edge | IE  |</para>
        /// <para> | :----: | :-----: | :----: | :--: | :-: |</para>
        /// <para> | **59** | **45**  | **11** | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/place-self</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> PlaceSelf
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["place-self"];
            set => _properties["place-self"] = value;
        }

        /// <summary>
        /// The **`scroll-margin`** shorthand property sets all of the scroll margins of an element at once, assigning values much like the `margin` property does for margins of an element.
        /// <para> **Syntax**: `&lt;length&gt;{1,4}`</para>
        /// <para> | Chrome | Firefox |          Safari           | Edge | IE  |</para>
        /// <para> | :----: | :-----: | :-----------------------: | :--: | :-: |</para>
        /// <para> | **69** | **90**  |         **14.1**          | n/a  | No  |</para>
        /// <para> |        |         | 11 _(scroll-snap-margin)_ |      |     |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/scroll-margin</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> ScrollMargin
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["scroll-margin"];
            set => _properties["scroll-margin"] = value;
        }

        /// <summary>
        /// The `scroll-margin-block` shorthand property sets the scroll margins of an element in the block dimension.
        /// <para> **Syntax**: `&lt;length&gt;{1,2}`</para>
        /// <para> | Chrome | Firefox | Safari | Edge | IE  |</para>
        /// <para> | :----: | :-----: | :----: | :--: | :-: |</para>
        /// <para> | **69** | **68**  | **15** | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/scroll-margin-block</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> ScrollMarginBlock
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["scroll-margin-block"];
            set => _properties["scroll-margin-block"] = value;
        }

        /// <summary>
        /// The `scroll-margin-inline` shorthand property sets the scroll margins of an element in the inline dimension.
        /// <para> **Syntax**: `&lt;length&gt;{1,2}`</para>
        /// <para> | Chrome | Firefox | Safari | Edge | IE  |</para>
        /// <para> | :----: | :-----: | :----: | :--: | :-: |</para>
        /// <para> | **69** | **68**  | **15** | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/scroll-margin-inline</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> ScrollMarginInline
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["scroll-margin-inline"];
            set => _properties["scroll-margin-inline"] = value;
        }

        /// <summary>
        /// The **`scroll-padding`** shorthand property sets scroll padding on all sides of an element at once, much like the `padding` property does for padding on an element.
        /// <para> **Syntax**: `[ auto | &lt;length-percentage&gt; ]{1,4}`</para>
        /// <para> | Chrome | Firefox |  Safari  | Edge | IE  |</para>
        /// <para> | :----: | :-----: | :------: | :--: | :-: |</para>
        /// <para> | **69** | **68**  | **14.1** | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/scroll-padding</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> ScrollPadding
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["scroll-padding"];
            set => _properties["scroll-padding"] = value;
        }

        /// <summary>
        /// The `scroll-padding-block` shorthand property sets the scroll padding of an element in the block dimension.
        /// <para> **Syntax**: `[ auto | &lt;length-percentage&gt; ]{1,2}`</para>
        /// <para> | Chrome | Firefox | Safari | Edge | IE  |</para>
        /// <para> | :----: | :-----: | :----: | :--: | :-: |</para>
        /// <para> | **69** | **68**  | **15** | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/scroll-padding-block</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> ScrollPaddingBlock
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["scroll-padding-block"];
            set => _properties["scroll-padding-block"] = value;
        }

        /// <summary>
        /// The `scroll-padding-inline` shorthand property sets the scroll padding of an element in the inline dimension.
        /// <para> **Syntax**: `[ auto | &lt;length-percentage&gt; ]{1,2}`</para>
        /// <para> | Chrome | Firefox | Safari | Edge | IE  |</para>
        /// <para> | :----: | :-----: | :----: | :--: | :-: |</para>
        /// <para> | **69** | **68**  | **15** | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/scroll-padding-inline</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> ScrollPaddingInline
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["scroll-padding-inline"];
            set => _properties["scroll-padding-inline"] = value;
        }

        /// <summary>
        /// The **`scroll-margin`** shorthand property sets all of the scroll margins of an element at once, assigning values much like the `margin` property does for margins of an element.
        /// <para> **Syntax**: `&lt;length&gt;{1,4}`</para>
        /// <para> | Chrome | Firefox |          Safari           | Edge | IE  |</para>
        /// <para> | :----: | :-----: | :-----------------------: | :--: | :-: |</para>
        /// <para> | **69** |  68-90  |         **14.1**          | n/a  | No  |</para>
        /// <para> |        |         | 11 _(scroll-snap-margin)_ |      |     |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/scroll-margin</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> ScrollSnapMargin
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["scroll-snap-margin"];
            set => _properties["scroll-snap-margin"] = value;
        }

        /// <summary>
        /// The **`scroll-timeline`** CSS shorthand property defines a name that can be used to identify the source element of a scroll timeline, along with the scrollbar axis that should provide the timeline.
        /// <para> **Syntax**: `[ &lt;'scroll-timeline-name'&gt; &lt;'scroll-timeline-axis'&gt;? ]#`</para>
        /// <para> | Chrome  | Firefox | Safari | Edge | IE  |</para>
        /// <para> | :-----: | :-----: | :----: | :--: | :-: |</para>
        /// <para> | **115** |   n/a   |   No   | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/scroll-timeline</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> ScrollTimeline
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["scroll-timeline"];
            set => _properties["scroll-timeline"] = value;
        }

        /// <summary>
        /// The **`text-decoration`** shorthand CSS property sets the appearance of decorative lines on text. It is a shorthand for `text-decoration-line`, `text-decoration-color`, `text-decoration-style`, and the newer `text-decoration-thickness` property.
        /// <para> **Syntax**: `&lt;'text-decoration-line'&gt; || &lt;'text-decoration-style'&gt; || &lt;'text-decoration-color'&gt; || &lt;'text-decoration-thickness'&gt;`</para>
        /// <para> | Chrome | Firefox | Safari |  Edge  |  IE   |</para>
        /// <para> | :----: | :-----: | :----: | :----: | :---: |</para>
        /// <para> | **1**  |  **1**  | **1**  | **12** | **3** |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/text-decoration</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> TextDecoration
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["text-decoration"];
            set => _properties["text-decoration"] = value;
        }

        /// <summary>
        /// The **`text-emphasis`** CSS property applies emphasis marks to text (except spaces and control characters). It is a shorthand for `text-emphasis-style` and `text-emphasis-color`.
        /// <para> **Syntax**: `&lt;'text-emphasis-style'&gt; || &lt;'text-emphasis-color'&gt;`</para>
        /// <para> |  Chrome  | Firefox | Safari | Edge | IE  |</para>
        /// <para> | :------: | :-----: | :----: | :--: | :-: |</para>
        /// <para> |  **99**  | **46**  | **7**  | n/a  | No  |</para>
        /// <para> | 25 _-x-_ |         |        |      |     |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/text-emphasis</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> TextEmphasis
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["text-emphasis"];
            set => _properties["text-emphasis"] = value;
        }

        /// <summary>
        /// The **`transition`** CSS property is a shorthand property for `transition-property`, `transition-duration`, `transition-timing-function`, and `transition-delay`.
        /// <para> **Syntax**: `&lt;single-transition&gt;#`</para>
        /// <para> | Chrome  | Firefox |  Safari   |  Edge  |   IE   |</para>
        /// <para> | :-----: | :-----: | :-------: | :----: | :----: |</para>
        /// <para> | **26**  | **16**  |   **9**   | **12** | **10** |</para>
        /// <para> | 1 _-x-_ |         | 3.1 _-x-_ |        |        |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/transition</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> Transition
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["transition"];
            set => _properties["transition"] = value;
        }

        /// <summary>
        /// The **`view-timeline`** CSS shorthand property is used to define a _named view progress timeline_, which is progressed through based on the change in visibility of an element (known as the _subject_) inside a scrollable element (_scroller_). `view-timeline` is set on the subject.
        /// <para> **Syntax**: `[ &lt;'view-timeline-name'&gt; &lt;'view-timeline-axis'&gt;? ]#`</para>
        /// <para> | Chrome  | Firefox | Safari | Edge | IE  |</para>
        /// <para> | :-----: | :-----: | :----: | :--: | :-: |</para>
        /// <para> | **115** |   n/a   |   No   | n/a  | No  |</para>
        /// <para> @see https://developer.mozilla.org/docs/Web/CSS/view-timeline</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> ViewTimeline
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["view-timeline"];
            set => _properties["view-timeline"] = value;
        }

    }
}
