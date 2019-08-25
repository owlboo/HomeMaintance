using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeMaintance.Models.ViewModels
{
    public class HouseModelViewModel
    {
        public HouseModels HouseModel { get; set; }
        public List<HouseModelCategory> ModelCategories { get; set; }
    }
}
