using Microsoft.AspNetCore.Mvc;

namespace MvcSeriesPersonajesCAJA.Controllers
{
    public class SeriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
