using Microsoft.EntityFrameworkCore;
using RolPrueba1.Models;

namespace RolPrueba1.Data
{
    public class SeresContext : DbContext
    {
        public SeresContext
            (DbContextOptions<SeresContext> options) : base(options) { }

        public DbSet<Seres> Seres { get; set; }
  

    }
}
