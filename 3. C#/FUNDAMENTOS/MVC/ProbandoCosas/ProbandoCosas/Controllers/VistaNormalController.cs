using Microsoft.AspNetCore.Mvc;

namespace ProbandoCosas.Controllers
{
    public class VistaNormalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
