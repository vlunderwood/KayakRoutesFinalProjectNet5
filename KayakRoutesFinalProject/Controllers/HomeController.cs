using System.Linq;
using Microsoft.AspNetCore.Mvc;
using KayakRoutesFinalProject.Models;

namespace KayakFinalProject.Controllers
{
    public class HomeController : Controller
    {
        private RouteContext context { get; set; }

        public HomeController(RouteContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            
            var routes = context.Routes.ToList();
            return View(routes);
        }
        
        public IActionResult Details(string id)
        {
            var session = new KayakSession(HttpContext.Session);

            return View();
        }
    }
}

