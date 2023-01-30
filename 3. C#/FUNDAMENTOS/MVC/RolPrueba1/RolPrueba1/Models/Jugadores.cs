using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RolPrueba1.Models
{
    [Table("JUGADORES")]
    public class Jugadores
    {
        [Key]
        [Column("JUGADOR")]
        public string Jugador { get; set; }

    }
}
