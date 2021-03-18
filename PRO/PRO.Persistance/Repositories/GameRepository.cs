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
    public class GameRepository :IGameRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public GameRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task Add(Game newElement)
        {
            throw new NotImplementedException();
        }

        public Task<Game> Find(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Game> Get(Func<Game, bool> wherePredicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Game> GetAll()
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
                 .Include(a=>a.GameLanguages)
                 .Include(a=>a.GameTags);

            var languages = _dbContext.GameLanguage.ToList();
            var tags = _dbContext.GameTag.ToList();
            

            return games;
        }

        public Task<IEnumerable<Game>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public void Remove(Game elementToRemove)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }
    }
}
