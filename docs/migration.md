## Antd v5 Style Migration

- Clone the source code of react-antd

```bash
git clone https://github.com/ant-design/ant-design.git
```

After cloning, the directory tree is as follows:
```
ant-design/
ant-design-blazor/
 ├── cssincs.json
```

`ant-design: ` is the source code of the React project.  
`ant-design-blazor: ` is the source code of the Blazor project.  

**For stable version, please use the git tag version**

- Install the generator

```bash
dotnet tool install -g CssInCSharp.CommandLine
```

- Create profile

Create a cssincs.json under the root path of the blazor project, as follows:

```json
{
  "Converter": "Ts",
  "CsOptions": {
    "Usings": [
      "System",
      "AntDesign",
      "CssInCSharp",
      "CssInCSharp.Colors",
      "static AntDesign.GlobalStyle",
      "static AntDesign.Theme",
      "static AntDesign.StyleUtil",
      "static AntDesign.PresetColors",
      "Keyframes = CssInCSharp.Keyframe"
    ],
    "Namespace": "AntDesign.Styles",
    "NamePrefix": "{dir:../../}",
    "DefaultReturnType": "object",
    "DefaultParameterType": "object",
    "DefaultVariableType": "object",
    "DefaultExportType": "object",
    "DefaultExportClassName": "{dir:../../}Style",
    "DefaultExportMethodName": "{file}Default",
    "UsePascalCase": true,
    "UsePartialClass": true,
    "UseStaticMethod": true,
    "Replacements": [
      {
        "Pattern": "class ComponentToken",
        "Value": "class ComponentToken : TokenWithCommonCls"
      },
      {
        "Pattern": "FullToken(\\<\\w*\\>)?",
        "Value": "ComponentToken"
      },
      {
        "Pattern": "(?<!var) gen(\\w+)",
        "Value": " Gen$1"
      },
      {
        "Pattern": "prepare(\\w+)",
        "Value": "Prepare$1"
      },
      {
        "Pattern": "(?<!token.)Calc\\(",
        "Value": "calc("
      },
      {
        "Pattern": "_skip_check_",
        "Value": "SkipCheck"
      },
      {
        "Pattern": "= textEllipsis",
        "Value": "= TextEllipsis"
      },
      {
        "Pattern": "= AvatarSizeStyle",
        "Value": "= avatarSizeStyle"
      },
      {
        "Pattern": "= GetCompactBorderStyle",
        "Value": "= getCompactBorderStyle"
      },
      {
        "Pattern": "CSSObject\\[\\]",
        "Value": "CSSInterpolation[]"
      },
      {
        "Pattern": "ButtonVariantType variant",
        "Value": "string variant = null"
      },
      {
        "Pattern": "variant &&",
        "Value": "variant == null &&"
      },
      {
        "Pattern": "var genDisabledButtonStyle",
        "Value": "Func<ButtonToken, CSSObject> genDisabledButtonStyle"
      },
      {
        "Pattern": "= GenDisabledButtonStyle",
        "Value": "= genDisabledButtonStyle"
      },
      {
        "Pattern": "PresetColorKey",
        "Value": "string"
      },
      {
        "Pattern": "token\\[(\\$@\"[^\"]+\")\\]",
        "Value": "token[$1].ToString()"
      },
      {
        "Pattern": "Unitless = new GenOptions",
        "Value": "Unitless = new"
      },
      {
        "Pattern": "getCompactBorderStyle\\(\\)",
        "Value": "getCompactBorderStyle(false)"
      },
      {
        "Pattern": "CSSObject hoverStyle, CSSObject activeStyle",
        "Value": "CSSObject hoverStyle = null, CSSObject activeStyle = null"
      },
      {
        "Pattern": "getColumnsStyle;",
        "Value": "GetColumnsStyle;"
      }
    ]
  },
  "Include": [
    {
      "Src": "../ant-design/components/**/style/*.ts",
      "Dest": "./components"
    }
  ],
  "Exclude": [
    "../ant-design/components/style/*.ts",
    "../ant-design/components/qrcode/style/*.ts"
  ],
  "TypeInferences": [
    {
      "RuleName": "ObjectTypeInfer_CSSObject",
      "Expression": "Kind == \"ObjectType\" && ((HasIndexer && Properties == null) || HasAny(\"margin\", \"width\", \"display\", \"position\", \"color\", \"direction\", \"flex\", \"background\"))",
      "Actions": {
        "OnSuccess": {
          "Name": "OutputExpression",
          "Context": {
            "Expression": "\"CSSObject\""
          }
        }
      }
    },
    {
      "RuleName": "ObjectTypeInfer_PropertySkip",
      "Expression": "Kind == \"ObjectType\" && HasKey(\"_skip_check_\")",
      "Actions": {
        "OnSuccess": {
          "Name": "OutputExpression",
          "Context": {
            "Expression": "\"PropertySkip\""
          }
        }
      }
    },
    {
      "RuleName": "ObjectTypeInfer_GenOptions",
      "Expression": "Kind == \"ObjectType\" && HasAny(\"deprecatedTokens\", \"unitless\")",
      "Actions": {
        "OnSuccess": {
          "Name": "OutputExpression",
          "Context": {
            "Expression": "\"GenOptions\""
          }
        }
      }
    },
    {
      "RuleName": "ReturnTypeInfer_CSSInterpolation_Size",
      "Expression": "Kind == \"ReturnType\" && FunctionName.StartsWith(\"genSize\")",
      "Actions": {
        "OnSuccess": {
          "Name": "OutputExpression",
          "Context": {
            "Expression": "\"CSSInterpolation\""
          }
        }
      }
    },
    {
      "RuleName": "ReturnTypeInfer_CSSObject",
      "Expression": "Kind == \"ReturnType\" && FunctionName.EndsWith(\"Style\")",
      "Actions": {
        "OnSuccess": {
          "Name": "OutputExpression",
          "Context": {
            "Expression": "\"CSSObject\""
          }
        }
      }
    },
    {
      "RuleName": "ReturnTypeInfer_Token",
      "Expression": "Kind == \"ReturnType\" && FunctionName.StartsWith(\"pre\") && FunctionName.EndsWith(\"Token\")",
      "Actions": {
        "OnSuccess": {
          "Name": "OutputExpression",
          "Context": {
            "Expression": "CsOptions.NamePrefix + \"Token\""
          }
        }
      }
    },
    {
      "RuleName": "ReturnTypeInfer_UseComponentStyleResult",
      "Expression": "Kind == \"ReturnType\" && FunctionName.EndsWith(\"indexDefault\")",
      "Actions": {
        "OnSuccess": {
          "Name": "OutputExpression",
          "Context": {
            "Expression": "\"UseComponentStyleResult\""
          }
        }
      }
    },
    {
      "RuleName": "ReturnTypeInfer_CSSInterpolation",
      "Expression": "Kind == \"ReturnType\" && (FunctionName == \"genStyleHooks\" || FunctionName == \"genSubStyleComponent\") && ValueType == \"array\"",
      "Actions": {
        "OnSuccess": {
          "Name": "OutputExpression",
          "Context": {
            "Expression": "\"CSSInterpolation\""
          }
        }
      }
    },
    {
      "RuleName": "ParameterTypeInfer_Token",
      "Expression": "Kind == \"ParameterType\" && Name.EndsWith(\"token\")",
      "Actions": {
        "OnSuccess": {
          "Name": "OutputExpression",
          "Context": {
            "Expression": "FunctionName.EndsWith(\"ComponentToken\") ? \"GlobalToken\" : CsOptions.NamePrefix + \"Token\""
          }
        }
      }
    },
    {
      "RuleName": "ParameterTypeInfer_CalcColor",
      "Expression": "Kind == \"ParameterType\" && FunctionName == \"genPresetColor\"",
      "Actions": {
        "OnSuccess": {
          "Name": "OutputExpression",
          "Context": {
            "Expression": "Name.Contains(\"binding\") ? \"CalcColor\" : \"string\""
          }
        }
      }
    },
    {
      "RuleName": "ParameterTypeInfer_StringColor",
      "Expression": "Kind == \"ParameterType\" && Name.Contains(\"Color\")",
      "Actions": {
        "OnSuccess": {
          "Name": "OutputExpression",
          "Context": {
            "Expression": "\"string\""
          }
        }
      }
    },
    {
      "RuleName": "PropertyTypeInfer_String",
      "Expression": "Kind == \"PropertyType\" && UnionType != null",
      "Actions": {
        "OnSuccess": {
          "Name": "OutputExpression",
          "Context": {
            "Expression": "\"CSSProperties\""
          }
        }
      }
    }
  ]
}
```

