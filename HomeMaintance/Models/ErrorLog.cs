using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeMaintance.Models
{
    public class ErrorLog
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Exception { get; set; }
        public string Path { get; set; }
    }
}
