using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace APIAssigment1.Models
{
    public class AuthenticationRequestModel
    {
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}