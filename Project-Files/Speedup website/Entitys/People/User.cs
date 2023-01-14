using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Speedup_website.Entitys.People
{
    public class User : IdentityUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int? mobilephone { get; set; } = null;

        [Required]
        [StringLength(25)]
        public string userName { get; set; } = "user name";

        [Required]
        [StringLength(100)]
        public string password { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string email { get; set; } = string.Empty;


        [Required]
        public bool isOwner { get; set; } = false;

        [Required]
        [StringLength(15)]
        public UserState state { get; set; } = UserState.Active;


        public Orders.ShoppingSassion? shoppingSassion { get; set; }
    }

    [ComplexType]
    public class UserDetails
    {
        [StringLength(25)]
        public string fName { get; set; } = string.Empty;

        [StringLength(25)]
        public string lName { get; set; } = string.Empty;

        [NotMapped]
        public string fullName => $"{fName} {lName}";

        [StringLength(200)]
        public string location { get; set; } = string.Empty;


        [Required]
        public bool gender { get; set; } = true;

        public DateTime? birthDate { get; set; } = null;

        [StringLength(200)]
        public string? image { get; set; } = null;


        [Required]
        public DateTime createdAt { get; } = DateTime.Now;

        public DateTime? removedAt { get; set; } = null;

        public DateTime? modifiedAt { get; set; } = null;


        public IList<UserAddress>? addresses { get; set; }
        public virtual IList<UserPayment>? payments { get; set; }
        public IList<Orders.OrderDetails>? orders { get; set; }
    }
}