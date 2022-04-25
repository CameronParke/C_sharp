using System;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class LoginUser
    {
        [Key]

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string LogEmail {get;set;}

        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        [DataType(DataType.Password)]
        public string LogPassword {get;set;}
    }
}