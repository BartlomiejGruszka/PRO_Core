using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Domain.Entities;
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

        public IQueryable<ImageType> FilterSearch(string query)
        {
            var imageTypes = GetAll().AsQueryable();
            if (!string.IsNullOrEmpty(query))
            {
                imageTypes = imageTypes.Where(s =>
                s.Name.ToLower().Contains(query.ToLower())
                );
            }
            return imageTypes;
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
        public IEnumerable<ImageType> GetByType(ImageTypes Type)
        {
            return _repository.GetAll().Where(s => s.Type == Type);
        }

        public IQueryable<ImageType> SortList(string sortOrder, IQueryable<ImageType> imageTypes)
        {
            imageTypes = sortOrder switch
            {
                "name_desc" => imageTypes.OrderByDescending(s => s.Name),
                "" => imageTypes.OrderBy(s => s.Name),
                "type_desc" => imageTypes.OrderByDescending(s => s.Type),
                "type" => imageTypes.OrderBy(s => s.Type),
                _ => imageTypes.OrderBy(s => s.Name),
            };
            return imageTypes.AsQueryable();
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
