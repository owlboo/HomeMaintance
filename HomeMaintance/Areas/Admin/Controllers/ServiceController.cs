using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HomeMaintance.Data;
using HomeMaintance.Models;
using HomeMaintance.Models.ViewModels;
using HomeMaintance.Reposity;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Mvc;

namespace HomeMaintance.Areas.Admin
{
    [Area("Admin")]
    public class ServiceController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly HostingEnvironment _hostingEnvironment;

        [BindProperty]
        public ServiceViewModel ServicesVM { get; set; }
        public ServiceController(IUnitOfWork unitOfWork, HostingEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostingEnvironment = hostingEnvironment;
            ServicesVM = new ServiceViewModel();
        }
        public IActionResult Index()
        {
            var lstServices = _unitOfWork.Repository<Services>().GetAllInclude(s => s.Category);
            return View(lstServices);
        }

        public IActionResult Create()
        {
            ServicesVM.Categories = _unitOfWork.Repository<Category>().GetAll();
            ServicesVM.Services = new Services();
            return View(ServicesVM);
        }
        [HttpPost,ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePost()
        {
            if (!ModelState.IsValid)
            {
                return View(ServicesVM);
            }

            _unitOfWork.Repository<Services>().Insert(ServicesVM.Services);

            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            var serviceFromDb = await _unitOfWork.Repository<Services>().GetByIdAsync(ServicesVM.Services.Id);
            if (files.Count != 0)
            {
                var uploads = Path.Combine(webRootPath, @"images\ServiceImages");
                var extension = Path.GetExtension(files[0].FileName);
                var fileName = Path.Combine(uploads, serviceFromDb.ServiceName + extension);
                using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                {
                    await files[0].CopyToAsync(fileStream);
                }

                ServicesVM.Services.Thumbnail = Path.GetFileName(fileName);
               
            }
            await _unitOfWork.Commit();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            ServicesVM.Services = _unitOfWork.Repository<Services>().GetAllInclude(s => s.Category).SingleOrDefault(s=>s.Id==id);
            if (ServicesVM.Services == null)
            {
                return NotFound();
            }
            ServicesVM.Categories = _unitOfWork.Repository<Category>().GetAll();
            return View(ServicesVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id)
        {
            if (id != ServicesVM.Services.Id) return NotFound();
            if (!ModelState.IsValid)
            {
                return View(ServicesVM);
            }

            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            var serviceFromDb = await _unitOfWork.Repository<Services>().GetByIdAsync(ServicesVM.Services.Id);
            if (files.Count != 0)
            {
                var uploads = Path.Combine(webRootPath, @"images\ServiceImages");
                var extension = Path.GetExtension(files[0].FileName);
                var fileName = Path.Combine(uploads, serviceFromDb.ServiceName + extension);

                if (System.IO.File.Exists(Path.Combine(uploads, fileName)))
                {
                    System.IO.File.Delete(Path.Combine(uploads, fileName));
                }

                using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                {
                    await files[0].CopyToAsync(fileStream);
                }

                ServicesVM.Services.Thumbnail = Path.GetFileName(fileName);
            }

            if (ServicesVM.Services.Thumbnail != null)
            {
                serviceFromDb.Thumbnail = ServicesVM.Services.Thumbnail;
            }

            serviceFromDb.ServiceName = ServicesVM.Services.ServiceName;
            serviceFromDb.CreatedDate = ServicesVM.Services.CreatedDate;
            serviceFromDb.ModifiedDate = ServicesVM.Services.ModifiedDate;
            serviceFromDb.SEOTitle = ServicesVM.Services.SEOTitle;
            serviceFromDb.MetaTitle = ServicesVM.Services.MetaTitle;
            serviceFromDb.MetaDescription = ServicesVM.Services.MetaDescription;
            serviceFromDb.CategoryId = ServicesVM.Services.CategoryId;
            serviceFromDb.Description = ServicesVM.Services.Description;
            serviceFromDb.IsDone = ServicesVM.Services.IsDone;

            await _unitOfWork.Commit();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            ServicesVM.Services = _unitOfWork.Repository<Services>().GetAllInclude(s => s.Category).SingleOrDefault(s => s.Id == id);
            if (ServicesVM.Services == null)
            {
                return NotFound();
            }
            ServicesVM.Categories = _unitOfWork.Repository<Category>().GetAll();
            return View(ServicesVM);
        }
        
        public async Task<IActionResult> Delete(int id)
        {
            var serviceFromDb = await _unitOfWork.Repository<Services>().GetByIdAsync(id);
            if (serviceFromDb == null) return NotFound();
            await _unitOfWork.Repository<Services>().DeleteAsync(serviceFromDb);

            return RedirectToAction("Index");
        }
    }
}