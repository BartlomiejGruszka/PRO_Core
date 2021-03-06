using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace PRO.Entities
{
    public class Status
    {
        [Key]
        public int Id { get; set; }

        [IndexColumn("StatusName_IX", IsUnique = true)]
        [Required, MaxLength(100), DisplayName("Status"), MinLength(3)] //add custom is unique constraintUniqueStatusName
        public string Name { get; set; }

        [Required, DisplayName("Umożliwia recenzowanie")]
        public bool AllowReviews { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}