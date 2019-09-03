using HomeMaintance.Models;
using HomeMaintance.Reposity;
using HomeMaintance.Ultilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeMaintance.Data
{
    public class DbInittializer : IDbInittializer
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public SystemConfig SystemConfig { get; set; }
        public DbInittializer(ApplicationDbContext db, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager )
        {
            _roleManager = roleManager;
            _db = db;
            _userManager = userManager;
        }
        public async void Initialize()
        {
            _db.Database.Migrate();
            //if (_db.Roles.Any(r => r.Name == SD.SuperAdminEndUser)) return;
            //_roleManager.CreateAsync(new IdentityRole(SD.SuperAdminEndUser)).GetAwaiter().GetResult();

            //_userManager.CreateAsync(new ApplicationUsers
            //{
            //    UserName = "admin@gmail.com",
            //    Email = "admin@gmail.com",
            //    FullName = "Quản trị viên",
            //    EmailConfirmed = true
            //}, "Abc123!").GetAwaiter().GetResult();

            ////SystemConfig = new SystemConfig
            ////{
            ////    CompanyName = "Xây dựng Nam Việt",
            ////    CompanyEmail = "nguyenthanhcong088@gmail.com",
            ////    CompanyLogo = "Chưa đặt",
            ////    CompanyPhone = "0968501615",
            ////    CompanyAddress = "Gò Vấp"
            ////};

            

            //await _userManager.AddToRoleAsync(await _userManager.FindByEmailAsync("admin@gmail.com"), SD.SuperAdminEndUser);

        }
    }
}
