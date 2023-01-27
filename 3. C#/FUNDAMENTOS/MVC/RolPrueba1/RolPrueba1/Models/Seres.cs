using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RolPrueba1.Models
{
    public class Seres
    {
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Planeta { get; set; }
        public string Agresividad { get; set; }
        public string Habilidades { get; set; }
        public string Debilidad { get; set; }
        public string Bioma { get; set; }
    }
}
