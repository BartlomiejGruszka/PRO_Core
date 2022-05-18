using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Domain.Entities;
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

        public IQueryable<Award> FilterSearch(string query)
        {
            var awards = GetAll().AsQueryable();
            if (!string.IsNullOrEmpty(query))
            {
                awards = awards.Where(s => s.Name.ToLower().Contains(query.ToLower()) ||
                s.Game.Title.ToLower().Contains(query.ToLower())
                );
            }
            return awards;
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

        public IQueryable<Award> SortList(string sortOrder, IQueryable<Award> awards)
        {
            awards = sortOrder switch
            {
                "id_desc" => awards.OrderByDescending(s => s.Id),
                "" => awards.OrderBy(s => s.Id),
                "name_desc" => awards.OrderByDescending(s => s.Name),
                "Name" => awards.OrderBy(s => s.Name),
                "game_desc" => awards.OrderByDescending(s => s.Game.Title),
                "game" => awards.OrderBy(s => s.Game.Title),
                "date_desc" => awards.OrderByDescending(s => s.AwardDate),
                "date" => awards.OrderBy(s => s.AwardDate),
                _ => awards.OrderBy(s => s.Id),
            };
            return awards.AsQueryable();
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
