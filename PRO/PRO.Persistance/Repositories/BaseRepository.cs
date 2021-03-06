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
       public readonly ApplicationDbContext _dbContext;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public T Find(int? id)
        {
            if (!id.HasValue) return null;
            var item = _dbContext.Set<T>().Find(id.Value);

            return item;
        }

        public IEnumerable<T> Get(Func<T, bool> wherePredicate)
        {
            return _dbContext.Set<T>().Where(wherePredicate).ToList();
        }

        public void Add(T newElement)
        {
            _dbContext.Set<T>().Add(newElement);
        }

        public void Remove(T elementToRemove)
        {
            _dbContext.Set<T>().Remove(elementToRemove);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            if (_dbContext != null)
                _dbContext.Dispose();
        }

        public void Update(T updatedElement)
        {
            //  var old = _dbContext.Set<T>().Find(updatedElement);
            //  _dbContext.Entry(old).CurrentValues.SetValues(updatedElement);
            _dbContext.ChangeTracker.Clear();
            _dbContext.Attach(updatedElement);
            _dbContext.Entry(updatedElement).State = EntityState.Modified;
        }

    }
}
