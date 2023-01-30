using Microsoft.AspNetCore.Mvc;

namespace RolPrueba1.Controllers
{
    public class TesteoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
