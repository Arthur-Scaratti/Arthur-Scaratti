const fs = require('fs');

const tipo_de_dado_map = {
    "INT":	"int",
    "BIGINT":	"long",
    "SMALLINT":	"short",
    "TINYINT":	"byte",
    "DOUBLE":	"double",
    "DECIMAL":	"decimal",
    "VARCHAR":	"string",
    "TEXT":	"string",
    "TIME":	"string",
    "DATETIME":	"string",
    "TIMESTAMP":	"string",
    "BOOLEAN":	"bool",
    "BLOB":	"byte[]",
    "ENUM":	"string",
    "JSON":	"string",
    'LONG': 'string',  
    'DATE': 'string',
    'URITYPE': 'string',
    'CHAR': 'string',
    'NVARCHAR2': 'string',
    'XMLTYPE': 'string',  
    'NCHAR': 'string',
    'TIMESTAMP(6) WITH TIME ZONE': 'string',
    'RAW': 'byte[]',
    'NUMBER': 'int',
    'CLOB': 'string',  
    'FLOAT': 'float',
    "MEDIUMTEXT": 'string', 
    "LONGTEXT": 'string',
    "TINYINT": 'int',
};

function criarAnotacoes(coluna) {
    const anotacoes = [];

    if (coluna['IS_NULLABLE'] === 'NO') {
        anotacoes.push('[Required]');
    }

    if (coluna['DATA_TYPE'] === 'varchar') {
        anotacoes.push(`[StringLength(${coluna["CHARACTER_MAXIMUM_LENGTH"]})]`);
    }

    if (coluna['COLUMN_KEY'] === 'PRI') {
        anotacoes.push('[Key]');
    }

    return anotacoes.length === 0 ? '' : '    ' + anotacoes.join('\n    ');
}

function criarClasse(nomeTabela, infoTabela) {
    let classe = `
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ${nomeTabela}
    {
`;
    for (const [nomeColuna, detalhesColuna] of Object.entries(infoTabela['columns'])) {
        const anotacoes = criarAnotacoes(detalhesColuna);
        const tipoDeDado = tipo_de_dado_map[detalhesColuna['DATA_TYPE'].toUpperCase()];
        const comentario = detalhesColuna['comment'] || '';
        classe += `        ${anotacoes}
        /// <summary>
        /// ${comentario}
        /// </summary>
        public ${tipoDeDado} ${nomeColuna} { get; set; }
`;
    }
    /*for (const [triggerNome, triggerSql] of Object.entries(infoTabela['triggers'])) {
        // Converto triggerSql para string se não for uma
        const triggerString = typeof triggerSql === 'string' ? triggerSql : JSON.stringify(triggerSql);
        
        // Aplico a substituição de caracteres especiais
        const triggerSqlFormatado = triggerString.replace(/`/g, '\\"');
    
        // Concateno a string formatada com a classe
        /*classe += `
        [NotMapped]
        public string Trigger_${triggerNome} { get; set; } = \`${triggerSqlFormatado}\`;
    `;*/

    classe += `
}
}
`;
return classe;
    }



function modelsCreation()
    {
        const database = require('./database_schema.json');


    const tiposDeDadosUnicos = new Set();

    // select do log dos tipos de dados únicos
    for (const [, detalhesTabela] of Object.entries(database)) {
        for (const [, detalhesColuna] of Object.entries(detalhesTabela['columns'])) {
            tiposDeDadosUnicos.add(detalhesColuna['DATA_TYPE']);
        }
    }

    //log com os tipos de dados únicos
    fs.writeFileSync('tipos_de_dados.log', 'Tipos de Dados Únicos Encontrados:\n');
    for (const tipoDeDado of tiposDeDadosUnicos) {
        fs.appendFileSync('tipos_de_dados.log', `- ${tipoDeDado}\n`);
    }

    console.log("Log gerado com sucesso!");

    // Crio a pasta 'modelos' se não existir
    if (!fs.existsSync('modelos')) {
        fs.mkdirSync('modelos');
    }

    // arquivos das classes
    for (const [tabela, detalhesTabela] of Object.entries(database)) {
        fs.writeFileSync(`modelos/${tabela}.cs`, criarClasse(tabela, detalhesTabela));
    }

    console.log("Modelos gerados com sucesso!");
    }

module.exports = modelsCreation;