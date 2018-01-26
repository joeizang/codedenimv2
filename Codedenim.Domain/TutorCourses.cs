using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain
{
    public class TutorCourse
    {
        [Key]
        public int TutorCoursesId { get; set; }
        public string TutorId { get; set; }
        public int CourseId { get; set; }
        public virtual  Tutor Tutor { get; set; }
        public virtual Course Courses { get; set; }
    }

}

