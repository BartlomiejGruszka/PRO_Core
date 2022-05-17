using PRO.Domain.Extensions;
using PRO.Domain.HelperClasses;
using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        private readonly IRepository<GameLanguage> _gamelanguageRepository;
        private readonly IRepository<GameTag> _gametagRepository;
        public GameService(
            IGameRepository gameRepository,
            IImageRepository imageRepository,
            IGameListRepository gameListRepository,
            IRepository<Language> languageRepository,
            IRepository<Tag> tagRepository,
            IRepository<GameLanguage> gamelanguageRepository,
            IRepository<GameTag> gametagRepository)
        {
            _gameRepository = gameRepository;
            _gameListRepository = gameListRepository;
            _languageRepository = languageRepository;
            _tagRepository = tagRepository;
            _imageRepository = imageRepository;
            _gamelanguageRepository = gamelanguageRepository;
            _gametagRepository = gametagRepository;
        }
        public void Add(Game newGame)
        {
            _gameRepository.Add(newGame);

            _gameRepository.Save();
        }

        public void Delete(Game game)
        {
            _gameRepository.Remove(game);
            _gameRepository.Save();
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
            return _gameRepository.Get(i => i.IsActive == true).ToList();
        }

        public void Update(Game game)
        {
            _gameRepository.Update(game);
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

        public void UpdateTags(Game game, IEnumerable<int> selectedTagsId)
        {
            IEnumerable<GameTag> currentGameTags = _gametagRepository.Get(g => g.GameId == game.Id);
            IEnumerable<GameTag> formGameTags = new List<GameTag>();
            if (!selectedTagsId.IsNullOrEmpty())
            {
                foreach (var item in selectedTagsId)
                {
                    formGameTags = formGameTags.Append(new GameTag { GameId = game.Id, TagId = item });
                }
            }
            var removedGameTags = currentGameTags.Except(formGameTags);
            var newGameTags = formGameTags.Except(currentGameTags);

            if (!removedGameTags.IsNullOrEmpty())
            {
                foreach (var gametag in removedGameTags)
                {
                    _gametagRepository.Remove(gametag);
                }
            }
            if (!newGameTags.IsNullOrEmpty())
            {
                foreach (var gametag in newGameTags)
                {
                    _gametagRepository.Add(gametag);
                }
            }

            _gametagRepository.Save();

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

        public void UpdateLanguages(Game game, IEnumerable<int> selectedLanguagesId)
        {
            IEnumerable<GameLanguage> currentGameLanguages = _gamelanguageRepository.Get(g => g.GameId == game.Id);
            IEnumerable<GameLanguage> formGameLangauges = new List<GameLanguage>();
            if (!selectedLanguagesId.IsNullOrEmpty())
            {
                foreach (var item in selectedLanguagesId)
                {
                    formGameLangauges = formGameLangauges.Append(new GameLanguage { GameId = game.Id, LanguageId = item });
                }
            }

            var removedGameLanguages = currentGameLanguages.Except(formGameLangauges);
            var newGameLanguages = formGameLangauges.Except(currentGameLanguages);
            if (!removedGameLanguages.IsNullOrEmpty())
            {
                foreach (var gamelanguage in removedGameLanguages)
                {
                    _gamelanguageRepository.Remove(gamelanguage);
                }
            }
            if (!newGameLanguages.IsNullOrEmpty())
            {
                foreach (var gamelanguage in newGameLanguages)
                {
                    _gamelanguageRepository.Add(gamelanguage);
                }
            }

            _gamelanguageRepository.Save();

        }

        public IEnumerable<Game> GetComingGames()
        {
            return GetAllActive().Where(a => a.ReleaseDate > DateTime.Now).OrderBy(a => a.ReleaseDate).Take(3);
        }
        public IEnumerable<Game> GetRecentlyReleased()
        {
            return GetAllActive().Where(a => a.ReleaseDate < DateTime.Now).OrderByDescending(a => a.ReleaseDate).Take(4);
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

        public List<GameScore> GetUnorderedGamesRanking()
        {
            var images = _imageRepository.GetAll();
            var ranking = GetAllActive()
              .Select(c => new GameScore { Game = c, Score = c.GameLists.Average(p => p.PersonalScore) })
              .ToList();
            return ranking;
        }
        public List<GameScore> GetUnorderedGamesRanking(IQueryable<Game> games)
        {
            if (games == null) return GetUnorderedGamesRanking();
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
        public List<GamePopularity> GetGamesByPopularity()
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
                .Select(c => new GamePopularity { Game = c.game, Popularity = c.count })
                .ToList();

            var games = GetAllActive().Where(g => !g.GameLists.Any()).ToList();
            foreach (Game game in games)
            {
                popularity.Add(new GamePopularity { Game = game, Popularity = null });
            }


            return popularity;
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
            return games.FindIndex(s => s.Game.Id == gameid) + 1;
        }

        public IQueryable<Game> Filter(bool active, string text)
        {
            return Filter(active, text, null, null, null, null, null, null, null, null);
        }

        public IQueryable<Game> Filter(bool active, string text,
               int[] Plat,
               int[] Stat,
               int[] Genr,
               int[] Seri,
               int[] Publ,
               int[] Deve,
               int[] Lang,
               int[] Tags)
        {
            IQueryable<Game> games = Enumerable.Empty<Game>().AsQueryable();

            if (active) { games = GetAllActive().AsQueryable(); }
            else { games = GetAll().AsQueryable(); }

            if (!Plat.IsNullOrEmpty())
            {
                games = games.Where(s => Plat.Contains(s.PlatformId));
            }
            if (!Stat.IsNullOrEmpty())
            {
                games = games.Where(s => Stat.Contains(s.StatusId));
            }
            if (!Genr.IsNullOrEmpty())
            {
                games = games.Where(s => Genr.Contains(s.GenreId));
            }
            if (!Seri.IsNullOrEmpty())
            {
                games = games.Where(s => s.SeriesId.HasValue && Seri.Contains(s.SeriesId.Value));
                var test2 = games.Any();
            }
            if (!Publ.IsNullOrEmpty())
            {
                games = games.Where(s => s.PublisherId.HasValue && Publ.Contains(s.PublisherId.Value));
            }
            if (!Deve.IsNullOrEmpty())
            {
                games = games.Where(s => s.DeveloperId.HasValue && Deve.Contains(s.DeveloperId.Value));
            }
            if (!Lang.IsNullOrEmpty())
            {
                games = games.Where(game => game.Languages.Where(lan => Lang.Contains(lan.Id)).Any());
            }
            if (!Tags.IsNullOrEmpty())
            {
                games = games.Where(game => game.Tags.Where(tag => Tags.Contains(tag.Id)).Any());
            }
            if (!string.IsNullOrEmpty(text))
            {
                text = text.ToLower();
                games = games.Where(s =>
                    s.Title.ToLower().Contains(text)
                    ||
                    s.Description.ToLower().Contains(text)
                    );
            }

            return games;
        }

        public IQueryable<GameScore> SortList(string sortOrder, IQueryable<GameScore> games)
        {
            games = sortOrder switch
            {
                "Title_desc" => games.OrderByDescending(s => s.Game.Title),
                "" => games.OrderBy(s => s.Game.Title),
                "Platform_desc" => games.OrderByDescending(s => s.Game.Platform.Name),
                "Platform" => games.OrderBy(s => s.Game.Platform.Name),
                "Date_desc" => games.OrderBy(s => s.Game.ReleaseDate.HasValue).ThenByDescending(s => s.Game.ReleaseDate),
                "Date" => games.OrderByDescending(s => s.Game.ReleaseDate.HasValue).ThenBy(s => s.Game.ReleaseDate),
                "Status_desc" => games.OrderByDescending(s => s.Game.Status.Name),
                "Status" => games.OrderBy(s => s.Game.Status.Name),
                "Score_desc" => games.OrderBy(s => s.Score.HasValue).ThenBy(s => s.Score),
                "Score" => games.OrderBy(s => s.Score.HasValue).OrderByDescending(s => s.Score),
                "Userscore_desc" => games.OrderByDescending(s => s.UserScore.HasValue).ThenBy(s => s.UserScore),
                "Userscore" => games.OrderBy(s => s.UserScore.HasValue).ThenByDescending(s => s.UserScore),
                "Genre_desc" => games.OrderByDescending(s => s.Game.Genre.Name),
                "Genre" => games.OrderBy(s => s.Game.Genre.Name),
                "Publisher_desc" => games.OrderBy(s => s.Game.PublisherId.HasValue).ThenByDescending(s => s.Game.PublisherCompany != null ? s.Game.PublisherCompany.Name : ""),
                "Publisher" => games.OrderByDescending(s => s.Game.PublisherId.HasValue).ThenBy(s => s.Game.PublisherCompany != null ? s.Game.PublisherCompany.Name : ""),
                "Developer_desc" => games.OrderBy(s => s.Game.DeveloperId.HasValue).ThenByDescending(s => s.Game.DeveloperCompany != null ? s.Game.DeveloperCompany.Name : ""),
                "Developer" => games.OrderByDescending(s => s.Game.DeveloperId.HasValue).ThenBy(s => s.Game.DeveloperCompany != null ? s.Game.DeveloperCompany.Name : ""),
                "Series_desc" => games.OrderBy(s => s.Game.SeriesId.HasValue).ThenByDescending(s => s.Game.Series != null ? s.Game.Series.Name : ""),
                "Series" => games.OrderByDescending(s => s.Game.SeriesId.HasValue).ThenBy(s => s.Game.Series != null ? s.Game.Series.Name : ""),

                _ => games.OrderBy(s => s.Game.Title),
            };
            return games.AsQueryable();
        }
    }
}
