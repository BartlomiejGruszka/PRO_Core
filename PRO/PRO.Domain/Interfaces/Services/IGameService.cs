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
        List<Tuple<Game, double?>> GetUnorderedGamesRanking();
        List<Tuple<Game, double?>> GetHighestRatedGames(int? number);
        List<Game> FilterGames(string query);
        void Update(Game game);
    }
}
