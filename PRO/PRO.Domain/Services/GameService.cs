using PRO.Domain.Extensions;
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
            return _gameRepository.GetAll().Where(a => a.ReleaseDate > DateTime.Now).OrderBy(a => a.ReleaseDate).Take(3);
        }

        public List<Tuple<Game, double?>> GetHighestRatedGames(int? number)
        {
            var orderedRanking = GetUnorderedGamesRanking().OrderByDescending(o => o.Item2).ThenByDescending(d => d.Item1.ReleaseDate).ToList();
            if (number.HasValue)
            {
                return orderedRanking.Take(number.Value).ToList();
            }
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

            var games = GetAllActive().Where(g => !g.GameLists.Any()).ToList();
            foreach (Game game in games)
            {
                ranking.Add(new Tuple<Game, double?>(game, null));
            }



            return ranking;
        }

        public List<Game> FilterGames(string query)
        {
            var filteredgames = GetAllActive()
                .Where(g =>
                g.Title.CaseInsensitiveContains(query) ||
                g.Description.CaseInsensitiveContains(query) ||
                g.DeveloperCompany.Name.CaseInsensitiveContains(query) ||
                g.PublisherCompany.Name.CaseInsensitiveContains(query) ||
                g.Status.Name.CaseInsensitiveContains(query)
                ).ToList();
            return filteredgames;
        }

        public void Update(Game game)
        {
            _gameRepository.Update(game);
            _gameRepository.Save();
        }
    }
}
