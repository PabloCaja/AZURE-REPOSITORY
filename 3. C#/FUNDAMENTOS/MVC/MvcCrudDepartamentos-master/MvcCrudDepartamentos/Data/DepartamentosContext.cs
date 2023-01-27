using Microsoft.EntityFrameworkCore;
using MvcCrudDepartamentos.Models;

namespace MvcCrudDepartamentos.Data
{
    public class DepartamentosContext: DbContext
    {
        public DepartamentosContext
            (DbContextOptions<DepartamentosContext> options): base(options) { }
        public DbSet<Departamento> Departamentos { get; set; }
    }
}
