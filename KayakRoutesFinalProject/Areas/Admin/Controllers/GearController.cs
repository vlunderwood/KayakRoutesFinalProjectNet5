using System.Linq;
using Microsoft.AspNetCore.Mvc;
using KayakRoutesFinalProject.Models;

namespace KayakRoutesFinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GearController : Controller
    {
        
        private GearContext context { get; set; }

        public GearController(GearContext ctx)
        {
            context = ctx;
        }
        [Route("[area]/[controller]s/{id?}")]
        public IActionResult Index()
        {
            var gears = context.Gears.OrderBy(m => m.Contact).ToList();
            return View(gears);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            //ViewBag.Routes = context.Routes.OrderBy(g => g.Name).ToList();
            return View("Edit", new Gear());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            //ViewBag.Routes = context.Routes.OrderBy(g => g.Name).ToList();
            var gear = context.Gears.Find(id);
            return View(gear);
        }

        [HttpPost]
        public IActionResult Edit(Gear gear)
        {
            if (ModelState.IsValid)
            {
                if (gear.GearId == 0)
                    context.Gears.Add(gear);
                else
                    context.Gears.Update(gear);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (gear.GearId == 0) ? "Add" : "Edit";
                //ViewBag.Routes = context.Routes.OrderBy(g => g.Name).ToList();
                return View(gear);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var route = context.Gears.Find(id);
            return View(route);
        }

        [HttpPost]
        public IActionResult Delete(Gear gear)
        {
            context.Gears.Remove(gear);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
