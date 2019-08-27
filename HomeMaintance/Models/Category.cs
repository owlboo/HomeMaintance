using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeMaintance.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Tên mục")]
        public string CategoryName { get; set; }
        [Display(Name = "Tiêu đề")]
        public string MetaTitle { get; set; }
        [Display(Name = "Tiêu đề quảng cáo")]
        public string SEOTitle { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; } //Xem xét
        [Display(Name = "Ngày sửa")]
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; } //Xem xét
        [Display(Name = "Từ khoá tiêu đề")]
        public string MetaKeyword { get; set; }
        [Display(Name ="Mô tả tiêu đề" )]
        public string MetaDescription { get; set; }

        public ICollection<Services> Services { get; set; }
    }
}
