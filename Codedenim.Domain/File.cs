using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain
{
    public class File
    {
        [Key]
        public int FileId { get; set; }

        [StringLength(355)]
        [Required]
        public string FileName { get; set; }

        [StringLength(100)]
        [Required]
        public string ContentType { get; set; }

        [Required]
        public byte[] Content { get; set; }
        public FileType FileType { get; set; }
        public int TutorId { get; set; }
        public virtual Tutor Tutor { get; set; }
    }
}
