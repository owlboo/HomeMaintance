using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HomeMaintance.Models;
using HomeMaintance.Reposity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HomeMaintance.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class SignInController : Controller
    {
        public readonly IUnitOfWork _unitOfWork;
        public readonly UserManager<IdentityUser> _userManager;
        public readonly SignInManager<IdentityUser> _signInManager;
        public SignInController(IUnitOfWork unitOfWork, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult SignInIndex()
        {
            return View();
        }

        public string ReturnUrl { get; set; }
        [BindProperty]
        public SignInModel Input { get; set; }
        public class SignInModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }
        [HttpPost, ActionName("SignInIndex")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignInPost()
        {
            if (!ModelState.IsValid)
            {
                return null;
            }
            var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, false, lockoutOnFailure: true);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home", new { areas = "Customer" });
            }
            else
            {
                ViewBag.Err = "Thông tin đăng nhập không chính xác !!" ;
            }
            return RedirectToAction("Index", "Home", new { areas = "Customer" });

        }
    }

}