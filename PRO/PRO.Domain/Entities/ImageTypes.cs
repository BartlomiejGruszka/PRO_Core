using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace PRO.Domain.Entities
{
    public enum ImageTypes{ Article, Game, User, Other };
    public class ImageType
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "'{0}' must be at least {2} and maximum {1} characters.")]
        [IndexColumn("ImageTypeName_IX", IsUnique = true)]
        [DisplayName("Rodzaj obrazu")] //add custom is unique constraint UniqueImageTypeName
        public string Name { get; set; }

        public ICollection<Image> Images { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Typ")]
        [EnumDataType(typeof(ImageTypes))]
        public ImageTypes Type { get; set; }
    }
}