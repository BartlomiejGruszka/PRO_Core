using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;
using System.Linq;

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

        public IQueryable<Moderator> FilterSearch(string query)
        {
            var moderators = GetAll().AsQueryable();
            if (!string.IsNullOrEmpty(query))
            {
                moderators = moderators.Where(s =>
                s.User.UserName.ToLower().Contains(query.ToLower())
                );
            }
            return moderators;
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

        public IQueryable<Moderator> SortList(string sortOrder, IQueryable<Moderator> moderators)
        {
            moderators = sortOrder switch
            {
                "user_desc" => moderators.OrderByDescending(s => s.User.UserName),
                "" => moderators.OrderBy(s => s.User.UserName),
                "adddate_desc" => moderators.OrderByDescending(s => s.CreatedDate),
                "adddate" => moderators.OrderBy(s => s.CreatedDate),
                "logindate_desc" => moderators.OrderByDescending(s => s.LastLoginDate),
                "logindate" => moderators.OrderBy(s => s.LastLoginDate),
                _ => moderators.OrderBy(s => s.User.UserName),
            };
            return moderators.AsQueryable();
        }

        public void Update(Moderator moderator)
        {
            _repository.Update(moderator);
            _repository.Save();
        }
    }
}
