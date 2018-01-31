using System.ComponentModel.DataAnnotations;
using Codedenim.Domain.Quiz;

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

        public Topic Topic { get; set; }
        public Module Module { get; set; }
    }
}