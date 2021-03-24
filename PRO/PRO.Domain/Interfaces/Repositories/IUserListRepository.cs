using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Repositories
{

    public interface IUserListRepository : IRepository<UserList>
    {

        public new IEnumerable<UserList> GetAll();
    }
}
