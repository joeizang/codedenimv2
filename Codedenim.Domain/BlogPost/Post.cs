using System;
using System.Collections.Generic;
using Codedenim.Domain.Quiz;

namespace Codedenim.Domain.BlogPost
{
    public class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
            Tags = new HashSet<Tag>();
        }

        public int PostId { get; set; }
        public string Title { get; set; }
        public DateTime DateTime { get; set; }
        public string Body { get; set; }
        public int TopicId { get; set; }
        public string TutorId { get; set; }
        public virtual Tutor Tutor { get; set; }
        public virtual Topic Topic { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}