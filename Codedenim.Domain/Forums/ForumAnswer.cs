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
        public virtual ICollection<ForumAnswerVoteForumAnswers> ForumAnswerVoteForumAnswers { get; set; }
    }

    public class VoteForumAnswer
    {
        [Key]
        public int VoteForumAnswerId { get; set; }
        public int ForumAnswerId { get; set; }
        public Vote Vote { get; set; }
        public string UserId { get; set; }
        public virtual ICollection<ForumAnswerVoteForumAnswers> ForumAnswerVoteForumAnswers { get; set; }
    }

    public class ForumAnswerVoteForumAnswers
    {
        public int ForumAnswerId { get; set; }

        public ForumAnswer ForumAnswer { get; set; }

        public int VoteForumAnswerId { get; set; }

        public VoteForumAnswer VoteForumAnswer { get; set; }

    }

    public enum Vote
    {
        Like,Dislike
    }
}