using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace PRO.Domain.Entities
{
    public class Status
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "'{0}' must be at least {2} and maximum {1} characters.")]
        [IndexColumn("StatusName_IX", IsUnique = true)]
        [DisplayName("Status")] //add custom is unique constraintUniqueStatusName
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Umożliwia recenzowanie")]
        public bool AllowReviews { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}