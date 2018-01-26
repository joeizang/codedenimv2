using System.Collections.Generic;

namespace Codedenim.Domain.BlogPost
{
    public class Tag
    {
        public Tag()
        {
            Posts = new HashSet<Post>();
        }

        public int TagId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}