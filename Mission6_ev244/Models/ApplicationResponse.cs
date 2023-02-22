using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission6_ev244.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
       
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }

        public string Lent_To { get; set; }

        [StringLength(25, ErrorMessage = "Message can be no longer than 25 characters")]
        public string Notes { get; set; }

        // Foreign Key Relationship
        [Required]
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
