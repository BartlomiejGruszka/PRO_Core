using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRO.Domain.Extensions;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System;
using System.Linq;

namespace PRO.Controllers
{
    //[Authorize]
    public class ReviewsController : Controller
    {
        private readonly IGameService _gameService;
        private readonly IReviewService _reviewService;
        private readonly IUserService _userService;

        public ReviewsController(
            IGameService gameService,
            IReviewService reviewService,
            IUserService userService
            )
        {
            _gameService = gameService;
            _reviewService = reviewService;
            _userService = userService;
        }

        [Route("reviews/manage")]
        [Authorize(Roles ="Admin,Moderator")]
        public ActionResult Manage(
            int? page,
            int? items,
            string sortOrder,
            string currentFilter,
            string searchString
            )
        {
            if (String.IsNullOrEmpty(sortOrder)) sortOrder = "";
                ViewData["GameSortParm"] = sortOrder.ToUpper().Contains("DESC")? "" : "DESC";
            ViewData["DateSortParm"] = sortOrder == "date" ? "date_desc" : "date";
            ViewData["UserSortParm"] = sortOrder == "user" ? "user_desc" : "user";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;

            var reviews = _reviewService.GetAllSorted(sortOrder);

            if (!String.IsNullOrEmpty(searchString))
            {
                reviews = reviews.Where(s => s.Game.Title.ToUpper().Contains(searchString.ToUpper())
                                       || s.User.NormalizedUserName.Contains(searchString.ToUpper()));
            }
            return View(PaginatedList<Review>.Create(reviews.AsNoTracking(), page, items));
        }
       // [Authorize]
        [Route("reviews/{id}")]
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: reviews/Details/5
        [Route("reviews/details/{id}")]
        [Authorize(Roles = "Admin,Moderator")]
        public ActionResult ManageDetails(int? id)
        {
            Review review = _reviewService.Find(id);
            if (review == null)
            {
                return NotFound();
            }
            return View(review);
        }

        [Authorize]
        [Route("reviews/new/{id}")]
        public ActionResult New(int id)
        {
            var review = new Review
            {
                GameId = id
            };

            return View(review);
        }

        [Authorize]
        [HttpPost]
        [Route("reviews/new")]
        [ValidateAntiForgeryToken]
        public ActionResult New(Review review)
        {
            review.ReviewDate = DateTime.Now;
            review.EditDate = null;
            review.ModeratorId = null;
            review.UserId = _userService.GetLoggedInUserId().Value;
            if (ModelState.IsValid)
            {
                var errors = _reviewService.ValidateReview(review);
                if (!errors.Any())
                {
                    _reviewService.Add(review);

                    return RedirectToAction("?");
                }
                ModelState.Merge(errors);
            }
            return View(review);
        }



        [Route("reviews/add")]
        [Authorize(Roles = "Admin,Moderator")]
        public ActionResult Add()
        {
            ViewBag.GameId = _gameService.GetAllActive().ToList();
            return View();
        }

        [HttpPost]
        [Route("reviews/add")]
        [Authorize(Roles = "Admin,Moderator")]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Review review)
        {
            review.ReviewDate = DateTime.Now;
            review.EditDate = null;
            review.ModeratorId = null;
            review.UserId = _userService.GetLoggedInUserId().Value;
            if (ModelState.IsValid)
            {
                var errors = _reviewService.ValidateReview(review);
                if (!errors.Any())
                {
                    _reviewService.Add(review);

                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
            }
            ViewBag.GameId = _gameService.GetAllActive().ToList();
            return View(review);
        }

        [Route("reviews/edit/{id}")]
        [Authorize(Roles = "Admin,Moderator")]
        public ActionResult Edit(int? id)
        {
            Review review = _reviewService.Find(id);
            if (review == null)
            {
                return NotFound();
            }
            return View(review);
        }

        [HttpPost]
        [Route("reviews/edit/{id}")]
        [Authorize(Roles = "Admin,Moderator")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Review review)
        {
            if (ModelState.IsValid)
            {
                var user = _userService.Find(review.UserId);
                var loggeduser = _userService.GetLoggedInUserId();
                if (user.Id != loggeduser.Value)
                {
                    review.ModeratorId = loggeduser.Value;
                }
                review.EditDate = DateTime.Now;
                var errors = _reviewService.ValidateReview(review);
                if (!errors.Any())
                {
                    _reviewService.Update(review);

                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
            }
            return View(review);
        }

        [Authorize]
        [HttpPost]
        [Route("reviews/newreview")]
        public ActionResult NewReview(Review model)
        {
            model.UserId = _userService.GetLoggedInUserId().Value;
            model.ReviewDate = DateTime.Now;
            TempData.Put("newReview", model);

            if (ModelState.IsValid)
            {
                var errors = _reviewService.ValidateReview(model);
                if (!errors.Any())
                {
                    _reviewService.Add(model);
                    return RedirectToAction("Reviews", "Games", new { id = model.GameId});
                }

            }
             return RedirectToAction("NewReview", "Games", new { id = model.GameId }); 
        }


        [Route("reviews/delete/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            Review review = _reviewService.Find(id);
            if (review == null)
            {
                return NotFound();
            }
            return View(review);
        }

        // POST: Tags/Delete/5
        [HttpPost, ActionName("Delete")]
        [Route("reviews/delete/{id}")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Review review = _reviewService.Find(id);
            _reviewService.Delete(review);
            return RedirectToAction("Manage");
        }
    }
}