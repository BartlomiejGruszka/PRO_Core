using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Domain.Interfaces.Services
{
    public interface IPlatformService
    {
        public IEnumerable<Platform> GetAll();
        public Platform Find(int? id);
        public void Add(Platform tag);
        public void Delete(Platform tag);

        public void Update(Platform tag);
        public ModelStateDictionary ValidatePlatform(Platform platform);
        IQueryable<Platform> FilterSearch(string query);
        IQueryable<Platform> SortList(string sortOrder, IQueryable<Platform> platforms);
    }
}
