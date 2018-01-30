using System;
using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain.BlogPost
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public int PostId { get; set; }
        public DateTime DateTime { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }

        public virtual Post Post { get; set; }
    }
}