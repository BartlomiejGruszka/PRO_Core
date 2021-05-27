using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Repositories
{

    public interface ISeriesRepository : IRepository<Series>
    {

        public new IEnumerable<Series> GetAll();
        public new Series Find(int? id);
    }
}
