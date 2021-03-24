using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Repositories
{

    public interface IPlatformRepository : IRepository<Platform>
    {

        public new IEnumerable<Platform> GetAll();
        public new Platform Find(int? id);
    }
}
