using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace SkyblockProject.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Welcome/
        //Example for passing variables via the URL. Probably not used in our project.
        //public IActionResult Welcome(string name, int numTimes = 1)
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //The ViewData dictionary object contains data that will be passed to the view
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
