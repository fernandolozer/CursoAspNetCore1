# Anotações #


Dentro da pasta src de um projeto, onde tem o arquivo project.json, executar:

1 - Instalar o dnvm -- dot net version Manager

2 - dnvm upgrade --  para instalar as atualizações, dnu e dnx

3 - dnu restore -- para restaurar todos os pacotes de um projeto.

dnx <nome da tast> --  para rodar a task configurada. os comandos ficam no arquivo project.json como segue: 

    "commands": {
      "web": "Microsoft.AspNet.Server.Kestrel",
      "ef": "EntityFramework.Commands"
    },

# Programação do Curso #

## Objetivos ##

O objetivo deste curso é mostrar o que é o ASP.NET Core 1 e o .NET Core 1, tudo o que você precisa saber para criar projetos WEB para rodarem em qualquer plataforma (Windows, Mac Ox e Linux), onde veremos desde a estrutura até a criação do projeto na linguagem C#.

## Programação ##

|Sábado 02 de Abril - 08:00 às 17:00 |	Domingo 03 de Abril - 08:00 às 17:00|
|-----------------------------------|-------------------------------------|
|Introdução ao ASP.NET Core 1, .NET Core 1 e arquitetura MVC, o que é Open-Source?	|Entendimento de Controller, View e heranças (Web API)|
|Cross-plataform, configurar o ASP.NET core 1 para executar no Mac Ox, Linux e Windows |	Sintaxes básicas do Razor, uso das novas TagHelpers para gerar HTML 5|
|Uso do DNVM (.NET Version Manager), DNX (.NET Execution Environment) e DNU (.NET Development Utility) |	Uso de Code First e Entity Framework Core 1|
|Estrutura de um projeto ASP.NET Core 1, Frameworks usados, entendimento dos arquivos de configurações	| Criar um Controller e o contexto do banco de dados|
|Como usar injeção de dependência para frameworks e namespaces?	| Como criar e usar View Component e View Partial|
|Como gerenciar pacotes com o NPM, uso do bower, grunt e gulp? |	Deploy da aplicação nos servidores|
