using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _403Project1.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "You must enter your first name")]
        [Display(Name = "Parent First Name")]
        public string CustFirstName { get; set; }

        [Required(ErrorMessage = "You must enter your last name")]
        [Display(Name = "Parent Last Name")]
        public string CustLastName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "You must enter your email address")]
        [Display(Name = "Email Address")]
        public string CustEmail { get; set; }

        [Required(ErrorMessage = "You must enter your child's first and last name")]
        [Display(Name = "Child's Full Name")]
        public string CustChildName { get; set; }

        [Required(ErrorMessage = "You must enter your child's age")]
        [Display(Name = "Child's Age")]
        public string CustChildAge { get; set; }

        [Required(ErrorMessage = "You must enter the school you would like to enroll your child in.")]
        [Display(Name = "Desired School Location")]
        public int CustSchoolLocation { get; set; } //just 3 schools, so 1 = lehi, 2 = riverton, 3 = gilbert
    }
}