using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Key]
        public int PostId { get; set; }

        [StringLength(200)]
        [Required]
        [DataType(DataType.Text)]
        public string Title { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTimeOffset PostDate { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(1000)]
        [Required]
        public string Body { get; set; }
        public int TopicId { get; set; }
        public string TutorId { get; set; }
        public virtual Tutor Tutor { get; set; }
        public virtual Topic Topic { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        public ICollection<PostTags> PostTags { get; set; }
    }
}