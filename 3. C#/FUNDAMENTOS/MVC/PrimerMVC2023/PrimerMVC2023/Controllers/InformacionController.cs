using Microsoft.AspNetCore.Mvc;
using PrimerMVC2023.Models;

namespace PrimerMVC2023.Controllers
{
    public class InformacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ControllerView()
        {
            //ENVIAMOS INFORMACION SIMPLE
            ViewBag.Nombre = "Alumno";
            ViewData["Descripcion"]= "Estoy aprendiendo Net Core";
            ViewData["YEAR"] = "2023";
            return View();
        }
        public IActionResult ControllerViewModel()
        {
            //CREAMOS UN OBJETO PERSONA PARA ENVIARLO
            Persona persona = new Persona();
            persona.Nombre = "Alumno Net Core";
            persona.Edad = 24;
            persona.Email = "alumnonetcore@gmail.com";
            return View(persona);
        }
        public IActionResult ControllerViewModelList()
        {
            List<Persona> personas = new List<Persona>();
            for (int i= 1; i <= 10; i++)
            {
                Persona persona = new Persona();
                persona.Nombre = "Persona " + i;
                persona.Edad = i + 20;
                persona.Email = "persona" + i + "@gmail.com";
                personas.Add(persona);
                persona.Imagen = "https://juegosdeconstruccion.net/wp-content/uploads/2021/12/juguetes-sets-lego-batman.jpg";
            }
            return View(personas);
        }
        public IActionResult ViewControllerGet(String nombre, int edad)
        {
            ViewData["MENSAJE"] = nombre + ", Edad: " + edad;
            return View();
        }
        public IActionResult ViewControllerPost()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ViewControllerPost(String cajanombre, int cajaedad)
        {
            ViewData["MENSAJE"] = "Nombre: " + cajanombre + ", Edad: "
               + cajaedad;
            return View();
        }

    }
}
