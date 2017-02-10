using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TechReviewMVC.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Display(Name = "Category")]
        public string CategoryName { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}