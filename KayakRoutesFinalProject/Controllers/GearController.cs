using System.Linq;
using Microsoft.AspNetCore.Mvc;
using KayakRoutesFinalProject.Models;

namespace KayakRoutesFinalProject.Controllers
{
    public class GearController : Controller
    {
        private GearContext context { get; set; }

        public GearController(GearContext ctx)
        {
            context = ctx;
        }
        [Route("Gear/Gear")]
        public IActionResult Index()
        {
            var gears = context.Gears.OrderBy(m => m.Contact).ToList();
            return View(gears);
        }
    }
}
