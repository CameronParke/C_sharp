using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleLoginRegistration.Models
{
    public class RegUser
    {
        [Required(ErrorMessage = "You must enter a First Name")]
        [MinLength(2, ErrorMessage = "Your First Name must be at least 2 characters")]
        [Display(Name="First Name:")]
        public string FirstName {get;set;}

        [Required(ErrorMessage = "You must enter a Last Name")]
        [MinLength(2, ErrorMessage = "Your Last Name must be at least 2 characters")]
        [Display(Name="Last Name:")]
        public string LastName {get;set;}

        [Required(ErrorMessage = "You must enter a valid Email to Register")]
        [DataType(DataType.EmailAddress), ]
        [Display(Name="Email:")]
        public string Email {get;set;}
        
        [Required(ErrorMessage = "You must enter a Password to Register")]
        [MinLength(8, ErrorMessage = "Your Password must be at least 8 characters")]
        [DataType(DataType.Password)]
        [Display(Name="Password:")]
        public string Password {get;set;}

        [Required(ErrorMessage = "You must Confirm your Password")]
        [DataType(DataType.Password)]
        [Display(Name="Confirm Password:")]
        [Compare("Password", ErrorMessage ="The Passwords entered do not a match")]
        public string ConfirmPassword {get;set;}
    }
}
