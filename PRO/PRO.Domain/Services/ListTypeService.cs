using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;

namespace PRO.Domain.Services
{
    class ListTypeService : IListTypeService
    {
        private readonly IRepository<ListType> _repository;
        public ListTypeService(IRepository<ListType> repository)
        {
            _repository = repository;
        }

        public void Add(ListType listType)
        {
            _repository.Add(listType);
            _repository.Save();
        }

        public void Delete(ListType listType)
        {
            _repository.Remove(listType);
            _repository.Save();
        }

        public ListType Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _repository.Find(id.Value);
        }

        public IEnumerable<ListType> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(ListType listType)
        {
            _repository.Update(listType);
            _repository.Save();
        }
    }
}
