using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeMaintance.Models
{
    public class TypicalConstruction
    {
        public int Id { get; set; }
        [Display(Name = "Tên dự án")]
        public string  Name { get; set; }
        [Display(Name = "Tên khách hàng")]
        public string CustomerName { get; set; }
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }
        [Display(Name = "Mô tả")]
        public string Description { get; set; }
        [Display(Name = "Ảnh đại diện")]
        public string Thumbnail { get; set; }
    }
}
