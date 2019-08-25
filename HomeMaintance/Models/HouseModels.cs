using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeMaintance.Models
{
    public class HouseModels
    {
        public int Id { get; set; }
        public string HouseModelName { get; set; }
        public string ImageThumbnail { get; set; }
        public virtual ICollection<HouseModelImages> HouseModelImages { get; set; }
        public int HouseModelCategoryId { get; set; }
        public virtual HouseModelCategory GetHouseModelCategory { get; set; }
        public int ViewCount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? TopHot { get; set; }
    }
}
