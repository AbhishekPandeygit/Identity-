using System.ComponentModel.DataAnnotations;

namespace IdentityBhrDev.ViewModel
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Please Enter Email")] //default error message => " email not entered"
        [EmailAddress]
        public string Email { get; set; } = default! ;

        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = default!;

        [Required(ErrorMessage = "Please Enter Password")]
        [Display(Name = "Confirm Password")]
        [Compare("Password",ErrorMessage = "Password did not match")]
        public string ConfirmPassword { get; set; } = default ! ;

    }
}
