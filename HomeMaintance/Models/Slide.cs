using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeMaintance.Models
{
    public class Slide
    {
        public int Id { get; set; }
        [Display(Name = "Tên ảnh")]
        public string Name { get; set; }
        [Display(Name = "Ảnh")]
        public string Image { get; set; }
    }
}
