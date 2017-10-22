using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCReviewSiteProject.Models
{
    public class Reviews
    {
        public int ID { get; set; }
        [Display(Name = "Reviewer Name")]
        public string ReviewerName { get; set; }
        [Display(Name = "Gadget Reviewed")]
        public string GadgetReviewed { get; set; }
        [Display(Name = "Today's Date")]
        [DisplayFormat(DataFormatString = "{0:mm/dd/yyyy}")]
        public DateTime DateReviewed { get; set; }
        public string Review { get; set; }
        [Required(ErrorMessage = "A rating is required")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        [Display(Name = "Star Rating")]
        public int StarRating { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}