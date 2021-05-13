using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Domain.Services
{
    public class TagService : ITagService
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

        public ModelStateDictionary ValidateTag(Tag tag)
        {
            ModelStateDictionary errors = new ModelStateDictionary();
            if (tag == null) return errors;

            var tags = _repository.GetAll().Where(i => i.Name == tag.Name && i.Id != tag.Id);

            if (tags.Any())
            {
                errors.TryAddModelError("Name", "Istnieje już tag o takiej nazwie.");
            }
            return errors;
        }
    }
}

