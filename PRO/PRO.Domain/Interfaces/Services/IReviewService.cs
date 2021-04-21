using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO.Domain.Interfaces.Services
{
    public interface IReviewService
    {
        public IEnumerable<Review> GetAll();
        public Review Find(int? id);
        public void Add(Review review);
        public void Delete(Review review);

        public void Update(Review review);
        IEnumerable<Review> GetRecentReviews();
    }
}
