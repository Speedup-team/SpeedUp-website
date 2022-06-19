using System.ComponentModel.DataAnnotations;

namespace Speedup_website.ViewModels
{
    public class LogupViewModel
    {
        [Required]
        [StringLength(25)]
        public string userName { get; set; }

        [Required]
        [StringLength(100)]
        public string password { get; set; }

        [Required]
        public string confirmPassword { get; set; }
    }
}