﻿using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain.CBTE
{
    public class QuizRule
    {
        [Key]
        public int QuizRuleId { get; set; }

        public int TopicId { get; set; }
        public int ModuleId { get; set; }

        [Display(Name = "Score per Question")]
        [Required(ErrorMessage = "Score per Question is required")]
        public double ScorePerQuestion { get; set; }

        [Display(Name = "Total Question")]
        [Range(1, 100)]
        [Required(ErrorMessage = "Total Question is required")]
        public int TotalQuestion { get; set; }

        [Display(Name = "Duration In Minute")]
        [Required(ErrorMessage = "Maximum Exam Time is required")]
        public int MaximumTime { get; set; }

        //public virtual Topic Topic { get; set; }
        public virtual Module Module { get; set; }
    }
}