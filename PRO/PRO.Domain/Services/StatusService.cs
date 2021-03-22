using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;

namespace PRO.Domain.Services
{
    class StatusService : IStatusService
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

        public Status Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _repository.Find(id.Value);
        }

        public IEnumerable<Status> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Status status)
        {
            _repository.Update(status);
            _repository.Save();
        }
    }
}
