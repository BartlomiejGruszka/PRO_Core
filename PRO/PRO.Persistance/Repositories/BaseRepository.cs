using Microsoft.EntityFrameworkCore;
using PRO.Domain.Interfaces.Repositories;
using PRO.Persistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Persistance.Repositories
{

    public class BaseRepository<T> : IRepository<T>,
                                IDisposable
                                where T : class
    {
        private readonly ApplicationDbContext _dbContext;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> Find(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public IEnumerable<T> Get(Func<T, bool> wherePredicate)
        {
            return _dbContext.Set<T>().Where(wherePredicate).ToList();
        }

        public async Task Add(T newElement)
        {
            await _dbContext.Set<T>().AddAsync(newElement);
        }

        public void Remove(T elementToRemove)
        {
            _dbContext.Set<T>().Attach(elementToRemove);
            _dbContext.Entry(elementToRemove).State = EntityState.Deleted;
        }

        public async Task Save()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            if (_dbContext != null)
                _dbContext.Dispose();
        }

    }
}
