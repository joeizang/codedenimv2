using Codedenim.Domain.Quiz;

namespace Codedenim.Domain
{
    public class TopicContent
    {
        public int TopicContentId { get; set; }
        public int TopicId { get; set; }
        public string TopicDescription { get; set; }
        public virtual Topic Topic { get; set; }
    }
}