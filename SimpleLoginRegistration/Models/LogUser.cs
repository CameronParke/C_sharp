using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleLoginRegistration.Models
{
    public class LogUser
    {
        [Required(ErrorMessage = "You must enter a valid Email to Login")]
        [DataType(DataType.EmailAddress)]
        [Display(Name="Email:")]
        public string Email {get;set;}

        [Required(ErrorMessage = "You must enter your Password to Login")]
        [MinLength(8, ErrorMessage = "Your Password must be at least 8 characters")]
        [DataType(DataType.Password)]
        [Display(Name="Password:")]
        public string Password {get;set;}
    }
}
