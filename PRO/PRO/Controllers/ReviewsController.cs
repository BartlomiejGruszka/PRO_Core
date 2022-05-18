using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRO.Domain.Extensions;
using PRO.Domain.Interfaces.Services;
using PRO.Domain.Entities;
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
        [Authorize(Roles = "Admin,Moderator")]
        public ActionResult Manage(int? page, int? items, string sortOrder, string currentFilter)
        {
            ViewData["IdSortParm"] = String.IsNullOrEmpty(sortOrder) ? "id_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "date" ? "date_desc" : "date";
            ViewData["GameSortParm"] = sortOrder == "game" ? "game_desc" : "game";
            ViewData["UserSortParm"] = sortOrder == "user" ? "user_desc" : "user";
            ViewData["EditDateSortParm"] = sortOrder == "editdate" ? "editdate_desc" : "editdate";
            var reviews = _reviewService.FilterSearch(currentFilter);
            reviews = _reviewService.SortList(sortOrder, reviews);

            var result = PaginatedList<Review>.Create(reviews.AsNoTracking(), page, items);
            result.Pagination.Configure(
                this.ControllerContext.ActionDescriptor.ActionName.ToString(), currentFilter, sortOrder);
            return View(result);
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

        [Route("reviews/add")]
        [Authorize(Roles = "Admin,Moderator")]
        public ActionResult Add()
        {
            ViewBag.returnUrl = HttpContext.Request.Headers["Referer"];
            ViewBag.GameId = _gameService.GetAllActive().ToList();
            return View();
        }

        [HttpPost]
        [Route("reviews/add")]
        [Authorize(Roles = "Admin,Moderator")]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Review review, string returnUrl = null)
        {
            ViewBag.returnUrl = returnUrl ?? Url.Content("~/");
            review = _reviewService.SetValues(review, _userService.GetLoggedInUserId().Value);
            if (ModelState.IsValid)
            {
                var errors = _reviewService.ValidateReview(review);
                if (!errors.Any())
                {
                    _reviewService.Add(review);
                    if (returnUrl != null) { return Redirect(returnUrl); }
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
                    review = _reviewService.Moderate(review, loggeduser.Value);
                }
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
        [Route("reviews/userreview")]
        public ActionResult UserReview(Review model)
        {
            var userid = _userService.GetLoggedInUserId().Value;
            if (model.UserId <= 0)
            {
                model.UserId = userid;
            }
            TempData.Put("userReview", model);

            if (ModelState.IsValid)
            {
                var errors = _reviewService.ValidateReview(model);
                if (!errors.Any())
                {
                    if (model.Id > 0)
                    {
                        if(User.IsInRole("Moderator") || User.IsInRole("Admin"))
                        {
                            model = _reviewService.Moderate(model, userid);
                        }
                        _reviewService.Update(model);

                    }
                    else
                    {
                        _reviewService.Add(model);
                    }
                    TempData.Clear();
                    return RedirectToAction("Reviews", "Games", new { id = model.GameId });
                }

            }
            return RedirectToAction("UserReview", "Games", new { id = model.GameId });
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

        [HttpPost, ActionName("Delete")]
        [Authorize]
        [Route("reviews/userdelete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult UserDelete(int id, int gameid)
        {
            if (!_reviewService.UserDelete(id))
            {
                return NotFound();
            }
            return RedirectToAction("Reviews", "Games", new {id = gameid });
        }
       

    }
}