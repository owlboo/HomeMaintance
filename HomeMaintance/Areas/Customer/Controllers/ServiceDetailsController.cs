using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeMaintance.Models;
using HomeMaintance.Models.ViewModels;
using HomeMaintance.Reposity;
using Microsoft.AspNetCore.Mvc;

namespace HomeMaintance.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ServiceDetailsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        [BindProperty]
        public ServiceDetailsViewModel ServiceDetailVM { get; set; }
        public ServiceDetailsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            ServiceDetailVM = new ServiceDetailsViewModel();
        }
        public IActionResult Index(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            ViewData["ListService"] = _unitOfWork.Repository<Services>().GetAllInclude(c => c.Category).Take(5);
            ServiceDetailVM.Services = _unitOfWork.Repository<Services>().GetAllInclude(c =>c.Category).Where(c => c.Id == id).SingleOrDefault();
            ServiceDetailVM.Appointments = new Appointments();
            return View(ServiceDetailVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAppointment()
        {
            if (!ModelState.IsValid)
            {
                return null;
            }
            if(ServiceDetailVM.Appointments == null)
            {
                return null;
            }
            Random rand = new Random();
            var appName = "CH" + DateTime.Now.ToString("ddMMyyyy")+ rand.Next(10,99);
            ServiceDetailVM.Appointments.AppointmentsName = appName;
            ServiceDetailVM.Appointments.CreatedDate = DateTime.Now;

            _unitOfWork.Repository<Appointments>().Insert(ServiceDetailVM.Appointments);
            await _unitOfWork.Commit();
            return RedirectToAction("Index","Home", new { areas = "Customer"});
        }
    }
}