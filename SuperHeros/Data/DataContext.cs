using Microsoft.EntityFrameworkCore;
using SuperHeros.Models;

namespace SuperHeros.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
            {
                
            }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=PC_DE_TISMA;Initial Catalog=Hero;Integrated Security=True;Encrypt=False");
        }

        public DbSet<Hero> Heroes { get; set; }

    }
}
