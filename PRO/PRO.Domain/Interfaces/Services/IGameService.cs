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
        List<Game> GetAll();
        void AddGame(Game newGame);
    }
}
