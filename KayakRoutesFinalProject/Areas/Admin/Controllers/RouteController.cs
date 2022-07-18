using System.Linq;
using Microsoft.AspNetCore.Mvc;
using KayakRoutesFinalProject.Models;

namespace RouteList.Areas.Admin.Controllers
{
    public class RouteController : Controller
    {
        private RouteContext context { get; set; }

        public RouteController(RouteContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            //ViewBag.Routes = context.Routes.OrderBy(g => g.Name).ToList();
            return View("Edit", new Route());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            //ViewBag.Routes = context.Routes.OrderBy(g => g.Name).ToList();
            var route = context.Routes.Find(id);
            return View(route);
        }

        [HttpPost]
        public IActionResult Edit(Route route)
        {
            if (ModelState.IsValid)
            {
                if (route.RouteId == 0)
                    context.Routes.Add(route);
                else
                    context.Routes.Update(route);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (route.RouteId == 0) ? "Add" : "Edit";
                //ViewBag.Routes = context.Routes.OrderBy(g => g.Name).ToList();
                return View(route);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var route = context.Routes.Find(id);
            return View(route);
        }

        [HttpPost]
        public IActionResult Delete(Route route)
        {
            context.Routes.Remove(route);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}

