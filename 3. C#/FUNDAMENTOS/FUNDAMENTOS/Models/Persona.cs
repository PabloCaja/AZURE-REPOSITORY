using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNDAMENTOS.Models
{
    public enum Paises { España, Alemania, Francia, Argentina }
    public class Persona
    {
        public Paises Nacionalidad { get; set; }
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
                return this._Edad;
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
                    this._Edad = value;
                }

            }
        }
        private string[] _Descripciones = new string[3];
        //public string[] this[]

        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido + ", Edad: " + this.Edad;
        }

        public virtual string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellido;
        }
        //POLIMORFISMO
        public string GetNombreCompleto(bool orden)
        {
            if(orden == true)
            {
                return this.Apellido + " " + this.Nombre;    
            }
            else
            {
                return this.Nombre + " " + this.Apellido;
            }
        }
        public void GetNombreCompleto(int num1, int num2) { }
        public void GetNombreCompleto(int num1, int num2, int num3) { }

        public Persona()
        {
            this.Nacionalidad = Paises.Alemania;
        }

        public Persona(String nombre, string apellidos)
        {
            this.Nombre = nombre;
            this.Apellido = apellidos;
        }

    }
}
