using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ChefsNDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get;set;}

        [Required(ErrorMessage = "First Name is required")]
        public string FirstName {get;set;}
        
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName {get;set;}
        
        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date, ErrorMessage = "Date of Birth is required")]
        [CheckAge(18, "Chef must be at least 18 years old")]
        public DateTime DateOfBirth { get; set; }
        
        // Navigation property
        public List<Dish> RecipeBook {get;set;}
        
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        // Wanted to find the most optimal way to determine display of Chef age in Index
        // Not sure whether adding a public int Age to the Chef Model is what we are supposed to do here since our Form Inputs are only for Names and Date of Birth
        // Plus it is possible to extract the age from the Date Of Birth using DateTime.Today to measure the difference between the two.
        // The following are potential options for finding the age via these means, but I was not sure how to properly implement them to test if they work
        // Maybe they should live in the Home Controller?
        // I doubt the logic for displaying the age is supposed to happen in the front end, but it's all I could think of that works.

        // static string CalculateAge(DateTime DoB)
        // {
        //     DateTime Now = DateTime.Now;
        //     int Years = new DateTime(DateTime.Now.Subtract(DoB).Ticks).Year - 1;
        //     DateTime PastYearDate = DoB.AddYears(Years);
        //     int Months = 0;
        //     for(int i = 1; i <= 12; i++)
        //     {
        //         if(PastYearDate.AddMonths(i) == Now) {
        //             Months = i;
        //             break;
        //         } else {
        //             if (PastYearDate.AddMonths(i) >= Now) {
        //                 Months = i -1;
        //                 break;
        //             }
        //         }
        //     }
        //     int Days = Now.Subtract(PastYearDate.AddMonths(Months)).Days;
        //     return String.Format("{0}", Years);
        // }

    //     private static int FindAge (DateTime dateOfBirth)
    //     {
    //         int age = 0;
    //         age = DateTime.Now.Year - dateOfBirth.Year;
    //         if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear) {
    //             age = age - 1;
    //         }
    //         return age;
    //     }

    //     static int HowOld(DateTime BirthDate, DateTime now)
    //     {
    //         var year = now.Year - BirthDate.Year;
    //         if (now.Month < BirthDate.Month || now.Month == BirthDate.Month && now.Day < BirthDate.Day){
    //             year --;
    //         }
    //         return year;
    //     }
    }

    public class CheckAgeAttribute : ValidationAttribute
    {
        
        public CheckAgeAttribute(int ageMin, string response)
            : base()
        {
            _AgeMin = new TimeSpan(ageMin * 365 + (NumberOfLeapYears(2005, DateTime.Now.Year)), 0, 0, 0);
            _Response = response;
        }

        private static int NumberOfLeapYears(int startYear, int endYear)
        {
            int counter = 0;
            for (int year = startYear; year <= endYear; year++) counter += DateTime.IsLeapYear(year) ? 1 : 0;
            return counter;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            TimeSpan age = DateTime.Now - ((DateTime)value);
            if (age.CompareTo(_AgeMin) <= 0)
            {
                return new ValidationResult("Chef must be at least 18 years old");
            }
            return ValidationResult.Success;
        }
        private string _Response;
        private TimeSpan _AgeMin;
    }
}