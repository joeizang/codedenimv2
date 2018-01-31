using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain
{
    public class PaymentType
    {
        [Key]
        public int PaymentTypeId { get; set; }
        
        [DataType(DataType.Text)]
        [StringLength(100)]
        [Required]
        public string PaymentName { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "9.99","99999.99")]
        public decimal Amount { get; set; }

        [StringLength(50)]
        [Required]
        public string PaymentTypeValue { get; set; }
    }
}
