using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using PRO.Domain.HelperClasses;
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
            review.ReviewDate = DateTime.Now;
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
            review.EditDate = DateTime.Now;
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
            var reviews = _reviewRepository.GetAll().Where(i => i.UserId == id.Value).ToList();
            return reviews;
        }
        public Review GetUserGameReview(int? userid, int? gameid) {
            if (!userid.HasValue || !gameid.HasValue) { return null; }
            var review = _reviewRepository.GetAll().SingleOrDefault(i => i.UserId == userid.Value && i.GameId == gameid.Value);

            return review;
        }
        public List<Review> GetGameReviews(int id)
        {
            var reviews = _reviewRepository.GetAll().Where(c => c.GameId == id).ToList();
            return reviews;
        }

        public List<ReviewPlaytime> ReviewPlaytimeList(List<Review> reviews)
        {
            var reviewGametimes = new List<ReviewPlaytime>();
            foreach (var rev in reviews)
            {
                var playtime = _gameListRepository.GetGameListPlaytime(rev.GameId, rev.UserId);
                reviewGametimes.Add(new ReviewPlaytime { Review = rev, Playtime = playtime });
            }
            return reviewGametimes;
        }

        public List<ReviewPlaytime> UserPlaytimeList(int userid)
        {
            var reviews = GetUserReviews(userid);
            return ReviewPlaytimeList(reviews);
        }

        public List<ReviewPlaytime> GamePlaytimeList(int gameid)
        {
            var reviews = GetGameReviews(gameid);
            return ReviewPlaytimeList(reviews);
        }

        public ModelStateDictionary ValidateReview(Review review)
        {
            ModelStateDictionary errors = new ModelStateDictionary();
            if (review == null) return errors;

            var reviews = _reviewRepository.GetAll().Where(i => i.GameId == review.GameId && i.UserId == review.UserId && i.Id != review.Id);
            if (reviews.Any())
            {
                errors.TryAddModelError("GameId", "Napisałeś już recenzję dla tej gry.");
            }
            if(review.Content == null)
            {
                errors.TryAddModelError("Content", "Treść recenzji musi mieć między 10 a 5000 znaków.");
            }
            else if ( review.Content.Length < 10 && 5000 < review.Content.Length)
            {
                errors.TryAddModelError("Content", "Treść recenzji musi mieć między 10 a 5000 znaków.");
            }
            if (review.GameplayScore < 1 || review.GameplayScore > 10)
            {
                errors.TryAddModelError("GameplayScore", "Ocena grywalności musi mieć wartość od 1 do 10.");
            }
            if (review.GraphicsScore < 1 || review.GraphicsScore > 10)
            {
                errors.TryAddModelError("GraphicsScore", "Ocena grafiki musi mieć wartość od 1 do 10.");
            }
            if (review.MusicScore < 1 || review.MusicScore > 10)
            {
                errors.TryAddModelError("MusicScore", "Ocena muzyki musi mieć wartość od 1 do 10.");
            }
            if (review.StoryScore < 1 || review.StoryScore > 10)
            {
                errors.TryAddModelError("StoryScore", "Ocena fabuły musi mieć wartość od 1 do 10.");
            }
            return errors;
        }

        public IQueryable<Review> GetAllSorted(string sortOrder)
        {
            var reviews = GetAll();
            reviews = sortOrder switch
            {
                "DESCgame" => reviews.OrderByDescending(s => s.Game.Title),
                "game" => reviews.OrderBy(s => s.Game.Title),
                "DESCuser" => reviews.OrderByDescending(s => s.User.UserName),
                "user" => reviews.OrderBy(s => s.User.UserName),
                "DESCdate" => reviews.OrderByDescending(s => s.ReviewDate),
                "date" => reviews.OrderBy(s => s.ReviewDate),
                _ => reviews.OrderBy(s => s.Game.Title),
            };
            return reviews.AsQueryable();
        }
    }
}
