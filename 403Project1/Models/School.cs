using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _403Project1.Models
{
    // School Table
    [Table("School")]
    public class School
    {
        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("School ID")]
        public int SchoolID { get; set; }
        #region Links
        // Link back to the Student Table
        public virtual ICollection<Student> student { get; set; }
        // Link back to the SchoolQuestion Table
        public virtual ICollection<SchoolQuestion> schoolquestion { get; set; }
        #endregion

        [Required(ErrorMessage = "A School Name is required.")]
        [StringLength(30, ErrorMessage = "School Name must not exceed 30 characters.")]
        [DisplayName("School Name")]
        public string SchoolName { get; set; }

        [Required(ErrorMessage = "A School Address is required.")]
        [StringLength(30, ErrorMessage = "School Street Address must not exceed 30 characters.")]
        [DisplayName("School Street Address")]
        public string SchoolAddress { get; set; }

        [Required(ErrorMessage = "A School City is required.")]
        [StringLength(30, ErrorMessage = "School City must not exceed 30 characters.")]
        [DisplayName("School City")]
        public string SchoolCity { get; set; }

        [Required(ErrorMessage = "A School ZIP is required.")]
        [StringLength(30, ErrorMessage = "School ZIP must not exceed 30 characters.")]
        [DisplayName("School ZIP")]
        public string SchoolZIP { get; set; }

        [Required(ErrorMessage = "A School State is required.")]
        [StringLength(30, ErrorMessage = "School State must not exceed 30 characters.")]
        [DisplayName("School State")]
        public string SchoolState { get; set; }

        [Required(ErrorMessage = "A School Director Name is required.")]
        [StringLength(30, ErrorMessage = "School Director Name must not exceed 30 characters.")]
        [DisplayName("School Director Name")]
        public string DirectorName { get; set; }

        // BLOB DATA TYPE GOES HERE..........
    }
}