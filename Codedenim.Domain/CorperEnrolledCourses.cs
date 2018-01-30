using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain
{
    //this table is for the enrollment of students and
    // not only corpers
    public class CorperEnrolledCourses
    {
        [Key]
        public int CorperEnrolledCoursesId { get; set; }
        public int CourseId { get; set; }

        [StringLength(50)]
        [Required]
        public string CorperCallUpNumber { get; set; }
        public string StudentId { get; set; }
        public int CourseCategoryId { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual Student Student { get; set; }
        public virtual CourseCategory Category { get; set; }
    }
}
