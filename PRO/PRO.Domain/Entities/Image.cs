using Microsoft.AspNetCore.Http;
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
        [Required, MaxLength(100),DisplayName("Nazwa"),MinLength(3)] //add custom is unique constraint UniqueImageName
        public string Name { get; set; }

        public string ImagePath { get; set; }

        [NotMapped, DisplayName("Plik obrazu")]//FileMustBeAnImage
        public IFormFile ImageFile { get; set; }

        [Required, DisplayName("Rodzaj obrazu")]
        public int ImageTypeId { get; set; }

        [ForeignKey("ImageTypeId")]
        public ImageType ImageType { get; set; }
    }
}