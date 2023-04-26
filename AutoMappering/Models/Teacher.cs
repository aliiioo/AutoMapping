using System.ComponentModel.DataAnnotations;

namespace AutoMappering.Models
{
    public class Teacher
    {
        public int id { get; set; }

        public string name { get; set; }

        public string Usrename { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }
        
        public string City { get; set; }
        
        public string Adderss { get; set; }
        
        public string Description { get; set; }
        
        public int Age { get; set; }
              
    }
}
