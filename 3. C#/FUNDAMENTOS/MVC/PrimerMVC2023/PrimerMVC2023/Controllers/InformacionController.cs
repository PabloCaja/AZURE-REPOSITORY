using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
    }
}
