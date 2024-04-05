const fs = require('fs');
const { CsharpToTs, getConfiguration } = require("csharp-to-typescript");

const modelsFolder = './modelos';
const outputFolder = './output';
const preserveModifier = false;
const methodType = "signature"; // other options are 'lambda' or 'controller'
const changeToInterface = true;

// Verificar se a pasta de saída existe, senão, criá-la
if (!fs.existsSync(outputFolder)) {
    fs.mkdirSync(outputFolder);
}

// Função para converter um arquivo C# para TypeScript
function convertFileToTypeScript(filePath) {
    const csharpCode = fs.readFileSync(filePath, 'utf8');
    const withoutImports = csharpCode.replace(/using\s+.*?;/g, '');
    const typescriptCode = CsharpToTs(withoutImports, getConfiguration(preserveModifier, methodType, changeToInterface));
    return typescriptCode;
}

// Função para iterar sobre os arquivos na pasta de modelos
function convertModelsToTypeScript() {
    fs.readdir(modelsFolder, (err, files) => {
        if (err) {
            console.error('Erro ao ler a pasta de modelos:', err);
            return;
        }

        files.forEach(file => {
            const filePath = `${modelsFolder}/${file}`;
            if (fs.lstatSync(filePath).isFile() && file.endsWith('.cs')) {
                const typescriptCode = convertFileToTypeScript(filePath);
                const start = typescriptCode.indexOf('{');
                const end = typescriptCode.lastIndexOf('}');
                const codeInsideBraces = typescriptCode.substring(start + 1, end).trim();
                const cleanedCode = codeInsideBraces.split('\n').filter(line => line.trim()).join('\n');
                const outputFileName = file.replace('.cs', '.ts');
                fs.writeFileSync(`${outputFolder}/${outputFileName}`, cleanedCode);
            }
        });
    });
}
module.exports = convertModelsToTypeScript;