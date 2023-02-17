using MvcCoreChollometro.Data;
using MvcCoreChollometro.Models;

namespace MvcCoreChollometro.Repositories
{
    public class RepositoryChollometro
    {
        private ChollometroContext context;

        public RepositoryChollometro(ChollometroContext context)
        {
            this.context = context;
        }

        public List<Chollo> GetChollos()
        {
            var consulta = from datos in this.context.Chollos
                           orderby datos.Fecha descending
                           select datos;
            return consulta.ToList();
        }
    }
}
