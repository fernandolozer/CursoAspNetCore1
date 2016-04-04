namespace MigrationDicas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aluno",
                c => new
                    {
                        AlunoID = c.Int(nullable: false, identity: true),
                        ProfessorID = c.Int(nullable: false),
                        NomeAluno = c.String(),
                        Email = c.String(),
                        Ano = c.Int(nullable: false),
                        Inscricao = c.DateTime(),
                    })
                .PrimaryKey(t => t.AlunoID)
                .ForeignKey("dbo.Professor", t => t.ProfessorID, cascadeDelete: true)
                .Index(t => t.ProfessorID);
            
            CreateTable(
                "dbo.Professor",
                c => new
                    {
                        ProfessorID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Celular = c.String(),
                        Telefone = c.String(),
                        Salario = c.Decimal(precision: 18, scale: 2),
                        TwitterBlog = c.String(),
                        Materia = c.String(),
                    })
                .PrimaryKey(t => t.ProfessorID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Aluno", "ProfessorID", "dbo.Professor");
            DropIndex("dbo.Aluno", new[] { "ProfessorID" });
            DropTable("dbo.Professor");
            DropTable("dbo.Aluno");
        }
    }
}
