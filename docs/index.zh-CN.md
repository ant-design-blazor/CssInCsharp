# 目录表
- [目录表](#目录表)
- [开始](#开始)
  - [安装包](#安装包)
  - [添加引用](#添加引用)
  - [创建CSSObject](#创建cssobject)
- [用法简介](#用法简介)
  - [结构化样式表](#结构化样式表)
  - [父选择](#父选择)
  - [样式合并](#样式合并)
    - [复用全局样式](#复用全局样式)
    - [使用操作符合并样式](#使用操作符合并样式)
    - [覆写已有样式](#覆写已有样式)
  - [变量](#变量)
    - [保留样式](#保留样式)
  - [方法](#方法)
  - [动画](#动画)
  - [颜色](#颜色)
  - [样式渲染](#样式渲染)
    - [StyleOutlet组件](#styleoutlet组件)
    - [StyleContent组件](#stylecontent组件)
    - [Style组件](#style组件)
  - [样式隔离](#样式隔离)
  - [自定义组件样式](#自定义组件样式)

# 开始

## 安装包
```sh
dotnet add package CssInCSharp
```

## 添加引用

在blazor项目中，添加以下代码到_Imports.razor文件中。

```CSharp
@using CssInCSharp
```

## 创建CSSObject
```CSharp
// 创建一个CSSObject对象
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

// 使用ToString方法来序列化样式表
var style = css.ToString();
// 或者使用SerializeCss方法序列化样式表。
var style = css.SerializeCss("hashId");
```

CSSObject类型支持字符串类型的索引器，你可以利用该索引器向样式对象中添加样式名称，样式属性，选择器和变量等。

```csharp
var css = new CSSObject
{
    // 索引器支持样式名称
    [".btn-default"] = new CSSObject
    {
        // 索引器支持选择器
        ["&:hober"] = ...,
        ["> span"] = ...,
        ["button"] = ...,

        // 索引器支持变量
        ["--btn-display"] = "block",

        // 索引器支持样式属性，但是推荐使用强类型属性字段
        ["color"] = "red",
    },
}
```
CSSObject为每个样式属性定义了属性类型，该类型支持多种值。

```csharp
var css = new CSSObject
{
    [".btn-default"] = new CSSObject
    {
        // Width属性既支持数字类型，同时也支持字符串类型。
        Width = 200,
        Width = "200px",
        Width = "100%",
        Width = "var(--btn-width)",
    },
}
```

数字类型的属性在序列化时会自动添加`px`后缀。CSSObject内部有一个数据集用来判断该属性是否支持px。

使用数字类型的属性，可以对属性进行数值运算，而不用进行类型转换。

```csharp
var token = 10;
var css = new CSSObject
{
    [".btn-default"] = new CSSObject
    {
        // 例如：可以在属性赋值时进行四则运算等。
        Width = 200 + token,
        Width = 200 - token,
        Width = 200 * token,
        Width = 200 / token,
    },
}
```

# 用法简介
## 结构化样式表

和less或sass类似，CSSObject也是结构化的样式表。可以使用对象嵌套的方式来表示样式的层级关系。


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

## 父选择

和less一样，CSSObject也是使用 `&` 来表示对父级选择器的引用。

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

`&` 操作符用途有很多，基本上只要是默认规则以外的其他方式组合嵌套的选择器都可以使用。例如：你可以使用 `&` 来生成重复的样式名称。


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

## 样式合并

在某些使用场景里，你可以使用Merge方式来继承或合并多个样式对象。

### 复用全局样式
```CSharp
// 这是一个全局共用样式对象
var globalCss = new CSSObject
{
    Background = "#EFEFEF",
    FontSize = "14px",
    Border = "1px solid #DDD",
    MarginBottom = "20px"
};

// 使用Merge方法可以将该全局样式合并到当前样式中，合并时会覆盖已经存在的同名属性。
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

### 使用操作符合并样式
CSSObject对象中提供了一个合并操作符`["..."]`，使用该操作符何以在构造期间进行指定位置的样式合并。

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
        // 使用 ["..."] 来合并全局样式, 写法类似TS中的 ...globalCss
        ["..."] = globalCss,
        Width = "100px",
        Height = "100px",
        Color = "red",
        ["..."] = colorCss, // 合并操作符何以多次使用。
    }
};
```

**注意** : Merge方法，只能用在对象构造之后。`["..."]`操作符可以用在对象构造期间。


### 覆写已有样式
Merge方法可以覆盖对象中已有的样式。例如：覆盖上述样式对象中div3的title的颜色值。

```CSharp
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

## 变量

CssInCsharp设计的目的就是为了能够利用C#语言的一切特性来生成样式。所以你可以在创建样式过程中使用C#定义的任何变量，包括但不限于全局变量，成员变量或局部变量。


```CSharp
private string _style = "";
private string _color = "red";        // 成员变量
[Parameter]
public int Size { get; set; } = 200;  // 组件属性

protected override void OnInitialized()
{
    var fontSize = "16px";            // 局部变量
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

    _style = css.ToString();
}
```
**变量值只在序列化时生效，一旦序列化完成后，样式就不再受变量值影响。除非重新序列化样式。**

### 保留样式

```CSharp
private CSSObject _css = new ();
private string _color = "red";
[Parameter]
public int Size { get; set; } = 200;  // 组件属性

protected override void OnInitialized()
{
    var fontSize = "16px";            // 局部变量
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

如果你需要在样式对象构造完成后并更新它，那么你需要将它定义成成员变量或全局变量。但这么做并不推荐。


以下是演示如何修改上述定义的CSSObject对象。

```CSharp
private void ClickToChangeCssObject() 
{
    // 1.使用Merge方法来修改其内容
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

    // 2.直接设置对象属性的值
    _css[".div2"]["& .title"].Color = "green";

    // 重新序列化样式
    _style = _css.ToString();
}
```
**注意: 尽可能不要在样式已经初始化结束再修改样式内容。**

## 方法

由于CssInCsharp是完全基于C#语言的，因此也可以在创建样式时调用C#定义的方法。

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
                // 直接调用普通的方法
                Height = $"{CalcBodyHeight(50, 50)}px",
                Width = "100%",
                BorderTop = "1px solid #DDD",
                BorderBottom = "1px solid #DDD",
                [".container"] = new CSSObject
                {
                    // 也可以调用async方法
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

## 动画

CSSObject类型的AnimationName属性支持`Keyframe`类型的值。使用该类型可以创建动画效果。

这是一个渐变效果的动画，在3s内将div宽度从0px变到100px，透明度从1变为0.2

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
                            Opacity = 0.2
                        }
                    }
                }
            }
        }.ToString();
    }
}
```

## 颜色
CssInCSharp提供了用于颜色处理和转换的TinyColor类型。该类型可以用来对不同颜色值进行转换处理。例如RGB和16进制互转等。同时也支持css颜色转rgb或16进制。

* 字符串rgb转16进制
```csharp
new TinyColor("rgb 255 0 0").ToHexString(); // 输出: #ff0000
```
* 16进制字符串转rgb
```csharp
new TinyColor("#fff").ToRgbString(); // 输出: rgb(255, 255, 255)
```
* css颜色值转16进制
```csharp
new TinyColor("red").ToHexString(); // 输出: #ff0000
```
* RGB对象转16进制
```csharp
new TinyColor(new RGB(255, 0, 0)).ToHexString(); // 输出: #ff0000
```
* 单独设置Alpha通道值
```csharp
new TinyColor("rgba(255, 0, 0, 1)").SetAlpha(0.9);
```

## 样式渲染

CssInCSharp提供一组用于样式渲染输出的组件。包括 `<StyleOutlet>` , `<StyleContent>` 和 `<Style>`。

### StyleOutlet组件
`<StyleOutlet>`组件是样式的入口组件，如果你需要将样式输出到页面的`head`标签中，那么你需要将该组件放到`head`里。西面演示如果在不同项目中设置该组件。


在wasm模板工程中, 在`Program.cs`文件里修改如下代码。
```csharp
// builder.RootComponents.Add<HeadOutlet>("head::after"); // 移除自动生成的HeadOutlet组件
builder.RootComponents.Add<StyleOutlet>("head::after");   // 添加StyleOutlet组件到RootComponents中
```
在server模板工程中, 需要修改`_Layout.cshtml`的代码。
```html
<head>
  <!--添加StyleOutlet，并且将它置于其它标签的最顶端。-->
  <component type="typeof(StyleOutlet)" render-mode="ServerPrerendered" />
  <meta charset="utf-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1.0" />
  ...
  <!--移除自带的HeadOutlet组件-->
  <!--<component type="typeof(HeadOutlet)" render-mode="ServerPrerendered" />-->
</head>
```

### StyleContent组件
`<StyleContent>`组件会把组件的内容渲染到`<StyleOutlet>`所在位置。StyleContent组件一般放在Razor页面里，每个页面只能有一个StyleContent组件。如果一个页面中同时存在多个StyleContent组件，那么只有最后渲染的那个组件才会生效。


Index.Razor页面：

```html
@page "/"

<div></div>

<PageTitle>Home</PageTitle>

<StyleContent>
  <style>.demo1{ color:'red'; }</style>
  <style>.demo2{ color:'yellow'; }</style>
</StyleContent>

@code{

}
```

StyleContent里可以放原生的style标签也可以放CssInCsharp提供的Style组件。

**NOTE：** 由于每个页面只能有一个StyleContent组件，因此StyleContent只能放在页面里，不能用在组件中。(因为组件可能会被实例化多次，例如Button组件，在同一个页面上也可能存在多个实例)

### Style组件
`<Style>`组件用于创建样式标签和保证样式的唯一性，要注意区别于html本身的`<style>`标签。


Style组件属性列表: 
| Name    | Type   | Desc                                          |
| ------- | ------ | --------------------------------------------- |
| HashId  | string | 样式的HashId，依据token计算得到，用于样式隔离 |
| Path    | string | 样式路径，用于保证样式唯一性                  |
| StyleFn | Func   | 样式生成方法                                  |


示例：
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
`Path` 属性为样式提供了唯一性保证，相同的Path只会创建一个style标签。因此在为组件设计样式时，一定要设置Path属性，这样无论该组件被实例化多少次，它的样式表有且只有一份。

在使用`<Style>`组件创建样式时，该组件会以Path属性为Key，为该样式生成缓存。缓存创建后即便组件状态发生变化，样式创建方法`StyleFn`不会再被调用，而是会从缓存中获取样式内容。`StyleFn`方法只在缓存不存在时才会被调用。


## 样式隔离
`<Style>`组件使用`:where`的伪类来实现样式隔离。如果你需要对样式进行样式隔离，那么只需要在样式序列化时带上`HashId`即可。

一般HashId是依据样式Token生成的，样式Token可以是主题相关配置，也可以依据自己的需求生成。它本身无特殊要求只是一个字符串而已。

一旦设置了`HashId`那么所有生成的样式都会带上`:where`伪类。只有符合的html标签该样式才会生效。

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
输出的样式:
```css
<style>
:where(.css-zcfrx9).div1{width:200px;height:200px;border:1px solid #DDD;}
</style>
```

## 自定义组件样式
在页面上，你可以使用`<StyleContent>`组件来添加页面样式。但是StyleContent并不能用在自定义的组件里。例如创建一个`<DemoComponent>`组件，该如何为这个自定义组件添加样式。CssInCsharp提供一个全局的Helper类`StyleHelper`。你可以使用`Register`方法来向head标签里注入样式。

DemoComponent.razor演示代码：
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
`StyleHelper`类中包含一组用于注册样式的方法。可直接注入`CSSObject`对象或样式字符串。
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
通过`CX`方法注入CSSObject时可以保留自定义className，否则会以HashId作为该对象的className，`CSS`方法可以直接注入样式字符串，该字符串可以包含结构化的样式内容。