using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeMaintance.Data;
using HomeMaintance.Models;
using HomeMaintance.Ultilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeMaintance.Areas.Identity.Pages.Account
{
    public class AddAdminUserDefaultModel : PageModel
    {
        private const string superAdminEndUser = SD.SuperAdminEndUser;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _db;
        public AddAdminUserDefaultModel(
            UserManager<IdentityUser> userManager,

            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext db
            )
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> OnGet()
        {
            
            //Create Roles for our Website And create ADmin USer
            if (!await _roleManager.RoleExistsAsync(SD.SuperAdminEndUser))
            {
                await _roleManager.CreateAsync(new IdentityRole(superAdminEndUser));
                var userAdmin = new Users()
                {
                    UserName = SD.EmailDefault,
                    DisplayName = "Main Supper Admin",
                    Email = SD.EmailDefault,
                    PhoneNumber = "0912312321",
                    isMainAdmin = true
                };


                var resultUser = await _userManager.CreateAsync(userAdmin, "Admin123!");
                await _userManager.AddToRoleAsync(userAdmin, SD.SuperAdminEndUser);
            }


            return Page();
        }
    }
}