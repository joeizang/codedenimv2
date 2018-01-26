﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using Codedenim.Domain.Quiz;
using Microsoft.AspNetCore.Http;

namespace Codedenim.Domain
{
    public class TopicMaterialUpload
    {
       
        public int TopicMaterialUploadId { get; set; }
        public int TopicId { get; set; }
        public string Tutor { get; set; }
        public FileType FileType { get; set; }

        [Display(Name = "Material Name")]
        [Required(ErrorMessage = "Material Name is required")]
        public string Name { get; set; } //hide inherited property

        //[Display(Name = "Material Author")]
        //[Required(ErrorMessage = "Material Author is required")]
        //public string Author { get; set; }

        [Display(Name = " Short Description")]
        //[Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        public string FileLocation { get; set; }

        [NotMapped]
        public ICollection<IFormFile> Files { get; set; }

        public virtual Topic Course { get; set; }
        public virtual Tutor MaterialByTutor { get; set; }
    }
}