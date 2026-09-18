using System.ComponentModel.DataAnnotations;

namespace ModernPortfolio.Models
{
    public class Login
    {
        [Required, EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
