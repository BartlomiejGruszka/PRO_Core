using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Domain.Services
{
    public class GameListService : IGameListService
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
            return _gameListRepository.GetAll();
        }

        public List<Tuple<GameList, DateTime>> GetRecentUserGameListUpdates(int userid, int? number)
        {
            List<GameList> gameLists = GetAll().Where(u => u.UserList.UserId == userid).ToList();
            var tuplelist = new List<Tuple<GameList, DateTime>>();
            foreach (var gamelist in gameLists)
            {

                if (gamelist.EditedDate.HasValue)
                {
                    tuplelist.Add(new Tuple<GameList, DateTime>(gamelist, gamelist.EditedDate.Value));
                }
                else
                {
                    tuplelist.Add(new Tuple<GameList, DateTime>(gamelist, gamelist.AddedDate));
                }
            }
            if (number.HasValue)
            {
                return tuplelist.OrderByDescending(o => o.Item2).Take(number.Value).ToList();
            }

            return tuplelist.OrderByDescending(o => o.Item2).ToList(); ;
        }

        public int? GetUserReviewPlaytime(Review review)
        {
            if (review == null) return null;
            return _gameListRepository.GetGameListPlaytime(review.GameId, review.UserId);

        }

        public void Update(GameList gameList)
        {
            _repository.Update(gameList);
            _repository.Save();
        }
    }
}
