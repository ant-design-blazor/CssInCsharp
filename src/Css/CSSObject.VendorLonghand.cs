namespace CssInCSharp
{
    public partial class CSSObject
    {
        /// <summary>
        /// The **`animation-delay`** CSS property specifies the amount of time to wait from applying the animation to an element before beginning to perform the animation. The animation can start later, immediately from its beginning, or immediately and partway through the animation.
        /// <para> **Syntax**: `&lt;time&gt;#`</para>
        /// <para> **Initial value**: `0s`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozAnimationDelay
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-animation-delay"];
            set => _properties["-moz-animation-delay"] = value;
        }

        /// <summary>
        /// The **`animation-direction`** CSS property sets whether an animation should play forward, backward, or alternate back and forth between playing the sequence forward and backward.
        /// <para> **Syntax**: `&lt;single-animation-direction&gt;#`</para>
        /// <para> **Initial value**: `normal`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozAnimationDirection
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-animation-direction"];
            set => _properties["-moz-animation-direction"] = value;
        }

        /// <summary>
        /// The **`animation-duration`** CSS property sets the length of time that an animation takes to complete one cycle.
        /// <para> **Syntax**: `&lt;time&gt;#`</para>
        /// <para> **Initial value**: `0s`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozAnimationDuration
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-animation-duration"];
            set => _properties["-moz-animation-duration"] = value;
        }

        /// <summary>
        /// The **`animation-fill-mode`** CSS property sets how a CSS animation applies styles to its target before and after its execution.
        /// <para> **Syntax**: `&lt;single-animation-fill-mode&gt;#`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozAnimationFillMode
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-animation-fill-mode"];
            set => _properties["-moz-animation-fill-mode"] = value;
        }

        /// <summary>
        /// The **`animation-iteration-count`** CSS property sets the number of times an animation sequence should be played before stopping.
        /// <para> **Syntax**: `&lt;single-animation-iteration-count&gt;#`</para>
        /// <para> **Initial value**: `1`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MozAnimationIterationCount
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-animation-iteration-count"];
            set => _properties["-moz-animation-iteration-count"] = value;
        }

        /// <summary>
        /// The **`animation-name`** CSS property specifies the names of one or more `@keyframes` at-rules that describe the animation to apply to an element. Multiple `@keyframe` at-rules are specified as a comma-separated list of names. If the specified name does not match any `@keyframe` at-rule, no properties are animated.
        /// <para> **Syntax**: `[ none | &lt;keyframes-name&gt; ]#`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, Keyframe> MozAnimationName
        {
            get => (Property<CSSProperties, PropertySkip, string, Keyframe>) _properties["-moz-animation-name"];
            set => _properties["-moz-animation-name"] = value;
        }

        /// <summary>
        /// The **`animation-play-state`** CSS property sets whether an animation is running or paused.
        /// <para> **Syntax**: `&lt;single-animation-play-state&gt;#`</para>
        /// <para> **Initial value**: `running`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozAnimationPlayState
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-animation-play-state"];
            set => _properties["-moz-animation-play-state"] = value;
        }

        /// <summary>
        /// The **`animation-timing-function`** CSS property sets how an animation progresses through the duration of each cycle.
        /// <para> **Syntax**: `&lt;easing-function&gt;#`</para>
        /// <para> **Initial value**: `ease`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozAnimationTimingFunction
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-animation-timing-function"];
            set => _properties["-moz-animation-timing-function"] = value;
        }

        /// <summary>
        /// The **`appearance`** CSS property is used to control native appearance of UI controls, that are based on operating system's theme.
        /// <para> **Syntax**: `none | button | button-arrow-down | button-arrow-next | button-arrow-previous | button-arrow-up | button-bevel | button-focus | caret | checkbox | checkbox-container | checkbox-label | checkmenuitem | dualbutton | groupbox | listbox | listitem | menuarrow | menubar | menucheckbox | menuimage | menuitem | menuitemtext | menulist | menulist-button | menulist-text | menulist-textfield | menupopup | menuradio | menuseparator | meterbar | meterchunk | progressbar | progressbar-vertical | progresschunk | progresschunk-vertical | radio | radio-container | radio-label | radiomenuitem | range | range-thumb | resizer | resizerpanel | scale-horizontal | scalethumbend | scalethumb-horizontal | scalethumbstart | scalethumbtick | scalethumb-vertical | scale-vertical | scrollbarbutton-down | scrollbarbutton-left | scrollbarbutton-right | scrollbarbutton-up | scrollbarthumb-horizontal | scrollbarthumb-vertical | scrollbartrack-horizontal | scrollbartrack-vertical | searchfield | separator | sheet | spinner | spinner-downbutton | spinner-textfield | spinner-upbutton | splitter | statusbar | statusbarpanel | tab | tabpanel | tabpanels | tab-scroll-arrow-back | tab-scroll-arrow-forward | textfield | textfield-multiline | toolbar | toolbarbutton | toolbarbutton-dropdown | toolbargripper | toolbox | tooltip | treeheader | treeheadercell | treeheadersortarrow | treeitem | treeline | treetwisty | treetwistyopen | treeview | -moz-mac-unified-toolbar | -moz-win-borderless-glass | -moz-win-browsertabbar-toolbox | -moz-win-communicationstext | -moz-win-communications-toolbox | -moz-win-exclude-glass | -moz-win-glass | -moz-win-mediatext | -moz-win-media-toolbox | -moz-window-button-box | -moz-window-button-box-maximized | -moz-window-button-close | -moz-window-button-maximize | -moz-window-button-minimize | -moz-window-button-restore | -moz-window-frame-bottom | -moz-window-frame-left | -moz-window-frame-right | -moz-window-titlebar | -moz-window-titlebar-maximized`</para>
        /// <para> **Initial value**: `none` (but this value is overridden in the user agent CSS)</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozAppearance
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-appearance"];
            set => _properties["-moz-appearance"] = value;
        }

        /// <summary>
        /// The **`-moz-binding`** CSS property is used by Mozilla-based applications to attach an XBL binding to a DOM element.
        /// <para> **Syntax**: `&lt;url&gt; | none`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozBinding
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-binding"];
            set => _properties["-moz-binding"] = value;
        }

        /// <summary>
        /// In Mozilla applications like Firefox, the **`-moz-border-bottom-colors`** CSS property sets a list of colors for the bottom border.
        /// <para> **Syntax**: `&lt;color&gt;+ | none`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozBorderBottomColors
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-border-bottom-colors"];
            set => _properties["-moz-border-bottom-colors"] = value;
        }

        /// <summary>
        /// The **`border-inline-end-color`** CSS property defines the color of the logical inline-end border of an element, which maps to a physical border color depending on the element's writing mode, directionality, and text orientation. It corresponds to the `border-top-color`, `border-right-color`, `border-bottom-color`, or `border-left-color` property depending on the values defined for `writing-mode`, `direction`, and `text-orientation`.
        /// <para> **Syntax**: `&lt;'border-top-color'&gt;`</para>
        /// <para> **Initial value**: `currentcolor`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozBorderEndColor
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-border-end-color"];
            set => _properties["-moz-border-end-color"] = value;
        }

        /// <summary>
        /// The **`border-inline-end-style`** CSS property defines the style of the logical inline end border of an element, which maps to a physical border style depending on the element's writing mode, directionality, and text orientation. It corresponds to the `border-top-style`, `border-right-style`, `border-bottom-style`, or `border-left-style` property depending on the values defined for `writing-mode`, `direction`, and `text-orientation`.
        /// <para> **Syntax**: `&lt;'border-top-style'&gt;`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozBorderEndStyle
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-border-end-style"];
            set => _properties["-moz-border-end-style"] = value;
        }

        /// <summary>
        /// The **`border-inline-end-width`** CSS property defines the width of the logical inline-end border of an element, which maps to a physical border width depending on the element's writing mode, directionality, and text orientation. It corresponds to the `border-top-width`, `border-right-width`, `border-bottom-width`, or `border-left-width` property depending on the values defined for `writing-mode`, `direction`, and `text-orientation`.
        /// <para> **Syntax**: `&lt;'border-top-width'&gt;`</para>
        /// <para> **Initial value**: `medium`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MozBorderEndWidth
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-border-end-width"];
            set => _properties["-moz-border-end-width"] = value;
        }

        /// <summary>
        /// In Mozilla applications like Firefox, the **`-moz-border-left-colors`** CSS property sets a list of colors for the left border.
        /// <para> **Syntax**: `&lt;color&gt;+ | none`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozBorderLeftColors
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-border-left-colors"];
            set => _properties["-moz-border-left-colors"] = value;
        }

        /// <summary>
        /// In Mozilla applications like Firefox, the **`-moz-border-right-colors`** CSS property sets a list of colors for the right border.
        /// <para> **Syntax**: `&lt;color&gt;+ | none`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozBorderRightColors
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-border-right-colors"];
            set => _properties["-moz-border-right-colors"] = value;
        }

        /// <summary>
        /// The **`border-inline-start-color`** CSS property defines the color of the logical inline start border of an element, which maps to a physical border color depending on the element's writing mode, directionality, and text orientation. It corresponds to the `border-top-color`, `border-right-color`, `border-bottom-color`, or `border-left-color` property depending on the values defined for `writing-mode`, `direction`, and `text-orientation`.
        /// <para> **Syntax**: `&lt;'border-top-color'&gt;`</para>
        /// <para> **Initial value**: `currentcolor`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozBorderStartColor
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-border-start-color"];
            set => _properties["-moz-border-start-color"] = value;
        }

        /// <summary>
        /// The **`border-inline-start-style`** CSS property defines the style of the logical inline start border of an element, which maps to a physical border style depending on the element's writing mode, directionality, and text orientation. It corresponds to the `border-top-style`, `border-right-style`, `border-bottom-style`, or `border-left-style` property depending on the values defined for `writing-mode`, `direction`, and `text-orientation`.
        /// <para> **Syntax**: `&lt;'border-top-style'&gt;`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozBorderStartStyle
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-border-start-style"];
            set => _properties["-moz-border-start-style"] = value;
        }

        /// <summary>
        /// In Mozilla applications like Firefox, the **`-moz-border-top-colors`** CSS property sets a list of colors for the top border.
        /// <para> **Syntax**: `&lt;color&gt;+ | none`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozBorderTopColors
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-border-top-colors"];
            set => _properties["-moz-border-top-colors"] = value;
        }

        /// <summary>
        /// The **`box-sizing`** CSS property sets how the total width and height of an element is calculated.
        /// <para> **Syntax**: `content-box | border-box`</para>
        /// <para> **Initial value**: `content-box`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozBoxSizing
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-box-sizing"];
            set => _properties["-moz-box-sizing"] = value;
        }

        /// <summary>
        /// The **`column-count`** CSS property breaks an element's content into the specified number of columns.
        /// <para> **Syntax**: `&lt;integer&gt; | auto`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MozColumnCount
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-column-count"];
            set => _properties["-moz-column-count"] = value;
        }

        /// <summary>
        /// The **`column-fill`** CSS property controls how an element's contents are balanced when broken into columns.
        /// <para> **Syntax**: `auto | balance | balance-all`</para>
        /// <para> **Initial value**: `balance`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozColumnFill
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-column-fill"];
            set => _properties["-moz-column-fill"] = value;
        }

        /// <summary>
        /// The **`column-rule-color`** CSS property sets the color of the line drawn between columns in a multi-column layout.
        /// <para> **Syntax**: `&lt;color&gt;`</para>
        /// <para> **Initial value**: `currentcolor`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozColumnRuleColor
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-column-rule-color"];
            set => _properties["-moz-column-rule-color"] = value;
        }

        /// <summary>
        /// The **`column-rule-style`** CSS property sets the style of the line drawn between columns in a multi-column layout.
        /// <para> **Syntax**: `&lt;'border-style'&gt;`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozColumnRuleStyle
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-column-rule-style"];
            set => _properties["-moz-column-rule-style"] = value;
        }

        /// <summary>
        /// The **`column-rule-width`** CSS property sets the width of the line drawn between columns in a multi-column layout.
        /// <para> **Syntax**: `&lt;'border-width'&gt;`</para>
        /// <para> **Initial value**: `medium`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MozColumnRuleWidth
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-column-rule-width"];
            set => _properties["-moz-column-rule-width"] = value;
        }

        /// <summary>
        /// The **`column-width`** CSS property sets the ideal column width in a multi-column layout. The container will have as many columns as can fit without any of them having a width less than the `column-width` value. If the width of the container is narrower than the specified value, the single column's width will be smaller than the declared column width.
        /// <para> **Syntax**: `&lt;length&gt; | auto`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MozColumnWidth
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-column-width"];
            set => _properties["-moz-column-width"] = value;
        }

        /// <summary>
        /// The **`-moz-context-properties`** property can be used within privileged contexts in Firefox to share the values of specified properties of the element with a child SVG image.
        /// <para> **Syntax**: `none | [ fill | fill-opacity | stroke | stroke-opacity ]#`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozContextProperties
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-context-properties"];
            set => _properties["-moz-context-properties"] = value;
        }

        /// <summary>
        /// The **`font-feature-settings`** CSS property controls advanced typographic features in OpenType fonts.
        /// <para> **Syntax**: `normal | &lt;feature-tag-value&gt;#`</para>
        /// <para> **Initial value**: `normal`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozFontFeatureSettings
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-font-feature-settings"];
            set => _properties["-moz-font-feature-settings"] = value;
        }

        /// <summary>
        /// The **`font-language-override`** CSS property controls the use of language-specific glyphs in a typeface.
        /// <para> **Syntax**: `normal | &lt;string&gt;`</para>
        /// <para> **Initial value**: `normal`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozFontLanguageOverride
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-font-language-override"];
            set => _properties["-moz-font-language-override"] = value;
        }

        /// <summary>
        /// The **`hyphens`** CSS property specifies how words should be hyphenated when text wraps across multiple lines. It can prevent hyphenation entirely, hyphenate at manually-specified points within the text, or let the browser automatically insert hyphens where appropriate.
        /// <para> **Syntax**: `none | manual | auto`</para>
        /// <para> **Initial value**: `manual`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozHyphens
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-hyphens"];
            set => _properties["-moz-hyphens"] = value;
        }

        /// <summary>
        /// For certain XUL elements and pseudo-elements that use an image from the `list-style-image` property, this property specifies a region of the image that is used in place of the whole image. This allows elements to use different pieces of the same image to improve performance.
        /// <para> **Syntax**: `&lt;shape&gt; | auto`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozImageRegion
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-image-region"];
            set => _properties["-moz-image-region"] = value;
        }

        /// <summary>
        /// The **`margin-inline-end`** CSS property defines the logical inline end margin of an element, which maps to a physical margin depending on the element's writing mode, directionality, and text orientation. In other words, it corresponds to the `margin-top`, `margin-right`, `margin-bottom` or `margin-left` property depending on the values defined for `writing-mode`, `direction`, and `text-orientation`.
        /// <para> **Syntax**: `&lt;'margin-left'&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MozMarginEnd
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-margin-end"];
            set => _properties["-moz-margin-end"] = value;
        }

        /// <summary>
        /// The **`margin-inline-start`** CSS property defines the logical inline start margin of an element, which maps to a physical margin depending on the element's writing mode, directionality, and text orientation. It corresponds to the `margin-top`, `margin-right`, `margin-bottom`, or `margin-left` property depending on the values defined for `writing-mode`, `direction`, and `text-orientation`.
        /// <para> **Syntax**: `&lt;'margin-left'&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MozMarginStart
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-margin-start"];
            set => _properties["-moz-margin-start"] = value;
        }

        /// <summary>
        /// The **`-moz-orient`** CSS property specifies the orientation of the element to which it's applied.
        /// <para> **Syntax**: `inline | block | horizontal | vertical`</para>
        /// <para> **Initial value**: `inline`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozOrient
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-orient"];
            set => _properties["-moz-orient"] = value;
        }

        /// <summary>
        /// The **`font-smooth`** CSS property controls the application of anti-aliasing when fonts are rendered.
        /// <para> **Syntax**: `auto | never | always | &lt;absolute-size&gt; | &lt;length&gt;`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MozOsxFontSmoothing
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-osx-font-smoothing"];
            set => _properties["-moz-osx-font-smoothing"] = value;
        }

        /// <summary>
        /// In Mozilla applications, the **`-moz-outline-radius-bottomleft`** CSS property can be used to round the bottom-left corner of an element's `outline`.
        /// <para> **Syntax**: `&lt;outline-radius&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MozOutlineRadiusBottomleft
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-outline-radius-bottomleft"];
            set => _properties["-moz-outline-radius-bottomleft"] = value;
        }

        /// <summary>
        /// In Mozilla applications, the **`-moz-outline-radius-bottomright`** CSS property can be used to round the bottom-right corner of an element's `outline`.
        /// <para> **Syntax**: `&lt;outline-radius&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MozOutlineRadiusBottomright
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-outline-radius-bottomright"];
            set => _properties["-moz-outline-radius-bottomright"] = value;
        }

        /// <summary>
        /// In Mozilla applications, the **`-moz-outline-radius-topleft`** CSS property can be used to round the top-left corner of an element's `outline`.
        /// <para> **Syntax**: `&lt;outline-radius&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MozOutlineRadiusTopleft
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-outline-radius-topleft"];
            set => _properties["-moz-outline-radius-topleft"] = value;
        }

        /// <summary>
        /// In Mozilla applications, the **`-moz-outline-radius-topright`** CSS property can be used to round the top-right corner of an element's `outline`.
        /// <para> **Syntax**: `&lt;outline-radius&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MozOutlineRadiusTopright
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-outline-radius-topright"];
            set => _properties["-moz-outline-radius-topright"] = value;
        }

        /// <summary>
        /// The **`padding-inline-end`** CSS property defines the logical inline end padding of an element, which maps to a physical padding depending on the element's writing mode, directionality, and text orientation.
        /// <para> **Syntax**: `&lt;'padding-left'&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MozPaddingEnd
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-padding-end"];
            set => _properties["-moz-padding-end"] = value;
        }

        /// <summary>
        /// The **`padding-inline-start`** CSS property defines the logical inline start padding of an element, which maps to a physical padding depending on the element's writing mode, directionality, and text orientation.
        /// <para> **Syntax**: `&lt;'padding-left'&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MozPaddingStart
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-padding-start"];
            set => _properties["-moz-padding-start"] = value;
        }

        /// <summary>
        /// **`-moz-stack-sizing`** is an extended CSS property. Normally, a `&lt;xul:stack&gt;` will change its size so that all of its child elements are completely visible. For example, moving a child of the stack far to the right will widen the stack so the child remains visible.
        /// <para> **Syntax**: `ignore | stretch-to-fit`</para>
        /// <para> **Initial value**: `stretch-to-fit`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozStackSizing
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-stack-sizing"];
            set => _properties["-moz-stack-sizing"] = value;
        }

        /// <summary>
        /// The **`tab-size`** CSS property is used to customize the width of tab characters (U+0009).
        /// <para> **Syntax**: `&lt;integer&gt; | &lt;length&gt;`</para>
        /// <para> **Initial value**: `8`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MozTabSize
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-moz-tab-size"];
            set => _properties["-moz-tab-size"] = value;
        }

        /// <summary>
        /// The **`-moz-text-blink`** non-standard Mozilla CSS extension specifies the blink mode.
        /// <para> **Syntax**: `none | blink`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozTextBlink
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-text-blink"];
            set => _properties["-moz-text-blink"] = value;
        }

        /// <summary>
        /// The **`text-size-adjust`** CSS property controls the text inflation algorithm used on some smartphones and tablets. Other browsers will ignore this property.
        /// <para> **Syntax**: `none | auto | &lt;percentage&gt;`</para>
        /// <para> **Initial value**: `auto` for smartphone browsers supporting inflation, `none` in other cases (and then not modifiable).</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozTextSizeAdjust
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-text-size-adjust"];
            set => _properties["-moz-text-size-adjust"] = value;
        }

        /// <summary>
        /// The **`-moz-user-focus`** CSS property is used to indicate whether an element can have the focus.
        /// <para> **Syntax**: `ignore | normal | select-after | select-before | select-menu | select-same | select-all | none`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozUserFocus
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-user-focus"];
            set => _properties["-moz-user-focus"] = value;
        }

        /// <summary>
        /// The **`user-modify`** property has no effect in Firefox. It was originally planned to determine whether or not the content of an element can be edited by a user.
        /// <para> **Syntax**: `read-only | read-write | write-only`</para>
        /// <para> **Initial value**: `read-only`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozUserModify
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-user-modify"];
            set => _properties["-moz-user-modify"] = value;
        }

        /// <summary>
        /// The **`user-select`** CSS property controls whether the user can select text. This doesn't have any effect on content loaded as part of a browser's user interface (its chrome), except in textboxes.
        /// <para> **Syntax**: `auto | text | none | contain | all`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozUserSelect
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-user-select"];
            set => _properties["-moz-user-select"] = value;
        }

        /// <summary>
        /// The **`-moz-window-dragging`** CSS property specifies whether a window is draggable or not. It only works in Chrome code, and only on Mac OS X.
        /// <para> **Syntax**: `drag | no-drag`</para>
        /// <para> **Initial value**: `drag`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozWindowDragging
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-window-dragging"];
            set => _properties["-moz-window-dragging"] = value;
        }

        /// <summary>
        /// The **`-moz-window-shadow`** CSS property specifies whether a window will have a shadow. It only works on Mac OS X.
        /// <para> **Syntax**: `default | menu | tooltip | sheet | none`</para>
        /// <para> **Initial value**: `default`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MozWindowShadow
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-moz-window-shadow"];
            set => _properties["-moz-window-shadow"] = value;
        }

        /// <summary>
        /// The **`-ms-accelerator`** CSS property is a Microsoft extension that sets or retrieves a string indicating whether the object represents a keyboard shortcut.
        /// <para> **Syntax**: `false | true`</para>
        /// <para> **Initial value**: `false`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsAccelerator
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-accelerator"];
            set => _properties["-ms-accelerator"] = value;
        }

        /// <summary>
        /// The **`-ms-block-progression`** CSS property is a Microsoft extension that specifies the block progression and layout orientation.
        /// <para> **Syntax**: `tb | rl | bt | lr`</para>
        /// <para> **Initial value**: `tb`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsBlockProgression
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-block-progression"];
            set => _properties["-ms-block-progression"] = value;
        }

        /// <summary>
        /// The **`-ms-content-zoom-chaining`** CSS property is a Microsoft extension specifying the zoom behavior that occurs when a user hits the zoom limit during page manipulation.
        /// <para> **Syntax**: `none | chained`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsContentZoomChaining
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-content-zoom-chaining"];
            set => _properties["-ms-content-zoom-chaining"] = value;
        }

        /// <summary>
        /// The **`-ms-content-zoom-limit-max`** CSS property is a Microsoft extension that specifies the selected elements' maximum zoom factor.
        /// <para> **Syntax**: `&lt;percentage&gt;`</para>
        /// <para> **Initial value**: `400%`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsContentZoomLimitMax
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-content-zoom-limit-max"];
            set => _properties["-ms-content-zoom-limit-max"] = value;
        }

        /// <summary>
        /// The **`-ms-content-zoom-limit-min`** CSS property is a Microsoft extension that specifies the minimum zoom factor.
        /// <para> **Syntax**: `&lt;percentage&gt;`</para>
        /// <para> **Initial value**: `100%`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsContentZoomLimitMin
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-content-zoom-limit-min"];
            set => _properties["-ms-content-zoom-limit-min"] = value;
        }

        /// <summary>
        /// The **`-ms-content-zoom-snap-points`** CSS property is a Microsoft extension that specifies where zoom snap-points are located.
        /// <para> **Syntax**: `snapInterval( &lt;percentage&gt;, &lt;percentage&gt; ) | snapList( &lt;percentage&gt;# )`</para>
        /// <para> **Initial value**: `snapInterval(0%, 100%)`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsContentZoomSnapPoints
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-content-zoom-snap-points"];
            set => _properties["-ms-content-zoom-snap-points"] = value;
        }

        /// <summary>
        /// The **`-ms-content-zoom-snap-type`** CSS property is a Microsoft extension that specifies how zooming is affected by defined snap-points.
        /// <para> **Syntax**: `none | proximity | mandatory`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsContentZoomSnapType
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-content-zoom-snap-type"];
            set => _properties["-ms-content-zoom-snap-type"] = value;
        }

        /// <summary>
        /// The **`-ms-content-zooming`** CSS property is a Microsoft extension that specifies whether zooming is enabled.
        /// <para> **Syntax**: `none | zoom`</para>
        /// <para> **Initial value**: zoom for the top level element, none for all other elements</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsContentZooming
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-content-zooming"];
            set => _properties["-ms-content-zooming"] = value;
        }

        /// <summary>
        /// The `-ms-filter` CSS property is a Microsoft extension that sets or retrieves the filter or collection of filters applied to an object.
        /// <para> **Syntax**: `&lt;string&gt;`</para>
        /// <para> **Initial value**: "" (the empty string)</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsFilter
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-filter"];
            set => _properties["-ms-filter"] = value;
        }

        /// <summary>
        /// The **`flex-direction`** CSS property sets how flex items are placed in the flex container defining the main axis and the direction (normal or reversed).
        /// <para> **Syntax**: `row | row-reverse | column | column-reverse`</para>
        /// <para> **Initial value**: `row`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsFlexDirection
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-flex-direction"];
            set => _properties["-ms-flex-direction"] = value;
        }

        /// <summary>
        /// The **`flex-grow`** CSS property sets the flex grow factor of a flex item's main size.
        /// <para> **Syntax**: `&lt;number&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MsFlexPositive
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-ms-flex-positive"];
            set => _properties["-ms-flex-positive"] = value;
        }

        /// <summary>
        /// The **`-ms-flow-from`** CSS property is a Microsoft extension that gets or sets a value identifying a region container in the document that accepts the content flow from the data source.
        /// <para> **Syntax**: `[ none | &lt;custom-ident&gt; ]#`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsFlowFrom
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-flow-from"];
            set => _properties["-ms-flow-from"] = value;
        }

        /// <summary>
        /// The **`-ms-flow-into`** CSS property is a Microsoft extension that gets or sets a value identifying an iframe container in the document that serves as the region's data source.
        /// <para> **Syntax**: `[ none | &lt;custom-ident&gt; ]#`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsFlowInto
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-flow-into"];
            set => _properties["-ms-flow-into"] = value;
        }

        /// <summary>
        /// The **`grid-template-columns`** CSS property defines the line names and track sizing functions of the grid columns.
        /// <para> **Syntax**: `none | &lt;track-list&gt; | &lt;auto-track-list&gt;`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MsGridColumns
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-ms-grid-columns"];
            set => _properties["-ms-grid-columns"] = value;
        }

        /// <summary>
        /// The **`grid-template-rows`** CSS property defines the line names and track sizing functions of the grid rows.
        /// <para> **Syntax**: `none | &lt;track-list&gt; | &lt;auto-track-list&gt;`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MsGridRows
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-ms-grid-rows"];
            set => _properties["-ms-grid-rows"] = value;
        }

        /// <summary>
        /// The **`-ms-high-contrast-adjust`** CSS property is a Microsoft extension that gets or sets a value indicating whether to override any CSS properties that would have been set in high contrast mode.
        /// <para> **Syntax**: `auto | none`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsHighContrastAdjust
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-high-contrast-adjust"];
            set => _properties["-ms-high-contrast-adjust"] = value;
        }

        /// <summary>
        /// The **`-ms-hyphenate-limit-chars`** CSS property is a Microsoft extension that specifies one to three values indicating the minimum number of characters in a hyphenated word. If the word does not meet the required minimum number of characters in the word, before the hyphen, or after the hyphen, then the word is not hyphenated.
        /// <para> **Syntax**: `auto | &lt;integer&gt;{1,3}`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MsHyphenateLimitChars
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-ms-hyphenate-limit-chars"];
            set => _properties["-ms-hyphenate-limit-chars"] = value;
        }

        /// <summary>
        /// The **`-ms-hyphenate-limit-lines`** CSS property is a Microsoft extension specifying the maximum number of consecutive lines in an element that may be ended with a hyphenated word.
        /// <para> **Syntax**: `no-limit | &lt;integer&gt;`</para>
        /// <para> **Initial value**: `no-limit`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MsHyphenateLimitLines
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-ms-hyphenate-limit-lines"];
            set => _properties["-ms-hyphenate-limit-lines"] = value;
        }

        /// <summary>
        /// The `**-ms-hyphenate-limit-zone**` CSS property is a Microsoft extension specifying the width of the hyphenation zone.
        /// <para> **Syntax**: `&lt;percentage&gt; | &lt;length&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MsHyphenateLimitZone
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-ms-hyphenate-limit-zone"];
            set => _properties["-ms-hyphenate-limit-zone"] = value;
        }

        /// <summary>
        /// The **`hyphens`** CSS property specifies how words should be hyphenated when text wraps across multiple lines. It can prevent hyphenation entirely, hyphenate at manually-specified points within the text, or let the browser automatically insert hyphens where appropriate.
        /// <para> **Syntax**: `none | manual | auto`</para>
        /// <para> **Initial value**: `manual`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsHyphens
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-hyphens"];
            set => _properties["-ms-hyphens"] = value;
        }

        /// <summary>
        /// The **`-ms-ime-align`** CSS property is a Microsoft extension aligning the Input Method Editor (IME) candidate window box relative to the element on which the IME composition is active. The extension is implemented in Microsoft Edge and Internet Explorer 11.
        /// <para> **Syntax**: `auto | after`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsImeAlign
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-ime-align"];
            set => _properties["-ms-ime-align"] = value;
        }

        /// <summary>
        /// The **`line-break`** CSS property sets how to break lines of Chinese, Japanese, or Korean (CJK) text when working with punctuation and symbols.
        /// <para> **Syntax**: `auto | loose | normal | strict | anywhere`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsLineBreak
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-line-break"];
            set => _properties["-ms-line-break"] = value;
        }

        /// <summary>
        /// The **`order`** CSS property sets the order to lay out an item in a flex or grid container. Items in a container are sorted by ascending `order` value and then by their source code order.
        /// <para> **Syntax**: `&lt;integer&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MsOrder
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-ms-order"];
            set => _properties["-ms-order"] = value;
        }

        /// <summary>
        /// The **`-ms-overflow-style`** CSS property is a Microsoft extension controlling the behavior of scrollbars when the content of an element overflows.
        /// <para> **Syntax**: `auto | none | scrollbar | -ms-autohiding-scrollbar`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsOverflowStyle
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-overflow-style"];
            set => _properties["-ms-overflow-style"] = value;
        }

        /// <summary>
        /// The **`overflow-x`** CSS property sets what shows when content overflows a block-level element's left and right edges. This may be nothing, a scroll bar, or the overflow content.
        /// <para> **Syntax**: `visible | hidden | clip | scroll | auto`</para>
        /// <para> **Initial value**: `visible`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsOverflowX
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-overflow-x"];
            set => _properties["-ms-overflow-x"] = value;
        }

        /// <summary>
        /// The **`overflow-y`** CSS property sets what shows when content overflows a block-level element's top and bottom edges. This may be nothing, a scroll bar, or the overflow content.
        /// <para> **Syntax**: `visible | hidden | clip | scroll | auto`</para>
        /// <para> **Initial value**: `visible`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsOverflowY
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-overflow-y"];
            set => _properties["-ms-overflow-y"] = value;
        }

        /// <summary>
        /// The `**-ms-scroll-chaining**` CSS property is a Microsoft extension that specifies the scrolling behavior that occurs when a user hits the scroll limit during a manipulation.
        /// <para> **Syntax**: `chained | none`</para>
        /// <para> **Initial value**: `chained`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsScrollChaining
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-scroll-chaining"];
            set => _properties["-ms-scroll-chaining"] = value;
        }

        /// <summary>
        /// The `**-ms-scroll-limit-x-max**` CSS property is a Microsoft extension that specifies the maximum value for the `Element.scrollLeft` property.
        /// <para> **Syntax**: `auto | &lt;length&gt;`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MsScrollLimitXMax
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-ms-scroll-limit-x-max"];
            set => _properties["-ms-scroll-limit-x-max"] = value;
        }

        /// <summary>
        /// The **`-ms-scroll-limit-x-min`** CSS property is a Microsoft extension that specifies the minimum value for the `Element.scrollLeft` property.
        /// <para> **Syntax**: `&lt;length&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MsScrollLimitXMin
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-ms-scroll-limit-x-min"];
            set => _properties["-ms-scroll-limit-x-min"] = value;
        }

        /// <summary>
        /// The **`-ms-scroll-limit-y-max`** CSS property is a Microsoft extension that specifies the maximum value for the `Element.scrollTop` property.
        /// <para> **Syntax**: `auto | &lt;length&gt;`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MsScrollLimitYMax
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-ms-scroll-limit-y-max"];
            set => _properties["-ms-scroll-limit-y-max"] = value;
        }

        /// <summary>
        /// The **`-ms-scroll-limit-y-min`** CSS property is a Microsoft extension that specifies the minimum value for the `Element.scrollTop` property.
        /// <para> **Syntax**: `&lt;length&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MsScrollLimitYMin
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-ms-scroll-limit-y-min"];
            set => _properties["-ms-scroll-limit-y-min"] = value;
        }

        /// <summary>
        /// The **`-ms-scroll-rails`** CSS property is a Microsoft extension that specifies whether scrolling locks to the primary axis of motion.
        /// <para> **Syntax**: `none | railed`</para>
        /// <para> **Initial value**: `railed`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsScrollRails
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-scroll-rails"];
            set => _properties["-ms-scroll-rails"] = value;
        }

        /// <summary>
        /// The **`-ms-scroll-snap-points-x`** CSS property is a Microsoft extension that specifies where snap-points will be located along the x-axis.
        /// <para> **Syntax**: `snapInterval( &lt;length-percentage&gt;, &lt;length-percentage&gt; ) | snapList( &lt;length-percentage&gt;# )`</para>
        /// <para> **Initial value**: `snapInterval(0px, 100%)`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsScrollSnapPointsX
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-scroll-snap-points-x"];
            set => _properties["-ms-scroll-snap-points-x"] = value;
        }

        /// <summary>
        /// The **`-ms-scroll-snap-points-y`** CSS property is a Microsoft extension that specifies where snap-points will be located along the y-axis.
        /// <para> **Syntax**: `snapInterval( &lt;length-percentage&gt;, &lt;length-percentage&gt; ) | snapList( &lt;length-percentage&gt;# )`</para>
        /// <para> **Initial value**: `snapInterval(0px, 100%)`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsScrollSnapPointsY
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-scroll-snap-points-y"];
            set => _properties["-ms-scroll-snap-points-y"] = value;
        }

        /// <summary>
        /// The **`scroll-snap-type`** CSS property sets how strictly snap points are enforced on the scroll container in case there is one.
        /// <para> **Syntax**: `none | proximity | mandatory`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsScrollSnapType
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-scroll-snap-type"];
            set => _properties["-ms-scroll-snap-type"] = value;
        }

        /// <summary>
        /// The **`-ms-scroll-translation`** CSS property is a Microsoft extension that specifies whether vertical-to-horizontal scroll wheel translation occurs on the specified element.
        /// <para> **Syntax**: `none | vertical-to-horizontal`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsScrollTranslation
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-scroll-translation"];
            set => _properties["-ms-scroll-translation"] = value;
        }

        /// <summary>
        /// The **`-ms-scrollbar-3dlight-color`** CSS property is a Microsoft extension specifying the color of the top and left edges of the scroll box and scroll arrows of a scroll bar.
        /// <para> **Syntax**: `&lt;color&gt;`</para>
        /// <para> **Initial value**: depends on user agent</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsScrollbar3dlightColor
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-scrollbar3dlight-color"];
            set => _properties["-ms-scrollbar3dlight-color"] = value;
        }

        /// <summary>
        /// The **`-ms-scrollbar-arrow-color`** CSS property is a Microsoft extension that specifies the color of the arrow elements of a scroll arrow.
        /// <para> **Syntax**: `&lt;color&gt;`</para>
        /// <para> **Initial value**: `ButtonText`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsScrollbarArrowColor
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-scrollbar-arrow-color"];
            set => _properties["-ms-scrollbar-arrow-color"] = value;
        }

        /// <summary>
        /// The `**-ms-scrollbar-base-color**` CSS property is a Microsoft extension that specifies the base color of the main elements of a scroll bar.
        /// <para> **Syntax**: `&lt;color&gt;`</para>
        /// <para> **Initial value**: depends on user agent</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsScrollbarBaseColor
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-scrollbar-base-color"];
            set => _properties["-ms-scrollbar-base-color"] = value;
        }

        /// <summary>
        /// The **`-ms-scrollbar-darkshadow-color`** CSS property is a Microsoft extension that specifies the color of a scroll bar's gutter.
        /// <para> **Syntax**: `&lt;color&gt;`</para>
        /// <para> **Initial value**: `ThreeDDarkShadow`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsScrollbarDarkshadowColor
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-scrollbar-darkshadow-color"];
            set => _properties["-ms-scrollbar-darkshadow-color"] = value;
        }

        /// <summary>
        /// The `**-ms-scrollbar-face-color**` CSS property is a Microsoft extension that specifies the color of the scroll box and scroll arrows of a scroll bar.
        /// <para> **Syntax**: `&lt;color&gt;`</para>
        /// <para> **Initial value**: `ThreeDFace`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsScrollbarFaceColor
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-scrollbar-face-color"];
            set => _properties["-ms-scrollbar-face-color"] = value;
        }

        /// <summary>
        /// The `**-ms-scrollbar-highlight-color**` CSS property is a Microsoft extension that specifies the color of the slider tray, the top and left edges of the scroll box, and the scroll arrows of a scroll bar.
        /// <para> **Syntax**: `&lt;color&gt;`</para>
        /// <para> **Initial value**: `ThreeDHighlight`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsScrollbarHighlightColor
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-scrollbar-highlight-color"];
            set => _properties["-ms-scrollbar-highlight-color"] = value;
        }

        /// <summary>
        /// The **`-ms-scrollbar-shadow-color`** CSS property is a Microsoft extension that specifies the color of the bottom and right edges of the scroll box and scroll arrows of a scroll bar.
        /// <para> **Syntax**: `&lt;color&gt;`</para>
        /// <para> **Initial value**: `ThreeDDarkShadow`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsScrollbarShadowColor
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-scrollbar-shadow-color"];
            set => _properties["-ms-scrollbar-shadow-color"] = value;
        }

        /// <summary>
        /// The **`-ms-scrollbar-track-color`** CSS property is a Microsoft extension that specifies the color of the track element of a scrollbar.
        /// <para> **Syntax**: `&lt;color&gt;`</para>
        /// <para> **Initial value**: `Scrollbar`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsScrollbarTrackColor
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-scrollbar-track-color"];
            set => _properties["-ms-scrollbar-track-color"] = value;
        }

        /// <summary>
        /// The **`-ms-text-autospace`** CSS property is a Microsoft extension that specifies the autospacing and narrow space width adjustment of text.
        /// <para> **Syntax**: `none | ideograph-alpha | ideograph-numeric | ideograph-parenthesis | ideograph-space`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsTextAutospace
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-text-autospace"];
            set => _properties["-ms-text-autospace"] = value;
        }

        /// <summary>
        /// The **`text-combine-upright`** CSS property sets the combination of characters into the space of a single character. If the combined text is wider than 1em, the user agent must fit the contents within 1em. The resulting composition is treated as a single upright glyph for layout and decoration. This property only has an effect in vertical writing modes.
        /// <para> **Syntax**: `none | all | [ digits &lt;integer&gt;? ]`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsTextCombineHorizontal
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-text-combine-horizontal"];
            set => _properties["-ms-text-combine-horizontal"] = value;
        }

        /// <summary>
        /// The **`text-overflow`** CSS property sets how hidden overflow content is signaled to users. It can be clipped, display an ellipsis ('`…`'), or display a custom string.
        /// <para> **Syntax**: `[ clip | ellipsis | &lt;string&gt; ]{1,2}`</para>
        /// <para> **Initial value**: `clip`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsTextOverflow
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-text-overflow"];
            set => _properties["-ms-text-overflow"] = value;
        }

        /// <summary>
        /// The **`touch-action`** CSS property sets how an element's region can be manipulated by a touchscreen user (for example, by zooming features built into the browser).
        /// <para> **Syntax**: `auto | none | [ [ pan-x | pan-left | pan-right ] || [ pan-y | pan-up | pan-down ] || pinch-zoom ] | manipulation`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsTouchAction
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-touch-action"];
            set => _properties["-ms-touch-action"] = value;
        }

        /// <summary>
        /// The **`-ms-touch-select`** CSS property is a Microsoft extension that toggles the gripper visual elements that enable touch text selection.
        /// <para> **Syntax**: `grippers | none`</para>
        /// <para> **Initial value**: `grippers`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsTouchSelect
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-touch-select"];
            set => _properties["-ms-touch-select"] = value;
        }

        /// <summary>
        /// The **`transform`** CSS property lets you rotate, scale, skew, or translate an element. It modifies the coordinate space of the CSS visual formatting model.
        /// <para> **Syntax**: `none | &lt;transform-list&gt;`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsTransform
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-transform"];
            set => _properties["-ms-transform"] = value;
        }

        /// <summary>
        /// The **`transform-origin`** CSS property sets the origin for an element's transformations.
        /// <para> **Syntax**: `[ &lt;length-percentage&gt; | left | center | right | top | bottom ] | [ [ &lt;length-percentage&gt; | left | center | right ] && [ &lt;length-percentage&gt; | top | center | bottom ] ] &lt;length&gt;?`</para>
        /// <para> **Initial value**: `50% 50% 0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MsTransformOrigin
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-ms-transform-origin"];
            set => _properties["-ms-transform-origin"] = value;
        }

        /// <summary>
        /// The **`transition-delay`** CSS property specifies the duration to wait before starting a property's transition effect when its value changes.
        /// <para> **Syntax**: `&lt;time&gt;#`</para>
        /// <para> **Initial value**: `0s`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsTransitionDelay
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-transition-delay"];
            set => _properties["-ms-transition-delay"] = value;
        }

        /// <summary>
        /// The **`transition-duration`** CSS property sets the length of time a transition animation should take to complete. By default, the value is `0s`, meaning that no animation will occur.
        /// <para> **Syntax**: `&lt;time&gt;#`</para>
        /// <para> **Initial value**: `0s`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsTransitionDuration
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-transition-duration"];
            set => _properties["-ms-transition-duration"] = value;
        }

        /// <summary>
        /// The **`transition-property`** CSS property sets the CSS properties to which a transition effect should be applied.
        /// <para> **Syntax**: `none | &lt;single-transition-property&gt;#`</para>
        /// <para> **Initial value**: all</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsTransitionProperty
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-transition-property"];
            set => _properties["-ms-transition-property"] = value;
        }

        /// <summary>
        /// The **`transition-timing-function`** CSS property sets how intermediate values are calculated for CSS properties being affected by a transition effect.
        /// <para> **Syntax**: `&lt;easing-function&gt;#`</para>
        /// <para> **Initial value**: `ease`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsTransitionTimingFunction
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-transition-timing-function"];
            set => _properties["-ms-transition-timing-function"] = value;
        }

        /// <summary>
        /// The **`user-select`** CSS property controls whether the user can select text. This doesn't have any effect on content loaded as part of a browser's user interface (its chrome), except in textboxes.
        /// <para> **Syntax**: `none | element | text`</para>
        /// <para> **Initial value**: `text`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsUserSelect
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-user-select"];
            set => _properties["-ms-user-select"] = value;
        }

        /// <summary>
        /// The **`word-break`** CSS property sets whether line breaks appear wherever the text would otherwise overflow its content box.
        /// <para> **Syntax**: `normal | break-all | keep-all | break-word`</para>
        /// <para> **Initial value**: `normal`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsWordBreak
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-word-break"];
            set => _properties["-ms-word-break"] = value;
        }

        /// <summary>
        /// The **`-ms-wrap-flow`** CSS property is a Microsoft extension that specifies how exclusions impact inline content within block-level elements.
        /// <para> **Syntax**: `auto | both | start | end | maximum | clear`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsWrapFlow
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-wrap-flow"];
            set => _properties["-ms-wrap-flow"] = value;
        }

        /// <summary>
        /// The **`-ms-wrap-margin`** CSS property is a Microsoft extension that specifies a margin that offsets the inner wrap shape from other shapes.
        /// <para> **Syntax**: `&lt;length&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> MsWrapMargin
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-ms-wrap-margin"];
            set => _properties["-ms-wrap-margin"] = value;
        }

        /// <summary>
        /// The **`-ms-wrap-through`** CSS property is a Microsoft extension that specifies how content should wrap around an exclusion element.
        /// <para> **Syntax**: `wrap | none`</para>
        /// <para> **Initial value**: `wrap`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsWrapThrough
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-wrap-through"];
            set => _properties["-ms-wrap-through"] = value;
        }

        /// <summary>
        /// The **`writing-mode`** CSS property sets whether lines of text are laid out horizontally or vertically, as well as the direction in which blocks progress. When set for an entire document, it should be set on the root element (`html` element for HTML documents).
        /// <para> **Syntax**: `horizontal-tb | vertical-rl | vertical-lr | sideways-rl | sideways-lr`</para>
        /// <para> **Initial value**: `horizontal-tb`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> MsWritingMode
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-ms-writing-mode"];
            set => _properties["-ms-writing-mode"] = value;
        }

        /// <summary>
        /// The CSS **`align-content`** property sets the distribution of space between and around content items along a flexbox's cross-axis or a grid's block axis.
        /// <para> **Syntax**: `normal | &lt;baseline-position&gt; | &lt;content-distribution&gt; | &lt;overflow-position&gt;? &lt;content-position&gt;`</para>
        /// <para> **Initial value**: `normal`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitAlignContent
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-align-content"];
            set => _properties["-webkit-align-content"] = value;
        }

        /// <summary>
        /// The CSS **`align-items`** property sets the `align-self` value on all direct children as a group. In Flexbox, it controls the alignment of items on the Cross Axis. In Grid Layout, it controls the alignment of items on the Block Axis within their grid area.
        /// <para> **Syntax**: `normal | stretch | &lt;baseline-position&gt; | [ &lt;overflow-position&gt;? &lt;self-position&gt; ]`</para>
        /// <para> **Initial value**: `normal`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitAlignItems
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-align-items"];
            set => _properties["-webkit-align-items"] = value;
        }

        /// <summary>
        /// The **`align-self`** CSS property overrides a grid or flex item's `align-items` value. In Grid, it aligns the item inside the grid area. In Flexbox, it aligns the item on the cross axis.
        /// <para> **Syntax**: `auto | normal | stretch | &lt;baseline-position&gt; | &lt;overflow-position&gt;? &lt;self-position&gt;`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitAlignSelf
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-align-self"];
            set => _properties["-webkit-align-self"] = value;
        }

        /// <summary>
        /// The **`animation-delay`** CSS property specifies the amount of time to wait from applying the animation to an element before beginning to perform the animation. The animation can start later, immediately from its beginning, or immediately and partway through the animation.
        /// <para> **Syntax**: `&lt;time&gt;#`</para>
        /// <para> **Initial value**: `0s`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitAnimationDelay
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-animation-delay"];
            set => _properties["-webkit-animation-delay"] = value;
        }

        /// <summary>
        /// The **`animation-direction`** CSS property sets whether an animation should play forward, backward, or alternate back and forth between playing the sequence forward and backward.
        /// <para> **Syntax**: `&lt;single-animation-direction&gt;#`</para>
        /// <para> **Initial value**: `normal`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitAnimationDirection
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-animation-direction"];
            set => _properties["-webkit-animation-direction"] = value;
        }

        /// <summary>
        /// The **`animation-duration`** CSS property sets the length of time that an animation takes to complete one cycle.
        /// <para> **Syntax**: `&lt;time&gt;#`</para>
        /// <para> **Initial value**: `0s`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitAnimationDuration
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-animation-duration"];
            set => _properties["-webkit-animation-duration"] = value;
        }

        /// <summary>
        /// The **`animation-fill-mode`** CSS property sets how a CSS animation applies styles to its target before and after its execution.
        /// <para> **Syntax**: `&lt;single-animation-fill-mode&gt;#`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitAnimationFillMode
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-animation-fill-mode"];
            set => _properties["-webkit-animation-fill-mode"] = value;
        }

        /// <summary>
        /// The **`animation-iteration-count`** CSS property sets the number of times an animation sequence should be played before stopping.
        /// <para> **Syntax**: `&lt;single-animation-iteration-count&gt;#`</para>
        /// <para> **Initial value**: `1`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitAnimationIterationCount
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-animation-iteration-count"];
            set => _properties["-webkit-animation-iteration-count"] = value;
        }

        /// <summary>
        /// The **`animation-name`** CSS property specifies the names of one or more `@keyframes` at-rules that describe the animation to apply to an element. Multiple `@keyframe` at-rules are specified as a comma-separated list of names. If the specified name does not match any `@keyframe` at-rule, no properties are animated.
        /// <para> **Syntax**: `[ none | &lt;keyframes-name&gt; ]#`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, Keyframe> WebkitAnimationName
        {
            get => (Property<CSSProperties, PropertySkip, string, Keyframe>) _properties["-webkit-animation-name"];
            set => _properties["-webkit-animation-name"] = value;
        }

        /// <summary>
        /// The **`animation-play-state`** CSS property sets whether an animation is running or paused.
        /// <para> **Syntax**: `&lt;single-animation-play-state&gt;#`</para>
        /// <para> **Initial value**: `running`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitAnimationPlayState
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-animation-play-state"];
            set => _properties["-webkit-animation-play-state"] = value;
        }

        /// <summary>
        /// The **`animation-timing-function`** CSS property sets how an animation progresses through the duration of each cycle.
        /// <para> **Syntax**: `&lt;easing-function&gt;#`</para>
        /// <para> **Initial value**: `ease`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitAnimationTimingFunction
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-animation-timing-function"];
            set => _properties["-webkit-animation-timing-function"] = value;
        }

        /// <summary>
        /// The **`appearance`** CSS property is used to control native appearance of UI controls, that are based on operating system's theme.
        /// <para> **Syntax**: `none | button | button-bevel | caret | checkbox | default-button | inner-spin-button | listbox | listitem | media-controls-background | media-controls-fullscreen-background | media-current-time-display | media-enter-fullscreen-button | media-exit-fullscreen-button | media-fullscreen-button | media-mute-button | media-overlay-play-button | media-play-button | media-seek-back-button | media-seek-forward-button | media-slider | media-sliderthumb | media-time-remaining-display | media-toggle-closed-captions-button | media-volume-slider | media-volume-slider-container | media-volume-sliderthumb | menulist | menulist-button | menulist-text | menulist-textfield | meter | progress-bar | progress-bar-value | push-button | radio | searchfield | searchfield-cancel-button | searchfield-decoration | searchfield-results-button | searchfield-results-decoration | slider-horizontal | slider-vertical | sliderthumb-horizontal | sliderthumb-vertical | square-button | textarea | textfield | -apple-pay-button`</para>
        /// <para> **Initial value**: `none` (but this value is overridden in the user agent CSS)</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitAppearance
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-appearance"];
            set => _properties["-webkit-appearance"] = value;
        }

        /// <summary>
        /// The **`backdrop-filter`** CSS property lets you apply graphical effects such as blurring or color shifting to the area behind an element. Because it applies to everything _behind_ the element, to see the effect you must make the element or its background at least partially transparent.
        /// <para> **Syntax**: `none | &lt;filter-function-list&gt;`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitBackdropFilter
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-backdrop-filter"];
            set => _properties["-webkit-backdrop-filter"] = value;
        }

        /// <summary>
        /// The **`backface-visibility`** CSS property sets whether the back face of an element is visible when turned towards the user.
        /// <para> **Syntax**: `visible | hidden`</para>
        /// <para> **Initial value**: `visible`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitBackfaceVisibility
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-backface-visibility"];
            set => _properties["-webkit-backface-visibility"] = value;
        }

        /// <summary>
        /// The **`background-clip`** CSS property sets whether an element's background extends underneath its border box, padding box, or content box.
        /// <para> **Syntax**: `&lt;box&gt;#`</para>
        /// <para> **Initial value**: `border-box`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitBackgroundClip
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-background-clip"];
            set => _properties["-webkit-background-clip"] = value;
        }

        /// <summary>
        /// The **`background-origin`** CSS property sets the background's origin: from the border start, inside the border, or inside the padding.
        /// <para> **Syntax**: `&lt;box&gt;#`</para>
        /// <para> **Initial value**: `padding-box`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitBackgroundOrigin
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-background-origin"];
            set => _properties["-webkit-background-origin"] = value;
        }

        /// <summary>
        /// The **`background-size`** CSS property sets the size of the element's background image. The image can be left to its natural size, stretched, or constrained to fit the available space.
        /// <para> **Syntax**: `&lt;bg-size&gt;#`</para>
        /// <para> **Initial value**: `auto auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitBackgroundSize
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-background-size"];
            set => _properties["-webkit-background-size"] = value;
        }

        /// <summary>
        /// **Syntax**: `&lt;color&gt;`
        /// <para> **Initial value**: `currentcolor`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitBorderBeforeColor
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-border-before-color"];
            set => _properties["-webkit-border-before-color"] = value;
        }

        /// <summary>
        /// **Syntax**: `&lt;'border-style'&gt;`
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitBorderBeforeStyle
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-border-before-style"];
            set => _properties["-webkit-border-before-style"] = value;
        }

        /// <summary>
        /// **Syntax**: `&lt;'border-width'&gt;`
        /// <para> **Initial value**: `medium`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitBorderBeforeWidth
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-border-before-width"];
            set => _properties["-webkit-border-before-width"] = value;
        }

        /// <summary>
        /// The **`border-bottom-left-radius`** CSS property rounds the bottom-left corner of an element by specifying the radius (or the radius of the semi-major and semi-minor axes) of the ellipse defining the curvature of the corner.
        /// <para> **Syntax**: `&lt;length-percentage&gt;{1,2}`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitBorderBottomLeftRadius
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-border-bottom-left-radius"];
            set => _properties["-webkit-border-bottom-left-radius"] = value;
        }

        /// <summary>
        /// The **`border-bottom-right-radius`** CSS property rounds the bottom-right corner of an element by specifying the radius (or the radius of the semi-major and semi-minor axes) of the ellipse defining the curvature of the corner.
        /// <para> **Syntax**: `&lt;length-percentage&gt;{1,2}`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitBorderBottomRightRadius
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-border-bottom-right-radius"];
            set => _properties["-webkit-border-bottom-right-radius"] = value;
        }

        /// <summary>
        /// The **`border-image-slice`** CSS property divides the image specified by `border-image-source` into regions. These regions form the components of an element's border image.
        /// <para> **Syntax**: `&lt;number-percentage&gt;{1,4} && fill?`</para>
        /// <para> **Initial value**: `100%`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitBorderImageSlice
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-border-image-slice"];
            set => _properties["-webkit-border-image-slice"] = value;
        }

        /// <summary>
        /// The **`border-top-left-radius`** CSS property rounds the top-left corner of an element by specifying the radius (or the radius of the semi-major and semi-minor axes) of the ellipse defining the curvature of the corner.
        /// <para> **Syntax**: `&lt;length-percentage&gt;{1,2}`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitBorderTopLeftRadius
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-border-top-left-radius"];
            set => _properties["-webkit-border-top-left-radius"] = value;
        }

        /// <summary>
        /// The **`border-top-right-radius`** CSS property rounds the top-right corner of an element by specifying the radius (or the radius of the semi-major and semi-minor axes) of the ellipse defining the curvature of the corner.
        /// <para> **Syntax**: `&lt;length-percentage&gt;{1,2}`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitBorderTopRightRadius
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-border-top-right-radius"];
            set => _properties["-webkit-border-top-right-radius"] = value;
        }

        /// <summary>
        /// The **`box-decoration-break`** CSS property specifies how an element's fragments should be rendered when broken across multiple lines, columns, or pages.
        /// <para> **Syntax**: `slice | clone`</para>
        /// <para> **Initial value**: `slice`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitBoxDecorationBreak
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-box-decoration-break"];
            set => _properties["-webkit-box-decoration-break"] = value;
        }

        /// <summary>
        /// The **`-webkit-box-reflect`** CSS property lets you reflect the content of an element in one specific direction.
        /// <para> **Syntax**: `[ above | below | right | left ]? &lt;length&gt;? &lt;image&gt;?`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitBoxReflect
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-box-reflect"];
            set => _properties["-webkit-box-reflect"] = value;
        }

        /// <summary>
        /// The **`box-shadow`** CSS property adds shadow effects around an element's frame. You can set multiple effects separated by commas. A box shadow is described by X and Y offsets relative to the element, blur and spread radius, and color.
        /// <para> **Syntax**: `none | &lt;shadow&gt;#`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitBoxShadow
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-box-shadow"];
            set => _properties["-webkit-box-shadow"] = value;
        }

        /// <summary>
        /// The **`box-sizing`** CSS property sets how the total width and height of an element is calculated.
        /// <para> **Syntax**: `content-box | border-box`</para>
        /// <para> **Initial value**: `content-box`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitBoxSizing
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-box-sizing"];
            set => _properties["-webkit-box-sizing"] = value;
        }

        /// <summary>
        /// The **`clip-path`** CSS property creates a clipping region that sets what part of an element should be shown. Parts that are inside the region are shown, while those outside are hidden.
        /// <para> **Syntax**: `&lt;clip-source&gt; | [ &lt;basic-shape&gt; || &lt;geometry-box&gt; ] | none`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitClipPath
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-clip-path"];
            set => _properties["-webkit-clip-path"] = value;
        }

        /// <summary>
        /// The **`column-count`** CSS property breaks an element's content into the specified number of columns.
        /// <para> **Syntax**: `&lt;integer&gt; | auto`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitColumnCount
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-column-count"];
            set => _properties["-webkit-column-count"] = value;
        }

        /// <summary>
        /// The **`column-fill`** CSS property controls how an element's contents are balanced when broken into columns.
        /// <para> **Syntax**: `auto | balance | balance-all`</para>
        /// <para> **Initial value**: `balance`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitColumnFill
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-column-fill"];
            set => _properties["-webkit-column-fill"] = value;
        }

        /// <summary>
        /// The **`column-rule-color`** CSS property sets the color of the line drawn between columns in a multi-column layout.
        /// <para> **Syntax**: `&lt;color&gt;`</para>
        /// <para> **Initial value**: `currentcolor`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitColumnRuleColor
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-column-rule-color"];
            set => _properties["-webkit-column-rule-color"] = value;
        }

        /// <summary>
        /// The **`column-rule-style`** CSS property sets the style of the line drawn between columns in a multi-column layout.
        /// <para> **Syntax**: `&lt;'border-style'&gt;`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitColumnRuleStyle
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-column-rule-style"];
            set => _properties["-webkit-column-rule-style"] = value;
        }

        /// <summary>
        /// The **`column-rule-width`** CSS property sets the width of the line drawn between columns in a multi-column layout.
        /// <para> **Syntax**: `&lt;'border-width'&gt;`</para>
        /// <para> **Initial value**: `medium`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitColumnRuleWidth
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-column-rule-width"];
            set => _properties["-webkit-column-rule-width"] = value;
        }

        /// <summary>
        /// The **`column-span`** CSS property makes it possible for an element to span across all columns when its value is set to `all`.
        /// <para> **Syntax**: `none | all`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitColumnSpan
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-column-span"];
            set => _properties["-webkit-column-span"] = value;
        }

        /// <summary>
        /// The **`column-width`** CSS property sets the ideal column width in a multi-column layout. The container will have as many columns as can fit without any of them having a width less than the `column-width` value. If the width of the container is narrower than the specified value, the single column's width will be smaller than the declared column width.
        /// <para> **Syntax**: `&lt;length&gt; | auto`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitColumnWidth
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-column-width"];
            set => _properties["-webkit-column-width"] = value;
        }

        /// <summary>
        /// The **`filter`** CSS property applies graphical effects like blur or color shift to an element. Filters are commonly used to adjust the rendering of images, backgrounds, and borders.
        /// <para> **Syntax**: `none | &lt;filter-function-list&gt;`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitFilter
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-filter"];
            set => _properties["-webkit-filter"] = value;
        }

        /// <summary>
        /// The **`flex-basis`** CSS property sets the initial main size of a flex item. It sets the size of the content box unless otherwise set with `box-sizing`.
        /// <para> **Syntax**: `content | &lt;'width'&gt;`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitFlexBasis
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-flex-basis"];
            set => _properties["-webkit-flex-basis"] = value;
        }

        /// <summary>
        /// The **`flex-direction`** CSS property sets how flex items are placed in the flex container defining the main axis and the direction (normal or reversed).
        /// <para> **Syntax**: `row | row-reverse | column | column-reverse`</para>
        /// <para> **Initial value**: `row`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitFlexDirection
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-flex-direction"];
            set => _properties["-webkit-flex-direction"] = value;
        }

        /// <summary>
        /// The **`flex-grow`** CSS property sets the flex grow factor of a flex item's main size.
        /// <para> **Syntax**: `&lt;number&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitFlexGrow
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-flex-grow"];
            set => _properties["-webkit-flex-grow"] = value;
        }

        /// <summary>
        /// The **`flex-shrink`** CSS property sets the flex shrink factor of a flex item. If the size of all flex items is larger than the flex container, items shrink to fit according to `flex-shrink`.
        /// <para> **Syntax**: `&lt;number&gt;`</para>
        /// <para> **Initial value**: `1`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitFlexShrink
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-flex-shrink"];
            set => _properties["-webkit-flex-shrink"] = value;
        }

        /// <summary>
        /// The **`flex-wrap`** CSS property sets whether flex items are forced onto one line or can wrap onto multiple lines. If wrapping is allowed, it sets the direction that lines are stacked.
        /// <para> **Syntax**: `nowrap | wrap | wrap-reverse`</para>
        /// <para> **Initial value**: `nowrap`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitFlexWrap
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-flex-wrap"];
            set => _properties["-webkit-flex-wrap"] = value;
        }

        /// <summary>
        /// The **`font-feature-settings`** CSS property controls advanced typographic features in OpenType fonts.
        /// <para> **Syntax**: `normal | &lt;feature-tag-value&gt;#`</para>
        /// <para> **Initial value**: `normal`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitFontFeatureSettings
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-font-feature-settings"];
            set => _properties["-webkit-font-feature-settings"] = value;
        }

        /// <summary>
        /// The **`font-kerning`** CSS property sets the use of the kerning information stored in a font.
        /// <para> **Syntax**: `auto | normal | none`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitFontKerning
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-font-kerning"];
            set => _properties["-webkit-font-kerning"] = value;
        }

        /// <summary>
        /// The **`font-smooth`** CSS property controls the application of anti-aliasing when fonts are rendered.
        /// <para> **Syntax**: `auto | never | always | &lt;absolute-size&gt; | &lt;length&gt;`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitFontSmoothing
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-font-smoothing"];
            set => _properties["-webkit-font-smoothing"] = value;
        }

        /// <summary>
        /// The **`font-variant-ligatures`** CSS property controls which ligatures and contextual forms are used in textual content of the elements it applies to. This leads to more harmonized forms in the resulting text.
        /// <para> **Syntax**: `normal | none | [ &lt;common-lig-values&gt; || &lt;discretionary-lig-values&gt; || &lt;historical-lig-values&gt; || &lt;contextual-alt-values&gt; ]`</para>
        /// <para> **Initial value**: `normal`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitFontVariantLigatures
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-font-variant-ligatures"];
            set => _properties["-webkit-font-variant-ligatures"] = value;
        }

        /// <summary>
        /// The **`hyphenate-character`** CSS property sets the character (or string) used at the end of a line before a hyphenation break.
        /// <para> **Syntax**: `auto | &lt;string&gt;`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitHyphenateCharacter
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-hyphenate-character"];
            set => _properties["-webkit-hyphenate-character"] = value;
        }

        /// <summary>
        /// The **`hyphens`** CSS property specifies how words should be hyphenated when text wraps across multiple lines. It can prevent hyphenation entirely, hyphenate at manually-specified points within the text, or let the browser automatically insert hyphens where appropriate.
        /// <para> **Syntax**: `none | manual | auto`</para>
        /// <para> **Initial value**: `manual`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitHyphens
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-hyphens"];
            set => _properties["-webkit-hyphens"] = value;
        }

        /// <summary>
        /// The `initial-letter` CSS property sets styling for dropped, raised, and sunken initial letters.
        /// <para> **Syntax**: `normal | [ &lt;number&gt; &lt;integer&gt;? ]`</para>
        /// <para> **Initial value**: `normal`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitInitialLetter
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-initial-letter"];
            set => _properties["-webkit-initial-letter"] = value;
        }

        /// <summary>
        /// The CSS **`justify-content`** property defines how the browser distributes space between and around content items along the main-axis of a flex container, and the inline axis of a grid container.
        /// <para> **Syntax**: `normal | &lt;content-distribution&gt; | &lt;overflow-position&gt;? [ &lt;content-position&gt; | left | right ]`</para>
        /// <para> **Initial value**: `normal`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitJustifyContent
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-justify-content"];
            set => _properties["-webkit-justify-content"] = value;
        }

        /// <summary>
        /// The **`line-break`** CSS property sets how to break lines of Chinese, Japanese, or Korean (CJK) text when working with punctuation and symbols.
        /// <para> **Syntax**: `auto | loose | normal | strict | anywhere`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitLineBreak
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-line-break"];
            set => _properties["-webkit-line-break"] = value;
        }

        /// <summary>
        /// The **`-webkit-line-clamp`** CSS property allows limiting of the contents of a block to the specified number of lines.
        /// <para> **Syntax**: `none | &lt;integer&gt;`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitLineClamp
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-line-clamp"];
            set => _properties["-webkit-line-clamp"] = value;
        }

        /// <summary>
        /// The **`margin-inline-end`** CSS property defines the logical inline end margin of an element, which maps to a physical margin depending on the element's writing mode, directionality, and text orientation. In other words, it corresponds to the `margin-top`, `margin-right`, `margin-bottom` or `margin-left` property depending on the values defined for `writing-mode`, `direction`, and `text-orientation`.
        /// <para> **Syntax**: `&lt;'margin-left'&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitMarginEnd
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-margin-end"];
            set => _properties["-webkit-margin-end"] = value;
        }

        /// <summary>
        /// The **`margin-inline-start`** CSS property defines the logical inline start margin of an element, which maps to a physical margin depending on the element's writing mode, directionality, and text orientation. It corresponds to the `margin-top`, `margin-right`, `margin-bottom`, or `margin-left` property depending on the values defined for `writing-mode`, `direction`, and `text-orientation`.
        /// <para> **Syntax**: `&lt;'margin-left'&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitMarginStart
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-margin-start"];
            set => _properties["-webkit-margin-start"] = value;
        }

        /// <summary>
        /// If a `mask-image` is specified, `-webkit-mask-attachment` determines whether the mask image's position is fixed within the viewport, or scrolls along with its containing block.
        /// <para> **Syntax**: `&lt;attachment&gt;#`</para>
        /// <para> **Initial value**: `scroll`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitMaskAttachment
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-mask-attachment"];
            set => _properties["-webkit-mask-attachment"] = value;
        }

        /// <summary>
        /// The **`mask-border-outset`** CSS property specifies the distance by which an element's mask border is set out from its border box.
        /// <para> **Syntax**: `[ &lt;length&gt; | &lt;number&gt; ]{1,4}`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitMaskBoxImageOutset
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-mask-box-image-outset"];
            set => _properties["-webkit-mask-box-image-outset"] = value;
        }

        /// <summary>
        /// The **`mask-border-repeat`** CSS property sets how the edge regions of a source image are adjusted to fit the dimensions of an element's mask border.
        /// <para> **Syntax**: `[ stretch | repeat | round | space ]{1,2}`</para>
        /// <para> **Initial value**: `stretch`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitMaskBoxImageRepeat
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-mask-box-image-repeat"];
            set => _properties["-webkit-mask-box-image-repeat"] = value;
        }

        /// <summary>
        /// The **`mask-border-slice`** CSS property divides the image set by `mask-border-source` into regions. These regions are used to form the components of an element's mask border.
        /// <para> **Syntax**: `&lt;number-percentage&gt;{1,4} fill?`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitMaskBoxImageSlice
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-mask-box-image-slice"];
            set => _properties["-webkit-mask-box-image-slice"] = value;
        }

        /// <summary>
        /// The **`mask-border-source`** CSS property sets the source image used to create an element's mask border.
        /// <para> **Syntax**: `none | &lt;image&gt;`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitMaskBoxImageSource
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-mask-box-image-source"];
            set => _properties["-webkit-mask-box-image-source"] = value;
        }

        /// <summary>
        /// The **`mask-border-width`** CSS property sets the width of an element's mask border.
        /// <para> **Syntax**: `[ &lt;length-percentage&gt; | &lt;number&gt; | auto ]{1,4}`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitMaskBoxImageWidth
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-mask-box-image-width"];
            set => _properties["-webkit-mask-box-image-width"] = value;
        }

        /// <summary>
        /// The **`mask-clip`** CSS property determines the area which is affected by a mask. The painted content of an element must be restricted to this area.
        /// <para> **Syntax**: `[ &lt;box&gt; | border | padding | content | text ]#`</para>
        /// <para> **Initial value**: `border`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitMaskClip
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-mask-clip"];
            set => _properties["-webkit-mask-clip"] = value;
        }

        /// <summary>
        /// The **`-webkit-mask-composite`** property specifies the manner in which multiple mask images applied to the same element are composited with one another. Mask images are composited in the opposite order that they are declared with the `-webkit-mask-image` property.
        /// <para> **Syntax**: `&lt;composite-style&gt;#`</para>
        /// <para> **Initial value**: `source-over`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitMaskComposite
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-mask-composite"];
            set => _properties["-webkit-mask-composite"] = value;
        }

        /// <summary>
        /// The **`mask-image`** CSS property sets the image that is used as mask layer for an element. By default this means the alpha channel of the mask image will be multiplied with the alpha channel of the element. This can be controlled with the `mask-mode` property.
        /// <para> **Syntax**: `&lt;mask-reference&gt;#`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitMaskImage
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-mask-image"];
            set => _properties["-webkit-mask-image"] = value;
        }

        /// <summary>
        /// The **`mask-origin`** CSS property sets the origin of a mask.
        /// <para> **Syntax**: `[ &lt;box&gt; | border | padding | content ]#`</para>
        /// <para> **Initial value**: `padding`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitMaskOrigin
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-mask-origin"];
            set => _properties["-webkit-mask-origin"] = value;
        }

        /// <summary>
        /// The **`mask-position`** CSS property sets the initial position, relative to the mask position layer set by `mask-origin`, for each defined mask image.
        /// <para> **Syntax**: `&lt;position&gt;#`</para>
        /// <para> **Initial value**: `0% 0%`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitMaskPosition
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-mask-position"];
            set => _properties["-webkit-mask-position"] = value;
        }

        /// <summary>
        /// The `-webkit-mask-position-x` CSS property sets the initial horizontal position of a mask image.
        /// <para> **Syntax**: `[ &lt;length-percentage&gt; | left | center | right ]#`</para>
        /// <para> **Initial value**: `0%`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitMaskPositionX
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-mask-position-x"];
            set => _properties["-webkit-mask-position-x"] = value;
        }

        /// <summary>
        /// The `-webkit-mask-position-y` CSS property sets the initial vertical position of a mask image.
        /// <para> **Syntax**: `[ &lt;length-percentage&gt; | top | center | bottom ]#`</para>
        /// <para> **Initial value**: `0%`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitMaskPositionY
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-mask-position-y"];
            set => _properties["-webkit-mask-position-y"] = value;
        }

        /// <summary>
        /// The **`mask-repeat`** CSS property sets how mask images are repeated. A mask image can be repeated along the horizontal axis, the vertical axis, both axes, or not repeated at all.
        /// <para> **Syntax**: `&lt;repeat-style&gt;#`</para>
        /// <para> **Initial value**: `repeat`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitMaskRepeat
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-mask-repeat"];
            set => _properties["-webkit-mask-repeat"] = value;
        }

        /// <summary>
        /// The `-webkit-mask-repeat-x` property specifies whether and how a mask image is repeated (tiled) horizontally.
        /// <para> **Syntax**: `repeat | no-repeat | space | round`</para>
        /// <para> **Initial value**: `repeat`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitMaskRepeatX
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-mask-repeat-x"];
            set => _properties["-webkit-mask-repeat-x"] = value;
        }

        /// <summary>
        /// The `-webkit-mask-repeat-y` property sets whether and how a mask image is repeated (tiled) vertically.
        /// <para> **Syntax**: `repeat | no-repeat | space | round`</para>
        /// <para> **Initial value**: `repeat`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitMaskRepeatY
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-mask-repeat-y"];
            set => _properties["-webkit-mask-repeat-y"] = value;
        }

        /// <summary>
        /// The **`mask-size`** CSS property specifies the sizes of the mask images. The size of the image can be fully or partially constrained in order to preserve its intrinsic ratio.
        /// <para> **Syntax**: `&lt;bg-size&gt;#`</para>
        /// <para> **Initial value**: `auto auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitMaskSize
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-mask-size"];
            set => _properties["-webkit-mask-size"] = value;
        }

        /// <summary>
        /// The **`max-inline-size`** CSS property defines the horizontal or vertical maximum size of an element's block, depending on its writing mode. It corresponds to either the `max-width` or the `max-height` property, depending on the value of `writing-mode`.
        /// <para> **Syntax**: `&lt;'max-width'&gt;`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitMaxInlineSize
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-max-inline-size"];
            set => _properties["-webkit-max-inline-size"] = value;
        }

        /// <summary>
        /// The **`order`** CSS property sets the order to lay out an item in a flex or grid container. Items in a container are sorted by ascending `order` value and then by their source code order.
        /// <para> **Syntax**: `&lt;integer&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitOrder
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-order"];
            set => _properties["-webkit-order"] = value;
        }

        /// <summary>
        /// The `-webkit-overflow-scrolling` CSS property controls whether or not touch devices use momentum-based scrolling for a given element.
        /// <para> **Syntax**: `auto | touch`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitOverflowScrolling
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-overflow-scrolling"];
            set => _properties["-webkit-overflow-scrolling"] = value;
        }

        /// <summary>
        /// The **`padding-inline-end`** CSS property defines the logical inline end padding of an element, which maps to a physical padding depending on the element's writing mode, directionality, and text orientation.
        /// <para> **Syntax**: `&lt;'padding-left'&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitPaddingEnd
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-padding-end"];
            set => _properties["-webkit-padding-end"] = value;
        }

        /// <summary>
        /// The **`padding-inline-start`** CSS property defines the logical inline start padding of an element, which maps to a physical padding depending on the element's writing mode, directionality, and text orientation.
        /// <para> **Syntax**: `&lt;'padding-left'&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitPaddingStart
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-padding-start"];
            set => _properties["-webkit-padding-start"] = value;
        }

        /// <summary>
        /// The **`perspective`** CSS property determines the distance between the z=0 plane and the user in order to give a 3D-positioned element some perspective.
        /// <para> **Syntax**: `none | &lt;length&gt;`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitPerspective
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-perspective"];
            set => _properties["-webkit-perspective"] = value;
        }

        /// <summary>
        /// The **`perspective-origin`** CSS property determines the position at which the viewer is looking. It is used as the _vanishing point_ by the `perspective` property.
        /// <para> **Syntax**: `&lt;position&gt;`</para>
        /// <para> **Initial value**: `50% 50%`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitPerspectiveOrigin
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-perspective-origin"];
            set => _properties["-webkit-perspective-origin"] = value;
        }

        /// <summary>
        /// The **`print-color-adjust`** CSS property sets what, if anything, the user agent may do to optimize the appearance of the element on the output device. By default, the browser is allowed to make any adjustments to the element's appearance it determines to be necessary and prudent given the type and capabilities of the output device.
        /// <para> **Syntax**: `economy | exact`</para>
        /// <para> **Initial value**: `economy`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitPrintColorAdjust
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-print-color-adjust"];
            set => _properties["-webkit-print-color-adjust"] = value;
        }

        /// <summary>
        /// The **`ruby-position`** CSS property defines the position of a ruby element relatives to its base element. It can be positioned over the element (`over`), under it (`under`), or between the characters on their right side (`inter-character`).
        /// <para> **Syntax**: `[ alternate || [ over | under ] ] | inter-character`</para>
        /// <para> **Initial value**: `alternate`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitRubyPosition
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-ruby-position"];
            set => _properties["-webkit-ruby-position"] = value;
        }

        /// <summary>
        /// The **`scroll-snap-type`** CSS property sets how strictly snap points are enforced on the scroll container in case there is one.
        /// <para> **Syntax**: `none | [ x | y | block | inline | both ] [ mandatory | proximity ]?`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitScrollSnapType
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-scroll-snap-type"];
            set => _properties["-webkit-scroll-snap-type"] = value;
        }

        /// <summary>
        /// The **`shape-margin`** CSS property sets a margin for a CSS shape created using `shape-outside`.
        /// <para> **Syntax**: `&lt;length-percentage&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitShapeMargin
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-shape-margin"];
            set => _properties["-webkit-shape-margin"] = value;
        }

        /// <summary>
        /// **`-webkit-tap-highlight-color`** is a non-standard CSS property that sets the color of the highlight that appears over a link while it's being tapped. The highlighting indicates to the user that their tap is being successfully recognized, and indicates which element they're tapping on.
        /// <para> **Syntax**: `&lt;color&gt;`</para>
        /// <para> **Initial value**: `black`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitTapHighlightColor
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-tap-highlight-color"];
            set => _properties["-webkit-tap-highlight-color"] = value;
        }

        /// <summary>
        /// The **`text-combine-upright`** CSS property sets the combination of characters into the space of a single character. If the combined text is wider than 1em, the user agent must fit the contents within 1em. The resulting composition is treated as a single upright glyph for layout and decoration. This property only has an effect in vertical writing modes.
        /// <para> **Syntax**: `none | all | [ digits &lt;integer&gt;? ]`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitTextCombine
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-text-combine"];
            set => _properties["-webkit-text-combine"] = value;
        }

        /// <summary>
        /// The **`text-decoration-color`** CSS property sets the color of decorations added to text by `text-decoration-line`.
        /// <para> **Syntax**: `&lt;color&gt;`</para>
        /// <para> **Initial value**: `currentcolor`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitTextDecorationColor
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-text-decoration-color"];
            set => _properties["-webkit-text-decoration-color"] = value;
        }

        /// <summary>
        /// The **`text-decoration-line`** CSS property sets the kind of decoration that is used on text in an element, such as an underline or overline.
        /// <para> **Syntax**: `none | [ underline || overline || line-through || blink ] | spelling-error | grammar-error`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitTextDecorationLine
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-text-decoration-line"];
            set => _properties["-webkit-text-decoration-line"] = value;
        }

        /// <summary>
        /// The **`text-decoration-skip`** CSS property sets what parts of an element's content any text decoration affecting the element must skip over. It controls all text decoration lines drawn by the element and also any text decoration lines drawn by its ancestors.
        /// <para> **Syntax**: `none | [ objects || [ spaces | [ leading-spaces || trailing-spaces ] ] || edges || box-decoration ]`</para>
        /// <para> **Initial value**: `objects`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitTextDecorationSkip
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-text-decoration-skip"];
            set => _properties["-webkit-text-decoration-skip"] = value;
        }

        /// <summary>
        /// The **`text-decoration-style`** CSS property sets the style of the lines specified by `text-decoration-line`. The style applies to all lines that are set with `text-decoration-line`.
        /// <para> **Syntax**: `solid | double | dotted | dashed | wavy`</para>
        /// <para> **Initial value**: `solid`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitTextDecorationStyle
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-text-decoration-style"];
            set => _properties["-webkit-text-decoration-style"] = value;
        }

        /// <summary>
        /// The **`text-emphasis-color`** CSS property sets the color of emphasis marks. This value can also be set using the `text-emphasis` shorthand.
        /// <para> **Syntax**: `&lt;color&gt;`</para>
        /// <para> **Initial value**: `currentcolor`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitTextEmphasisColor
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-text-emphasis-color"];
            set => _properties["-webkit-text-emphasis-color"] = value;
        }

        /// <summary>
        /// The **`text-emphasis-position`** CSS property sets where emphasis marks are drawn. Like ruby text, if there isn't enough room for emphasis marks, the line height is increased.
        /// <para> **Syntax**: `[ over | under ] && [ right | left ]`</para>
        /// <para> **Initial value**: `over right`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitTextEmphasisPosition
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-text-emphasis-position"];
            set => _properties["-webkit-text-emphasis-position"] = value;
        }

        /// <summary>
        /// The **`text-emphasis-style`** CSS property sets the appearance of emphasis marks. It can also be set, and reset, using the `text-emphasis` shorthand.
        /// <para> **Syntax**: `none | [ [ filled | open ] || [ dot | circle | double-circle | triangle | sesame ] ] | &lt;string&gt;`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitTextEmphasisStyle
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-text-emphasis-style"];
            set => _properties["-webkit-text-emphasis-style"] = value;
        }

        /// <summary>
        /// The **`-webkit-text-fill-color`** CSS property specifies the fill color of characters of text. If this property is not set, the value of the `color` property is used.
        /// <para> **Syntax**: `&lt;color&gt;`</para>
        /// <para> **Initial value**: `currentcolor`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitTextFillColor
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-text-fill-color"];
            set => _properties["-webkit-text-fill-color"] = value;
        }

        /// <summary>
        /// The **`text-orientation`** CSS property sets the orientation of the text characters in a line. It only affects text in vertical mode (when `writing-mode` is not `horizontal-tb`). It is useful for controlling the display of languages that use vertical script, and also for making vertical table headers.
        /// <para> **Syntax**: `mixed | upright | sideways`</para>
        /// <para> **Initial value**: `mixed`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitTextOrientation
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-text-orientation"];
            set => _properties["-webkit-text-orientation"] = value;
        }

        /// <summary>
        /// The **`text-size-adjust`** CSS property controls the text inflation algorithm used on some smartphones and tablets. Other browsers will ignore this property.
        /// <para> **Syntax**: `none | auto | &lt;percentage&gt;`</para>
        /// <para> **Initial value**: `auto` for smartphone browsers supporting inflation, `none` in other cases (and then not modifiable).</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitTextSizeAdjust
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-text-size-adjust"];
            set => _properties["-webkit-text-size-adjust"] = value;
        }

        /// <summary>
        /// The **`-webkit-text-stroke-color`** CSS property specifies the stroke color of characters of text. If this property is not set, the value of the `color` property is used.
        /// <para> **Syntax**: `&lt;color&gt;`</para>
        /// <para> **Initial value**: `currentcolor`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitTextStrokeColor
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-text-stroke-color"];
            set => _properties["-webkit-text-stroke-color"] = value;
        }

        /// <summary>
        /// The **`-webkit-text-stroke-width`** CSS property specifies the width of the stroke for text.
        /// <para> **Syntax**: `&lt;length&gt;`</para>
        /// <para> **Initial value**: `0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitTextStrokeWidth
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-text-stroke-width"];
            set => _properties["-webkit-text-stroke-width"] = value;
        }

        /// <summary>
        /// The **`text-underline-position`** CSS property specifies the position of the underline which is set using the `text-decoration` property's `underline` value.
        /// <para> **Syntax**: `auto | from-font | [ under || [ left | right ] ]`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitTextUnderlinePosition
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-text-underline-position"];
            set => _properties["-webkit-text-underline-position"] = value;
        }

        /// <summary>
        /// The `-webkit-touch-callout` CSS property controls the display of the default callout shown when you touch and hold a touch target.
        /// <para> **Syntax**: `default | none`</para>
        /// <para> **Initial value**: `default`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitTouchCallout
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-touch-callout"];
            set => _properties["-webkit-touch-callout"] = value;
        }

        /// <summary>
        /// The **`transform`** CSS property lets you rotate, scale, skew, or translate an element. It modifies the coordinate space of the CSS visual formatting model.
        /// <para> **Syntax**: `none | &lt;transform-list&gt;`</para>
        /// <para> **Initial value**: `none`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitTransform
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-transform"];
            set => _properties["-webkit-transform"] = value;
        }

        /// <summary>
        /// The **`transform-origin`** CSS property sets the origin for an element's transformations.
        /// <para> **Syntax**: `[ &lt;length-percentage&gt; | left | center | right | top | bottom ] | [ [ &lt;length-percentage&gt; | left | center | right ] && [ &lt;length-percentage&gt; | top | center | bottom ] ] &lt;length&gt;?`</para>
        /// <para> **Initial value**: `50% 50% 0`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string, double> WebkitTransformOrigin
        {
            get => (Property<CSSProperties, PropertySkip, string, double>) _properties["-webkit-transform-origin"];
            set => _properties["-webkit-transform-origin"] = value;
        }

        /// <summary>
        /// The **`transform-style`** CSS property sets whether children of an element are positioned in the 3D space or are flattened in the plane of the element.
        /// <para> **Syntax**: `flat | preserve-3d`</para>
        /// <para> **Initial value**: `flat`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitTransformStyle
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-transform-style"];
            set => _properties["-webkit-transform-style"] = value;
        }

        /// <summary>
        /// The **`transition-delay`** CSS property specifies the duration to wait before starting a property's transition effect when its value changes.
        /// <para> **Syntax**: `&lt;time&gt;#`</para>
        /// <para> **Initial value**: `0s`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitTransitionDelay
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-transition-delay"];
            set => _properties["-webkit-transition-delay"] = value;
        }

        /// <summary>
        /// The **`transition-duration`** CSS property sets the length of time a transition animation should take to complete. By default, the value is `0s`, meaning that no animation will occur.
        /// <para> **Syntax**: `&lt;time&gt;#`</para>
        /// <para> **Initial value**: `0s`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitTransitionDuration
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-transition-duration"];
            set => _properties["-webkit-transition-duration"] = value;
        }

        /// <summary>
        /// The **`transition-property`** CSS property sets the CSS properties to which a transition effect should be applied.
        /// <para> **Syntax**: `none | &lt;single-transition-property&gt;#`</para>
        /// <para> **Initial value**: all</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitTransitionProperty
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-transition-property"];
            set => _properties["-webkit-transition-property"] = value;
        }

        /// <summary>
        /// The **`transition-timing-function`** CSS property sets how intermediate values are calculated for CSS properties being affected by a transition effect.
        /// <para> **Syntax**: `&lt;easing-function&gt;#`</para>
        /// <para> **Initial value**: `ease`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitTransitionTimingFunction
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-transition-timing-function"];
            set => _properties["-webkit-transition-timing-function"] = value;
        }

        /// <summary>
        /// **Syntax**: `read-only | read-write | read-write-plaintext-only`
        /// <para> **Initial value**: `read-only`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitUserModify
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-user-modify"];
            set => _properties["-webkit-user-modify"] = value;
        }

        /// <summary>
        /// The **`user-select`** CSS property controls whether the user can select text. This doesn't have any effect on content loaded as part of a browser's user interface (its chrome), except in textboxes.
        /// <para> **Syntax**: `auto | text | none | contain | all`</para>
        /// <para> **Initial value**: `auto`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitUserSelect
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-user-select"];
            set => _properties["-webkit-user-select"] = value;
        }

        /// <summary>
        /// The **`writing-mode`** CSS property sets whether lines of text are laid out horizontally or vertically, as well as the direction in which blocks progress. When set for an entire document, it should be set on the root element (`html` element for HTML documents).
        /// <para> **Syntax**: `horizontal-tb | vertical-rl | vertical-lr | sideways-rl | sideways-lr`</para>
        /// <para> **Initial value**: `horizontal-tb`</para>
        /// </summary>
        public Property<CSSProperties, PropertySkip, string> WebkitWritingMode
        {
            get => (Property<CSSProperties, PropertySkip, string>) _properties["-webkit-writing-mode"];
            set => _properties["-webkit-writing-mode"] = value;
        }

    }
}
