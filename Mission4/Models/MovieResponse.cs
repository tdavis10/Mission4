using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class MovieResponse
    {
        [Key]
        [Required]

        public int MovieID { get; set; }
        [Required(ErrorMessage = "Please Input a Category")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Please Input a Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please Input a Year")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Please Input a Director")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Please Input a Rating")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }
    }
}
