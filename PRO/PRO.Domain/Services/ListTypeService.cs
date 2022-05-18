using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Domain.Services
{
    public class ListTypeService : IListTypeService
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

        public IQueryable<ListType> FilterSearch(string query)
        {
            var listTypes = GetAll().AsQueryable();
            if (!string.IsNullOrEmpty(query))
            {
                listTypes = listTypes.Where(s =>
                s.Name.ToLower().Contains(query.ToLower())
                );
            }
            return listTypes;
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

        public IQueryable<ListType> SortList(string sortOrder, IQueryable<ListType> listTypes)
        {
            listTypes = sortOrder switch
            {
                "id_desc" => listTypes.OrderByDescending(s => s.Id),
                "" => listTypes.OrderBy(s => s.Id),
                "name_desc" => listTypes.OrderByDescending(s => s.Name),
                "name" => listTypes.OrderBy(s => s.Name),
                _ => listTypes.OrderBy(s => s.Id),
            };
            return listTypes.AsQueryable();
        }

        public void Update(ListType listType)
        {
            _repository.Update(listType);
            _repository.Save();
        }

        public ModelStateDictionary ValidateListType(ListType listType)
        {
            ModelStateDictionary errors = new ModelStateDictionary();
            if (listType == null) return errors;

            var listTypes = _repository.GetAll().Where(i => i.Name == listType.Name && i.Id != listType.Id);

            if (listTypes.Any())
            {
                errors.TryAddModelError("Name", "Istnieje już rodzaj listy o takiej nazwie.");
            }
            return errors;
        }
    }
}
