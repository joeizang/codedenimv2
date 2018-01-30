using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Codedenim.Domain.CBTE;
using Codedenim.Domain.Quiz;

namespace Codedenim.Domain
{
    public class Module
    {
        [Key]
        public int ModuleId { get; set; }
        public int CourseId { get; set; }
        public string ModuleName { get; set; }
        public string ModuleDescription { get; set; }
        public int ExpectedTime { get; set; }
        public virtual Course Course { get; set; }
        public virtual ICollection<Topic> Topics { get; set; }
        public virtual ICollection<StudentTestLog> StudentTestLogs { get; set; }
    }
}