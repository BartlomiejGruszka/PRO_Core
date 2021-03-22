using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;

namespace PRO.Domain.Services
{
    class GenreService : IGenreService
    {
        private readonly IRepository<Genre> _repository;
        public GenreService(IRepository<Genre> repository)
        {
            _repository = repository;
        }
        public void Add(Genre genre)
        {
            _repository.Add(genre);
            _repository.Save();
        }

        public void Delete(Genre genre)
        {
            _repository.Remove(genre);
            _repository.Save();
        }

        public Genre Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _repository.Find(id.Value);
        }

        public IEnumerable<Genre> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Genre genre)
        {
            _repository.Update(genre);
            _repository.Save();
        }
    }
}
