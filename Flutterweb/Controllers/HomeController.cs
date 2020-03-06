using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Flutterweb.Models;
using Newtonsoft.Json.Linq;

namespace Flutterweb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.index = 1;
            return View();
        }
        
        public IActionResult _IndexArticles(int? pageindex)
        {
            if (pageindex == null)
            {
                pageindex = 1;
            }

            ViewBag.index = pageindex + 1;
            Models.Article ac = new Models.Article();
            return PartialView(ac.GetArticlesData(pageindex));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("/article/post/{id}/{title}", Name ="articles")]
        public IActionResult Article(int id, string title)
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
