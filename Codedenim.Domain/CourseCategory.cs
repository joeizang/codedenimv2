using System.Collections.Generic;

namespace Codedenim.Domain
{
    public class CourseCategory
    {
        public int CourseCategoryId { get; set; }
        public string CategoryName { get; set; }
        public decimal Amount { get; set; }
        public string StudentType { get;set; }
        public string CategoryDescription { get; set; }
        public string ImageLocation { get; set; }
        public virtual ICollection<StudentPayment> StudentPayments { get; set; }
        public virtual ICollection<EnrollForCourse> EnrollForCourse { get; set; }
       }
}