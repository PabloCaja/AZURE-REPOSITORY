using RolPrueba1.Data;
using RolPrueba1.Models;

namespace RolPrueba1.Repository
{
    public class RepositorySeres
    {

        private SeresContext context;

        public RepositorySeres(SeresContext context)
        {
            this.context = context;
        }

        // Metodo para devolver todos los seres

        public List<Seres> GetSeres()
        {
            var consulta = from datos in this.context.Seres
                           select datos;
            return consulta.ToList();
        }

        // busca una serie por su id

        public Seres GetOneSer(string id)
        {
            var consulta = from datos in this.context.Seres
                           where datos.Nombre == id
                           select datos;
            return consulta.FirstOrDefault();
        }
        // inserta un ser
        public void AddSer(Seres ser)
        {
            this.context.Seres.Add(ser);
            this.context.SaveChanges();
        }
        //Busca un ser por su nombre
        public Seres FindSer(string id)
        {
            var consulta = from datos in this.context.Seres
                           where datos.Nombre == id
                           select datos;
            return consulta.FirstOrDefault();
        }

        //Metodo para actualizar una criatura

        public void UpdateSer(string nombre, string especie, string planeta, 
            string agresividad, string habilidades, string debilidad, string bioma)
        {
            Seres seres = this.FindSer(nombre);
            seres.Nombre = nombre;
            seres.Especie = especie;
            seres.Planeta = planeta;
            seres.Agresividad = agresividad;
            seres.Habilidades = habilidades;
            seres.Debilidad = debilidad;
            seres.Bioma = bioma;
            
            this.context.SaveChanges();
        }

        //Metodo para eliminar una criatura

        public void DeleteSeres(string id)
        {
            Seres seres = this.FindSer(id);
            this.context.Seres.Remove(seres);
            this.context.SaveChanges();
        }
    }
}
