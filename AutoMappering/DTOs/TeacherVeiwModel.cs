using System.ComponentModel.DataAnnotations;

namespace AutoMappering.DTOs
{
    public class TeacherVeiwModel
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string Usrename { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Adderss { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Age { get; set; }

        
    }
}
