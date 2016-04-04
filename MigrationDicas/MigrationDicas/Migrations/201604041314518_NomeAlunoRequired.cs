namespace MigrationDicas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NomeAlunoRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Aluno", "NomeAluno", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Aluno", "NomeAluno", c => c.String());
        }
    }
}
