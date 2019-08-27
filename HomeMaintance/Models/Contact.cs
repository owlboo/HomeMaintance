using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeMaintance.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Họ tên")]
        public string Name { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Display(Name = "Lời nhắn")]
        public string Message { get; set; }
    }
}
