using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRO.Entities
{
    public class Platform
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100), DisplayName("Nazwa platformy"), MinLength(3)] //add custom is unique constraint UniquePlatformName
        public string Name { get; set; }

        [Required, DisplayName("Data premiery")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [Required, DisplayName("Wciąż dostępna")]
        public bool IsActive { get; set; }

        [Required, DisplayName("Wydawca")]
        public int CompanyId { get; set; }

        [ForeignKey("CompanyId"), DisplayName("Wydawca")]
        public Company Company{ get; set; }

        public ICollection<Game> Games { get; set; }

    }
}