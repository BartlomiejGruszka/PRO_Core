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

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [StringLength(maximumLength: 100, MinimumLength = 2, ErrorMessage = "'{0}' must be at least {2} and maximum {1} characters.")]
        [IndexColumn("TagName_IX", IsUnique = true)]//add custom is unique constraintUniqueTagName
        [DisplayName("Słowo kluczowe")] 
        public string Name { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}