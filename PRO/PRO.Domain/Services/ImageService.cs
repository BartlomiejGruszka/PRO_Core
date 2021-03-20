using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Hosting;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace PRO.Domain.Services
{
    public class ImageService : IImageService
    {
       // private readonly IRepository<ImageType> _imagetypeRepository;
        private readonly IImageRepository _imageRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        public ImageService(
            IImageRepository imageRepository,
            IWebHostEnvironment hostEnvironment
           /*, IRepository<ImageType> imagetypeRepository*/)
        {
            _imageRepository = imageRepository;
            webHostEnvironment = hostEnvironment;
          //  _imagetypeRepository = imagetypeRepository;
        }

        public void UploadImageFile(Image image)
        {

            string fileName = Path.GetFileNameWithoutExtension(image.ImageFile.FileName);
            string extension = Path.GetExtension(image.ImageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;

            string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");

            string filePath = Path.Combine(uploadsFolder, fileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                image.ImageFile.CopyTo(fileStream);
            }


        }

        public Image FindImage(int? id)
        {
            if (!id.HasValue) return null;
            var image = _imageRepository.Find(id.Value);


            return image;
        }

        public IEnumerable<Image> ImagesList()
        {
            return _imageRepository.GetAll();
        }

        public void AddImage(Image image)
        {
            _imageRepository.Add(image);
            _imageRepository.Save();
            UploadImageFile(image);
        }

        public void UpdateImage(Image image)
        {
            var oldimage = _imageRepository.Find(image.Id);
            _imageRepository.Update(image);
            _imageRepository.Save();
            UploadImageFile(image);
            RemoveImageFile(oldimage);
        }

        public void DeleteImage(Image image)
        {
            _imageRepository.Delete(image);
            _imageRepository.Save();
            RemoveImageFile(image);
        }
       /* public IEnumerable<ImageType> GetImageTypes()
        {
            return _imagetypeRepository.GetAll();
        }*/

        public IEnumerable<Image> GetImagesByType(int id)
        {
            return _imageRepository.Get(i => i.ImageTypeId == id);
        }

        public void RemoveImageFile(Image image)
        {
            if (File.Exists(image.ImagePath))
            {
                File.Delete(image.ImagePath);
            }
        }

        public void RenameImage(Image image)
        {
            _imageRepository.UpdateName(image);
            _imageRepository.Save();
        }
    }
}
