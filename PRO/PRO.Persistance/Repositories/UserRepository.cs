using Microsoft.EntityFrameworkCore;
using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Entities;
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
               .Include(o=>o.Moderator)
               .Include(o => o.Author)
               .ToList();
            return users;
        }
        public ApplicationUser Find(int id)
        {
            return _dbContext.ApplicationUsers
                .Include(i=>i.Image)
                .Include(i => i.Moderator)
                .SingleOrDefault(u => u.Id == id);
        }

    }
}
