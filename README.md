🚗 Concessionária API – .NET 9.0

API completa para gerenciamento de concessionária, com autenticação JWT, controle de perfis (Administrador, Editor e Usuário), persistência em MySQL e documentação via Swagger/OpenAPI.
Desenvolvida utilizando boas práticas de Arquitetura Limpa, POO e testes automatizados com MSTest.

🛠️ Tecnologias Utilizadas
Tecnologia	Descrição
C#	Linguagem principal
.NET 9.0	Plataforma da aplicação
ASP.NET Core	Framework para criação da API
JWT Bearer Authentication	Autenticação e controle de acesso
Entity Framework Core	ORM para persistência
MySQL	Banco de dados
DbContext / EF Migrations	Infraestrutura e versionamento
Swagger / OpenAPI	Documentação e testes das rotas
POO	Organização e modelagem do sistema
MSTest	Testes automatizados
📌 Funcionalidades
🔐 Autenticação

Login via JWT Bearer

Perfis disponíveis:

👑 Administrador

🛠️ Editor

👤 Usuário Comum

🚘 Gerenciamento de Veículos

POST / PUT / DELETE → somente Administrador e Editor

GET → todas as permissões (Admin, Editor e Usuário)

🧪 Testes (MSTest)

Testes unitários das regras de negócio

Testes de integração de rotas (POST, GET, PUT…)

📂 Estrutura do Projeto

Uma visualização estilo "árvore" para ficar bonito no README:

ConcessionariaAPI/
│
├── API/
│   ├── Dominio/
│   │
│   ├── DTO/
│   │   ├── AdministradorDTO.cs
│   │   ├── LoginDTO.cs
│   │   └── VeiculoDTO.cs
│   │
│   ├── Entidade/
│   │   ├── Administrador.cs
│   │   └── Veiculo.cs
│   │
│   ├── Enums/
│   │   └── Perfis.cs
│   │
│   ├── Interfaces/
│   │   ├── IAdministrador.cs
│   │   └── IVeiculo.cs
│   │
│   ├── ModelViews/
│   │   ├── AdministradorModelView.cs
│   │   ├── AdmLogadoModelView.cs
│   │   ├── ErrosDeValidacao.cs
│   │   └── Home.cs
│   │
│   ├── Serviços/
│   │   ├── AdministradorServico.cs
│   │   └── VeiculoServico.cs
│   │
│   ├── Infraestrutura/
│   │   └── DbContexto.cs
│   │
│   ├── Migrations/
│   │   ├── CriarTabelaAdministrador.cs
│   │   └── CriarTabelaVeiculo.cs
│   │
│   ├── Properties/
│   │   └── launchSettings.json
│   │
│   └── Program.cs
│
└── Teste/
    ├── UnitTests/
    │   ├── AdministradorTests.cs
    │   └── VeiculoTests.cs
    │
    └── IntegrationTests/
        ├── ApiIntegrationTests.cs
        └── DatabaseIntegrationTests.cs

🚀 Como Executar o Projeto
1. Clonando o repositório
git clone https://github.com/seu-usuario/concessionaria-api.git

2. Configurar o banco MySQL

Criar banco:

CREATE DATABASE ConcessionariaAPI;


Atualizar o appsettings.json com suas credenciais MySQL.

3. Rodar migrations
dotnet ef database update

4. Iniciar a API
dotnet run

5. Acessar Swagger
http://localhost:5000/swagger

🔑 Exemplo de Login (JWT)
{
  "email": "admin@teste.com",
  "senha": "123456"
}


Retorno:

{
  "token": "eyJhbGciOiJIUzI1NiIs..."
}

📜 Licença

Este projeto é totalmente livre para estudo e aprimoramento.
