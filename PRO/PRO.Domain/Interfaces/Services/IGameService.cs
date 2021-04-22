using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Services
{
    public interface IGameService
    {

        IEnumerable<Game> GetGames();
        IEnumerable<Game> GetComingGames();
        IEnumerable<Game> GetAll();
        void AddGame(Game newGame);
        List<Tuple<Game, double?>> GetUnorderedGamesRanking();
        List<Tuple<Game, double?>> GetHighestRatedGames(int number);
    }
}
