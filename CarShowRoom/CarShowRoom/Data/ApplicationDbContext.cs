using CarShowRoom.Domain;
using CarShowRoom.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarShowRoom.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Car> Cars { get; set; }

        public DbSet<CarCreateViewModel> CarCreateViewModel { get; set; }
        public DbSet<CarDetailsViewModel> CarDetailsViewModel { get; set; }
        public DbSet<CarAllViewModel> CarAllViewModel { get; set; }
    }
}
