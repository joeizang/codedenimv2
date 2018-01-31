using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain
{
    public class CourseCategory
    {
        [Key]
        public int CourseCategoryId { get; set; }

        [Required]
        [StringLength(100)]
        [DataType(DataType.Text)]
        public string CategoryName { get; set; }

        [Range(typeof(decimal), "9.99","999999.99")]
        [Required]
        public decimal Amount { get; set; }

        [StringLength(50)]
        [Required]
        public string StudentType { get;set; }

        [StringLength(200)]
        public string CategoryDescription { get; set; }

        [StringLength(300)]
        public string ImageLocation { get; set; }
        public virtual ICollection<StudentPayment> StudentPayments { get; set; }
        public virtual ICollection<EnrollForCourse> EnrollForCourse { get; set; }
       }
}