using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HomeMaintance.Models;
using HomeMaintance.Models.ViewModels;
using HomeMaintance.Reposity;
using Microsoft.AspNetCore.Mvc;

namespace HomeMaintance.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        [BindProperty]
        public HomeViewModel HomeVM { get; set; }
        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            HomeVM = new HomeViewModel();
        }
        public IActionResult Index()
        {

            HomeVM.Services = _unitOfWork.Repository<Services>().GetAll();
            HomeVM.HumanResources = _unitOfWork.Repository<HumanResources>().GetAll();
            HomeVM.Feedback = new Feedback();

            return View(HomeVM);
        }
        [HttpPost,ActionName("Index")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> IndexPost()
        {
            //Validate email format
            string emailRegex = @"^[a-z][a-z0-9_\.]{5,32}@[a-z0-9]{2,}(\.[a-z0-9]{2,4}){1,2}$";

            string phoneRegex = @"(09|03[0-9])+([0-9]{8})\b";
            Regex EmailRe = new Regex(emailRegex);
            Regex PhoneRe = new Regex(phoneRegex);

            if (!EmailRe.IsMatch(HttpContext.Request.Form["Email"].ToString()) || !PhoneRe.IsMatch(HttpContext.Request.Form["Phone"].ToString()))
            {
                return PartialView("Error");
            }

            Feedback feedback = new Feedback
            {
                SenderName = HttpContext.Request.Form["Name"],
                Email = HttpContext.Request.Form["Email"],
                Phone = HttpContext.Request.Form["Phone"],
                Content = HttpContext.Request.Form["Message"],
                CreatedDate = DateTime.Today
            };
            
            await _unitOfWork.Repository<Feedback>().InsertAsync(feedback);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Contact(Contact contact)
        {
            if (!ModelState.IsValid) return View();

            await _unitOfWork.Repository<Contact>().InsertAsync(contact);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Service()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }
    }
}