# CssInCSharp

A lib for generating Style Sheets with C#.

[English](./docs/index.md) | [简体中文](./docs/index.zh-CN.md)

![Latest Version](https://img.shields.io/github/actions/workflow/status/ant-design-blazor/CssInCsharp/package.yml?style=flat-square)
[![CssInCSharp](https://img.shields.io/nuget/v/CssInCSharp.svg?color=red&style=flat-square)](https://www.nuget.org/packages/CssInCsharp)

## Getting started
```sh
dotnet add package CssInCSharp
```

## Usage
- Used in native style tag
```csharp
<div class="basic">
    <div class="title">Title</div>
    <button class="button">Click</button>
</div>

<style>
    @_css
</style>

@code
{
    private string _css = string.Empty;

    protected override void OnInitialized()
    {
        _css = new CSSObject
        {
            [".basic"] = new CSSObject
            {
                Width = 300,
                Height = 300,
                Border = "1px solid #DDD",
                ["& .title"] = new CSSObject
                {
                    LineHeight = 20,
                    Color = "red"
                },
                ["& .button"] = new CSSObject
                {
                    Width = "100%",
                    Height = "20px",
                    TextAlign = "center",
                    ["&:hover"] = new CSSObject
                    {
                        Color = "blue"
                    }
                }
            }
        }.ToString();
    }
}
```

- Use StyleContent Or Style Component
```csharp
<div class="div1">
    Style In Head
</div>

<div class="div2">
    Style In Body
</div>

<!-- style in head -->
<StyleContent>
    <Style StyleFn="@StyleInHead" Path="Basic|StyleTag"></Style>
</StyleContent>

<!--style in body-->
<Style StyleFn="@StyleInBody"></Style>

@code {
    private CSSInterpolation StyleInHead()
    {
        return new CSSObject
        {
            [".div1"] = new CSSObject
            {
                Width = "200px",
                Height = "200px",
                Border = "1px solid #DDD",
            }
        };
    }

    private CSSInterpolation StyleInBody()
    {
        return new CSSObject
        {
            [".div2"] = new CSSObject
            {
                Width = "200px",
                Height = "200px",
                Border = "1px solid #DDD",
                BackgroundColor = "#EFEFEF",
            }
        };
    }
}
```

- Register style
```csharp
@_node

@code {

    private RenderFragment _node;

    protected override void OnInitialized()
    {
        var token = new
        {
            ColorBgLayout = "#ddd",
            BorderRadiusLG = "8px",
            BoxShadow = "5px #DEDEDE",
            Padding = 20,
            BorderRadius = 4,
            ColorTextTertiary = "#000",
            ColorBgContainer = "#EFEFEF",
            MotionEaseInBack = "",
            ColorTextSecondary = "",
            BoxShadowSecondary = ""
        };
        var styles = new
        {
            container = new CSSObject
            {
                BackgroundColor = token.ColorBgLayout,
                BorderRadius = token.BorderRadiusLG,
                MaxWidth = 400,
                Width = "100%",
                Height = 180,
                Display = "flex",
                AlignItems = "center",
                JustifyContent = "center",
                FlexDirection = "column",
                MarginLeft = "auto",
                MarginRight = "auto",
            },

            card = CSS($$""""
                box-shadow: {{token.BoxShadow}};
                padding: {{token.Padding}}px;
                border-radius: {{token.BorderRadius}}px;
                color: {{token.ColorTextTertiary}};
                background: {{token.ColorBgContainer}};
                transition: all 100ms {{token.MotionEaseInBack}};

                margin-bottom: 8px;
                cursor: pointer;

                &:hover {
                  color: {{token.ColorTextSecondary}};
                  box-shadow: {{token.BoxShadowSecondary}};
                }
            """"),
        };

        _node = @<div class="@CX("a-simple-create-style-demo-classname", styles.container)">
                    <div class="@styles.card">createStyles Demo</div>
                    <div>Current theme mode: dark</div>
                </div>;
    }
}
```

For other examples, you can check out the example code. For more information, please refer to the [document](./docs/index.md).

## Css Compiler
The CssInCSharp is similar to less or sass. You can simply convert you style file into C# class, so that you can make full use of the C# language features to generate style content.

## Css Converter
For those projects that are already using css or ts styles, you can use the [converter](./generators/README.md) provided by CssInCSharp to convert css or ts code into C# code, which improves style control and code reuse.

For details about the style migration of antd-v5, see the [Antd v5 Style Migration Document](./docs/migration.md).

## Benchmark
```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.26100.3775)
AMD Ryzen 7 5700G with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 9.0.200
  [Host]   : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  .NET 5.0 : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2
  .NET 6.0 : .NET 6.0.28 (6.0.2824.12007), X64 RyuJIT AVX2
  .NET 7.0 : .NET 7.0.17 (7.0.1724.11508), X64 RyuJIT AVX2
  .NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  .NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2


```
| Method    | Job      | Runtime  | Mean     | Error    | StdDev   | Median   | Ratio | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------- |--------- |--------- |---------:|---------:|---------:|---------:|------:|--------:|--------:|-------:|----------:|------------:|
| CreateCss | .NET 5.0 | .NET 5.0 | 55.68 μs | 1.112 μs | 1.795 μs | 55.56 μs |  1.00 |    0.00 | 20.0806 | 1.0986 | 164.32 KB |        1.00 |
| CreateCss | .NET 6.0 | .NET 6.0 | 51.66 μs | 1.024 μs | 2.374 μs | 52.28 μs |  0.91 |    0.05 | 19.3481 | 1.0986 | 158.04 KB |        0.96 |
| CreateCss | .NET 7.0 | .NET 7.0 | 48.51 μs | 0.969 μs | 1.450 μs | 48.49 μs |  0.87 |    0.03 | 19.3481 | 1.0376 | 158.11 KB |        0.96 |
| CreateCss | .NET 8.0 | .NET 8.0 | 41.71 μs | 1.585 μs | 4.391 μs | 40.90 μs |  0.81 |    0.08 | 19.2871 | 1.0986 | 157.98 KB |        0.96 |
| CreateCss | .NET 9.0 | .NET 9.0 | 33.33 μs | 0.660 μs | 1.840 μs | 32.80 μs |  0.62 |    0.03 | 19.2871 | 1.0986 | 157.98 KB |        0.96 |



## Special Thanks

[cssinjs](https://github.com/ant-design/cssinjs): Component level cssinjs solution used in ant.design.

[stylis](https://github.com/thysultan/stylis): A Light–weight CSS Preprocessor.

[csstype](https://github.com/frenic/csstype): TypeScript and Flow definitions for CSS.

[tinycolor](https://github.com/scttcper/tinycolor): A small library for color manipulation and conversion.

[TypeScriptAST](https://github.com/ToCSharp/TypeScriptAST): .NET port of TypeScript parser.