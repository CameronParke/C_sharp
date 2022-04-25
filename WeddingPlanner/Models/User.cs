using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // this is needed to use [NotMapped] on Confirm Password
using System.Collections.Generic;

namespace WeddingPlanner.Models
{
    public class User
    {
        [Key]
        public int  UserId {get;set;}
        [Required(ErrorMessage = "First Name is required")]
        [MinLength(2, ErrorMessage = "First Name must be at least 2 characters")]
        public string FirstName {get;set;}

        [Required(ErrorMessage = "Last Name is required")]
        [MinLength(2, ErrorMessage = "Last Name must be at least 2 characters")]
        public string LastName {get;set;}

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email {get;set;}

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        public string Password {get;set;}
        
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Wedding> WeddingsBeingPlanned {get; set;}

        public List<Guest> WeddingAttendee {get; set;}

        [NotMapped]
        [Compare("Password", ErrorMessage = "Passwords must match")]
        [DataType(DataType.Password)]
        public string Confirm {get;set;}
    }
}