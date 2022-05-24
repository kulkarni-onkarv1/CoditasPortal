using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace CoditasPortal.Models
{
    public class RegisterUser
    {
        [Required(ErrorMessage = "Please enter your valid email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Remote(action:"IsUserNameAvailable", controller:"UserAuthentication",HttpMethod ="POST",ErrorMessage = "Mail ID is Already Registered")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please choose user name")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please mention your first name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please mention your last name")]
        public string LastName { get; set; }
        public string Gender { get; set; }
        [Required(ErrorMessage ="Please mention your date of birthday")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }
        [Required(ErrorMessage = "Please enter your active mobile no.")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage ="Mandatory Field")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [Display(Name = "Password")]
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Passwords must be at least 8 characters and contain at 3 of 4 of the following: upper case (A-Z), lower case (a-z), number (0-9) and special character (e.g. !@#$%^&*)")]
        public string Password { get; set; }

        //[Remote(action: "CheckPasswordMatch", controller: "Authentication", HttpMethod = "POST", ErrorMessage = "Password and Confirm Password Does Not Match")]
        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        public string ConfirmPassword { get; set; }
    }
}
