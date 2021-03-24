using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Repositories
{

    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Find(int? id);
        IEnumerable<T> Get(Func<T, bool> wherePredicate);
        void Add(T newElement);
        void Remove(T elementToRemove);
        void Save();
        void Update(T updatedElement);
    }
}
