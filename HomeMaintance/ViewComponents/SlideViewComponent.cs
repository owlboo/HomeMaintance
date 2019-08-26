using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeMaintance.Models;
using HomeMaintance.Reposity;
using Microsoft.AspNetCore.Mvc;

namespace HomeMaintance.ViewComponents
{
    public class SlideViewComponent:ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;

        public SlideViewComponent(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var lstSlide = await _unitOfWork.Repository<Slide>().GetAllAsync();
            return View("Slide", lstSlide);
        }
    }
}
