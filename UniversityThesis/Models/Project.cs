using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;


namespace UniversityThesis.Models
{

    [Table("Projects")]
    public class Project
    {

        [Display(Name = "Project ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectId { get; set; }

        [Display(Name = "Title of the Project")]
        [Required]
        [StringLength(50)]
        [Column("varchar")]
        public string ProjectTitle { get; set; }

        [Display(Name = "Description of the Project")]
        [Required]
        [StringLength(50)]
        [Column("varchar")]
        public string ProjectDescription { get; set; }


        [Required]
        public int SubjectId { get; set; }


        [Required]
        public int UserId { get; set; }

        [Display(Name = " Start Date ")]
        [Required]

        public DateTime StartDate { get; set; }

        [Display(Name = " End Date ")]
        [Required]

        public DateTime EndDate { get; set; }

       /* 
Professor ID(FK to Faculty → UserID)(int)
Mentor ID(FK to Faculty → UserID)(int)
Completion Percentage */
        #region Navigation properties to the Subject Model

        public ICollection<Subject> Subjects { get; set; }
        #endregion

        #region Navigation properties to the Student Model

        public ICollection<Student> Students { get; set; }
        #endregion
       
    }
    
}
