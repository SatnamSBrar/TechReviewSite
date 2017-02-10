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
        public int ReviewID { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }


        public string ReviewTitle { get; set; }
        public string ReviewBody { get; set; }
        public DateTime Date { get; set; }
        public int Starred { get; set; }
    }
}