using Microsoft.AspNetCore.Mvc;
using MvcSeriesPersonajesPCM.Models;
using MvcSeriesPersonajesPCM.Repositories;

namespace MvcSeriesPersonajesPCM.Controllers
{
    public class SeriesController : Controller
    {
        
        private RepositorySeries repo;
        public SeriesController(RepositorySeries repo)
        {
            this.repo = repo;
        }
        
        public IActionResult Index()
        {
            List<Series> seriesList = this.repo.GetSeries();
            return View(seriesList);
        }
      
        public IActionResult Details(int id)
        {
            Series serie = this.repo.GetOneSerie(id);
            return View(serie);
        }

    
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Series series)
        {
            this.repo.AddSerie(series);
            return RedirectToAction("Index");
        }

     
        public ActionResult Personajes(int id)
        {
            List<Personajes> personajes = this.repo.MostrarPersonajes(id);
            return View(personajes);
        }
    }
}


