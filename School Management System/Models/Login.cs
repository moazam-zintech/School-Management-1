
using System.ComponentModel.DataAnnotations;

namespace School_Management_System.Models
{
    public class Login 
    {
        [Key]
        public int Id {  get; set; }
        [Required(ErrorMessage ="Email is required")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

    }
}
