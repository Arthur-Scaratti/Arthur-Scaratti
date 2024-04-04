const mariadb = require('mariadb');
const pool = mariadb.createPool({
    host: 'localhost',
    user: 'root',
    password: '@ktngtr1',
    connectionLimit: 100,
});

async function retrieveSchema() {
    const schema = {}; // Objeto para armazenar o esquema
    let conn; // Declare a variável de conexão fora do bloco try
    try {
        conn = await pool.getConnection();
        console.log('Conectado ao banco de dados');

        const query_novellist = `
            SELECT TABLE_NAME
            FROM INFORMATION_SCHEMA.TABLES
            WHERE TABLE_SCHEMA = 'novel';
        `;
        const tablenames = await conn.execute(query_novellist);

        for (const tableRow of tablenames) {
            const tableName = tableRow.TABLE_NAME;
            console.log(tableName);
            schema[tableName] = { columns: {}};
            const columnsQuery = `
                SELECT *
                FROM INFORMATION_SCHEMA.COLUMNS
                WHERE TABLE_SCHEMA = 'novel'
                AND TABLE_NAME = ?`;

            const columnsResult = await conn.execute(columnsQuery, [tableName]);

            for (const columnRow of columnsResult) {

                const columnName = columnRow.COLUMN_NAME;

                console.log(columnName);

                const columnInfo = {
                    TABLE_SCHEMA: columnRow.TABLE_SCHEMA,
                    TABLE_NAME: columnRow.TABLE_NAME,
                    COLUMN_NAME: columnRow.COLUMN_NAME,
                    TABLE_CATALOG: columnRow.TABLE_CATALOG,
                    DATA_TYPE: columnRow.DATA_TYPE,
                    CHARACTER_MAXIMUM_LENGTH: columnRow.CHARACTER_MAXIMUM_LENGTH,
                    IS_NULLABLE: columnRow.IS_NULLABLE,
                    CHARACTER_OCTET_LENGTH: columnRow.CHARACTER_OCTET_LENGTH,
                    NUMERIC_PRECISION: columnRow.NUMERIC_PRECISION,
                    DATETIME_PRECISION: columnRow.DATETIME_PRECISION,
                    NUMERIC_SCALE: columnRow.NUMERIC_SCALE,
                    ORDINAL_POSITION: columnRow.ORDINAL_POSITION,
                    COLUMN_DEFAULT: columnRow.COLUMN_DEFAULT,
                    CHARACTER_SET_NAME: columnRow.CHARACTER_SET_NAME,
                    COLLATION_NAME: columnRow.COLLATION_NAME,
                    COLUMN_KEY: columnRow.COLUMN_KEY,
                    EXTRA: columnRow.EXTRA,
                    PRIVILEGES: columnRow.PRIVILEGES,
                    COLUMN_COMMENT: columnRow.COLUMN_COMMENT,
                    IS_GENERATED: columnRow.IS_GENERATED,
                    GENERATION_EXPRESSION: columnRow.GENERATION_EXPRESSION,
                };
                for (const [key, value] of Object.entries(columnRow)) {
                    columnInfo[key] = typeof value === 'bigint' ? value.toString() : value;
                }
                schema[tableName].columns[columnName] = columnInfo;
                // Adicione a lógica para armazenar as informações das colunas no objeto de esquema, se necessário
            }
        }

        const fs = require('fs');
        fs.writeFileSync('database_schema.json', JSON.stringify(schema, null, 2));
        
        console.log('Schema saved to database_schema.json');

    } catch (error) {
        console.error('Erro ao conectar ao banco de dados:', error);
        throw error;
    } finally {
        if (conn) conn.end(); // Feche a conexão
    }
}

retrieveSchema();
