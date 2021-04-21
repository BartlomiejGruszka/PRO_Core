using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Repositories
{

    public interface IArticleRepository : IRepository<Article>
    {

        public new IEnumerable<Article> GetAll();
        public new Article Find(int? id);
        

    }
}
