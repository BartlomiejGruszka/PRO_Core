using Microsoft.AspNetCore.Mvc;
using PRO.Domain.Extensions;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Linq;

namespace PRO.UI.ViewComponents
{
    public class UserReviewViewComponent : ViewComponent
    {
        private readonly IUserService _userService;
        private readonly IReviewService _reviewService;
        private readonly IGameListService _gameListService;

        public UserReviewViewComponent(
            IUserService userService,
            IGameListService gameListService,
            IReviewService reviewService
            )
        {
            _userService = userService;
            _reviewService = reviewService;
            _gameListService = gameListService;
        }
        public IViewComponentResult Invoke(int gameid, int? reviewid)
        {

            if (reviewid == null) reviewid = -1;
            var review = TempData.Get<Review>("userReview");
            if (review != null)
            {
                var errors = _reviewService.ValidateReview(review);
                ModelState.Merge(errors);
            }
            if (review == null && reviewid <= 0)
            {
                review = _reviewService.GetUserGameReview(_userService.GetLoggedInUserId(), gameid);
              
            }
            if (review == null && reviewid > 0)
            {
                review = _reviewService.Find(reviewid);

            }
            if (review != null)
            {
                ViewBag.ReviewId = review.Id;
            }

            if (review == null) review = new Review();

            ViewBag.GameId = gameid;

            return View("_UserReview", review);
        }

    }
}
