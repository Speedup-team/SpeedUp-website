using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Speedup_website.Entitys.Orders
{
    public class ShoppingSassion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public int guest_id { get; set; }

        [Range(0,9999999)]
        public decimal total { get; set; }

        [Required]
        public DateTime createdAt { get; set; } = DateTime.Now;

        public DateTime? modifiedAt { get; set; } = null;

        [ForeignKey(nameof(guest_id))]
        public People.User? user { get; set; }
        public IList<CartItem>? items { get; set; }
    }
}