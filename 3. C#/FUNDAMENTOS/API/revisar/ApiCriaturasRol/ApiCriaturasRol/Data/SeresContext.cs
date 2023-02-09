using ApiCriaturasRol.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCriaturasRol.Data
{
    public class SeresContext: DbContext
    {
        public SeresContext(DbContextOptions<SeresContext> options) : base(options) { }
        public DbSet<Planeta> Planeta { get; set; }
        public DbSet<Seres> Seres { get; set; }
    }
}
