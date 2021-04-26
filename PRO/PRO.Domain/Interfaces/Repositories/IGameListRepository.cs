using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Repositories
{

    public interface IGameListRepository : IRepository<GameList>
    {

        public new IEnumerable<GameList> GetAll();
        public GameList FindByGameReview(int gameid, int userid);
    }
}
