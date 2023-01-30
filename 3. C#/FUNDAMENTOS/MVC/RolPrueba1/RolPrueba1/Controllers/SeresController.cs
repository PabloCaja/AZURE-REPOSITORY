using System.Drawing;
using System.Numerics;
using Microsoft.AspNetCore.Mvc;
using RolPrueba1.Models;
using RolPrueba1.Repository;

namespace RolPrueba1.Controllers
{
    public class SeresController : Controller
    {
        //Llamamos al repositorio para poder usarlo desde el controlador
        private RepositorySeres repo;
        public SeresController(RepositorySeres repo)
        {
            this.repo = repo;
        }

        // Desde la vista index, llamamos a la lista de Seres
        public IActionResult Index()
        {
            List<Seres> seres = this.repo.GetSeres();
            return View(seres);
        }

        // Desde la vista Details, llamamos a los detalles de la serie
        // Recibiendo la ID
        public IActionResult Details(string id)
        {
            Seres ser = this.repo.GetOneSer(id);
            return View(ser);
        }


        // Crear una vista para crear una nueva criatura
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Seres ser)
        {
            this.repo.AddSer(ser);
            return RedirectToAction("Index");
        }

        // realizamos el update con su post 
        public IActionResult Update(string id)
        {
            Seres ser = this.repo.FindSer(id);
            return View(ser);
        }

        [HttpPost]
        public IActionResult Update(Seres ser)
        {
            this.repo.UpdateSer(ser.Nombre, ser.Especie, ser.Planeta,
            ser.Agresividad, ser.Habilidades, ser.Debilidad, ser.Bioma);
            return RedirectToAction("Index");
        }

        // delete rows
        public IActionResult Delete(string id)
        {
            this.repo.DeleteSeres(id);
            return RedirectToAction("Index");
        }
    }

}

