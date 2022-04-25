using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WeddingPlanner.Models
{
    public class Wedding
    {
        [Key]
        public int  WeddingId {get;set;}

        [Required(ErrorMessage = "Wedder One is required")]
        public string WedderOne {get;set;}

        [Required(ErrorMessage = "Wedder Two is required")]
        public string WedderTwo {get;set;}

        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        [DateCheck]
        // [Display(Name = "minDate")]
        public DateTime Date {get;set;}

        [Required(ErrorMessage = "Address is required")]
        public string Address {get; set;}

        public int UserId {get; set;}
        public User Planner {get; set;}
        
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Guest> GuestList {get; set;}
    }

    public class DateCheckAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime minDate = (DateTime)value;
            return minDate <= DateTime.Now ? new ValidationResult("Must be a future date") : ValidationResult.Success;
        }
    } 
}