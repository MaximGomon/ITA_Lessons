using System.ComponentModel.DataAnnotations;

namespace DbEntity
{
    public class User : IdEntity
    {
        [MaxLength(150), MinLength(3), Required]
        public string FirstName { get; set; }
        [MaxLength(150), MinLength(2), Required]
        public string LastName { get; set; }
        [MaxLength(20), MinLength(5), Required]
        public string Login { get; set; }
        [MaxLength(40), MinLength(6), Required]
        public string Password { get; set; }
        [MaxLength(20), Required]
        public string Salt { get; set; }
        [Required]
        public virtual Role Role { get; set; }
    }
}
