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

        public IActionResult ViewControllerPostModel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ViewControllerPostModel(Comic comic)
        {
            //CUANDO RECIBAMOS UN COMIC, LO DEVOLVEMOS A LA VISTA COMO 
            //UN MODEL
            return View(comic);
        }

        //METODO PARA EL GET Y MOSTRAR LA VISTA LA PRIMERA VEZ
        public IActionResult ViewControllerPost()
        {
            return View();
        }

        //EL METODO PARA RECIBIR LOS DATOS CON POST
        //DEBE TENER UNA DECORACION
        [HttpPost]
        public IActionResult ViewControllerPost(string nombre, int edad)
        {
            ViewData["MENSAJE"] = "Nombre: " + nombre + ", Edad: "
                + edad;
            return View();
        }

        public IActionResult ViewControllerGet(string nombre, int edad)
        {
            //CON ESTO, YA HEMOS RECIBIDO LAS VARIABLES
            //PODEMOS HACER CON ELLAS LO QUE DESEEMOS.
            //POR EJEMPLO, VAMOS A ENVIAR LOS DATOS RECIBIDOS A LA VISTA
            ViewData["MENSAJE"] = nombre + ", Edad: " + edad;
            return View();
        }

        public IActionResult ControllerViewModelList()
        {
            //VAMOS A REALIZAR UN BUCLE PARA CREARNOS MULTIPLES PERSONAS
            List<Persona> personas = new List<Persona>();
            for (int i = 1; i <= 10; i++)
            {
                Persona persona = new Persona();
                persona.Nombre = "Persona " + i;
                persona.Edad = i + 20;
                persona.Email = "persona" + i + "@gmail.com";
                persona.Imagen = "https://juegosdeconstruccion.net/wp-content/uploads/2021/12/juguetes-sets-lego-batman.jpg";
                personas.Add(persona);
            }
            return View(personas);
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

        public IActionResult ControllerView()
        {
            //AQUI ENVIAMOS LA INFORMACION SIMPLE
            ViewBag.Nombre = "Alumno";
            ViewData["Descripcion"] = "Estoy aprendiendo Net Core Mvc";
            ViewData["Year"] = 2023;
            return View();
        }
    }
}
