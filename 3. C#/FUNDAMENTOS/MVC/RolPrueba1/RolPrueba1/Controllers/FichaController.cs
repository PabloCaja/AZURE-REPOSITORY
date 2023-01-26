using Microsoft.AspNetCore.Mvc;

namespace RolPrueba1.Controllers
{
    public class FichaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
