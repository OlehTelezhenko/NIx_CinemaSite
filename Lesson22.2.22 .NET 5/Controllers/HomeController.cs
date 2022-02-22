using Lesson22._2._22_.NET_5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson22._2._22_.NET_5.Controllers
{
    [NonController]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private SheduleDBContext _dbContext;

        public HomeController(ILogger<HomeController> logger, SheduleDBContext dBContext)
        {
            _dbContext = dBContext;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_dbContext.Lessons.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
