using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
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

        public IEnumerable<Game> GetGames()
        {
            return  _repository.GetAll();
        }
        public List<Game> GetAll()
        {
           var test =  _gameRepository.GetAll();
            var list = test.ToList();
            return list;
        }
       

    }
}
