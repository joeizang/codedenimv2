using System;
using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain
{
    public class RemitaPaymentLog
    {
        [Key]
        public int RemitaPaymentLogId { get; set; }

        [StringLength(50)]
        [Required]
        public string OrderId { get; set; }

        [StringLength(50)]
        [Required]
        public string StatusCode { get; set; }

        [StringLength(50)]
        [Required]
        public string TransactionMessage { get; set; }

        [StringLength(100)]
        [Required]
        public string Rrr { get; set; }

        [StringLength(50)]
        [Required]
        public string PaymentName { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTimeOffset PaymentDate { get; set; }

        [StringLength(20)]
        [Required]
        public string Amount { get; set; }

        [StringLength(50)]
        [Required]
        public string PayerName { get; set; }
    }
}
