using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PRO.Domain.Extensions;
using PRO.Domain.Interfaces.Services;
using PRO.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;

namespace PRO.Controllers
{
    [Authorize(Roles = "Admin")]
    public class GameListsController : Controller
    {
        private readonly IUserService _userService;
        private readonly IReviewService _reviewService;
        private readonly IUserListService _userListService;
        private readonly IGameListService _gameListService;
        private readonly IGameService _gameService;
        public GameListsController
            (
            IUserService userService,
            IReviewService reviewService,
            IUserListService userListService,
            IGameListService gameListService,
            IGameService gameService
            )

        {
            _userService = userService;
            _reviewService = reviewService;
            _userListService = userListService;
            _gameListService = gameListService;
            _gameService = gameService;
        }

        // GET: GameLists
        [Route("gamelists/manage")]
        public ActionResult Manage(int? page, int? items)
        {
            var gameLists = _gameListService.GetAll();

            ViewBag.Pagination = new Pagination(page, items, gameLists.Count());

            return View(gameLists);
        }

        // GET: GameLists/Details/5
        [Route("gamelists/details/{id}")]
        public ActionResult Details(int? id)
        {
            var gameList = _gameListService.Find(id);
            if (gameList == null)
            {
                return NotFound();
            }
            return View(gameList);
        }

        // GET: GameLists/Create
        [Route("gamelists/add")]
        public ActionResult Add()
        {
            ViewBag.userList = _userService.GetAll().Select(s => new { Id = s.Id, UserName = s.UserName }).ToList();
            ViewBag.Games = _gameService.GetAllActive();
            return View(new GameList());
        }
        [HttpPost]
        [Route("gamelists/getuserlists/{id}")]
        public ActionResult GetUserLists(int id)
        {
            List<UserList> userLists = _userListService.GetAll().Where(s => s.UserId == id).ToList();
            SelectList viewLists = new SelectList(userLists, "Id", "Name", 0);
            return Json(viewLists);
        }

        [HttpPost]
        [Route("gamelists/add")]
        [ValidateAntiForgeryToken]
        public ActionResult Add([Bind("Id,HoursPlayed,PersonalScore,UserListId,GameId")] GameList gameList)
        {
            if (gameList.UserListId <= 0)
            {
                ModelState.AddModelError("UserListId", "Wybierz listę użytkownika");
            }
            gameList.AddedDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                var errors = _gameListService.ValidateGameList(gameList);
                if (!errors.Any())
                {
                    _gameListService.Add(gameList);

                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
            }
            ViewBag.userList = _userService.GetAll().Select(s => new { Id = s.Id, UserName = s.UserName }).ToList();
            ViewBag.Games = _gameService.GetAllActive();

            return View(gameList);
        }

        [Authorize]
        [HttpPost]
        public ActionResult AddGameToList(GameList model)
        {
            model = _gameListService.AddOrUpdateDates(model);
            var previouspage = HttpContext.Request.Headers["Referer"];
            TempData.Put("gameList", model);

            if (ModelState.IsValid)
            {
                var errors = _gameListService.ValidateGameList(model);

                var userid = _userService.GetLoggedInUserId();
                var userlist = _userListService.Find(model.UserListId);
                if (userid != userlist.UserId) { return NotFound(); }
                if (!errors.Any())
                {
                    _gameListService.AddOrUpdate(model);
                    TempData.Add("GameListId", model.Id);
                }

            }
            if (string.IsNullOrEmpty(previouspage)) { return RedirectToAction("Details", "Games", new { id = model.GameId }); }
            return Redirect(previouspage);
        }

        // GET: GameLists/Edit/5
        [Route("gamelists/edit/{id}")]
        public ActionResult Edit(int? id)
        {
            var gameList = _gameListService.Find(id);
            if (gameList == null)
            {
                return NotFound();
            }
            ViewBag.Games = _gameService.GetAllActive();
            ViewBag.userLists = _userListService.GetAll().Where(u => u.UserId == gameList.UserList.UserId).ToList();
            return View(gameList);
        }

        [HttpPost]
        [Route("gamelists/edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind("Id,AddedDate,HoursPlayed,PersonalScore,UserListId,GameId")] GameList gameList)
        {
            gameList.EditedDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                var errors = _gameListService.ValidateGameList(gameList);
                if (!errors.Any())
                {
                    _gameListService.Update(gameList);

                    return RedirectToAction("Manage");
                }
                ModelState.Merge(errors);
            }
            var gameListUser = _gameListService.Find(gameList.Id);
            gameList.UserList = gameListUser.UserList;
            var userLists = _userListService.GetAll().Where(u => u.UserId == gameListUser.UserList.UserId).ToList();

            ViewBag.userLists = userLists;
            ViewBag.Games = _gameService.GetAllActive();

            return View(gameList);
        }

        // GET: GameLists/Delete/5
        [Route("gamelists/delete/{id}")]
        public ActionResult Delete(int? id)
        {

            var gameList = _gameListService.Find(id);
            if (gameList == null)
            {
                return NotFound();
            }
            return View(gameList);
        }

        // POST: GameLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [Route("gamelists/delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var gameList = _gameListService.Find(id);
            _gameListService.Delete(gameList);
            return RedirectToAction("Manage");
        }

    }
}
