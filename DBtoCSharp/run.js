const { exec } = require('child_process');

// Função para execução sequencial de scripts
function executarScripts() {
    exec('node databaseSchema.js', (error, stdout, stderr) => {
        if (error) {
            console.error(`Erro ao executar databaseSchema.js: ${error.message}`);
            return;
        }
        console.log(stdout);
        console.log("databaseSchema.js executado com sucesso!");

        exec('node createModels.js', (error, stdout, stderr) => {
            if (error) {
                console.error(`Erro ao executar createModels.js: ${error.message}`);
                return;
            }
            console.log(stdout);
            console.log("createModels.js executado com sucesso!");

            exec('node createContext.js', (error, stdout, stderr) => {
                if (error) {
                    console.error(`Erro ao executar createContext.js: ${error.message}`);
                    return;
                }
                console.log(stdout);
                console.log("createContext.js executado com sucesso!");
            });
        });
    });
}

// Executar os scripts
executarScripts();
