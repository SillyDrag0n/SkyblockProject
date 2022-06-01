using Microsoft.AspNetCore.Mvc;

namespace SkyblockProject.Controllers
{
    public class IslandCotroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
