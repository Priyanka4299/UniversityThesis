using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityThesis.Models
{
    [Table("Subjects")]
    public class Subject
    {
        [Display(Name = "Subject ID")]
        [Key]
        [Required]
        [MaxLength(5)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "int")]
        public int SubjectId { get; set; }


        [Display(Name = "Name of the Subject")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string SubjectName { get; set; }

        #region Navigation properties from faculty Model

        public ICollection<Faculty> Faculty { get; set; }
        #endregion
    }
}
