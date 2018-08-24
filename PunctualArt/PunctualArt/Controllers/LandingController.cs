using Microsoft.AspNetCore.Mvc;

namespace PunctualArt.Controllers
{
    public class LandingController : Controller
    {
        public IActionResult Landing() => View("Views/Landing.cshtml");
    }
}