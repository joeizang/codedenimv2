using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain.BlogPost
{
    public class Tag
    {
        public Tag()
        {
            Posts = new HashSet<Post>();
        }

        [Key]
        public int TagId { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}