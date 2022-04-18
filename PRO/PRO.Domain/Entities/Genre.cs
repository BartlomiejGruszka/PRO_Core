using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace PRO.Domain.Entities
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "'{0}' must be at least {2} and maximum {1} characters.")]
        [DisplayName("Nazwa gatunku"), IndexColumn("GenreName_IX", IsUnique = true)] //add custom is unique constraint UniqueGenreName
        public string Name { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}