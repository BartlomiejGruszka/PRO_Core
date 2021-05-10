
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

        [Required]
        [DisplayName("Data rejestracji")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RegisterDate { get; set; }

        [MaxLength(5000), DisplayName("Opis")]
        public string Description { get; set; } //nullable

        [Required, DisplayName("Wciąż aktywny")]
        public bool IsActive { get; set; }

        [Required, DisplayName("Publiczny profil")]
        public bool IsPublic { get; set; }

        [DisplayName("Obraz profilu")]
        public int? ImageId { get; set; }

        [ForeignKey("ImageId"), DisplayName("Obraz profilu")]
        public Image Image { get; set; }

        public ICollection<UserList> UserLists { get; set; }
        public ICollection<Review> Reviews { get; set; }

        public Moderator Moderator{ get; set; }
        public Author Author { get; set; }
    }
}