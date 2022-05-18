using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Domain.Services
{
    public class StatusService : IStatusService
    {
        private readonly IRepository<Status> _repository;
        public StatusService(IRepository<Status> repository)
        {
            _repository = repository;
        }

        public void Add(Status status)
        {
            _repository.Add(status);
            _repository.Save();
        }

        public void Delete(Status status)
        {
            _repository.Remove(status);
            _repository.Save();
        }

        public IQueryable<Status> FilterSearch(string query)
        {
            var statuses = GetAll().AsQueryable();
            if (!string.IsNullOrEmpty(query))
            {
                statuses = statuses.Where(s =>
                s.Name.ToLower().Contains(query.ToLower())
                );
            }
            return statuses;
        }

        public Status Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _repository.Find(id.Value);
        }

        public IEnumerable<Status> GetAll()
        {
            return _repository.GetAll();
        }

        public IQueryable<Status> SortList(string sortOrder, IQueryable<Status> statuses)
        {
            statuses = sortOrder switch
            {
                "id_desc" => statuses.OrderByDescending(s => s.Id),
                "" => statuses.OrderBy(s => s.Id),
                "name_desc" => statuses.OrderByDescending(s => s.Name),
                "name" => statuses.OrderBy(s => s.Name),
                _ => statuses.OrderBy(s => s.Id),
            };
            return statuses.AsQueryable();
        }

        public void Update(Status status)
        {
            _repository.Update(status);
            _repository.Save();
        }
        public ModelStateDictionary ValidateStatus(Status status)
        {
            ModelStateDictionary errors = new ModelStateDictionary();
            if (status == null) return errors;

            var statuses = _repository.GetAll().Where(i => i.Name == status.Name && i.Id != status.Id);

            if (statuses.Any())
            {
                errors.TryAddModelError("Name", "Istnieje już status o takiej nazwie.");
            }
            return errors;
        }
    }
}
