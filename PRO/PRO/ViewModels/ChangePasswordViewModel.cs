using System.ComponentModel.DataAnnotations;

namespace PRO.UI.ViewModels
{
    public class ChangePasswordViewModel
    {
        public int id { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Obecne hasło")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nowe hasło")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Powtórz nowe hasło")]
        [Compare("NewPassword", ErrorMessage = "Nowe hasło i powtórzone nowe hasło nie są takie same.")]
        public string ConfirmPassword { get; set; }
    }
}
