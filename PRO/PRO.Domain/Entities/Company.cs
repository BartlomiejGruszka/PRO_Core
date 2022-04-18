using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace PRO.Domain.Entities
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [StringLength(maximumLength: 100, MinimumLength = 2, ErrorMessage = "'{0}' must be at least {2} and maximum {1} characters.")]
        [DisplayName("Nazwa firmy"), IndexColumn("CompanyName_IX", IsUnique = true)] //add custom is unique constraint UniqueCompanyName
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DataType(DataType.Date), DisplayName("Data założenia")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Wciąż aktywna")]
        public bool IsActive { get; set; }


        public ICollection<Platform> Platforms{ get; set; }
        public ICollection<Game> PublishedGames { get; set; }


        public ICollection<Game> DevelopedGames { get; set; }

    }
}