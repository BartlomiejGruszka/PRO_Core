using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
        [Authorize(Roles = "Admin")]
        [Route("gamelists/manage")]
        public ActionResult Manage(int? page, int? items, string sortOrder, string currentFilter)
        {
            ViewData["UserSortParm"] = String.IsNullOrEmpty(sortOrder) ? "user_desc" : "";
            ViewData["GameSortParm"] = sortOrder == "game" ? "game_desc" : "game";
            ViewData["AddDateSortParm"] = sortOrder == "adddate" ? "adddate_desc" : "adddate";
            ViewData["EditDateSortParm"] = sortOrder == "editdate" ? "editdate_desc" : "editdate";
            ViewData["ScoreSortParm"] = sortOrder == "score" ? "score_desc" : "score";
            ViewData["HoursSortParm"] = sortOrder == "hours" ? "hours_desc" : "hours";
            ViewData["ListSortParm"] = sortOrder == "list" ? "list_desc" : "list";

            var gameLists = _gameListService.FilterSearch(currentFilter);
            gameLists = _gameListService.SortList(sortOrder, gameLists);

            var result = PaginatedList<GameList>.Create(gameLists.AsNoTracking(), page, items);
            result.Pagination.Configure(
                this.ControllerContext.ActionDescriptor.ActionName.ToString(), currentFilter, sortOrder);
            return View(result);
        }

        // GET: GameLists/Details/5
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        [Route("gamelists/add")]
        public ActionResult Add()
        {
            ViewBag.userList = _userService.GetUserIdNamesList(null);
            ViewBag.Games = _gameService.GetAllActive();
            return View(new GameList());
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [Route("gamelists/getuserlists/{id}")]
        public ActionResult GetUserLists(int id)
        {
            List<UserList> userLists = _userListService.GetAll().Where(s => s.UserId == id).ToList();
            SelectList viewLists = new SelectList(userLists, "Id", "Name", 0);
            return Json(viewLists);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [Route("gamelists/add")]
        [ValidateAntiForgeryToken]
        public ActionResult Add([Bind("HoursPlayed, PersonalScore,GameId,UserListId")] GameList gameList)
        {
            var validate = _gameListService.ValidateGameList(gameList);
            ModelState.Merge(validate);
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
            ViewBag.userList = _userService.GetUserIdNamesList(null);
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

        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        [Route("gamelists/edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind("Id, HoursPlayed, PersonalScore,GameId,UserListId")] GameList gameList)
        {
            var validate = _gameListService.ValidateGameList(gameList);
            ModelState.Merge(validate);

            if (ModelState.IsValid)
            {
                _gameListService.Update(gameList);

                return RedirectToAction("Manage");
            }
            var gameListUser = _gameListService.Find(gameList.Id);
            gameList.UserList = gameListUser.UserList;

            ViewBag.userLists = _userListService.GetAll().Where(u => u.UserId == gameListUser.UserList.UserId).ToList();
            ViewBag.Games = _gameService.GetAllActive();

            return View(gameList);
        }

        [Authorize(Roles = "Admin")]
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

        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [Route("gamelists/delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var gameList = _gameListService.Find(id);
            _gameListService.Delete(gameList);
            return RedirectToAction("Manage");
        }

        [Authorize]
        [HttpPost]
        [Route("gamelists/useredit")]
        [ValidateAntiForgeryToken]
        public ActionResult UserEdit(GameList model)
        {
            var previouspage = HttpContext.Request.Headers["Referer"];
            TempData.Put("gameList", model);

            var errors = _gameListService.ValidateGameList(model);
            ModelState.Merge(errors);
            if (ModelState.IsValid)
            {
                _gameListService.AddOrUpdate(model);
                TempData.Clear();
                return RedirectToAction("GameLists", "Users");
            }

            return Redirect(previouspage);
        }

        [HttpPost, ActionName("Delete")]
        [Authorize]
        [Route("gamelists/userdelete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult UserDelete(int id)
        {
            if (!_gameListService.UserDelete(id))
            {
                return NotFound();
            }
            return RedirectToAction("GameLists", "Users");
        }
    }
}
