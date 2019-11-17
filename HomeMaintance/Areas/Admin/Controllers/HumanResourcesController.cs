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
    public class HumanResourcesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly HostingEnvironment _hostingEnvironment;

        public HumanResourcesController(IUnitOfWork unitOfWork,HostingEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            var lstHuman = _unitOfWork.Repository<HumanResources>().GetAll();
            return View(lstHuman);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HumanResources humanResources)
        {
            if (!ModelState.IsValid) return View(humanResources);

            await _unitOfWork.Repository<HumanResources>().InsertAsync(humanResources);
            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            var humanFromDb = await _unitOfWork.Repository<HumanResources>().GetByIdAsync(humanResources.Id);
            if (files.Count != 0)
            {
                var uploads = Path.Combine(webRootPath, @"images/HumanImages");
                var extension = Path.GetExtension(files[0].FileName);
                var fileName = Path.Combine(uploads, humanFromDb.PersonName + extension);
                using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                {
                    await files[0].CopyToAsync(fileStream);
                }

                humanResources.Avatar = Path.GetFileName(fileName);
            }
            else
            {
                var uploads = Path.Combine(webRootPath, @"images/HumanImages/"+SD.DefaultHumanImage);
                System.IO.File.Copy(uploads,webRootPath+ @"/images/HumanImages/"+ humanResources.Id+".png");
                humanResources.Avatar = humanResources.Id + ".png";
            }
            await _unitOfWork.Commit();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var humanResourcesFromDb = await _unitOfWork.Repository<HumanResources>().GetByIdAsync(id);
            if (humanResourcesFromDb == null) return NotFound();
            return View(humanResourcesFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,HumanResources humanResources)
        {
            if (id != humanResources.Id) return NotFound();
            if (!ModelState.IsValid) return View(humanResources);

            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            var humanFromDb = await _unitOfWork.Repository<HumanResources>().GetByIdAsync(humanResources.Id);
            if (files.Count != 0)
            {
                var uploads = Path.Combine(webRootPath, @"images\HumanImages");
                var extension = Path.GetExtension(files[0].FileName);
                var fileName = Path.Combine(uploads, humanFromDb.PersonName + extension);
                if (System.IO.File.Exists(Path.Combine(uploads, fileName)))
                {
                    System.IO.File.Exists(Path.Combine(uploads, fileName));
                }
                using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                {
                    await files[0].CopyToAsync(fileStream);
                }

                humanResources.Avatar = Path.GetFileName(fileName);
            }
            else
            {
                var uploads = Path.Combine(webRootPath, @"images\HumanImages\" + SD.DefaultHumanImage);
                if (System.IO.File.Exists(Path.Combine(uploads, webRootPath + @"\images\HumanImages\" + humanResources.Id + ".png")))
                {
                    System.IO.File.Delete(Path.Combine(uploads, webRootPath + @"\images\HumanImages\" + humanResources.Id + ".png"));
                }
                System.IO.File.Copy(uploads, webRootPath + @"\images\HumanImages\" + humanResources.Id + ".png");
                humanResources.Avatar = humanResources.Id + ".png";
            }

            if (humanResources.Avatar != null)
            {
                humanFromDb.Avatar = humanResources.Avatar;
            }

            humanFromDb.PersonName = humanResources.PersonName;
            humanFromDb.ExperienceYears = humanResources.ExperienceYears;
            humanFromDb.PhoneNumber = humanResources.PhoneNumber;
            humanFromDb.Role = humanResources.Role;
            humanFromDb.Address = humanResources.Address;
            humanFromDb.Description = humanResources.Description;



            await _unitOfWork.Commit();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var humanResourcesFromDb = await _unitOfWork.Repository<HumanResources>().GetByIdAsync(id);
            if (humanResourcesFromDb == null) return NotFound();
            return View(humanResourcesFromDb);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var humanResourcesFromDb = await _unitOfWork.Repository<HumanResources>().GetByIdAsync(id);
            if (humanResourcesFromDb == null) return NotFound();
            return View(humanResourcesFromDb);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var humanResourcesFromDb = await _unitOfWork.Repository<HumanResources>().GetByIdAsync(id);
            if (humanResourcesFromDb == null) return NotFound();
            await _unitOfWork.Repository<HumanResources>().DeleteAsync(humanResourcesFromDb);

            return RedirectToAction("Index");
        }
    }
}