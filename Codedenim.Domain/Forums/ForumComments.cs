using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain.Forums
{
    public class ForumComments
    {
        [Key]
        public int ForumCommentsId { get; set; }
        public string Comment { get; set; }
        public string UserId { get; set; }
        public int ForumReplyIdP { get; set; }
        public virtual ICollection<ForumQuestion> ForumQeQuestion { get; set; }
    }
}