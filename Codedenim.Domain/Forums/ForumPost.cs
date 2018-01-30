using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codedenim.Domain.Forums
{
    public class ForumPost
    {
        [Key]
        public int ForumPostId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(200)]
        public string Subject { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Body { get; set; }

        [StringLength(12)]
        public string Ip { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ModifiedAt { get; set; }
        public int Flag { get; set; }

        [StringLength(300)]
        [DataType(DataType.Text)]
        public string EditReason { get; set; }

        [StringLength(300)]
        [DataType(DataType.Text)]
        public string DeletedReason { get; set; }
        public int ReplyToPost { get; set; }
        public int AuthorId { get; set; }

        [StringLength(50)]
        public string AuthorName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime PostedDate { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }
        public int ForumTopicId { get; set; }
        public virtual ICollection<ForumTopic> Forum { get; set; }
        
  



    }
}
