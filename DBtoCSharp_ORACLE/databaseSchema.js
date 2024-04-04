const oracledb = require('oracledb');
oracledb.initOracleClient({libDir: 'C:\\Program Files\\instantclient_11_2'});

async function connectToDatabase() {
    try {
        const connection = await oracledb.getConnection({
            user: 'compiereprod',
            password: 'DIEB3G5PPRT',
            connectString: "(DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.3)(PORT = 1521)))(CONNECT_DATA =(SERVICE_NAME = diementz)))"
        });
        console.log('Connected to the database');
        return connection;
    } catch (error) {
        console.error('Error connecting to the database:', error);
        throw error;
    }
}

async function retrieveSchema() {
    const schema = {}; // Objeto para armazenar o esquema
    const connection = await connectToDatabase();

    try {
        // Consulta para obter os nomes das tabelas
        const tablesQuery = `SELECT table_name 
                             FROM all_tables 
                             WHERE owner = 'COMPIEREPROD' 
                             AND avg_row_len > 0`;
        const tablesResult = await connection.execute(tablesQuery);

        // Iterar sobre cada tabela
        for (const tableRow of tablesResult.rows) {
            const tableName = tableRow[0];
            schema[tableName] = { columns: {}, triggers: {}, procedures: {} }; // Objeto para armazenar as colunas, triggers e procedures da tabela

            // Consulta para obter os metadados das colunas da tabela
            const columnsQuery = `SELECT cols.*,
                                        (CASE WHEN EXISTS (SELECT 1 
                                                            FROM all_cons_columns 
                                                            WHERE owner = 'COMPIEREPROD' 
                                                            AND table_name = cols.table_name 
                                                            AND column_name = cols.column_name 
                                                            AND constraint_name IN (SELECT constraint_name 
                                                                                    FROM all_constraints 
                                                                                    WHERE owner = 'COMPIEREPROD' 
                                                                                    AND table_name = cols.table_name 
                                                                                    AND constraint_type = 'P')) 
                                                  THEN 'Y' ELSE 'N' END) AS is_primary_key,
                                        comments.comments as column_comment
                                  FROM all_tab_columns cols
                                  LEFT JOIN all_col_comments comments ON cols.owner = comments.owner 
                                                                             AND cols.table_name = comments.table_name 
                                                                             AND cols.column_name = comments.column_name
                                  WHERE cols.owner = 'COMPIEREPROD' AND cols.table_name = :tableName`;
            const columnsResult = await connection.execute(columnsQuery, [tableName]);
            for (const columnRow of columnsResult.rows) {
                const columnName = columnRow[2];
                const columnInfo = {
                    OWNER: columnRow[0],
                    TABLE_NAME: columnRow[1],
                    COLUMN_NAME: columnRow[2],
                    DATA_TYPE: columnRow[3],
                    //DATA_TYPE_MOD: columnRow[4],
                    //DATA_TYPE_OWNER: columnRow[5],
                    DATA_LENGTH: columnRow[6],
                    DATA_PRECISION: columnRow[7],
                    DATA_SCALE: columnRow[8],
                    NULLABLE: columnRow[9],
                    COLUMN_ID: columnRow[10],
                    DEFAULT_LENGTH: columnRow[11],
                    DATA_DEFAULT: columnRow[12],
                    //NUM_DISTINCT: columnRow[13],
                    //LOW_VALUE: columnRow[14],
                    //HIGH_VALUE: columnRow[15],
                    //DENSITY: columnRow[16],
                    //NUM_NULLS: columnRow[17],
                    //NUM_BUCKETS: columnRow[18],
                    //LAST_ANALYZED: columnRow[19],
                    //SAMPLE_SIZE: columnRow[20],
                    CHARACTER_SET_NAME: columnRow[21],
                    CHAR_COL_DECL_LENGTH: columnRow[22],
                    //GLOBAL_STATS: columnRow[23],
                    //USER_STATS: columnRow[24],
                    //AVG_COL_LEN: columnRow[25],
                    //CHAR_LENGTH: columnRow[26],
                    //CHAR_USED: columnRow[27],
                    //V80_FMT_IMAGE: columnRow[28],
                    //DATA_UPGRADED: columnRow[29],
                    //HISTOGRAM: columnRow[30],
                    IS_PRIMARY_KEY: columnRow[31] === 'Y' ? 'true' : 'false',
                    COLUMN_COMMENT: columnRow[32]
                };

                schema[tableName].columns[columnName] = columnInfo;
            }
        }

        // Consulta para obter as triggers
        const triggersQuery = `SELECT trigger_name, table_name, triggering_event, trigger_body
                               FROM all_triggers
                               WHERE owner = 'COMPIEREPROD'`;
        const triggersResult = await connection.execute(triggersQuery);

        // Iterar sobre cada trigger e adicionar ao esquema
        for (const triggerRow of triggersResult.rows) {
            const triggerName = triggerRow[0];
            const tableName = triggerRow[1];
            const triggeringEvent = triggerRow[2];
            const triggerBody = triggerRow[3];

            if (!schema[tableName]) {
                schema[tableName] = { columns: {}, triggers: {}, procedures: {} };
            }

            if (!schema[tableName].triggers) {
                schema[tableName].triggers = {};
            }

            schema[tableName].triggers[triggerName] = {
                triggering_event: triggeringEvent,
                trigger_body: triggerBody
            };
        }

        // Escrever o esquema para um único arquivo JSON
        const fs = require('fs');
        fs.writeFileSync('database_schema.json', JSON.stringify(schema, null, 2));
        
        console.log('Schema saved to database_schema.json');

    } catch (error) {
        console.error('Error retrieving schema:', error);
    } finally {
        await connection.close();
    }
}


retrieveSchema();
