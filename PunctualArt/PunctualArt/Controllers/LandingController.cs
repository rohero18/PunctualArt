using Microsoft.AspNetCore.Mvc;

namespace PunctualArt.Controllers
{
    public class LandingController : Controller
    {
        public IActionResult Landing()
        {
            return View("Views/Landing.cshtml");
        }
    }
}