using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Web;
using Codedenim.Domain.Assesment;
using Codedenim.Domain.Forums;
using Microsoft.AspNetCore.Http;

namespace Codedenim.Domain
{
    public class Course
    {
        public int CourseId { get; set; }
        //public int CourseCategoryId { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        //public string CoursePrice { get; set; }
        public int ExpectedTime { get; set; }
        public DateTime? DateAdded { get; set; }

        public int Points { get; set; }
        public byte[] CourseImage { get; set; }
        public string FileLocation { get; set; }

        [Display(Name = "Upload A Passport/Picture")]
        [ValidateFile(ErrorMessage = "Please select a PNG/JPEG image smaller than 20kb")]
        [NotMapped]
        public IFormFile FormFile
        {
            get { return null; }

            set
            {
                try
                {
                    var target = new MemoryStream();
                    if (value.OpenReadStream() == null)
                        return;
                    value.OpenReadStream().CopyToAsync(target);
                    CourseImage = target.ToArray();
                }
                catch (Exception e)
                {
                    var message = e.Message;
                }
            }
        }


        //[NotMapped]
        //public HttpPostedFileBase File
        //{
        //    get
        //    {
        //        return null;
        //    }

        //    set
        //    {
        //        try
        //        {
        //            var target = new MemoryStream();

        //            if (value.InputStream == null)
        //                return;

        //            value.InputStream.CopyTo(target);
        //            CourseImage = target.ToArray();
        //        }
        //        catch (Exception ex)
        //        {
        //            var message = ex.Message;
        //        }
        //    }
        //}

        //public virtual CourseCategory CourseCategory { get; set; }
        //public virtual ICollection<Enrollment> Enrollments { get; set; }
        //public virtual Tutor Instructors { get; set; }
        public virtual ICollection<TutorCourse> TutorCourses { get; set; }
        public virtual ICollection<Module> Modules { get; set; }
        public virtual ICollection<AssesmentQuestionAnswer> AssesmentQuestionAnswers { get; set; }
        public virtual ICollection<StudentAssignedCourse> StudentAssignedCourses {get;set;}
        public virtual Forum Forum { get; set; }
        public virtual ICollection<CourseEnrollment> CourseEnrollments { get; set; }
        
    }
}