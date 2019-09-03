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
    public class HouseModelCusController : Controller
    {
        
        private readonly IUnitOfWork _unitOfWork;
        [BindProperty]
        public HouseModelDetails HouseVM { get; set; }
        public HouseModelCusController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            HouseVM = new HouseModelDetails();
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
        public IActionResult ViewDetails(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            ViewData["DbContext"] = _unitOfWork;
            HouseVM.HouseModel  = _unitOfWork.Repository<HouseModels>().Find(c=>c.Id == id);
            HouseVM.HouseModelCategory = _unitOfWork.Repository<HouseModelCategory>().Find(c => c.Id == HouseVM.HouseModel.HouseModelCategoryId);
            HouseVM.Images = _unitOfWork.Repository<HouseModelImages>().FindAll(c => c.HouseModelId == HouseVM.HouseModel.HouseModelCategoryId);
            return View(HouseVM);
        }

    }
}