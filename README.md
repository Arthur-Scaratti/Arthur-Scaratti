BackEnd Tools Rep From Arthur Scaratti


/////////////////////////////////////////////////////////////////////////////////


PT-BR

DBtoCSharp


O DBtoCSharp é uma ferramenta que permite criar modelos de classes em C# a partir de um banco de dados Oracle. Ele automatiza o processo de geração de modelos de entidades (classes) e um contexto de banco de dados para um projeto .NET Core.


Funcionalidades

Conexão com o Banco de Dados:
O arquivo databaseSchema.js se conecta ao banco de dados Oracle e recupera informações sobre todas as tabelas, colunas e gatilhos (triggers), incluindo os comentários das colunas.


Geração do Esquema JSON:
O arquivo databaseSchema.js gera um arquivo JSON que representa o esquema do banco de dados, contendo todas as informações coletadas.


Criação dos Modelos de Entidades:
O arquivo createModels.js cria modelos de classes (entidades) em C# com base no esquema do banco de dados. Esses modelos representam as tabelas e colunas do banco de dados como classes e propriedades em C#.


Criação do Contexto do Banco de Dados:
O arquivo createContext.js cria um arquivo DatabaseContext.cs que contém o contexto do banco de dados, incluindo todos os DbSets para as classes de entidades criadas.


Configuração

Antes de usar o DBtoCSharp, você precisa configurar a conexão com o banco de dados Oracle. Para fazer isso, abra o arquivo databaseSchema.js e insira as informações de conexão, como usuário, senha e URL do banco de dados.



Execução

Após configurar a conexão com o banco de dados, você pode executar o DBtoCSharp. Basta executar o script run.js, que executará sequencialmente os scripts databaseSchema.js, createModels.js e createContext.js.


node run.js


Resultado

Depois de executar o DBtoCSharp, você terá um arquivo database_schema.json que contém o esquema do banco de dados em formato JSON. Além disso, na pasta modelos, você encontrará os modelos de classes C# representando as tabelas do banco de dados. Por fim, o arquivo DatabaseContext.cs conterá o contexto do banco de dados com os DbSets para todas as classes de entidades.



////////////////////////////////////////////////////////////////

DBtoCSharp



DBtoCSharp is a tool that facilitates the generation of C# class models from an Oracle database. It automates the process of creating entity models and a database context for a .NET Core project.



Features

Database Connection: The databaseSchema.js file connects to the Oracle database and retrieves information about all tables, columns, and triggers, including column comments.



JSON Schema Generation:
The databaseSchema.js file generates a JSON file representing the database schema, containing all the collected information.



Entity Models Creation:
The createModels.js file generates C# class models based on the database schema. These models represent the tables and columns of the database as C# classes and properties.



Database Context Creation:
The createContext.js file creates a DatabaseContext.cs file containing the database context, including all DbSets for the entity classes created.



Configuration

Before using DBtoCSharp, you need to configure the connection to the Oracle database. To do this, open the databaseSchema.js file and enter the connection information, such as user, password, and database URL.



Execution

After configuring the database connection, you can execute DBtoCSharp. Simply run the run.js script, which will sequentially execute the databaseSchema.js, createModels.js, and createContext.js scripts.



node run.js



Result
Once DBtoCSharp is executed, you will have a database_schema.json file containing the database schema in JSON format. Additionally, in the models folder, you will find the C# class models representing the database tables. Finally, the DatabaseContext.cs file will contain the database context with the DbSets for all entity classes.
