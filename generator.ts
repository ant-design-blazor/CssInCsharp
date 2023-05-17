
import * as fs from 'fs'

type PropertyItem = {
    name: string;
    indexer: string;
    comments: string[];
}

function escapeComment(input: string) {
    return input.replaceAll('<', '&lt;').replaceAll('>', '&gt;');
}

function getPropertyItems(lines: string[]): PropertyItem[] {
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
        const propertyName = pure.substring(0, pure.indexOf('?:'));
        const newName = propertyName.replace(regex, (m) => '-' + m.toLowerCase());
        items.push({
            name: propertyName.charAt(0).toUpperCase() + propertyName.slice(1),
            indexer: newName,
            comments: [...comments],
        });
    }
    return items;
}

function generateCsCode(input: string, output: string, start: number, end: number) {
    const content = fs.readFileSync(input, 'utf8');
    const lines = content.split(/\r?\n/).slice(start, end - 1);
    const tab = '        ';
    const items = getPropertyItems(lines);
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
        sb += tab + `public Property<string> ${item.name}\r\n`;
        sb += tab + '{\r\n';
        sb += tab + `    get => (Property<string>) _properties["${item.indexer}"];\r\n`;
        sb += tab + `    set => _properties["${item.indexer}"] = value;\r\n`;
        sb += tab + '}\r\n';
        sb += '\r\n';
    });

    const template = `namespace CssInCs
{
    public partial class CSSObject
    {
${sb}    }
}
`;
    fs.writeFileSync(output, template, 'utf8');
}

function generateStandardLonghand() {
    const input = './node_modules/csstype/index.d.ts';
    const output = './src/CSSObject.StandardLonghand.cs';
    generateCsCode(input, output, 11, 5064);
}

function generateStandardShorthand() {
    const input = './node_modules/csstype/index.d.ts';
    const output = './src/CSSObject.StandardShorthand.cs';
    generateCsCode(input, output, 5066, 5864);
}

function generate() {
    generateStandardLonghand();
    generateStandardShorthand();
}

generate();
