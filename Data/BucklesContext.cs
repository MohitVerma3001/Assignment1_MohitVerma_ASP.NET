using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Buckles.Models;

namespace Buckles.Data
{
    public class BucklesContext : DbContext
    {
        public BucklesContext (DbContextOptions<BucklesContext> options)
            : base(options)
        {
        }

        public DbSet<Buckles.Models.SeedData> SeedData { get; set; }
    }
}
