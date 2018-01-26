﻿using System;

namespace Codedenim.Domain.CBTE
{
    public class StudentTestLog
    {
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