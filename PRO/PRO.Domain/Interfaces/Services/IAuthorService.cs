using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Services
{
    public interface IAuthorService
    {
        public IEnumerable<Author> GetAll();
        public Author Find(int? id);
        public void Add(Author author);
        public void Delete(Author author);

        public void Update(Author author);
        public IQueryable<Author> SortList(string sortOrder, IQueryable<Author> authors);
        public IQueryable<Author> FilterSearch(string query);
    }
}
