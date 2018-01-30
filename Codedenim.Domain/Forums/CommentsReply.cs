using System;
using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain.Forums
{
    public class CommentsReply
    {
        [Key]
        public int CommentsReplyId { get; set; }

        [StringLength(1000)]
        [Required]
        public string Reply { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Reply Date")]
        public DateTime ReplyDate { get; set; }
        public string UserId { get; set; }
        public int ForumCommentsId { get; set; }
        public virtual ForumComments ForumQuestionComments { get; set; }
    }
}