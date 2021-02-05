# Projeto Vendas
## Projeto de uma aplicação CRUD em Visual Basic .NET

Projeto de um software voltado para vendas de produtos integrado com um banco de dados.   
Funcionalidades:
* Cadastros de funcionários, clientes, usuários e produtos;
* acesso à dados do banco de dados;
* Procedures e triggers no banco de dados para atualizar o estoque e atualizar comissões; 
* Gerar relatórios;
* Criptografia de senhas.

O software foi desenvolvido utilizando a plataforma .NET com Windows Forms, utilizando as liguagens de programação Visual Basic .NET e Microsoft SQL Server.
IDEs:
* Visual Studio;
* Microsoft SQL Server e SQL Server Management Studio (SSMS).

### Para rodar:

Primeiro é necessario ter o sql server instalado na máquina, e ter o Management para facilitar o uso do banco de dados.
Depois criar e adicionar as tabelas, triggers e procedures, uma de cada vez. Pode ser feita através do script do banco de dados no Management.
Depois inserir os dados do Usuário Master do sistema. *Login: Master; Senha: Master*.
Para rodar de fato, é necessário abrir o executável e configurar as credenciais do banco de dados e entrar como Master e criar grupos (para controle de acesso) e, posteriormente, os usuários.
