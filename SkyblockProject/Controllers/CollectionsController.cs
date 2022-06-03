using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SkyblockProject.Data;
using SkyblockProject.Models;

namespace SkyblockProject.Controllers
{
    public class CollectionsController : Controller
    {
        private readonly SkyblockProjectContext _context;

        public CollectionsController(SkyblockProjectContext context)
        {
            _context = context;
        }

        // GET: Collections
        public async Task<IActionResult> Index(string searchString)
        {
            //Chearts a LINQ query to select the collections
            //More information under: https://docs.microsoft.com/en-us/dotnet/standard/linq/
            var collctions_m = from m in _context.Collection
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                collctions_m = collctions_m.Where(s => s.CollectionTitle!.Contains(searchString));
            }

            return View(await collctions_m.ToListAsync());
        }
    }
}
