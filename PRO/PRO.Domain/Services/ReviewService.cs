using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using PRO.Domain.HelperClasses;
using PRO.Domain.Interfaces.Repositories;
using PRO.Domain.Interfaces.Services;
using PRO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using PRO.Domain.ExternalAPI.SteamAPI.Interfaces;

namespace PRO.Domain.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IGameListRepository _gameListRepository;
        private readonly IGameRepository _gameRepository;
        private readonly IUserService _userService;
        private readonly ISteamApi _steamApi;
        public ReviewService(
            IReviewRepository reviewRepository, 
            IGameListRepository gameListRepository, 
            IGameRepository gameRepository,
            IUserService userService,
            ISteamApi steamApi
            )
        {
            _reviewRepository = reviewRepository;
            _gameListRepository = gameListRepository;
            _gameRepository = gameRepository;
            _gameRepository = gameRepository;
            _userService = userService;
            _steamApi = steamApi;
        }

        public void Add(Review review)
        {
            review.ReviewDate = DateTime.Now;
            var game = _gameRepository.Find(review.GameId);
            review.IsVerifiedOwner = _steamApi.CheckAppOwnershipAsync(review.UserId, game.SteamAppId).Result;
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
            var game = _gameRepository.Find(review.GameId);
            review.IsVerifiedOwner = _steamApi.CheckAppOwnershipAsync(review.UserId, game.SteamAppId).Result;
            _reviewRepository.Update(review);
            _reviewRepository.Save();
        }
        public Review Moderate(Review review, int userid)
        {
            review.ModeratorId = userid;
            return review;
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
            var reviewPlaytimes = new List<ReviewPlaytime>();
            foreach (var rev in reviews)
            {
                var playtime = _gameListRepository.GetGameListPlaytime(rev.GameId, rev.UserId);
                reviewPlaytimes.Add(new ReviewPlaytime { Review = rev, Playtime = playtime });
            }
            return reviewPlaytimes;
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

            var game = _gameRepository.Find(review.GameId);
            if(game != null && game.Status.AllowReviews == false)
            {
                errors.TryAddModelError("", "Status tej gry nie pozwala na napisanie recenzji");
            }
            return errors;
        }

        public IQueryable<Review> FilterSearch(string query)
        {
            var reviews = GetAll().AsQueryable();
            if (!string.IsNullOrEmpty(query))
            {
                reviews = reviews.Where(s =>
                s.User.UserName.ToLower().Contains(query.ToLower()) ||
                s.Game.Title.ToLower().Contains(query.ToLower())
                );
            }
            return reviews;
        }

        public IQueryable<Review> SortList(string sortOrder, IQueryable<Review> reviews)
        {
            reviews = sortOrder switch
            {
                "date_desc" => reviews.OrderByDescending(s => s.ReviewDate),
                "" => reviews.OrderBy(s => s.ReviewDate),
                "game_desc" => reviews.OrderByDescending(s => s.Game.Title),
                "game" => reviews.OrderBy(s => s.Game.Title),
                "user_desc" => reviews.OrderByDescending(s => s.User.UserName),
                "user" => reviews.OrderBy(s => s.User.UserName),
                "editdate_desc" => reviews.OrderByDescending(s => s.EditDate),
                "editdate" => reviews.OrderBy(s => s.EditDate),
                _ => reviews.OrderBy(s => s.ReviewDate),
            };
            return reviews.AsQueryable();
        }

        public Review SetValues(Review review, int? userid)
        {
            review.ReviewDate = DateTime.Now;
            review.EditDate = null;
            review.ModeratorId = null;
            if (userid.HasValue)
                review.UserId = userid.Value;
            return review;
        }

        public bool UserDelete(int id)
        {
            Review review = Find(id);
            var IsOwner = _userService.IsOwner(review?.UserId);
            if (!IsOwner || review == null) return false;
            Delete(review);
            return true;
        }

        public PaginatedList<ReviewPlaytime> VerifyGameOwnership(PaginatedList<ReviewPlaytime> paginatedreviews)
        {
            foreach (var paginatedreview in paginatedreviews)
            {
                if (paginatedreview.Review != null && paginatedreview.Review?.Game != null)
                    // paginatedreview.VerifiedOwner = _steamApi.CheckAppOwnershipAsync(paginatedreview.Review.UserId, paginatedreview.Review.Game.SteamAppId).Result;
                    paginatedreview.VerifiedOwner = paginatedreview.Review.IsVerifiedOwner;
                           
            }
            return paginatedreviews;
        }

        public PaginatedList<ReviewPlaytime> PrepareReviews(List<Review> reviews, int? page, int? items)
        {
            var reviewplaytimes = ReviewPlaytimeList(reviews).AsQueryable();
            var paginatedreviews = PaginatedList<ReviewPlaytime>.Create(reviewplaytimes.AsNoTracking(), page, items);
            var verifiedreviews = VerifyGameOwnership(paginatedreviews);
            return verifiedreviews;

        }
    }
}
