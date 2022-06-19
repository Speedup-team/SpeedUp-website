using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Speedup_website.Entitys.Orders
{
    public class GuestShoppingSession
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public int guest_id { get; set; }

        [Required]
        [Range(0,9999999)]
        public decimal total { get; set; }

        [Required]
        public DateTime createdAt { get; set; } = DateTime.Now;

        public DateTime? modifiedAt { get; set; }

        [ForeignKey(nameof(guest_id))]
        public People.Guest guest { get; set; }
        public IList<GuestCartItem>? cartItems { get; set; }
    }
}
