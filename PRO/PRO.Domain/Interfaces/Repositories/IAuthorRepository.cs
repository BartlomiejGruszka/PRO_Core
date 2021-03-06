using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Repositories
{

    public interface IAuthorRepository : IRepository<Author>
    {

        public new IEnumerable<Author> GetAll();
    }
}
