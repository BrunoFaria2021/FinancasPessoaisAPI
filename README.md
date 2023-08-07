<h1 align="center">:moneybag: Finanças Pessoais API :money_with_wings:</h1>
:memo: Descrição
Este projeto foi desenvolvido como parte de um desafio para criar uma Web API de Finanças Pessoais. O objetivo da API é fornecer recursos para gerenciar despesas e receitas pessoais. O projeto foi elaborado usando a plataforma .NET 7.0 e seguindo o padrão de arquitetura DDD (Domain-Driven Design).

:books: Funcionalidades
📊 Tabelas do Banco

✔️ DESPESA (Id, Descrição, Valor, Data)

✔️ RECEITA (Id, Descrição, Valor, Data)

🛠️ CRUD Métodos API:

✔️ DESPESA: (Cadastro, Atualização, Listagem de todas as Despesas e Exclusão);

✔️ RECEITA: (Cadastro, Atualização, Listagem de todas as Receitas e Exclusão);

💼 Regra de Negócios

Este projeto ainda está em desenvolvimento, mas algumas regras de negócio já foram implementadas:

✔️ 1- Uma Despesa não pode ser cadastrada sem uma descrição, valor e data válida.

✔️ 2- Uma Receita não pode ser cadastrada sem uma descrição, valor e data válida.

✔️ 3- A API deve calcular o saldo atual, que é a soma de todas as Receitas menos a soma de todas as Despesas.

✔️ 4- A API deve fornecer relatórios de Despesas e Receitas, permitindo filtrar por período e categoria (se aplicável).

✔️ 5- A API deve garantir que não ocorram duplicações de Despesas ou Receitas com o mesmo Id.

✔️ :wrench: Tecnologias / Metodologias Utilizadas
CSharp <img align="center" alt="Rafa-Csharp" height="30" width="40" src="https://github.com/BrunoFaria2021/FinancasPessoaisAPI.git">

AspNetCore

SQL Server

AutoMapper

DDD

EF Core

Repository Patterns

Injeção de Dependências

Microsoft.EntityFrameworkCore

Swashbuckle.AspNetCore.Swagger

:rocket: Rodando o Projeto
Para executar o projeto, siga as instruções abaixo:

Clone o repositório:

bash
Copy code
git clone https://github.com/SeuPerfilAqui/FinancasPessoaisAPI.git
Restaure as dependências:

Copy code
dotnet restore
Execute a aplicação:

arduino
Copy code
dotnet run
O projeto estará disponível em http://localhost:5000.

:soon: Implementação Futura
O projeto ainda está em desenvolvimento e existem algumas funcionalidades que serão adicionadas no futuro:

✔️ Autenticação e Autorização: Para proteger os recursos da API e permitir apenas que usuários autorizados acessem as informações financeiras.

✔️ Relatórios Melhorados: A API fornecerá relatórios detalhados de gastos por categoria, gráficos de despesas e receitas ao longo do tempo.

✔️ Tratamento de Erros: Adicionar um tratamento robusto de erros para fornecer respostas claras e informativas em caso de exceções.

:handshake: Colaboradores
https://github.com/SeuPerfilAqui

:dart: Status do Projeto
<p align="LEFT">
<img src="http://img.shields.io/static/v1?label=STATUS&message=EM%20DESENVOLVIMENTO&color=ORANGE&style=for-the-badge"/>
</p>