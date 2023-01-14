using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Speedup_website.Entitys.Products
{
    public class Catigory
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required, StringLength(200)]
        public string name { get; set; } = string.Empty;

        [Required, StringLength(25), Column("catigoryType")]
        public string type { get; set; } = "notSet";

        [Column(TypeName = "ntext")]
        public string description { get; set; } = string.Empty;

        [Required]
        public int owner_id { get; set; }

        [Required, StringLength(15)]
        public CatigoryState state { get; set; }

        [Required]
        public DateTime createdAt { get; set; } = DateTime.Now;

        public DateTime? removedAt { get; set; } = null;

        public DateTime? modifieAt { get; set; } = null;


        [ForeignKey(nameof(owner_id))]
        public People.Owner? owner { get; set; } = null;
        public IList<Product>? products { get; set; }
    }
}