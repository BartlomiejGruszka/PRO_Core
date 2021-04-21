using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Domain.Services
{
    class GameListService : IGameListService
    {
        private readonly IRepository<GameList> _repository;
        private readonly IGameListRepository _gameListRepository;

        public GameListService(IRepository<GameList> repository, IGameListRepository gameListRepository)
        {
            _repository = repository;
            _gameListRepository = gameListRepository;
        }

        public void Add(GameList gameList)
        {
            _repository.Add(gameList);
            _repository.Save();
        }

        public void Delete(GameList gameList)
        {
            _repository.Remove(gameList);
            _repository.Save();
        }

        public GameList Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _repository.Find(id.Value);
        }

        public IEnumerable<GameList> GetAll()
        {
            return  _gameListRepository.GetAll();
        }


        public void Update(GameList gameList)
        {
            _repository.Update(gameList);
            _repository.Save();
        }
    }
}
