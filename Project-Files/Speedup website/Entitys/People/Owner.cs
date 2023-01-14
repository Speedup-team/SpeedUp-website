using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Speedup_website.Entitys.People
{
    public class Owner
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public int person_id { get; set; }

        [Required]
        [StringLength(15)]
        public OwnerState state { get; set; } = OwnerState.active;

        [Required]
        public DateTime createdAt { get; set; } = DateTime.Now;

        public DateTime? removedAt { get; set; } = null;
        public DateTime? modifiedAt { get; set; } = null;


        [ForeignKey(nameof(person_id))]
        public User? userDetails { get; set; }
        public IList<OwnerCashingOut>? ownerCashingOuts { get; set; }
        public IList<Products.Catigory>? categories { get; set; }
    }
}