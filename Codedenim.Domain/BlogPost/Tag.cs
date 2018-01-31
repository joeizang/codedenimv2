using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain.BlogPost
{
    public class Tag
    {
        public Tag()
        {
            PostTags = new List<PostTags>();
        }

        [Key]
        public int TagId { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        public ICollection<PostTags> PostTags { get; set; }
    }
}