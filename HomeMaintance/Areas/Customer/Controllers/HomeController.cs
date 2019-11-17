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
        public FooterViewModel FooterView { get; set; }
        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            HomeVM = new HomeViewModel();
                     
        }
        public IActionResult Index()
        {
            ViewData["DbContext"] = _unitOfWork;
            HomeVM.Services = _unitOfWork.Repository<Services>().GetAll();
            HomeVM.HumanResources = _unitOfWork.Repository<HumanResources>().GetAll();
            HomeVM.Feedback = new Feedback();
            return View(HomeVM);
        }
        [HttpPost,ActionName("Index")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> IndexPost()
        {
           

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Contact()
        {
            ViewData["DbContext"] = _unitOfWork;
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

        public async Task<IActionResult> About()
        {
            ViewData["DbContext"] = _unitOfWork;
            return View();
        }

        public async Task<IActionResult> Service()
        {
            ViewData["DbContext"] = _unitOfWork;
            return View();
        }

        public async Task<IActionResult> Gallery()
        {
            ViewData["DbContext"] = _unitOfWork;
            return RedirectToAction("Index", "TypicalConstructionCustomer");
        }
        public async Task<IActionResult> Feedback()
        {
            ViewData["DbContext"] = _unitOfWork;
            return PartialView("Feedback");
        }

        [HttpPost, ActionName("Feedback")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FeedbackPost()
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
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CreateAppointment(string txtName =null, string txtPhone=null, string txtEmail = null, string txtMessage=null)
        {
            Appointments appointments = new Appointments()
            {
                CustomerName = txtName,
                CustomerPhone = txtPhone,
                CustomerEmail = txtEmail,
                CustomerMessage = txtMessage,
                CreatedDate = DateTime.Now,
                AppointmentsName = "Khách hàng hẹn gặp"
            };
            _unitOfWork.Repository<Appointments>().Insert(appointments);
            await _unitOfWork.Commit();
            return RedirectToAction(nameof(Index));
        }
    }
}