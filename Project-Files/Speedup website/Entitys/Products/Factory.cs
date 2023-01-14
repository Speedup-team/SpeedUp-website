using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Speedup_website.Entitys.Products
{
    public class Factory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; } = string.Empty;

        [Column(TypeName = "ntext")]
        public string description { get; set; } = string.Empty;

        [Required]
        public DateTime createdAt { get; } = DateTime.Now;

        public DateTime? removedAt { get; set; } = null;

        public DateTime? modifiedAt { get; set; } = null;

        public List<Product>? products { get; set; } = null;
    }
}