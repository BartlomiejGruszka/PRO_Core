using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;

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
    }
}
