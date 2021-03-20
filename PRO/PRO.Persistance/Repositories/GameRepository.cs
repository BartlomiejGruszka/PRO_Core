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
                 .Include(a => a.GameLanguages)
                 .Include(a => a.GameTags);

            var languages = _dbContext.GameLanguage.ToList();
            var tags = _dbContext.GameTag.ToList();


            return games;
        }

    }
}
