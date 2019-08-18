using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeMaintance.Models
{
    public class Users:IdentityUser
    {
        public string DisplayName { get; set; }
        public string Address { get; set; }
        public bool isMainAdmin { get; set; }
    }
}
