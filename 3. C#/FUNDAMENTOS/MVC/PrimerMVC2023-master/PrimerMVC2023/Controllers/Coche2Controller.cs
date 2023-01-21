using Microsoft.AspNetCore.Mvc;
using PrimerMVC2023.Models;

namespace PrimerMVC2023.Controllers
{
    public class Coche2Controller : Controller
    {
        //DECLARAMOS UNA VARIABLE COCHE PARA UTILIZARLA 
        //EN TODA LA CLASE
        private Coche car;

        //RECIBIMOS EL OBJETO EN CADA UNA DE LAS CLASES
        //DENTRO DEL CONSTRUCTOR
        public Coche2Controller(Coche car)
        {
            this.car = car;
        }

        //EN LA VISTA INDEX DIBUJAREMOS EL COCHE
        //Y PODREMOS ACELERAR O FRENAR MEDIANTE BOTONES
        //DE UN FORMULARIO
        public IActionResult Index()
        {
            return View(this.car);
        }

        //AQUI RECIBIREMOS LA ACCION DE FRENAR O ACELERAR
        [HttpPost]
        public IActionResult Index(string accion)
        {
            if (accion == "acelerar")
            {
                this.car.Acelerar();
            }
            else
            {
                this.car.Frenar();
            }
            return View(this.car);
        }
    }
}