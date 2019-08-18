using System;
using System.Collections.Generic;
using System.Text;
using HomeMaintance.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HomeMaintance.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Services> Services { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<HumanResources> HumanResources { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Appointments> Appointments { get; set; }
    }
}
