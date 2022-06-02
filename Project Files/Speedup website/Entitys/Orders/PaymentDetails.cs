using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Speedup_website.Entitys.Orders
{
    public class PaymentDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public int order_id { get; set; }

        [Range(0,9999999999)]
        public decimal price { get; set; }

        [Required]
        public int cashingType_id { get; set; }

        [StringLength(15)]
        public string status { get; set; } = string.Empty;

        [Required]
        public DateTime createdAt { get; set; } = DateTime.Now;

        public DateTime? modifiedAt { get; set; } = null;


        [ForeignKey(nameof(order_id))]
        public OrderDetails? orderDetails { get; set; }

        [ForeignKey(nameof(cashingType_id))]
        public People.CashingType? cashingType { get; set; }
    }
}