﻿using Microsoft.AspNetCore.Mvc;
using PRO.Domain.Extensions;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System.Linq;

namespace PRO.UI.ViewComponents
{
    public class NewReviewViewComponent : ViewComponent
    {
        private readonly IUserService _userService;
        private readonly IReviewService _reviewService;
        private readonly IGameListService _gameListService;

        public NewReviewViewComponent(
            IUserService userService,
            IGameListService gameListService,
            IReviewService reviewService
            )
        {
            _userService = userService;
            _reviewService = reviewService;
            _gameListService = gameListService;
        }
        public IViewComponentResult Invoke(int gameid)
        {
          

            var review = TempData.Get<Review>("newReview");
            if (review != null)
            {
                var errors = _reviewService.ValidateReview(review);
                ModelState.Merge(errors);
            }
            if (review == null) review = new Review();

            ViewBag.GameId = gameid;

            return View("_NewReview", review);
        }

    }
}
