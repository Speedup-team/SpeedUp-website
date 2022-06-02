using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Speedup_website.Entitys.People
{
    public class CashingType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(25)]
        public string cashingType { get; set; }= string.Empty;

        [StringLength(25)]
        public string? provider { get; set; } = null;

        [StringLength(200)]
        public string? link { get; set; } = null;

        public DateTime createdAt { get; } = DateTime.Now;
        public DateTime? removedAt { get; set; } = null;
        public DateTime? modifiedAt { get; set; } = null;
    }
}