
import * as fs from 'fs'
import unitless from '@emotion/unitless'

type PropertyItem = {
    name: string;
    type: string;
    indexer: string;
    comments: string[];
}

type PropertyTypeItem = {
    name: string;
    type: string;
}

type PropertyType = {
    name: string;
    types: PropertyTypeItem[];
}

const numberProperties = [
    "FontWeight"
]

// const floatProperties = [
//     'Opacity',
//     "LineHeight"
// ]

const animationProperties = [
    'AnimationName'
]

function fieldCode(tab: string, t: PropertyType): string {
    return t.types
        .map(x => `${tab}private readonly ${x.type} _${x.name};`)
        .join('\r\n');
}
function parameterCode(tab: string, t: PropertyType): string {
    return t.types
        .map(x => `${x.type} ${x.name} = default`)
        .join(', ');
}
function constructorCode(tab: string, t: PropertyType): string {
    return t.types
        .map(x => `${tab}    _${x.name} = ${x.name};`)
        .join('\r\n');
}
function operatorCode(tab: string, t: PropertyType): string {
    return t.types
        .map((x, i) => `${tab}public static implicit operator ${t.name}(${x.type} t) => new(${i}, ${x.name}: t);`)
        .join('\r\n');
}
function valueCode(tab: string, t: PropertyType): string {
    return t.types
        .map((x, i) => `${tab}        ${i} => FormatValue(key, _value${i}),`)
        .join('\r\n');
}
function objectValueCode(tab: string, t: PropertyType): string {
    return t.types
        .map((x, i) => `${tab}        ${i} => _value${i},`)
        .join('\r\n');
}
function hashCode(tab: string, t: PropertyType): string {
    return t.types
        .map((x, i) => `${tab}            ${i} => _value${i}?.GetHashCode(),`)
        .join('\r\n');
}

function escapeComment(input: string) {
    return input.replaceAll('<', '&lt;').replaceAll('>', '&gt;');
}

function getPropertyTypes(lines: string[]): PropertyType[] {
    const items: PropertyType[] = [];
    for (let i = 0; i < lines.length; i++) {
        const pure = lines[i].trim();
        if (!pure) continue;
        if (pure.startsWith('export type')) {
            const type = pure.replace('export type', '').trim();
            const i = type.indexOf('<');
            const j = type.indexOf('=');
            let name = '';
            if (i > 0) {
                if (i < j) {
                    name = type.substring(0, i).trim();
                } else {
                    name = type.substring(0, j).trim();
                }

            } else if (j > 0) {
                name = type.substring(0, j).trim();
            }

            const types: PropertyTypeItem[] = [];
            // CSSProperties
            types.push({ name: `value${types.length}`, type: 'CSSProperties' });
            // ignore type
            types.push({ name: `value${types.length}`, type: 'PropertySkip' });
            // string type
            types.push({ name: `value${types.length}`, type: 'string' });

            // number type
            if (type.includes('TLength =') || type.includes('number & {}') || numberProperties.includes(name)) {
                // use double for all number type properties.
                types.push({ name: `value${types.length}`, type: 'double' });
                // if (floatProperties.includes(name)) {
                //     types.push({ name: `value${types.length}`, type: 'double' });
                // } else {
                //     types.push({ name: `value${types.length}`, type: 'int' });
                // }
            }

            // animation type
            if (animationProperties.includes(name)) {
                types.push({ name: `value${types.length}`, type: 'Keyframe' });
            }
            items.push({ name: name, types: types });
        }
    }
    return items;
}

