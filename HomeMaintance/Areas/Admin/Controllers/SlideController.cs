﻿using System;
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
    public class SlideController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly HostingEnvironment _hostingEnvironment;

        public SlideController(IUnitOfWork unitOfWork,HostingEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            var lstSlide = _unitOfWork.Repository<Slide>().GetAll();
            return View(lstSlide);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slide slide)
        {
            if (!ModelState.IsValid) return View();

            await _unitOfWork.Repository<Slide>().InsertAsync(slide);
            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            var slideFromDb = await _unitOfWork.Repository<Slide>().GetByIdAsync(slide.Id);
            if (files.Count != 0)
            {
                var uploads = Path.Combine(webRootPath, @"images/SlideImages");
                var extension = Path.GetExtension(files[0].FileName);
                Random rand = new Random();
                //var fileName = Path.Combine(uploads, slideFromDb.Name + extension);
                var fileName = "slide" + rand.Next(10, 99) + extension;
                using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                {
                    await files[0].CopyToAsync(fileStream);
                }

                slide.Image = Path.GetFileName(fileName);
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

            var slideFromDb = _unitOfWork.Repository<Slide>().GetById(id);

            return View(slideFromDb);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,Slide slide)
        {
            if (id != slide.Id) return NotFound();
            if (!ModelState.IsValid) return View(slide);

            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            var slideFromDb = await _unitOfWork.Repository<Slide>().GetByIdAsync(slide.Id);
            if (files.Count != 0)
            {
                var uploads = Path.Combine(webRootPath, @"images/SlideImages");
                var extension = Path.GetExtension(files[0].FileName);
                Random random = new Random();
                var fileName = "slidex-" + random.Next(10, 100) + extension;
                if (System.IO.File.Exists(Path.Combine(uploads, fileName)))
                {
                    System.IO.File.Exists(Path.Combine(uploads, fileName));
                }
                using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                {
                    await files[0].CopyToAsync(fileStream);
                }

                slide.Image = Path.GetFileName(fileName);
                
            }
            if (slide.Image != null)
            {
                slideFromDb.Image = slide.Image;
            }

            slideFromDb.Name = slide.Name;
            await _unitOfWork.Repository<Slide>().UpdateAsync(slideFromDb);

            return RedirectToAction("Index");
        }



        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();

            var slideFromDb = _unitOfWork.Repository<Slide>().GetById(id);

            return View(slideFromDb);
            
            
        }
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int id)
        {
            try
            {
                var slideFromDb = await _unitOfWork.Repository<Slide>().GetByIdAsync(id);
                if (slideFromDb == null) return NotFound();
                await _unitOfWork.Repository<Slide>().DeleteAsync(slideFromDb);

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                LogHelpers log = new LogHelpers();
                string path = "/Admin/Slide/Delete";
                log.WriteLogToDb(path, e.ToString());
                throw;
            }
        }
    }
}