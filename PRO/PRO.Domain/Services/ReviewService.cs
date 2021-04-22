using Microsoft.EntityFrameworkCore;
using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Domain.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IRepository<Review> _repository;
        private readonly IReviewRepository _reviewRepository;
        public ReviewService(IRepository<Review> repository,
            IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
            _repository = repository;
        }

        public void Add(Review review)
        {
            _repository.Add(review);
            _repository.Save();
        }

        public void Delete(Review review)
        {
            _repository.Remove(review);
            _repository.Save();
        }

        public Review Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _repository.Find(id.Value);
        }

        public IEnumerable<Review> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Review review)
        {
            _repository.Update(review);
            _repository.Save();
        }
        public IEnumerable<Review> GetRecentReviews()
        {
            var recentReviews = _reviewRepository.GetAll()
               .Where(w => w.ReviewDate < System.DateTime.Now)
               .OrderByDescending(o => o.ReviewDate)
               .Take(5);
            return recentReviews;
        }
    }
}
