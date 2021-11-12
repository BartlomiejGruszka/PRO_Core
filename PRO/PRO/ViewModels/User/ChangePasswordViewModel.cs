using System.ComponentModel.DataAnnotations;

namespace PRO.UI.ViewModels
{
    public class ChangePasswordViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DataType(DataType.Password)]
        [Display(Name = "Obecne hasło")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [StringLength(100, ErrorMessage = "'{0}' must be at least {2} and maximum {1} characters.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nowe hasło")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Powtórz nowe hasło")]
        [Compare("NewPassword", ErrorMessage = "Passwords are not identical.")]
        public string ConfirmPassword { get; set; }
    }
}
