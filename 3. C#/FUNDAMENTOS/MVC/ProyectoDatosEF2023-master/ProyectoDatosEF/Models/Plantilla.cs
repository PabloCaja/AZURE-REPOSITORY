using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoDatosEF.Models
{
    [Table("PLANTILLA")]
    public class Plantilla
    {
        [Key]
        [Column("EMPLEADO_NO")]
        public string IdPlantilla { get; set; }
        [Column("APELLIDO")]
        public string Apellido { get; set; }
        [Column("FUNCION")]
        public string Funcion { get; set; }
        [Column("T")]
        public string Turno { get; set; }
        [Column("SALARIO")]
        public string Salario { get; set; }
        [Column("SALA_COD")]
        public string IdSala { get; set; }
        [Column("HOSPITAL_COD")]
        public string IdHospital { get; set; }
    }
}
