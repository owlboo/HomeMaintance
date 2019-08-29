using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeMaintance.Models;
using HomeMaintance.Models.ViewModels;
using HomeMaintance.Reposity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeMaintance.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AppointmentsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        [BindProperty]
        public AppoinmentsViewModel AppointmentsVM { get; set; }
        public AppointmentsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            AppointmentsVM = new AppoinmentsViewModel
            {
                SalePerson = _unitOfWork.Repository<Users>().GetAll()
            };
        }
        public IActionResult Index(bool filter)
        {
            
            var lstAppointments = new List<Appointments>();
            if (!filter)
            {
                lstAppointments = _unitOfWork.Repository<Appointments>().GetAllInclude(c => c.SalePerson).OrderByDescending(c => c.CreatedDate).ToList();
            }
            else
            {
                lstAppointments = _unitOfWork.Repository<Appointments>().GetAllInclude(c => c.SalePerson).Where(c=>c.isConfirm==false).OrderByDescending(c => c.CreatedDate).ToList();

            }
            return View(lstAppointments);
        }
        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            AppointmentsVM.Appointments = _unitOfWork.Repository<Appointments>().Find(c => c.Id == id);
            return View(AppointmentsVM);
        }
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int id)
        {
            if(id != AppointmentsVM.Appointments.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                if(AppointmentsVM.Appointments.AppointmentDate != null)
                {
                    AppointmentsVM.Appointments.AppointmentDate = AppointmentsVM.Appointments.AppointmentDate.Value.AddHours(AppointmentsVM.Appointments.AppointmentTime.Value.Hour)
                                                                                                                    .AddMinutes(AppointmentsVM.Appointments.AppointmentTime.Value.Minute);
                }
                var appFromDb = await _unitOfWork.Repository<Appointments>().FindAsync(a => a.Id == id);
                appFromDb.SalePersonId = AppointmentsVM.Appointments.SalePersonId;
                appFromDb.AppointmentContent = AppointmentsVM.Appointments.AppointmentContent;
                appFromDb.AppointmentDate = AppointmentsVM.Appointments.AppointmentDate;
                appFromDb.CustomerName = AppointmentsVM.Appointments.CustomerName;
                appFromDb.CustomerPhone = AppointmentsVM.Appointments.CustomerPhone;
                appFromDb.CustomerEmail = AppointmentsVM.Appointments.CustomerEmail;
                appFromDb.CustomerMessage = AppointmentsVM.Appointments.CustomerMessage;
                appFromDb.isConfirm = AppointmentsVM.Appointments.isConfirm;
                await _unitOfWork.Commit();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

    }
}