using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Speedup_website.Entitys.People;
    public class UserAddress
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }

    [Required]
    public int user_id { get; set; }

    [Required]
    [StringLength(200)]
    public string Address { get; set; } = string.Empty;

    [Required]
    [StringLength(20)]
    public string City { get; set; } = string.Empty;

    [Required]
    [StringLength(20)]
    public string country { get; set; } = string.Empty;

    public int? mobilePhone { get; set; } = null;

    public int? telephone { get; set; } = null;

    [Required]
    public bool isActive { get; set; }

    [Required]
    public DateTime createdAt { get; }= DateTime.Now;

    public DateTime removedAt { get; set; }

    public DateTime modifiedAt { get; set; }


    [ForeignKey(nameof(user_id))]
    public User? userData { get; set; }
}
