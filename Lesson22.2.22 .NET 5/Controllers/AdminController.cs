using Microsoft.AspNetCore.Mvc;

namespace Lesson22._2._22_.NET_5.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
