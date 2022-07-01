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
            var routes = context.Routes.OrderBy(m => m.Name).ToList();
            return View(routes);
        }
    }
}

