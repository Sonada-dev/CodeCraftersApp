using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeCraftersApp.Models
{
    public class Application
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Фамилия")]
        public string? Surname { get; set; }

        [Required]
        [Display(Name = "Имя")]
        public string? Name { get; set; }

        [Display(Name = "Отчество")]
        public string? MiddleName { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [ForeignKey(nameof(Course.Id))]
        public int CourseId { get; set; }

        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; } = DateTime.Now;

    }
}
