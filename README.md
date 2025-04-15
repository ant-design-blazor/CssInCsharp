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

For other examples, you can check out the example code.

## Css Compiler
The CssInCSharp is similar to less or sass. You can simply convert you style file into C# class, so that you can make full use of the C# language features to generate style content.

## Benchmark
```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3593/23H2/2023Update/SunValley3)
AMD Ryzen 7 5700G with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  .NET 5.0 : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2
  .NET 6.0 : .NET 6.0.28 (6.0.2824.12007), X64 RyuJIT AVX2
  .NET 7.0 : .NET 7.0.17 (7.0.1724.11508), X64 RyuJIT AVX2
  .NET 8.0 : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2


```
| Method    | Job      | Runtime  | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|---------- |--------- |--------- |---------:|---------:|---------:|------:|--------:|--------:|-------:|----------:|------------:|
| CreateCss | .NET 5.0 | .NET 5.0 | 58.99 μs | 1.179 μs | 2.001 μs |  1.00 |    0.00 | 18.4326 | 0.9766 | 150.64 KB |        1.00 |
| CreateCss | .NET 6.0 | .NET 6.0 | 55.16 μs | 1.076 μs | 1.797 μs |  0.94 |    0.04 | 17.6392 | 1.0376 | 144.36 KB |        0.96 |
| CreateCss | .NET 7.0 | .NET 7.0 | 50.61 μs | 0.999 μs | 2.062 μs |  0.87 |    0.05 | 17.6392 | 1.0376 | 144.42 KB |        0.96 |
| CreateCss | .NET 8.0 | .NET 8.0 | 37.73 μs | 0.748 μs | 1.642 μs |  0.65 |    0.03 | 17.6392 | 0.9155 |  144.3 KB |        0.96 |


## Special Thanks

[cssinjs](https://github.com/ant-design/cssinjs): Component level cssinjs solution used in ant.design.
[stylis](https://github.com/thysultan/stylis): A Light–weight CSS Preprocessor.
[csstype](https://github.com/frenic/csstype): TypeScript and Flow definitions for CSS.
[tinycolor](https://github.com/scttcper/tinycolor): A small library for color manipulation and conversion.
[TypeScriptAST](https://github.com/ToCSharp/TypeScriptAST): .NET port of TypeScript parser.