using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tutorialAsp.Models;

namespace tutorialAsp.Data
{
    public class tutorialAspContext : DbContext
    {
        public tutorialAspContext (DbContextOptions<tutorialAspContext> options)
            : base(options)
        {
        }

        public DbSet<tutorialAsp.Models.Movie> Movie { get; set; }
    }
}
