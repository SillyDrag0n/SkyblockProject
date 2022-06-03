using Microsoft.AspNetCore.Mvc;

namespace SkyblockProject.Controllers
{
    public class IslandsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
