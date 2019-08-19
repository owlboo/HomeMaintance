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

        public string Thumbnail { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; } //xem xét lại
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; } //xem xét lại
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string SEOTitle { get; set; }

        public int ViewCount { get; set; }

        public bool IsDone { get; set; }

        public int LikeCount { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
