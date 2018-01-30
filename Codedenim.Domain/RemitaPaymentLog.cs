using System;
using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain
{
    public class RemitaPaymentLog
    {
        [Key]
        public int RemitaPaymentLogId { get; set; }

        [StringLength(50)]
        public string OrderId { get; set; }

        [StringLength(50)]
        public string StatusCode { get; set; }

        [StringLength(50)]
        public string TransactionMessage { get; set; }

        [StringLength(100)]
        public string Rrr { get; set; }

        [StringLength(50)]
        public string PaymentName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTimeOffset PaymentDate { get; set; }

        [StringLength(20)]
        public string Amount { get; set; }

        [StringLength(50)]
        public string PayerName { get; set; }
    }
}
