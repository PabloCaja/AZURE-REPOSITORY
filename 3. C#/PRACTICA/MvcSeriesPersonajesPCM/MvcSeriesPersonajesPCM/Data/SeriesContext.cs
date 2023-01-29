using Microsoft.EntityFrameworkCore;
using MvcSeriesPersonajesPCM.Models;

namespace MvcSeriesPersonajesPCM.Data
{
    public class SeriesContext : DbContext
    {
        public SeriesContext
            (DbContextOptions<SeriesContext> options) : base(options) { }

        public DbSet<Series> Series { get; set; }
        public DbSet<Personajes> Personajes { get; set; }

    }
}
