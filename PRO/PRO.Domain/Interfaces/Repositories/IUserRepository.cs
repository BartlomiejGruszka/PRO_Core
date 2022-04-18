using PRO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Repositories
{

    public interface IUserRepository : IRepository<ApplicationUser>
    {

        public new IEnumerable<ApplicationUser> GetAll();
        public ApplicationUser Find(int id);
    }
}
