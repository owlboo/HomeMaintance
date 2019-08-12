using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeMaintance.Models
{
    public class ApplicationUsers : IdentityUser
    {
        [Required]
        [Display(Name ="Full Name")]
        public string FullName { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public bool isAdmin { get; set; }
    }
}