function getPropertyItems(lines: string[], propTypes?: PropertyType[]): PropertyItem[] {
    let comments: string[] = [];
    const regex = RegExp('[A-Z]', 'g');
    const items: PropertyItem[] = [];
    for (let i = 0; i < lines.length; i++) {
        const pure = lines[i].trimStart();
        if (pure.startsWith('/*')) {
            comments = [];
            continue;
        } else if (pure.startsWith('*/')) {
            continue;

        } else if (pure.startsWith('*')) {
            comments.push(pure.substring(1));
            continue;
        }
        const propertyName = pure.substring(0, pure.indexOf('?:')).trim();
        const j = pure.indexOf('|');
        const k = pure.indexOf('<');
        const index = k > 0 && k < j ? k : j;
        const newName = propertyName
            .replace(regex, (m) => '-' + m.toLowerCase())
            .replace(/^(moz|ms|webkit)(.+)/, '-$1$2');
        let propertyType = pure.substring(pure.indexOf('?:') + 2, index).trim();
        if (propTypes) {
            const type = propTypes.find(x => `Property.${x.name}` === propertyType);
            if (type) {
                const tType = type.types.map(x => x.type).join(', ');
                propertyType = `Property<${tType}>`;
            }
        }
        items.push({
            name: propertyName.charAt(0).toUpperCase() + propertyName.slice(1),
            type: propertyType,
            indexer: newName,
            comments: [...comments],
        });
    }
    return items;
}

function getFileContent(input: string, start: number, end: number) {
    const content = fs.readFileSync(input, 'utf8');
    return content.split(/\r?\n/).slice(start, end - 1);
}

function generatePropertyGeneric(output: string, totalCount: number = 1) {
    const tab = '        ';
    const types: PropertyType[] = [];
    for (let i = 0; i < totalCount; i++) {
        const arr = new Array(i + 1).fill('');
        const t = arr.map((x, i) => `T${i}`).join(', ');
        types.push({
            name: `Property<${t}>`,
            types: arr.map((x, i) => ({ name: `value${i}`, type: `T${i}` }))
        })
    }
    let sb = '';
    types.forEach(item => {
        sb += `
    public readonly struct ${item.name} : IProperty
    {
        private readonly int _index;
${fieldCode(tab, item)}

        private Property(int index, ${parameterCode(tab, item)})
        {
            _index = index;
${constructorCode(tab, item)}
        }

${operatorCode(tab, item)}

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is ${item.name} o && Equals(o);
        }

        public override string ToString() => GetValue(null);

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = _index switch
                {
${hashCode(tab, item)}
                    _ => 0
                } ?? 0;
                return (hashCode * 397) ^ _index;
            }
        }

        public string GetValue(string key)
        {
            return _index switch
            {
${valueCode(tab, item)}
                _ => throw new InvalidOperationException("Unexpected index.")
            };
        }

        public object GetValue()
        {
            return _index switch
            {
${objectValueCode(tab, item)}
                _ => throw new InvalidOperationException("Unexpected index.")
            };
        }
    }
`
    })

    const template = `using System;
using static CssInCSharp.Functions;

namespace CssInCSharp
{${sb}}
`;
    fs.writeFileSync(output, template, 'utf8');
}

function generatePropertyTypes(input: string, output: string, start: number, end: number) {
    const lines = getFileContent(input, start, end);
    const items = getPropertyTypes(lines);
    const tab = '            ';

    let sb = '';
    items.forEach((item) => {
        sb += `
        public readonly struct ${item.name} : IProperty
        {
            private readonly int _index;
${fieldCode(tab, item)}

            private ${item.name}(int index, ${parameterCode(tab, item)})
            {
                _index = index;
${constructorCode(tab, item)}
            }

${operatorCode(tab, item)}

            public string GetValue(string key)
            {
                return _index switch
                {
${valueCode(tab, item)}
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }

            public object GetValue()
            {
                return _index switch
                {
${objectValueCode(tab, item)}
                    _ => throw new InvalidOperationException("Unexpected index.")
                };
            }
        }
`;

    })

    const template = `using System;
using static CssInCSharp.Functions;

namespace CssInCSharp
{
    /**
     * If you want to use this property type to replace generic property types.
     * You can set "useGeneric = false" in "generator.ts".
     */
    public readonly struct Property
    {${sb}}
}
`;

    fs.writeFileSync(output, template, 'utf8');
}

