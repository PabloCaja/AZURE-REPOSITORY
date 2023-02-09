using ApiCriaturasRol.Data;
using ApiCriaturasRol.Models;

namespace ApiCriaturasRol.Repositories
{
    public class RepositorySeres
    {
        private SeresContext context;

        public RepositorySeres(SeresContext context)
        {
            this.context = context;
        }

        #region TABLA PLANETAS

        public List<Planeta> GetPlaneta()
        {
            var consulta = from datos in this.context.Planeta
                           select datos;
            return consulta.ToList();
        }

        public Planeta FindPlaneta(int idplaneta)
        {
            var consulta = from datos in this.context.Planeta
                           where datos.IdPlaneta == idplaneta
                           select datos;
            return consulta.FirstOrDefault();
        }

        #endregion

        #region TABLA SERES

        //SERES POR PLANETA
        public List<Seres> GetPersonajesSerie(int idplaneta)
        {
            var consulta = from datos in this.context.Seres
                           where datos.IdPlaneta == idplaneta
                           select datos;
            return consulta.ToList();
        }

        public List<Seres> GetPersonajes()
        {
            var consulta = from datos in this.context.Personajes
                           select datos;
            return consulta.ToList();
        }

        public Seres FindPersonaje(int idpersonaje)
        {
            var consulta = from datos in this.context.Personajes
                           where datos.IdPersonaje == idpersonaje
                           select datos;
            return consulta.FirstOrDefault();
        }

        //METODO PARA CAMBIAR UN PERSONAJE DE SERIE
        public async Task UpdatePersonajeSerie(int id, int idplaneta)
        {
            Personaje personaje = this.FindPersonaje(id);
            personaje.Idplaneta = idplaneta;
            await this.context.SaveChangesAsync();
        }

        //METODO PARA INSERTAR PERSONAJE
        public async Task InsertPersonaje (Seres ser)
            
        {
            this.context.Seres.Add(Ser);
            await this.context.SaveChangesAsync();
        }

        #endregion


    }
}
