using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace PRO.Entities
{
    public class ImageType
    {
        [Key]
        public int Id { get; set; }

        [IndexColumn(nameof(Name), IsUnique = true)]
        [Required, MaxLength(50), DisplayName("Rodzaj obrazu"), MinLength(3)] //add custom is unique constraint UniqueImageTypeName
        public string Name { get; set; }

        public ICollection<Image> Images { get; set; }


    }
}