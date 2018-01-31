using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Codedenim.Domain.Quiz;
using Microsoft.AspNetCore.Http;

namespace Codedenim.Domain
{
    public class TopicAssignment
    {
        [Key]
        public int TopicAssignmentId { get; set; }
        public int TopicId { get; set; }

        [StringLength(100)]
        [Required]
        [DataType(DataType.Text)]
        public string AssignmentTitle { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(300)]
        public string AssignmentDescription { get; set; }

        [DataType(DataType.DateTime)]
        public DateTimeOffset? AssignmentDueDate { get; set; }
        public virtual Topic Topic { get; set; }
    }

    public class SubmitAssignment
    {
        [Key]
        public int SubmitAssignmentId { get; set; }
        public int TopicId { get; set; }
        public string StudentId { get; set; }
        public string AssignmentBody { get; set; }
        public string AttachmentLocation { get; set; }

        [NotMapped]
        public IFormFile File { get; set; }

        public virtual Student Student { get; set; }
        public virtual Topic Topic { get; set; }
        public virtual ICollection<AssignmentReview> AssignmentReviews { get; set; }
    }

    public class AssignmentReview
    {
        [Key]
        public int AssignmentReviewId { get; set; }
        public int SubmitAssignmentId { get; set; }
        public string ReviewComment { get; set; }
        public string Rating { get; set; }
        public virtual SubmitAssignment SubmitAssignment { get; set; }
    }
}