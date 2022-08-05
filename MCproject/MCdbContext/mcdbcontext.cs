using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MCproject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity ;


namespace MCproject.MCdbcontext
{
    public class Mcdbcontext : IdentityDbContext<IdentityUser>
    {
        public Mcdbcontext(DbContextOptions<Mcdbcontext> options):base(options)
        {

        }
        public DbSet<make>makes { get; set; }
        public DbSet<models> models { get; set; }
        public DbSet<Bike> bikes { get; set; }
        public DbSet<bikeee> bikeees { get; set; }


        public DbSet<ApplicationUser> ApplicationUsers { get; set; }


    }
}
