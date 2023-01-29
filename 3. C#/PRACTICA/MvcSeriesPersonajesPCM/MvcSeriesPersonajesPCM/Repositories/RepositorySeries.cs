using MvcSeriesPersonajesPCM.Data;
using MvcSeriesPersonajesPCM.Models;

namespace MvcSeriesPersonajesPCM.Repositories
{
    public class RepositorySeries
    {
        private SeriesContext context;

        public RepositorySeries(SeriesContext context)
        {
            this.context = context;
        }

        // devuelve todas las series

        public List<Series> GetSeries()
        {
            var consulta = from datos in this.context.Series
                           select datos;
            return consulta.ToList();
        }

        // busca una serie por su id

        public Series GetOneSerie(int id)
        {
            var consulta = from datos in this.context.Series
                           where datos.IdSerie == id
                           select datos;
            return consulta.FirstOrDefault();
        }

        // inserta una serie
        public void AddSerie(Series serie)
        {

            this.context.Series.Add(serie);
            this.context.SaveChanges();
        }

        // Muestra los personajes de una serie
        public List<Personajes> MostrarPersonajes(int id)
        {
            var consulta = from datos in this.context.Personajes
                           where datos.IdSerie == id
                           select datos;
            return consulta.ToList();
        }
    }
}
