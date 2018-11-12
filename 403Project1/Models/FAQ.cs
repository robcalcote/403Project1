using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _403Project1.Models
{
    public class FAQ
    {
        [Required(ErrorMessage = "Please enter your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the location")]
        public int Location { get; set; }

        [Required(ErrorMessage = "Please enter a question")]
        public string Question { get; set; }
    }
}