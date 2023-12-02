namespace CssInCSharp
{
    public static class Styles
    {
        public static CSSObject BenchmarkCss = new()
        {
            [".pro-card"] = new CSSObject()
            {
                Position = "relative",
                Display = "flex",
                FlexDirection = "column",
                BoxSizing = "border-box",
                Width = "100%",
                MarginBlock = 0,
                MarginInline = 0,
                PaddingBlock = 0,
                PaddingInline = 0,
                BackgroundColor = "#EFEFEF",
                BorderRadius = 5,
                Opacity = 0.5f,
                ["&-box-shadow"] = new CSSObject()
                {
                    BoxShadow = "0 1px 2px -2px #00000029, 0 3px 6px #0000001f, 0 5px 12px 4px #00000017",
                    BorderColor = "transparent"
                },
                ["&-col"] = new CSSObject()
                {
                    Width = "100%"
                },
                ["&-border"] = new CSSObject()
                {
                    Border = "20px solid #DDD"
                },
                ["&-hoverable"] = new CSSObject()
                {
                    Cursor = "pointer",
                    Transition = "box-shadow 0.3s, border-color 0.3s",
                    ["&:hover"] = new CSSObject()
                    {
                        BorderColor = "transparent",
                        BoxShadow = "0 1px 2px -2px #00000029, 0 3px 6px #0000001f, 0 5px 12px 4px #00000017",
                    },
                    ["&.pro-card-checked:hover"] = new CSSObject()
                    {
                        BorderColor = "#DDD"
                    }
                },
                ["&-checked"] = new CSSObject()
                {
                    BackgroundColor = "#EFEFEF",
                    BorderColor = "#DDD",
                    ["&::after"] = new CSSObject()
                    {
                        Position = "absolute",
                        InsetBlockStart = "2px",
                        InsetInlineEnd = "2px",
                        Width = 0,
                        Height = 0,
                        Border = "6px solid #485670",
                        BorderBlockEnd = "6px solid transparent",
                        BorderInlineStart = "6px solid transparent",
                        BorderStartEndRadius = "2px",
                        Content = "\"\"",
                    }
                },
                ["&:focus"] = new CSSObject()
                {
                    BackgroundColor = "#EFEFEF",
                    BorderColor = "#DDD",
                },
                ["&&-size-small"] = new CSSObject()
                {
                    [".pro-card"] = new CSSObject()
                    {
                        ["&-header"] = new CSSObject()
                        {
                            PaddingInline = "10px",
                            PaddingBlock = "10px",
                            PaddingBlockEnd = 0,
                            ["&-border"] = new CSSObject()
                            {
                                PaddingBlockEnd = "10px"
                            }
                        },
                        ["&-title"] = new CSSObject()
                        {
                            FontSize = "12px"
                        },
                        ["&-body"] = new CSSObject()
                        {
                            PaddingInline = "10px",
                            PaddingBlock = "10px",
                        }
                    }
                }
            }
        };

        public static CSSObject Selectors_I = new ()
        {
            ["a"] = new CSSObject()
            {
                Color = "blue",
                ["&:hover"] = new CSSObject()
                {
                    Color = "green"
                }
            }
        };

        public static CSSObject Selectors_II = new CSSObject()
        {
            [".button"] = new CSSObject()
            {
                ["&-ok"] = new CSSObject()
                {
                    BackgroundImage = "url(\"ok.png\")"
                },
                ["&-cancel"] = new CSSObject()
                {
                    BackgroundImage = "url(\"cancel.png\")"
                },
                ["&-custom"] = new CSSObject()
                {
                    BackgroundImage = "url(\"custom.png\")"
                }
            }
        };

        public static CSSObject Selectors_III = new()
        {
            [".link"] = new CSSObject()
            {
                ["& + &"] = new CSSObject()
                {
                    Color = "red"
                },
                ["& &"] = new CSSObject()
                {
                    Color = "green"
                },
                ["&&"] = new CSSObject()
                {
                    Color = "blue"
                },
                ["&, &ish"] = new CSSObject()
                {
                    Color = "cyan"
                }
            }
        };

        public static CSSObject Selectors_IV = new CSSObject()
        {
            [".grand"] = new CSSObject()
            {
                [".parent"] = new CSSObject()
                {
                    ["& > &"] = new CSSObject()
                    {
                        Color = "red"
                    },
                    ["& &"] = new CSSObject()
                    {
                        Color = "green"
                    },
                    ["&&"] = new CSSObject()
                    {
                        Color = "blue"
                    },
                    ["&, &ish"] = new CSSObject()
                    {
                        Color = "cyan"
                    }
                }
            }
        };

        public static CSSObject Selectors_V = new()
        {
            [".header"] = new CSSObject()
            {
                [".menu"] = new CSSObject()
                {
                    BorderRadius = "5px",
                    [".no-borderradius &"] = new CSSObject()
                    {
                        BackgroundImage = "url('images/button-background.png')"
                    }
                }
            }
        };
    }
}

