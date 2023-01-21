using Microsoft.AspNetCore.Mvc;
using PrimerMVC2023.Models;

namespace PrimerMVC2023.Controllers
{
    public class Coche1Controller : Controller
    {
        //DECLARAMOS UNA VARIABLE COCHE PARA UTILIZARLA 
        //EN TODA LA CLASE
        private Coche car;

        //INYECTAMOS EL COCHE EN EL CONSTRUCTOR
        public Coche1Controller(Coche car)
        {
            //IGUALAMOS LA VARIABLE DE LA CLASE
            //CON LA QUE RECIBIMOS
            this.car = car;
        }

        //EN LA VISTA INDEX DIBUJAREMOS EL COCHE
        //Y PODREMOS ACELERAR O FRENAR MEDIANTE BOTONES
        //DE UN FORMULARIO

        int numero = 1;

        public IActionResult Index()
        {
           
            return View(this.car);
        }

        //AQUI RECIBIREMOS LA ACCION DE FRENAR O ACELERAR
        [HttpPost]
        public IActionResult Index(string accion)
        {
            this.numero += 1;
            ViewData["NUMERO"] = numero;
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
