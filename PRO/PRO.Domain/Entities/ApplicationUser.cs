
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRO.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Data rejestracji")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RegisterDate { get; set; }

        [DisplayName("Zaktualizowano")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? EditDate { get; set; }

        [StringLength(maximumLength: 5000, MinimumLength = 0, ErrorMessage = "'{0}' must be at least {2} and maximum {1} characters.")]
        [DisplayName("Opis")]
        public string Description { get; set; } //nullable

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Wciąż aktywny")]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Publiczny profil")]
        public bool IsPublic { get; set; }

        [DisplayName("Obraz profilu")]
        public int? ImageId { get; set; }

        [DisplayName("Obraz profilu")]
        public Image Image { get; set; }

        public ICollection<UserList> UserLists { get; set; }
        public ICollection<Review> Reviews { get; set; }

        public Moderator Moderator{ get; set; }
        public Author Author { get; set; }
    }
}