using Microsoft.AspNetCore.Mvc;
using RolPrueba1.Models;
using RolPrueba1.Repository;

namespace RolPrueba1.Controllers
{
    public class FichaController : Controller
    {
        private RepositoryFichapj repo;

        public FichaController(RepositoryFichapj repo)
        {
            this.repo = repo;
        }

        public IActionResult ListadoFichapj()
        {
            List<Fichapj> Fichapjs = this.repo.GetFichapj();
            return View(Fichapjs);
        }

        // public IActionResult JugadorClase(string jugador1)
        //{
        //List<Fichapj> Fichapjs = this.repo.GetJugadorFicha(jugador1);
        //    return View(Fichapjs);
        //}

        //public IActionResult Detalles(string jugador2)
        //{
        //Fichapj Fichapj = this.repo.FindFichapj(jugador2);
        //    return View(Fichapj);
        //}

        public IActionResult BuscarJugadorClase()
        {
            List<Fichapj> Fichapjs = this.repo.GetFichapj();
            return View(Fichapjs);
        }

        [HttpPost]
        public IActionResult BuscarJugadorClase(string clase)
        {
            List<Fichapj> Fichapjs = this.repo.GetJugadorClase(clase);
            return View(Fichapjs);
        }
    }
}
