using System.ComponentModel.DataAnnotations;

namespace MVC_TUTORIAL_5_12_23.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Max char only 10")]
        [StringLength(10)]

        public string Name { get; set; }
        [Required]
        public string Comments { get; set; } = string.Empty;
        [Required]
        public string Book { get; set; }
        [Required]
        public DateTime Date { get; set; }

    }
}
