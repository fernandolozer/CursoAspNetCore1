namespace MigrationDicas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AtributosNomeProfessor : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Professor", "Nome", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Professor", "Nome", c => c.String());
        }
    }
}
