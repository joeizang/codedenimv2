﻿using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain.Quiz
{
    public class TopicQuiz
    {
        [Key]
        public int TopicQuizId { get; set; }


        [Display(Name = "Topic Name")]
        [Required(ErrorMessage = "Topic Name is required")]
        public int TopicId { get; set; }

        [Display(Name = "Module Name")]
        [Required(ErrorMessage = "Module Name is required")]
        public int ModuleId { get; set; }

        [Display(Name = "Question")]
        [Required(ErrorMessage = "Question is required")]
        [DataType(DataType.MultilineText)]
        public string Question { get; set; }

        [Display(Name = "Option 1")]
        //[Required(ErrorMessage = "Option 1 is required")]
        [DataType(DataType.MultilineText)]
        public string Option1 { get; set; }

        [Display(Name = "Option 2")]
        //[Required(ErrorMessage = "Option 2 is required")]
        [DataType(DataType.MultilineText)]
        public string Option2 { get; set; }

        [Display(Name = "Option 3")]
        //[Required(ErrorMessage = "Option 3 is required")]
        [DataType(DataType.MultilineText)]
        public string Option3 { get; set; }

        [Display(Name = "Option 4")]
        // [Required(ErrorMessage = "Option 4 is required")]
        [DataType(DataType.MultilineText)]
        public string Option4 { get; set; }

        [Display(Name = "Answer")]
        [Required(ErrorMessage = "Answer is required")]
        [DataType(DataType.MultilineText)]
        public string Answer { get; set; }

        [Display(Name = "Question Hint")]
        public string QuestionHint { get; set; }

        [StringLength(200)]

        public string QuestionType { get; set; }

        [Display(Name = "Fill in the Gap")]
        public bool IsFillInTheGag
        {
            get
            {
                if (QuestionType.Trim().ToUpper().Equals("BLANKCHOICE"))
                {
                    return true;
                }
                return false;
            }
            private set { }
        }

        [Display(Name = "Multi-choice Answer")]
        public bool IsMultiChoiceAnswer
        {
            get
            {
                if (QuestionType.Trim().ToUpper().Equals("MULTICHOICE"))
                {
                    return true;
                }
                return false;
            }
            private set { }
        }

        public bool IsSingleChoiceAnswer
        {
            get
            {
                if (QuestionType.Trim().ToUpper().Equals("SINGLECHOICE"))
                {
                    return true;
                }
                return false;
            }
            private set { }
        }


        //public virtual Topic Topic { get; set; }
        public virtual Module Module { get; set; }
    }
}