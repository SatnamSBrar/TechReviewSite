using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechReviewMVC.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }   //set ID for Reviews

        public string ReviewTitle { get; set; }     //Model attributes
        public string ReviewBody { get; set; }
        [Display(Name ="Publish Date: ")]           //set Date to be named "Publish Date: "
        public DateTime Date { get; set; }
        public string Author { get; set; }

        [ForeignKey("Category")]            //call in ID for Categories
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}