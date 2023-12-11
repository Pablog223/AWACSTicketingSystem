using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AWACSTicketSystemWeb.Models
{
    public class LoginViewModel
    {
        [Key]
        public string WorkerID { get; set; }

        [Required(ErrorMessage = "A Name is required")]
        public string Username { get; set; }

        [Required(ErrorMessage ="An EMail is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "An Password is required")]
        [DataType(DataType.Password)]   
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Please confirm your password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }


    }
}