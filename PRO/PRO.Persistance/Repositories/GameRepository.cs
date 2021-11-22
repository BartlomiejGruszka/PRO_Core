using Microsoft.EntityFrameworkCore;
using PRO.Domain.Interfaces.Repositories;
using PRO.Entities;
using PRO.Persistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Persistance.Repositories
{
    public class GameRepository : BaseRepository<Game>, IGameRepository
    {

        public GameRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }


        public new Game Find(int? id)
        {
            if (!id.HasValue) { return null; }
            var game = _dbContext.Games
         .Include(i => i.Platform)
         .Include(a => a.Genre)
         .Include(a => a.Status)
         .Include(a => a.Series)
         .Include(a => a.Series.Games)
         .Include(a => a.PublisherCompany)
         .Include(a => a.DeveloperCompany)
         .Include(a => a.Tags)
         .Include(a => a.Languages)
         .Include(a => a.Image)
         .Include(a => a.Awards)
         .Include(a => a.Reviews)
         .SingleOrDefault(g => g.Id == id.Value);

            return game;
        }
        public new IEnumerable<Game> GetAll()
        {

            var games = _dbContext.Games
                 .Include(i => i.Platform)
                 .Include(a => a.Genre)
                 .Include(a => a.Status)
                 .Include(a => a.Series)
                 .Include(a => a.PublisherCompany)
                 .Include(a => a.DeveloperCompany)
                 .Include(a => a.Image)
                 .Include(a => a.Reviews)
                 .Include(a => a.Languages)
                 .Include(a => a.Tags)
                 .Include(i => i.GameLists);

            return games;
        }
    }
}
