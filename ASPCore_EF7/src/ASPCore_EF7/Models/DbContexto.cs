using Microsoft.Data.Entity;

namespace ASPCore_EF7.Models
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

        public DbSet<Produto> Produto { get; set; }
    }
}
