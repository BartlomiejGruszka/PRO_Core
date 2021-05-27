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
        private readonly IAwardRepository _awardRepository;
        public AwardService(IAwardRepository awardRepository)
        {
            _awardRepository = awardRepository;
        }

        public void Add(Award award)
        {
            _awardRepository.Add(award);
            _awardRepository.Save();
        }

        public void Delete(Award award)
        {
            _awardRepository.Remove(award);
            _awardRepository.Save();
        }

        public Award Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _awardRepository.Find(id.Value);
        }

        public IEnumerable<Award> GetAll()
        {
            return _awardRepository.GetAll();
        }

        public void Update(Award award)
        {
            _awardRepository.Update(award);
            _awardRepository.Save();
        }

        public ModelStateDictionary ValidateAward(Award award)
        {
            ModelStateDictionary errors = new ModelStateDictionary();
            if (award == null) return errors;

            var awards = _awardRepository.GetAll().Where(i => i.Name == award.Name && i.Id != award.Id);

            if (awards.Any())
            {
                errors.TryAddModelError("Name", "Istnieje już nagroda o takiej nazwie.");
            }
            return errors;
        }
    }
}
