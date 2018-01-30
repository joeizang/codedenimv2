using System.ComponentModel.DataAnnotations;

namespace Codedenim.Domain
{
    public class PaymentType
    {
        [Key]
        public int PaymentTypeId { get; set; }
        
        [DataType(DataType.Text)]
        [StringLength(100)]
        public string PaymentName { get; set; }
        public int Amount { get; set; }
        public string PaymentTypeValue { get; set; }
    }
}
