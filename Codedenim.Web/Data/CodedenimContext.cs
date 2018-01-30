using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Codedenim.Domain;
using Codedenim.Domain.BlogPost;
using Codedenim.Domain.CBTE;
using Codedenim.Domain.Forums;
using Codedenim.Domain.Quiz;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Codedenim.Web.Models;

namespace Codedenim.Web.Data
{
    public class CodedenimContext : IdentityDbContext<ApplicationUser>
    {
        public CodedenimContext(DbContextOptions<CodedenimContext> options)
            : base(options)
        {
        }

        public DbSet<CourseCategory> CourseCategories { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Module> Modules { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<TopicMaterialUpload> TopicMaterialUploads { get; set; }
        public DbSet<File> Files { get; set; }

        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<TutorCourse> TutorCourses { get; set; }

        public DbSet<QuizRule> QuizRules { get; set; }

        public DbSet<TopicQuiz> TopicQuizs { get; set; }

        public DbSet<StudentTopicQuiz> StudentTopicQuizs { get; set; }
        public DbSet<QuizLog> QuizLogs { get; set; }

        public DbSet<StudentAssignedCourse> StudentAssignedCourses { get; set; }

        public DbSet<Forum> Fora { get; set; }

        public DbSet<ForumView> ForumViews { get; set; }

        public DbSet<ForumQuestion> ForumQuestions { get; set; }

        public DbSet<ForumQuestionView> ForumQuestionViews { get; set; }

        public DbSet<ForumAnswer> ForumAnswers { get; set; }

        public DbSet<CourseRating> CourseRatings { get; set; }
        
        public DbSet<PaymentType> PaymentTypes { get; set; }

        public DbSet<CorperEnrolledCourses> CorperEnrolledCourses { get; set; }

        public DbSet<AssignCourseCategory> AssignCourseCategories { get; set; }
        public DbSet<StudentPayment> StudentPayments { get; set; }

        public DbSet<RemitaPaymentLog> RemitaPaymentLogs { get; set; }

        public DbSet<EnrollForCourse> EnrollForCourses { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<Post>()
                .HasMany(p => p.Tags);
        }


    }
}
