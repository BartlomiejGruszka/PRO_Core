using PRO.Domain.HelperClasses;
using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Services
{
    public interface IGameService
    {

        Game Find(int? id);
        Game FindActive(int? id);
        IEnumerable<Game> GetComingGames();
        public IEnumerable<Game> GetRecentlyReleased();
        List<Game> GetAll();
        List<Game> GetAllActive();
        void Delete(Game game);
        void Add(Game newGame);
        void AddTags(Game newGame, IEnumerable<int> selectedTagsId);
        void UpdateTags(Game game, IEnumerable<int> selectedTagsId);
        void AddLanguages(Game newGame, IEnumerable<int> selectedLanguagesId);
        void UpdateLanguages(Game game, IEnumerable<int> selectedLanguagesId);
        List<GameScore> GetUnorderedGamesRanking();
        List<GameScore> GetUnorderedGamesRanking(IQueryable<Game> games);
        List<GameScore> GetUserUnorderedGamesRanking(int? userid);
        List<GameScore> GetUserUnorderedGamesRanking(int? userid, IQueryable<Game> games);
        List<GameScore> GetOrderedGamesRanking(int? number);
        public List<Tuple<Game, int?>> GetGamesByPopularity();

        public int? GetGamePosition(int gameid);
        public double? GetGameRating(int gameid);
        public int GetGamePopularity(int gameid);

        public IQueryable<Game> Filter(bool active, string text);
        public IQueryable<Game> Filter (bool active, string text,
              int[] Plat, 
              int[] Stat,
              int[] Genr,
              int[] Seri,
              int[] Publ,
              int[] Deve,
              int[] Lang,
              int[] Tags);
        void Update(Game game);
        public IQueryable<GameScore> SortList(string sortOrder, IQueryable<GameScore> games);

    }

}
