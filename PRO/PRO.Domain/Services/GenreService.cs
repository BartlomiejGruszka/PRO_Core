using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Domain.Services
{
    public class GenreService : IGenreService
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

        public ModelStateDictionary ValidateGenre(Genre genre)
        {
            ModelStateDictionary errors = new ModelStateDictionary();
            if (genre == null) return errors;

            var genres = _repository.GetAll().Where(i => i.Name == genre.Name && i.Id != genre.Id);

            if (genres.Any())
            {
                errors.TryAddModelError("Name", "Istnieje już gatunek o takiej nazwie.");
            }
            return errors;
        }
        public IQueryable<Genre> FilterSearch(string query)
        {
            var genres = GetAll().AsQueryable();
            if (!string.IsNullOrEmpty(query))
            {
                genres = genres.Where(s => s.Name.ToLower().Contains(query.ToLower()));
            }
            return genres;
        }

        public IQueryable<Genre> SortList(string sortOrder, IQueryable<Genre> genres)
        {
            genres = sortOrder switch
            {
                "DESC" => genres.OrderByDescending(s => s.Name),
                "" => genres.OrderBy(s => s.Name),               
                _ => genres.OrderBy(s => s.Name),
            };
            return genres.AsQueryable();
        }
    }
}
