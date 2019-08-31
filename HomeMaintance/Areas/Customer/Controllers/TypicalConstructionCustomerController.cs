using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeMaintance.Models;
using HomeMaintance.Reposity;
using Microsoft.AspNetCore.Mvc;

namespace HomeMaintance.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class TypicalConstructionCustomerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public TypicalConstructionCustomerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var lstTypicalContruction = _unitOfWork.Repository<TypicalConstruction>().GetAll();
            return View(lstTypicalContruction);
        }
    }
}