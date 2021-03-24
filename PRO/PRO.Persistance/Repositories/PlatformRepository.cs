using Microsoft.EntityFrameworkCore;
using PRO.Domain.Interfaces.Repositories;
using PRO.Entities;
using PRO.Persistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Persistance.Repositories
{

    public class PlatformRepository : BaseRepository<Platform>, IPlatformRepository
    {

        public PlatformRepository(ApplicationDbContext dbContext):base(dbContext)
        {
        }

        public new IEnumerable<Platform> GetAll()
        {
            var platforms = _dbContext.Platforms
                .Include(i => i.Company);
            return platforms;
        }
        public new Platform Find(int? id)
        {
            return _dbContext.Platforms
                .Include(a => a.Company)
                .SingleOrDefault(a => a.Id == id);
        }
    }
}
