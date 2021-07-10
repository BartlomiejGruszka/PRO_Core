using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using PRO.Entities;

namespace PRO.UI.ViewModels
{
    public class NewUserViewModel
    {


        public ApplicationUser AppUser { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} musi mieć co najmniej {2} znaków.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Powtórz hasło")]
        [Compare("Password", ErrorMessage = "Hasła nie są takie same.")]
        public string ConfirmPassword { get; set; }

        public IEnumerable<ImageType> ImageTypes { get; set; }
        public int? SelectedImageTypeId { get; set; }
        public List<Image> Images { get; set; }
    }
}