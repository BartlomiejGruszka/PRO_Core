using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;

namespace PRO.Domain.Services
{
    class PlatformService : IPlatformService
    {
        private readonly IRepository<Platform> _repository;
        public PlatformService(IRepository<Platform> repository)
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
    }
}

