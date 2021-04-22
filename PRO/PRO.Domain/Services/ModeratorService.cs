using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;

namespace PRO.Domain.Services
{
    public class ModeratorService : IModeratorService
    {
        private readonly IRepository<Moderator> _repository;
        public ModeratorService(IRepository<Moderator> repository)
        {
            _repository = repository;
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
            return _repository.Find(id.Value);
        }

        public IEnumerable<Moderator> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Moderator moderator)
        {
            _repository.Update(moderator);
            _repository.Save();
        }
    }
}
