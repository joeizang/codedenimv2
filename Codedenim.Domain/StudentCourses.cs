using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain
{
    public class StudentCourses
    {
        [Key]
        public int StudentCourseId { get; set; }
        public string StudentId { get; set; }
        public int CourseId { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Courses { get; set; }
    }
}