function generatePropertyItems(input: string, output: string, start: number, end: number, useGeneric: boolean = true, obsolete: boolean = false, usings: string[] = []) {
    const lines = getFileContent(input, start, end);
    const tab = '        ';
    let propTypes: PropertyType[] = []
    if (useGeneric) {
        const propLines = getFileContent('./node_modules/csstype/index.d.ts', 18948, 20690);
        propTypes = getPropertyTypes(propLines)
    }
    const items = getPropertyItems(lines, propTypes);
    let sb = '';
    items.forEach((item) => {
        sb += tab + '/// <summary>\r\n';
        for (let i = 0; i < item.comments.length; i++) {
            const comment = item.comments[i];
            if (!comment) continue;
            if (i === 0) {
                sb += tab + `///${escapeComment(comment)}\r\n`;
            } else {
                sb += tab + `/// <para>${escapeComment(comment)}</para>\r\n`;
            }
        }
        sb += tab + '/// </summary>\r\n';
        if (obsolete) {
            sb += tab + `[Obsolete]\r\n`;
        }
        sb += tab + `public ${item.type} ${item.name}\r\n`;
        sb += tab + '{\r\n';
        sb += tab + `    get => (${item.type}) _properties["${item.indexer}"];\r\n`;
        sb += tab + `    set => _properties["${item.indexer}"] = value;\r\n`;
        sb += tab + '}\r\n';
        sb += '\r\n';
    });

    const using = usings.length > 0 ? usings.join('\r\n') + '\r\n\r\n' : '';

    const template = `${using}namespace CssInCSharp
{
    public partial class CSSObject
    {
${sb}    }
}
`;
    fs.writeFileSync(output, template, 'utf8');
}

function generateProperty() {
    const input = './node_modules/csstype/index.d.ts';
    const output = './src/Css/Property.cs';
    generatePropertyTypes(input, output, 18948, 20690);
    generatePropertyGeneric('./src/Css/PropertyT.cs', 4);
}

function generateStandardLonghand() {
    const input = './node_modules/csstype/index.d.ts';
    const output = './src/Css/CSSObject.StandardLonghand.cs';
    generatePropertyItems(input, output, 11, 5283);
}

function generateStandardShorthand() {
    const input = './node_modules/csstype/index.d.ts';
    const output = './src/Css/CSSObject.StandardShorthand.cs';
    generatePropertyItems(input, output, 5285, 6109);
}

function generateVendorLonghand() {
    const input = './node_modules/csstype/index.d.ts';
    const output = './src/Css/CSSObject.VendorLonghand.cs';
    generatePropertyItems(input, output, 6115, 7868);
}

function generateVendorShorthand() {
    const input = './node_modules/csstype/index.d.ts';
    const output = './src/Css/CSSObject.VendorShorthand.cs';
    generatePropertyItems(input, output, 7870, 8021);
}

function generateObsoleteProperties() {
    const input = './node_modules/csstype/index.d.ts';
    const output = './src/Css/CSSObject.ObsoleteProperties.cs';
    generatePropertyItems(input, output, 8025, 9078, true, true, ['using System;']);
}

function generateUnitless() {
    const tab = '            ';
    const transform = (key: string) => {
        const newName = key
            .replace(/[A-Z]/g, (m) => '-' + m.toLowerCase())
            .replace(/^(moz|ms|webkit)(.+)/, '-$1$2');
        return newName;
    }
    const items = Object.keys(unitless).map(key => `${tab}{ "${transform(key)}", ${unitless[key]} }`);
    let template = `using System.Collections.Generic;

namespace CssInCSharp
{
    /// <summary>
    /// @see https://github.com/emotion-js/emotion/blob/main/packages/unitless/src/index.js
    /// </summary>
    internal static class Unitless
    {
        public static Dictionary<string, int> Keys = new Dictionary<string, int>
        {
${items.join(',\r\n')}
        };
    }
}`;
    const output = './src/Css/Unitless.cs';
    fs.writeFileSync(output, template, 'utf8');
}

function generate() {
    generateProperty();
    generateStandardLonghand();
    generateStandardShorthand();
    generateVendorLonghand();
    generateVendorShorthand();
    generateObsoleteProperties();
    generateUnitless();
}

generate();