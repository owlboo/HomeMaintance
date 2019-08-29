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
    public class HouseModelCusController : Controller
    {
        
        private readonly IUnitOfWork _unitOfWork;
        public HouseModelCusController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var lstModelCategory = _unitOfWork.Repository<HouseModelCategory>().GetAll().ToList();
            ViewData["DbContext"] = _unitOfWork;
            return View(lstModelCategory);
        }
        public IActionResult GetHouseModel(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var lstHouseModel = _unitOfWork.Repository<HouseModels>().FindAll(c => c.HouseModelCategoryId == id).ToList();
            return PartialView(lstHouseModel);
            
        }
    }
}