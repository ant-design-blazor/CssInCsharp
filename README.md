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
``` ini
BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1702/22H2/2022Update/SunValley2)
AMD Ryzen 7 5700G with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.203
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```
|    Method |     Mean |    Error |   StdDev |   Median |    Gen0 |   Gen1 | Allocated |
|---------- |---------:|---------:|---------:|---------:|--------:|-------:|----------:|
| CreateCss | 39.71 μs | 0.789 μs | 1.595 μs | 38.98 μs | 17.6392 | 1.0376 | 144.29 KB |
