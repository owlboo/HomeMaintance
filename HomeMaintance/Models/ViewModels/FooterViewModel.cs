using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeMaintance.Models.ViewModels
{
    public class FooterViewModel
    {
        public SystemConfig SystemConfigs { get; set; }
        public List<Services> Services { get; set; }
    }
}
