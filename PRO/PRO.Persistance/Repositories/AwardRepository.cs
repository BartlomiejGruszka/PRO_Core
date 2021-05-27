using Microsoft.EntityFrameworkCore;
using PRO.Domain.Interfaces.Repositories;
using PRO.Entities;
using PRO.Persistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Persistance.Repositories
{

    public class AwardRepository : BaseRepository<Award>, IAwardRepository
    {

        public AwardRepository(ApplicationDbContext dbContext):base(dbContext)
        {
        }

        public new IEnumerable<Award> GetAll()
        {
            var platforms = _dbContext.Awards
                .Include(i => i.Game);
            return platforms;
        }
        public new Award Find(int? id)
        {
            return _dbContext.Awards
                .Include(a => a.Game)
                .SingleOrDefault(a => a.Id == id);
        }
    }
}
