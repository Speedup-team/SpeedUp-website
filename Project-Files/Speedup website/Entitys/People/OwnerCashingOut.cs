using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Speedup_website.Entitys.People;
public class OwnerCashingOut
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }

    [Required]
    public int owner_id { get; set; }

    [Required]
    public int cashingType_id { get; set; }

    [ForeignKey(nameof(owner_id))]
    public Owner? owner { get; set; }

    [ForeignKey(nameof(cashingType_id))]
    public CashingType? cashingType { get; set; }

    public DateTime createdAt { get; } = DateTime.Now;
    public DateTime? removedAt { get; set; } = null;
    public DateTime? modifiedAt { get; set; } = null;
}