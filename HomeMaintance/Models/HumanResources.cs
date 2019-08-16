using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeMaintance.Models
{
    public class HumanResources
    {
        public int Id { get; set; }
        public string Avatar { get; set; }
        public string PersonName { get; set; }
        public string Role { get; set; }
        public int ExperienceYears { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
