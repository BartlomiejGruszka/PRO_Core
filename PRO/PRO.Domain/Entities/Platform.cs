using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace PRO.Entities
{
    public class Platform
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "'{0}' must be at least {2} and maximum {1} characters.")]
        [IndexColumn("PlatformName_IX", IsUnique = true)]
        [DisplayName("Nazwa platformy")] //add custom is unique constraint UniquePlatformName
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Data premiery")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Wciąż dostępna")]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Wydawca")]
        public int CompanyId { get; set; }

        [ForeignKey("CompanyId"), DisplayName("Wydawca")]
        public Company Company{ get; set; }

        public ICollection<Game> Games { get; set; }

    }
}