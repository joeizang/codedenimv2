using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codedenim.Domain
{
    public class FilePath
    {
        [Key]
        public int FilePathId { get; set; }

        [StringLength(300)]
        [Required]
        public string FileName { get; set; }
        public FileType FileType { get; set; }
        public int TutorId { get; set; }
        public virtual Tutor Tutor { get; set; }
    }
}
