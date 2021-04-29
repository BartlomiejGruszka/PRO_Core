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
        private readonly IReviewRepository _reviewRepository;
        public ReviewService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public void Add(Review review)
        {
            _reviewRepository.Add(review);
            _reviewRepository.Save();
        }

        public void Delete(Review review)
        {
            _reviewRepository.Remove(review);
            _reviewRepository.Save();
        }

        public Review Find(int? id)
        {
            if (!id.HasValue) { return null; }
            return _reviewRepository.Find(id.Value);
        }

        public IEnumerable<Review> GetAll()
        {
            return _reviewRepository.GetAll();
        }

        public void Update(Review review)
        {
            _reviewRepository.Update(review);
            _reviewRepository.Save();
        }
        public IEnumerable<Review> GetRecentReviews()
        {
            var recentReviews = _reviewRepository.GetAll()
               .Where(w => w.ReviewDate < System.DateTime.Now)
               .OrderByDescending(o => o.ReviewDate)
               .Take(5);
            return recentReviews;
        }
        public List<Review> GetUserReviews(int? id)
        {
            if (!id.HasValue) { return null; }
            return _reviewRepository.GetAll().Where(i => i.UserId == id.Value).ToList();
        }

        public List<Review> GetGameReviews(int id)
        {
            var reviews = _reviewRepository.GetAll().Where(c => c.GameId == id).ToList();
            return reviews;
        }
    }
}
