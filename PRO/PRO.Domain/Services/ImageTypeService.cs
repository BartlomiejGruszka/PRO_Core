using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Linq;

namespace PRO.Domain.Services
{
    public class ImageTypeService : IImageTypeService
    {
        private readonly IRepository<ImageType> _repository;
        public ImageTypeService(IRepository<ImageType> repository)
        {
            _repository = repository;
        }

        public void Add(ImageType imageType)
        {
            _repository.Add(imageType);
            _repository.Save();
        }

        public void Delete(ImageType imageType)
        {
            _repository.Remove(imageType);
            _repository.Save();
        }

        public ImageType Find(int? id)
        {
            if (!id.HasValue) return null;
            return _repository.Find(id.Value);
        }

        public IEnumerable<ImageType> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(ImageType imageType)
        {
            _repository.Update(imageType);
            _repository.Save();
        }

        public ModelStateDictionary ValidateImageType(ImageType imageType)
        {
            ModelStateDictionary errors = new ModelStateDictionary();
            if (imageType == null) return errors;

            var imageTypes = _repository.GetAll().Where(i => i.Name == imageType.Name && i.Id != imageType.Id);

            if (imageTypes.Any())
            {
                errors.TryAddModelError("Name", "Istnieje już rodzaj obrazu o takiej nazwie.");
            }
            return errors;
        }
    }
}
