using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Repositories
{

    public interface IGameRepository :IRepository<Game>
    {

        public IEnumerable<Game> GetAll();
    }
}
