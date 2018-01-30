

using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain.Quiz
{
    public class StudentTopicQuiz
    {
        [Key]
        public int StudentTopicQuizId { get; set; }
        public int StudentQuestionId { get; set; }
        public string StudentId { get; set; }
        //public int TopicId { get; set; }
        public int ModuleId { get; set; }

        [StringLength(300)]
        [Required]
        [DataType(DataType.MultilineText)]
        public string Question { get; set; }

        [StringLength(300)]
        [Required]
        [DataType(DataType.Text)]
        public string Option1 { get; set; }

        [StringLength(300)]
        [Required]
        [DataType(DataType.Text)]
        public string Option2 { get; set; }

        [StringLength(300)]
        [Required]
        [DataType(DataType.Text)]
        public string Option3 { get; set; }

        [StringLength(300)]
        [Required]
        [DataType(DataType.Text)]
        public string Option4 { get; set; }
        public bool Check1 { get; set; }
        public bool Check2 { get; set; }
        public bool Check3 { get; set; }
        public bool Check4 { get; set; }

        [StringLength(500)]
        [Required]
        [DataType(DataType.Text)]
        public string FilledAnswer { get; set; }

        [StringLength(300)]
        [Required]
        [DataType(DataType.Text)]
        public string Answer { get; set; }

        [StringLength(300)]
        [Required]
        [DataType(DataType.Text)]
        public string QuestionHint { get; set; }
        public int QuestionNumber { get; set; }
        public bool IsCorrect { get; set; }
        public bool IsFillInTheGag { get; set; }
        public bool IsMultiChoiceAnswer { get; set; }

        [StringLength(300)]
        [Required]
        [DataType(DataType.Text)]
        public string SelectedAnswer { get; set; }
        public int TotalQuestion { get; set; }

        public int ExamTime { get; set; }

        public virtual Student Student { get; set; }
        //public virtual Topic Topic { get; set; }
        public virtual Module Module { get; set; }

    }
}