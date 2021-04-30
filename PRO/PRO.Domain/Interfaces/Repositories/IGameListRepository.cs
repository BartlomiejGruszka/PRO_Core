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
        public int? GetGameListPlaytime(int gameid, int userid);
    }
}
