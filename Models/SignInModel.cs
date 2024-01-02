using System.ComponentModel.DataAnnotations;

namespace MVC_TUTORIAL_5_12_23.Models
{
    public class SignInModel
    {
        [Key]
        [Required ]
        public int ID { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
