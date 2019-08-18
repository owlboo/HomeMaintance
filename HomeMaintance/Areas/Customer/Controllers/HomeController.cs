using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeMaintance.Models;
using HomeMaintance.Models.ViewModels;
using HomeMaintance.Reposity;
using Microsoft.AspNetCore.Mvc;

namespace HomeMaintance.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        [BindProperty]
        public HomeViewModel HomeVM { get; set; }
        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            HomeVM = new HomeViewModel();
        }
        public IActionResult Index()
        {
            HomeVM.Services = _unitOfWork.Repository<Services>().GetAll();
            HomeVM.HumanResources = _unitOfWork.Repository<HumanResources>().GetAll();


            return View(HomeVM);
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Service()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }
    }
}