using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Domain.Services
{
    public class SeriesService : ISeriesService
    {
        private readonly ISeriesRepository _repository;
        private readonly IGameRepository _gameRepository;
        public SeriesService(ISeriesRepository repository,
            IGameRepository gameRepository)
        {
            _repository = repository;
            _gameRepository = gameRepository;
        }

        public void Add(Series series)
        {
            _repository.Add(series);
            _repository.Save();
        }

        public void Delete(Series series)
        {
            _repository.Remove(series);
            _repository.Save();
        }

        public Series Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _repository.Find(id.Value);
        }

        public IEnumerable<Series> GetAll()
        {
            return _repository.GetAll();
        }

        public void RemoveFromGames(int id)
        {
            var games = _gameRepository.Get(i => i.SeriesId == id);
            foreach(var game in games)
            {
                game.SeriesId = null;
            }
            _gameRepository.Save();
        }

        public void Update(Series series)
        {
            _repository.Update(series);
            _repository.Save();
        }

        public ModelStateDictionary ValidateSeries(Series series)
        {
            ModelStateDictionary errors = new ModelStateDictionary();
            if (series == null) return errors;

            var serieslist = _repository.GetAll().Where(i => i.Name == series.Name && i.Id != series.Id);

            if (serieslist.Any())
            {
                errors.TryAddModelError("Name", "Istnieje już seria o takiej nazwie.");
            }
            return errors;
        }
    }
}
