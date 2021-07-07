using Microsoft.AspNetCore.Mvc.ModelBinding;
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
        private readonly IGameListRepository _gameListRepository;

        public GameListService( IGameListRepository gameListRepository)
        {
            _gameListRepository = gameListRepository;
        }

        public void Add(GameList gameList)
        {
            _gameListRepository.Add(gameList);
            _gameListRepository.Save();
        }

        public void Delete(GameList gameList)
        {
            _gameListRepository.Remove(gameList);
            _gameListRepository.Save();
        }

        public GameList Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _gameListRepository.Find(id.Value);
        }

        public IEnumerable<GameList> GetAll()
        {
            return _gameListRepository.GetAll().ToList();
        }
        public GameList AddOrUpdateDates(GameList gameList)
        {
            if (gameList.UserListId <= 0)
            { return null; }
            var oldGameList = Find(gameList.Id);
            if (oldGameList == null)
            {
                gameList.AddedDate = DateTime.Now;
            }
            else
            {
                gameList.EditedDate = DateTime.Now;
                gameList.AddedDate = oldGameList.AddedDate;
            }
            return gameList;
        }
        public void AddOrUpdate(GameList gameList)
        {
            var oldgamelist = Find(gameList.Id);
            if (oldgamelist == null) {
                Add(gameList);
            }
            else
            {
                oldgamelist.PersonalScore = gameList.PersonalScore;
                oldgamelist.EditedDate = gameList.EditedDate;
                oldgamelist.AddedDate = gameList.AddedDate;
                oldgamelist.HoursPlayed = gameList.HoursPlayed;
                oldgamelist.UserListId = gameList.UserListId;
                Update(oldgamelist);
            }


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
            _gameListRepository.Update(gameList);
            _gameListRepository.Save();
        }

        public ModelStateDictionary ValidateGameList(GameList gameList)
        {
            ModelStateDictionary errors = new ModelStateDictionary();
            if (gameList == null) return errors;

            var gameLists = _gameListRepository
                .GetAll()
                .Where(
                    i => i.UserListId == gameList.UserListId &&
                    i.GameId == gameList.GameId &&
                    (
                    i.Id != gameList.Id ||
                    gameList.Id == 0
                    ))
                .ToList();

            if (gameLists.Any())
            {
              //  errors.TryAddModelError("GameId", "Wybrana gra znajduje się już na wskazanej liście.");
                errors.TryAddModelError("UserListId", "Wybrana gra znajduje się już na wskazanej liście.");
            }

            if (gameList.PersonalScore <= 0 || gameList.PersonalScore > 10)
            {
                errors.TryAddModelError("PersonalScore", "Ocena musi być pusta lub z zakresu 1-10.");
            }
            if (gameList.HoursPlayed < 0 || gameList.HoursPlayed > 99999)
            {
                errors.TryAddModelError("HoursPlayed", "Liczba godzin musi być z zakresu 0-99999.");
            }
            if (gameList.UserListId <= 0 || gameList.UserListId == null)
            {
                errors.TryAddModelError("UserListId", "Wybierz listę.");
            }

            return errors;
        }

        public IQueryable<GameList> FilterSearch(string query)
        {
            var gameLists = GetAll().AsQueryable();
            if (!string.IsNullOrEmpty(query))
            {
                gameLists = gameLists.Where(s => 
                s.Game.Title.ToLower().Contains(query.ToLower()) ||
                s.UserList.Name.ToLower().Contains(query.ToLower()) ||
                s.UserList.User.UserName.ToLower().Contains(query.ToLower())
                );
            }
            return gameLists;
        }

        public IQueryable<GameList> SortList(string sortOrder, IQueryable<GameList> gameLists)
        {
            gameLists = sortOrder switch
            {
                "user_desc" => gameLists.OrderByDescending(s => s.UserList.User.UserName),
                "" => gameLists.OrderBy(s => s.UserList.User.UserName),
                "list_desc" => gameLists.OrderByDescending(s => s.UserList.Name),
                "list" => gameLists.OrderBy(s => s.UserList.Name),
                "adddate_desc" => gameLists.OrderByDescending(s => s.AddedDate),
                "adddate" => gameLists.OrderBy(s => s.AddedDate),
                "editdate_desc" => gameLists.OrderByDescending(s => s.EditedDate),
                "editdate" => gameLists.OrderBy(s => s.EditedDate),
                "game_desc" => gameLists.OrderByDescending(s => s.Game.Title),
                "game" => gameLists.OrderBy(s => s.Game.Title),
                "hours_desc" => gameLists.OrderByDescending(s => s.HoursPlayed),
                "hours" => gameLists.OrderBy(s => s.HoursPlayed),
                "score_desc" => gameLists.OrderByDescending(s => s.PersonalScore),
                "score" => gameLists.OrderBy(s => s.PersonalScore),
                _ => gameLists.OrderBy(s => s.UserList.User.UserName),
            };
            return gameLists.AsQueryable();
        }

        public IQueryable<GameList> FilterByList(string currentFilter, IQueryable<GameList> gamelists)
        {
            if (currentFilter == null) return gamelists;
            if (currentFilter.Equals("all")) return gamelists;
            return gamelists.Where(s => s.UserList.ListType.Name.Equals(currentFilter));
        }
    }
}
