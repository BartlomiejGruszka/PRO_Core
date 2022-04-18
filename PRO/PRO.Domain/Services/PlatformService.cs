using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Domain.Entities;
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

        public IQueryable<Platform> FilterSearch(string query)
        {
            var platforms = GetAll().AsQueryable();
            if (!string.IsNullOrEmpty(query))
            {
                platforms = platforms.Where(s =>
                s.Name.ToLower().Contains(query.ToLower()) ||
                s.Company.Name.ToLower().Contains(query.ToLower())
                );
            }
            return platforms;
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

        public IQueryable<Platform> SortList(string sortOrder, IQueryable<Platform> platforms)
        {
            platforms = sortOrder switch
            {
                "name_desc" => platforms.OrderByDescending(s => s.Name),
                "" => platforms.OrderBy(s => s.Name),
                "company_desc" => platforms.OrderByDescending(s => s.Company.Name),
                "company" => platforms.OrderBy(s => s.Company.Name),
                "date_desc" => platforms.OrderByDescending(s => s.ReleaseDate),
                "date" => platforms.OrderBy(s => s.ReleaseDate),
                _ => platforms.OrderBy(s => s.Name),
            };
            return platforms.AsQueryable();
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

