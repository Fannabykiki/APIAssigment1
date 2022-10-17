using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace APIAssigment1.Models
{
    public class PersonUpdateModel
    {
        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is requied")]
        public string? FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is requied")]
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string? BirthPlace { get; set; }
    }
}