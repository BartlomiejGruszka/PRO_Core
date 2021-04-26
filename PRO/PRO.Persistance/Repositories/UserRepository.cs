using Microsoft.EntityFrameworkCore;
using PRO.Domain.Interfaces.Repositories;
using PRO.Entities;
using PRO.Persistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Persistance.Repositories
{

    public class UserRepository : BaseRepository<ApplicationUser>, IUserRepository
    {

        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public new IEnumerable<ApplicationUser> GetAll()
        {
            var users = _dbContext.ApplicationUsers
               .Include(o => o.Image)
               .ToList();
            return users;
        }

    }
}
