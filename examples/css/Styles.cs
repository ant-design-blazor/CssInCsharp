namespace CssInCs
{
    public static class Styles
    {
        public static CSSObject BenchmarkCss = new()
        {
            [".pro-card"] = new()
            {
                Position = "relative",
                Display = "flex",
                FlexDirection = "column",
                BoxSizing = "border-box",
                Width = "100%",
                MarginBlock = "0px",
                MarginInline = "0px",
                PaddingBlock = "0px",
                PaddingInline = "0px",
                BackgroundColor = "#EFEFEF",
                BorderRadius = "5px",
                ["&-box-shadow"] = new()
                {
                    BoxShadow = "0 1px 2px -2px #00000029, 0 3px 6px #0000001f, 0 5px 12px 4px #00000017",
                    BorderColor = "transparent"
                },
                ["&-col"] = new()
                {
                    Width = "100%"
                },
                ["&-border"] = new()
                {
                    Border = "20px solid #DDD"
                },
                ["&-hoverable"] = new()
                {
                    Cursor = "pointer",
                    Transition = "box-shadow 0.3s, border-color 0.3s",
                    ["&:hover"] = new()
                    {
                        BorderColor = "transparent",
                        BoxShadow = "0 1px 2px -2px #00000029, 0 3px 6px #0000001f, 0 5px 12px 4px #00000017",
                    },
                    ["&pro-card-checked:hover"] = new()
                    {
                        BorderColor = "#DDD"
                    }
                },
                ["&-checked"] = new()
                {
                    BackgroundColor = "#EFEFEF",
                    BorderColor = "#DDD",
                    ["&::after"] = new()
                    {
                        Position = "absolute",
                        InsetBlockStart = "2px",
                        InsetInlineEnd = "2px",
                        Width = "0px",
                        Height = "0px",
                        Border = "6px solid #485670",
                        BorderBlockEnd = "6px solid transparent",
                        BorderInlineStart = "6px solid transparent",
                        BorderStartEndRadius = "2px",
                        Content = "\"\"",
                    }
                },
                ["&:focus"] = new()
                {
                    BackgroundColor = "#EFEFEF",
                    BorderColor = "#DDD",
                },
                ["&&-size-small"] = new()
                {
                    ["pro-card"] = new()
                    {
                        ["&-header"] = new()
                        {
                            PaddingInline = "10px",
                            PaddingBlock = "10px",
                            PaddingBlockEnd = "0px",
                            ["&-border"] = new()
                            {
                                PaddingBlockEnd = "10px"
                            }
                        },
                        ["&-title"] = new()
                        {
                            FontSize = "12px"
                        },
                        ["&-body"] = new()
                        {
                            PaddingInline = "10px",
                            PaddingBlock = "10px",
                        }
                    }
                }
            }
        };
    }
}

