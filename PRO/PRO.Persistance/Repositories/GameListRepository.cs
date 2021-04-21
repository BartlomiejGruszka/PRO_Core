using Microsoft.EntityFrameworkCore;
using PRO.Domain.Interfaces.Repositories;
using PRO.Entities;
using PRO.Persistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Persistance.Repositories
{
    public class GameListRepository : BaseRepository<GameList>, IGameListRepository
    {

        public GameListRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }


        public new Game Find(int? id)
        {
            return null;
        }
        public new IEnumerable<GameList> GetAll()
        {
            var images = _dbContext.Images.ToList();
            var games = _dbContext.GameLists
                 .Include(i => i.Game);

            return games;
        }

    }
}
