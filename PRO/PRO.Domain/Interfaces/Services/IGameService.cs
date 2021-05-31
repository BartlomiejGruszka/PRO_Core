using PRO.Domain.HelperClasses;
using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Services
{
    public interface IGameService
    {

        Game Find(int? id);
        Game FindActive(int? id);
        IEnumerable<Game> GetComingGames();
        List<Game> GetAll();
        List<Game> GetAllActive();
        void Delete(Game game);
        void Add(Game newGame);
        void AddTags(Game newGame, IEnumerable<int> selectedTagsId);
        void AddLanguages(Game newGame, IEnumerable<int> selectedLanguagesId);
        List<GameScore> GetUnorderedGamesRanking(); 
        List<GameScore> GetUserUnorderedGamesRanking(int? userid);

        List<GameScore> GetOrderedGamesRanking(int? number);
        public List<Tuple<Game, int?>> GetGamesByPopularity();

        public int? GetGamePosition(int gameid);
        public double? GetGameRating(int gameid);
        public int GetGamePopularity(int gameid);
        public List<GameScore> GetFilteredGamesRanking(string query);

        List<Game> FilterGames(string query);
        void Update(Game game);
    }
}
