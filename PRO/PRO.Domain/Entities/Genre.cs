using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace PRO.Entities
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(50), DisplayName("Nazwa gatunku"), MinLength(3), IndexColumn(nameof(Name), IsUnique = true)] //add custom is unique constraint UniqueGenreName
        public string Name { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}