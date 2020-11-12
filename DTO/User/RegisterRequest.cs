using System.ComponentModel.DataAnnotations;

namespace Dto.User
{
    public class RegisterRequest
    {
        [Required]
        [RegularExpression(@"^\w+$", ErrorMessage = "Name can contain only letters and figures")]
        [StringLength(10, ErrorMessage = "Name length must be maximum 10 symbols"), MinLength(2, ErrorMessage = "Name length must be minimum 2 symbols")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^\w+$", ErrorMessage = "Login can contain only letters and figures")]
        [StringLength(10, ErrorMessage = "Login can contain only letters and figures"), MinLength(4, ErrorMessage = "Login length must be minimum 4 symbols")]
        public string Login { get; set; }

        [Required]
        [RegularExpression(@"^\w+$", ErrorMessage = "Password can contain only letters and figures")]
        [StringLength(10), MinLength(6)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Confirm password must mutch the password")]
        public string PasswordConfirm { get; set; }
    }
}