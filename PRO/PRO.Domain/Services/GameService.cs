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
        private readonly IImageRepository _imageRepository;
        private readonly IGameListRepository _gameListRepository;

        public GameService(
            IRepository<Game> repository,
            IGameRepository gameRepository,
            IImageRepository imageRepository,
            IGameListRepository gameListRepository)
        {
            _repository = repository;
            _gameRepository = gameRepository;
            _gameListRepository = gameListRepository;
            _imageRepository = imageRepository;
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

        public List<Tuple<Game, double?>> GetHighestRatedGames(int number)
        {
            var orderedRanking = GetUnorderedGamesRanking().OrderByDescending(o => o.Item2).Take(number).ToList();
            return orderedRanking;
        }

        public List<Tuple<Game, double?>> GetUnorderedGamesRanking()
        {
            var images = _imageRepository.GetAll();

            var ranking = _gameListRepository.GetAll()
                .GroupBy(g => g.Game)
                .AsEnumerable()
                .Select(g => new { game = g.Key, average = g.Average(p => p.PersonalScore) })
                .Select(c => new Tuple<Game, double?>(c.game, c.average))
                .ToList();

            var games = _gameRepository.GetAll().Where(g => !g.GameLists.Any()).ToList();
            foreach (Game game in games)
            {
                ranking.Add(new Tuple<Game, double?>(game, null));
            }



            return ranking;
        }
    }
}
