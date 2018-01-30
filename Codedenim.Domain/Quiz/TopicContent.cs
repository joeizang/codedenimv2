using System.ComponentModel.DataAnnotations;
using Codedenim.Domain.Quiz;

namespace Codedenim.Domain
{
    public class TopicContent
    {
        [Key]
        public int TopicContentId { get; set; }
        public int TopicId { get; set; }

        [StringLength(200)]
        [DataType(DataType.MultilineText)]
        public string TopicDescription { get; set; }
        public virtual Topic Topic { get; set; }
    }
}