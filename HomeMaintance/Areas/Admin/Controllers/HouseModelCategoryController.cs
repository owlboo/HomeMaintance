using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeMaintance.Models;
using HomeMaintance.Reposity;
using Microsoft.AspNetCore.Mvc;

namespace HomeMaintance.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HouseModelCategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public HouseModelCategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {           
            return View(_unitOfWork.Repository<HouseModelCategory>().GetAll());
        }
        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(HouseModelCategory modelCategory)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _unitOfWork.Repository<HouseModelCategory>().Insert(modelCategory);
            await _unitOfWork.Commit();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var houseModelCate = _unitOfWork.Repository<HouseModelCategory>().Find(h => h.Id == id);
            return View(houseModelCate);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, HouseModelCategory modelCategory)
        {
            if(id != modelCategory.Id)
            {
                return NotFound();
            }
            if(!ModelState.IsValid)
            {
                return NotFound();
            }
            var houseCateFromDb = await _unitOfWork.Repository<HouseModelCategory>().GetByIdAsync(modelCategory.Id);
            houseCateFromDb.HouseModelCategoryName = modelCategory.HouseModelCategoryName;
            houseCateFromDb.ModifiedDate = modelCategory.ModifiedDate;
            await _unitOfWork.Commit();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete (int? id)
        {
            if(id==null)
            {
                return NotFound();
            }
            var houseCateDelete = await _unitOfWork.Repository<HouseModelCategory>().GetByIdAsync(id);
            _unitOfWork.Repository<HouseModelCategory>().Delete(houseCateDelete);
            await _unitOfWork.Commit();
            return RedirectToAction(nameof(Index));
        }
    }
}