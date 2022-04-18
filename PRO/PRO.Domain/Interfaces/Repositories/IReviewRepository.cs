using PRO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Repositories
{

    public interface IReviewRepository : IRepository<Review>
    {

        public new IEnumerable<Review> GetAll();
        public new void Update(Review review);
    }
}
