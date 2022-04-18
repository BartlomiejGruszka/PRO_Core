using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRO.Domain.Interfaces.Services
{
    public interface IImageService
    {
        public IEnumerable<Image> GetAll();
        public Image Find(int? id);

        public Image UploadImageFile(Image image);
        public void Add(Image image);
        public void Update(Image image);
        public void Delete(Image image);
        public void RemoveImageFile(Image image);
        public void RenameImage(Image image);
        // public IEnumerable<ImageType> GetImageTypes();
        public IEnumerable<Image> GetImagesByImageType(int id);
        public IEnumerable<Image> GetImagesByEnumType(ImageTypes type);
        public ModelStateDictionary ValidateImage(Image product);
        public Image CreateUserImage(IFormFile profileImage, string username);
        IQueryable<Image> FilterSearch(string query);
        IQueryable<Image> SortList(string sortOrder, IQueryable<Image> images);
    }
}
