# CssInCSharp Generator

In order to be able to migrate cssinjs style code or css style files to C# code, CssInCSharp implements a code migration tool.

## Usage
Install the command-line tools
```sh
dotnet tool install -g CssInCSharp.CommandLine
```

```sh
cssincs --help

Usage:
  CssInCSharp.CommandLine [command] [options] [[--] <additional arguments>...]]

Options:
  --version       Show version information
  -?, -h, --help  Show help and usage information

Commands:
  init     Init an empty configuration file.
  convert  Convert css file to c#.
Additional Arguments:
  Arguments passed to the application that is being run.
```

## Examples
- `cssincs init`
  
  Initialize an empty profile `cssincs.json`.

- `cssincs convert -c cssincs.json`
  
  Use the specified profile for conversions.

- `cssincs convert -t ts -s src/style.ts -d dest/style.cs`
  
  Convert the specified TS file to C# code.

## Options

- `--config, -c`
  
  Specify the profile for conversion. eg: ./cssincs.json

- `--source, -s`
  
  Source file path. This parameter is required if no profile is specified. eg: `./src/style.ts`, or use file globbing eg: `./src/**/*.ts`.

- `--dest, -d`
  
  The destination file, if not specified, will be output to the source file path.

- `--type, -t`
  
  The converter type supports `ts, css, less` etc.

- `--dry-run`

  Dry run and output the result to the console.

## Profile
Profile is recommended when you need to do a lot of file conversions or when you need to control the content of the output code.

Full profile example:

```json
{
  "Converter": "ts",
  "CsOptions": {
    "Usings": [
      "System",
      "CssInCSharp",
      "CssInCSharp.Colors",
      "static CssInCSharp.Css.CSSUtil",
      "Keyframes = CssInCSharp.Keyframe"
    ],
    "Namespace": "CssInCSharp.Styles",
    "NamePrefix": "{dir:../../}",
    "DefaultReturnType": "object",
    "DefaultParameterType": "object",
    "DefaultFieldType": "object",
    "DefaultClassName": "{dir:../../}Style",
    "DefaultExportMethodName": "{file}Default",
    "UsePascalCase": true,
    "UsePartialClass": true,
    "UseStaticMethod": true,
    "UseTypeInference": true,
    "TypeInferences": [
      {
        "Pattern": "^token$",
        "Value": "{NamePrefix}Token"
      }
    ],
    "Replacements": [
      {
        "Pattern": "FullToken(\\<\\w*\\>)?",
        "Value": "ComponentToken"
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
    "../ant-design/components/style/*.ts"
  ]
}
```
