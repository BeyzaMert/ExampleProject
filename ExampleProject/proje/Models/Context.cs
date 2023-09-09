using Microsoft.EntityFrameworkCore;

namespace proje.Models
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-T41TQPB; database=kisimesaj; integrated security=true;");
        }
        public DbSet<Kisi> kisiler { get; set; }
    }
}
