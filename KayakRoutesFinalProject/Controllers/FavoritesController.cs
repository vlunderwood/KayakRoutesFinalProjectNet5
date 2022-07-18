using Microsoft.AspNetCore.Mvc;

namespace KayakRoutesFinalProject.Controllers
{
    public class FavoritesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
