using System.ComponentModel.DataAnnotations;

namespace MVC_TUTORIAL_5_12_23.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]  
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int Experience { get; set; }
        [Required]
        public int Mobile { get; set; }
        [Required]
        public int DepartmentID { get; set; }
    }
}
