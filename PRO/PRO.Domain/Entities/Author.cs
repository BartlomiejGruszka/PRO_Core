using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PRO.Entities
{
    public class Author
    {
        [Key,ForeignKey("User"), DisplayName("Użytkownik")]
        public int UserId { get; set; } // user id fk and pk

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "'{0}' must be at least {2} and maximum {1} characters.")]
        [DisplayName("Imię")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "'{0}' must be at least {2} and maximum {1} characters.")]
        [DisplayName("Nazwisko")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Data nadania roli")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Wciąż aktywny")]
        public bool IsActive { get; set; }

        public ICollection<Article> Articles { get; set; }

        [DisplayName("Użytkownik")]
        public ApplicationUser User { get; set; }
    }
}