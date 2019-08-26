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
        public string SenderName { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Phone] public string Phone { get; set; }

    }
}
