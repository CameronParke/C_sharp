using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleLoginRegistration.Models
{
    public class IndexViewModel
    {
        public LogUser NewLogIn {get;set;}
        public RegUser NewUser {get;set;}
    }
}