using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRO.UI.ViewModels
{
    public class AdminChangePasswordViewModel
    {
        public int id { get; set; }

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
