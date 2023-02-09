using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCriaturasRol.Models
{
    [Table("Seres")]
    public class Seres
    {
        [Key]
        [Column("Nombre")]
        public string Nombre { get; set; }
        [Column("Imagen")]
        public string Imagen { get; set; }
        [Column("Especie")]
        public string Especie { get; set; }
        [Column("Planeta")]
        public string Planeta { get; set; }
        [Column("Agresividad")]
        public string Agresividad { get; set; }
        [Column("Habilidades")]
        public string Habilidades { get; set; }
        [Column("Debilidad")]
        public string Debilidad { get; set; }
        [Column("Bioma")]
        public string Bioma { get; set; }
        [Column("IdPlaneta")]
        public int IdPlaneta { get; set; }
    }
}
