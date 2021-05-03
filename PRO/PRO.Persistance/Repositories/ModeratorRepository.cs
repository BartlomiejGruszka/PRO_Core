using Microsoft.EntityFrameworkCore;
using PRO.Domain.Interfaces.Repositories;
using PRO.Entities;
using PRO.Persistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Persistance.Repositories
{

    public class ModeratorRepository : BaseRepository<Moderator>, IModeratorRepository
    {

        public ModeratorRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public new IEnumerable<Moderator> GetAll()
        {
            var users = _dbContext.Moderators
               .Include(o => o.User)
               .ToList();
            return users;
        }
        public Moderator Find(int id)
        {
            return _dbContext.Moderators.Include(i=>i.User).SingleOrDefault(u => u.UserId == id);
        }

    }
}
