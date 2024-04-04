const fs = require('fs');

function criarDatabaseContext(tabelas) {
    let dbContext = `
using Microsoft.EntityFrameworkCore;
using .Modelos;

namespace MyNovelAPI.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
`;
    // Adicionar DbSets para todas as tabelas
    for (const tabela of tabelas) {
        // Substituir caracteres especiais por "_"
        const nomeDbSet = tabela.replace(/[^a-zA-Z0-9_]/g, '');
        dbContext += `
        public DbSet<${tabela}> ${nomeDbSet} { get; set; }
`;
    }
    // Fechar a classe
    dbContext += `
    }
}
`;
    return dbContext;
}

// Carregar o arquivo JSON
const database = require('./database_schema.json');

// Extrair nomes das tabelas
const tabelas = Object.keys(database);

// Gerar o arquivo DatabaseContext
const dbContext = criarDatabaseContext(tabelas);

fs.writeFileSync('DatabaseContext.cs', dbContext);

console.log("Arquivo DatabaseContext gerado com sucesso!")