using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _403Project1.Models
{
    // SchoolQuestion Table
    [Table("SchoolQuestion")]
    public class SchoolQuestion
    {
        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Question ID")]
        public int QuestionID { get; set; }

        // Link to the Schools Table
        [Required(ErrorMessage = "School ID is required.")]
        [DisplayName("School ID")]
        [ForeignKey("school")]
        public int SchoolID { get; set; }
        public virtual School school { get; set; }

        // Link to the Parent Table
        [Required(ErrorMessage = "Parent ID is required.")]
        [DisplayName("Parent ID")]
        [ForeignKey("parent")]
        public int ParentID { get; set; }
        public virtual Parent parent { get; set; }

        [Required(ErrorMessage = "A Question is required.")]
        [StringLength(500, ErrorMessage = "Question must not exceed 500 characters.")]
        [DisplayName("Question")]
        public string Question { get; set; }

        [StringLength(500, ErrorMessage = "Answer must not exceed 500 characters.")]
        [DisplayName("Answer")]
        public string Answer { get; set; }
    }
}