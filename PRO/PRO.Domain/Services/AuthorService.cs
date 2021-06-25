using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Domain.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IRepository<Author> _repository;
        private readonly IAuthorRepository _authorRepository;
        public AuthorService(IRepository<Author> repository, IAuthorRepository authorRepository)
        {
            _repository = repository;
            _authorRepository = authorRepository;
        }

        public void Add(Author author)
        {
            _repository.Add(author);
            _repository.Save();
        }

        public void Delete(Author author)
        {
            _repository.Remove(author);
            _repository.Save();
        }

        public IQueryable<Author> FilterSearch(string query)
        {
            var authors = GetAll().AsQueryable();
            if (!string.IsNullOrEmpty(query))
            {
                authors = authors
                    .Where(s => 
                    s.FirstName.ToLower().Contains(query.ToLower()) ||
                    s.LastName.ToLower().Contains(query.ToLower()) ||
                    s.User.UserName.ToLower().Contains(query.ToLower())
                    );
            }
            return authors;
        }

        public Author Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _authorRepository.Find(id.Value);
        }

        public IEnumerable<Author> GetAll()
        {
            return _authorRepository.GetAll().ToList() ;
        }

        public IQueryable<Author> SortList(string sortOrder, IQueryable<Author> authors)
        {
            authors = sortOrder switch
            {
                "User_desc" => authors.OrderByDescending(s => s.User.UserName),
                "" => authors.OrderBy(s => s.User.UserName),
                "date_desc" => authors.OrderByDescending(s => s.CreatedDate),
                "Date" => authors.OrderBy(s => s.CreatedDate),
                "Name_desc" => authors.OrderByDescending(s => s.FirstName),
                "Name" => authors.OrderBy(s => s.FirstName),
                "Surname_desc" => authors.OrderByDescending(s => s.LastName),
                "Surname" => authors.OrderBy(s => s.LastName),
                _ => authors.OrderBy(s => s.User.UserName),
            };
            return authors.AsQueryable();
        }

        public void Update(Author author)
        {
            _repository.Update(author);
            _repository.Save();
        }
    }
}
