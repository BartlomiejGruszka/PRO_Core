using PRO.Domain.Extensions;
using PRO.Domain.HelperClasses;
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
        private readonly IGameRepository _gameRepository;
        private readonly IImageRepository _imageRepository;
        private readonly IGameListRepository _gameListRepository;
        private readonly IRepository<Language> _languageRepository;
        private readonly IRepository<Tag> _tagRepository;

        public GameService(
            IGameRepository gameRepository,
            IImageRepository imageRepository,
            IGameListRepository gameListRepository,
            IRepository<Language> languageRepository,
            IRepository<Tag> tagRepository)
        {
            _gameRepository = gameRepository;
            _gameListRepository = gameListRepository;
            _languageRepository = languageRepository;
            _tagRepository = tagRepository;
            _imageRepository = imageRepository;
        }


        public void Add(Game newGame)
        {
            _gameRepository.Add(newGame);

            _gameRepository.Save();
        }
        public void AddTags(Game newGame, IEnumerable<int> selectedTagsId)
        {
            List<Tag> newTags = new List<Tag>();
            var tags = _tagRepository.GetAll().ToList();

            if (selectedTagsId != null)
            {
                foreach (var tagid in selectedTagsId)
                {
                    newTags.Add(tags.Single(s => s.Id == tagid));
                }
                newGame.Tags = newTags;
            }

        }

        public void AddLanguages(Game newGame, IEnumerable<int> selectedLanguagesId)
        {
            List<Language> newLanguages = new List<Language>();
            var languages = _languageRepository.GetAll().ToList();

            if (selectedLanguagesId != null)
            {
                foreach (var languageid in selectedLanguagesId)
                {
                    newLanguages.Add(languages.Single(s => s.Id == languageid));
                }
                newGame.Languages = newLanguages;
            }

        }
        public Game Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _gameRepository.Find(id.Value);
        }

        public Game FindActive(int? id)
        {
            var game = Find(id);
            if (game == null) { return null; }
            if (game.IsActive == false) { return null; }
            return game;
        }

        public List<Game> GetAll()
        {

            return _gameRepository.GetAll().ToList();
        }
        public List<Game> GetAllActive()
        {
            return _gameRepository.GetAll().Where(i => i.IsActive == true).ToList();
        }
        public void Delete(Game game)
        {
            _gameRepository.Remove(game);
            _gameRepository.Save();
        }

        public IEnumerable<Game> GetComingGames()
        {
            return GetAllActive().Where(a => a.ReleaseDate > DateTime.Now).OrderBy(a => a.ReleaseDate).Take(3);
        }
        public IEnumerable<Game> GetRecentlyReleased()
        {
            return GetAllActive().Where(a => a.ReleaseDate < DateTime.Now).OrderBy(a => a.ReleaseDate).Take(5);
        }
        public List<GameScore> GetOrderedGamesRanking(int? number)
        {
            var orderedRanking = GetUnorderedGamesRanking().OrderByDescending(o => o.Score).ThenByDescending(d => d.Game.ReleaseDate).ToList();
            if (number.HasValue)
            {
                return orderedRanking.Take(number.Value).ToList();
            }
            return orderedRanking;
        }
        public List<GameScore> GetFilteredGamesRanking(string query)
        {
            var filteredgames = FilterGames(query).Select(s => new GameScore { Game = s, Score = null }).ToList();
            var ranking = GetUnorderedGamesRanking();
            var result = ranking.Select(r => new GameScore { Game = r.Game, Score = r.Score })
                .Where(g => ranking.Select(f => f.Game.Id).Intersect(filteredgames.Select(fg => fg.Game.Id)).Contains(g.Game.Id)).ToList();

            return result;
        }
        public List<GameScore> GetUnorderedGamesRanking()
        {
            var images = _imageRepository.GetAll();
            var ranking = GetAllActive()
              .Select(c => new GameScore { Game = c, Score = c.GameLists.Average(p => p.PersonalScore) })
              .ToList();
            return ranking;
        }
        public List<GameScore> GetUnorderedGamesRanking(IQueryable <Game> games)
        {
            //var images = _imageRepository.GetAll();
            var ranking = games
              .Select(c => new GameScore { Game = c, Score = c.GameLists.Average(p => p.PersonalScore) })
              .ToList();
            return ranking;
        }
        public List<GameScore> GetUserUnorderedGamesRanking(int? userid, IQueryable<Game> games)
        {
            if (!userid.HasValue) return GetUnorderedGamesRanking(games);
            if (userid < 1) return GetUnorderedGamesRanking(games);

            var usergamelists = _gameListRepository.GetAll().Where(s => s.UserList.UserId == userid);
            var ranking = GetUnorderedGamesRanking(games);

            foreach (var item in ranking)
            {
                var gamelist = usergamelists.FirstOrDefault(s => s.GameId == item.Game.Id);
                if (gamelist != null) { item.UserScore = gamelist.PersonalScore; }
            }
            return ranking;
        }
        public List<GameScore> GetUserUnorderedGamesRanking(int? userid)
        {
            return GetUserUnorderedGamesRanking(userid, null);
        }
        public List<Tuple<Game, int?>> GetGamesByPopularity()
        {
            var popularity = _gameListRepository.GetAll()
                .GroupBy(g => g.Game)
                .Select(g => new
                {
                    game = g.Key,
                    count = g.Select(i => i.UserList.UserId).Distinct().Count()
                })
                .Where(s => s.game.IsActive == true)
                .AsEnumerable()
                .Select(c => new Tuple<Game, int?>(c.game, c.count))
                .ToList();

            var games = GetAllActive().Where(g => !g.GameLists.Any()).ToList();
            foreach (Game game in games)
            {
                popularity.Add(new Tuple<Game, int?>(game, null));
            }


            return popularity;
        }

        public List<Game> FilterGames(string query)
        {
            var games = GetAllActive();

            List<Game> filteredgames1 = new List<Game>();
            foreach (var game in games)
            {
                if (game.DeveloperCompany != null)
                {
                    if (game.DeveloperCompany.Name.CaseInsensitiveContains(query)) { filteredgames1.Add(game); }
                }
                if (game.PublisherCompany != null)
                {
                    if (game.PublisherCompany.Name.CaseInsensitiveContains(query)) { filteredgames1.Add(game); }
                }
            }

            var filteredgames = games.Where(g =>
                g.Title.CaseInsensitiveContains(query) ||
                g.Description.CaseInsensitiveContains(query) ||
                g.Status.Name.CaseInsensitiveContains(query)
                ).ToList();

            var result = filteredgames.Concat(filteredgames1).Distinct().ToList();

            return result;
        }

        public void Update(Game game)
        {
            _gameRepository.Update(game);
            _gameRepository.Save();
        }

        public int? GetGamePosition(int gameid)
        {
            var gamesRankings = GetOrderedGamesRanking(null);
            int? position = gamesRankings.IndexOf(gamesRankings.Single(g => g.Game.Id == gameid)) + 1;
            return position;
        }

        public double? GetGameRating(int gameid)
        {
            var gamesRankings = GetOrderedGamesRanking(null);
            double? rating = gamesRankings.FirstOrDefault(g => g.Game.Id == gameid).Score;
            if (rating.HasValue)
            {
                rating = Math.Round(rating.Value, 1);
            }
            else
            {
                rating = 0;
            }
            return rating;
        }

        public int GetGamePopularity(int gameid)
        {
            var games = GetGamesByPopularity();
            return games.FindIndex(s => s.Item1.Id == gameid) + 1;
        }

        public IQueryable<Game> FilterSearch(string query, bool active)
        {
            IQueryable<Game> games = null;

            if (active)
            {
                games = GetAllActive().AsQueryable();
            }
            else
            {
                games = GetAll().AsQueryable();
            }

            if (!string.IsNullOrEmpty(query))
            {
                games = games.Where(s =>
                s.Title.ToLower().Contains(query.ToLower()) ||
                (s.DeveloperCompany != null &&
                s.DeveloperCompany.Name.ToLower().Contains(query.ToLower())
                ) ||
                 (s.PublisherCompany != null &&
                s.PublisherCompany.Name.ToLower().Contains(query.ToLower())
                ) ||
                 (s.Series != null &&
                s.Series.Name.ToLower().Contains(query.ToLower())
                ) ||
                s.Genre.Name.ToLower().Contains(query.ToLower()) ||
                s.Platform.Name.ToLower().Contains(query.ToLower())
                );
            }
            return games;
        }

        public IQueryable<Game> SortList(string sortOrder, IQueryable<Game> games)
        {
            games = sortOrder switch
            {
                "Title_desc" => games.OrderByDescending(s => s.Title),
                "" => games.OrderBy(s => s.Title),
                "Platform_desc" => games.OrderByDescending(s => s.Platform.Name),
                "Platform" => games.OrderBy(s => s.Platform.Name),
                "Date_desc" => games.OrderByDescending(s => s.ReleaseDate),
                "Date" => games.OrderBy(s => s.ReleaseDate),
                "Status_desc" => games.OrderByDescending(s => s.Status.Name),
                "Status" => games.OrderBy(s => s.Status.Name),
                "Genre_desc" => games.OrderByDescending(s => s.Genre.Name),
                "Genre" => games.OrderBy(s => s.Genre.Name),


                _ => games.OrderBy(s => s.Title),
            };
            return games.AsQueryable();
        }
        public IQueryable<GameScore> GameSortList(string sortOrder, IQueryable<GameScore> games)
        {
            games = sortOrder switch
            {
                "Title_desc" => games.OrderByDescending(s => s.Game.Title),
                "" => games.OrderBy(s => s.Game.Title),
                "Platform_desc" => games.OrderByDescending(s => s.Game.Platform.Name),
                "Platform" => games.OrderBy(s => s.Game.Platform.Name),
                "Date_desc" => games.OrderByDescending(s => s.Game.ReleaseDate),
                "Date" => games.OrderBy(s => s.Game.ReleaseDate),
                "Status_desc" => games.OrderByDescending(s => s.Game.Status.Name),
                "Status" => games.OrderBy(s => s.Game.Status.Name),
                "Score_desc" => games.OrderByDescending(s => s.Score),
                "Score" => games.OrderBy(s => s.Score),
                "Userscore_desc" => games.OrderByDescending(s => s.UserScore),
                "Userscore" => games.OrderBy(s => s.UserScore),

                _ => games.OrderBy(s => s.Game.Title),
            };
            return games.AsQueryable();
        }

        public IQueryable<GameScore> FilterByProperty(string property, string value, IQueryable<GameScore> list)
        {

            list = property switch
            {
                "" => list.OrderBy(s => s.Game.Title),
                "platform" => list.Where(s => s.Game.Platform.Name == value),
                "status" => list.Where(s => s.Game.Status.Name == value),
                "series" => list.Where(s => s.Game.Series != null && s.Game.Series.Name == value),
                "genre" => list.Where(s => s.Game.Genre.Name == value),
                "publisher" => list.Where(s => s.Game.PublisherCompany != null && s.Game.DeveloperCompany.Name == value),
                "developer" => list.Where(s => s.Game.DeveloperCompany != null && s.Game.DeveloperCompany.Name == value),
                "language" => list.Where(s => s.Game.Languages.Any(i => i.Name == value)),
                "tag" => list.Where(s => s.Game.Tags.Any(i => i.Name == value)),
                _ => list.OrderBy(s => s.Game.Title),
            };
            return list.OrderBy(s => s.Game.Title).AsQueryable();
        }
    }
}
