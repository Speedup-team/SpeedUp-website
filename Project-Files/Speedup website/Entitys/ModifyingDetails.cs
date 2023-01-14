using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Speedup_website.Entitys
{
    public class ModifyingDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(10)]
        public string tableName { get; set; } = string.Empty;

        [StringLength(100)]
        public string columnsChanged { get; set; } = string.Empty;

        [Required]
        public int row_id { get; set; }

        [Required]
        public DateTime modifyingDate { get; set; } = DateTime.Now;

        [Required]
        public string modifiedBy { get; set; } = string.Empty;

        [Required]
        public int modifier_id { get; set; }
    }
}
