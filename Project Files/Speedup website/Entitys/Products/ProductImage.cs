using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Speedup_website.Entitys.Products
{
    public class ProductImage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public int product_id { get; set; }

        [Required]
        public string image { get; set; } = string.Empty;

        [Required]
        public DateTime addedAt { get; set; } = DateTime.Now;

        public DateTime? removedAt { get; set; } = null;

        public DateTime? modifiedAt { get; set; } = null;


        [ForeignKey(nameof(product_id))]
        public Product? product { get; set; }
    }
}