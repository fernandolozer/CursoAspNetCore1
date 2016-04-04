using System.Data.Entity;
// usado para fazer override para fazer o onmodelCreating
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MigrationDicas.Models
{
    public class BancoContexto : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        /// <summary>
        /// Nome da string de conexao está no web.config.
        /// </summary>
        public BancoContexto() : base("name=ConnDB")
        {
        }

        public DbSet<Professor> Professores { get; set; }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Provas> Provas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder); 
            // importante para não gerar as tabelas com pluralização.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
