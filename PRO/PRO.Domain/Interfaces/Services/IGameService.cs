using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Services
{
    public interface IGameService
    {

        Task<IEnumerable<Game>> GetGamesAsync();
        List<Game> GetAll();
        Task AddGameAsync(Game newGame);
    }
}
