using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using PRO.Domain.Entities;

namespace PRO.UI.ViewModels
{
    public class NewUserViewModel
    {


        public ApplicationUser AppUser { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [StringLength(maximumLength: 100, MinimumLength = 6, ErrorMessage = "'{0}' must be at least {2} and maximum {1} characters.")]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Powtórz hasło")]
        [Compare("Password", ErrorMessage = "Passwords are not identical.")]
        public string ConfirmPassword { get; set; }

        public IEnumerable<ImageType> ImageTypes { get; set; }
        public int? SelectedImageTypeId { get; set; }
        public List<Image> Images { get; set; }
    }
}