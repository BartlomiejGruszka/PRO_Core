﻿using PRO.Entities;
using System;
using System.Collections.Generic;
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
        public IEnumerable<Image> GetImagesByType(int id);
    }
}
