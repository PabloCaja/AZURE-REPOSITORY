using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCriaturasRol.Models
{
    [Table("Planetas")]
    public class Planeta
    {
        [Key]
        [Column("IdPlaneta")]
        public int IdPlaneta { get; set; }
        [Column("Nombre")]
        public string Nombre { get; set; }
        [Column("Imagen")]
        public string Imagen { get; set; }
        [Column("Anyo")]
        public int Anyo { get; set; }
    }
}
