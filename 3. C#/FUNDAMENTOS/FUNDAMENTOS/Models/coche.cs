using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNDAMENTOS.Models
{
    //UN COCHE PODRA GIRAR, ASI QUE NOS CREAMOS UNA 
    //ENUMERACION PARA LA DIRECCION DEL COCHE
    public enum Brujula { Norte, Sur, Este, Oeste }

    public class Coche
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int VelocidadActual { get; set; }
        public Brujula DireccionCoche { get; set; }
        //LA VELOCIDAD MAXIMA SERA UNICA PARA CADA COCHE,
        //POR LO QUE NO VA A SER UNA PROPIEDAD QUE EL CONDUCTOR (Program)
        //PUEDA CAMBIAR
        private int VelocidadMaxima;
        //VAMOS A CREAR UNA VARIABLE QUE NOS INDICARA SI 
        //EL COCHE ESTA ARRANCADO/DETENIDO
        private bool EstadoArranque;

        //VAMOS A CREAR DOS CONSTRUCTORES
        //UN CONSTRUCTOR DE UN COCHE CON LA VELOCIDAD MAXIMA
        //PREDEFINIDA
        public Coche()
        {
            this.DireccionCoche = Brujula.Norte;
            this.EstadoArranque = false;
            this.VelocidadActual = 0;
            this.VelocidadMaxima = 180;
        }

        //CREAMOS UN CONSTRUCTOR PARA QUE NOS INDIQUEN LA 
        //VELOCIDAD MAXIMA DE UN COCHE
        public Coche(int velMax)
        {
            this.DireccionCoche = Brujula.Norte;
            this.EstadoArranque = false;
            this.VelocidadActual = 0;
            this.VelocidadMaxima = velMax;
        }

        //EN EL METODO ToString() VAMOS A DEVOLVER UN STRING
        //CON CARACTERISTICAS DEL COCHE
        public override string ToString()
        {
            return this.Marca + " " + this.Modelo + ", Velocidad: "
                + this.VelocidadActual + ", Dirección: "
                + this.DireccionCoche;
        }

        //METODOS DE ACCION void
        public void Arrancar()
        {
            this.EstadoArranque = true;
            Console.WriteLine("Coche arrancado");
        }

        public void Acelerar()
        {
            if (this.EstadoArranque == false)
            {
                throw new Exception("No podemos acelerar sin arrancar el coche");
            }
            else
            {
                this.VelocidadActual += 20;
                //COMPROBAMOS LA VELOCIDAD DEL COCHE
                if (this.VelocidadActual > this.VelocidadMaxima)
                {
                    this.VelocidadActual = this.VelocidadMaxima;
                }
            }
        }

        public void Acelerar(int aceleracion)
        {
            if (this.EstadoArranque == false)
            {
                throw new Exception("El coche no acelera si no lo arrancas");
            }
            else
            {
                this.VelocidadActual += aceleracion;
                if (this.VelocidadActual > this.VelocidadMaxima)
                {
                    this.VelocidadActual = this.VelocidadMaxima;
                }
            }
        }

        public void Frenar()
        {
            this.VelocidadActual -= 10;
            if (this.VelocidadActual < 0)
            {
                this.VelocidadActual = 0;
            }
        }

        public void Girar()
        {
            if (this.DireccionCoche == Brujula.Norte)
            {
                this.DireccionCoche = Brujula.Sur;
            }
            else if (this.DireccionCoche == Brujula.Sur)
            {
                this.DireccionCoche = Brujula.Este;
            }
            else if (this.DireccionCoche == Brujula.Este)
            {
                this.DireccionCoche = Brujula.Oeste;
            }
            else
            {
                this.DireccionCoche = Brujula.Norte;
            }
        }

        public void Girar(Brujula direccion)
        {
            this.DireccionCoche = direccion;
        }
    }
}
