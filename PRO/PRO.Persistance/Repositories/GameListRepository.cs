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


        public GameList FindByGameReview(int gameid, int userid)
        {
            return _dbContext.GameLists.Include(i => i.UserList).FirstOrDefault(f => f.GameId == gameid && f.UserList.UserId == userid);
        }
        public new IEnumerable<GameList> GetAll()
        {   
            return _dbContext.GameLists.Include(i => i.Game).Include(u=>u.UserList);
        }

    }
}
