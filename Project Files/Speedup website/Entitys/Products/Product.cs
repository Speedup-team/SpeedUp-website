using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Speedup_website.Entitys.Products
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required, StringLength(100)]
        public string name { get; set; } = string.Empty;

        [Column(TypeName = "ntext")]
        public string description { get; set; } = string.Empty;

        [StringLength(200)]
        public string? primaryImage { get; set; } = null;

        [Required]
        public int catigory_id { get; set; }

        [Required, StringLength(10)]
        public string sku { get; set; } = string.Empty;

        [Required, Range(0, 9999999)]
        public decimal price { get; set; } = 0;

        public int? discount_id { get; set; } = null;

        public int? inventory_id { get; set; } = null;

        public int? factory_id { get; set; } = null;

        [Required]
        public DateTime createdAt { get; } = DateTime.Now;

        public DateTime? removedAt { get; set; } = null;

        public DateTime? modifiedAt { get; set; } = null;


        [ForeignKey(nameof(factory_id))]
        public Factory? factory { get; set; }

        [ForeignKey(nameof(inventory_id))]
        public Inventory? inventory { get; set; }

        [ForeignKey(nameof(discount_id))]
        public Orders.Discount? discount { get; set; }

        [ForeignKey(nameof(catigory_id))]
        public Catigory? catigory { get; set; }

        public IList<ProductImage>? images { get; set; }
    }
}