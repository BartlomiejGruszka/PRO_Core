using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;

namespace PRO.Domain.Services
{
    public class ModeratorService : IModeratorService
    {
        private readonly IRepository<Moderator> _repository;
        private readonly IModeratorRepository _moderatorRepository;
        public ModeratorService(IRepository<Moderator> repository, IModeratorRepository moderatorRepository)
        {
            _repository = repository;
            _moderatorRepository = moderatorRepository;
        }

        public void Add(Moderator moderator)
        {
            _repository.Add(moderator);
            _repository.Save();
        }

        public void Delete(Moderator moderator)
        {
            _repository.Remove(moderator);
            _repository.Save();
        }

        public Moderator Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _moderatorRepository.Find(id.Value);
        }

        public IEnumerable<Moderator> GetAll()
        {
            return _moderatorRepository.GetAll();
        }

        public void Update(Moderator moderator)
        {
            _repository.Update(moderator);
            _repository.Save();
        }
    }
}
