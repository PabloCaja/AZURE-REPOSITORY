using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ApiCriaturasRol.Repositories;
using ApiCriaturasRol.Models;


namespace ApiCriaturasRol.Controllers
{
    public class SeresController : Controller
    {
        [Route("api/[controller]")]
        [ApiController]
        public class SeresController : ControllerBase
        {
            private RepositorySeres repo;

            public SeresController(RepositorySeres repo)
            {
                this.repo = repo;
            }

            [HttpGet]
            public ActionResult<List<Ser>> GetSeres()
            {
                return this.repo.GetSeres();
            }

            [HttpGet("{id}")]
            public ActionResult<Ser> FindSer(int id)
            {
                return this.repo.FindSer(id);
            }

            [HttpPut]
            [Route("[action]/{nombre}/{idplaneta}")]
            public async Task<ActionResult> UpdateSerPlaneta(string id, int idplaneta)
                
            {
                await this.repo.UpdatePersonajeSerie(idpersonaje, idserie);
                return Ok();
            }

            [HttpPost]
            public async Task<ActionResult> CreatePersonaje(Personaje personaje)
            {
                await this.repo.InsertPersonaje(personaje.IdPersonaje
                    , personaje.Nombre, personaje.Imagen
                    , personaje.IdSerie);
                return Ok();
            }
        }
    }
}
