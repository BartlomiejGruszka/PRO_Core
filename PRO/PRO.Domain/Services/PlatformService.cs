using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Domain.Services
{
    public class PlatformService : IPlatformService
    {
        private readonly IPlatformRepository _repository;
        public PlatformService(IPlatformRepository repository)
        {
            _repository = repository;
        }

        public void Add(Platform platform)
        {
            _repository.Add(platform);
            _repository.Save();
        }

        public void Delete(Platform platform)
        {
            _repository.Remove(platform);
            _repository.Save();
        }

        public Platform Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _repository.Find(id.Value);
        }

        public IEnumerable<Platform> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Platform platform)
        {
            _repository.Update(platform);
            _repository.Save();
        }

        public ModelStateDictionary ValidatePlatform(Platform platform)
        {
            ModelStateDictionary errors = new ModelStateDictionary();
            if (platform == null) return errors;

            var platforms = _repository.GetAll().Where(i => i.Name == platform.Name && i.Id != platform.Id);

            if (platforms.Any())
            {
                errors.TryAddModelError("Name", "Istnieje już platforma o takiej nazwie.");
            }
            return errors;
        }
    }
}

