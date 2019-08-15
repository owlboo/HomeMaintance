using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeMaintance.Models.ViewModels
{
    public class ServiceViewModel
    {
        public Services Services { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
