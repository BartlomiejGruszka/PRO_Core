using Microsoft.AspNetCore.Mvc.ModelBinding;
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
        public IEnumerable<Review> GetRecentReviews();
        public List<Review> GetUserReviews(int? id);
        public List<Review> GetGameReviews(int id);
        public List<Tuple<Review, int?>> ReviewPlaytimeList(List<Review> reviews);
        public List<Tuple<Review, int?>> UserPlaytimeList(int userid);
        public List<Tuple<Review, int?>> GamePlaytimeList(int gameid);
        public ModelStateDictionary ValidateReview(Review review);
    }
}
