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
    public class SystemConfigsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly HostingEnvironment _hostingEnvironment;
        public SystemConfigsController(IUnitOfWork unitOfWork, HostingEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostingEnvironment = hostingEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            SystemConfig system = new SystemConfig();
            system = _unitOfWork.Repository<SystemConfig>().GetAll().FirstOrDefault();
            if(system == null)
            {
                system = new SystemConfig
                {
                    CompanyName = "",
                    CompanyPhone = "",
                    CompanyAddress = "",
                    CompanyEmail = "",
                    CompanyLogo = ""
                };
                _unitOfWork.Repository<SystemConfig>().Insert(system);
                await _unitOfWork.Commit();
                return View(system);
            }
            if (system.CompanyName == null || system == null)
            {
                system.CompanyName = "Chưa đặt";
            }
            if (system.CompanyPhone == null || system == null)
            {
                system.CompanyPhone = "Chưa đặt";
            }
            if (system.CompanyLogo == null || system == null)
            {
                system.CompanyLogo = "Chưa đặt";
            }
            if (system.CompanyEmail == null || system == null)
            {
                system.CompanyEmail = "Chưa đặt";
            }
            if (system.CompanyAddress == null || system == null)
            {
                system.CompanyAddress = "Chưa đặt";
            }
            return View(system);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateConfig(SystemConfig model)
        {

            if (!ModelState.IsValid)
            {
                return NotFound();
            }

            await _unitOfWork.Repository<SystemConfig>().UpdateAsync(model);
            await _unitOfWork.Commit();


            var webRootPath = _hostingEnvironment.WebRootPath;
           
            var files = HttpContext.Request.Form.Files;
            Random rand = new Random();
            string name = "logo"+rand.Next(10,99);
            var systemFromDb = _unitOfWork.Repository<SystemConfig>().Find(c => c.Id == model.Id);
            
            if(files.Count > 0)
            {
                var upload = Path.Combine(webRootPath, SD.SystemLogoFolder);
                var extension = Path.GetExtension(files[0].FileName);
                using(var filestream = new FileStream(Path.Combine(upload, name + extension), FileMode.Create))
                {
                    files[0].CopyTo(filestream);
                }
                systemFromDb.CompanyLogo = @"\" + SD.SystemLogoFolder + @"\" + name  + extension;
                await _unitOfWork.Commit();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}