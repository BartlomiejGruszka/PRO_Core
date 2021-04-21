using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRO.Domain.Services
{
    public class GameService : IGameService
    {
        private readonly IRepository<Game> _repository;
        private readonly IGameRepository _gameRepository;

        public GameService(IRepository<Game> repository, IGameRepository gameRepository)
        {
            _repository = repository;
            _gameRepository = gameRepository;
        }

        public void AddGame(Game newGame)
        {
             _repository.Add(newGame);
             _repository.Save();
        }

        public IEnumerable<Game> GetAll()
        {
            
            return _gameRepository.GetAll();
        }

        public IEnumerable<Game> GetComingGames()
        {
            return _gameRepository.GetAll().Where(a => a.ReleaseDate > DateTime.Now).OrderBy(a => a.ReleaseDate).Take(3);
        }

        public IEnumerable<Game> GetGames()
        {
            throw new System.NotImplementedException();
        }
    }
}
