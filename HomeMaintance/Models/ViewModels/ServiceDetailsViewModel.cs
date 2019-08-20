using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeMaintance.Models.ViewModels
{
    public class ServiceDetailsViewModel
    {
        public Services Services { get; set; }
        public Appointments Appointments { get; set; }

        public List<Services> ServicesTopView { get; set; }
    }
}
