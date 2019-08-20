using Microsoft.EntityFrameworkCore;
using Polo_TestSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polo_TestSite.DAL
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<Welcome> Welcomes { get; set; }
        public DbSet<What_We> What_Wes { get; set; }


    }
}
