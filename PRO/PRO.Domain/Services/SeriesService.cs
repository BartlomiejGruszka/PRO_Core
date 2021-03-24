using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;

namespace PRO.Domain.Services
{
    class SeriesService : ISeriesService
    {
        private readonly IRepository<Series> _repository;
        private readonly IGameRepository _gameRepository;
        public SeriesService(IRepository<Series> repository,
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
    }
}
