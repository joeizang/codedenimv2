using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codedenim.Domain.Forums
{
    public class Forum
    {
        [Key,ForeignKey("Course")]
        public int CourseId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(300)]
        [Required]
        [Display(Name = "Forum Name")]
        public string ForumName { get; set; }

        [DataType(DataType.Text)]
        [StringLength(200)]
        public string Description { get; set; }
        
        [DataType(DataType.DateTime)]
        [Display(Name = "Last Posted")]
        public DateTime LastPosted { get; set; }
        
        [DataType(DataType.DateTime)]
        [Display(Name = "Creation Date")]
        public DateTime CreationDate { get; set; }

        public virtual Course Course { get; set; }
        public virtual ICollection<ForumQuestion> ForumQuestions { get; set; }
        public virtual ForumView ForumView { get; set; }
    }

    public class ForumView
    {
        [Key, ForeignKey("Forum")]
        public int ContentViewId { get; set; }
        public int ViewCounter { get; set; }
        public virtual Forum Forum { get; set; }
    }
}
