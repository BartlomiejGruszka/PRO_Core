using Microsoft.AspNetCore.Http;
using PRO.Domain.Extensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PRO.Entities
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nazwa obrazu jest wymagana."), MaxLength(100),DisplayName("Nazwa"),MinLength(3)] //add custom is unique constraint UniqueImageName
        public string Name { get; set; }

        public string ImagePath { get; set; }

        [NotMapped, DisplayName("Plik obrazu")]
        [CustomValidation(typeof(Image), "ValidateFile")]//FileMustBeAnImage
        public IFormFile ImageFile { get; set; }

        [Required(ErrorMessage = "Rodzaj obrazu jest wymagany."), DisplayName("Rodzaj obrazu")]
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