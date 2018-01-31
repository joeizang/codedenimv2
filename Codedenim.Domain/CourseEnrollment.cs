using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain
{
    public class CourseEnrollment
    {
        [Key]
        public int CourseEnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public bool HasStartCourse { get; set; }
        public bool HasEndCourse { get; set; }
        public virtual Student Student { get;set; }
        public virtual Course Course { get; set; }

        
    }
}
