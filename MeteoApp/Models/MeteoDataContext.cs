using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace MeteoApp.Model
{
    public class MeteoDataContext : DbContext
    {
        public DbSet<MeteoData> MeteoDatas { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Meteo.db");
        }
    }
}


