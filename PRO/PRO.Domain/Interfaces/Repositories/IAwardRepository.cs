using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Repositories
{

    public interface IAwardRepository : IRepository<Award>
    {

        public new IEnumerable<Award> GetAll();
        public new Award Find(int? id);
    }
}
