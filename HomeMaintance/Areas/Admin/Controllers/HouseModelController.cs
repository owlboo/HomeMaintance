using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HomeMaintance.Models;
using HomeMaintance.Models.ViewModels;
using HomeMaintance.Reposity;
using HomeMaintance.Ultilities;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Mvc;

namespace HomeMaintance.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HouseModelController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly HostingEnvironment _hostingEnvironment;
        [BindProperty]
        public HouseModelViewModel HouseModelVM { get; set; }
        public HouseModelController(IUnitOfWork unitOfWork, HostingEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            HouseModelVM = new HouseModelViewModel
            {
                ModelCategories = _unitOfWork.Repository<HouseModelCategory>().GetAll().ToList(),
                HouseModel = new HouseModels()
            };
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            var houseModels = _unitOfWork.Repository<HouseModels>().GetAllInclude(c => c.HouseModelCategory).ToList();
            return View(houseModels);
        }
        public IActionResult Create()
        {
            return View(HouseModelVM);
        }
        [HttpPost]
        [ActionName("Create")]
        public async Task<IActionResult> CreatePost()
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            _unitOfWork.Repository<HouseModels>().Insert(HouseModelVM.HouseModel);
            await _unitOfWork.Commit();
            var files = HttpContext.Request.Form.Files;
            string webRootPath = _hostingEnvironment.WebRootPath;
            var houseModelFromDb = await _unitOfWork.Repository<HouseModels>().FindAsync(c => c.Id == HouseModelVM.HouseModel.Id);
            int i = 0;
            if (files.Count > 0)
            {
                //Upload Image
                foreach (var item in files)
                {
                    var uploads = Path.Combine(webRootPath, SD.HouseModelFolderImages);
                    var extension = Path.GetExtension(item.FileName);
                    var name = houseModelFromDb.HouseModelName;
                    if (i == 0)
                    {
                        name += "house-models-thumnail";
                    }
                    else
                    {
                        name += "house-models-" + i;
                    }                   
                    using (var filestream = new FileStream(Path.Combine(uploads, name+extension), FileMode.Create))
                    {
                        files[0].CopyTo(filestream);
                    }
                    HouseModelImages modelImages = new HouseModelImages
                    {
                        HouseModelId = HouseModelVM.HouseModel.Id,
                        ImageUrl = @"\" + SD.HouseModelFolderImages + @"\" + name + extension
                    };
                    _unitOfWork.Repository<HouseModelImages>().Insert(modelImages);
                    await _unitOfWork.Commit();
                    i++;
                }
                houseModelFromDb.ImageThumbnail = @"\" + SD.HouseModelFolderImages + @"\" + "house-models-thumnail" + Path.GetExtension(files[0].FileName);
            }
            await _unitOfWork.Commit();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            HouseModelVM.HouseModel = _unitOfWork.Repository<HouseModels>().GetAllInclude(c=>c.Id == id).FirstOrDefault() ;
            return View(HouseModelVM);
        }
    }
}