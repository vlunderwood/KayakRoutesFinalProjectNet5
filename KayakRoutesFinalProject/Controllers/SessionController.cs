using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace KayakRoutesFinalProject.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            int num = HttpContext.Session.GetInt32("num") ?? 0;
            num += 1;
            HttpContext.Session.SetInt32("num", num);

            return View();
        }
    }
}
