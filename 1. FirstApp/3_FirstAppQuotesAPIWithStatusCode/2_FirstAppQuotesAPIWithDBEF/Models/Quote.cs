using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuotesThreeAPI.Models
{
    public class Quote
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Title { get; set; }
        [Required]
        [MinLength(20)]
        public string Author { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        [Required]
        public string type { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
    }
}