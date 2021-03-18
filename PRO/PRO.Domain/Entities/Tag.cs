using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PRO.Entities
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100), DisplayName("Słowo kluczowe"), MinLength(2)] //add custom is unique constraintUniqueTagName
        public string Name { get; set; }

        public ICollection<GameTag> GameTags { get; set; }
    }
}