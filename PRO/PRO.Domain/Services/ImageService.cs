using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Http;

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
        public Image CreateUserImage(IFormFile profileImage, string username)
        {
            var userimage = new Image();
            userimage.Name = username+DateTime.Now.Ticks;
            userimage.ImageTypeId = 2;
            userimage.ImageFile = profileImage;

            return userimage;
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

        public IEnumerable<Image> GetImagesByImageType(int id)
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

        public ModelStateDictionary ValidateImage(Image image)
        {
            ModelStateDictionary errors = new ModelStateDictionary();
            if (image == null) return errors;
            
            var images = _imageRepository.GetAll().Where(i => i.Name == image.Name && i.Id != image.Id);

            if(images.Any())
            {
                errors.TryAddModelError("Name", "Istnieje już obraz o takiej nazwie.");
            }
            return errors;
        }
        public void RenameImage(Image image)
        {
            _imageRepository.UpdateName(image);
           // _imageRepository.Save();
        }

        public IEnumerable<Image> GetImagesByEnumType(ImageTypes type)
        {
            return _imageRepository.GetAll().Where(i => i.ImageType.Type == type);
        }

        public IQueryable<Image> FilterSearch(string query)
        {
            var images = GetAll().AsQueryable();
            if (!string.IsNullOrEmpty(query))
            {
                images = images.Where(s =>
                s.Name.ToLower().Contains(query.ToLower()) ||
                s.ImageType.Name.ToLower().Contains(query.ToLower())
                );
            }
            return images;
        }

        public IQueryable<Image> SortList(string sortOrder, IQueryable<Image> images)
        {
            images = sortOrder switch
            {
                "name_desc" => images.OrderByDescending(s => s.Name),
                "" => images.OrderBy(s => s.Name),
                "type_desc" => images.OrderByDescending(s => s.ImageType.Name),
                "type" => images.OrderBy(s => s.ImageType.Name),            
                _ => images.OrderBy(s => s.Name),
            };
            return images.AsQueryable();
        }
    }
}
