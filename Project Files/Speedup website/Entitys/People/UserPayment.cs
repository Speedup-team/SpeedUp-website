using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Speedup_website.Entitys.People;
public class UserPayment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }

    [Required]
    public int user_id { get; set; }

    [ForeignKey(nameof(user_id))]
    public User? userDetailes { get; set; }

    [Required]
    public int paymentType_id { get; set; }

    [ForeignKey(nameof(paymentType_id))]
    public CashingType? cashingType { get; set; }

    public DateTime createdAt { get; } = DateTime.Now;
    public DateTime? removedAt { get; set; } = null;
    public DateTime? modifiedAt { get; set; } = null;
}