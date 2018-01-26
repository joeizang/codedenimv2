using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain
{
    public class File
    {
        public int FileId { get; set; }
        [StringLength(355)]
        public string FileName { get; set; }
        [StringLength(100)]
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public FileType FileType { get; set; }
        public int TutorId { get; set; }
        public virtual Tutor Tutor { get; set; }
    }
}
