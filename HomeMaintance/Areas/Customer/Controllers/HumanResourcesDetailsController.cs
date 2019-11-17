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
    public class HumanResourcesDetailsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public FooterViewModel FooterView { get; set; }

        public HumanResourcesDetailsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index(int? id)
        {
            ViewData["DbContext"] = _unitOfWork;
            if (id == null) return NotFound();
            var human = _unitOfWork.Repository<HumanResources>().GetById(id);
            if (human == null) return NotFound("Không tìm thấy");
            return View(human);
        }
    }
}