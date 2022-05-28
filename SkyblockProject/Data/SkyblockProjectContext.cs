using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SkyblockProject.Models;

namespace SkyblockProject.Data
{
    public class SkyblockProjectContext : DbContext
    {
        public SkyblockProjectContext (DbContextOptions<SkyblockProjectContext> options)
            : base(options)
        {
        }

        public DbSet<SkyblockProject.Models.Collection>? Collection { get; set; }
    }
}