Where `Include` and `Exclude` are relative to the path of the react project, if you clone with a different path, please modify this configuration.

- Execute Convert Command

Execute the following command at the root path of the blazor project.

```bash
cssincs convert -c cssincs.json
```

After the command is executed, all .ts files will be converted to .cs files. If `Dest` specifies a folder instead of a file, the final file will be generated according to the directory of the source file.

## Legacy Issues
- Since C# doesn't support UnionType, like multiple inheritance or `Pick<T>`, `Omit<T>`, etc., are not possible.
  
To solve this problem, we plan to use a source generator to achieve the effect of Pick and Omit.
  
- Antd-Style library is not implemented

Sample code：

```cs
var style = new
{
  container = new CSSObject
  {
    MaxWidth = 400,
    Width = '100%',
    Height = 180,
    Display = 'flex',
  },
  card = css(@"
    margin-bottom: 8px;
    cursor: pointer;
    &:hover {
      color: #DDD;
    }
  ")
}

<div class="@style.card"></div>
<div class="@cx('a-simple-create-style-demo-classname', styles.container)"></div>
```
To solve the above problems, you only need to implement a css() and cx() method. CssInCSharp already supports the serialization of a `string` or a `CSSObject`.

## Guide

- Step1: Add new theme options for antd, eg:
  
  ```csharp
  services.AddAntDesign(option => 
  {
    option.DefaultTheme = "dark",
    option.ThemeAlgorithm = () => {
      ...
    }
  });
  ```

- Step2: Gen style code from ts code.
  ```bash
  # use cssincs cli tool
  cssincs convert -c cssincs.json

  # eg: button component
  button/
    ├── Button.razor
    ├── Button.razor.cs
    ├── style
        ├── index.cs
        ├── group.cs
        ├── compact.cs
        ├── token.cs
  ```

- Step3: Register style for each component
  ```csharp
  
  ```