using Microsoft.Data.Entity;
using ASPCore_EF7_Entidades.Models;

namespace ASPCore_EF7_Entidades.Models
{
    public class DbContexto : DbContext
    {
        private static bool _created = false;

        public DbContexto()
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureCreated();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }

        public DbSet<Professor> Professor { get; set; }

        public DbSet<Aluno> Aluno { get; set; }
    }
}
