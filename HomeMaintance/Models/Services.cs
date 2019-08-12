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
        public string ServiceName { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }

    }
}
