using System;
using System.ComponentModel.DataAnnotations; // brings in ability for validations

namespace DojoSurveyValidations.Models
{
    public class User
    {
        [Required] // tried to also require DataType be text with [DataType(DataType.Text)] to prevent numbers from being written in name, but wouuld not prevent numbers from being used in name input
        [MinLength(2, ErrorMessage = "Your name must be at least 2 characters")]
        [DataType(DataType.Text)]
        public string name {get;set;}

        
        [MinLength(20, ErrorMessage = "Your comment must be at least 20 characters")]
        public string comment {get;set;}
        
        [Required(ErrorMessage = "You must choose a Dojo location")]
        public string location {get;set;}

        [Required(ErrorMessage = "You must choose a favorite language")]
        public string language {get;set;}
    }
}