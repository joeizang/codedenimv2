﻿using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText = "No grade Assigned Yet, Complete the Coures")]
        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }

    //this specifies wether a student has passed or failed
    public enum Grade
    {
       Pass, Fail
    }
}
