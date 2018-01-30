﻿using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain.Assesment
{
    public class StudentAssesment
    {
        [Key]
        public int StudentAssesmentId { get; set; }
        public int CousreId { get; set; }
        public double TotalScore { get; set; }
        public int TotalQuestion { get; set; }
        public string StudentId { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}