using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRO.Domain.Interfaces.Services
{
    public interface IImageService
    {
        public IEnumerable<Image> ImagesList();
        public Image FindImage(int? id);

        public Image UploadImageFile(Image image);
        public void AddImage(Image image);
        public void UpdateImage(Image image);
        public void DeleteImage(Image image);
        public void RemoveImageFile(Image image);
        public void RenameImage(Image image);
       // public IEnumerable<ImageType> GetImageTypes();
        public IEnumerable<Image> GetImagesByType(int id);
    }
}
