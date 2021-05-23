using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
//using Pagination.Validation;

namespace Pagination.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int Code { get; set; }
        [Required(ErrorMessage ="Please enter the product name.")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Cost { get; set; }
        [Required(ErrorMessage ="Testing pricing modeling controlling etcing.")]
        [Range(500,1000, ErrorMessage = "You must enter the product price between 500 to 1000.")]
        public int Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
