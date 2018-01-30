using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain.Forums
{
    public class ForumAnswer
    {
        [Key]
        public int ForumAnswerId { get; set; }
        public string Answer { get; set; }
        public DateTime ReplyDate { get; set; }
        public int ForumQuestionId { get; set; }
        public string UserId { get; set; }
        public virtual ForumQuestion ForumQuestions { get; set; }
        public virtual ICollection<VoteForumAnswer> VoteForumAnswers { get; set; }
    }

    public class VoteForumAnswer
    {
        [Key]
        public int VoteForumAnswerId { get; set; }
        public int ForumAnswerId { get; set; }
        public Vote Vote { get; set; }
        public string UserId { get; set; }
        public virtual ICollection<ForumAnswer> ForumAnswers { get; set; }
    }

    public enum Vote
    {
        Like,Dislike
    }
}