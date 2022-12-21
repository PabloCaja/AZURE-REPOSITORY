using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNDAMENTOS.Models
{
    public class Empleado: Persona
    {
        public override String GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellido + " " + this.SalarioMinimo;
        }
        
        protected int SalarioMinimo { get; set;}

        //EL EMPLEADO TENDRA UN SALARIO MINIMO DE 900
        public Empleado() 
        {
            this.SalarioMinimo = 900;
        }
        //
        public void MostrarSalarioMinimo()
        {
            Console.WriteLine("Salario minimo: "+ this.SalarioMinimo);  
        }
    }
}
