using Microsoft.EntityFrameworkCore;
using RolPrueba1.Models;

namespace RolPrueba1.Data
{
    public class FichapjContext : DbContext
    {
        //NECESITAMOS UN CONSTRUCTOR OBLIGATORIO PARA 
        //PODER RECIBIR LA CADENA DE CONEXION DESDE PROGRAM
        public FichapjContext(DbContextOptions<FichapjContext> options) : base(options) { }

        //DEBEMOS MAPEAR CADA CLASE MODEL DE LA BASE DE DATOS CON UN OBJETO
        //DbSet.  CADA TABLA DE LA BASE DE DATOS SERA UN DbSet CON UN MODEL.
        //NOSOTROS HAREMOS LAS CONSULTAS A DICHO DbSet
        public DbSet<Fichapj> Fichapj { get; set; }

    }
}
