const { exec } = require('child_process');
const startTime = process.hrtime();
const retrieveSchema = require('./databaseSchema');
const modelsCreation = require('./createModels');
const create_context = require('./createContext');
const convertModelsToTypeScript = require('./cs2ts');

// Função para executar os scripts na ordem desejada
async function executarScripts() {
    try {
        // Execute retrieveSchema primeiro
        await retrieveSchema();
        console.log("retrieveSchema concluído com sucesso!");

        // Execute createModels e createContext em paralelo
        const [modelsResult, contextResult] = await Promise.all([
            modelsCreation(),
            create_context()
        ]);
        console.log("createModels e createContext concluídos com sucesso!");

        // Execute convertModelsToTypeScript por último
        await convertModelsToTypeScript();
        console.log("convertModelsToTypeScript concluído com sucesso!");
    } catch (error) {
        console.error("Ocorreu um erro durante a execução dos scripts:", error);
    }
}

executarScripts();
process.on('exit', () => {
    const endTime = process.hrtime(startTime);
    const elapsedTime = (endTime[0] + endTime[1] / 1e9).toFixed(3);
    console.log(`Tempo de execução: ${elapsedTime} segundos`);
});