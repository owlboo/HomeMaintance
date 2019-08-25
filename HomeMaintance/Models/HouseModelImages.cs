using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeMaintance.Models
{
    public class HouseModelImages
    {
        public int Id { get; set; }
        public long HouseModelId { get; set; }
        public virtual HouseModels HouseModels { get; set; }
        public string ImageUrl { get; set; }
    }
}
