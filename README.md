Minimal API Project
Este projeto é uma Minimal API desenvolvida em .NET, com suporte para Swagger UI, Entity Framework Core, e integração com banco de dados (MYSQL && SQLSERVER) via Migrations. Ele inclui funcionalidades para gerenciamento de Perfis Administradores e Editor, CRUD de veículos.

📌 Funcionalidades

Administradores

Endpoints para criação, atualização, listagem de todos e por ID, validação de login.

Melhoria sendo projetada: implementação de segurança de keys e senhas via JWT.


Veículos

Implementação completa da feature de veículos:

Entidade
Serviço
Interface
ModelView
DbSet
Migrations



Swagger UI
Documentação interativa para testar os endpoints.
Indico instalar uma extensão de seu browser para visualização da documentação que está sendo criada, além da interface do Swagger.

🛠️ Tecnologias Utilizadas

.NET 9.0 Minimal API
Entity Framework Core
SQL Server / MySQL (dependendo da configuração)
Swagger UI
Migrations para controle do banco de dados


📂 Estrutura do Projeto
├── Dominio/                # Lógica de negócio, entidades, interfaces, modelviews e servicos
├── Infraestrutura/         # DbContext
├── Migrations/             # Controle de versão do banco de dados
├── Properties/             # Configurações do projeto
├── Program.cs              # Configuração principal da API
├── appsettings.json        # Configurações gerais
├── appsettings.Development.json # Configurações para ambiente de desenvolvimento
├── minimal-api.csproj      # Arquivo do projeto
└── minimal-api.sln         # Solução do projeto


✅ Melhorias Recentes

Ajustes nos GETs de administradores para otimização.
Adição da feature de veículos com migrations.
Documentação via Swagger UI.

📌 Próximos Passos

Implementar autenticação e autorização.
Criar testes unitários para os serviços.
Adicionar logs e monitoramento.
