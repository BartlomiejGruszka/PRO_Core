using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace PRO.Entities
{
    public enum ImageTypes{ Article, Game, User, Other };
    public class ImageType
    {
        [Key]
        public int Id { get; set; }

        [IndexColumn("ImageTypeName_IX", IsUnique = true)]
        [Required, MaxLength(50), DisplayName("Rodzaj obrazu"), MinLength(3)] //add custom is unique constraint UniqueImageTypeName
        public string Name { get; set; }

        public ICollection<Image> Images { get; set; }

        [Required, DisplayName("Typ")]
        [Column(TypeName = "nvarchar(24)")]
        public ImageTypes Type { get; set; }
    }
}