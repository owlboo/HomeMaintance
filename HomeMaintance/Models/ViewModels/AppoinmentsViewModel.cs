using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeMaintance.Models.ViewModels
{
    public class AppoinmentsViewModel
    {
        public Appointments Appointments { get; set; }
        public IEnumerable<Users> SalePerson { get; set; }
    }
}
