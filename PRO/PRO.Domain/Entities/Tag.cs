using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace PRO.Entities
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }

        [IndexColumn("TagName_IX", IsUnique = true)]
        [Required, MaxLength(100), DisplayName("Słowo kluczowe"), MinLength(2)] //add custom is unique constraintUniqueTagName
        public string Name { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}