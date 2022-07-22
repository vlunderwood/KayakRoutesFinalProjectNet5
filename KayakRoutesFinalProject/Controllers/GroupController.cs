using System.Linq;
using Microsoft.AspNetCore.Mvc;
using KayakRoutesFinalProject.Models;

namespace KayakRoutesFinalProject.Controllers
{
    public class GroupController : Controller
    {
        private GroupContext context { get; set; }

        public GroupController(GroupContext ctx)
        {
            context = ctx;
        }
        [Route("Group/Group")]
        public IActionResult Index()
        {
            var groups = context.Groups.OrderBy(m => m.Contact).ToList();
            return View("Index" ,groups);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            //ViewBag.Routes = context.Routes.OrderBy(g => g.Name).ToList();
            return View("Edit", new GroupFloat());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            //ViewBag.Routes = context.Routes.OrderBy(g => g.Name).ToList();
            var group = context.Groups.Find(id);
            return View(group);
        }

        [HttpPost]
        public IActionResult Edit(GroupFloat group)
        {
            if (ModelState.IsValid)
            {
                if (group.GroupId == 0)
                    context.Groups.Add(group);
                else
                    context.Groups.Update(group);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (group.GroupId == 0) ? "Add" : "Edit";
                //ViewBag.Routes = context.Routes.OrderBy(g => g.Name).ToList();
                return View(group);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var route = context.Groups.Find(id);
            return View(route);
        }

        [HttpPost]
        public IActionResult Delete(GroupFloat group)
        {
            context.Groups.Remove(group);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }
}
