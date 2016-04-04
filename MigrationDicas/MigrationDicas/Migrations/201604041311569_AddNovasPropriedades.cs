namespace MigrationDicas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNovasPropriedades : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Professor", "Disponivel", c => c.Boolean(nullable: false));
            AddColumn("dbo.Professor", "Admissao", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Professor", "Admissao");
            DropColumn("dbo.Professor", "Disponivel");
        }
    }
}
