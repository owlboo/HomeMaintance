using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeMaintance.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Services> Services { get; set; }
        public IEnumerable<HumanResources> HumanResources { get; set; }

        public Feedback Feedback { get; set; }
        public SystemConfig SystemConfig { get; set; }
    }
}
