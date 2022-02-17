using Microsoft.AspNetCore.Mvc;

namespace Nix_CinemaSite.PL.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
