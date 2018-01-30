using System;
using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain.CBTE
{
    public class StudentTestLog
    {
        [Key]
        public int StudentTestLogId { get; set; }
        public string StudentId { get; set; }
    
        public int ModuleId { get; set; }
        public double Score { get; set; }
        public double TotalScore { get; set; }
        public bool ExamTaken { get; set; }
        public virtual Student Student { get; set; }

        public virtual Module Module { get; set; }
    }
}