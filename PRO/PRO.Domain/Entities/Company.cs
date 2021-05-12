using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace PRO.Entities
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100), DisplayName("Nazwa firmy"), MinLength(2), IndexColumn("CompanyName_IX", IsUnique = true)] //add custom is unique constraint UniqueCompanyName
        public string Name { get; set; }

        [Required, DataType(DataType.Date), DisplayName("Data założenia")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        [Required, DisplayName("Wciąż aktywna")]
        public bool IsActive { get; set; }


        public ICollection<Platform> Platforms{ get; set; }
        public ICollection<Game> PublishedGames { get; set; }


        public ICollection<Game> DevelopedGames { get; set; }

    }
}