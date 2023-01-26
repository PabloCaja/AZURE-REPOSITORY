using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RolPrueba1.Models
{
    [Table("FICHAPJ")]
    public class Fichapj
    {
        [Key]
        [Column("JUGADOR")]
        public string Jugador { get; set; }
        [Column("PERSONAJE")]
        public string Personaje { get; set; }
        [Column("OBJETOS")]
        public string Objetos { get; set; }
        [Column("UNIDADES")]
        public string Unidades { get; set; }
        [Column("NOTAS")]
        public string Notas { get; set; }
        [Column("CLASE")]
        public string Clase { get; set; }
    }
}
