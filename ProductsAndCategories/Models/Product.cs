using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ProductsAndCategories.Models
{
    public class Product
    {
        [Key]
        public int ProductId {get; set;}

        [Required(ErrorMessage = "Name is required")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters")]
        public string Name {get; set;}

        [Required(ErrorMessage = "Description is required")]
        [MinLength(8, ErrorMessage = "Description must be at least 8 characters")]
        public string Description {get; set;}

        [Required(ErrorMessage = "Price is required")]
        [DataType(DataType.Currency)]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than $0.00")]
        public double Price {get; set;}

        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        public List<Association> CategoryTypes {get; set;}
    }
}