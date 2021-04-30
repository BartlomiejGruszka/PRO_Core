using Microsoft.EntityFrameworkCore;
using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PRO.Domain.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IGameListRepository _gameListRepository;
        public ReviewService(IReviewRepository reviewRepository, IGameListRepository gameListRepository)
        {
            _reviewRepository = reviewRepository;
            _gameListRepository = gameListRepository;
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

        public List<Tuple<Review, int?>> ReviewPlaytimeList(List<Review> reviews)
        {
            var reviewGametimes = new List<Tuple<Review, int?>>();
            foreach (var rev in reviews)
            {
                var playtime = _gameListRepository.GetGameListPlaytime(rev.GameId, rev.UserId);
                reviewGametimes.Add(new Tuple<Review, int?>(rev, playtime));
            }
            return reviewGametimes;
        }

        public List<Tuple<Review, int?>> UserPlaytimeList(int userid)
        {
            var reviews = GetUserReviews(userid);
            return ReviewPlaytimeList(reviews);
        }

        public List<Tuple<Review, int?>> GamePlaytimeList(int gameid)
        {
            var reviews = GetGameReviews(gameid);
            return ReviewPlaytimeList(reviews);
        }
    }
}
