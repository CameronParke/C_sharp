using System;
using System.ComponentModel.DataAnnotations;

namespace crudelicious
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}
        
        [Required(ErrorMessage = "Name of Dish is required")]
        public string Name {get;set;}

        [Required(ErrorMessage = "Name of Chef is required")]
        public string Chef {get;set;}

        [Required]
        [Range(1,5, ErrorMessage = "Tastiness is required")]
        public int Tastiness {get;set;}

        [Required(ErrorMessage = "Calories must be greater than 0")]
        [Range(1,int.MaxValue, ErrorMessage = "Calories must be greater than 0")]
        public int Calories {get;set;}

        [Required(ErrorMessage = "Description of Dish is required")]
        public string Description {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}