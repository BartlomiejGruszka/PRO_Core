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


        public int? GetGameListPlaytime(int gameid, int userid)
        {
            return _dbContext.GameLists
                .Include(i => i.UserList)
                .Where(f => f.GameId == gameid && f.UserList.UserId == userid)
                .Select(s=>s.HoursPlayed)
                .FirstOrDefault();
        }
        public new IEnumerable<GameList> GetAll()
        {   
            return _dbContext.GameLists
                .Include(i => i.Game)
                .Include(i => i.Game.Image)
                .Include(i => i.Game.DeveloperCompany)
                .Include(u=>u.UserList)
                .Include(u => u.UserList.User)
                .Include(u => u.UserList.ListType);
        }
        public new GameList Find(int? id)
        {
            if (!id.HasValue) { return null; }
            var gameList = _dbContext.GameLists
              .Include(g => g.Game)
              .Include(i => i.Game.Image)
              .Include(g => g.UserList)
              .Include(g => g.UserList.User)
              .Include(u => u.UserList.ListType)
              .SingleOrDefault(g => g.Id == id.Value);

            return gameList;
        }
    }
}
