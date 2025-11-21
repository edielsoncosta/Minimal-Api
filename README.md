# 🚗 Concessionária API -- .NET 9

API completa para gerenciamento de veículos de uma concessionária, com
autenticação JWT, controle de perfis, persistência em MySQL e
documentação via Swagger/OpenAPI.

## 🛠️ Tecnologias Utilizadas

-   C#
-   .NET 9.0
-   ASP.NET Core
-   Entity Framework Core
-   MySQL
-   JWT Bearer Authentication
-   Swagger / OpenAPI
-   Programação Orientada a Objetos
-   MSTest

## 📌 Funcionalidades Principais

### 🔐 Autenticação & Perfis

-   Login com JWT
-   Perfis:
    -   Administrador\
    -   Editor\
    -   Usuário

### 🚘 Gerenciamento de Veículos

  Operação   Administrador   Editor   Usuário
  ---------- --------------- -------- ---------
  GET        ✔               ✔        ✔
  POST       ✔               ✔        ❌
  PUT        ✔               ✔        ❌
  DELETE     ✔               ✔        ❌

## 📂 Estrutura do Projeto

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

## 🚀 Como Executar

1.  `git clone`
2.  Criar DB MySQL
3.  Ajustar appsettings.json
4.  `dotnet ef database update`
5.  `dotnet run`
6.  Acessar `/swagger`

## 🔑 Exemplo de Login

``` json
{
  "email": "admin@teste.com",
  "senha": "123456"
}
```

## 📜 Licença

Projeto livre para estudo.
