using BrzaPosta.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrzaPosta.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Package> Package {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "Super Admin", NormalizedName = "Super Admin".ToUpper() },
                new IdentityRole { Name = "Admin", NormalizedName = "Admin".ToUpper() },
                new IdentityRole { Name = "Dostavljac", NormalizedName = "Dostavljac".ToUpper() },
                new IdentityRole { Name = "Korisnik", NormalizedName = "Korisnik".ToUpper() });
        }
    }
}
