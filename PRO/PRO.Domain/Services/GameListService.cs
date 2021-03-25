using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;

namespace PRO.Domain.Services
{
    class GameListService : IGameListService
    {
        private readonly IRepository<GameList> _repository;
        public GameListService(IRepository<GameList> repository)
        {
            _repository = repository;
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
            return _repository.GetAll();
        }

        public void Update(GameList gameList)
        {
            _repository.Update(gameList);
            _repository.Save();
        }
    }
}
