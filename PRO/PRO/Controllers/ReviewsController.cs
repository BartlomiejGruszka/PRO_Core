using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System;
using System.Collections.Generic;
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
        public ActionResult Manage(int? page, int? items)
        {
            var reviews = _reviewService.GetAll();
            ViewBag.Pagination = new Pagination(page, items, reviews.Count());

            return View(reviews);
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
                _reviewService.Add(review);
                return RedirectToAction("?not done yet");
            }
            return View(review);
        }



        [Route("reviews/add")]
        [Authorize(Roles = "Admin,Moderator")]
        public ActionResult Add()
        {
            ViewBag.GameId = new SelectList(_gameService.GetAllActive(), "Id", "Title");
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
            var test = _reviewService.GetAll().SingleOrDefault(i => i.UserId == review.UserId && i.GameId == review.GameId);

            if (test != null) { ModelState.AddModelError(string.Empty, "Można napisać tylko jedną recenzję dla danej gry"); }
            if (ModelState.IsValid)
            {
                _reviewService.Add(review);
                return RedirectToAction("Manage");
            }
            ViewBag.GameId = new SelectList(_gameService.GetAllActive(), "Id", "Title");
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
                _reviewService.Update(review);
               
                return RedirectToAction("Manage");
            }
            return View(review);
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