using System;
using System.ComponentModel.DataAnnotations;

namespace RegistrationExample.Models
{
    public class UserViewModel
    {
        [Required]
        public Guid Id { get; set; }
        [MaxLength(150, ErrorMessage = "FirstName must be less that 150 chars")]
        [MinLength(3, ErrorMessage = "FirstName must be more that 3 chars")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "FirstName are required")]
        public string FirstName { get; set; }
        [MaxLength(150, ErrorMessage = "LastName must be less that 150 chars")]
        [MinLength(2, ErrorMessage = "LastName must be more that 2 chars")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "LastName are required")]
        public string LastName { get; set; }
        [MaxLength(20, ErrorMessage = "Login must be less that 20 chars")]
        [MinLength(5, ErrorMessage = "Login must be more that 5 chars")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Login are required")]
        public string Login { get; set; }
        [MaxLength(40, ErrorMessage = "Password must be less that 40 chars")]
        [MinLength(6, ErrorMessage = "Password must be more that 6 chars")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password are required")]
        public string Password { get; set; }
        [MaxLength(40, ErrorMessage = "ConfirmPassword must be less that 40 chars")]
        [MinLength(6, ErrorMessage = "ConfirmPassword must be more that 6 chars")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ConfirmPassword are required")]
        public string ConfirmPassword { get; set; }
        [Required]
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }
    }
}