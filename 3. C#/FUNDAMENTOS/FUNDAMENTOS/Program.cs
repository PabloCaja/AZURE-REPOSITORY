using FUNDAMENTOS.Models;
using System;
using System.Collections.Generic;

namespace FUNDAMENTOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Maria";
            persona.Apellido = "Mama";
            persona.Edad = 28;
            Console.WriteLine("Persona: " + persona.Nombre + ", Edad:" + persona.Edad);

        }
        static void ValidarIsbn()
        {

 
        }
    }
}
