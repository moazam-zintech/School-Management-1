using System.ComponentModel.DataAnnotations;

namespace School_Management_System.Models
{
    public class Register
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Username is required.")]
        public string? Username { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "ConfirmPassword is required.")]
        public string? ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Address is required.")]
        public string? Address { get; set; }
        [Required(ErrorMessage = "PhoneNumber is required.")]
        public string? PhoneNumber { get; set; }
        [Required(ErrorMessage = "Role is required.")]
        public string? Role { get; set; }
    }
}
