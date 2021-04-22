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
        private readonly IImageRepository _imageRepository;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ImageService(
            IImageRepository imageRepository,
            IWebHostEnvironment hostEnvironment)
         {
            _imageRepository = imageRepository;
            webHostEnvironment = hostEnvironment;
        }

        public Image UploadImageFile(Image image)
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
            image.ImagePath = fileName;
            return image;

        }

        public Image Find(int? id)
        {
            if (!id.HasValue) return null;
            var image = _imageRepository.Find(id.Value);


            return image;
        }

        public IEnumerable<Image> GetAll()
        {
            return _imageRepository.GetAll();
        }

        public void Add(Image image)
        {
           // if()
            image = UploadImageFile(image);
            _imageRepository.Add(image);
            _imageRepository.Save();

        }

        public void Update(Image image)
        {
            if (image.ImageFile != null)
            {
                var oldimage = _imageRepository.Find(image.Id);
                _imageRepository.DetachOld(oldimage);
                image = UploadImageFile(image);
                RemoveImageFile(oldimage);
                _imageRepository.Update(image);
            }
            else
            {
                RenameImage(image);
            }


            _imageRepository.Save();
        }

        public void Delete(Image image)
        {
            _imageRepository.Delete(image);
            _imageRepository.Save();
            RemoveImageFile(image);
        }

        public IEnumerable<Image> GetImagesByType(int id)
        {
            return _imageRepository.Get(i => i.ImageTypeId == id);
        }

        public void RemoveImageFile(Image image)
        {
            string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
            string filePath = Path.Combine(uploadsFolder, image.ImagePath);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public void RenameImage(Image image)
        {
            _imageRepository.UpdateName(image);
            _imageRepository.Save();
        }
    }
}
