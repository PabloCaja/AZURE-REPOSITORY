using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNDAMENTOS.Models
{
    public class Persona
    {
        public enum Paises { España, Alemania, Francia, Argentina }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        //EN LAS PROPIEDADES EXTENDIDAS, QUE SON AQUELLAS 
        //EN LAS QUE DESEAMOS CONTROLAR ALGO
        //SE UTILIZAN CAMPOS PRIVADOS
        private int _Edad;

        public int Edad
        {
            get
            {
                //SE DEVUELVE EL CAMPO PRIVADO
                return _Edad;
            }
            set
            {
                //CAMBIAMOS EL CAMPO PRIVADO
                //COMPROBAMOS EL VALOR QUE VIENE
                if (value < 0)
                {
                    //LANZAMOS UNA EXCEPCION
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    _Edad = value;
                }
            }
        }

    }
}
