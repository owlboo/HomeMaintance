using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HomeMaintance.Models;
using HomeMaintance.Reposity;
using HomeMaintance.Ultilities;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Mvc;

namespace HomeMaintance.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TypicalConstructionController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly HostingEnvironment _hostingEnvironment;

        public TypicalConstructionController(IUnitOfWork unitOfWork,HostingEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            var lstTypicalConstruction = _unitOfWork.Repository<TypicalConstruction>().GetAll();
            return View(lstTypicalConstruction);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TypicalConstruction typicalConstruction)
        {
            if (!ModelState.IsValid) return View();

            await _unitOfWork.Repository<TypicalConstruction>().InsertAsync(typicalConstruction);
            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            var typicalFromDb = await _unitOfWork.Repository<TypicalConstruction>().GetByIdAsync(typicalConstruction.Id);
            if (files.Count != 0)
            {
                var uploads = Path.Combine(webRootPath, @"images/TypicalImages");
                var extension = Path.GetExtension(files[0].FileName);
                var fileName = Path.Combine(uploads, typicalFromDb.Name + extension);
                using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                {
                    await files[0].CopyToAsync(fileStream);
                }

                typicalConstruction.Thumbnail = Path.GetFileName(fileName);
            }
            else
            {

            }
            await _unitOfWork.Commit();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var typicalFromDb = _unitOfWork.Repository<TypicalConstruction>().GetById(id);

            return View(typicalFromDb);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TypicalConstruction typicalConstruction)
        {
            if (id != typicalConstruction.Id) return NotFound();
            if (!ModelState.IsValid) return View(typicalConstruction);

            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            var typicalFromDb = await _unitOfWork.Repository<TypicalConstruction>().GetByIdAsync(typicalConstruction.Id);
            if (files.Count != 0)
            {
                var uploads = Path.Combine(webRootPath, @"images\TypicalImages");
                var extension = Path.GetExtension(files[0].FileName);
                var fileName = Path.Combine(uploads, typicalConstruction.Name + extension);
                if (System.IO.File.Exists(Path.Combine(uploads, fileName)))
                {
                    System.IO.File.Exists(Path.Combine(uploads, fileName));
                }
                using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                {
                    await files[0].CopyToAsync(fileStream);
                }

                typicalConstruction.Thumbnail = Path.GetFileName(fileName);

            }
            if (typicalConstruction.Thumbnail != null)
            {
                typicalFromDb.Thumbnail = typicalConstruction.Thumbnail;
            }

            typicalFromDb.Name = typicalConstruction.Name;
            typicalFromDb.CustomerName = typicalConstruction.CustomerName;
            typicalFromDb.Address = typicalConstruction.Address;
            typicalFromDb.Description = typicalConstruction.Description;

            await _unitOfWork.Repository<TypicalConstruction>().UpdateAsync(typicalFromDb);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();

            var typicalFromDb = _unitOfWork.Repository<TypicalConstruction>().GetById(id);

            return View(typicalFromDb);
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var typicalFromDb = await _unitOfWork.Repository<TypicalConstruction>().GetByIdAsync(id);
                if (typicalFromDb == null) return NotFound();
                await _unitOfWork.Repository<TypicalConstruction>().DeleteAsync(typicalFromDb);

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                LogHelpers log = new LogHelpers();
                string path = "/Admin/Typical/Delete";
                log.WriteLogToDb(path, e.ToString());
                throw;
            }
            
        }


    }
}