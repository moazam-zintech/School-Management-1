using System.ComponentModel.DataAnnotations;

namespace School_Management_System.Models
{
    public class Student
    {
        [Key]
        public int Std_id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string? Std_Name{ get; set; }
        [Required(ErrorMessage = "Gender is required")]
        public string? Std_Gender { get; set; }
        [Required(ErrorMessage = "Age is required")]

        [Range(1, 100, ErrorMessage = "Age must be between 1 and 100")]
        public int Std_Age { get; set; }

        public ICollection<Class>? Classes { get; set; }
        public ICollection<Teacher>? Teachers { get; set; }
        public ICollection<Term>? Terms { get; set; }
        public ICollection<Grade>? Grades { get; set; }
        public ICollection<Subject>? Subjects { get; set; }
    }
}
    