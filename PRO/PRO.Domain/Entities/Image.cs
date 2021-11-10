using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PRO.Domain.Extensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Toolbelt.ComponentModel.DataAnnotations.Schema.V5;

namespace PRO.Entities
{
    public class Image
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "'{0}' must be at least {2} and maximum {1} characters.")]
        [IndexColumn("ImageName_IX", IsUnique = true)]
        [DisplayName("Nazwa")] //add custom is unique constraint UniqueImageName
        public string Name { get; set; }

        [DisplayName("Ścieżka obrazu")]
        public string ImagePath { get; set; }

        [NotMapped, DisplayName("Plik obrazu")]
        [CustomValidation(typeof(Image), "ValidateFile")]//FileMustBeAnImage
        public IFormFile ImageFile { get; set; }

        [Required(ErrorMessage = "Please enter value for {0}.")]
        [DisplayName("Rodzaj obrazu")]
        public int ImageTypeId { get; set; }

        [ForeignKey("ImageTypeId")]
        public ImageType ImageType { get; set; }

        public static ValidationResult ValidateFile(object value, ValidationContext context)
        {
            ValidationResult result = null;
            var image = (Image)context.ObjectInstance;
            if (image.ImageFile == null && image.Id > 0) return result;
            if (image.ImageFile == null)
            {
                result = new ValidationResult($"{context.DisplayName} jest wymagany.");
            }
            else if (!FormFileExtensions.IsImage(image.ImageFile))
            {
                result = new ValidationResult($"Wybrany plik nie jest obrazem.");
            }

            return result;
        }
    }

}