using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace PRO.Entities
{
    public class Series
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "'{0}' must be at least {2} and maximum {1} characters.")]
        [IndexColumn("SeriesName_IX", IsUnique = true)]
        [DisplayName("Tytuł serii")] //add custom is unique constraint UniqueSeriesName
        public string Name { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}