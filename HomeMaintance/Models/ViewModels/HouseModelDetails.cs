using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeMaintance.Models.ViewModels
{
    public class HouseModelDetails
    {
        public HouseModels HouseModel { get; set; }
        public HouseModelCategory HouseModelCategory { get; set; }
        public ICollection<HouseModelImages> Images { get; set; }
    }
}
