using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Speedup_website.Entitys.Orders
{
    public class CartItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public int session_id { get; set; }

        [Required]
        public int product_id { get; set; }

        [Required]
        public int quantity { get; set; }

        [Required]
        public DateTime createdAt { get; set; } = DateTime.Now;

        public DateTime? modifiedAt { get; set; } = null;


        [ForeignKey(nameof(session_id))]
        public ShoppingSassion? shoppingSassion { get; set; }

        [ForeignKey(nameof(product_id))]
        public Products.Product? Product { get; set; } = null;
    }
}