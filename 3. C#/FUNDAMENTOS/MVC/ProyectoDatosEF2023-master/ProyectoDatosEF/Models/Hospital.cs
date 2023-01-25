using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoDatosEF.Models
{
    //DEBEMOS INDICAR QUE TABLA ESTA ASOCIADA
    //A ESTE MODELO
    [Table("HOSPITAL")]
    public class Hospital
    {
        //SI VAMOS A REALIZAR CONSULTAS DE ACCION
        //COMO NORMA, DEBERIAMOS TENER UN CAMPO COMO CLAVE (PK)
        [Key]
        [Column("HOSPITAL_COD")]
        public string IdHospital { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("DIRECCION")]
        public string Direccion { get; set; }
        [Column("TELEFONO")]
        public string Telefono { get; set; }
        [Column("NUM_CAMA")]
        public string Camas { get; set; }
    }
}
