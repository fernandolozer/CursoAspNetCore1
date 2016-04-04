# Migrations #

## usando o NugetPackageManager

1 - Abrir o package Manager

2 - Executar Enable-Migrations + nome do contexto. Caso não seja informado o nome do contexto a ser utilizado.
Dica- Executar apenas o Enable-Migrations, que será exibida uma mensagem de erro e irá sugerir o nome do contexto.

![PAckage Manager](img/mig1.png)

Apos execução, é criada uma pasta com todas as Migrations.

![PAckage Manager](img/mig2.png)

3 - Faz alteração na classe

![PAckage Manager](img/mig3.png)

4 - Adicionar nova Migrations: `Add-Migration NomeQueEuquerodar`

![PAckage Manager](img/mig4.png)

5 - Update-Database

![PAckage Manager](img/mig5.png)

5 - caso altere algo nas classes em nível de estrutura
das tabelas no banco, use:
Add-Migration label (AtribuiCamposObrigatorios)

![PAckage Manager](img/mig6.png)


6 - `Update-Database` usando a opcao `-verbose` é exibido o script que foi executado no migrations.

![PAckage Manager](img/img7.png)

7 - `Update-Database` usando a opcao `-script` é exibido o script em uma nova janela, mas não é executado no banco.

![PAckage Manager](img/mig8.png)

### outras dicas ###


* o Comando `Update-Database -target nomeConfiguracao(label)` volta o banco ao label informado.

* `Update-Database -target <nome da migracao> -force` força a instalação de um pacote específico.




Outros Comandos do Nuget

    Update-Package pacote
    Install-Package pacote -version x
    Uninstall-Package pacote

Para novas entidades

    //criar a classe ex:provas  e referencia-la no DbContext
    DbSet<classe>
    Add-Migration addProvas
    Update-Database
