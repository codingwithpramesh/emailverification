using System.ComponentModel.DataAnnotations;

namespace emailverification.Models
{
    public class UserRegisterRequest
    {
        [Required, EmailAddress]
        public string Email { get; set; }= string.Empty;
        [Required, MinLength(6)]
        public string password { get; set; }=string.Empty;
        [Required, Compare("password")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
