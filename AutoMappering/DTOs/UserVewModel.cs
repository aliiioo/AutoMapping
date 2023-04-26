using System.ComponentModel.DataAnnotations;

namespace AutoMappering.DTOs
{
    public class UserVewModel
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string Usrename { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public DateTime dateTime { get; set; }
    }
}
