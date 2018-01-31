using Codedenim.Domain.Assesment;
using Codedenim.Domain.CBTE;
using Codedenim.Domain.Forums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain
{
    public class Student : Person
    {
        [Key]
        public string StudentId { get; set; }

        [StringLength(50)]
        public string MatricNo { get; set; }

        [StringLength(50)]
        public string CallUpNo { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Enrollment Date")]
        public DateTimeOffset EnrollmentDate { get; set; }

        public bool Active { get; set; }

        [StringLength(5)]
        public string Title { get; set; }

        [StringLength(15)]
        public string AccountType { get; set; }

        public bool IsGraduated { get; set; }

        [StringLength(50)]
        public string Institution { get; set; }

        [StringLength(50)]
        public string StateOfService { get; set; }

        [StringLength(30)]
        public string Batch { get; set; }

        [StringLength(50)]
        public string Discpline { get; set; }
        
        //  public virtual ICollection<File> Files { get; set; }

        public virtual ICollection<SubmitAssignment> SubmitAssignments { get; set; }
        public virtual ICollection<StudentTestLog> StudentTestLogs { get; set; }
        public virtual ICollection<StudentQuestion> StudentQuestions { get; set; }
        public virtual ICollection<StudentAssesment> StudentAssesments { get; set; }
        public virtual ICollection<StudentAssignedCourse> AssignedCourses { get; set; }
        public virtual ICollection<ForumQuestion> ForumQuestions { get; set; }
        public virtual ICollection<StudentPayment> StudentPayments { get; set; }
    }
}