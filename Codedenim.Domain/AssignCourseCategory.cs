﻿namespace Codedenim.Domain
{
    public class AssignCourseCategory
    {

        public int AssignCourseCategoryId { get; set; }
        public int CourseId { get; set; }
        public int CourseCategoryId { get; set; }
        public virtual Course Courses { get; set; } 
        public virtual CourseCategory CourseCategory { get; set; }
        public virtual StudentAssignedCourse StudentAssignedCourse { get; set; }



    }
}
