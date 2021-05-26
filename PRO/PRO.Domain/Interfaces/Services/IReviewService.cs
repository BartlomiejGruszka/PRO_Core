using Microsoft.AspNetCore.Mvc.ModelBinding;
using PRO.Domain.HelperClasses;
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
        public IQueryable<Review> GetAllSorted(string sortOrder);
        public Review Find(int? id);
        public void Add(Review review);
        public void Delete(Review review);

        public void Update(Review review);
        public IEnumerable<Review> GetRecentReviews();
        public List<Review> GetUserReviews(int? id);
        public List<Review> GetGameReviews(int id);
        public List<ReviewPlaytime> ReviewPlaytimeList(List<Review> reviews);
        public List<ReviewPlaytime> UserPlaytimeList(int userid);
        public List<ReviewPlaytime> GamePlaytimeList(int gameid);
        public ModelStateDictionary ValidateReview(Review review);
    }
}
