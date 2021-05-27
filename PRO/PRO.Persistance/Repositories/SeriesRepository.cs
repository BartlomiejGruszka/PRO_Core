using Microsoft.EntityFrameworkCore;
using PRO.Domain.Interfaces.Repositories;
using PRO.Entities;
using PRO.Persistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Persistance.Repositories
{

    public class SeriesRepository : BaseRepository<Series>, ISeriesRepository
    {

        public SeriesRepository(ApplicationDbContext dbContext):base(dbContext)
        {
        }

        public new IEnumerable<Series> GetAll()
        {
            var platforms = _dbContext.Series
                .Include(i => i.Games);
            return platforms;
        }
        public new Series Find(int? id)
        {
            return _dbContext.Series
                .Include(a => a.Games)
                .SingleOrDefault(a => a.Id == id);
        }
    }
}
