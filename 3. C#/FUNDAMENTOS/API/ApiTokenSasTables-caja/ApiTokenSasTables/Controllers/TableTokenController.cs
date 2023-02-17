using ApiTokenSasTables.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiTokenSasTables.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableTokenController : ControllerBase
    {
        private ServiceSasSToken service;

        public TableTokenController(ServiceSasSToken service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("[action]/{curso}")]
        public ActionResult<string> GenerateToken(string curso)
        {
            string token = this.service.GenerateSaSToken(curso);
            //NO SE DEVUELVE DIRECTAMENTE EL STRING
            //LO QUE SE DEVUELVE EN LAS APIS SON JSON
            // { token: awdjaiwdjiawaidiai2192314$$121sada }
            return Ok(
                    new
                    {
                        token = token,
                    }
                );
        }
    }
}
