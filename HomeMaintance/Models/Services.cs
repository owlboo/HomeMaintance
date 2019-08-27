using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeMaintance.Models
{
    public class Services
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Tên dịch vụ")]
        public string ServiceName { get; set; }
        [Display(Name = "Ảnh chính")]
        public string Thumbnail { get; set; }
        [Display(Name = "Mô tả ngắn")]
        public string ShortDescription { get; set; }
        [Display(Name = "Mô tả")]
        public string Description { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; } //xem xét lại
        [Display(Name = "Ngày sửa")]
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; } //xem xét lại
        [Display(Name = "Tiêu đề")]
        public string MetaTitle { get; set; }
        [Display(Name = "Mô tả tiêu đề")]
        public string MetaDescription { get; set; }
        [Display(Name = "Tiêu đề quảng cáo")]
        public string SEOTitle { get; set; }
        [Display(Name = "Lượt xem")]
        public int ViewCount { get; set; }
        [Display(Name = "Hoàn thành")]
        public bool IsDone { get; set; }
        [Display(Name = "Hàng đầu")]
        public DateTime TopHot { get; set; }

        [Display(Name = "Mục")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
