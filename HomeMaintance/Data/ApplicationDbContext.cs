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
        public DbSet<HouseModelCategory> HouseModelCategories { get; set; }
        public DbSet<HouseModels> HouseModels { get; set; }
        public DbSet<HouseModelImages> HouseModelImages { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<TypicalConstruction> TypicalConstructions { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<ErrorLog> ErrorLogs { get; set; }
    }
}
