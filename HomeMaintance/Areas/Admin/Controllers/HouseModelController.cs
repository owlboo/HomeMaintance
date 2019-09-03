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
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReflectionIT.Mvc.Paging;

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
        public IActionResult Index(int page = 1)
        {
            var houseModels = _unitOfWork.Repository<HouseModels>().GetAllInclude(c => c.HouseModelCategory)
                .OrderByDescending(h => h.CreatedDate).AsEnumerable();
            var model = PagingList.Create(houseModels, 5, page);

            return View(model);
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
                    var name = "";
                    if (i == 0)
                    {
                        name += "house-models-thumnail";
                    }
                    else
                    {
                        name += "house-models-" + i;
                    }
                    using (var filestream = new FileStream(Path.Combine(uploads, name + extension), FileMode.Create))
                    {
                        files[i].CopyTo(filestream);
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

            HouseModelVM.HouseModel = _unitOfWork.Repository<HouseModels>().GetSingleInclude(c => c.Id == id);
            HouseModelVM.Images = _unitOfWork.Repository<HouseModelImages>().FindAll(c => c.HouseModelId == id).ToList();
            return View(HouseModelVM);
        }


        [HttpPost]
        [ActionName("Edit")]
        public async Task<IActionResult> EditPost(int id)
        {
            if (id != HouseModelVM.HouseModel.Id)
            {
                return NotFound();
            }
            var houseModelFromDb = _unitOfWork.Repository<HouseModels>().FindAll(c => c.Id == id).FirstOrDefault();
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            if (files.Count > 0 && files[0] != null)
            {
                foreach (var item in files)
                {
                    var uploads = Path.Combine(webRootPath, SD.HouseModelFolderImages);
                    var extension = Path.GetExtension(item.FileName);
                    Random rand = new Random();
                    var name = "house-models-" + rand.Next(10, 99);

                    using (var filestream = new FileStream(Path.Combine(uploads, name + extension), FileMode.Create))
                    {
                        item.CopyTo(filestream);
                    }
                    HouseModelImages modelImages = new HouseModelImages
                    {
                        HouseModelId = HouseModelVM.HouseModel.Id,
                        ImageUrl = @"\" + SD.HouseModelFolderImages + @"\" + name + extension
                    };
                    _unitOfWork.Repository<HouseModelImages>().Insert(modelImages);
                    await _unitOfWork.Commit();
                }
            }


            houseModelFromDb.HouseModelName = HouseModelVM.HouseModel.HouseModelName;
            houseModelFromDb.HouseModelCategoryId = HouseModelVM.HouseModel.HouseModelCategoryId;
            houseModelFromDb.Description = HouseModelVM.HouseModel.Description;
            houseModelFromDb.ModifiedDate = HouseModelVM.HouseModel.ModifiedDate;
            await _unitOfWork.Commit();

            return RedirectToAction("Edit", new { id = HouseModelVM.HouseModel.Id });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteImage(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var imageFromDb = await _unitOfWork.Repository<HouseModelImages>().FindAsync(c => c.Id == id);
            if (imageFromDb == null)
            {
                return NotFound();
            }
            _unitOfWork.Repository<HouseModelImages>().Delete(imageFromDb);
            await _unitOfWork.Commit();
            return RedirectToAction("Edit", new { id = imageFromDb.HouseModelId });
        }
        [HttpPost]
        public async Task<IActionResult> ChangeThumbnail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var houseModelFromDb = await _unitOfWork.Repository<HouseModels>().FindAsync(c => c.Id == id);
            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            Random rand = new Random();
            if (files.Count != 0 && files[0] != null)
            {
                var uploads = Path.Combine(webRootPath, SD.HouseModelFolderImages);
                var extension = Path.GetExtension(files[0].FileName);
                var extension_old = Path.GetExtension(houseModelFromDb.ImageThumbnail);
                var name = "house-models-thumnail"+ rand.Next(10, 99);
                if (System.IO.File.Exists(Path.Combine(uploads, name + extension_old)))
                {
                    System.IO.File.Delete(Path.Combine(uploads, name + extension));
                }
                using (var filestream = new FileStream(Path.Combine(uploads, name +  extension), FileMode.Create))
                {
                    files[0].CopyTo(filestream);
                }
                houseModelFromDb.ImageThumbnail = @"\" + SD.HouseModelFolderImages + @"\" + name  + extension;
                await _unitOfWork.Commit();
                return RedirectToAction("Edit", new { id = houseModelFromDb.Id });
            }
            return RedirectToAction("Edit", new { id = houseModelFromDb.Id });
        }
    }
}