using PRO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Repositories
{

    public interface IGameRepository :IRepository<Game>
    {

        public new IEnumerable<Game> GetAll();
        public new Game Find(int? id);
    }
}
