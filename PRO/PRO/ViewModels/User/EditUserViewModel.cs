using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using PRO.Domain.Entities;


namespace PRO.UI.ViewModels
{
    public class EditUserViewModel
    {
       public ApplicationUser AppUser { get; set; }
        public IEnumerable<ImageType> ImageTypes { get; set; }
        public int? SelectedImageTypeId { get; set; }
        public List<Image> Images { get; set; }

        [DisplayName("Plik obrazu")]
        public IFormFile ImageFile { get; set; }
    }
}