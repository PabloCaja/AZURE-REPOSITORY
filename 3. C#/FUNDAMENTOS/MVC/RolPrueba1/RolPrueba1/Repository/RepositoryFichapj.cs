using RolPrueba1.Data;
using RolPrueba1.Models;


namespace RolPrueba1.Repository
{
    public class RepositoryFichapj
    {
        private FichapjContext context;

        public RepositoryFichapj(FichapjContext context)
        {
            this.context = context;
        }

        public List<Fichapj> GetFichapj()
        {
            var consulta = from datos in this.context.Fichapj
                           select datos;
            return consulta.ToList();
        }

        public List<Fichapj> GetPlantillaHospital(string jugador1)
        {
            var consulta = from datos in this.context.Fichapj
                           where datos.Jugador == jugador1
                           select datos;
            return consulta.ToList();
        }

        public Fichapj FindFichapj(string jugador2)
        {
            var consulta = from datos in this.context.Fichapj
                           where datos.Jugador == jugador2
                           select datos;
            return consulta.FirstOrDefault();
        }

        public List<Fichapj> GetJugadorClase(string clase)
        {
            var consulta = from datos in this.context.Fichapj
                           where datos.Clase == clase
                           select datos;
            return consulta.ToList();
        }

        public List<string> GetClases()
        {
            var consulta = (from datos in this.context.Fichapj
                            select datos.Clase).Distinct();
            return consulta.ToList();
        }
    }
}
