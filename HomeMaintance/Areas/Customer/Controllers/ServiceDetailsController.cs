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
            ServiceDetailVM.Services = _unitOfWork.Repository<Services>().GetAllInclude(c =>c.Category).Where(c => c.Id == id).SingleOrDefault();
            ServiceDetailVM.Appointments = new Appointments();
            return View(ServiceDetailVM);
        }

    }
}