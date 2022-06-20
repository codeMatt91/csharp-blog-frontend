using csharp_blog_frontend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace csharp_blog_frontend.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        { 
            return View();
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            return View(id);
        }

        [HttpGet]
        public IActionResult Create()
        { 
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(id);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(id);
        }
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}