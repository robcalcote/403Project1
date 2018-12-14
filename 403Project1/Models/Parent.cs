using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _403Project1.Models
{
    // Parent Table
    [Table("Parent")]
    public class Parent
    {
        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Parent ID")]
        public int ParentID { get; set; }
        #region Links
        // Link back to the Student Table
        public virtual ICollection<Student> student { get; set; }
        // Link back to the SchoolQuestion Table
        public virtual ICollection<SchoolQuestion> schoolquestion { get; set; }
        #endregion

        [Required(ErrorMessage = "A Parent First Name is required.")]
        [StringLength(30, ErrorMessage = "Parent First Name must not exceed 30 characters.")]
        [DisplayName("Parent First Name")]
        public string PFirstName { get; set; }

        [Required(ErrorMessage = "A Parent Last Name is required.")]
        [StringLength(30, ErrorMessage = "Parent Last Name must not exceed 30 characters.")]
        [DisplayName("Parent Last Name")]
        public string PLastName { get; set; }
        
        [Required(ErrorMessage = "A Parent Email is required.")]
        [StringLength(30, ErrorMessage = "Parent Email must not exceed 30 characters.")]
        [DisplayName("Parent Email")]
        [EmailAddress]
        public string PEmail { get; set; }

        [Required(ErrorMessage = "A Parent Login Password is required.")]
        [StringLength(30, ErrorMessage = "Parent Login Password must not exceed 30 characters.")]
        [DisplayName("Parent Login Password")]
        public string PLogin { get; set; }
    }
}