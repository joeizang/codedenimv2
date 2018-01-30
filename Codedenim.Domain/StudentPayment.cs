using System;
using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain
{
    /// <summary>
    /// Holds payment summary of every successful or failed payments from Remita
    /// </summary>
    public class StudentPayment
    {
        [Key]
        public int StudentPaymentId { get; set; }
        public string OrderId { get; set; }
        public int CourseCategoryId { get; set; }
        public string StudentId { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTimeOffset PaymentDateTime { get; set; }

        [Required]
        [Range(typeof(decimal), "9.99", "99999.99")]
        public decimal Amount { get; set; }
        public bool IsPayed { get; set; }

        [Required]
        [Range(typeof(decimal), "9.99", "99999.99")]
        public decimal AmountPaid { get; set; }

        [StringLength(20)]
        public string ReferenceNo { get; set; }

        [StringLength(20)]
        public string PaymentStatus { get; set; }
        public virtual Student Student { get; set; }
        public virtual CourseCategory CourseCategory { get; set; }
    }
}
