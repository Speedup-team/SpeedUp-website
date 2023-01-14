using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Speedup_website.Entitys.Products
{
    public class Inventory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public int quantity { get; set; } = 0;

        [Required]
        [StringLength(10)]
        public string sku { get; set; } = string.Empty;

        [Required]
        public DateTime createdAt { get; } = DateTime.Now;

        public DateTime? removedAt { get; set; } = null;

        public DateTime? modifiedAt { get; set; } = null;

        public Product? product { get; set; }
    }
}