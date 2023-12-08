using System.ComponentModel.DataAnnotations;

namespace CodeCraftersApp.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Название")]
        public string? Title { get; set; }
        [Required]
        [Display(Name = "Краткое описание")]
        public string? ShortDescription { get; set; }
        [Display(Name = "Описание")]
        public string? Description { get; set; }
        [Required]
        [Display(Name = "Изображение")]
        public string? Image { get; set; }
        [Required]
        [Display(Name = "Срок обучения (в месяцах)")]
        public int Duration { get; set; }
    }
}
