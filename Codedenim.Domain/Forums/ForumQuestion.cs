﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codedenim.Domain.Forums
{
    public class ForumQuestion
    {
        [Key]
        public int ForumQuestionId { get; set; }

        [StringLength(200)]
        [DataType(DataType.Text)]
        [Required]
        public string Title { get; set; }

        [StringLength(200)]
        [DataType(DataType.Text)]
        [Required]
        public string QuestionName { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Post Data")]
        public DateTime PostDate { get; set; }
        public int CourseId { get; set; }
        public string StudentId { get; set; }

        public virtual Forum Forum { get; set; }

        public virtual Student Students { get; set; }
        public virtual ICollection<ForumAnswer> ForumAnswers { get; set; }
        public  ForumQuestionView ForumQuestionView { get; set; }

    }

    public class ForumQuestionView
    {

        [Key, ForeignKey("ForumQuestion")]
        public int ForumQuestionId { get; set; }
        public int ViewCounter { get; set; }
        public virtual ForumQuestion ForumQuestion { get; set; }
    }




}
