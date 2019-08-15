using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeMaintance.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string MetaTitle { get; set; }
        public string SEOTitle { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; } //Xem xét
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; } //Xem xét
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }

        public ICollection<Services> Services { get; set; }
    }
}
