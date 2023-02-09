using ApiCriaturasRol.Models;
using ApiCriaturasRol.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiCriaturasRol.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        private RepositorySeries repo;

        public SeriesController(RepositorySeries repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Serie>> GetSeries()
        {
            return this.repo.GetSeries();
        }

        [HttpGet("{id}")]
        public ActionResult<Serie> FindSerie(int id)
        {
            return this.repo.FindSerie(id);
        }

        [HttpGet]
        [Route("[action]/{idserie}")]
        public ActionResult<List<Personaje>> PersonajesSerie
            (int idserie)
        {
            return this.repo.GetPersonajesSerie(idserie);
        }
    }
}
