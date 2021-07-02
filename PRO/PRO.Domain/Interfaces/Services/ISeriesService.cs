using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Services
{
    public interface ISeriesService
    {
        public IEnumerable<Series> GetAll();
        public Series Find(int? id);
        public void Add(Series series);
        public void Delete(Series series);

        public void Update(Series series);
        public void RemoveFromGames(int id);
        public ModelStateDictionary ValidateSeries(Series series);
        IQueryable<Series> FilterSearch(string query);
        IQueryable<Series> SortList(string sortOrder, IQueryable<Series> series);
    }
}
