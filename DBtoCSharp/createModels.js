const fs = require('fs');

const tipo_de_dado_map = {
    'LONG': 'string',  
    'DATE': 'string',
    'VARCHAR2': 'string',
    'URITYPE': 'string',
    'CHAR': 'string',
    'NVARCHAR2': 'string',
    'BLOB': 'byte[]',
    'XMLTYPE': 'string',  
    'NCHAR': 'string',
    'TIMESTAMP(6) WITH TIME ZONE': 'string',
    'RAW': 'byte[]',
    'NUMBER': 'int',
    'CLOB': 'string',  
    'FLOAT': 'float',
};

function criarAnotacoes(coluna) {
    const anotacoes = [];

    if (coluna['nullable'] === 'false') {
        anotacoes.push('[Required]');
    }

    if (coluna['data_type'] === 'VARCHAR2') {
        anotacoes.push(`[StringLength(${coluna["data_length"]})]`);
    }

    if (coluna['is_primary_key'] === 'true') {
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
        const tipoDeDado = tipo_de_dado_map[detalhesColuna['data_type']] || 'object';
        const comentario = detalhesColuna['comment'] || '';
        classe += `        ${anotacoes}
        /// <summary>
        /// ${comentario}
        /// </summary>
        public ${tipoDeDado} ${nomeColuna} { get; set; }
`;
    }
    for (const [triggerNome, triggerSql] of Object.entries(infoTabela['triggers'])) {
        // Converto triggerSql para string se não for uma
        const triggerString = typeof triggerSql === 'string' ? triggerSql : JSON.stringify(triggerSql);
        
        // Aplico a substituição de caracteres especiais
        const triggerSqlFormatado = triggerString.replace(/`/g, '\\"');
    
        // Concateno a string formatada com a classe
        classe += `
        [NotMapped]
        public string Trigger_${triggerNome} { get; set; } = \`${triggerSqlFormatado}\`;
    `;
    }

    classe += `
    }
}
`;
    return classe;
}

const database = require('./database_schema.json');


const tiposDeDadosUnicos = new Set();

// select do log dos tipos de dados únicos
for (const [, detalhesTabela] of Object.entries(database)) {
    for (const [, detalhesColuna] of Object.entries(detalhesTabela['columns'])) {
        tiposDeDadosUnicos.add(detalhesColuna['data_type']);
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
