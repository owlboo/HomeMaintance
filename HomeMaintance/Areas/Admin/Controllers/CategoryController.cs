using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeMaintance.Models;
using HomeMaintance.Reposity;
using HomeMaintance.Ultilities;
using Microsoft.AspNetCore.Mvc;

namespace HomeMaintance.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var lstCategory = _unitOfWork.Repository<Category>().GetAll();
            return View(lstCategory);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await _unitOfWork.Repository<Category>().InsertAsync(category);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var categoryFromDb = await _unitOfWork.Repository<Category>().GetByIdAsync(id);
            if (categoryFromDb == null) return NotFound();
            return View(categoryFromDb);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }

            var categoryFromDb = await _unitOfWork.Repository<Category>().GetByIdAsync(id);
            if (categoryFromDb != null)
            {
                categoryFromDb.CategoryName = category.CategoryName;
                categoryFromDb.CreatedDate = category.CreatedDate;
                categoryFromDb.ModifiedDate = category.ModifiedDate;
                categoryFromDb.MetaTitle = category.MetaTitle;
                categoryFromDb.MetaDescription = category.MetaDescription;
                categoryFromDb.MetaKeyword = category.MetaKeyword;
                categoryFromDb.SEOTitle = category.SEOTitle;

                await _unitOfWork.Repository<Category>().UpdateAsync(categoryFromDb);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var categoryFromDb =  _unitOfWork.Repository<Category>().GetByIdAsync(id);
            if (categoryFromDb == null) return NotFound();
            return View(categoryFromDb);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var categoryFromDb = await _unitOfWork.Repository<Category>().GetByIdAsync(id);
                if (categoryFromDb == null) return NotFound();
                await _unitOfWork.Repository<Category>().DeleteAsync(categoryFromDb);

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                string path = "/Admin/Category/Delte";
                LogHelpers log = new LogHelpers();
                log.WriteLogToDb(path, e.ToString());
                throw;
            }
            
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var categoryFromDb = await _unitOfWork.Repository<Category>().GetByIdAsync(id);
            if (categoryFromDb == null) return NotFound();
            return View(categoryFromDb);
        }
    }
}