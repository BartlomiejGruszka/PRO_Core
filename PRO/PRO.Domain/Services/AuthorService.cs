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

        public Author Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _authorRepository.Find(id.Value);
        }

        public IEnumerable<Author> GetAll()
        {
            return _authorRepository.GetAll().ToList() ;
        }

        public void Update(Author author)
        {
            _repository.Update(author);
            _repository.Save();
        }
    }
}
