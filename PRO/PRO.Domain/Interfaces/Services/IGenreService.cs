using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Services
{
    public interface IGenreService
    {
        public IEnumerable<Genre> GetAll();
        public Genre Find(int? id);
        public void Add(Genre genre);
        public void Delete(Genre genre);

        public void Update(Genre genre);
        public ModelStateDictionary ValidateGenre(Genre genre);
        public IQueryable<Genre> FilterSearch(string query);
        public IQueryable<Genre> SortList(string sortOrder, IQueryable<Genre> genres);
    }
}
