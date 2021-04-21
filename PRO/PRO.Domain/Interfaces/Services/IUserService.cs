using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Services
{
    public interface IUserService
    {
        public IEnumerable<ApplicationUser> GetAll();
        public ApplicationUser Find(int? id);
        public void Add(ApplicationUser user);
        public void Delete(ApplicationUser user);

        public void Update(ApplicationUser user);
        public int? GetLoggedInUserId();

    }
}
