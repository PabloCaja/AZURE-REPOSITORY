using Microsoft.AspNetCore.Mvc;

namespace PrimerMVC2023.Controllers
{
    public class PruebaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NuevaVista()
        {
            return View();
        }
    }
}
