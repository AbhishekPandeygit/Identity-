using System.ComponentModel.DataAnnotations;

namespace IdentityBhrDev.ViewModel
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Please Enter Email")] //default error message => " email not entered"
        [EmailAddress]
        public string Email { get; set; } = default!;

        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = default!;

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
