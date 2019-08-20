using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeMaintance.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string SenderName { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
