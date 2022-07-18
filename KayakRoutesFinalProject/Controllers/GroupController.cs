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
            return View(groups);
        }

        
    }
}
