using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;

namespace PRO.Domain.Services
{
    class TagService : ITagService
    {
        private readonly IRepository<Tag> _repository;
        public TagService(IRepository<Tag> repository)
        {
            _repository = repository;
        }

        public void Add(Tag tag)
        {
            _repository.Add(tag);
            _repository.Save();
        }

        public void Delete(Tag tag)
        {
            _repository.Remove(tag);
            _repository.Save();
        }

        public Tag Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _repository.Find(id.Value);
        }

        public IEnumerable<Tag> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Tag tag)
        {
            _repository.Update(tag);
            _repository.Save();
        }
    }
}

