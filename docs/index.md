# Table of Contents
- [Table of Contents](#table-of-contents)
- [Getting Started](#getting-started)
  - [Install Package](#install-package)
  - [Add Using](#add-using)
  - [Create CSS Object](#create-css-object)
- [Usage](#usage)
  - [Structured Stylesheet](#structured-stylesheet)
  - [Parent Selectors](#parent-selectors)
  - [Merge](#merge)
    - [Reuse global styles](#reuse-global-styles)
    - [Using merge operator](#using-merge-operator)
    - [Overwrite existing styles](#overwrite-existing-styles)
  - [Variables](#variables)
    - [Retain CSS](#retain-css)
  - [Functions](#functions)
  - [Animation](#animation)
  - [Colors](#colors)
  - [Style Rendering](#style-rendering)
  - [CSS Isolation](#css-isolation)
  - [Custom Component Style](#custom-component-style)

# Getting Started

## Install Package
```sh
dotnet add package CssInCSharp
```

## Add Using

Add usings to _Imports.razor file in your blazor project.

```CSharp
@using CssInCSharp
```

## Create CSS Object
```CSharp
// Create css object
var css = new CSSObject
{
    [".demo"] = new CSSObject
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
};

// Serialize the css object.
var style = css.ToString();
// or use hashId
var style = css.SerializeCss("hashId");
```

The CSSObject type supports a string indexer, which you can add calss names, attributes, selectors, and variables.

```csharp
var css = new CSSObject
{
    // class name
    [".btn-default"] = new CSSObject
    {
        // selectors
        ["&:hober"] = ...,
        ["> span"] = ...,
        ["button"] = ...,

        // css variable
        ["--btn-display"] = "block",
    },
}
```

The CSSObject defines a property type for each style property, which supports a wide range of types.

```csharp
var css = new CSSObject
{
    [".btn-default"] = new CSSObject
    {
        // different ways to set the value
        Width = 200,
        Width = "200px",
        Width = "100%",
        Width = "var(--btn-width)",
    },
}
```

The width of the number type is automatically wrapped with `px` at the time of serialization.


The benefit of numeric types is that you can use operators for style attributes.

```csharp
var token = 10;
var css = new CSSObject
{
    [".btn-default"] = new CSSObject
    {
        // eg: use four operations + - * /
        Width = 200 + token,
        Width = 200 - token,
        Width = 200 * token,
        Width = 200 / token,
    },
}
```

# Usage
## Structured Stylesheet

The stylesheet is structured, this is similar to less or sass.


HTML
```html
<div class="div1">
    <div class="div2">
        <div class="div3"></div>
    </div>
</div>
```
Standard CSS
```css
.div1 { ... }
.div1 .div2 { ... }
.div1 .div2 .div3 { ... }
```
CssInCSharp
```csharp
var css = new CSSObject
{
    [".div1"] = new CSSObject
    {
        [".div2"] = new CSSObject
        {
            [".div3"] = new CSSObject
            {
            }
        }
    }
}
```

## Parent Selectors

Referencing parent selectors with & , This is the same as less. 

```csharp
var css = new CSSObject
{
    ["a"] = new CSSObject
    {
        Color = "blue",
        ["&:hover"] = new CSSObject
        {
            Color = "green"
        }
    }
};
```

output:

```css
a {
  color: blue;
}

a:hover {
  color: green;
}
```

The `parent selectors` operator has a variety of uses. Basically any time you need the selectors of the nested rules to be combined in other ways than the default. For example another typical use of the & is to produce repetitive class names:

```csharp
var css = new CSSObject
{
    [".button"] = new CSSObject
    {
        ["&-ok"] = new CSSObject
        {
            BackgroundImage = "url(\"ok.png\")"
        },
        ["&-cancel"] = new CSSObject
        {
            BackgroundImage = "url(\"cancel.png\")"
        },
        ["&-custom"] = new CSSObject
        {
            BackgroundImage = "url(\"custom.png\")"
        }
    }
};
```

output:

```css
.button-ok {
  background-image: url("ok.png");
}
.button-cancel {
  background-image: url("cancel.png");
}
.button-custom {
  background-image: url("custom.png");
}
```

## Merge

You can use the merge method to inherit or merge multiple css object in some scenarios.

### Reuse global styles
```CSharp
var globalCss = new CSSObject
{
    Background = "#EFEFEF",
    FontSize = "14px",
    Border = "1px solid #DDD",
    MarginBottom = "20px"
};

// merge with a global css
var css = new CSSObject
{
    [".div1"] = new CSSObject
    {
        Width = "100px",
        Height = "100px",
        Color = "red"
    }.Merge(globalCss),
    [".div2"] = new CSSObject
    {
        Width = "120px",
        Height = "120px",
        Color = "blue"
    }.Merge(globalCss),
    [".div3"] = new CSSObject
    {
        Width = "120px",
        Height = "120px",
        Color = "blue",
        ["& .title"] = new CSSObject
        {
            Color = "cadetblue",
            FontSize = "20px"
        }
    }.Merge(globalCss)
};
```

### Using merge operator
```CSharp
var globalCss = new CSSObject
{
    Background = "#EFEFEF",
    FontSize = "14px",
    Border = "1px solid #DDD",
    MarginBottom = "20px"
};

var colorCss = new CSSObject
{
    Color = "green"
}

var css = new CSSObject
{
    [".div1"] = new CSSObject
    {
        // using "..." to merge globalCss, similar to the ...globalCss in ts.
        ["..."] = globalCss,
        Width = "100px",
        Height = "100px",
        Color = "red",
        ["..."] = colorCss, // merge operator can be used multiple times.
    }
};
```

**NOTE** : The Merge method can only overwrite the object property after instantiation, but the Merge operator can be overridden during instantiation.


### Overwrite existing styles

```CSharp
// override div3 title color
css.Merge(new CSSObject
{
    [".div3"] = new CSSObject
    {
        ["& .title"] = new CSSObject
        {
            Color = "yellow"
        }
    }
});
```

## Variables

You can use the variables defined in your class during css object creation, including member variables, local variables etc.

```CSharp
private string _style = "";
private string _color = "red";        // field
[Parameter]
public int Size { get; set; } = 200;  // component parameter

protected override void OnInitialized()
{
    var fontSize = "16px";            // local varibale
    var css = new CSSObject
    {
        [".div1"] = new CSSObject
        {
            Border = "1px solid #DDD",
            Width = $"{Size}px",
            Height = $"{Size}px",
            Color = _color,
            FontSize = fontSize,
            ["& .title"] = new CSSObject
            {
                Color = _color,
                FontSize = fontSize
            } 
        }
    };

    // variables are effective only during initialization
    _style = css.ToString();
}
```
**Variables are effective only during initialization, you should not change the css object by modifying variables after initialization.**

### Retain CSS

```CSharp
private CSSObject _css = new ();
private string _color = "red";
[Parameter]
public int Size { get; set; } = 200;  // component parameter

protected override void OnInitialized()
{
    var fontSize = "16px";            // local varibale
    _css = new CSSObject
    {
        [".div2"] = new CSSObject
        {
            Border = "1px solid #DDD",
            Width = $"{Size}px",
            Height = $"{Size}px",
            MarginTop = "10px",
            ["& .title"] = new CSSObject
            {
                Color = _color,
                FontSize = fontSize
            }
        }
    };
}
```

If you want to change css object after initialization, you should define css object as a member variable, but we do not recommend you to do this.

The following examples shows how to change a css object.

```CSharp
private void ClickToChangeCssObject() 
{
    // 1.use merge method to change css object, @see merge example.
    _css.Merge(new CSSObject
    {
        [".div2"] = new ()
        {
            ["& .title"] = new CSSObject
            {
                Color = "green"
            }
        }
    });

    // 2.or set property directly
    _css[".div2"]["& .title"].Color = "green";

    // rerender the style
    _style = _css.ToString();
}
```
**Remember: Never change the css object after initialization.**

## Functions

As you know, Functions are also supported.

```CSharp
private int _size = 500;
private string _style = "";

protected override async Task OnInitializedAsync()
{
    var css = new CSSObject
    {
        [".div"] = new CSSObject
        {
            Width = $"{_size}px",
            Border = "1px solid #DDD",
            ["& .header"] = new CSSObject
            {
                Height = "50px",
                Width = "100%",
            },
            ["& .footer"] = new CSSObject
            {
                Height = "50px",
                Width = "100%",
            },
            ["& .body"] = new CSSObject
            {
                // normal method
                Height = $"{CalcBodyHeight(50, 50)}px",
                Width = "100%",
                BorderTop = "1px solid #DDD",
                BorderBottom = "1px solid #DDD",
                [".container"] = new CSSObject
                {
                    // async method
                    Height = await GetContainerSizeAsync(),
                    BackgroundColor = "#EFEFEF",
                }
            }
        }
    };
    _style = css.ToString();
}

private int CalcBodyHeight(int header, int footer)
{
    return _size - header - footer;
}

private async Task<string> GetContainerSizeAsync()
{
    return await Task.FromResult("200px");
}
```

## Animation

We designed a **Keyframe** type to create animation styles, which are supported by the AnimationName property.

Transform animation example:

```csharp
<div class="transform">
    <span class="title">Transform</span>
    <div class="animation"></div>
</div>

<style>
    @_transform
</style>

@code {
    private string _transform = "";

    protected override void OnInitialized()
    {
        _transform = new CSSObject
        {
            [".transform"] = new CSSObject
            {
                Width = 120,
                Height = 120,
                ["& .title"] = new CSSObject
                {
                    Height = 20,
                    LineHeight = 20,
                    FontSize = 14
                },
                ["& .animation"] = new CSSObject
                {
                    Width = 100,
                    Height = 100,
                    BackgroundColor = "rgba(0, 0, 255, 0.5)",
                    AnimationDuration = "3s",
                    AnimationName = new Keyframe("animation-transform")
                    {
                        ["from"] = new()
                        {
                            Transform = "translateX(0px)",
                            Opacity = 1
                        },
                        ["to"] = new()
                        {
                            Transform = "translateX(100px)",
                            Opacity = 0.2f
                        }
                    }
                }
            }
        }.ToString();
    }
}
```

## Colors
CssInCSharp provider a TinyColor type for color manipulation and conversion.

```csharp
// convert rgb string to hex
new TinyColor("rgb 255 0 0").ToHexString(); // should be: #ff0000

// convert hex to rgb
new TinyColor("#fff").ToRgbString(); // should be: rgb(255, 255, 255)

// convert css color to hex
new TinyColor("red").ToHexString(); // should be: #ff0000

// from rgb
new TinyColor(new RGB(255, 0, 0)).ToHexString(); // should be: #ff0000

// set alpha
new TinyColor("rgba(255, 0, 0, 1)").SetAlpha(0.9);
```

## Style Rendering

The CssInCSharp lib provides a set of components for style rendering. Including `<StyleOutlet>` , `<StyleContent>` and `<Style>`.

The `<StyleOutlet>` component is the entry component of the style, if you want to render the style to the head tag, you need to put this component in the head.

In wasm project, add this code to `Program.cs` file.
```csharp
// builder.RootComponents.Add<HeadOutlet>("head::after"); // remove this line
builder.RootComponents.Add<StyleOutlet>("head::after");   // add StyleOutlet to head
```
In server project, add this code to `_Layout.cshtml` file.
```html
<head>
  <!--add StyleOutlet here, is should be on the top-->
  <!--also should remove HeadOutlet-->
  <component type="typeof(StyleOutlet)" render-mode="ServerPrerendered" />
  <meta charset="utf-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1.0" />
  ...
</head>
```

The content of the `<StyleContent>` will be rendered into the `<StyleOutlet>`. StyleContent will usually be placed on the page. Each page can only contain one StyleContent, if there are multiple ones, only the last rendered will take effect.

```html
@page "/"

<div></div>

<PageTitle>Home</PageTitle>

<StyleContent>
  <!--put your style here-->
</StyleContent>

@code{

}
```

The `<Style>` component provides style tag generation, style caching, and style uniqueness.

Style Component Properties: 
| Name    | Type   | Desc                     |
| ------- | ------ | ------------------------ |
| HashId  | string | Hash of style token.     |
| Path    | string | Path of style.           |
| StyleFn | Func   | Style generation method. |

```csharp
@page "/"

<div class="div1"></div>

<PageTitle>Home</PageTitle>

<StyleContent>
  <Style HashId="@_tokenHash" Path="home|button" StyleFn="@StyleFn"></Style>
</StyleContent>

@code
{
    private string _tokenHash = "css-zcfrx9";

    private CSSInterpolation GenStyle()
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
}
```

**NOTE:**
The `Path` provides uniqueness for the style, only one style tag will be created of the same path. When designing a component, you should add a Path to the component style, so that no matter how many instances the component creating, there is only one stylesheet for those instances.


When style is generated, the `<Style>` component will create a cache for the generated style based on the `Path`. When component is updated, if the style is cached, `StyleFn` will no longer execute, but will take the cached value.

## CSS Isolation
The `Style` component uses the `:where` pseudo-class to implement style isolation. If you need to enable style isolation, just set the value for the `HashId`.

```csharp
<div class="@_tokenHash div1"></div>

<StyleContent>
  <Style HashId="@_tokenHash" Path="home|button" StyleFn="@StyleFn"></Style>
</StyleContent>

@code{
    private string _tokenHash = "css-zcfrx9";

    private CSSInterpolation GenStyle()
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
}
```
The style output:
```css
<style>
:where(.css-zcfrx9).div1{width:200px;height:200px;border:1px solid #DDD;}
</style>
```

## Custom Component Style
On a page, you can use the `<StyleContent>` component to add styles, but you can't use StyleContent in custom component, so if you need to add a style to the head in the custom component, you need to use the `Register` method in the `StyleHelper` class to register the style.

DemoComponent.razor
```csharp
<div class="@_tokenHash demo"></div>

@code
{
    private string _tokenHash = "css-zcfrx9";

    protected override void OnInitialized()
    {
        StyleHelper.Register(new StyleInfo
        {
            HashId = _tokenHash,
            Path = new[] { "component", "demo" },
            StyleFn = GenStyle
        });
    }

    private CSSInterpolation GenStyle()
    {
        return new CSSObject
        {
            [".demo"] = new CSSObject
            {
                Width = "200px",
                Height = "200px",
                Border = "1px solid #DDD",
            }
        };
    }
}
```
The `StyleHelper` class contains a set of methods for registering styles. `CSSObject` or `CSSString` can be injected directly.
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
When injecting CSSObject via the `CX` method, you can keep the custom className, otherwise the `HashId` will be used as the default className, and the `CSS` method can inject a style string, which can contain structured style content.