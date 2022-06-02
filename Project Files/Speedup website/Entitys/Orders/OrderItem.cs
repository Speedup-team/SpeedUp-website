using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Speedup_website.Entitys.Orders
{
    public class OrderItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public int order_id { get; set; }

        [Required]
        public int product_id { get; set; }

        [Range(0,9999999)]
        public decimal quantity { get; set; }


        [ForeignKey(nameof(order_id))]
        public OrderDetails? orderDetails { get; set; }

        [ForeignKey(nameof(product_id))]
        public Products.Product? Product { get; set; }
    }
}
