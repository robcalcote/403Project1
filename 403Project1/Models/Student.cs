using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _403Project1.Models
{
    // Student Table
    [Table("Student")]
    public class Student
    {
        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Student ID")]
        public int StudentID { get; set; }
        
        // Link to the Parent Table
        [Required(ErrorMessage = "Parent ID is required.")]
        [DisplayName("Parent ID")]
        [ForeignKey("parent")]
        public int ParentID { get; set; }
        public virtual Parent parent { get; set; }

        [Required(ErrorMessage = "A Student First Name is required.")]
        [StringLength(30, ErrorMessage = "Student First Name must not exceed 30 characters.")]
        [DisplayName("Student First Name")]
        public string SFirstName { get; set; }

        [Required(ErrorMessage = "A Student Last Name is required.")]
        [StringLength(30, ErrorMessage = "Student Last Name must not exceed 30 characters.")]
        [DisplayName("Student Last Name")]
        public string SLastName { get; set; }

        [Required(ErrorMessage = "A Student Age is required.")]
        [DisplayName("Student Age")]
        public int SAge { get; set; }

        // Link to the Schools Table
        [Required(ErrorMessage = "Desired School ID is required.")]
        [DisplayName("Desired School ID")]
        [ForeignKey("school")]
        public int DesiredSchool { get; set; }
        public virtual School school { get; set; }
    }
}