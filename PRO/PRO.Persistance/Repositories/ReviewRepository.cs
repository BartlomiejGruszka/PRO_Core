using Microsoft.EntityFrameworkCore;
using PRO.Domain.Interfaces.Repositories;
using PRO.Entities;
using PRO.Persistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Persistance.Repositories
{

    public class ReviewRepository : BaseRepository<Review>, IReviewRepository
    {

        public ReviewRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public new IEnumerable<Review> GetAll()
        {
            var reviews = _dbContext.Reviews
               .Include(o => o.Game)
               .Include(o => o.User)
               .Include(o => o.Game.Image)
               .Include(o => o.User.Image);
            return reviews;
        }

    }
}
