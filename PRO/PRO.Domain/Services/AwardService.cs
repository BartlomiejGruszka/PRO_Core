using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Domain.Services
{
    public class AwardService : IAwardService
    {
        private readonly IRepository<Award> _repository;
        public AwardService(IRepository<Award> repository)
        {
            _repository = repository;
        }

        public void Add(Award award)
        {
            _repository.Add(award);
            _repository.Save();
        }

        public void Delete(Award award)
        {
            _repository.Remove(award);
            _repository.Save();
        }

        public Award Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _repository.Find(id.Value);
        }

        public IEnumerable<Award> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Award award)
        {
            _repository.Update(award);
            _repository.Save();
        }

        public ModelStateDictionary ValidateAward(Award award)
        {
            ModelStateDictionary errors = new ModelStateDictionary();
            if (award == null) return errors;

            var awards = _repository.GetAll().Where(i => i.Name == award.Name && i.Id != award.Id);

            if (awards.Any())
            {
                errors.TryAddModelError("Name", "Istnieje już nagroda o takiej nazwie.");
            }
            return errors;
        }
    }
}
