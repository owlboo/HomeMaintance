using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeMaintance.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Họ tên")]
        public string SenderName { get; set; }
        [Display(Name = "Nội dung")]
        public string Content { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime CreatedDate { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Phone]
        [Display(Name = "Số điện thoại")]
        public string Phone { get; set; }

    }
}
