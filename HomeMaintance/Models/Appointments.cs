using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HomeMaintance.Models
{
    public class Appointments
    {
        public int Id { get; set; }
        public string AppointmentsName { get; set; }
        public string AppointmentContent { get; set; }
        public DateTime AppointmentDate { get; set; }
        [NotMapped]
        public DateTime AppointmentTime { get; set; }
        [Display(Name ="Sale Person")]
        public string SalePersonId { get; set; }
        public virtual ApplicationUsers SalePerson { get; set; }
        public bool isConfirm { get; set; }
    }
}
