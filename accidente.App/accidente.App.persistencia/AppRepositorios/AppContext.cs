using Microsoft.EntityFrameworkCore;
using accidente.App.dominio;

namespace accidente.App.persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<agentedetransito> agentedetransito {get;set;}
        public DbSet<accidentados> accidentados {get;set;}
        public DbSet<ciudadano> ciudadano {get;set;}
        public DbSet<vehiculo> vehiculo {get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder
            .UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = accidenteData");
        }
    }
    }
}