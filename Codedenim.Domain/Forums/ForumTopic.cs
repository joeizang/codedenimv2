using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain.Forums
{
    public class ForumTopic
    {
        [Key]
        public int ForumTopicId { get; set; }

        [StringLength(300)]
        [Required]
        public string Title { get; set; }
        public int ViewCount { get; set; }
        public int PostCount { get; set; }
        public int Flag { get; set; }
        public int Type { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Last Posted")]
        public DateTime LastPosted { get; set; }
        public int LastPostId { get; }
        public int LastPostAuthorId { get; set; }

        [StringLength(50)]
        public string LastPostUsername { get; set; }
        public int ForumId { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Posted { get; set; }
        public int SpamScore { get; set; }
        public int SpamReporters { get; set; }
        public int OriginalTopicId { get; set; }
        public string CustomProperties { get; set; }

        public virtual ICollection<LatestPost> LatestPost { get; set; }
        public virtual ICollection<Forum> Forum { get; set; }
        
    }
}